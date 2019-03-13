namespace ZBase.Forms
{
    partial class UCSkinChanger
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
            this.label5 = new System.Windows.Forms.Label();
            this.ForceFullUpdateCheck = new System.Windows.Forms.Button();
            this.SkinChangerCheck = new System.Windows.Forms.CheckBox();
            this.WeaponNameComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SetSkinButton = new System.Windows.Forms.Button();
            this.KnifeChangerCheck = new System.Windows.Forms.CheckBox();
            this.KnifeChangerComboBox = new System.Windows.Forms.ComboBox();
            this.FasterChangersCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.KnifeSkinsComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 91;
            this.label5.Text = "Bind VK_END";
            // 
            // ForceFullUpdateCheck
            // 
            this.ForceFullUpdateCheck.Location = new System.Drawing.Point(6, 24);
            this.ForceFullUpdateCheck.Name = "ForceFullUpdateCheck";
            this.ForceFullUpdateCheck.Size = new System.Drawing.Size(75, 23);
            this.ForceFullUpdateCheck.TabIndex = 90;
            this.ForceFullUpdateCheck.Text = "ForceFullUpdate";
            this.ForceFullUpdateCheck.UseVisualStyleBackColor = true;
            this.ForceFullUpdateCheck.Click += new System.EventHandler(this.ForceFullUpdateCheck_Click);
            // 
            // SkinChangerCheck
            // 
            this.SkinChangerCheck.AutoSize = true;
            this.SkinChangerCheck.Location = new System.Drawing.Point(3, 3);
            this.SkinChangerCheck.Name = "SkinChangerCheck";
            this.SkinChangerCheck.Size = new System.Drawing.Size(87, 17);
            this.SkinChangerCheck.TabIndex = 89;
            this.SkinChangerCheck.Text = "SkinChanger";
            this.SkinChangerCheck.UseVisualStyleBackColor = true;
            this.SkinChangerCheck.CheckedChanged += new System.EventHandler(this.SkinChangerCheck_CheckedChanged);
            // 
            // WeaponNameComboBox
            // 
            this.WeaponNameComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Full Box",
            "Edge Box"});
            this.WeaponNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WeaponNameComboBox.FormattingEnabled = true;
            this.WeaponNameComboBox.Items.AddRange(new object[] {
            "Desert Eagle",
            "Dual Berettas",
            "Five-Seven",
            "Glock-18",
            "AK-47",
            "AUG",
            "AWP",
            "FAMAS",
            "G3SG1",
            "Galil",
            "M249",
            "M4A4",
            "MAC-10",
            "P90",
            "UMP-45",
            "XM1014",
            "PP-Bizon",
            "Mag-7",
            "Negev",
            "Sawed-Off",
            "Tec-9",
            "P2000",
            "MP7",
            "MP9",
            "Nova",
            "P250",
            "MP5",
            "SCAR-20",
            "SG 553",
            "SSG 08",
            "M4A1-S",
            "USP-S",
            "CZ75",
            "R8 Revolver"});
            this.WeaponNameComboBox.Location = new System.Drawing.Point(3, 174);
            this.WeaponNameComboBox.Name = "WeaponNameComboBox";
            this.WeaponNameComboBox.Size = new System.Drawing.Size(131, 21);
            this.WeaponNameComboBox.TabIndex = 134;
            this.WeaponNameComboBox.SelectedIndexChanged += new System.EventHandler(this.WeaponNameComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 135;
            this.label1.Text = "Weapon";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "-------Skins AK47-----------",
            "AK47 | Neon Rider - 707",
            "AK47 | The Empress - 675",
            "AK47 | Bloodsport - 639",
            "AK47 | Neon Revolution - 600",
            "AK47 | Fuel Injector - 524",
            "AK47 | Aquamarine Revenge - 474",
            "AK47 | Wasteland Rebel - 380",
            "AK47 | Jaguar - 316",
            "AK47 | Vulcan - 302",
            "AK47 | Fire Serpent - 180",
            "AK47 | Point Disarray - 506",
            "AK47 | Frontside Misty - 490",
            "AK47 | Cartel - 394",
            "AK47 | Redline - 282",
            "AK47 | Red Laminate - 14",
            "AK47 | Case Hardened - 44",
            "AK47 | Hydroponic - 456",
            "AK47 | Jet Set - 340",
            "AK47 | Orbit Mk01 - 656",
            "AK47 | Blue Laminate - 226",
            "AK47 | Safety Net - 795",
            "AK47 | First Class - 341",
            "AK47 | Emerald Pinstripe - 300",
            "AK47 | Elite Build - 422",
            "AK47 | Black Laminate - 172",
            "AK47 | Safari Mesh - 72",
            "AK47 | Jungle Spray - 122",
            "AK47 | Predator - 170",
            "------- Skins USP-S -----------",
            "USPS | Neo-Noir - 653",
            "USPS | Kill Confirmed - 504",
            "USPS | Cortex - 705",
            "USPS | Caiman - 339",
            "USPS | Orion - 313",
            "USPS | Serum - 221",
            "USPS | Cyrex - 637",
            "USPS | Guardian - 290",
            "USPS | Overgrowth - 183",
            "USPS | Dark Water - 60",
            "USPS | Road Rash - 318",
            "USPS | Blueprint - 657",
            "USPS | Lead Conduit - 540",
            "USPS | Torque - 489",
            "USPS | Blood Tiger - 217",
            "USPS | Stainless - 277",
            "USPS | Check Engine - 796",
            "USPS | Business Class - 364",
            "USPS | Night Ops - 236",
            "USPS | Para Green - 454",
            "USPS | Royal Blue - 332",
            "USPS | Forest Leaves - 25",
            "------- Skins M4A4 -----------",
            "M4A4 | Howl - 309",
            "M4A4 | Neo-Noir - 695",
            "M4A4 | Buzz Kill - 632",
            "M4A4 | The Battlestar - 533",
            "M4A4 | Royal Paladin - 512",
            "M4A4 | Bullet Rain - 155",
            "M4A4 | Desert-Strike - 336",
            "M4A4 | Asiimov - 255",
            "M4A4 | X-Ray - 215",
            "M4A4 | Hellfire - 664",
            "M4A4 | Desolate Space - 588",
            "M4A4 | (Dragon King) - 400",
            "M4A4 | Poseidon - 449",
            "M4A4 | Evil Daimyo - 480",
            "M4A4 | Griffin - 384",
            "M4A4 | Zirka - 187",
            "M4A4 | Daybreak - 471",
            "M4A4 | Modern Hunter - 164",
            "M4A4 | Faded Zebra - 176",
            "M4A4 | Converter - 793",
            "M4A4 | Radiation Hazard - 167",
            "M4A4 | Mainframe - 780",
            "M4A4 | Urban DDPAT - 17",
            "M4A4 | Tornado - 101",
            "M4A4 | Jungle Tiger - 16",
            "M4A4 | Desert Storm - 8",
            "------- Skins M4A1-S -----------",
            "M4A1S | Mecha Industries - 587",
            "M4A1S | Chantico\'s Fire - 548",
            "M4A1S | Golden Coil - 497",
            "M4A1S | Hyper Beast - 430",
            "M4A1S | Cyrex - 360",
            "M4A1S | Nightmare - 714",
            "M4A1S | Leaded Glass - 681",
            "M4A1S | Decimator - 644",
            "M4A1S | Atomic Alloy - 301",
            "M4A1S | Guardian - 257",
            "M4A1S | Control Panel - 792",
            "M4A1S | Hot Rod - 445",
            "M4A1S | Knight - 326",
            "M4A1S | Master Piece - 321",
            "M4A1S | Flashback - 631",
            "M4A1S | Basilisk - 383",
            "M4A1S | Bright Water - 189",
            "M4A1S | Dark Water - 60",
            "M4A1S | Icarus Fell - 440",
            "M4A1S | Nitro - 254",
            "M4A1S | Briefing - 663",
            "M4A1S | Blood Tiger - 217",
            "M4A1S | VariCamo - 235",
            "M4A1S | Boreal Forest - 77",
            "------- Skins AWP -----------",
            "AWP | Oni Taiji - 662",
            "AWP | Hyper Beast - 475",
            "AWP | Man-o\'-war - 395",
            "AWP | Asiimov - 279",
            "AWP | Lightning Strike - 51",
            "AWP | Medusa - 446",
            "AWP | Dragon Lore - 344",
            "AWP | Mortis - 691",
            "AWP | Fever Dream - 640",
            "AWP | Elite Build - 525",
            "AWP | Corticera - 181",
            "AWP | Redline - 259",
            "AWP | Electric Hive - 227",
            "AWP | Graphite - 212",
            "AWP | BOOM - 174",
            "AWP | PAW - 718",
            "AWP | Phobos - 584",
            "AWP | Worm God - 424",
            "AWP | Pink DDPAT - 84",
            "AWP | Pit Viper - 251",
            "AWP | Acheron - 788",
            "AWP | Snake Camo - 30",
            "AWP | Sun in Leo - 451",
            "AWP | Safari Mesh - 72",
            "------- Skins Deagle -----------",
            "DESERTEAGLE | Code Red - 711",
            "DESERTEAGLE | Golden Koi - 185",
            "DESERTEAGLE | Kumicho Dragon - 527",
            "DESERTEAGLE | Conspiracy - 351",
            "DESERTEAGLE | Cobalt Disruption - 231",
            "DESERTEAGLE | Hypnotic - 61",
            "DESERTEAGLE | Directive - 603",
            "DESERTEAGLE | Naga - 397",
            "DESERTEAGLE | Crimson Web - 232",
            "DESERTEAGLE | Heirloom - 273",
            "DESERTEAGLE | Sunset Storm - 469",
            "DESERTEAGLE | Sunset Storm - 470",
            "DESERTEAGLE | Hand Cannon - 328",
            "DESERTEAGLE | Pilot - 347",
            "DESERTEAGLE | Blaze - 37",
            "DESERTEAGLE | Oxide Blaze - 645",
            "DESERTEAGLE | Corinthian - 509",
            "DESERTEAGLE | Bronze Deco - 425",
            "DESERTEAGLE | Meteorite - 296",
            "DESERTEAGLE | Urban Rubble - 237",
            "DESERTEAGLE | Night - 40",
            "DESERTEAGLE | Midnight Storm - 468",
            "DESERTEAGLE | Urban DDPAT - 17",
            "DESERTEAGLE | Mudder - 90",
            "------- Skins Glock-----------",
            "GLOCK18 | Wasteland Rebel - 586",
            "GLOCK18 | Water Elemental - 353",
            "GLOCK18 | Twilight Galaxy - 437",
            "GLOCK18 | Moonrise - 694",
            "GLOCK18 | Weasel - 607",
            "GLOCK18 | Royal Legion - 532",
            "GLOCK18 | Grinder - 381",
            "GLOCK18 | Steel Disruption - 230",
            "GLOCK18 | Dragon Tattoo - 48",
            "GLOCK18 | Nuclear Garden - 789",
            "GLOCK18 | Fade - 38",
            "GLOCK18 | Brass - 159",
            "GLOCK18 | Warhawk - 713",
            "GLOCK18 | Off World - 680",
            "GLOCK18 | Ironwork - 623",
            "GLOCK18 | Wraiths - 495",
            "GLOCK18 | Bunsen Burner - 479",
            "GLOCK18 | Catacombs - 399",
            "GLOCK18 | Blue Fissure - 278",
            "GLOCK18 | Reactor - 367",
            "GLOCK18 | Candy Apple - 3",
            "GLOCK18 | High Beam - 799",
            "GLOCK18 | Night - 40",
            "GLOCK18 | Death Rattle - 293",
            "GLOCK18 | Groundwater - 2",
            "GLOCK18 | Sand Dune - 208"});
            this.listBox1.Location = new System.Drawing.Point(140, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(243, 277);
            this.listBox1.TabIndex = 136;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // SetSkinButton
            // 
            this.SetSkinButton.Location = new System.Drawing.Point(3, 201);
            this.SetSkinButton.Name = "SetSkinButton";
            this.SetSkinButton.Size = new System.Drawing.Size(75, 23);
            this.SetSkinButton.TabIndex = 137;
            this.SetSkinButton.Text = "Set Skin";
            this.SetSkinButton.UseVisualStyleBackColor = true;
            this.SetSkinButton.Click += new System.EventHandler(this.SetSkinButton_Click);
            // 
            // KnifeChangerCheck
            // 
            this.KnifeChangerCheck.AutoSize = true;
            this.KnifeChangerCheck.Location = new System.Drawing.Point(3, 66);
            this.KnifeChangerCheck.Name = "KnifeChangerCheck";
            this.KnifeChangerCheck.Size = new System.Drawing.Size(90, 17);
            this.KnifeChangerCheck.TabIndex = 138;
            this.KnifeChangerCheck.Text = "KnifeChanger";
            this.KnifeChangerCheck.UseVisualStyleBackColor = true;
            this.KnifeChangerCheck.CheckedChanged += new System.EventHandler(this.KnifeChangerCheck_CheckedChanged);
            // 
            // KnifeChangerComboBox
            // 
            this.KnifeChangerComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Full Box",
            "Edge Box"});
            this.KnifeChangerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KnifeChangerComboBox.FormattingEnabled = true;
            this.KnifeChangerComboBox.Items.AddRange(new object[] {
            "Bayonet",
            "Flip Knife",
            "Karambit",
            "M9 Bayonet",
            "Butterfly",
            "Falchion",
            "Bowie",
            "Gut Knife",
            "Talon",
            "Stiletto",
            "Ursus",
            "Shadow Daggers",
            "Huntsman",
            "Navaja",
            "Fists"});
            this.KnifeChangerComboBox.Location = new System.Drawing.Point(3, 89);
            this.KnifeChangerComboBox.Name = "KnifeChangerComboBox";
            this.KnifeChangerComboBox.Size = new System.Drawing.Size(131, 21);
            this.KnifeChangerComboBox.TabIndex = 139;
            this.KnifeChangerComboBox.SelectedIndexChanged += new System.EventHandler(this.KnifeChangerComboBox_SelectedIndexChanged);
            // 
            // FasterChangersCheck
            // 
            this.FasterChangersCheck.AutoSize = true;
            this.FasterChangersCheck.Location = new System.Drawing.Point(3, 263);
            this.FasterChangersCheck.Name = "FasterChangersCheck";
            this.FasterChangersCheck.Size = new System.Drawing.Size(103, 17);
            this.FasterChangersCheck.TabIndex = 140;
            this.FasterChangersCheck.Text = "Faster Changers";
            this.FasterChangersCheck.UseVisualStyleBackColor = true;
            this.FasterChangersCheck.CheckedChanged += new System.EventHandler(this.FasterChangersCheck_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 141;
            this.label2.Text = "Only for good PC";
            // 
            // KnifeSkinsComboBox
            // 
            this.KnifeSkinsComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Full Box",
            "Edge Box"});
            this.KnifeSkinsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KnifeSkinsComboBox.FormattingEnabled = true;
            this.KnifeSkinsComboBox.Location = new System.Drawing.Point(3, 134);
            this.KnifeSkinsComboBox.Name = "KnifeSkinsComboBox";
            this.KnifeSkinsComboBox.Size = new System.Drawing.Size(131, 21);
            this.KnifeSkinsComboBox.TabIndex = 142;
            this.KnifeSkinsComboBox.SelectedIndexChanged += new System.EventHandler(this.KnifeSkinsComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 143;
            this.label3.Text = "Knife\'s Skins";
            // 
            // UCSkinChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.KnifeSkinsComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FasterChangersCheck);
            this.Controls.Add(this.KnifeChangerComboBox);
            this.Controls.Add(this.KnifeChangerCheck);
            this.Controls.Add(this.SetSkinButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WeaponNameComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ForceFullUpdateCheck);
            this.Controls.Add(this.SkinChangerCheck);
            this.Name = "UCSkinChanger";
            this.Size = new System.Drawing.Size(452, 317);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ForceFullUpdateCheck;
        private System.Windows.Forms.CheckBox SkinChangerCheck;
        private System.Windows.Forms.ComboBox WeaponNameComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button SetSkinButton;
        private System.Windows.Forms.CheckBox KnifeChangerCheck;
        private System.Windows.Forms.ComboBox KnifeChangerComboBox;
        private System.Windows.Forms.CheckBox FasterChangersCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox KnifeSkinsComboBox;
        private System.Windows.Forms.Label label3;
    }
}
