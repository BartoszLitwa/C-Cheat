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
            this.ColoredHandsCheck = new System.Windows.Forms.CheckBox();
            this.AutoStrafeCheck = new System.Windows.Forms.CheckBox();
            this.ClanTagChangerTextBox = new System.Windows.Forms.TextBox();
            this.ClanTagChangerCheck = new System.Windows.Forms.CheckBox();
            this.textBoxTest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.BunnyhopCheck.Location = new System.Drawing.Point(131, 72);
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
            this.AntiAimCheck.Location = new System.Drawing.Point(3, 94);
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
            this.HitMarkerCheck.Location = new System.Drawing.Point(131, 49);
            this.HitMarkerCheck.Name = "HitMarkerCheck";
            this.HitMarkerCheck.Size = new System.Drawing.Size(71, 17);
            this.HitMarkerCheck.TabIndex = 126;
            this.HitMarkerCheck.Text = "Hitmarker";
            this.HitMarkerCheck.UseVisualStyleBackColor = true;
            this.HitMarkerCheck.CheckedChanged += new System.EventHandler(this.HitMarkerCheck_CheckedChanged);
            // 
            // ColoredHandsCheck
            // 
            this.ColoredHandsCheck.AutoSize = true;
            this.ColoredHandsCheck.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ColoredHandsCheck.Location = new System.Drawing.Point(3, 72);
            this.ColoredHandsCheck.Name = "ColoredHandsCheck";
            this.ColoredHandsCheck.Size = new System.Drawing.Size(96, 17);
            this.ColoredHandsCheck.TabIndex = 127;
            this.ColoredHandsCheck.Text = "Colored Hands";
            this.ColoredHandsCheck.UseVisualStyleBackColor = true;
            this.ColoredHandsCheck.CheckedChanged += new System.EventHandler(this.ColoredHandsCheck_CheckedChanged);
            // 
            // AutoStrafeCheck
            // 
            this.AutoStrafeCheck.AutoSize = true;
            this.AutoStrafeCheck.Location = new System.Drawing.Point(131, 95);
            this.AutoStrafeCheck.Name = "AutoStrafeCheck";
            this.AutoStrafeCheck.Size = new System.Drawing.Size(79, 17);
            this.AutoStrafeCheck.TabIndex = 128;
            this.AutoStrafeCheck.Text = "Auto Strafe";
            this.AutoStrafeCheck.UseVisualStyleBackColor = true;
            this.AutoStrafeCheck.CheckedChanged += new System.EventHandler(this.AutoStrafeCheck_CheckedChanged);
            // 
            // ClanTagChangerTextBox
            // 
            this.ClanTagChangerTextBox.Location = new System.Drawing.Point(280, 91);
            this.ClanTagChangerTextBox.Name = "ClanTagChangerTextBox";
            this.ClanTagChangerTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClanTagChangerTextBox.TabIndex = 129;
            this.ClanTagChangerTextBox.TextChanged += new System.EventHandler(this.ClanTagChangerTextBox_TextChanged);
            // 
            // ClanTagChangerCheck
            // 
            this.ClanTagChangerCheck.AutoSize = true;
            this.ClanTagChangerCheck.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ClanTagChangerCheck.Location = new System.Drawing.Point(280, 72);
            this.ClanTagChangerCheck.Name = "ClanTagChangerCheck";
            this.ClanTagChangerCheck.Size = new System.Drawing.Size(109, 17);
            this.ClanTagChangerCheck.TabIndex = 130;
            this.ClanTagChangerCheck.Text = "ClanTag Changer";
            this.ClanTagChangerCheck.UseVisualStyleBackColor = true;
            this.ClanTagChangerCheck.CheckedChanged += new System.EventHandler(this.ClanTagChangerCheck_CheckedChanged);
            // 
            // textBoxTest
            // 
            this.textBoxTest.Location = new System.Drawing.Point(278, 159);
            this.textBoxTest.Name = "textBoxTest";
            this.textBoxTest.Size = new System.Drawing.Size(100, 20);
            this.textBoxTest.TabIndex = 132;
            this.textBoxTest.TextChanged += new System.EventHandler(this.textBoxTest_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 133;
            this.label1.Text = "ForTesting";
            // 
            // UCMisc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTest);
            this.Controls.Add(this.ClanTagChangerCheck);
            this.Controls.Add(this.ClanTagChangerTextBox);
            this.Controls.Add(this.AutoStrafeCheck);
            this.Controls.Add(this.ColoredHandsCheck);
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
        private System.Windows.Forms.CheckBox ColoredHandsCheck;
        private System.Windows.Forms.CheckBox AutoStrafeCheck;
        private System.Windows.Forms.TextBox ClanTagChangerTextBox;
        private System.Windows.Forms.CheckBox ClanTagChangerCheck;
        private System.Windows.Forms.TextBox textBoxTest;
        private System.Windows.Forms.Label label1;
    }
}
