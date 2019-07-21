using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using ZBase.Utilities;
using ZBase.Classes;
using System.Linq;

namespace ZBase.Forms
{
    public partial class UCSkinChanger : UserControl
    {
        public bool SetSkin = false;
        public List<string> items = new List<string>();
        public UCSkinChanger()
        {
            InitializeComponent();
        }

        public void UCSkinChanger_Load()
        {
            if (Main.S.SkinChangerEnabled)
                SkinChangerCheck.CheckState = CheckState.Checked;
            if (Main.S.KnifeChangerEnabled)
                KnifeChangerCheck.CheckState = CheckState.Checked;
            if (Main.S.FasterChangersEnabled)
                FasterChangersCheck.CheckState = CheckState.Checked;
            StatTrakValueTextBox.Text = Main.S.StatTrakValue.ToString();
            FloatWearValue.Text = Main.S.FloatWearValue.ToString();
            if (Main.S.FloatWearValue == 0) Main.S.FloatWearValue = 1;
            FloatValueTrackBar.Value = (int)(Main.S.FloatWearValue * 1000);
            //////////////////////////////////////////////////////
            if (!Main.S.SkinChangerEnabled)
                SkinChangerCheck.CheckState = CheckState.Unchecked;
            if (!Main.S.KnifeChangerEnabled)
                KnifeChangerCheck.CheckState = CheckState.Unchecked;
            if (!Main.S.FasterChangersEnabled)
                FasterChangersCheck.CheckState = CheckState.Unchecked;

            foreach (string item in listBox1.Items)
                items.Add(item);

            switch (Main.S.SelectedKnife)
            {
                case "Bayonet":
                    KnifeChangerComboBox.SelectedIndex = 0;
                    break;
                case "Flip Knife":
                    KnifeChangerComboBox.SelectedIndex = 1;
                    break;
                case "Karambit":
                    KnifeChangerComboBox.SelectedIndex = 2;
                    break;
                case "M9 Bayonet":
                    KnifeChangerComboBox.SelectedIndex = 3;
                    break;
                case "Butterfly":
                    KnifeChangerComboBox.SelectedIndex = 4;
                    break;
                case "Falchion":
                    KnifeChangerComboBox.SelectedIndex = 5;
                    break;
                case "Bowie":
                    KnifeChangerComboBox.SelectedIndex = 6;
                    break;
                case "Gut Knife":
                    KnifeChangerComboBox.SelectedIndex = 7;
                    break;
                case "Talon":
                    KnifeChangerComboBox.SelectedIndex = 8;
                    break;
                case "Stiletto":
                    KnifeChangerComboBox.SelectedIndex = 9;
                    break;
                case "Ursus":
                    KnifeChangerComboBox.SelectedIndex = 10;
                    break;
                case "Shadow Daggers":
                    KnifeChangerComboBox.SelectedIndex = 11;
                    break;
                case "Huntsman":
                    KnifeChangerComboBox.SelectedIndex = 12;
                    break;
                case "Navaja":
                    KnifeChangerComboBox.SelectedIndex = 13;
                    break;
                case "Fists":
                    KnifeChangerComboBox.SelectedIndex = 14;
                    break;
                default:
                    break;
            }

            KnifeSkinsComboBox.Items.Clear();
            KnifeSkinsComboBox.Items.Add("Fade");
            KnifeSkinsComboBox.Items.Add("CrimsonWeb");
            KnifeSkinsComboBox.Items.Add("Marble_Fade");
            KnifeSkinsComboBox.Items.Add("CaseHardened");
            KnifeSkinsComboBox.Items.Add("TigerTooth");
            KnifeSkinsComboBox.Items.Add("Doppler_SAPPHIRE");
            KnifeSkinsComboBox.Items.Add("Doppler_RUBY");
            KnifeSkinsComboBox.Items.Add("Doppler_BLACKPEARL");
            KnifeSkinsComboBox.Items.Add("Doppler_1");
            KnifeSkinsComboBox.Items.Add("Doppler_2");
            KnifeSkinsComboBox.Items.Add("Doppler_3");
            KnifeSkinsComboBox.Items.Add("Doppler_PHASE1");
            KnifeSkinsComboBox.Items.Add("Doppler_PHASE2");
            KnifeSkinsComboBox.Items.Add("Doppler_PHASE3");
            KnifeSkinsComboBox.Items.Add("Doppler_PHASE4");
            KnifeSkinsComboBox.Items.Add("GammaDoppler_EMERALD");
            KnifeSkinsComboBox.Items.Add("GammaDoppler_PHASE1");
            KnifeSkinsComboBox.Items.Add("GammaDoppler_PHASE2");
            KnifeSkinsComboBox.Items.Add("GammaDoppler_PHASE3");
            KnifeSkinsComboBox.Items.Add("GammaDoppler_PHASE4");
            KnifeSkinsComboBox.Items.Add("Slaughter");
            KnifeSkinsComboBox.Items.Add("Ultraviolet");
            KnifeSkinsComboBox.Items.Add("Ultraviolet_1");
            KnifeSkinsComboBox.Items.Add("Ultraviolet_2");
            KnifeSkinsComboBox.Items.Add("Lore_M9BAYONET");
            KnifeSkinsComboBox.Items.Add("Lore_KARAMBIT");
            KnifeSkinsComboBox.Items.Add("Lore_GUT");
            KnifeSkinsComboBox.Items.Add("Lore_FLIP");
            KnifeSkinsComboBox.Items.Add("Lore_BAYONET");
            KnifeSkinsComboBox.Items.Add("Autotronic_M9BAYONET");
            KnifeSkinsComboBox.Items.Add("Autotronic_KARAMBIT");
            KnifeSkinsComboBox.Items.Add("Autotronic_GUT");
            KnifeSkinsComboBox.Items.Add("Autotronic_FLIP");
            KnifeSkinsComboBox.Items.Add("Autotronic_BAYONET");
            KnifeSkinsComboBox.Items.Add("Freehand_M9BAYONET");
            KnifeSkinsComboBox.Items.Add("Freehand_KARAMBIT");
            KnifeSkinsComboBox.Items.Add("Freehand");
            KnifeSkinsComboBox.Items.Add("BrightWater_M9BAYONET");
            KnifeSkinsComboBox.Items.Add("BrightWater");
            KnifeSkinsComboBox.Items.Add("RustCoat");
            KnifeSkinsComboBox.Items.Add("RustCoat_2");
            KnifeSkinsComboBox.Items.Add("RustCoat_3");
            KnifeSkinsComboBox.Items.Add("ForestDDPAT");
            KnifeSkinsComboBox.Items.Add("SafariMesh");
            KnifeSkinsComboBox.Items.Add("Stained");

            switch (Main.S.SelectedKnifeSkin)
            {
                case 0:
                    KnifeSkinsComboBox.SelectedIndex = 0;
                    break;
                case 1:
                    KnifeSkinsComboBox.SelectedIndex = 1;
                    break;
                case 2:
                    KnifeSkinsComboBox.SelectedIndex = 2;
                    break;
                case 3:
                    KnifeSkinsComboBox.SelectedIndex = 3;
                    break;
                case 4:
                    KnifeSkinsComboBox.SelectedIndex = 4;
                    break;
                case 5:
                    KnifeSkinsComboBox.SelectedIndex = 5;
                    break;
                case 6:
                    KnifeSkinsComboBox.SelectedIndex = 6;
                    break;
                case 7:
                    KnifeSkinsComboBox.SelectedIndex = 7;
                    break;
                case 8:
                    KnifeSkinsComboBox.SelectedIndex = 8;
                    break;
                case 9:
                    KnifeSkinsComboBox.SelectedIndex = 9;
                    break;
                case 10:
                    KnifeSkinsComboBox.SelectedIndex = 10;
                    break;
                case 11:
                    KnifeSkinsComboBox.SelectedIndex = 11;
                    break;
                case 12:
                    KnifeSkinsComboBox.SelectedIndex = 12;
                    break;
                case 13:
                    KnifeSkinsComboBox.SelectedIndex = 13;
                    break;
                case 14:
                    KnifeSkinsComboBox.SelectedIndex = 14;
                    break;
                case 15:
                    KnifeSkinsComboBox.SelectedIndex = 15;
                    break;
                case 16:
                    KnifeSkinsComboBox.SelectedIndex = 16;
                    break;
                case 17:
                    KnifeSkinsComboBox.SelectedIndex = 17;
                    break;
                case 18:
                    KnifeSkinsComboBox.SelectedIndex = 18;
                    break;
                case 19:
                    KnifeSkinsComboBox.SelectedIndex = 19;
                    break;
                case 20:
                    KnifeSkinsComboBox.SelectedIndex = 20;
                    break;
                case 21:
                    KnifeSkinsComboBox.SelectedIndex = 21;
                    break;
                case 22:
                    KnifeSkinsComboBox.SelectedIndex = 22;
                    break;
                case 23:
                    KnifeSkinsComboBox.SelectedIndex = 23;
                    break;
                case 24:
                    KnifeSkinsComboBox.SelectedIndex = 24;
                    break;
                case 25:
                    KnifeSkinsComboBox.SelectedIndex = 25;
                    break;
                case 26:
                    KnifeSkinsComboBox.SelectedIndex = 26;
                    break;
                case 27:
                    KnifeSkinsComboBox.SelectedIndex = 27;
                    break;
                case 28:
                    KnifeSkinsComboBox.SelectedIndex = 28;
                    break;
                case 29:
                    KnifeSkinsComboBox.SelectedIndex = 29;
                    break;
                case 30:
                    KnifeSkinsComboBox.SelectedIndex = 30;
                    break;
                case 31:
                    KnifeSkinsComboBox.SelectedIndex = 31;
                    break;
                case 32:
                    KnifeSkinsComboBox.SelectedIndex = 32;
                    break;
                case 33:
                    KnifeSkinsComboBox.SelectedIndex = 33;
                    break;
                case 34:
                    KnifeSkinsComboBox.SelectedIndex = 34;
                    break;
                case 35:
                    KnifeSkinsComboBox.SelectedIndex = 35;
                    break;
                case 36:
                    KnifeSkinsComboBox.SelectedIndex = 36;
                    break;
                case 37:
                    KnifeSkinsComboBox.SelectedIndex = 37;
                    break;
                case 38:
                    KnifeSkinsComboBox.SelectedIndex = 38;
                    break;
                case 39:
                    KnifeSkinsComboBox.SelectedIndex = 39;
                    break;
                case 40:
                    KnifeSkinsComboBox.SelectedIndex = 40;
                    break;
                case 41:
                    KnifeSkinsComboBox.SelectedIndex = 41;
                    break;
                case 42:
                    KnifeSkinsComboBox.SelectedIndex = 42;
                    break;
                case 43:
                    KnifeSkinsComboBox.SelectedIndex = 43;
                    break;
                default:
                    break;
            }
        }
        private void KnifeSkinsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (KnifeSkinsComboBox.SelectedItem.ToString())
            {
                case "Fade":
                    Main.S.SelectedKnifeSkin = 0;
                    break;
                case "CrimsonWeb":
                    Main.S.SelectedKnifeSkin = 1;
                    break;
                case "Marble_Fade":
                    Main.S.SelectedKnifeSkin = 2;
                    break;
                case "CaseHardened":
                    Main.S.SelectedKnifeSkin = 3;
                    break;
                case "TigerTooth":
                    Main.S.SelectedKnifeSkin = 4;
                    break;
                case "Doppler_SAPPHIRE":
                    Main.S.SelectedKnifeSkin = 5;
                    break;
                case "Doppler_RUBY":
                    Main.S.SelectedKnifeSkin = 6;
                    break;
                case "Doppler_BLACKPEARL":
                    Main.S.SelectedKnifeSkin = 7;
                    break;
                case "Doppler_1":
                    Main.S.SelectedKnifeSkin = 8;
                    break;
                case "Doppler_2":
                    Main.S.SelectedKnifeSkin = 9;
                    break;
                case "Doppler_3":
                    Main.S.SelectedKnifeSkin = 10;
                    break;
                case "Doppler_PHASE1":
                    Main.S.SelectedKnifeSkin = 11;
                    break;
                case "Doppler_PHASE2":
                    Main.S.SelectedKnifeSkin = 12;
                    break;
                case "Doppler_PHASE3":
                    Main.S.SelectedKnifeSkin = 13;
                    break;
                case "Doppler_PHASE4":
                    Main.S.SelectedKnifeSkin = 14;
                    break;
                case "GammaDoppler_EMERALD":
                    Main.S.SelectedKnifeSkin = 15;
                    break;
                case "GammaDoppler_PHASE1":
                    Main.S.SelectedKnifeSkin = 16;
                    break;
                case "GammaDoppler_PHASE2":
                    Main.S.SelectedKnifeSkin = 17;
                    break;
                case "GammaDoppler_PHASE3":
                    Main.S.SelectedKnifeSkin = 18;
                    break;
                case "GammaDoppler_PHASE4":
                    Main.S.SelectedKnifeSkin = 19;
                    break;
                case "Slaughter":
                    Main.S.SelectedKnifeSkin = 20;
                    break;
                case "Ultraviolet":
                    Main.S.SelectedKnifeSkin = 21;
                    break;
                case "Ultraviolet_1":
                    Main.S.SelectedKnifeSkin = 22;
                    break;
                case "Ultraviolet_2":
                    Main.S.SelectedKnifeSkin = 23;
                    break;
                case "Lore_M9BAYONET":
                    Main.S.SelectedKnifeSkin = 24;
                    break;
                case "Lore_KARAMBIT":
                    Main.S.SelectedKnifeSkin = 25;
                    break;
                case "Lore_GUT":
                    Main.S.SelectedKnifeSkin = 26;
                    break;
                case "Lore_FLIP":
                    Main.S.SelectedKnifeSkin = 27;
                    break;
                case "Lore_BAYONET":
                    Main.S.SelectedKnifeSkin = 28;
                    break;
                case "Autotronic_M9BAYONET":
                    Main.S.SelectedKnifeSkin = 29;
                    break;
                case "Autotronic_KARAMBIT":
                    Main.S.SelectedKnifeSkin = 30;
                    break;
                case "Autotronic_GUT":
                    Main.S.SelectedKnifeSkin = 31;
                    break;
                case "Autotronic_FLIP":
                    Main.S.SelectedKnifeSkin = 32;
                    break;
                case "Autotronic_BAYONET":
                    Main.S.SelectedKnifeSkin = 33;
                    break;
                case "Freehand_M9BAYONET":
                    Main.S.SelectedKnifeSkin = 34;
                    break;
                case "Freehand":
                    Main.S.SelectedKnifeSkin = 35;
                    break;
                case "BrightWater_M9BAYONET":
                    Main.S.SelectedKnifeSkin = 36;
                    break;
                case "BrightWater":
                    Main.S.SelectedKnifeSkin = 37;
                    break;
                case "RustCoat":
                    Main.S.SelectedKnifeSkin = 38;
                    break;
                case "RustCoat_2":
                    Main.S.SelectedKnifeSkin = 39;
                    break;
                case "RustCoat_3":
                    Main.S.SelectedKnifeSkin = 40;
                    break;
                case "ForestDDPAT":
                    Main.S.SelectedKnifeSkin = 41;
                    break;
                case "SafariMesh":
                    Main.S.SelectedKnifeSkin = 42;
                    break;
                case "Stained":
                    Main.S.SelectedKnifeSkin = 43;
                    break;
                default:
                    break;
            }
        }

        private void SkinChangerCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (SkinChangerCheck.Checked)
            {
                Main.S.SkinChangerEnabled = true;
            }
            else
                Main.S.SkinChangerEnabled = false;
        }

        private void ForceFullUpdateCheck_Click(object sender, EventArgs e)
        {
            Main.S.ForceFullUpdate = true;
            Thread.Sleep(10);
            Main.S.ForceFullUpdate = false;
        }
        private void WeaponNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                switch (WeaponNameComboBox.SelectedItem.ToString())
                {
                    case "Desert Eagle":

                        Main.S.SkinDeasertEagle = Main.I.Selectedskin;
                        break;
                    case "Dual Berettas":

                        Main.S.SkinDualBerettas = Main.I.Selectedskin;
                        break;
                    case "Five-Seven":

                        Main.S.SkinFiveSeven = Main.I.Selectedskin;
                        break;
                    case "Glock-18":

                        Main.S.SkinGlock18 = Main.I.Selectedskin;
                        break;
                    case "AK-47":

                        Main.S.SkinAK47 = Main.I.Selectedskin;
                        break;
                    case "AUG":

                        Main.S.SkinAUG = Main.I.Selectedskin;
                        break;
                    case "AWP":

                        Main.S.SkinAWP = Main.I.Selectedskin;
                        break;
                    case "FAMAS":

                        Main.S.SkinFamas = Main.I.Selectedskin;
                        break;
                    case "G3SG1":

                        Main.S.SkinG3SG1 = Main.I.Selectedskin;
                        break;
                    case "Galil":

                        Main.S.SkinGalilAR = Main.I.Selectedskin;
                        break;
                    case "M249":

                        Main.S.SkinM249 = Main.I.Selectedskin;
                        break;
                    case "M4A4":

                        Main.S.SkinM4A4 = Main.I.Selectedskin;
                        break;
                    case "MAC-10":

                        Main.S.SkinMac10 = Main.I.Selectedskin;
                        break;
                    case "P90":

                        Main.S.SkinP90 = Main.I.Selectedskin;
                        break;
                    case "UMP-45":

                        Main.S.SkinUMP45 = Main.I.Selectedskin;
                        break;
                    case "XM1014":

                        Main.S.SkinXM1014 = Main.I.Selectedskin;
                        break;
                    case "PP-Bizon":

                        Main.S.SkinPPBizon = Main.I.Selectedskin;
                        break;
                    case "Mag-7":

                        Main.S.SkinMag7 = Main.I.Selectedskin;
                        break;
                    case "Negev":

                        Main.S.SkinNegev = Main.I.Selectedskin;
                        break;
                    case "Sawed-Off":

                        Main.S.SkinSawedOff = Main.I.Selectedskin;
                        break;
                    case "Tec-9":

                        Main.S.SkinTec9 = Main.I.Selectedskin;
                        break;
                    case "P2000":

                        Main.S.SkinP2000 = Main.I.Selectedskin;
                        break;
                    case "MP7":

                        Main.S.SkinMP7 = Main.I.Selectedskin;
                        break;
                    case "MP9":

                        Main.S.SkinMP9 = Main.I.Selectedskin;
                        break;
                    case "Nova":

                        Main.S.SkinNova = Main.I.Selectedskin;
                        break;
                    case "P250":

                        Main.S.SkinP250 = Main.I.Selectedskin;
                        break;
                    case "MP5":

                        Main.S.SkinMP5 = Main.I.Selectedskin;
                        break;
                    case "SCAR-20":

                        Main.S.SkinSCAR20 = Main.I.Selectedskin;
                        break;
                    case "SG 553":

                        Main.S.SkinSG553 = Main.I.Selectedskin;
                        break;
                    case "SSG 08":

                        Main.S.SkinSSG08 = Main.I.Selectedskin;
                        break;
                    case "M4A1-S":

                        Main.S.SkinM4A1S = Main.I.Selectedskin;
                        break;
                    case "USP-S":

                        Main.S.SkinUSPS = Main.I.Selectedskin;
                        break;
                    case "CZ75":

                        Main.S.SkinCZ75 = Main.I.Selectedskin;
                        break;
                    case "R8 Revolver":
                        //Main.S.skinr = Main.I.Selectedskin;
                        break;
                    default:
                        break;
                }
        }

        private void SetSkinButton_Click(object sender, EventArgs e)
        {
            string currentiteam = WeaponNameComboBox.SelectedItem.ToString();
            WeaponNameComboBox.SelectedItem = "R8 Revolver";
            WeaponNameComboBox.SelectedItem = currentiteam;
            Thread.Sleep(10);
            ForceFullUpdateCheck_Click(sender,e);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) //Lista skinow https://www.unknowncheats.me/forum/counterstrike-global-offensive/304876-skin-id-list.html
        {
            switch (listBox1.SelectedItem.ToString())
            {
                //////////////////////// AK47 Skins /////////////////////////////////////////
                case "AK47 | Neon Rider - 707":
                    Main.I.Selectedskin = 707;
                    break;
                case "AK47 | The Empress - 675":
                    Main.I.Selectedskin = 675;
                    break;
                case "AK47 | Bloodsport - 639":
                    Main.I.Selectedskin = 639;
                    break;
                case "AK47 | Neon Revolution - 600":
                    Main.I.Selectedskin = 600;
                    break;
                case "AK47 | Fuel Injector - 524":
                    Main.I.Selectedskin = 524;
                    break;
                case "AK47 | Aquamarine Revenge - 474":
                    Main.I.Selectedskin = 474;
                    break;
                case "AK47 | Wasteland Rebel - 380":
                    Main.I.Selectedskin = 380;
                    break;
                case "AK47 | Jaguar - 316":
                    Main.I.Selectedskin = 316;
                    break;
                case "AK47 | Vulcan - 302":
                    Main.I.Selectedskin = 302;
                    break;
                case "AK47 | Fire Serpent - 180":
                    Main.I.Selectedskin = 180;
                    break;
                case "AK47 | Point Disarray - 506":
                    Main.I.Selectedskin = 506;
                    break;
                case "AK47 | Frontside Misty - 490":
                    Main.I.Selectedskin = 490;
                    break;
                case "AK47 | Cartel - 394":
                    Main.I.Selectedskin = 394;
                    break;
                case "AK47 | Redline - 282":
                    Main.I.Selectedskin = 282;
                    break;
                case "AK47 | Red Laminate - 14":
                    Main.I.Selectedskin = 14;
                    break;
                case "AK47 | Case Hardened - 44":
                    Main.I.Selectedskin = 44;
                    break;
                case "AK47 | Hydroponic - 456":
                    Main.I.Selectedskin = 456;
                    break;
                case "AK47 | Jet Set - 340":
                    Main.I.Selectedskin = 340;
                    break;
                case "AK47 | Orbit Mk01 - 656":
                    Main.I.Selectedskin = 656;
                    break;
                case "AK47 | Blue Laminate - 226":
                    Main.I.Selectedskin = 226;
                    break;
                case "AK47 | Safety Net - 795":
                    Main.I.Selectedskin = 795;
                    break;
                case "AK47 | First Class - 341":
                    Main.I.Selectedskin = 341;
                    break;
                case "AK47 | Emerald Pinstripe - 300":
                    Main.I.Selectedskin = 300;
                    break;
                case "AK47 | Elite Build - 422":
                    Main.I.Selectedskin = 422;
                    break;
                case "AK47 | Black Laminate - 172":
                    Main.I.Selectedskin = 172;
                    break;
                case "AK47 | Safari Mesh - 72":
                    Main.I.Selectedskin = 72;
                    break;
                case "AK47 | Jungle Spray - 122":
                    Main.I.Selectedskin = 122;
                    break;
                case "AK47 | Predator - 170":
                    Main.I.Selectedskin = 170;
                    break;
                    //////////////////////// USP-S Skins /////////////////////////////////////////
                case "USPS | Neo-Noir - 653":
                    Main.I.Selectedskin = 653;
                    break;
                case "USPS | Kill Confirmed - 504":
                    Main.I.Selectedskin = 504;
                    break;
                case "USPS | Cortex - 705":
                    Main.I.Selectedskin = 705;
                    break;
                case "USPS | Caiman - 339":
                    Main.I.Selectedskin = 339;
                    break;
                case "USPS | Orion - 313":
                    Main.I.Selectedskin = 313;
                    break;
                case "USPS | Serum - 221":
                    Main.I.Selectedskin = 221;
                    break;
                case "USPS | Cyrex - 637":
                    Main.I.Selectedskin = 637;
                    break;
                case "USPS | Guardian - 290":
                    Main.I.Selectedskin = 290;
                    break;
                case "USPS | Overgrowth - 183":
                    Main.I.Selectedskin = 183;
                    break;
                case "USPS | Dark Water - 60":
                    Main.I.Selectedskin = 60;
                    break;
                case "USPS | Road Rash - 318":
                    Main.I.Selectedskin = 318;
                    break;
                case "USPS | Blueprint - 657":
                    Main.I.Selectedskin = 657;
                    break;
                case "USPS | Lead Conduit - 540":
                    Main.I.Selectedskin = 540;
                    break;
                case "USPS | Torque - 489":
                    Main.I.Selectedskin = 489;
                    break;
                case "USPS | Blood Tiger - 217":
                    Main.I.Selectedskin = 217;
                    break;
                case "USPS | Stainless - 277":
                    Main.I.Selectedskin = 277;
                    break;
                case "USPS | Check Engine - 796":
                    Main.I.Selectedskin = 796;
                    break;
                case "USPS | Business Class - 364":
                    Main.I.Selectedskin = 364;
                    break;
                case "USPS | Night Ops - 236":
                    Main.I.Selectedskin = 236;
                    break;
                case "USPS | Para Green - 454":
                    Main.I.Selectedskin = 454;
                    break;
                case "USPS | Royal Blue - 332":
                    Main.I.Selectedskin = 332;
                    break;
                case "USPS | Forest Leaves - 25":
                    Main.I.Selectedskin = 25;
                    break;
                //////////////////////// M4A4 Skins /////////////////////////////////////////
                case "M4A4 | Howl - 309":
                    Main.I.Selectedskin = 309;
                    break;
                case "M4A4 | Neo-Noir - 695":
                    Main.I.Selectedskin = 695;
                    break;
                case "M4A4 | Buzz Kill - 632":
                    Main.I.Selectedskin = 632;
                    break;
                case "M4A4 | The Battlestar - 533":
                    Main.I.Selectedskin = 533;
                    break;
                case "M4A4 | Royal Paladin - 512":
                    Main.I.Selectedskin = 512;
                    break;
                case "M4A4 | Bullet Rain - 155":
                    Main.I.Selectedskin = 155;
                    break;
                case "M4A4 | Desert-Strike - 336":
                    Main.I.Selectedskin = 336;
                    break;
                case "M4A4 | Asiimov - 255":
                    Main.I.Selectedskin = 255;
                    break;
                case "M4A4 | X-Ray - 215":
                    Main.I.Selectedskin = 215;
                    break;
                case "M4A4 | Hellfire - 664":
                    Main.I.Selectedskin = 664;
                    break;
                case "M4A4 | Desolate Space - 588":
                    Main.I.Selectedskin = 588;
                    break;
                case "M4A4 | (Dragon King) - 400":
                    Main.I.Selectedskin = 400;
                    break;
                case "M4A4 | Poseidon - 449":
                    Main.I.Selectedskin = 449;
                    break;
                case "M4A4 | Evil Daimyo - 480":
                    Main.I.Selectedskin = 480;
                    break;
                case "M4A4 | Griffin - 384":
                    Main.I.Selectedskin = 384;
                    break;
                case "M4A4 | Zirka - 187":
                    Main.I.Selectedskin = 187;
                    break;
                case "M4A4 | Daybreak - 471":
                    Main.I.Selectedskin = 471;
                    break;
                case "M4A4 | Modern Hunter - 164":
                    Main.I.Selectedskin = 164;
                    break;
                case "M4A4 | Faded Zebra - 176":
                    Main.I.Selectedskin = 176;
                    break;
                case "M4A4 | Converter - 793":
                    Main.I.Selectedskin = 793;
                    break;
                case "M4A4 | Radiation Hazard - 167":
                    Main.I.Selectedskin = 167;
                    break;
                case "M4A4 | Mainframe - 780":
                    Main.I.Selectedskin = 780;
                    break;
                case "M4A4 | Urban DDPAT - 17":
                    Main.I.Selectedskin = 17;
                    break;
                case "M4A4 | Tornado - 101":
                    Main.I.Selectedskin = 101;
                    break;
                case "M4A4 | Jungle Tiger - 16":
                    Main.I.Selectedskin = 16;
                    break;
                case "M4A4 | Desert Storm - 8":
                    Main.I.Selectedskin = 8;
                    break;
                //////////////////////// M4A1-S Skins ///////////////////////////////////////
                case "M4A1S | Mecha Industries - 587":
                    Main.I.Selectedskin = 587;
                    break;
                case "M4A1S | Chantico's Fire - 548":
                    Main.I.Selectedskin = 548;
                    break;
                case "M4A1S | Golden Coil - 497":
                    Main.I.Selectedskin = 497;
                    break;
                case "M4A1S | Hyper Beast - 430":
                    Main.I.Selectedskin = 430;
                    break;
                case "M4A1S | Cyrex - 360":
                    Main.I.Selectedskin = 360;
                    break;
                case "M4A1S | Nightmare - 714":
                    Main.I.Selectedskin = 714;
                    break;
                case "M4A1S | Leaded Glass - 681":
                    Main.I.Selectedskin = 681;
                    break;
                case "M4A1S | Decimator - 644":
                    Main.I.Selectedskin = 644;
                    break;
                case "M4A1S | Atomic Alloy - 301":
                    Main.I.Selectedskin = 301;
                    break;
                case "M4A1S | Guardian - 257":
                    Main.I.Selectedskin = 257;
                    break;
                case "M4A1S | Control Panel - 792":
                    Main.I.Selectedskin = 792;
                    break;
                case "M4A1S | Hot Rod - 445":
                    Main.I.Selectedskin = 445;
                    break;
                case "M4A1S | Knight - 326":
                    Main.I.Selectedskin = 326;
                    break;
                case "M4A1S | Master Piece - 321":
                    Main.I.Selectedskin = 321;
                    break;
                case "M4A1S | Flashback - 631":
                    Main.I.Selectedskin = 631;
                    break;
                case "M4A1S | Basilisk - 383":
                    Main.I.Selectedskin = 383;
                    break;
                case "M4A1S | Bright Water - 189":
                    Main.I.Selectedskin = 189;
                    break;
                case "M4A1S | Dark Water - 60":
                    Main.I.Selectedskin = 60;
                    break;
                case "M4A1S | Icarus Fell - 440":
                    Main.I.Selectedskin = 440;
                    break;
                case "M4A1S | Nitro - 254":
                    Main.I.Selectedskin = 254;
                    break;
                case "M4A1S | Briefing - 663":
                    Main.I.Selectedskin = 663;
                    break;
                case "M4A1S | Blood Tiger - 217":
                    Main.I.Selectedskin = 217;
                    break;
                case "M4A1S | VariCamo - 235":
                    Main.I.Selectedskin = 235;
                    break;
                case "M4A1S | Boreal Forest - 77":
                    Main.I.Selectedskin = 77;
                    break;
                    //////////////////////// AWP Skins //////////////////////////////////////////
                case "AWP | Oni Taiji - 662":
                    Main.I.Selectedskin = 662;
                    break;
                case "AWP | Hyper Beast - 475":
                    Main.I.Selectedskin = 475;
                    break;
                case "AWP | Man-o'-war - 395":
                    Main.I.Selectedskin = 395;
                    break;
                case "AWP | Asiimov - 279":
                    Main.I.Selectedskin = 279;
                    break;
                case "AWP | Lightning Strike - 51":
                    Main.I.Selectedskin = 51;
                    break;
                case "AWP | Medusa - 446":
                    Main.I.Selectedskin = 446;
                    break;
                case "AWP | Dragon Lore - 344":
                    Main.I.Selectedskin = 344;
                    break;
                case "AWP | Mortis - 691":
                    Main.I.Selectedskin = 691;
                    break;
                case "AWP | Fever Dream - 640":
                    Main.I.Selectedskin = 640;
                    break;
                case "AWP | Elite Build - 525":
                    Main.I.Selectedskin = 525;
                    break;
                case "AWP | Corticera - 181":
                    Main.I.Selectedskin = 181;
                    break;
                case "AWP | Redline - 259":
                    Main.I.Selectedskin = 259;
                    break;
                case "AWP | Electric Hive - 227":
                    Main.I.Selectedskin = 227;
                    break;
                case "AWP | Graphite - 212":
                    Main.I.Selectedskin = 212;
                    break;
                case "AWP | BOOM - 174":
                    Main.I.Selectedskin = 174;
                    break;
                case "AWP | PAW - 718":
                    Main.I.Selectedskin = 718;
                    break;
                case "AWP | Phobos - 584":
                    Main.I.Selectedskin = 584;
                    break;
                case "AWP | Worm God - 424":
                    Main.I.Selectedskin = 424;
                    break;
                case "AWP | Pink DDPAT - 84":
                    Main.I.Selectedskin = 84;
                    break;
                case "AWP | Pit Viper - 251":
                    Main.I.Selectedskin = 251;
                    break;
                case "AWP | Acheron - 788":
                    Main.I.Selectedskin = 788;
                    break;
                case "AWP | Snake Camo - 30":
                    Main.I.Selectedskin = 30;
                    break;
                case "AWP | Sun in Leo - 451":
                    Main.I.Selectedskin = 451;
                    break;
                case "AWP | Safari Mesh - 72":
                    Main.I.Selectedskin = 72;
                    break;
                //////////////////////// Deagle Skins /////////////////////////////////////////
                case "DESERTEAGLE | Code Red - 711":
                    Main.I.Selectedskin = 711;
                    break;
                case "DESERTEAGLE | Golden Koi - 185":
                    Main.I.Selectedskin = 185;
                    break;
                case "DESERTEAGLE | Kumicho Dragon - 527":
                    Main.I.Selectedskin = 527;
                    break;
                case "DESERTEAGLE | Conspiracy - 351":
                    Main.I.Selectedskin = 351;
                    break;
                case "DESERTEAGLE | Cobalt Disruption - 231":
                    Main.I.Selectedskin = 231;
                    break;
                case "DESERTEAGLE | Hypnotic - 61":
                    Main.I.Selectedskin = 61;
                    break;
                case "DESERTEAGLE | Directive - 603":
                    Main.I.Selectedskin = 603;
                    break;
                case "DESERTEAGLE | Naga - 397":
                    Main.I.Selectedskin = 397;
                    break;
                case "DESERTEAGLE | Crimson Web - 232":
                    Main.I.Selectedskin = 232;
                    break;
                case "DESERTEAGLE | Heirloom - 273":
                    Main.I.Selectedskin = 273;
                    break;
                case "DESERTEAGLE | Sunset Storm - 469":
                    Main.I.Selectedskin = 469;
                    break;
                case "DESERTEAGLE | Sunset Storm - 470":
                    Main.I.Selectedskin = 470;
                    break;
                case "DESERTEAGLE | Hand Cannon - 328":
                    Main.I.Selectedskin = 328;
                    break;
                case "DESERTEAGLE | Pilot - 347":
                    Main.I.Selectedskin = 347;
                    break;
                case "DESERTEAGLE | Blaze - 37":
                    Main.I.Selectedskin = 37;
                    break;
                case "DESERTEAGLE | Oxide Blaze - 645":
                    Main.I.Selectedskin = 645;
                    break;
                case "DESERTEAGLE | Corinthian - 509":
                    Main.I.Selectedskin = 509;
                    break;
                case "DESERTEAGLE | Bronze Deco - 425":
                    Main.I.Selectedskin = 425;
                    break;
                case "DESERTEAGLE | Meteorite - 296":
                    Main.I.Selectedskin = 296;
                    break;
                case "DESERTEAGLE | Urban Rubble - 237":
                    Main.I.Selectedskin = 237;
                    break;
                case "DESERTEAGLE | Night - 40":
                    Main.I.Selectedskin = 40;
                    break;
                case "DESERTEAGLE | Midnight Storm - 468":
                    Main.I.Selectedskin = 468;
                    break;
                case "DESERTEAGLE | Urban DDPAT - 17":
                    Main.I.Selectedskin = 17;
                    break;
                case "DESERTEAGLE | Mudder - 90":
                    Main.I.Selectedskin = 90;
                    break;
                //////////////////////// Glock-18 Skins ///////////////////////////////////////
                case "GLOCK18 | Wasteland Rebel - 586":
                    Main.I.Selectedskin = 586;
                    break;
                case "GLOCK18 | Water Elemental - 353":
                    Main.I.Selectedskin = 353;
                    break;
                case "GLOCK18 | Twilight Galaxy - 437":
                    Main.I.Selectedskin = 437;
                    break;
                case "GLOCK18 | Moonrise - 694":
                    Main.I.Selectedskin = 694;
                    break;
                case "GLOCK18 | Weasel - 607":
                    Main.I.Selectedskin = 607;
                    break;
                case "GLOCK18 | Royal Legion - 532":
                    Main.I.Selectedskin = 532;
                    break;
                case "GLOCK18 | Grinder - 381":
                    Main.I.Selectedskin = 381;
                    break;
                case "GLOCK18 | Steel Disruption - 230":
                    Main.I.Selectedskin = 230;
                    break;
                case "GLOCK18 | Dragon Tattoo - 48":
                    Main.I.Selectedskin = 48;
                    break;
                case "GLOCK18 | Nuclear Garden - 789":
                    Main.I.Selectedskin = 789;
                    break;
                case "GLOCK18 | Fade - 38":
                    Main.I.Selectedskin = 38;
                    break;
                case "GLOCK18 | Brass - 159":
                    Main.I.Selectedskin = 159;
                    break;
                case "GLOCK18 | Warhawk - 713":
                    Main.I.Selectedskin = 713;
                    break;
                case "GLOCK18 | Off World - 680":
                    Main.I.Selectedskin = 680;
                    break;
                case "GLOCK18 | Ironwork - 623":
                    Main.I.Selectedskin = 623;
                    break;
                case "GLOCK18 | Wraiths - 495":
                    Main.I.Selectedskin = 495;
                    break;
                case "GLOCK18 | Bunsen Burner - 479":
                    Main.I.Selectedskin = 479;
                    break;
                case "GLOCK18 | Catacombs - 399":
                    Main.I.Selectedskin = 399;
                    break;
                case "GLOCK18 | Blue Fissure - 278":
                    Main.I.Selectedskin = 278;
                    break;
                case "GLOCK18 | Reactor - 367":
                    Main.I.Selectedskin = 367;
                    break;
                case "GLOCK18 | Candy Apple - 3":
                    Main.I.Selectedskin = 3;
                    break;
                case "GLOCK18 | High Beam - 799":
                    Main.I.Selectedskin = 799;
                    break;
                case "GLOCK18 | Night - 40":
                    Main.I.Selectedskin = 40;
                    break;
                case "GLOCK18 | Death Rattle - 293":
                    Main.I.Selectedskin = 293;
                    break;
                case "GLOCK18 | Groundwater - 2":
                    Main.I.Selectedskin = 2;
                    break;
                case "GLOCK18 | Sand Dune - 208":
                    Main.I.Selectedskin = 208;
                    break;
                default:
                    break;
            }
        }

        private void KnifeChangerCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (KnifeChangerCheck.Checked)
            {
                Main.S.KnifeChangerEnabled = true;
            }
            else
                Main.S.KnifeChangerEnabled = false;
        }

        private void KnifeChangerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (KnifeChangerComboBox.SelectedItem.ToString())
            {
                case "Bayonet":
                    Main.I.SelectedKnifeID = (int)WeaponsID.WEAPON_BAYONET;
                    Main.I.SelectedKnife = 65;
                    Main.S.SelectedKnife = "Bayonet";
                    break;
                case "Flip Knife":
                    Main.I.SelectedKnifeID = (int)WeaponsID.WEAPON_FLIP_KNIFE;
                    Main.I.SelectedKnife = 68;
                    Main.S.SelectedKnife = "Flip Knife";
                    break;
                case "Karambit":
                    Main.I.SelectedKnifeID = (int)WeaponsID.WEAPON_KARAMBIT;
                    Main.I.SelectedKnife = 74;
                    Main.S.SelectedKnife = "Karambit";
                    break;
                case "M9 Bayonet":
                    Main.I.SelectedKnifeID = (int)WeaponsID.WEAPON_M9_BAYONET;
                    Main.I.SelectedKnife = 77;
                    Main.S.SelectedKnife = "M9 Bayonet";
                    break;
                case "Butterfly":
                    Main.I.SelectedKnifeID = (int)WeaponsID.WEAPON_BUTTERFLY_KNIFE;
                    Main.I.SelectedKnife = 89;
                    Main.S.SelectedKnife = "Butterfly";
                    break;
                case "Falchion":
                    Main.I.SelectedKnifeID = (int)WeaponsID.WEAPON_FALCHION_KNIFE;
                    Main.I.SelectedKnife = 83;
                    Main.S.SelectedKnife = "Falchion";
                    break;
                case "Bowie":
                    Main.I.SelectedKnifeID = (int)WeaponsID.WEAPON_BOWIE_KNIFE;
                    Main.I.SelectedKnife = 86;
                    Main.S.SelectedKnife = "Bowie";
                    break;
                case "Gut Knife":
                    Main.I.SelectedKnifeID = (int)WeaponsID.WEAPON_GUT_KNIFE;
                    Main.I.SelectedKnife = 71;
                    Main.S.SelectedKnife = "Gut Knife";
                    break;
                case "Talon":
                    Main.I.SelectedKnifeID = (int)WeaponsID.WEAPON_TALON_KNIFE;
                    Main.I.SelectedKnife = 105;
                    Main.S.SelectedKnife = "Talon";
                    break;
                case "Stiletto":
                    Main.I.SelectedKnifeID = (int)WeaponsID.WEAPON_STILETTO_KNIFE;
                    Main.I.SelectedKnife = 102;
                    Main.S.SelectedKnife = "Stiletto";
                    break;
                case "Ursus":
                    Main.I.SelectedKnifeID = (int)WeaponsID.WEAPON_URSUS_KNIFE;
                    Main.I.SelectedKnife = 96;
                    Main.S.SelectedKnife = "Ursus";
                    break;
                case "Shadow Daggers":
                    Main.I.SelectedKnifeID = (int)WeaponsID.WEAPON_SHADOW_DAGGERS;
                    Main.I.SelectedKnife = 90;
                    Main.S.SelectedKnife = "Shadow Daggers";
                    break;
                case "Huntsman":
                    Main.I.SelectedKnifeID = (int)WeaponsID.WEAPON_HUNTSMAN_KNIFE;
                    Main.I.SelectedKnife = 80;
                    Main.S.SelectedKnife = "Huntsman";
                    break;
                case "Navaja":
                    Main.I.SelectedKnifeID = (int)WeaponsID.WEAPON_NAVAJA_KNIFE;
                    Main.I.SelectedKnife = 99;
                    Main.S.SelectedKnife = "Navaja";
                    break;
                case "Fists":
                    Main.I.SelectedKnife = -100;
                    Main.S.SelectedKnife = "Fists";
                    break;
                default:
                    break;
            }
        }

        private void FasterChangersCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (FasterChangersCheck.Checked)
                Main.S.FasterChangersEnabled = true;
            else
                Main.S.FasterChangersEnabled = false;
        }

        private void StatTrakValueTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Main.S.StatTrakValue = int.Parse(StatTrakValueTextBox.Text);
            }
            catch (Exception ex)
            {

            }
        }

        private void FloatValueTrackBar_Scroll(object sender, EventArgs e)
        {
            try{
                Main.S.FloatWearValue = (float)FloatValueTrackBar.Value / 1000f;
            }catch (Exception ex) { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FloatWearValue.Text = Main.S.FloatWearValue.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(string stringitem in items)
            {
                if(stringitem.Contains(textBox1.Text))
                {
                    listBox1.Items.Add(stringitem);
                }
            }
        }

        private void UCSkinChanger_Load(object sender, EventArgs e)
        {

        }
    }
}
