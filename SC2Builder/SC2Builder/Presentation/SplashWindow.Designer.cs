namespace SC2Builder.Presentation
{
    partial class SplashWindow
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashWindow));
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.SplashLabelClan = new System.Windows.Forms.Label();
			this.SplashLabelVersion = new System.Windows.Forms.Label();
			this.SplashLabelName = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1800;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(347, -115);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 500);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(-46, -115);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(100, 500);
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// SplashLabelClan
			// 
			this.SplashLabelClan.AutoSize = true;
			this.SplashLabelClan.BackColor = System.Drawing.Color.Transparent;
			this.SplashLabelClan.Font = new System.Drawing.Font("Calibri Light", 8.75F);
			this.SplashLabelClan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.SplashLabelClan.Location = new System.Drawing.Point(68, 259);
			this.SplashLabelClan.Name = "SplashLabelClan";
			this.SplashLabelClan.Size = new System.Drawing.Size(53, 14);
			this.SplashLabelClan.TabIndex = 2;
			this.SplashLabelClan.Text = "Clan MPC";
			// 
			// SplashLabelVersion
			// 
			this.SplashLabelVersion.AutoSize = true;
			this.SplashLabelVersion.BackColor = System.Drawing.Color.Transparent;
			this.SplashLabelVersion.Font = new System.Drawing.Font("Calibri Light", 8.75F);
			this.SplashLabelVersion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.SplashLabelVersion.Location = new System.Drawing.Point(68, 273);
			this.SplashLabelVersion.Name = "SplashLabelVersion";
			this.SplashLabelVersion.Size = new System.Drawing.Size(0, 14);
			this.SplashLabelVersion.TabIndex = 3;
			// 
			// SplashLabelName
			// 
			this.SplashLabelName.AutoSize = true;
			this.SplashLabelName.BackColor = System.Drawing.Color.Transparent;
			this.SplashLabelName.Font = new System.Drawing.Font("Calibri Light", 8.75F);
			this.SplashLabelName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.SplashLabelName.Location = new System.Drawing.Point(68, 245);
			this.SplashLabelName.Name = "SplashLabelName";
			this.SplashLabelName.Size = new System.Drawing.Size(33, 14);
			this.SplashLabelName.TabIndex = 4;
			this.SplashLabelName.Text = "steve";
			// 
			// SplashWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::SC2Builder.Properties.Resources.splash;
			this.ClientSize = new System.Drawing.Size(400, 300);
			this.Controls.Add(this.SplashLabelName);
			this.Controls.Add(this.SplashLabelVersion);
			this.Controls.Add(this.SplashLabelClan);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SplashWindow";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SplashWindow";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.SplashWindow_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
				private System.Windows.Forms.Label SplashLabelClan;
				private System.Windows.Forms.Label SplashLabelVersion;
				private System.Windows.Forms.Label SplashLabelName;
    }
}