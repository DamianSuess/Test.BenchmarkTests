﻿/* Copyright Xeno Innovations, Inc. 2020
 * Date:    2020-3-11
 * Author:  Damian Suess
 * File:    FrmMain.cs
 * Description:
 *
 */

using System;
using System.Windows.Forms;
using BenchmarkDotNet.Running;
using Test.BenchmarkTests.Tests;

namespace Test.BenchmarkTests
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();
    }

    private void BtnMd5Sha256_Click(object sender, EventArgs e)
    {
      var summary = BenchmarkRunner.Run<Md5VsSha256>();

      SummaryBox.Text = summary.ToString();
    }
  }
}
