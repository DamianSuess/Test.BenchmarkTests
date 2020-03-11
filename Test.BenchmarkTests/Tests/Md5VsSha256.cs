/* Copyright Xeno Innovations, Inc. 2020
 * Date:    2020-3-11
 * Author:  Damian Suess
 * File:    Md5VsSha256.cs
 * Description:
 *  MD5 vs SHA256 test
 */

using System;
using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace Test.BenchmarkTests.Tests
{
  ////----------------------
  ////[SimpleJob(RuntimeMoniker.Net472, baseline: true)]
  ////[SimpleJob(RuntimeMoniker.NetCoreApp30)]
  ////[SimpleJob(RuntimeMoniker.CoreRt30)]
  ////[SimpleJob(RuntimeMoniker.Mono)]
  ////[RPlotExporter]
  ////----------------------
  ////[ClrJob(baseline: true), CoreJob, MonoJob, CoreRtJob]
  ////[RPlotExporter, RankColumn]
  ////----------------------

  [SimpleJob(RuntimeMoniker.Net472, baseline: true)]
  [SimpleJob(RuntimeMoniker.NetCoreApp30)]
  [RPlotExporter]
  public class Md5VsSha256
  {
    [Params(1000, 10000)]
    public int Size;

    private SHA256 _sha256 = SHA256.Create();
    private MD5 _md5 = MD5.Create();
    private byte[] _data;

    [GlobalSetup]
    public void Setup()
    {
      _data = new byte[Size];
      new Random(42).NextBytes(_data);
    }

    [Benchmark]
    public byte[] Sha256() => _sha256.ComputeHash(_data);

    [Benchmark]
    public byte[] Md5() => _md5.ComputeHash(_data);
  }
}
