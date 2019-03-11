namespace ZBase.Forms
{
    partial class UCESP
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
            this.GlowValueTXT = new System.Windows.Forms.TextBox();
            this.ChamsValueTXT = new System.Windows.Forms.TextBox();
            this.comboBoxCrosshair = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SnapLineThicTrackBar = new System.Windows.Forms.TrackBar();
            this.DrawArmorcheck = new System.Windows.Forms.CheckBox();
            this.HealthBarLeftSideCheck = new System.Windows.Forms.CheckBox();
            this.DrawScopedCheck = new System.Windows.Forms.CheckBox();
            this.SnapLinesCheck = new System.Windows.Forms.CheckBox();
            this.HealthBarCheck = new System.Windows.Forms.CheckBox();
            this.DrawDistanceCheck = new System.Windows.Forms.CheckBox();
            this.WeaponCheck = new System.Windows.Forms.CheckBox();
            this.HealthCheck = new System.Windows.Forms.CheckBox();
            this.BoneESPMapComboBox = new System.Windows.Forms.ComboBox();
            this.BoneESPCheck = new System.Windows.Forms.CheckBox();
            this.ChamsCheck = new System.Windows.Forms.CheckBox();
            this.RadarHackCheck = new System.Windows.Forms.CheckBox();
            this.GlowCheck = new System.Windows.Forms.CheckBox();
            this.DrawSmartCrosshairCheck = new System.Windows.Forms.CheckBox();
            this.CrosshairSniperCheck = new System.Windows.Forms.CheckBox();
            this.RecoilCrosshairCheck = new System.Windows.Forms.CheckBox();
            this.DrawBondeIdsCheck = new System.Windows.Forms.CheckBox();
            this.ESPBoxCheck = new System.Windows.Forms.CheckBox();
            this.comboBoxESP = new System.Windows.Forms.ComboBox();
            this.ESPCheck = new System.Windows.Forms.CheckBox();
            this.GlowTeammatesCheck = new System.Windows.Forms.CheckBox();
            this.ChamsTeammatesCheck = new System.Windows.Forms.CheckBox();
            this.BoneTeammatesCheck = new System.Windows.Forms.CheckBox();
            this.BoxTeammatesCheck = new System.Windows.Forms.CheckBox();
            this.SnapLinesTeammatesCheck = new System.Windows.Forms.CheckBox();
            this.WeaponESPCheck = new System.Windows.Forms.CheckBox();
            this.SnapLinesPoscomboBox = new System.Windows.Forms.ComboBox();
            this.DebugCheck = new System.Windows.Forms.CheckBox();
            this.ShowRanksCheck = new System.Windows.Forms.CheckBox();
            this.ShowWinsCheck = new System.Windows.Forms.CheckBox();
            this.ShowNamesCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.SnapLineThicTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // GlowValueTXT
            // 
            this.GlowValueTXT.Location = new System.Drawing.Point(85, 208);
            this.GlowValueTXT.Name = "GlowValueTXT";
            this.GlowValueTXT.Size = new System.Drawing.Size(38, 20);
            this.GlowValueTXT.TabIndex = 141;
            this.GlowValueTXT.Text = "1";
            this.GlowValueTXT.TextChanged += new System.EventHandler(this.GlowValueTXT_TextChanged);
            // 
            // ChamsValueTXT
            // 
            this.ChamsValueTXT.Location = new System.Drawing.Point(85, 251);
            this.ChamsValueTXT.Name = "ChamsValueTXT";
            this.ChamsValueTXT.Size = new System.Drawing.Size(38, 20);
            this.ChamsValueTXT.TabIndex = 140;
            this.ChamsValueTXT.Text = "1";
            this.ChamsValueTXT.TextChanged += new System.EventHandler(this.ChamsValueTXT_TextChanged);
            // 
            // comboBoxCrosshair
            // 
            this.comboBoxCrosshair.AutoCompleteCustomSource.AddRange(new string[] {
            "Full Box",
            "Edge Box"});
            this.comboBoxCrosshair.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCrosshair.FormattingEnabled = true;
            this.comboBoxCrosshair.Items.AddRange(new object[] {
            "Dot Crosshair",
            "Plus Crosshair",
            "Cross Crosshair",
            "Gap Crosshair",
            "Diagonal Crosshair"});
            this.comboBoxCrosshair.Location = new System.Drawing.Point(129, 47);
            this.comboBoxCrosshair.Name = "comboBoxCrosshair";
            this.comboBoxCrosshair.Size = new System.Drawing.Size(113, 21);
            this.comboBoxCrosshair.TabIndex = 139;
            this.comboBoxCrosshair.SelectedIndexChanged += new System.EventHandler(this.comboBoxCrosshair_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 138;
            this.label2.Text = "SnapLine Thic";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SnapLineThicTrackBar
            // 
            this.SnapLineThicTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SnapLineThicTrackBar.Location = new System.Drawing.Point(255, 69);
            this.SnapLineThicTrackBar.Maximum = 15;
            this.SnapLineThicTrackBar.Name = "SnapLineThicTrackBar";
            this.SnapLineThicTrackBar.Size = new System.Drawing.Size(121, 45);
            this.SnapLineThicTrackBar.TabIndex = 137;
            this.SnapLineThicTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.SnapLineThicTrackBar.Value = 2;
            this.SnapLineThicTrackBar.Scroll += new System.EventHandler(this.SnapLineThicTrackBar_Scroll);
            // 
            // DrawArmorcheck
            // 
            this.DrawArmorcheck.AutoSize = true;
            this.DrawArmorcheck.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.DrawArmorcheck.Location = new System.Drawing.Point(129, 97);
            this.DrawArmorcheck.Name = "DrawArmorcheck";
            this.DrawArmorcheck.Size = new System.Drawing.Size(83, 17);
            this.DrawArmorcheck.TabIndex = 136;
            this.DrawArmorcheck.Text = "Armor Value";
            this.DrawArmorcheck.UseVisualStyleBackColor = true;
            this.DrawArmorcheck.CheckedChanged += new System.EventHandler(this.DrawArmorcheck_CheckedChanged);
            // 
            // HealthBarLeftSideCheck
            // 
            this.HealthBarLeftSideCheck.AutoSize = true;
            this.HealthBarLeftSideCheck.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.HealthBarLeftSideCheck.Location = new System.Drawing.Point(129, 146);
            this.HealthBarLeftSideCheck.Name = "HealthBarLeftSideCheck";
            this.HealthBarLeftSideCheck.Size = new System.Drawing.Size(112, 17);
            this.HealthBarLeftSideCheck.TabIndex = 135;
            this.HealthBarLeftSideCheck.Text = "HealthBarLeftSide";
            this.HealthBarLeftSideCheck.UseVisualStyleBackColor = true;
            this.HealthBarLeftSideCheck.CheckedChanged += new System.EventHandler(this.HealthBarLeftSideCheck_CheckedChanged);
            // 
            // DrawScopedCheck
            // 
            this.DrawScopedCheck.AutoSize = true;
            this.DrawScopedCheck.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.DrawScopedCheck.Location = new System.Drawing.Point(129, 170);
            this.DrawScopedCheck.Name = "DrawScopedCheck";
            this.DrawScopedCheck.Size = new System.Drawing.Size(63, 17);
            this.DrawScopedCheck.TabIndex = 134;
            this.DrawScopedCheck.Text = "Scoped";
            this.DrawScopedCheck.UseVisualStyleBackColor = true;
            this.DrawScopedCheck.CheckedChanged += new System.EventHandler(this.DrawScopedCheck_CheckedChanged);
            // 
            // SnapLinesCheck
            // 
            this.SnapLinesCheck.AutoSize = true;
            this.SnapLinesCheck.Location = new System.Drawing.Point(255, 28);
            this.SnapLinesCheck.Name = "SnapLinesCheck";
            this.SnapLinesCheck.Size = new System.Drawing.Size(76, 17);
            this.SnapLinesCheck.TabIndex = 133;
            this.SnapLinesCheck.Text = "SnapLines";
            this.SnapLinesCheck.UseVisualStyleBackColor = true;
            this.SnapLinesCheck.CheckedChanged += new System.EventHandler(this.SnapLinesCheck_CheckedChanged);
            // 
            // HealthBarCheck
            // 
            this.HealthBarCheck.AutoSize = true;
            this.HealthBarCheck.Location = new System.Drawing.Point(129, 124);
            this.HealthBarCheck.Name = "HealthBarCheck";
            this.HealthBarCheck.Size = new System.Drawing.Size(73, 17);
            this.HealthBarCheck.TabIndex = 132;
            this.HealthBarCheck.Text = "HealthBar";
            this.HealthBarCheck.UseVisualStyleBackColor = true;
            this.HealthBarCheck.CheckedChanged += new System.EventHandler(this.HealthBarCheck_CheckedChanged);
            // 
            // DrawDistanceCheck
            // 
            this.DrawDistanceCheck.AutoSize = true;
            this.DrawDistanceCheck.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.DrawDistanceCheck.Location = new System.Drawing.Point(1, 170);
            this.DrawDistanceCheck.Name = "DrawDistanceCheck";
            this.DrawDistanceCheck.Size = new System.Drawing.Size(68, 17);
            this.DrawDistanceCheck.TabIndex = 131;
            this.DrawDistanceCheck.Text = "Distance";
            this.DrawDistanceCheck.UseVisualStyleBackColor = true;
            this.DrawDistanceCheck.CheckedChanged += new System.EventHandler(this.DrawDistanceCheck_CheckedChanged);
            // 
            // WeaponCheck
            // 
            this.WeaponCheck.AutoSize = true;
            this.WeaponCheck.Location = new System.Drawing.Point(1, 147);
            this.WeaponCheck.Name = "WeaponCheck";
            this.WeaponCheck.Size = new System.Drawing.Size(67, 17);
            this.WeaponCheck.TabIndex = 130;
            this.WeaponCheck.Text = "Weapon";
            this.WeaponCheck.UseVisualStyleBackColor = true;
            this.WeaponCheck.CheckedChanged += new System.EventHandler(this.WeaponCheck_CheckedChanged);
            // 
            // HealthCheck
            // 
            this.HealthCheck.AutoSize = true;
            this.HealthCheck.Location = new System.Drawing.Point(1, 124);
            this.HealthCheck.Name = "HealthCheck";
            this.HealthCheck.Size = new System.Drawing.Size(57, 17);
            this.HealthCheck.TabIndex = 129;
            this.HealthCheck.Text = "Health";
            this.HealthCheck.UseVisualStyleBackColor = true;
            this.HealthCheck.CheckedChanged += new System.EventHandler(this.HealthCheck_CheckedChanged);
            // 
            // BoneESPMapComboBox
            // 
            this.BoneESPMapComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Full Box",
            "Edge Box"});
            this.BoneESPMapComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoneESPMapComboBox.FormattingEnabled = true;
            this.BoneESPMapComboBox.Items.AddRange(new object[] {
            "Mirage",
            "Cache",
            "Dust2",
            "Inferno",
            "Cobblestone",
            "Train",
            "Overpass",
            "Nuke",
            "Office"});
            this.BoneESPMapComboBox.Location = new System.Drawing.Point(1, 97);
            this.BoneESPMapComboBox.Name = "BoneESPMapComboBox";
            this.BoneESPMapComboBox.Size = new System.Drawing.Size(95, 21);
            this.BoneESPMapComboBox.TabIndex = 128;
            this.BoneESPMapComboBox.SelectedIndexChanged += new System.EventHandler(this.BoneESPMapComboBox_SelectedIndexChanged);
            // 
            // BoneESPCheck
            // 
            this.BoneESPCheck.AutoSize = true;
            this.BoneESPCheck.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BoneESPCheck.Location = new System.Drawing.Point(1, 74);
            this.BoneESPCheck.Name = "BoneESPCheck";
            this.BoneESPCheck.Size = new System.Drawing.Size(75, 17);
            this.BoneESPCheck.TabIndex = 127;
            this.BoneESPCheck.Text = "Bone ESP";
            this.BoneESPCheck.UseVisualStyleBackColor = true;
            this.BoneESPCheck.CheckedChanged += new System.EventHandler(this.BoneESPCheck_CheckedChanged);
            // 
            // ChamsCheck
            // 
            this.ChamsCheck.AutoSize = true;
            this.ChamsCheck.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ChamsCheck.Location = new System.Drawing.Point(1, 254);
            this.ChamsCheck.Name = "ChamsCheck";
            this.ChamsCheck.Size = new System.Drawing.Size(58, 17);
            this.ChamsCheck.TabIndex = 126;
            this.ChamsCheck.Text = "Chams";
            this.ChamsCheck.UseVisualStyleBackColor = true;
            this.ChamsCheck.CheckedChanged += new System.EventHandler(this.ChamsCheck_CheckedChanged);
            // 
            // RadarHackCheck
            // 
            this.RadarHackCheck.AutoSize = true;
            this.RadarHackCheck.Location = new System.Drawing.Point(1, 233);
            this.RadarHackCheck.Name = "RadarHackCheck";
            this.RadarHackCheck.Size = new System.Drawing.Size(81, 17);
            this.RadarHackCheck.TabIndex = 125;
            this.RadarHackCheck.Text = "RadarHack";
            this.RadarHackCheck.UseVisualStyleBackColor = true;
            this.RadarHackCheck.CheckedChanged += new System.EventHandler(this.RadarHackCheck_CheckedChanged);
            // 
            // GlowCheck
            // 
            this.GlowCheck.AutoSize = true;
            this.GlowCheck.Location = new System.Drawing.Point(1, 210);
            this.GlowCheck.Name = "GlowCheck";
            this.GlowCheck.Size = new System.Drawing.Size(50, 17);
            this.GlowCheck.TabIndex = 124;
            this.GlowCheck.Text = "Glow";
            this.GlowCheck.UseVisualStyleBackColor = true;
            this.GlowCheck.CheckedChanged += new System.EventHandler(this.GlowCheck_CheckedChanged);
            // 
            // DrawSmartCrosshairCheck
            // 
            this.DrawSmartCrosshairCheck.AutoSize = true;
            this.DrawSmartCrosshairCheck.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.DrawSmartCrosshairCheck.Location = new System.Drawing.Point(129, 74);
            this.DrawSmartCrosshairCheck.Name = "DrawSmartCrosshairCheck";
            this.DrawSmartCrosshairCheck.Size = new System.Drawing.Size(99, 17);
            this.DrawSmartCrosshairCheck.TabIndex = 123;
            this.DrawSmartCrosshairCheck.Text = "Smart Crosshair";
            this.DrawSmartCrosshairCheck.UseVisualStyleBackColor = true;
            this.DrawSmartCrosshairCheck.CheckedChanged += new System.EventHandler(this.DrawSmartCrosshairCheck_CheckedChanged);
            // 
            // CrosshairSniperCheck
            // 
            this.CrosshairSniperCheck.AutoSize = true;
            this.CrosshairSniperCheck.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CrosshairSniperCheck.Location = new System.Drawing.Point(129, 24);
            this.CrosshairSniperCheck.Name = "CrosshairSniperCheck";
            this.CrosshairSniperCheck.Size = new System.Drawing.Size(99, 17);
            this.CrosshairSniperCheck.TabIndex = 122;
            this.CrosshairSniperCheck.Text = "CrosshairSniper";
            this.CrosshairSniperCheck.UseVisualStyleBackColor = true;
            this.CrosshairSniperCheck.CheckedChanged += new System.EventHandler(this.CrosshairSniperCheck_CheckedChanged);
            // 
            // RecoilCrosshairCheck
            // 
            this.RecoilCrosshairCheck.AutoSize = true;
            this.RecoilCrosshairCheck.Location = new System.Drawing.Point(129, 4);
            this.RecoilCrosshairCheck.Name = "RecoilCrosshairCheck";
            this.RecoilCrosshairCheck.Size = new System.Drawing.Size(99, 17);
            this.RecoilCrosshairCheck.TabIndex = 121;
            this.RecoilCrosshairCheck.Text = "RecoilCrosshair";
            this.RecoilCrosshairCheck.UseVisualStyleBackColor = true;
            this.RecoilCrosshairCheck.CheckedChanged += new System.EventHandler(this.RecoilCrosshairCheck_CheckedChanged);
            // 
            // DrawBondeIdsCheck
            // 
            this.DrawBondeIdsCheck.AutoSize = true;
            this.DrawBondeIdsCheck.Location = new System.Drawing.Point(255, 4);
            this.DrawBondeIdsCheck.Name = "DrawBondeIdsCheck";
            this.DrawBondeIdsCheck.Size = new System.Drawing.Size(67, 17);
            this.DrawBondeIdsCheck.TabIndex = 120;
            this.DrawBondeIdsCheck.Text = "BoneIDs";
            this.DrawBondeIdsCheck.UseVisualStyleBackColor = true;
            this.DrawBondeIdsCheck.CheckedChanged += new System.EventHandler(this.DrawBondeIdsCheck_CheckedChanged);
            // 
            // ESPBoxCheck
            // 
            this.ESPBoxCheck.AutoSize = true;
            this.ESPBoxCheck.Location = new System.Drawing.Point(1, 28);
            this.ESPBoxCheck.Name = "ESPBoxCheck";
            this.ESPBoxCheck.Size = new System.Drawing.Size(68, 17);
            this.ESPBoxCheck.TabIndex = 119;
            this.ESPBoxCheck.Text = "ESP Box";
            this.ESPBoxCheck.UseVisualStyleBackColor = true;
            this.ESPBoxCheck.CheckedChanged += new System.EventHandler(this.ESPBoxCheck_CheckedChanged);
            // 
            // comboBoxESP
            // 
            this.comboBoxESP.AutoCompleteCustomSource.AddRange(new string[] {
            "Full Box",
            "Edge Box"});
            this.comboBoxESP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxESP.FormattingEnabled = true;
            this.comboBoxESP.Items.AddRange(new object[] {
            "Box",
            "Full Box",
            "Edge Box",
            "Filled Box",
            "Rounded Box"});
            this.comboBoxESP.Location = new System.Drawing.Point(1, 47);
            this.comboBoxESP.Name = "comboBoxESP";
            this.comboBoxESP.Size = new System.Drawing.Size(95, 21);
            this.comboBoxESP.TabIndex = 118;
            this.comboBoxESP.SelectedIndexChanged += new System.EventHandler(this.comboBoxESP_SelectedIndexChanged);
            // 
            // ESPCheck
            // 
            this.ESPCheck.AutoSize = true;
            this.ESPCheck.Location = new System.Drawing.Point(1, 3);
            this.ESPCheck.Name = "ESPCheck";
            this.ESPCheck.Size = new System.Drawing.Size(86, 17);
            this.ESPCheck.TabIndex = 117;
            this.ESPCheck.Text = "Overlay ESP";
            this.ESPCheck.UseVisualStyleBackColor = true;
            this.ESPCheck.CheckedChanged += new System.EventHandler(this.ESPCheck_CheckedChanged);
            // 
            // GlowTeammatesCheck
            // 
            this.GlowTeammatesCheck.AutoSize = true;
            this.GlowTeammatesCheck.Location = new System.Drawing.Point(129, 210);
            this.GlowTeammatesCheck.Name = "GlowTeammatesCheck";
            this.GlowTeammatesCheck.Size = new System.Drawing.Size(108, 17);
            this.GlowTeammatesCheck.TabIndex = 143;
            this.GlowTeammatesCheck.Text = "Glow Teammates";
            this.GlowTeammatesCheck.UseVisualStyleBackColor = true;
            this.GlowTeammatesCheck.CheckedChanged += new System.EventHandler(this.GlowTeammatesCheck_CheckedChanged);
            // 
            // ChamsTeammatesCheck
            // 
            this.ChamsTeammatesCheck.AutoSize = true;
            this.ChamsTeammatesCheck.Location = new System.Drawing.Point(129, 253);
            this.ChamsTeammatesCheck.Name = "ChamsTeammatesCheck";
            this.ChamsTeammatesCheck.Size = new System.Drawing.Size(116, 17);
            this.ChamsTeammatesCheck.TabIndex = 144;
            this.ChamsTeammatesCheck.Text = "Chams Teammates";
            this.ChamsTeammatesCheck.UseVisualStyleBackColor = true;
            this.ChamsTeammatesCheck.CheckedChanged += new System.EventHandler(this.ChamsTeammatesCheck_CheckedChanged);
            // 
            // BoneTeammatesCheck
            // 
            this.BoneTeammatesCheck.AutoSize = true;
            this.BoneTeammatesCheck.Location = new System.Drawing.Point(129, 231);
            this.BoneTeammatesCheck.Name = "BoneTeammatesCheck";
            this.BoneTeammatesCheck.Size = new System.Drawing.Size(109, 17);
            this.BoneTeammatesCheck.TabIndex = 145;
            this.BoneTeammatesCheck.Text = "Bone Teammates";
            this.BoneTeammatesCheck.UseVisualStyleBackColor = true;
            this.BoneTeammatesCheck.CheckedChanged += new System.EventHandler(this.BoneTeammatesCheck_CheckedChanged);
            // 
            // BoxTeammatesCheck
            // 
            this.BoxTeammatesCheck.AutoSize = true;
            this.BoxTeammatesCheck.Location = new System.Drawing.Point(255, 210);
            this.BoxTeammatesCheck.Name = "BoxTeammatesCheck";
            this.BoxTeammatesCheck.Size = new System.Drawing.Size(102, 17);
            this.BoxTeammatesCheck.TabIndex = 146;
            this.BoxTeammatesCheck.Text = "Box Teammates";
            this.BoxTeammatesCheck.UseVisualStyleBackColor = true;
            this.BoxTeammatesCheck.CheckedChanged += new System.EventHandler(this.BoxTeammatesCheck_CheckedChanged);
            // 
            // SnapLinesTeammatesCheck
            // 
            this.SnapLinesTeammatesCheck.AutoSize = true;
            this.SnapLinesTeammatesCheck.Location = new System.Drawing.Point(255, 233);
            this.SnapLinesTeammatesCheck.Name = "SnapLinesTeammatesCheck";
            this.SnapLinesTeammatesCheck.Size = new System.Drawing.Size(134, 17);
            this.SnapLinesTeammatesCheck.TabIndex = 147;
            this.SnapLinesTeammatesCheck.Text = "SnapLines Teammates";
            this.SnapLinesTeammatesCheck.UseVisualStyleBackColor = true;
            this.SnapLinesTeammatesCheck.CheckedChanged += new System.EventHandler(this.SnapLinesTeammatesCheck_CheckedChanged);
            // 
            // WeaponESPCheck
            // 
            this.WeaponESPCheck.AutoSize = true;
            this.WeaponESPCheck.Location = new System.Drawing.Point(1, 193);
            this.WeaponESPCheck.Name = "WeaponESPCheck";
            this.WeaponESPCheck.Size = new System.Drawing.Size(88, 17);
            this.WeaponESPCheck.TabIndex = 148;
            this.WeaponESPCheck.Text = "WeaponESP";
            this.WeaponESPCheck.UseVisualStyleBackColor = true;
            this.WeaponESPCheck.CheckedChanged += new System.EventHandler(this.WeaponESPCheck_CheckedChanged);
            // 
            // SnapLinesPoscomboBox
            // 
            this.SnapLinesPoscomboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Full Box",
            "Edge Box"});
            this.SnapLinesPoscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SnapLinesPoscomboBox.FormattingEnabled = true;
            this.SnapLinesPoscomboBox.Items.AddRange(new object[] {
            "Top",
            "Bottom",
            "Right",
            "Left",
            "Mid"});
            this.SnapLinesPoscomboBox.Location = new System.Drawing.Point(255, 47);
            this.SnapLinesPoscomboBox.Name = "SnapLinesPoscomboBox";
            this.SnapLinesPoscomboBox.Size = new System.Drawing.Size(113, 21);
            this.SnapLinesPoscomboBox.TabIndex = 149;
            this.SnapLinesPoscomboBox.SelectedIndexChanged += new System.EventHandler(this.SnapLinesPoscomboBox_SelectedIndexChanged);
            // 
            // DebugCheck
            // 
            this.DebugCheck.AutoSize = true;
            this.DebugCheck.Location = new System.Drawing.Point(255, 253);
            this.DebugCheck.Name = "DebugCheck";
            this.DebugCheck.Size = new System.Drawing.Size(58, 17);
            this.DebugCheck.TabIndex = 150;
            this.DebugCheck.Text = "Debug";
            this.DebugCheck.UseVisualStyleBackColor = true;
            this.DebugCheck.CheckedChanged += new System.EventHandler(this.DebugCheck_CheckedChanged);
            // 
            // ShowRanksCheck
            // 
            this.ShowRanksCheck.AutoSize = true;
            this.ShowRanksCheck.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ShowRanksCheck.Location = new System.Drawing.Point(254, 124);
            this.ShowRanksCheck.Name = "ShowRanksCheck";
            this.ShowRanksCheck.Size = new System.Drawing.Size(87, 17);
            this.ShowRanksCheck.TabIndex = 151;
            this.ShowRanksCheck.Text = "Show Ranks";
            this.ShowRanksCheck.UseVisualStyleBackColor = true;
            this.ShowRanksCheck.CheckedChanged += new System.EventHandler(this.ShowRanksCheck_CheckedChanged);
            // 
            // ShowWinsCheck
            // 
            this.ShowWinsCheck.AutoSize = true;
            this.ShowWinsCheck.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ShowWinsCheck.Location = new System.Drawing.Point(254, 147);
            this.ShowWinsCheck.Name = "ShowWinsCheck";
            this.ShowWinsCheck.Size = new System.Drawing.Size(80, 17);
            this.ShowWinsCheck.TabIndex = 152;
            this.ShowWinsCheck.Text = "Show Wins";
            this.ShowWinsCheck.UseVisualStyleBackColor = true;
            this.ShowWinsCheck.CheckedChanged += new System.EventHandler(this.ShowWinsCheck_CheckedChanged);
            // 
            // ShowNamesCheck
            // 
            this.ShowNamesCheck.AutoSize = true;
            this.ShowNamesCheck.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ShowNamesCheck.Location = new System.Drawing.Point(254, 170);
            this.ShowNamesCheck.Name = "ShowNamesCheck";
            this.ShowNamesCheck.Size = new System.Drawing.Size(89, 17);
            this.ShowNamesCheck.TabIndex = 153;
            this.ShowNamesCheck.Text = "Show Names";
            this.ShowNamesCheck.UseVisualStyleBackColor = true;
            this.ShowNamesCheck.CheckedChanged += new System.EventHandler(this.ShowNamesCheck_CheckedChanged);
            // 
            // UCESP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ShowNamesCheck);
            this.Controls.Add(this.ShowWinsCheck);
            this.Controls.Add(this.ShowRanksCheck);
            this.Controls.Add(this.DebugCheck);
            this.Controls.Add(this.SnapLinesPoscomboBox);
            this.Controls.Add(this.WeaponESPCheck);
            this.Controls.Add(this.SnapLinesTeammatesCheck);
            this.Controls.Add(this.BoxTeammatesCheck);
            this.Controls.Add(this.BoneTeammatesCheck);
            this.Controls.Add(this.ChamsTeammatesCheck);
            this.Controls.Add(this.GlowTeammatesCheck);
            this.Controls.Add(this.GlowValueTXT);
            this.Controls.Add(this.ChamsValueTXT);
            this.Controls.Add(this.comboBoxCrosshair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SnapLineThicTrackBar);
            this.Controls.Add(this.DrawArmorcheck);
            this.Controls.Add(this.HealthBarLeftSideCheck);
            this.Controls.Add(this.DrawScopedCheck);
            this.Controls.Add(this.SnapLinesCheck);
            this.Controls.Add(this.HealthBarCheck);
            this.Controls.Add(this.DrawDistanceCheck);
            this.Controls.Add(this.WeaponCheck);
            this.Controls.Add(this.HealthCheck);
            this.Controls.Add(this.BoneESPMapComboBox);
            this.Controls.Add(this.BoneESPCheck);
            this.Controls.Add(this.ChamsCheck);
            this.Controls.Add(this.RadarHackCheck);
            this.Controls.Add(this.GlowCheck);
            this.Controls.Add(this.DrawSmartCrosshairCheck);
            this.Controls.Add(this.CrosshairSniperCheck);
            this.Controls.Add(this.RecoilCrosshairCheck);
            this.Controls.Add(this.DrawBondeIdsCheck);
            this.Controls.Add(this.ESPBoxCheck);
            this.Controls.Add(this.comboBoxESP);
            this.Controls.Add(this.ESPCheck);
            this.Name = "UCESP";
            this.Size = new System.Drawing.Size(385, 303);
            ((System.ComponentModel.ISupportInitialize)(this.SnapLineThicTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GlowValueTXT;
        private System.Windows.Forms.TextBox ChamsValueTXT;
        private System.Windows.Forms.ComboBox comboBoxCrosshair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar SnapLineThicTrackBar;
        private System.Windows.Forms.CheckBox DrawArmorcheck;
        private System.Windows.Forms.CheckBox HealthBarLeftSideCheck;
        private System.Windows.Forms.CheckBox DrawScopedCheck;
        private System.Windows.Forms.CheckBox SnapLinesCheck;
        private System.Windows.Forms.CheckBox HealthBarCheck;
        private System.Windows.Forms.CheckBox DrawDistanceCheck;
        private System.Windows.Forms.CheckBox WeaponCheck;
        private System.Windows.Forms.CheckBox HealthCheck;
        private System.Windows.Forms.ComboBox BoneESPMapComboBox;
        private System.Windows.Forms.CheckBox BoneESPCheck;
        private System.Windows.Forms.CheckBox ChamsCheck;
        private System.Windows.Forms.CheckBox RadarHackCheck;
        private System.Windows.Forms.CheckBox GlowCheck;
        private System.Windows.Forms.CheckBox DrawSmartCrosshairCheck;
        private System.Windows.Forms.CheckBox CrosshairSniperCheck;
        private System.Windows.Forms.CheckBox RecoilCrosshairCheck;
        private System.Windows.Forms.CheckBox DrawBondeIdsCheck;
        private System.Windows.Forms.CheckBox ESPBoxCheck;
        private System.Windows.Forms.ComboBox comboBoxESP;
        private System.Windows.Forms.CheckBox ESPCheck;
        private System.Windows.Forms.CheckBox GlowTeammatesCheck;
        private System.Windows.Forms.CheckBox ChamsTeammatesCheck;
        private System.Windows.Forms.CheckBox BoneTeammatesCheck;
        private System.Windows.Forms.CheckBox BoxTeammatesCheck;
        private System.Windows.Forms.CheckBox SnapLinesTeammatesCheck;
        private System.Windows.Forms.CheckBox WeaponESPCheck;
        private System.Windows.Forms.ComboBox SnapLinesPoscomboBox;
        private System.Windows.Forms.CheckBox DebugCheck;
        private System.Windows.Forms.CheckBox ShowRanksCheck;
        private System.Windows.Forms.CheckBox ShowWinsCheck;
        private System.Windows.Forms.CheckBox ShowNamesCheck;
    }
}
