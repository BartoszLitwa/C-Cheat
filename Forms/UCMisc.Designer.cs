namespace ZBase.Forms
{
    partial class UCMisc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FakeLagTXT = new System.Windows.Forms.TextBox();
            this.FOVChangerTXT = new System.Windows.Forms.TextBox();
            this.AntiFlashLabel = new System.Windows.Forms.Label();
            this.AntiFlashTrackBar = new System.Windows.Forms.TrackBar();
            this.AntiFlashCheck = new System.Windows.Forms.CheckBox();
            this.NoHandsCheck = new System.Windows.Forms.CheckBox();
            this.ThirdPersonCheck = new System.Windows.Forms.CheckBox();
            this.NightModeCheck = new System.Windows.Forms.CheckBox();
            this.FakeLagCheck = new System.Windows.Forms.CheckBox();
            this.FOVChangerCheck = new System.Windows.Forms.CheckBox();
            this.BunnyhopCheck = new System.Windows.Forms.CheckBox();
            this.AntiAimCheck = new System.Windows.Forms.CheckBox();
            this.HitMarkerCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.AntiFlashTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // FakeLagTXT
            // 
            this.FakeLagTXT.Location = new System.Drawing.Point(227, 24);
            this.FakeLagTXT.Name = "FakeLagTXT";
            this.FakeLagTXT.Size = new System.Drawing.Size(38, 20);
            this.FakeLagTXT.TabIndex = 124;
            this.FakeLagTXT.Text = "1";
            this.FakeLagTXT.TextChanged += new System.EventHandler(this.FakeLagTXT_TextChanged);
            // 
            // FOVChangerTXT
            // 
            this.FOVChangerTXT.Location = new System.Drawing.Point(227, 1);
            this.FOVChangerTXT.MaxLength = 3;
            this.FOVChangerTXT.Name = "FOVChangerTXT";
            this.FOVChangerTXT.Size = new System.Drawing.Size(38, 20);
            this.FOVChangerTXT.TabIndex = 123;
            this.FOVChangerTXT.Text = "1";
            this.FOVChangerTXT.TextChanged += new System.EventHandler(this.FOVChangerTXT_TextChanged);
            // 
            // AntiFlashLabel
            // 
            this.AntiFlashLabel.AutoSize = true;
            this.AntiFlashLabel.Location = new System.Drawing.Point(277, 49);
            this.AntiFlashLabel.Name = "AntiFlashLabel";
            this.AntiFlashLabel.Size = new System.Drawing.Size(61, 13);
            this.AntiFlashLabel.TabIndex = 122;
            this.AntiFlashLabel.Text = "AntiFlash%:";
            this.AntiFlashLabel.Click += new System.EventHandler(this.AntiFlashLabel_Click);
            // 
            // AntiFlashTrackBar
            // 
            this.AntiFlashTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AntiFlashTrackBar.Location = new System.Drawing.Point(278, 21);
            this.AntiFlashTrackBar.Maximum = 100;
            this.AntiFlashTrackBar.Name = "AntiFlashTrackBar";
            this.AntiFlashTrackBar.Size = new System.Drawing.Size(121, 45);
            this.AntiFlashTrackBar.TabIndex = 121;
            this.AntiFlashTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.AntiFlashTrackBar.Value = 10;
            this.AntiFlashTrackBar.Scroll += new System.EventHandler(this.AntiFlashTrackBar_Scroll);
            // 
            // AntiFlashCheck
            // 
            this.AntiFlashCheck.AutoSize = true;
            this.AntiFlashCheck.Location = new System.Drawing.Point(280, 3);
            this.AntiFlashCheck.Name = "AntiFlashCheck";
            this.AntiFlashCheck.Size = new System.Drawing.Size(69, 17);
            this.AntiFlashCheck.TabIndex = 120;
            this.AntiFlashCheck.Text = "AntiFlash";
            this.AntiFlashCheck.UseVisualStyleBackColor = true;
            this.AntiFlashCheck.CheckedChanged += new System.EventHandler(this.AntiFlashCheck_CheckedChanged);
            // 
            // NoHandsCheck
            // 
            this.NoHandsCheck.AutoSize = true;
            this.NoHandsCheck.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.NoHandsCheck.Location = new System.Drawing.Point(3, 49);
            this.NoHandsCheck.Name = "NoHandsCheck";
            this.NoHandsCheck.Size = new System.Drawing.Size(71, 17);
            this.NoHandsCheck.TabIndex = 119;
            this.NoHandsCheck.Text = "NoHands";
            this.NoHandsCheck.UseVisualStyleBackColor = true;
            this.NoHandsCheck.CheckedChanged += new System.EventHandler(this.NoHandsCheck_CheckedChanged);
            // 
            // ThirdPersonCheck
            // 
            this.ThirdPersonCheck.AutoSize = true;
            this.ThirdPersonCheck.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ThirdPersonCheck.Location = new System.Drawing.Point(3, 26);
            this.ThirdPersonCheck.Name = "ThirdPersonCheck";
            this.ThirdPersonCheck.Size = new System.Drawing.Size(74, 17);
            this.ThirdPersonCheck.TabIndex = 118;
            this.ThirdPersonCheck.Text = "3rdPerson";
            this.ThirdPersonCheck.UseVisualStyleBackColor = true;
            this.ThirdPersonCheck.CheckedChanged += new System.EventHandler(this.ThirdPersonCheck_CheckedChanged);
            // 
            // NightModeCheck
            // 
            this.NightModeCheck.AutoSize = true;
            this.NightModeCheck.Location = new System.Drawing.Point(3, 3);
            this.NightModeCheck.Name = "NightModeCheck";
            this.NightModeCheck.Size = new System.Drawing.Size(78, 17);
            this.NightModeCheck.TabIndex = 117;
            this.NightModeCheck.Text = "NightMode";
            this.NightModeCheck.UseVisualStyleBackColor = true;
            this.NightModeCheck.CheckedChanged += new System.EventHandler(this.NightModeCheck_CheckedChanged);
            // 
            // FakeLagCheck
            // 
            this.FakeLagCheck.AutoSize = true;
            this.FakeLagCheck.Location = new System.Drawing.Point(131, 26);
            this.FakeLagCheck.Name = "FakeLagCheck";
            this.FakeLagCheck.Size = new System.Drawing.Size(68, 17);
            this.FakeLagCheck.TabIndex = 116;
            this.FakeLagCheck.Text = "FakeLag";
            this.FakeLagCheck.UseVisualStyleBackColor = true;
            this.FakeLagCheck.CheckedChanged += new System.EventHandler(this.FakeLagCheck_CheckedChanged);
            // 
            // FOVChangerCheck
            // 
            this.FOVChangerCheck.AutoSize = true;
            this.FOVChangerCheck.Location = new System.Drawing.Point(131, 3);
            this.FOVChangerCheck.Name = "FOVChangerCheck";
            this.FOVChangerCheck.Size = new System.Drawing.Size(90, 17);
            this.FOVChangerCheck.TabIndex = 115;
            this.FOVChangerCheck.Text = "FOV Changer";
            this.FOVChangerCheck.UseVisualStyleBackColor = true;
            this.FOVChangerCheck.CheckedChanged += new System.EventHandler(this.FOVChangerCheck_CheckedChanged);
            // 
            // BunnyhopCheck
            // 
            this.BunnyhopCheck.AutoSize = true;
            this.BunnyhopCheck.Location = new System.Drawing.Point(131, 49);
            this.BunnyhopCheck.Name = "BunnyhopCheck";
            this.BunnyhopCheck.Size = new System.Drawing.Size(79, 17);
            this.BunnyhopCheck.TabIndex = 114;
            this.BunnyhopCheck.Text = "Bunny Hop";
            this.BunnyhopCheck.UseVisualStyleBackColor = true;
            this.BunnyhopCheck.CheckedChanged += new System.EventHandler(this.BunnyhopCheck_CheckedChanged);
            // 
            // AntiAimCheck
            // 
            this.AntiAimCheck.AutoSize = true;
            this.AntiAimCheck.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.AntiAimCheck.Location = new System.Drawing.Point(3, 72);
            this.AntiAimCheck.Name = "AntiAimCheck";
            this.AntiAimCheck.Size = new System.Drawing.Size(61, 17);
            this.AntiAimCheck.TabIndex = 125;
            this.AntiAimCheck.Text = "AntiAim";
            this.AntiAimCheck.UseVisualStyleBackColor = true;
            this.AntiAimCheck.CheckedChanged += new System.EventHandler(this.AntiAimCheck_CheckedChanged);
            // 
            // HitMarkerCheck
            // 
            this.HitMarkerCheck.AutoSize = true;
            this.HitMarkerCheck.Location = new System.Drawing.Point(131, 72);
            this.HitMarkerCheck.Name = "HitMarkerCheck";
            this.HitMarkerCheck.Size = new System.Drawing.Size(71, 17);
            this.HitMarkerCheck.TabIndex = 126;
            this.HitMarkerCheck.Text = "Hitmarker";
            this.HitMarkerCheck.UseVisualStyleBackColor = true;
            this.HitMarkerCheck.CheckedChanged += new System.EventHandler(this.HitMarkerCheck_CheckedChanged);
            // 
            // UCMisc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HitMarkerCheck);
            this.Controls.Add(this.AntiAimCheck);
            this.Controls.Add(this.FakeLagTXT);
            this.Controls.Add(this.FOVChangerTXT);
            this.Controls.Add(this.AntiFlashLabel);
            this.Controls.Add(this.AntiFlashTrackBar);
            this.Controls.Add(this.AntiFlashCheck);
            this.Controls.Add(this.NoHandsCheck);
            this.Controls.Add(this.ThirdPersonCheck);
            this.Controls.Add(this.NightModeCheck);
            this.Controls.Add(this.FakeLagCheck);
            this.Controls.Add(this.FOVChangerCheck);
            this.Controls.Add(this.BunnyhopCheck);
            this.Name = "UCMisc";
            this.Size = new System.Drawing.Size(437, 257);
            ((System.ComponentModel.ISupportInitialize)(this.AntiFlashTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FakeLagTXT;
        private System.Windows.Forms.TextBox FOVChangerTXT;
        private System.Windows.Forms.Label AntiFlashLabel;
        private System.Windows.Forms.TrackBar AntiFlashTrackBar;
        private System.Windows.Forms.CheckBox AntiFlashCheck;
        private System.Windows.Forms.CheckBox NoHandsCheck;
        private System.Windows.Forms.CheckBox ThirdPersonCheck;
        private System.Windows.Forms.CheckBox NightModeCheck;
        private System.Windows.Forms.CheckBox FakeLagCheck;
        private System.Windows.Forms.CheckBox FOVChangerCheck;
        private System.Windows.Forms.CheckBox BunnyhopCheck;
        private System.Windows.Forms.CheckBox AntiAimCheck;
        private System.Windows.Forms.CheckBox HitMarkerCheck;
    }
}
