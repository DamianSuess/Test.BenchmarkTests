namespace Test.BenchmarkTests
{
  partial class FrmMain
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.BtnMd5Sha256 = new System.Windows.Forms.Button();
      this.SummaryBox = new System.Windows.Forms.TextBox();
      this.BtnTupleVsOut = new System.Windows.Forms.Button();
      this.BtnMathFuncts = new System.Windows.Forms.Button();
      this.BtnExportTest = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // BtnMd5Sha256
      // 
      this.BtnMd5Sha256.Location = new System.Drawing.Point(12, 12);
      this.BtnMd5Sha256.Name = "BtnMd5Sha256";
      this.BtnMd5Sha256.Size = new System.Drawing.Size(116, 23);
      this.BtnMd5Sha256.TabIndex = 0;
      this.BtnMd5Sha256.Text = "MD5 vs SHA256";
      this.BtnMd5Sha256.UseVisualStyleBackColor = true;
      this.BtnMd5Sha256.Click += new System.EventHandler(this.BtnMd5Sha256_Click);
      // 
      // SummaryBox
      // 
      this.SummaryBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.SummaryBox.Location = new System.Drawing.Point(12, 41);
      this.SummaryBox.Multiline = true;
      this.SummaryBox.Name = "SummaryBox";
      this.SummaryBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.SummaryBox.Size = new System.Drawing.Size(613, 237);
      this.SummaryBox.TabIndex = 1;
      // 
      // BtnTupleVsOut
      // 
      this.BtnTupleVsOut.Location = new System.Drawing.Point(134, 12);
      this.BtnTupleVsOut.Name = "BtnTupleVsOut";
      this.BtnTupleVsOut.Size = new System.Drawing.Size(117, 23);
      this.BtnTupleVsOut.TabIndex = 2;
      this.BtnTupleVsOut.Text = "Tuple vs Out";
      this.BtnTupleVsOut.UseVisualStyleBackColor = true;
      // 
      // BtnMathFuncts
      // 
      this.BtnMathFuncts.Location = new System.Drawing.Point(257, 12);
      this.BtnMathFuncts.Name = "BtnMathFuncts";
      this.BtnMathFuncts.Size = new System.Drawing.Size(97, 23);
      this.BtnMathFuncts.TabIndex = 3;
      this.BtnMathFuncts.Text = "Math Funcs";
      this.BtnMathFuncts.UseVisualStyleBackColor = true;
      this.BtnMathFuncts.Click += new System.EventHandler(this.BtnMathFuncts_Click);
      // 
      // BtnExportTest
      // 
      this.BtnExportTest.Location = new System.Drawing.Point(360, 12);
      this.BtnExportTest.Name = "BtnExportTest";
      this.BtnExportTest.Size = new System.Drawing.Size(97, 23);
      this.BtnExportTest.TabIndex = 4;
      this.BtnExportTest.Text = "Export Test";
      this.BtnExportTest.UseVisualStyleBackColor = true;
      this.BtnExportTest.Click += new System.EventHandler(this.BtnExportTest_Click);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(637, 290);
      this.Controls.Add(this.BtnExportTest);
      this.Controls.Add(this.BtnMathFuncts);
      this.Controls.Add(this.BtnTupleVsOut);
      this.Controls.Add(this.SummaryBox);
      this.Controls.Add(this.BtnMd5Sha256);
      this.Name = "FrmMain";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button BtnMd5Sha256;
    private System.Windows.Forms.TextBox SummaryBox;
    private System.Windows.Forms.Button BtnTupleVsOut;
    private System.Windows.Forms.Button BtnMathFuncts;
    private System.Windows.Forms.Button BtnExportTest;
  }
}

