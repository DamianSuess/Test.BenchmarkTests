/* Copyright Xeno Innovations, Inc. 2020
 * Date:    2020-3-11
 * Author:  Damian Suess
 * File:    IntroExport.cs
 * Description:
 *  
 */

using System;
using System.Threading;
using BenchmarkDotNet.Attributes;

namespace Test.BenchmarkTests.Tests
{
  [ShortRunJob]
  [MediumRunJob]
  [KeepBenchmarkFiles]

  [AsciiDocExporter]
  [CsvExporter]
  [CsvMeasurementsExporter]
  [HtmlExporter]
  [PlainExporter]
  [RPlotExporter]
  [JsonExporterAttribute.Brief]
  [JsonExporterAttribute.BriefCompressed]
  [JsonExporterAttribute.Full]
  [JsonExporterAttribute.FullCompressed]
  [MarkdownExporterAttribute.Default]
  [MarkdownExporterAttribute.GitHub]
  [MarkdownExporterAttribute.StackOverflow]
  [MarkdownExporterAttribute.Atlassian]
  [XmlExporterAttribute.Brief]
  [XmlExporterAttribute.BriefCompressed]
  [XmlExporterAttribute.Full]
  [XmlExporterAttribute.FullCompressed]
  public class IntroExportTest
  {
    private Random random = new Random(42);

    [Benchmark(Baseline = true)]
    public void Sleep10() => Thread.Sleep(10);

    [Benchmark]
    public void Sleep50Noisy() => Thread.Sleep(random.Next(100));
  }
}
