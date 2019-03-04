namespace ZBase
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.LeftSidePanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SkinChangerButton = new System.Windows.Forms.Button();
            this.MiscButton = new System.Windows.Forms.Button();
            this.AimbotButton = new System.Windows.Forms.Button();
            this.ESPButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadSettingsButton = new System.Windows.Forms.Button();
            this.SaveSettingsButton = new System.Windows.Forms.Button();
            this.ChoosenSettingsComboBox = new System.Windows.Forms.ComboBox();
            this.ColorButton = new System.Windows.Forms.Button();
            this.ucColors1 = new ZBase.Forms.UCColors();
            this.ucSkinChanger1 = new ZBase.Forms.UCSkinChanger();
            this.ucMisc1 = new ZBase.Forms.UCMisc();
            this.ucAimbot1 = new ZBase.Forms.UCAimbot();
            this.ucesp1 = new ZBase.Forms.UCESP();
            this.LeftSidePanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftSidePanel
            // 
            this.LeftSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.LeftSidePanel.Controls.Add(this.panel3);
            this.LeftSidePanel.Controls.Add(this.panel2);
            this.LeftSidePanel.Controls.Add(this.SkinChangerButton);
            this.LeftSidePanel.Controls.Add(this.MiscButton);
            this.LeftSidePanel.Controls.Add(this.AimbotButton);
            this.LeftSidePanel.Controls.Add(this.ESPButton);
            this.LeftSidePanel.Controls.Add(this.ColorButton);
            this.LeftSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftSidePanel.Location = new System.Drawing.Point(0, 0);
            this.LeftSidePanel.Name = "LeftSidePanel";
            this.LeftSidePanel.Size = new System.Drawing.Size(127, 370);
            this.LeftSidePanel.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(120, 120);
            this.panel3.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(0, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 43);
            this.panel2.TabIndex = 14;
            // 
            // SkinChangerButton
            // 
            this.SkinChangerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SkinChangerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SkinChangerButton.Location = new System.Drawing.Point(0, 274);
            this.SkinChangerButton.Name = "SkinChangerButton";
            this.SkinChangerButton.Size = new System.Drawing.Size(127, 43);
            this.SkinChangerButton.TabIndex = 17;
            this.SkinChangerButton.Text = "SkinChanger";
            this.SkinChangerButton.UseVisualStyleBackColor = true;
            this.SkinChangerButton.Click += new System.EventHandler(this.SkinChangerButton_Click);
            // 
            // MiscButton
            // 
            this.MiscButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MiscButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MiscButton.Location = new System.Drawing.Point(0, 225);
            this.MiscButton.Name = "MiscButton";
            this.MiscButton.Size = new System.Drawing.Size(127, 43);
            this.MiscButton.TabIndex = 16;
            this.MiscButton.Text = "Misc";
            this.MiscButton.UseVisualStyleBackColor = true;
            this.MiscButton.Click += new System.EventHandler(this.MiscButton_Click);
            // 
            // AimbotButton
            // 
            this.AimbotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AimbotButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AimbotButton.Location = new System.Drawing.Point(0, 176);
            this.AimbotButton.Name = "AimbotButton";
            this.AimbotButton.Size = new System.Drawing.Size(127, 43);
            this.AimbotButton.TabIndex = 15;
            this.AimbotButton.Text = "Aimbot";
            this.AimbotButton.UseVisualStyleBackColor = true;
            this.AimbotButton.Click += new System.EventHandler(this.AimbotButton_Click);
            // 
            // ESPButton
            // 
            this.ESPButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ESPButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ESPButton.Location = new System.Drawing.Point(0, 127);
            this.ESPButton.Name = "ESPButton";
            this.ESPButton.Size = new System.Drawing.Size(127, 43);
            this.ESPButton.TabIndex = 14;
            this.ESPButton.Text = "ESP";
            this.ESPButton.UseVisualStyleBackColor = true;
            this.ESPButton.Click += new System.EventHandler(this.ESPButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(127, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 50);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CRNYY\'s Cheat";
            // 
            // LoadSettingsButton
            // 
            this.LoadSettingsButton.Location = new System.Drawing.Point(130, 337);
            this.LoadSettingsButton.Name = "LoadSettingsButton";
            this.LoadSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.LoadSettingsButton.TabIndex = 89;
            this.LoadSettingsButton.Text = "Load";
            this.LoadSettingsButton.UseVisualStyleBackColor = true;
            this.LoadSettingsButton.Click += new System.EventHandler(this.LoadSettingsButton_Click);
            // 
            // SaveSettingsButton
            // 
            this.SaveSettingsButton.Location = new System.Drawing.Point(227, 337);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.SaveSettingsButton.TabIndex = 90;
            this.SaveSettingsButton.Text = "Save Settings";
            this.SaveSettingsButton.UseVisualStyleBackColor = true;
            this.SaveSettingsButton.Click += new System.EventHandler(this.SaveSettingsButton_Click);
            // 
            // ChoosenSettingsComboBox
            // 
            this.ChoosenSettingsComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Full Box",
            "Edge Box"});
            this.ChoosenSettingsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChoosenSettingsComboBox.FormattingEnabled = true;
            this.ChoosenSettingsComboBox.Items.AddRange(new object[] {
            "Legit",
            "Rage"});
            this.ChoosenSettingsComboBox.Location = new System.Drawing.Point(308, 337);
            this.ChoosenSettingsComboBox.Name = "ChoosenSettingsComboBox";
            this.ChoosenSettingsComboBox.Size = new System.Drawing.Size(113, 21);
            this.ChoosenSettingsComboBox.TabIndex = 150;
            this.ChoosenSettingsComboBox.SelectedIndexChanged += new System.EventHandler(this.ChoosenSettingsComboBox_SelectedIndexChanged);
            // 
            // ColorButton
            // 
            this.ColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ColorButton.Location = new System.Drawing.Point(0, 323);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(127, 43);
            this.ColorButton.TabIndex = 23;
            this.ColorButton.Text = "Colors";
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // ucColors1
            // 
            this.ucColors1.Location = new System.Drawing.Point(127, 52);
            this.ucColors1.Name = "ucColors1";
            this.ucColors1.Size = new System.Drawing.Size(386, 283);
            this.ucColors1.TabIndex = 151;
            // 
            // ucSkinChanger1
            // 
            this.ucSkinChanger1.Location = new System.Drawing.Point(129, 52);
            this.ucSkinChanger1.Name = "ucSkinChanger1";
            this.ucSkinChanger1.Size = new System.Drawing.Size(386, 279);
            this.ucSkinChanger1.TabIndex = 121;
            // 
            // ucMisc1
            // 
            this.ucMisc1.Location = new System.Drawing.Point(127, 56);
            this.ucMisc1.Name = "ucMisc1";
            this.ucMisc1.Size = new System.Drawing.Size(437, 253);
            this.ucMisc1.TabIndex = 120;
            // 
            // ucAimbot1
            // 
            this.ucAimbot1.Location = new System.Drawing.Point(127, 56);
            this.ucAimbot1.Name = "ucAimbot1";
            this.ucAimbot1.Size = new System.Drawing.Size(488, 279);
            this.ucAimbot1.TabIndex = 119;
            // 
            // ucesp1
            // 
            this.ucesp1.Location = new System.Drawing.Point(127, 56);
            this.ucesp1.Name = "ucesp1";
            this.ucesp1.Size = new System.Drawing.Size(488, 275);
            this.ucesp1.TabIndex = 118;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 370);
            this.Controls.Add(this.ucColors1);
            this.Controls.Add(this.ChoosenSettingsComboBox);
            this.Controls.Add(this.ucSkinChanger1);
            this.Controls.Add(this.ucMisc1);
            this.Controls.Add(this.ucAimbot1);
            this.Controls.Add(this.ucesp1);
            this.Controls.Add(this.SaveSettingsButton);
            this.Controls.Add(this.LoadSettingsButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LeftSidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "CRNYY\'s Cheat";
            this.LeftSidePanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel LeftSidePanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SkinChangerButton;
        private System.Windows.Forms.Button MiscButton;
        private System.Windows.Forms.Button AimbotButton;
        private System.Windows.Forms.Button ESPButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoadSettingsButton;
        private System.Windows.Forms.Button SaveSettingsButton;
        private Forms.UCESP ucesp1;
        private Forms.UCAimbot ucAimbot1;
        private Forms.UCMisc ucMisc1;
        private Forms.UCSkinChanger ucSkinChanger1;
        private System.Windows.Forms.ComboBox ChoosenSettingsComboBox;
        private System.Windows.Forms.Button ColorButton;
        private Forms.UCColors ucColors1;
    }
}

