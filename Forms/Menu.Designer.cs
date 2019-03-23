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
            this.ColorButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadSettingsButton = new System.Windows.Forms.Button();
            this.SaveSettingsButton = new System.Windows.Forms.Button();
            this.ChoosenSettingsComboBox = new System.Windows.Forms.ComboBox();
            this.ucColors1 = new ZBase.Forms.UCColors();
            this.ucSkinChanger1 = new ZBase.Forms.UCSkinChanger();
            this.ucMisc1 = new ZBase.Forms.UCMisc();
            this.ucAimbot1 = new ZBase.Forms.UCAimbot();
            this.ucesp1 = new ZBase.Forms.UCESP();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            this.LeftSidePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LeftSidePanel.Name = "LeftSidePanel";
            this.LeftSidePanel.Size = new System.Drawing.Size(169, 455);
            this.LeftSidePanel.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(4, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 148);
            this.panel3.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(0, 156);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 53);
            this.panel2.TabIndex = 14;
            // 
            // SkinChangerButton
            // 
            this.SkinChangerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SkinChangerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SkinChangerButton.Location = new System.Drawing.Point(0, 337);
            this.SkinChangerButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SkinChangerButton.Name = "SkinChangerButton";
            this.SkinChangerButton.Size = new System.Drawing.Size(169, 53);
            this.SkinChangerButton.TabIndex = 17;
            this.SkinChangerButton.Text = "SkinChanger";
            this.SkinChangerButton.UseVisualStyleBackColor = true;
            this.SkinChangerButton.Click += new System.EventHandler(this.SkinChangerButton_Click);
            // 
            // MiscButton
            // 
            this.MiscButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MiscButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MiscButton.Location = new System.Drawing.Point(0, 277);
            this.MiscButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MiscButton.Name = "MiscButton";
            this.MiscButton.Size = new System.Drawing.Size(169, 53);
            this.MiscButton.TabIndex = 16;
            this.MiscButton.Text = "Misc";
            this.MiscButton.UseVisualStyleBackColor = true;
            this.MiscButton.Click += new System.EventHandler(this.MiscButton_Click);
            // 
            // AimbotButton
            // 
            this.AimbotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AimbotButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AimbotButton.Location = new System.Drawing.Point(0, 217);
            this.AimbotButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AimbotButton.Name = "AimbotButton";
            this.AimbotButton.Size = new System.Drawing.Size(169, 53);
            this.AimbotButton.TabIndex = 15;
            this.AimbotButton.Text = "Aimbot";
            this.AimbotButton.UseVisualStyleBackColor = true;
            this.AimbotButton.Click += new System.EventHandler(this.AimbotButton_Click);
            // 
            // ESPButton
            // 
            this.ESPButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ESPButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ESPButton.Location = new System.Drawing.Point(0, 156);
            this.ESPButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ESPButton.Name = "ESPButton";
            this.ESPButton.Size = new System.Drawing.Size(169, 53);
            this.ESPButton.TabIndex = 14;
            this.ESPButton.Text = "ESP";
            this.ESPButton.UseVisualStyleBackColor = true;
            this.ESPButton.Click += new System.EventHandler(this.ESPButton_Click);
            // 
            // ColorButton
            // 
            this.ColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ColorButton.Location = new System.Drawing.Point(0, 398);
            this.ColorButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(169, 53);
            this.ColorButton.TabIndex = 23;
            this.ColorButton.Text = "Colors";
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(169, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 62);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "CRNYY\'s Cheat";
            // 
            // LoadSettingsButton
            // 
            this.LoadSettingsButton.Location = new System.Drawing.Point(173, 415);
            this.LoadSettingsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadSettingsButton.Name = "LoadSettingsButton";
            this.LoadSettingsButton.Size = new System.Drawing.Size(100, 28);
            this.LoadSettingsButton.TabIndex = 89;
            this.LoadSettingsButton.Text = "Load";
            this.LoadSettingsButton.UseVisualStyleBackColor = true;
            this.LoadSettingsButton.Click += new System.EventHandler(this.LoadSettingsButton_Click);
            // 
            // SaveSettingsButton
            // 
            this.SaveSettingsButton.Location = new System.Drawing.Point(303, 415);
            this.SaveSettingsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.Size = new System.Drawing.Size(100, 28);
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
            this.ChoosenSettingsComboBox.Location = new System.Drawing.Point(411, 415);
            this.ChoosenSettingsComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChoosenSettingsComboBox.Name = "ChoosenSettingsComboBox";
            this.ChoosenSettingsComboBox.Size = new System.Drawing.Size(149, 24);
            this.ChoosenSettingsComboBox.TabIndex = 150;
            this.ChoosenSettingsComboBox.SelectedIndexChanged += new System.EventHandler(this.ChoosenSettingsComboBox_SelectedIndexChanged);
            // 
            // ucColors1
            // 
            this.ucColors1.Location = new System.Drawing.Point(194, 131);
            this.ucColors1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucColors1.Name = "ucColors1";
            this.ucColors1.Size = new System.Drawing.Size(490, 343);
            this.ucColors1.TabIndex = 151;
            this.ucColors1.Load += new System.EventHandler(this.ucColors1_Load);
            // 
            // ucSkinChanger1
            // 
            this.ucSkinChanger1.Location = new System.Drawing.Point(172, 64);
            this.ucSkinChanger1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucSkinChanger1.Name = "ucSkinChanger1";
            this.ucSkinChanger1.Size = new System.Drawing.Size(515, 343);
            this.ucSkinChanger1.TabIndex = 121;
            // 
            // ucMisc1
            // 
            this.ucMisc1.Location = new System.Drawing.Point(169, 69);
            this.ucMisc1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucMisc1.Name = "ucMisc1";
            this.ucMisc1.Size = new System.Drawing.Size(583, 311);
            this.ucMisc1.TabIndex = 120;
            // 
            // ucAimbot1
            // 
            this.ucAimbot1.Location = new System.Drawing.Point(169, 69);
            this.ucAimbot1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucAimbot1.Name = "ucAimbot1";
            this.ucAimbot1.Size = new System.Drawing.Size(651, 343);
            this.ucAimbot1.TabIndex = 119;
            // 
            // ucesp1
            // 
            this.ucesp1.Location = new System.Drawing.Point(169, 69);
            this.ucesp1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucesp1.Name = "ucesp1";
            this.ucesp1.Size = new System.Drawing.Size(651, 338);
            this.ucesp1.TabIndex = 118;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(495, 364);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 24);
            this.comboBox1.TabIndex = 152;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(169, 355);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 153;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 455);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "CRNYY\'s Cheat";
            this.Load += new System.EventHandler(this.Menu_Load);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

