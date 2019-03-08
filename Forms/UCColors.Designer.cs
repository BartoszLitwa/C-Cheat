namespace ZBase.Forms
{
    partial class UCColors
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.ComboBoxESPColors = new System.Windows.Forms.ComboBox();
            this.PanelColor = new System.Windows.Forms.Panel();
            this.TrackBarColorRed = new System.Windows.Forms.TrackBar();
            this.TrackBarColorGreen = new System.Windows.Forms.TrackBar();
            this.TrackBarColorBlue = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LBL_RED = new System.Windows.Forms.Label();
            this.LBL_GREEN = new System.Windows.Forms.Label();
            this.LBL_BLUE = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ButtonSetColor = new System.Windows.Forms.Button();
            this.PanelColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarColorRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarColorGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarColorBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Glow Colors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(131, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "ESP Colors";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(83, 199);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(92, 27);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(93, 199);
            this.listBox2.TabIndex = 3;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // ComboBoxESPColors
            // 
            this.ComboBoxESPColors.AutoCompleteCustomSource.AddRange(new string[] {
            "Full Box",
            "Edge Box"});
            this.ComboBoxESPColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxESPColors.FormattingEnabled = true;
            this.ComboBoxESPColors.Location = new System.Drawing.Point(261, 5);
            this.ComboBoxESPColors.Name = "ComboBoxESPColors";
            this.ComboBoxESPColors.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxESPColors.TabIndex = 123;
            this.ComboBoxESPColors.SelectedIndexChanged += new System.EventHandler(this.ComboBoxESPColors_SelectedIndexChanged);
            // 
            // PanelColor
            // 
            this.PanelColor.Controls.Add(this.ButtonSetColor);
            this.PanelColor.Location = new System.Drawing.Point(198, 32);
            this.PanelColor.Name = "PanelColor";
            this.PanelColor.Size = new System.Drawing.Size(184, 96);
            this.PanelColor.TabIndex = 124;
            // 
            // TrackBarColorRed
            // 
            this.TrackBarColorRed.BackColor = System.Drawing.Color.Red;
            this.TrackBarColorRed.Location = new System.Drawing.Point(235, 134);
            this.TrackBarColorRed.Maximum = 255;
            this.TrackBarColorRed.Name = "TrackBarColorRed";
            this.TrackBarColorRed.Size = new System.Drawing.Size(157, 45);
            this.TrackBarColorRed.TabIndex = 125;
            // 
            // TrackBarColorGreen
            // 
            this.TrackBarColorGreen.BackColor = System.Drawing.Color.Green;
            this.TrackBarColorGreen.Location = new System.Drawing.Point(235, 163);
            this.TrackBarColorGreen.Maximum = 255;
            this.TrackBarColorGreen.Name = "TrackBarColorGreen";
            this.TrackBarColorGreen.Size = new System.Drawing.Size(157, 45);
            this.TrackBarColorGreen.TabIndex = 126;
            // 
            // TrackBarColorBlue
            // 
            this.TrackBarColorBlue.BackColor = System.Drawing.Color.Blue;
            this.TrackBarColorBlue.Location = new System.Drawing.Point(235, 196);
            this.TrackBarColorBlue.Maximum = 255;
            this.TrackBarColorBlue.Name = "TrackBarColorBlue";
            this.TrackBarColorBlue.Size = new System.Drawing.Size(157, 45);
            this.TrackBarColorBlue.TabIndex = 127;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(195, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 128;
            this.label3.Text = "RED";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(185, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 129;
            this.label4.Text = "GREEN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(191, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 130;
            this.label5.Text = "BLUE";
            // 
            // LBL_RED
            // 
            this.LBL_RED.AutoSize = true;
            this.LBL_RED.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_RED.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_RED.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LBL_RED.Location = new System.Drawing.Point(194, 150);
            this.LBL_RED.Name = "LBL_RED";
            this.LBL_RED.Size = new System.Drawing.Size(30, 18);
            this.LBL_RED.TabIndex = 131;
            this.LBL_RED.Text = "     ";
            this.LBL_RED.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_GREEN
            // 
            this.LBL_GREEN.AutoSize = true;
            this.LBL_GREEN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_GREEN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_GREEN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LBL_GREEN.Location = new System.Drawing.Point(194, 180);
            this.LBL_GREEN.Name = "LBL_GREEN";
            this.LBL_GREEN.Size = new System.Drawing.Size(30, 18);
            this.LBL_GREEN.TabIndex = 132;
            this.LBL_GREEN.Text = "     ";
            this.LBL_GREEN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_BLUE
            // 
            this.LBL_BLUE.AutoSize = true;
            this.LBL_BLUE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_BLUE.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_BLUE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LBL_BLUE.Location = new System.Drawing.Point(194, 214);
            this.LBL_BLUE.Name = "LBL_BLUE";
            this.LBL_BLUE.Size = new System.Drawing.Size(30, 18);
            this.LBL_BLUE.TabIndex = 133;
            this.LBL_BLUE.Text = "     ";
            this.LBL_BLUE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ButtonSetColor
            // 
            this.ButtonSetColor.Location = new System.Drawing.Point(106, 70);
            this.ButtonSetColor.Name = "ButtonSetColor";
            this.ButtonSetColor.Size = new System.Drawing.Size(75, 23);
            this.ButtonSetColor.TabIndex = 0;
            this.ButtonSetColor.Text = "Set Color";
            this.ButtonSetColor.UseVisualStyleBackColor = true;
            // 
            // UCColors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LBL_BLUE);
            this.Controls.Add(this.LBL_GREEN);
            this.Controls.Add(this.LBL_RED);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TrackBarColorBlue);
            this.Controls.Add(this.TrackBarColorGreen);
            this.Controls.Add(this.TrackBarColorRed);
            this.Controls.Add(this.PanelColor);
            this.Controls.Add(this.ComboBoxESPColors);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCColors";
            this.Size = new System.Drawing.Size(397, 336);
            this.PanelColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarColorRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarColorGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarColorBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ComboBox ComboBoxESPColors;
        private System.Windows.Forms.Panel PanelColor;
        private System.Windows.Forms.TrackBar TrackBarColorRed;
        private System.Windows.Forms.TrackBar TrackBarColorGreen;
        private System.Windows.Forms.TrackBar TrackBarColorBlue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBL_RED;
        private System.Windows.Forms.Label LBL_GREEN;
        private System.Windows.Forms.Label LBL_BLUE;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button ButtonSetColor;
    }
}
