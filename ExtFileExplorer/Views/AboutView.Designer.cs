namespace ExtFileExplorer.Views
{
  partial class AboutView
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
      this.labelProductDetails = new System.Windows.Forms.Label();
      this.labelProductName = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // labelProductDetails
      // 
      this.labelProductDetails.Location = new System.Drawing.Point(10, 109);
      this.labelProductDetails.Name = "labelProductDetails";
      this.labelProductDetails.Size = new System.Drawing.Size(356, 80);
      this.labelProductDetails.TabIndex = 0;
      this.labelProductDetails.Text = "Version 0.9.0 (64-Bit)\r\n\r\n\r\n© 2022 Christopher Fabian\r\nAll rights reserved.\r\n";
      // 
      // labelProductName
      // 
      this.labelProductName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.labelProductName.ForeColor = System.Drawing.SystemColors.Highlight;
      this.labelProductName.Location = new System.Drawing.Point(10, 10);
      this.labelProductName.Name = "labelProductName";
      this.labelProductName.Size = new System.Drawing.Size(356, 50);
      this.labelProductName.TabIndex = 1;
      this.labelProductName.Text = "EXT File Explorer";
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(10, 60);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(356, 40);
      this.label1.TabIndex = 2;
      this.label1.Text = "Access Linux Ext2/3/4 filesystem from Windows\r\nfor SD/MMC card, USB flash drive o" +
    "r any other wear leveled memory types.\r\n";
      // 
      // AboutView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
      this.ClientSize = new System.Drawing.Size(384, 191);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.labelProductName);
      this.Controls.Add(this.labelProductDetails);
      this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.ForeColor = System.Drawing.Color.White;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "AboutView";
      this.Text = "About EXT File Explorer";
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Label labelProductName;
    private System.Windows.Forms.Label labelProductDetails;
    private System.Windows.Forms.Label label1;
  }
}