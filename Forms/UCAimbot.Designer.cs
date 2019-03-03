namespace ZBase.Forms
{
    partial class UCAimbot
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
            this.DrawAimspotCheck = new System.Windows.Forms.CheckBox();
            this.AimbotSmoothTXT = new System.Windows.Forms.TextBox();
            this.TriggerBotTXT = new System.Windows.Forms.TextBox();
            this.TriggerBotCheck = new System.Windows.Forms.CheckBox();
            this.RCSTXT = new System.Windows.Forms.TextBox();
            this.RCSCheck = new System.Windows.Forms.CheckBox();
            this.AimbotSmoothCheck = new System.Windows.Forms.CheckBox();
            this.RecoilPredictionCheck = new System.Windows.Forms.CheckBox();
            this.ComoBoxAimbotBones = new System.Windows.Forms.ComboBox();
            this.FOVLabel = new System.Windows.Forms.Label();
            this.AimbotFOVTrackBar = new System.Windows.Forms.TrackBar();
            this.DisplayFOVAimbotCheck = new System.Windows.Forms.CheckBox();
            this.AimbotCheck = new System.Windows.Forms.CheckBox();
            this.AutoPistolCheck = new System.Windows.Forms.CheckBox();
            this.IfSpottedCheck = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SmartAimbotCheck = new System.Windows.Forms.CheckBox();
            this.SilentAimCheck = new System.Windows.Forms.CheckBox();
            this.ShootTeammatesCheck = new System.Windows.Forms.CheckBox();
            this.RageBotCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.AimbotFOVTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawAimspotCheck
            // 
            this.DrawAimspotCheck.AutoSize = true;
            this.DrawAimspotCheck.Location = new System.Drawing.Point(104, 181);
            this.DrawAimspotCheck.Name = "DrawAimspotCheck";
            this.DrawAimspotCheck.Size = new System.Drawing.Size(63, 17);
            this.DrawAimspotCheck.TabIndex = 130;
            this.DrawAimspotCheck.Text = "Aimspot";
            this.DrawAimspotCheck.UseVisualStyleBackColor = true;
            this.DrawAimspotCheck.CheckedChanged += new System.EventHandler(this.DrawAimspotCheck_CheckedChanged);
            // 
            // AimbotSmoothTXT
            // 
            this.AimbotSmoothTXT.Location = new System.Drawing.Point(176, 33);
            this.AimbotSmoothTXT.MaxLength = 3;
            this.AimbotSmoothTXT.Name = "AimbotSmoothTXT";
            this.AimbotSmoothTXT.Size = new System.Drawing.Size(38, 20);
            this.AimbotSmoothTXT.TabIndex = 129;
            this.AimbotSmoothTXT.Text = "1";
            this.AimbotSmoothTXT.TextChanged += new System.EventHandler(this.AimbotSmoothTXT_TextChanged);
            // 
            // TriggerBotTXT
            // 
            this.TriggerBotTXT.Location = new System.Drawing.Point(104, 155);
            this.TriggerBotTXT.Name = "TriggerBotTXT";
            this.TriggerBotTXT.Size = new System.Drawing.Size(38, 20);
            this.TriggerBotTXT.TabIndex = 128;
            this.TriggerBotTXT.Text = "1";
            this.TriggerBotTXT.TextChanged += new System.EventHandler(this.TriggerBotTXT_TextChanged);
            // 
            // TriggerBotCheck
            // 
            this.TriggerBotCheck.AutoSize = true;
            this.TriggerBotCheck.Location = new System.Drawing.Point(6, 158);
            this.TriggerBotCheck.Name = "TriggerBotCheck";
            this.TriggerBotCheck.Size = new System.Drawing.Size(75, 17);
            this.TriggerBotCheck.TabIndex = 127;
            this.TriggerBotCheck.Text = "TriggerBot";
            this.TriggerBotCheck.UseVisualStyleBackColor = true;
            this.TriggerBotCheck.CheckedChanged += new System.EventHandler(this.TriggerBotCheck_CheckedChanged);
            // 
            // RCSTXT
            // 
            this.RCSTXT.Location = new System.Drawing.Point(104, 129);
            this.RCSTXT.Name = "RCSTXT";
            this.RCSTXT.Size = new System.Drawing.Size(38, 20);
            this.RCSTXT.TabIndex = 126;
            this.RCSTXT.Text = "1";
            this.RCSTXT.TextChanged += new System.EventHandler(this.RCSTXT_TextChanged);
            // 
            // RCSCheck
            // 
            this.RCSCheck.AutoSize = true;
            this.RCSCheck.Location = new System.Drawing.Point(6, 135);
            this.RCSCheck.Name = "RCSCheck";
            this.RCSCheck.Size = new System.Drawing.Size(48, 17);
            this.RCSCheck.TabIndex = 125;
            this.RCSCheck.Text = "RCS";
            this.RCSCheck.UseVisualStyleBackColor = true;
            this.RCSCheck.CheckedChanged += new System.EventHandler(this.RCSCheck_CheckedChanged);
            // 
            // AimbotSmoothCheck
            // 
            this.AimbotSmoothCheck.AutoSize = true;
            this.AimbotSmoothCheck.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.AimbotSmoothCheck.Location = new System.Drawing.Point(104, 36);
            this.AimbotSmoothCheck.Name = "AimbotSmoothCheck";
            this.AimbotSmoothCheck.Size = new System.Drawing.Size(62, 17);
            this.AimbotSmoothCheck.TabIndex = 124;
            this.AimbotSmoothCheck.Text = "Smooth";
            this.AimbotSmoothCheck.UseVisualStyleBackColor = true;
            this.AimbotSmoothCheck.CheckedChanged += new System.EventHandler(this.AimbotSmoothCheck_CheckedChanged);
            // 
            // RecoilPredictionCheck
            // 
            this.RecoilPredictionCheck.AutoSize = true;
            this.RecoilPredictionCheck.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.RecoilPredictionCheck.Location = new System.Drawing.Point(261, 38);
            this.RecoilPredictionCheck.Name = "RecoilPredictionCheck";
            this.RecoilPredictionCheck.Size = new System.Drawing.Size(103, 17);
            this.RecoilPredictionCheck.TabIndex = 123;
            this.RecoilPredictionCheck.Text = "RecoilPrediction";
            this.RecoilPredictionCheck.UseVisualStyleBackColor = true;
            this.RecoilPredictionCheck.CheckedChanged += new System.EventHandler(this.RecoilPredictionCheck_CheckedChanged);
            // 
            // ComoBoxAimbotBones
            // 
            this.ComoBoxAimbotBones.AutoCompleteCustomSource.AddRange(new string[] {
            "Full Box",
            "Edge Box"});
            this.ComoBoxAimbotBones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComoBoxAimbotBones.FormattingEnabled = true;
            this.ComoBoxAimbotBones.Items.AddRange(new object[] {
            "Head",
            "Neck",
            "Chest",
            "Stomach",
            "Left Arm",
            "Right Arm",
            "Left hand",
            "Right Hand",
            "Pelvis",
            "Left Knee",
            "Right Knee",
            "Left Foot",
            "Right Foot"});
            this.ComoBoxAimbotBones.Location = new System.Drawing.Point(261, 11);
            this.ComoBoxAimbotBones.Name = "ComoBoxAimbotBones";
            this.ComoBoxAimbotBones.Size = new System.Drawing.Size(121, 21);
            this.ComoBoxAimbotBones.TabIndex = 122;
            this.ComoBoxAimbotBones.SelectedIndexChanged += new System.EventHandler(this.ComoBoxAimbotBones_SelectedIndexChanged);
            // 
            // FOVLabel
            // 
            this.FOVLabel.AutoSize = true;
            this.FOVLabel.Location = new System.Drawing.Point(9, 91);
            this.FOVLabel.Name = "FOVLabel";
            this.FOVLabel.Size = new System.Drawing.Size(31, 13);
            this.FOVLabel.TabIndex = 121;
            this.FOVLabel.Text = "FOV:";
            // 
            // AimbotFOVTrackBar
            // 
            this.AimbotFOVTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AimbotFOVTrackBar.Location = new System.Drawing.Point(7, 59);
            this.AimbotFOVTrackBar.Maximum = 1200;
            this.AimbotFOVTrackBar.Name = "AimbotFOVTrackBar";
            this.AimbotFOVTrackBar.Size = new System.Drawing.Size(240, 45);
            this.AimbotFOVTrackBar.TabIndex = 120;
            this.AimbotFOVTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.AimbotFOVTrackBar.Value = 10;
            this.AimbotFOVTrackBar.Scroll += new System.EventHandler(this.AimbotFOVTrackBar_Scroll);
            // 
            // DisplayFOVAimbotCheck
            // 
            this.DisplayFOVAimbotCheck.AutoSize = true;
            this.DisplayFOVAimbotCheck.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.DisplayFOVAimbotCheck.Location = new System.Drawing.Point(261, 61);
            this.DisplayFOVAimbotCheck.Name = "DisplayFOVAimbotCheck";
            this.DisplayFOVAimbotCheck.Size = new System.Drawing.Size(84, 17);
            this.DisplayFOVAimbotCheck.TabIndex = 119;
            this.DisplayFOVAimbotCheck.Text = "Display FOV";
            this.DisplayFOVAimbotCheck.UseVisualStyleBackColor = true;
            this.DisplayFOVAimbotCheck.CheckedChanged += new System.EventHandler(this.DisplayFOVAimbotCheck_CheckedChanged);
            // 
            // AimbotCheck
            // 
            this.AimbotCheck.AutoSize = true;
            this.AimbotCheck.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.AimbotCheck.Location = new System.Drawing.Point(7, 36);
            this.AimbotCheck.Name = "AimbotCheck";
            this.AimbotCheck.Size = new System.Drawing.Size(58, 17);
            this.AimbotCheck.TabIndex = 118;
            this.AimbotCheck.Text = "Aimbot";
            this.AimbotCheck.UseVisualStyleBackColor = true;
            this.AimbotCheck.CheckedChanged += new System.EventHandler(this.AimbotCheck_CheckedChanged);
            // 
            // AutoPistolCheck
            // 
            this.AutoPistolCheck.AutoSize = true;
            this.AutoPistolCheck.Location = new System.Drawing.Point(6, 181);
            this.AutoPistolCheck.Name = "AutoPistolCheck";
            this.AutoPistolCheck.Size = new System.Drawing.Size(73, 17);
            this.AutoPistolCheck.TabIndex = 131;
            this.AutoPistolCheck.Text = "AutoPistol";
            this.AutoPistolCheck.UseVisualStyleBackColor = true;
            this.AutoPistolCheck.CheckedChanged += new System.EventHandler(this.AutoPistolCheck_CheckedChanged);
            // 
            // IfSpottedCheck
            // 
            this.IfSpottedCheck.AutoSize = true;
            this.IfSpottedCheck.Location = new System.Drawing.Point(261, 84);
            this.IfSpottedCheck.Name = "IfSpottedCheck";
            this.IfSpottedCheck.Size = new System.Drawing.Size(69, 17);
            this.IfSpottedCheck.TabIndex = 132;
            this.IfSpottedCheck.Text = "IfSpotted";
            this.IfSpottedCheck.UseVisualStyleBackColor = true;
            this.IfSpottedCheck.CheckedChanged += new System.EventHandler(this.IfSpottedCheck_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Full Box",
            "Edge Box"});
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Rifles",
            "Pistols",
            "Snipers",
            "ShotGuns",
            "MachineGuns",
            "SMG"});
            this.comboBox1.Location = new System.Drawing.Point(3, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 133;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(131, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 134;
            this.label1.Text = "Type of Guns";
            // 
            // SmartAimbotCheck
            // 
            this.SmartAimbotCheck.AutoSize = true;
            this.SmartAimbotCheck.Location = new System.Drawing.Point(261, 107);
            this.SmartAimbotCheck.Name = "SmartAimbotCheck";
            this.SmartAimbotCheck.Size = new System.Drawing.Size(85, 17);
            this.SmartAimbotCheck.TabIndex = 135;
            this.SmartAimbotCheck.Text = "SmartAimbot";
            this.SmartAimbotCheck.UseVisualStyleBackColor = true;
            this.SmartAimbotCheck.CheckedChanged += new System.EventHandler(this.SmartAimbotCheck_CheckedChanged);
            // 
            // SilentAimCheck
            // 
            this.SilentAimCheck.AutoSize = true;
            this.SilentAimCheck.Location = new System.Drawing.Point(165, 134);
            this.SilentAimCheck.Name = "SilentAimCheck";
            this.SilentAimCheck.Size = new System.Drawing.Size(69, 17);
            this.SilentAimCheck.TabIndex = 136;
            this.SilentAimCheck.Text = "SilentAim";
            this.SilentAimCheck.UseVisualStyleBackColor = true;
            this.SilentAimCheck.CheckedChanged += new System.EventHandler(this.SilentAimCheck_CheckedChanged);
            // 
            // ShootTeammatesCheck
            // 
            this.ShootTeammatesCheck.AutoSize = true;
            this.ShootTeammatesCheck.Location = new System.Drawing.Point(165, 158);
            this.ShootTeammatesCheck.Name = "ShootTeammatesCheck";
            this.ShootTeammatesCheck.Size = new System.Drawing.Size(112, 17);
            this.ShootTeammatesCheck.TabIndex = 137;
            this.ShootTeammatesCheck.Text = "Shoot Teammates";
            this.ShootTeammatesCheck.UseVisualStyleBackColor = true;
            this.ShootTeammatesCheck.CheckedChanged += new System.EventHandler(this.ShootTeammatesCheck_CheckedChanged);
            // 
            // RageBotCheck
            // 
            this.RageBotCheck.AutoSize = true;
            this.RageBotCheck.Location = new System.Drawing.Point(165, 181);
            this.RageBotCheck.Name = "RageBotCheck";
            this.RageBotCheck.Size = new System.Drawing.Size(68, 17);
            this.RageBotCheck.TabIndex = 138;
            this.RageBotCheck.Text = "RageBot";
            this.RageBotCheck.UseVisualStyleBackColor = true;
            this.RageBotCheck.CheckedChanged += new System.EventHandler(this.RageBotCheck_CheckedChanged);
            // 
            // UCAimbot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RageBotCheck);
            this.Controls.Add(this.ShootTeammatesCheck);
            this.Controls.Add(this.SilentAimCheck);
            this.Controls.Add(this.SmartAimbotCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.IfSpottedCheck);
            this.Controls.Add(this.AutoPistolCheck);
            this.Controls.Add(this.DrawAimspotCheck);
            this.Controls.Add(this.AimbotSmoothTXT);
            this.Controls.Add(this.TriggerBotTXT);
            this.Controls.Add(this.TriggerBotCheck);
            this.Controls.Add(this.RCSTXT);
            this.Controls.Add(this.RCSCheck);
            this.Controls.Add(this.AimbotSmoothCheck);
            this.Controls.Add(this.RecoilPredictionCheck);
            this.Controls.Add(this.ComoBoxAimbotBones);
            this.Controls.Add(this.FOVLabel);
            this.Controls.Add(this.AimbotFOVTrackBar);
            this.Controls.Add(this.DisplayFOVAimbotCheck);
            this.Controls.Add(this.AimbotCheck);
            this.Name = "UCAimbot";
            this.Size = new System.Drawing.Size(392, 285);
            ((System.ComponentModel.ISupportInitialize)(this.AimbotFOVTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox DrawAimspotCheck;
        private System.Windows.Forms.TextBox AimbotSmoothTXT;
        private System.Windows.Forms.TextBox TriggerBotTXT;
        private System.Windows.Forms.CheckBox TriggerBotCheck;
        private System.Windows.Forms.TextBox RCSTXT;
        private System.Windows.Forms.CheckBox RCSCheck;
        private System.Windows.Forms.CheckBox AimbotSmoothCheck;
        private System.Windows.Forms.CheckBox RecoilPredictionCheck;
        private System.Windows.Forms.ComboBox ComoBoxAimbotBones;
        private System.Windows.Forms.Label FOVLabel;
        private System.Windows.Forms.TrackBar AimbotFOVTrackBar;
        private System.Windows.Forms.CheckBox DisplayFOVAimbotCheck;
        private System.Windows.Forms.CheckBox AimbotCheck;
        private System.Windows.Forms.CheckBox AutoPistolCheck;
        private System.Windows.Forms.CheckBox IfSpottedCheck;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox SmartAimbotCheck;
        private System.Windows.Forms.CheckBox SilentAimCheck;
        private System.Windows.Forms.CheckBox ShootTeammatesCheck;
        private System.Windows.Forms.CheckBox RageBotCheck;
    }
}
