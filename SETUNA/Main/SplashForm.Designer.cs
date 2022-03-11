namespace SETUNA.Main
{
	// Token: 0x02000043 RID: 67
	partial class SplashForm
	{
		// Token: 0x06000271 RID: 625 RVA: 0x0000D215 File Offset: 0x0000B415
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000D234 File Offset: 0x0000B434
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.SplashTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SplashTimer
            // 
            this.SplashTimer.Interval = 3000;
            this.SplashTimer.Tick += new System.EventHandler(this.SplashTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(-16, -10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(81, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW";
            // 
            // lblVer
            // 
            this.lblVer.ForeColor = System.Drawing.Color.Gray;
            this.lblVer.Location = new System.Drawing.Point(12, 129);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(366, 18);
            this.lblVer.TabIndex = 4;
            this.lblVer.Text = "SETUNA 2.0α";
            this.lblVer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVer.Click += new System.EventHandler(this.lblVer_Click);
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(386, 161);
            this.ControlBox = false;
            this.Controls.Add(this.lblVer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SplashForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000112 RID: 274
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000113 RID: 275
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000114 RID: 276
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000115 RID: 277
		private global::System.Windows.Forms.Label lblVer;

		// Token: 0x04000116 RID: 278
		public global::System.Windows.Forms.Timer SplashTimer;
	}
}
