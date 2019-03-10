using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZBase.Forms
{
    public partial class UCESP : UserControl
    {
        public UCESP()
        {
            InitializeComponent();
            UCESP_Load();
        }

        public void UCESP_Load()
        {
            if (Main.S.ESP)
                ESPCheck.CheckState = CheckState.Checked;
            if (Main.S.DrawHealthBarLeftSide)
                HealthBarLeftSideCheck.CheckState = CheckState.Checked;
            if (Main.S.DrawArmorBar)
                DrawArmorcheck.CheckState = CheckState.Checked;
            if (Main.S.BoneEnabled)
                BoneESPCheck.CheckState = CheckState.Checked;
            if (Main.S.ESPBoxEnabled)
                ESPBoxCheck.CheckState = CheckState.Checked;
            if (Main.S.DrawBoneIDs)
                DrawBondeIdsCheck.CheckState = CheckState.Checked;
            if (Main.S.ChamsEnabled)
                ChamsCheck.CheckState = CheckState.Checked;
            if (!Main.S.DrawHealthBarLeftSide)
                HealthBarLeftSideCheck.CheckState = CheckState.Unchecked;
            if (!Main.S.DrawArmorBar)
                DrawArmorcheck.CheckState = CheckState.Unchecked;
            if (!Main.S.BoneEnabled)
                BoneESPCheck.CheckState = CheckState.Unchecked;
            if (!Main.S.ESPBoxEnabled)
                ESPBoxCheck.CheckState = CheckState.Unchecked;
            if (!Main.S.DrawBoneIDs)
                DrawBondeIdsCheck.CheckState = CheckState.Unchecked;
            if (!Main.S.ChamsEnabled)
                ChamsCheck.CheckState = CheckState.Unchecked;
            if (Main.S.DrawSmartCrosshairEnabled)
                DrawSmartCrosshairCheck.CheckState = CheckState.Checked;
            if (!Main.S.DrawSmartCrosshairEnabled)
                DrawSmartCrosshairCheck.CheckState = CheckState.Unchecked;
            if (Main.S.DrawScopedEnabled)
                DrawScopedCheck.CheckState = CheckState.Checked;
            if (!Main.S.DrawScopedEnabled)
                DrawScopedCheck.CheckState = CheckState.Unchecked;
            if (Main.S.DrawDistanceString)
                DrawDistanceCheck.CheckState = CheckState.Checked;
            if (Main.S.GlowEnabled)
                GlowCheck.CheckState = CheckState.Checked;
            if (Main.S.DrawHealthBar)
                HealthBarCheck.CheckState = CheckState.Checked;
            if (Main.S.DrawHealthString)
                HealthCheck.CheckState = CheckState.Checked;
            if (Main.S.DrawWeaponString)
                WeaponCheck.CheckState = CheckState.Checked;
            if (Main.S.CrosshairSniperEnabled)
                CrosshairSniperCheck.CheckState = CheckState.Checked;
            if (Main.S.RecoilCrosshairEnabled)
                RecoilCrosshairCheck.CheckState = CheckState.Checked;
            if (Main.S.DrawSnaplines)
                SnapLinesCheck.CheckState = CheckState.Checked;
            if (Main.S.RadarHackEnabled)
                RadarHackCheck.CheckState = CheckState.Checked;
            if (!Main.S.ESP)
                ESPCheck.CheckState = CheckState.Unchecked;
            if (!Main.S.GlowEnabled)
                GlowCheck.CheckState = CheckState.Unchecked;
            if (!Main.S.DrawHealthBar)
                HealthBarCheck.CheckState = CheckState.Unchecked;
            if (!Main.S.DrawHealthString)
                HealthCheck.CheckState = CheckState.Unchecked;
            if (!Main.S.DrawWeaponString)
                WeaponCheck.CheckState = CheckState.Unchecked;
            if (!Main.S.CrosshairSniperEnabled)
                CrosshairSniperCheck.CheckState = CheckState.Unchecked;
            if (!Main.S.RecoilCrosshairEnabled)
                RecoilCrosshairCheck.CheckState = CheckState.Unchecked;
            if (!Main.S.DrawSnaplines)
                SnapLinesCheck.CheckState = CheckState.Unchecked;
            if (!Main.S.RadarHackEnabled)
                RadarHackCheck.CheckState = CheckState.Unchecked;
            if (!Main.S.DrawDistanceString)
                DrawDistanceCheck.CheckState = CheckState.Unchecked;
            if (!Main.S.BoneTeammates)
                BoneTeammatesCheck.CheckState = CheckState.Unchecked;
            if (!Main.S.BoxTeammates)
                BoxTeammatesCheck.CheckState = CheckState.Unchecked;
            if (!Main.S.ChamsTeammates)
                ChamsTeammatesCheck.CheckState = CheckState.Unchecked;
            if (!Main.S.GlowTeammates)
                GlowTeammatesCheck.CheckState = CheckState.Unchecked;
            if (Main.S.BoneTeammates)
                BoneTeammatesCheck.CheckState = CheckState.Checked;
            if (Main.S.BoxTeammates)
                BoxTeammatesCheck.CheckState = CheckState.Checked;
            if (Main.S.ChamsTeammates)
                ChamsTeammatesCheck.CheckState = CheckState.Checked;
            if (Main.S.GlowTeammates)
                GlowTeammatesCheck.CheckState = CheckState.Checked;
            if (Main.S.DrawWeaponESP)
                WeaponESPCheck.CheckState = CheckState.Checked;
            if (!Main.S.DrawWeaponESP)
                WeaponESPCheck.CheckState = CheckState.Unchecked;
            if (Main.S.DebugEnabled)
                DebugCheck.CheckState = CheckState.Checked;
            if (!Main.S.DebugEnabled)
                DebugCheck.CheckState = CheckState.Unchecked;
            if (Main.S.ShowWinsEnabled)
                ShowWinsCheck.CheckState = CheckState.Checked;
            if (!Main.S.ShowWinsEnabled)
                ShowWinsCheck.CheckState = CheckState.Unchecked;
            if (Main.S.ShowRanksEnabled)
                ShowRanksCheck.CheckState = CheckState.Checked;
            if (!Main.S.ShowRanksEnabled)
                ShowRanksCheck.CheckState = CheckState.Unchecked;
            //////////////////////////////////////////////////////////////
            if (Main.S.SnaplinesValue > 0 && Main.S.SnaplinesValue < 16)
                SnapLineThicTrackBar.Value = Main.S.SnaplinesValue;
            //////////////////////////////////////////////////////////////
            if (Main.S.ChamsValue >= 0)
                ChamsValueTXT.Text = (Main.S.ChamsValue).ToString();
            if (Main.S.GlowValue >= 0)
                GlowValueTXT.Text = (Main.S.GlowValue).ToString();
            //////////////////////////////////////////////////////////////
            switch (Main.S.BoneESPMap)
            {
                case 0:
                    BoneESPMapComboBox.SelectedIndex = 0;
                    break;
                case 1:
                    BoneESPMapComboBox.SelectedIndex = 1;
                    break;
                case 2:
                    BoneESPMapComboBox.SelectedIndex = 2;
                    break;
                case 3:
                    BoneESPMapComboBox.SelectedIndex = 3;
                    break;
                case 4:
                    BoneESPMapComboBox.SelectedIndex = 4;
                    break;
                case 5:
                    BoneESPMapComboBox.SelectedIndex = 5;
                    break;
                case 6:
                    BoneESPMapComboBox.SelectedIndex = 6;
                    break;
                case 7:
                    BoneESPMapComboBox.SelectedIndex = 7;
                    break;
                case 8:
                    BoneESPMapComboBox.SelectedIndex = 8;
                    break;
                default:
                    break;
            }
            switch (Main.S.TypeOfESPBOX)
            {
                case 0:
                    comboBoxESP.SelectedIndex = 0;
                    break;
                case 1:
                    comboBoxESP.SelectedIndex = 1;
                    break;
                case 2:
                    comboBoxESP.SelectedIndex = 2;
                    break;
                case 3:
                    comboBoxESP.SelectedIndex = 3;
                    break;
                case 4:
                    comboBoxESP.SelectedIndex = 4;
                    break;
                default:
                    break;
            }
            switch (Main.S.TypeOfCrosshair)
            {
                case 0:
                    comboBoxCrosshair.SelectedIndex = 0;
                    break;
                case 1:
                    comboBoxCrosshair.SelectedIndex = 1;
                    break;
                case 2:
                    comboBoxCrosshair.SelectedIndex = 2;
                    break;
                case 3:
                    comboBoxCrosshair.SelectedIndex = 3;
                    break;
                case 4:
                    comboBoxCrosshair.SelectedIndex = 4;
                    break;
                default:
                    break;
            }
            switch (Main.S.SnapLinesPos)
            {
                case "Top":
                    SnapLinesPoscomboBox.SelectedIndex = 0;
                    break;
                case "Bottom":
                    SnapLinesPoscomboBox.SelectedIndex = 1;
                    break;
                case "Right":
                    SnapLinesPoscomboBox.SelectedIndex = 2;
                    break;
                case "Left":
                    SnapLinesPoscomboBox.SelectedIndex = 3;
                    break;
                case "Mid":
                    SnapLinesPoscomboBox.SelectedIndex = 4;
                    break;
                default:
                    break;
            }
        }

        private void ESPCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ESPCheck.Checked)
            {
                Main.S.ESP = true;
            }
            else
                Main.S.ESP = false;
        }

        private void ChamsValueTXT_TextChanged(object sender, EventArgs e)
        {
            Main.S.ChamsValue = int.Parse(ChamsValueTXT.Text);
        }

        private void comboBoxCrosshair_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCrosshair.SelectedItem.ToString() == "Dot Crosshair")
            {
                Main.S.TypeOfCrosshair = 0;
            }
            if (comboBoxCrosshair.SelectedItem.ToString() == "Plus Crosshair")
            {
                Main.S.TypeOfCrosshair = 1;
            }
            if (comboBoxCrosshair.SelectedItem.ToString() == "Cross Crosshair")
            {
                Main.S.TypeOfCrosshair = 2;
            }
            if (comboBoxCrosshair.SelectedItem.ToString() == "Gap Crosshair")
            {
                Main.S.TypeOfCrosshair = 3;
            }
            if (comboBoxCrosshair.SelectedItem.ToString() == "Diagonal Crosshair")
            {
                Main.S.TypeOfCrosshair = 4;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SnapLineThicTrackBar_Scroll(object sender, EventArgs e)
        {
            Main.S.SnaplinesValue = SnapLineThicTrackBar.Value;
        }

        private void DrawArmorcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (DrawArmorcheck.Checked)
            {
                Main.S.DrawArmorBar = true;
            }
            else
                Main.S.DrawArmorBar = false;
        }

        private void HealthBarLeftSideCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (HealthBarLeftSideCheck.Checked)
            {
                Main.S.DrawHealthBarLeftSide = true;
            }
            else
                Main.S.DrawHealthBarLeftSide = false;
        }

        private void DrawScopedCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (DrawScopedCheck.Checked)
            {
                Main.S.DrawScopedEnabled = true;
            }
            else
                Main.S.DrawScopedEnabled = false;
        }

        private void SnapLinesCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (SnapLinesCheck.Checked)
            {
                Main.S.DrawSnaplines = true;
            }
            else
                Main.S.DrawSnaplines = false;
        }

        private void HealthBarCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (HealthBarCheck.Checked)
            {
                Main.S.DrawHealthBar = true;
            }
            else
                Main.S.DrawHealthBar = false;
        }

        private void DrawDistanceCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (DrawDistanceCheck.Checked)
            {
                Main.S.DrawDistanceString = true;
            }
            else
                Main.S.DrawDistanceString = false;
        }

        private void WeaponCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (WeaponCheck.Checked)
            {
                Main.S.DrawWeaponString = true;
            }
            else
                Main.S.DrawWeaponString = false;
        }

        private void HealthCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (HealthCheck.Checked)
            {
                Main.S.DrawHealthString = true;
            }
            else
                Main.S.DrawHealthString = false;
        }

        private void BoneESPMapComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (BoneESPMapComboBox.SelectedItem.ToString())
            {
                case "Mirage":
                    Main.S.BoneESPMap = 0;
                    break;
                case "Cache":
                    Main.S.BoneESPMap = 1;
                    break;
                case "Dust2":
                    Main.S.BoneESPMap = 2;
                    break;
                case "Inferno":
                    Main.S.BoneESPMap = 3;
                    break;
                case "Cobblestone":
                    Main.S.BoneESPMap = 4;
                    break;
                case "Train":
                    Main.S.BoneESPMap = 5;
                    break;
                case "Overpass":
                    Main.S.BoneESPMap = 6;
                    break;
                case "Nuke":
                    Main.S.BoneESPMap = 7;
                    break;
                case "Office":
                    Main.S.BoneESPMap = 8;
                    break;
                default:
                    break;
            }
        }

        private void BoneESPCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (BoneESPCheck.Checked)
            {
                Main.S.BoneEnabled = true;
            }
            else
                Main.S.BoneEnabled = false;
        }

        private void ChamsCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ChamsCheck.Checked)
            {
                Main.S.ChamsEnabled = true;
            }
            else
                Main.S.ChamsEnabled = false;
        }

        private void RadarHackCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (RadarHackCheck.Checked)
            {
                Main.S.RadarHackEnabled = true;
            }
            else
                Main.S.RadarHackEnabled = false;
        }

        private void GlowCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (GlowCheck.Checked)
            {
                Main.S.GlowEnabled = true;
            }
            else
                Main.S.GlowEnabled = false;
        }

        private void DrawSmartCrosshairCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (DrawSmartCrosshairCheck.Checked)
            {
                Main.S.DrawSmartCrosshairEnabled = true;
            }
            else
                Main.S.DrawSmartCrosshairEnabled = false;
        }

        private void CrosshairSniperCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (CrosshairSniperCheck.Checked)
            {
                Main.S.CrosshairSniperEnabled = true;
            }
            else
                Main.S.CrosshairSniperEnabled = false;
        }

        private void GlowValueTXT_TextChanged(object sender, EventArgs e)
        {
            Main.S.GlowValue = int.Parse(GlowValueTXT.Text);
        }

        private void DrawBondeIdsCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (DrawBondeIdsCheck.Checked)
            {
                Main.S.DrawBoneIDs = true;
            }
            else
                Main.S.DrawBoneIDs = false;
        }

        private void ESPBoxCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ESPBoxCheck.Checked)
            {
                Main.S.ESPBoxEnabled = true;
            }
            else
                Main.S.ESPBoxEnabled = false;
        }

        private void comboBoxESP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxESP.SelectedItem.ToString() == "Box")
            {
                Main.S.TypeOfESPBOX = 0;
            }
            if (comboBoxESP.SelectedItem.ToString() == "Full Box")
            {
                Main.S.TypeOfESPBOX = 1;
            }
            if (comboBoxESP.SelectedItem.ToString() == "Edge Box")
            {
                Main.S.TypeOfESPBOX = 2;
            }
            if (comboBoxESP.SelectedItem.ToString() == "Filled Box")
            {
                Main.S.TypeOfESPBOX = 3;
            }
            if (comboBoxESP.SelectedItem.ToString() == "Rounded Box")
            {
                Main.S.TypeOfESPBOX = 4;
            }
        }

        private void RecoilCrosshairCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (RecoilCrosshairCheck.Checked)
            {
                Main.S.RecoilCrosshairEnabled = true;
            }
            else
                Main.S.RecoilCrosshairEnabled = false;
        }

        private void HitIndicatorCheck_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void GlowTeammatesCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (GlowTeammatesCheck.Checked)
            {
                Main.S.GlowTeammates = true;
            }
            else
                Main.S.GlowTeammates = false;
        }

        private void ChamsTeammatesCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ChamsTeammatesCheck.Checked)
            {
                Main.S.ChamsTeammates = true;
            }
            else
                Main.S.ChamsTeammates = false;
        }

        private void BoneTeammatesCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (BoneTeammatesCheck.Checked)
            {
                Main.S.BoneTeammates = true;
            }
            else
                Main.S.BoneTeammates = false;
        }

        private void BoxTeammatesCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (BoxTeammatesCheck.Checked)
            {
                Main.S.BoxTeammates = true;
            }
            else
                Main.S.BoxTeammates = false;
        }

        private void SnapLinesTeammatesCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (SnapLinesTeammatesCheck.Checked)
            {
                Main.S.SnapLinesTeammates = true;
            }
            else
                Main.S.SnapLinesTeammates = false;
        }

        private void WeaponESPCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (WeaponESPCheck.Checked)
            {
                Main.S.DrawWeaponESP = true;
            }
            else
                Main.S.DrawWeaponESP = false;
        }

        private void SnapLinesPoscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SnapLinesPoscomboBox.SelectedItem.ToString() == "Top")
            {
                Main.S.SnapLinesPos = "Top";
            }
            if (SnapLinesPoscomboBox.SelectedItem.ToString() == "Bottom")
            {
                Main.S.SnapLinesPos = "Bottom";
            }
            if (SnapLinesPoscomboBox.SelectedItem.ToString() == "Right")
            {
                Main.S.SnapLinesPos = "Right";
            }
            if (SnapLinesPoscomboBox.SelectedItem.ToString() == "Left")
            {
                Main.S.SnapLinesPos = "Left";
            }
            if (SnapLinesPoscomboBox.SelectedItem.ToString() == "Mid")
            {
                Main.S.SnapLinesPos = "Mid";
            }
        }

        private void DebugCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (DebugCheck.Checked)
                Main.S.DebugEnabled = true;
            else
                Main.S.DebugEnabled = false;
        }

        private void ShowRanksCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowRanksCheck.Checked)
                Main.S.ShowRanksEnabled = true;
            else
                Main.S.ShowRanksEnabled = false;
        }

        private void ShowWinsCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowWinsCheck.Checked)
                Main.S.ShowWinsEnabled = true;
            else
                Main.S.ShowWinsEnabled = false;
        }
    }
}
