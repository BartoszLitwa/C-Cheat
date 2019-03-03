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
    public partial class UCAimbot : UserControl
    {
        public UCAimbot()
        {
            InitializeComponent();
        }

        public void UCAimbot_Load()
        {
            if (Main.S.RCSEnabled)
                RCSCheck.CheckState = CheckState.Checked;
            if (Main.S.TriggerbotEnabled)
                TriggerBotCheck.CheckState = CheckState.Checked;
            if (!Main.S.RCSEnabled)
                RCSCheck.CheckState = CheckState.Unchecked;
            if (!Main.S.TriggerbotEnabled)
                TriggerBotCheck.CheckState = CheckState.Unchecked;
            if (!Main.S.DrawAimspotEnabled)
                DrawAimspotCheck.CheckState = CheckState.Unchecked;
            if (Main.S.DrawAimspotEnabled)
                DrawAimspotCheck.CheckState = CheckState.Checked;
            if (Main.S.AutoPistolEnabled)
                AutoPistolCheck.CheckState = CheckState.Checked;
            if (!Main.S.AutoPistolEnabled)
                AutoPistolCheck.CheckState = CheckState.Unchecked;
            if (Main.S.SilentAImEnabled)
                SilentAimCheck.CheckState = CheckState.Checked;
            if (!Main.S.SilentAImEnabled)
                SilentAimCheck.CheckState = CheckState.Unchecked;
            if (Main.S.ShootteammatesEnabled)
                ShootTeammatesCheck.CheckState = CheckState.Checked;
            if (!Main.S.ShootteammatesEnabled)
                ShootTeammatesCheck.CheckState = CheckState.Unchecked;
            if (Main.S.RageBotEnabled)
                RageBotCheck.CheckState = CheckState.Checked;
            if (!Main.S.RageBotEnabled)
                RageBotCheck.CheckState = CheckState.Unchecked;
            if (Main.S.AimbotTypeofGun == 0)
            {
                if (Main.S.AimbotEnabledRifle)
                    AimbotCheck.CheckState = CheckState.Checked;
                if (!Main.S.AimbotEnabledRifle)
                    AimbotCheck.CheckState = CheckState.Unchecked;
                if (Main.S.DrawDisplayFovAimbotRifle)
                    DisplayFOVAimbotCheck.CheckState = CheckState.Checked;
                if (!Main.S.DrawDisplayFovAimbotRifle)
                    DisplayFOVAimbotCheck.CheckState = CheckState.Unchecked;
                if (Main.S.RecoilPredictionEnabledRifle)
                    RecoilPredictionCheck.CheckState = CheckState.Checked;
                if (!Main.S.aimbotSmoothRifle)
                    AimbotSmoothCheck.CheckState = CheckState.Unchecked;
                if (Main.S.aimbotSmoothRifle)
                    AimbotSmoothCheck.CheckState = CheckState.Checked;
                if (!Main.S.RecoilPredictionEnabledRifle)
                    RecoilPredictionCheck.CheckState = CheckState.Unchecked;
                if (!Main.S.AimbotSpottedByMaskRifle)
                    IfSpottedCheck.CheckState = CheckState.Unchecked;
                if (Main.S.AimbotSpottedByMaskRifle)
                    IfSpottedCheck.CheckState = CheckState.Checked;
                if (Main.S.SmartAimbotRifle)
                    SmartAimbotCheck.CheckState = CheckState.Checked;
                if (!Main.S.SmartAimbotRifle)
                    SmartAimbotCheck.CheckState = CheckState.Unchecked;
                //////////////////////////////////////////////////////
                if (Main.S.DrawDisplayFovAimbotValueRifle >= 0 && Main.S.DrawDisplayFovAimbotValueRifle < 1201)
                    AimbotFOVTrackBar.Value = Main.S.DrawDisplayFovAimbotValueRifle;
                if (Main.S.aimbotSmoothValueRifle >= 0)
                    AimbotSmoothTXT.Text = (Main.S.aimbotSmoothValueRifle).ToString();
                switch (Main.S.AimbotBoneIDRifle)
                {
                    case 8:
                        ComoBoxAimbotBones.SelectedIndex = 0;
                        break;
                    case 7:
                        ComoBoxAimbotBones.SelectedIndex = 1;
                        break;
                    case 6:
                        ComoBoxAimbotBones.SelectedIndex = 2;
                        break;
                    case 4:
                        ComoBoxAimbotBones.SelectedIndex = 3;
                        break;
                    case 11:
                        ComoBoxAimbotBones.SelectedIndex = 4;
                        break;
                    case 41:
                        ComoBoxAimbotBones.SelectedIndex = 5;
                        break;
                    case 0:
                        ComoBoxAimbotBones.SelectedIndex = 6;
                        break;
                    case 71:
                        ComoBoxAimbotBones.SelectedIndex = 7;
                        break;
                    case 13:
                        ComoBoxAimbotBones.SelectedIndex = 8;
                        break;
                    case 43:
                        ComoBoxAimbotBones.SelectedIndex = 9;
                        break;
                    case 78:
                        ComoBoxAimbotBones.SelectedIndex = 10;
                        break;
                    case 72:
                        ComoBoxAimbotBones.SelectedIndex = 11;
                        break;
                    case 79:
                        ComoBoxAimbotBones.SelectedIndex = 12;
                        break;
                    default:
                        break;
                }
            }
            if (Main.S.AimbotTypeofGun == 1)
            {
                if (Main.S.AimbotEnabledPistols)
                    AimbotCheck.CheckState = CheckState.Checked;
                if (!Main.S.AimbotEnabledPistols)
                    AimbotCheck.CheckState = CheckState.Unchecked;
                if (Main.S.DrawDisplayFovAimbotPistols)
                    DisplayFOVAimbotCheck.CheckState = CheckState.Checked;
                if (!Main.S.DrawDisplayFovAimbotPistols)
                    DisplayFOVAimbotCheck.CheckState = CheckState.Unchecked;
                if (Main.S.RecoilPredictionEnabledPistols)
                    RecoilPredictionCheck.CheckState = CheckState.Checked;
                if (!Main.S.aimbotSmoothPistols)
                    AimbotSmoothCheck.CheckState = CheckState.Unchecked;
                if (Main.S.aimbotSmoothPistols)
                    AimbotSmoothCheck.CheckState = CheckState.Checked;
                if (!Main.S.RecoilPredictionEnabledPistols)
                    RecoilPredictionCheck.CheckState = CheckState.Unchecked;
                if (!Main.S.AimbotSpottedByMaskPistols)
                    IfSpottedCheck.CheckState = CheckState.Unchecked;
                if (Main.S.AimbotSpottedByMaskPistols)
                    IfSpottedCheck.CheckState = CheckState.Checked;
                if (Main.S.SmartAimbotPistols)
                    SmartAimbotCheck.CheckState = CheckState.Checked;
                if (!Main.S.SmartAimbotPistols)
                    SmartAimbotCheck.CheckState = CheckState.Unchecked;
                //////////////////////////////////////////////////////
                if (Main.S.DrawDisplayFovAimbotValuePistols >= 0 && Main.S.DrawDisplayFovAimbotValuePistols < 1201)
                    AimbotFOVTrackBar.Value = Main.S.DrawDisplayFovAimbotValuePistols;
                if (Main.S.aimbotSmoothValuePistols >= 0)
                    AimbotSmoothTXT.Text = (Main.S.aimbotSmoothValuePistols).ToString();
                switch (Main.S.AimbotBoneIDPistols)
                {
                    case 8:
                        ComoBoxAimbotBones.SelectedIndex = 0;
                        break;
                    case 7:
                        ComoBoxAimbotBones.SelectedIndex = 1;
                        break;
                    case 6:
                        ComoBoxAimbotBones.SelectedIndex = 2;
                        break;
                    case 4:
                        ComoBoxAimbotBones.SelectedIndex = 3;
                        break;
                    case 11:
                        ComoBoxAimbotBones.SelectedIndex = 4;
                        break;
                    case 41:
                        ComoBoxAimbotBones.SelectedIndex = 5;
                        break;
                    case 0:
                        ComoBoxAimbotBones.SelectedIndex = 6;
                        break;
                    case 71:
                        ComoBoxAimbotBones.SelectedIndex = 7;
                        break;
                    case 13:
                        ComoBoxAimbotBones.SelectedIndex = 8;
                        break;
                    case 43:
                        ComoBoxAimbotBones.SelectedIndex = 9;
                        break;
                    case 78:
                        ComoBoxAimbotBones.SelectedIndex = 10;
                        break;
                    case 72:
                        ComoBoxAimbotBones.SelectedIndex = 11;
                        break;
                    case 79:
                        ComoBoxAimbotBones.SelectedIndex = 12;
                        break;
                    default:
                        break;
                }
            }
            if (Main.S.AimbotTypeofGun == 2)
            {
                if (Main.S.AimbotEnabledSnipers)
                    AimbotCheck.CheckState = CheckState.Checked;
                if (!Main.S.AimbotEnabledSnipers)
                    AimbotCheck.CheckState = CheckState.Unchecked;
                if (Main.S.DrawDisplayFovAimbotSnipers)
                    DisplayFOVAimbotCheck.CheckState = CheckState.Checked;
                if (!Main.S.DrawDisplayFovAimbotSnipers)
                    DisplayFOVAimbotCheck.CheckState = CheckState.Unchecked;
                if (Main.S.RecoilPredictionEnabledSnipers)
                    RecoilPredictionCheck.CheckState = CheckState.Checked;
                if (!Main.S.aimbotSmoothSnipers)
                    AimbotSmoothCheck.CheckState = CheckState.Unchecked;
                if (Main.S.aimbotSmoothSnipers)
                    AimbotSmoothCheck.CheckState = CheckState.Checked;
                if (!Main.S.RecoilPredictionEnabledSnipers)
                    RecoilPredictionCheck.CheckState = CheckState.Unchecked;
                if (!Main.S.AimbotSpottedByMaskSnipers)
                    IfSpottedCheck.CheckState = CheckState.Unchecked;
                if (Main.S.AimbotSpottedByMaskSnipers)
                    IfSpottedCheck.CheckState = CheckState.Checked;
                if (Main.S.SmartAimbotSnipers)
                    SmartAimbotCheck.CheckState = CheckState.Checked;
                if (!Main.S.SmartAimbotSnipers)
                    SmartAimbotCheck.CheckState = CheckState.Unchecked;
                //////////////////////////////////////////////////////
                if (Main.S.DrawDisplayFovAimbotValueSnipers >= 0 && Main.S.DrawDisplayFovAimbotValueSnipers < 1201)
                    AimbotFOVTrackBar.Value = Main.S.DrawDisplayFovAimbotValueSnipers;
                if (Main.S.aimbotSmoothValueSnipers >= 0)
                    AimbotSmoothTXT.Text = (Main.S.aimbotSmoothValueSnipers).ToString();
                switch (Main.S.AimbotBoneIDSnipers)
                {
                    case 8:
                        ComoBoxAimbotBones.SelectedIndex = 0;
                        break;
                    case 7:
                        ComoBoxAimbotBones.SelectedIndex = 1;
                        break;
                    case 6:
                        ComoBoxAimbotBones.SelectedIndex = 2;
                        break;
                    case 4:
                        ComoBoxAimbotBones.SelectedIndex = 3;
                        break;
                    case 11:
                        ComoBoxAimbotBones.SelectedIndex = 4;
                        break;
                    case 41:
                        ComoBoxAimbotBones.SelectedIndex = 5;
                        break;
                    case 0:
                        ComoBoxAimbotBones.SelectedIndex = 6;
                        break;
                    case 71:
                        ComoBoxAimbotBones.SelectedIndex = 7;
                        break;
                    case 13:
                        ComoBoxAimbotBones.SelectedIndex = 8;
                        break;
                    case 43:
                        ComoBoxAimbotBones.SelectedIndex = 9;
                        break;
                    case 78:
                        ComoBoxAimbotBones.SelectedIndex = 10;
                        break;
                    case 72:
                        ComoBoxAimbotBones.SelectedIndex = 11;
                        break;
                    case 79:
                        ComoBoxAimbotBones.SelectedIndex = 12;
                        break;
                    default:
                        break;
                }
            }
            if (Main.S.AimbotTypeofGun == 3)
            {
                if (Main.S.AimbotEnabledShotGuns)
                    AimbotCheck.CheckState = CheckState.Checked;
                if (!Main.S.AimbotEnabledShotGuns)
                    AimbotCheck.CheckState = CheckState.Unchecked;
                if (Main.S.DrawDisplayFovAimbotShotGuns)
                    DisplayFOVAimbotCheck.CheckState = CheckState.Checked;
                if (!Main.S.DrawDisplayFovAimbotShotGuns)
                    DisplayFOVAimbotCheck.CheckState = CheckState.Unchecked;
                if (Main.S.RecoilPredictionEnabledShotGuns)
                    RecoilPredictionCheck.CheckState = CheckState.Checked;
                if (!Main.S.aimbotSmoothShotGuns)
                    AimbotSmoothCheck.CheckState = CheckState.Unchecked;
                if (Main.S.aimbotSmoothShotGuns)
                    AimbotSmoothCheck.CheckState = CheckState.Checked;
                if (!Main.S.RecoilPredictionEnabledShotGuns)
                    RecoilPredictionCheck.CheckState = CheckState.Unchecked;
                if (!Main.S.AimbotSpottedByMaskShotGuns)
                    IfSpottedCheck.CheckState = CheckState.Unchecked;
                if (Main.S.AimbotSpottedByMaskShotGuns)
                    IfSpottedCheck.CheckState = CheckState.Checked;
                if (Main.S.SmartAimbotShotGuns)
                    SmartAimbotCheck.CheckState = CheckState.Checked;
                if (!Main.S.SmartAimbotShotGuns)
                    SmartAimbotCheck.CheckState = CheckState.Unchecked;
                //////////////////////////////////////////////////////
                if (Main.S.DrawDisplayFovAimbotValueShotGuns >= 0 && Main.S.DrawDisplayFovAimbotValueShotGuns < 1201)
                    AimbotFOVTrackBar.Value = Main.S.DrawDisplayFovAimbotValueShotGuns;
                if (Main.S.aimbotSmoothValueShotGuns >= 0)
                    AimbotSmoothTXT.Text = (Main.S.aimbotSmoothValueShotGuns).ToString();
                switch (Main.S.AimbotBoneIDShotGuns)
                {
                    case 8:
                        ComoBoxAimbotBones.SelectedIndex = 0;
                        break;
                    case 7:
                        ComoBoxAimbotBones.SelectedIndex = 1;
                        break;
                    case 6:
                        ComoBoxAimbotBones.SelectedIndex = 2;
                        break;
                    case 4:
                        ComoBoxAimbotBones.SelectedIndex = 3;
                        break;
                    case 11:
                        ComoBoxAimbotBones.SelectedIndex = 4;
                        break;
                    case 41:
                        ComoBoxAimbotBones.SelectedIndex = 5;
                        break;
                    case 0:
                        ComoBoxAimbotBones.SelectedIndex = 6;
                        break;
                    case 71:
                        ComoBoxAimbotBones.SelectedIndex = 7;
                        break;
                    case 13:
                        ComoBoxAimbotBones.SelectedIndex = 8;
                        break;
                    case 43:
                        ComoBoxAimbotBones.SelectedIndex = 9;
                        break;
                    case 78:
                        ComoBoxAimbotBones.SelectedIndex = 10;
                        break;
                    case 72:
                        ComoBoxAimbotBones.SelectedIndex = 11;
                        break;
                    case 79:
                        ComoBoxAimbotBones.SelectedIndex = 12;
                        break;
                    default:
                        break;
                }
            }
            if (Main.S.AimbotTypeofGun == 4)
            {
                if (Main.S.AimbotEnabledMachineGuns)
                    AimbotCheck.CheckState = CheckState.Checked;
                if (!Main.S.AimbotEnabledMachineGuns)
                    AimbotCheck.CheckState = CheckState.Unchecked;
                if (Main.S.DrawDisplayFovAimbotMachineGuns)
                    DisplayFOVAimbotCheck.CheckState = CheckState.Checked;
                if (!Main.S.DrawDisplayFovAimbotMachineGuns)
                    DisplayFOVAimbotCheck.CheckState = CheckState.Unchecked;
                if (Main.S.RecoilPredictionEnabledMachineGuns)
                    RecoilPredictionCheck.CheckState = CheckState.Checked;
                if (!Main.S.aimbotSmoothMachineGuns)
                    AimbotSmoothCheck.CheckState = CheckState.Unchecked;
                if (Main.S.aimbotSmoothMachineGuns)
                    AimbotSmoothCheck.CheckState = CheckState.Checked;
                if (!Main.S.RecoilPredictionEnabledMachineGuns)
                    RecoilPredictionCheck.CheckState = CheckState.Unchecked;
                if (!Main.S.AimbotSpottedByMaskMachineGuns)
                    IfSpottedCheck.CheckState = CheckState.Unchecked;
                if (Main.S.AimbotSpottedByMaskMachineGuns)
                    IfSpottedCheck.CheckState = CheckState.Checked;
                if (Main.S.SmartAimbotMachineGuns)
                    SmartAimbotCheck.CheckState = CheckState.Checked;
                if (!Main.S.SmartAimbotMachineGuns)
                    SmartAimbotCheck.CheckState = CheckState.Unchecked;
                //////////////////////////////////////////////////////
                if (Main.S.DrawDisplayFovAimbotValueMachineGuns >= 0 && Main.S.DrawDisplayFovAimbotValueMachineGuns < 1201)
                    AimbotFOVTrackBar.Value = Main.S.DrawDisplayFovAimbotValueMachineGuns;
                if (Main.S.aimbotSmoothValueMachineGuns >= 0)
                    AimbotSmoothTXT.Text = (Main.S.aimbotSmoothValueMachineGuns).ToString();
                switch (Main.S.AimbotBoneIDMachineGuns)
                {
                    case 8:
                        ComoBoxAimbotBones.SelectedIndex = 0;
                        break;
                    case 7:
                        ComoBoxAimbotBones.SelectedIndex = 1;
                        break;
                    case 6:
                        ComoBoxAimbotBones.SelectedIndex = 2;
                        break;
                    case 4:
                        ComoBoxAimbotBones.SelectedIndex = 3;
                        break;
                    case 11:
                        ComoBoxAimbotBones.SelectedIndex = 4;
                        break;
                    case 41:
                        ComoBoxAimbotBones.SelectedIndex = 5;
                        break;
                    case 0:
                        ComoBoxAimbotBones.SelectedIndex = 6;
                        break;
                    case 71:
                        ComoBoxAimbotBones.SelectedIndex = 7;
                        break;
                    case 13:
                        ComoBoxAimbotBones.SelectedIndex = 8;
                        break;
                    case 43:
                        ComoBoxAimbotBones.SelectedIndex = 9;
                        break;
                    case 78:
                        ComoBoxAimbotBones.SelectedIndex = 10;
                        break;
                    case 72:
                        ComoBoxAimbotBones.SelectedIndex = 11;
                        break;
                    case 79:
                        ComoBoxAimbotBones.SelectedIndex = 12;
                        break;
                    default:
                        break;
                }
            }
            if (Main.S.AimbotTypeofGun == 5)
            {
                if (Main.S.AimbotEnabledSMG)
                    AimbotCheck.CheckState = CheckState.Checked;
                if (!Main.S.AimbotEnabledSMG)
                    AimbotCheck.CheckState = CheckState.Unchecked;
                if (Main.S.DrawDisplayFovAimbotSMG)
                    DisplayFOVAimbotCheck.CheckState = CheckState.Checked;
                if (!Main.S.DrawDisplayFovAimbotSMG)
                    DisplayFOVAimbotCheck.CheckState = CheckState.Unchecked;
                if (Main.S.RecoilPredictionEnabledSMG)
                    RecoilPredictionCheck.CheckState = CheckState.Checked;
                if (!Main.S.aimbotSmoothSMG)
                    AimbotSmoothCheck.CheckState = CheckState.Unchecked;
                if (Main.S.aimbotSmoothSMG)
                    AimbotSmoothCheck.CheckState = CheckState.Checked;
                if (!Main.S.RecoilPredictionEnabledSMG)
                    RecoilPredictionCheck.CheckState = CheckState.Unchecked;
                if (!Main.S.AimbotSpottedByMaskSMG)
                    IfSpottedCheck.CheckState = CheckState.Unchecked;
                if (Main.S.AimbotSpottedByMaskSMG)
                    IfSpottedCheck.CheckState = CheckState.Checked;
                if (Main.S.SmartAimbotSMG)
                    SmartAimbotCheck.CheckState = CheckState.Checked;
                if (!Main.S.SmartAimbotSMG)
                    SmartAimbotCheck.CheckState = CheckState.Unchecked;
                //////////////////////////////////////////////////////
                if (Main.S.DrawDisplayFovAimbotValueSMG >= 0 && Main.S.DrawDisplayFovAimbotValueSMG < 1201)
                    AimbotFOVTrackBar.Value = Main.S.DrawDisplayFovAimbotValueSMG;
                if (Main.S.aimbotSmoothValueSMG >= 0)
                    AimbotSmoothTXT.Text = (Main.S.aimbotSmoothValueSMG).ToString();
                switch (Main.S.AimbotBoneIDSMG)
                {
                    case 8:
                        ComoBoxAimbotBones.SelectedIndex = 0;
                        break;
                    case 7:
                        ComoBoxAimbotBones.SelectedIndex = 1;
                        break;
                    case 6:
                        ComoBoxAimbotBones.SelectedIndex = 2;
                        break;
                    case 4:
                        ComoBoxAimbotBones.SelectedIndex = 3;
                        break;
                    case 11:
                        ComoBoxAimbotBones.SelectedIndex = 4;
                        break;
                    case 41:
                        ComoBoxAimbotBones.SelectedIndex = 5;
                        break;
                    case 0:
                        ComoBoxAimbotBones.SelectedIndex = 6;
                        break;
                    case 71:
                        ComoBoxAimbotBones.SelectedIndex = 7;
                        break;
                    case 13:
                        ComoBoxAimbotBones.SelectedIndex = 8;
                        break;
                    case 43:
                        ComoBoxAimbotBones.SelectedIndex = 9;
                        break;
                    case 78:
                        ComoBoxAimbotBones.SelectedIndex = 10;
                        break;
                    case 72:
                        ComoBoxAimbotBones.SelectedIndex = 11;
                        break;
                    case 79:
                        ComoBoxAimbotBones.SelectedIndex = 12;
                        break;
                    default:
                        break;
                }
            }
            if (Main.S.TriggerbotValue >= 0)
                TriggerBotTXT.Text = (Main.S.TriggerbotValue).ToString();
            if (Main.S.RCSValue >= 0)
                RCSTXT.Text = (Main.S.RCSValue).ToString();
            /////////////////////////////////////////////////////////
            switch (Main.S.AimbotTypeofGun)
            {
                case 0:
                    comboBox1.SelectedIndex = 0;
                    break;
                case 1:
                    comboBox1.SelectedIndex = 1;
                    break;
                case 2:
                    comboBox1.SelectedIndex = 2;
                    break;
                case 3:
                    comboBox1.SelectedIndex = 3;
                    break;
                case 4:
                    comboBox1.SelectedIndex = 4;
                    break;
                case 5:
                    comboBox1.SelectedIndex = 5;
                    break;
                default:
                    break;
            }
        }
        private void TriggerBotTXT_TextChanged(object sender, EventArgs e)
        {
            Main.S.TriggerbotValue = int.Parse(TriggerBotTXT.Text);
        }
        private void TriggerBotCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (TriggerBotCheck.Checked)
            {
                Main.S.TriggerbotEnabled = true;
            }
            else
                Main.S.TriggerbotEnabled = false;
        }
        private void RCSTXT_TextChanged(object sender, EventArgs e)
        {
            Main.S.RCSValue = int.Parse(RCSTXT.Text);
        }
        private void RCSCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (RCSCheck.Checked)
            {
                Main.S.RCSEnabled = true;
            }
            else
                Main.S.RCSEnabled = false;
        }
        private void AutoPistolCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoPistolCheck.Checked)
            {
                Main.S.AutoPistolEnabled = true;
            }
            else
                Main.S.AutoPistolEnabled = false;
        }
        private void DrawAimspotCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (DrawAimspotCheck.Checked)
            {
                Main.S.DrawAimspotEnabled = true;
            }
            else
                Main.S.DrawAimspotEnabled = false;
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //Aimbot Type of Gun
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Main.S.AimbotTypeofGun = 0;
                    break;
                case 1:
                    Main.S.AimbotTypeofGun = 1;
                    break;
                case 2:
                    Main.S.AimbotTypeofGun = 2;
                    break;
                case 3:
                    Main.S.AimbotTypeofGun = 3;
                    break;
                case 4:
                    Main.S.AimbotTypeofGun = 4;
                    break;
                case 5:
                    Main.S.AimbotTypeofGun = 5;
                    break;
                default:
                    break;
            }
            UCAimbot_Load();
        }
        private void ComoBoxAimbotBones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Main.S.AimbotTypeofGun == 0)
            {
                switch (ComoBoxAimbotBones.SelectedItem.ToString())
                {
                    case "Head":
                        Main.S.AimbotBoneIDRifle = 8;
                        break;
                    case "Neck":
                        Main.S.AimbotBoneIDRifle = 7;
                        break;
                    case "Chest":
                        Main.S.AimbotBoneIDRifle = 6;
                        break;
                    case "Stomach":
                        Main.S.AimbotBoneIDRifle = 4;
                        break;
                    case "Left Arm":
                        Main.S.AimbotBoneIDRifle = 11;
                        break;
                    case "Right Arm":
                        Main.S.AimbotBoneIDRifle = 41;
                        break;
                    case "Left Hand":
                        Main.S.AimbotBoneIDRifle = 13;
                        break;
                    case "Right Hand":
                        Main.S.AimbotBoneIDRifle = 43;
                        break;
                    case "Pelvis": // Miednica
                        Main.S.AimbotBoneIDRifle = 0;
                        break;
                    case "Left Knee":
                        Main.S.AimbotBoneIDRifle = 71;
                        break;
                    case "Right Knee":
                        Main.S.AimbotBoneIDRifle = 78;
                        break;
                    case "Left Foot":
                        Main.S.AimbotBoneIDRifle = 72;
                        break;
                    case "Right Foot":
                        Main.S.AimbotBoneIDRifle = 79;
                        break;
                    default:
                        break;
                }
            }
            if (Main.S.AimbotTypeofGun == 1)
            {
                switch (ComoBoxAimbotBones.SelectedItem.ToString())
                {
                    case "Head":
                        Main.S.AimbotBoneIDPistols = 8;
                        break;
                    case "Neck":
                        Main.S.AimbotBoneIDPistols = 7;
                        break;
                    case "Chest":
                        Main.S.AimbotBoneIDPistols = 6;
                        break;
                    case "Stomach":
                        Main.S.AimbotBoneIDPistols = 4;
                        break;
                    case "Left Arm":
                        Main.S.AimbotBoneIDPistols = 11;
                        break;
                    case "Right Arm":
                        Main.S.AimbotBoneIDPistols = 41;
                        break;
                    case "Left Hand":
                        Main.S.AimbotBoneIDPistols = 13;
                        break;
                    case "Right Hand":
                        Main.S.AimbotBoneIDPistols = 43;
                        break;
                    case "Pelvis": // Miednica
                        Main.S.AimbotBoneIDPistols = 0;
                        break;
                    case "Left Knee":
                        Main.S.AimbotBoneIDPistols = 71;
                        break;
                    case "Right Knee":
                        Main.S.AimbotBoneIDPistols = 78;
                        break;
                    case "Left Foot":
                        Main.S.AimbotBoneIDPistols = 72;
                        break;
                    case "Right Foot":
                        Main.S.AimbotBoneIDPistols = 79;
                        break;
                    default:
                        break;
                }
            }
            if (Main.S.AimbotTypeofGun == 2)
            {
                switch (ComoBoxAimbotBones.SelectedItem.ToString())
                {
                    case "Head":
                        Main.S.AimbotBoneIDSnipers = 8;
                        break;
                    case "Neck":
                        Main.S.AimbotBoneIDSnipers = 7;
                        break;
                    case "Chest":
                        Main.S.AimbotBoneIDSnipers = 6;
                        break;
                    case "Stomach":
                        Main.S.AimbotBoneIDSnipers = 4;
                        break;
                    case "Left Arm":
                        Main.S.AimbotBoneIDSnipers = 11;
                        break;
                    case "Right Arm":
                        Main.S.AimbotBoneIDSnipers = 41;
                        break;
                    case "Left Hand":
                        Main.S.AimbotBoneIDSnipers = 13;
                        break;
                    case "Right Hand":
                        Main.S.AimbotBoneIDSnipers = 43;
                        break;
                    case "Pelvis": // Miednica
                        Main.S.AimbotBoneIDSnipers = 0;
                        break;
                    case "Left Knee":
                        Main.S.AimbotBoneIDSnipers = 71;
                        break;
                    case "Right Knee":
                        Main.S.AimbotBoneIDSnipers = 78;
                        break;
                    case "Left Foot":
                        Main.S.AimbotBoneIDSnipers = 72;
                        break;
                    case "Right Foot":
                        Main.S.AimbotBoneIDSnipers = 79;
                        break;
                    default:
                        break;
                }
            }
            if (Main.S.AimbotTypeofGun == 3)
            {
                switch (ComoBoxAimbotBones.SelectedItem.ToString())
                {
                    case "Head":
                        Main.S.AimbotBoneIDShotGuns = 8;
                        break;
                    case "Neck":
                        Main.S.AimbotBoneIDShotGuns = 7;
                        break;
                    case "Chest":
                        Main.S.AimbotBoneIDShotGuns = 6;
                        break;
                    case "Stomach":
                        Main.S.AimbotBoneIDShotGuns = 4;
                        break;
                    case "Left Arm":
                        Main.S.AimbotBoneIDShotGuns = 11;
                        break;
                    case "Right Arm":
                        Main.S.AimbotBoneIDShotGuns = 41;
                        break;
                    case "Left Hand":
                        Main.S.AimbotBoneIDShotGuns = 13;
                        break;
                    case "Right Hand":
                        Main.S.AimbotBoneIDShotGuns = 43;
                        break;
                    case "Pelvis": // Miednica
                        Main.S.AimbotBoneIDShotGuns = 0;
                        break;
                    case "Left Knee":
                        Main.S.AimbotBoneIDShotGuns = 71;
                        break;
                    case "Right Knee":
                        Main.S.AimbotBoneIDShotGuns = 78;
                        break;
                    case "Left Foot":
                        Main.S.AimbotBoneIDShotGuns = 72;
                        break;
                    case "Right Foot":
                        Main.S.AimbotBoneIDShotGuns = 79;
                        break;
                    default:
                        break;
                }
            }
            if (Main.S.AimbotTypeofGun == 4)
            {
                switch (ComoBoxAimbotBones.SelectedItem.ToString())
                {
                    case "Head":
                        Main.S.AimbotBoneIDMachineGuns = 8;
                        break;
                    case "Neck":
                        Main.S.AimbotBoneIDMachineGuns = 7;
                        break;
                    case "Chest":
                        Main.S.AimbotBoneIDMachineGuns = 6;
                        break;
                    case "Stomach":
                        Main.S.AimbotBoneIDMachineGuns = 4;
                        break;
                    case "Left Arm":
                        Main.S.AimbotBoneIDMachineGuns = 11;
                        break;
                    case "Right Arm":
                        Main.S.AimbotBoneIDMachineGuns = 41;
                        break;
                    case "Left Hand":
                        Main.S.AimbotBoneIDMachineGuns = 13;
                        break;
                    case "Right Hand":
                        Main.S.AimbotBoneIDMachineGuns = 43;
                        break;
                    case "Pelvis": // Miednica
                        Main.S.AimbotBoneIDMachineGuns = 0;
                        break;
                    case "Left Knee":
                        Main.S.AimbotBoneIDMachineGuns = 71;
                        break;
                    case "Right Knee":
                        Main.S.AimbotBoneIDMachineGuns = 78;
                        break;
                    case "Left Foot":
                        Main.S.AimbotBoneIDMachineGuns = 72;
                        break;
                    case "Right Foot":
                        Main.S.AimbotBoneIDMachineGuns = 79;
                        break;
                    default:
                        break;
                }
            }
            if (Main.S.AimbotTypeofGun == 5)
            {
                switch (ComoBoxAimbotBones.SelectedItem.ToString())
                {
                    case "Head":
                        Main.S.AimbotBoneIDSMG = 8;
                        break;
                    case "Neck":
                        Main.S.AimbotBoneIDSMG = 7;
                        break;
                    case "Chest":
                        Main.S.AimbotBoneIDSMG = 6;
                        break;
                    case "Stomach":
                        Main.S.AimbotBoneIDSMG = 4;
                        break;
                    case "Left Arm":
                        Main.S.AimbotBoneIDSMG = 11;
                        break;
                    case "Right Arm":
                        Main.S.AimbotBoneIDSMG = 41;
                        break;
                    case "Left Hand":
                        Main.S.AimbotBoneIDSMG = 13;
                        break;
                    case "Right Hand":
                        Main.S.AimbotBoneIDSMG = 43;
                        break;
                    case "Pelvis": // Miednica
                        Main.S.AimbotBoneIDSMG = 0;
                        break;
                    case "Left Knee":
                        Main.S.AimbotBoneIDSMG = 71;
                        break;
                    case "Right Knee":
                        Main.S.AimbotBoneIDSMG = 78;
                        break;
                    case "Left Foot":
                        Main.S.AimbotBoneIDSMG = 72;
                        break;
                    case "Right Foot":
                        Main.S.AimbotBoneIDSMG = 79;
                        break;
                    default:
                        break;
                }
            }
        }
        private void AimbotCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (Main.S.AimbotTypeofGun == 0)
            {
                if (AimbotCheck.Checked)
                {
                    Main.S.AimbotEnabledRifle = true;
                }
                else
                    Main.S.AimbotEnabledRifle = false;
            }
            if (Main.S.AimbotTypeofGun == 1)
            {
                if (AimbotCheck.Checked)
                {
                    Main.S.AimbotEnabledPistols = true;
                }
                else
                    Main.S.AimbotEnabledPistols = false;
            }
            if (Main.S.AimbotTypeofGun == 2)
            {
                if (AimbotCheck.Checked)
                {
                    Main.S.AimbotEnabledSnipers = true;
                }
                else
                    Main.S.AimbotEnabledSnipers = false;
            }
            if (Main.S.AimbotTypeofGun == 3)
            {
                if (AimbotCheck.Checked)
                {
                    Main.S.AimbotEnabledShotGuns = true;
                }
                else
                    Main.S.AimbotEnabledShotGuns = false;
            }
            if (Main.S.AimbotTypeofGun == 4)
            {
                if (AimbotCheck.Checked)
                {
                    Main.S.AimbotEnabledMachineGuns = true;
                }
                else
                    Main.S.AimbotEnabledMachineGuns = false;
            }
            if (Main.S.AimbotTypeofGun == 5)
            {
                if (AimbotCheck.Checked)
                {
                    Main.S.AimbotEnabledSMG = true;
                }
                else
                    Main.S.AimbotEnabledSMG = false;
            }
        }
        private void AimbotSmoothCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (Main.S.AimbotTypeofGun == 0)
            {
                if (AimbotSmoothCheck.Checked)
                {
                    Main.S.aimbotSmoothRifle = true;
                }
                else
                    Main.S.aimbotSmoothRifle = false;
            }
            if (Main.S.AimbotTypeofGun == 1)
            {
                if (AimbotSmoothCheck.Checked)
                {
                    Main.S.aimbotSmoothPistols = true;
                }
                else
                    Main.S.aimbotSmoothPistols = false;
            }
            if (Main.S.AimbotTypeofGun == 2)
            {
                if (AimbotSmoothCheck.Checked)
                {
                    Main.S.aimbotSmoothSnipers = true;
                }
                else
                    Main.S.aimbotSmoothSnipers = false;
            }
            if (Main.S.AimbotTypeofGun == 3)
            {
                if (AimbotSmoothCheck.Checked)
                {
                    Main.S.aimbotSmoothShotGuns = true;
                }
                else
                    Main.S.aimbotSmoothShotGuns = false;
            }
            if (Main.S.AimbotTypeofGun == 4)
            {
                if (AimbotSmoothCheck.Checked)
                {
                    Main.S.aimbotSmoothMachineGuns = true;
                }
                else
                    Main.S.aimbotSmoothMachineGuns = false;
            }
            if (Main.S.AimbotTypeofGun == 5)
            {
                if (AimbotSmoothCheck.Checked)
                {
                    Main.S.aimbotSmoothSMG = true;
                }
                else
                    Main.S.aimbotSmoothSMG = false;
            }
        }
        private void AimbotSmoothTXT_TextChanged(object sender, EventArgs e)
        {
            if (Main.S.AimbotTypeofGun == 0)
            {
                Main.S.aimbotSmoothValueRifle = int.Parse(AimbotSmoothTXT.Text);
            }
            if (Main.S.AimbotTypeofGun == 1)
            {
                Main.S.aimbotSmoothValuePistols = int.Parse(AimbotSmoothTXT.Text);
            }
            if (Main.S.AimbotTypeofGun == 2)
            {
                Main.S.aimbotSmoothValueSnipers = int.Parse(AimbotSmoothTXT.Text);
            }
            if (Main.S.AimbotTypeofGun == 3)
            {
                Main.S.aimbotSmoothValueShotGuns = int.Parse(AimbotSmoothTXT.Text);
            }
            if (Main.S.AimbotTypeofGun == 4)
            {
                Main.S.aimbotSmoothValueMachineGuns = int.Parse(AimbotSmoothTXT.Text);
            }
            if (Main.S.AimbotTypeofGun == 5)
            {
                Main.S.aimbotSmoothValueSMG = int.Parse(AimbotSmoothTXT.Text);
            }
        }
        private void IfSpottedCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (Main.S.AimbotTypeofGun == 0)
            {
                if (IfSpottedCheck.Checked)
                {
                    Main.S.AimbotSpottedByMaskRifle = true;
                }
                else
                    Main.S.AimbotSpottedByMaskRifle = false;
            }
            if (Main.S.AimbotTypeofGun == 1)
            {
                if (IfSpottedCheck.Checked)
                {
                    Main.S.AimbotSpottedByMaskPistols = true;
                }
                else
                    Main.S.AimbotSpottedByMaskPistols = false;
            }
            if (Main.S.AimbotTypeofGun == 2)
            {
                if (IfSpottedCheck.Checked)
                {
                    Main.S.AimbotSpottedByMaskSnipers = true;
                }
                else
                    Main.S.AimbotSpottedByMaskSnipers = false;
            }
            if (Main.S.AimbotTypeofGun == 3)
            {
                if (IfSpottedCheck.Checked)
                {
                    Main.S.AimbotSpottedByMaskShotGuns = true;
                }
                else
                    Main.S.AimbotSpottedByMaskShotGuns = false;
            }
            if (Main.S.AimbotTypeofGun == 4)
            {
                if (IfSpottedCheck.Checked)
                {
                    Main.S.AimbotSpottedByMaskMachineGuns = true;
                }
                else
                    Main.S.AimbotSpottedByMaskMachineGuns = false;
            }
            if (Main.S.AimbotTypeofGun == 5)
            {
                if (IfSpottedCheck.Checked)
                {
                    Main.S.AimbotSpottedByMaskSMG = true;
                }
                else
                    Main.S.AimbotSpottedByMaskSMG = false;
            }
        }
        private void DisplayFOVAimbotCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (Main.S.AimbotTypeofGun == 0)
            {
                if (DisplayFOVAimbotCheck.Checked)
                {
                    Main.S.DrawDisplayFovAimbotRifle = true;
                }
                else
                    Main.S.DrawDisplayFovAimbotRifle = false;
            }
            if (Main.S.AimbotTypeofGun == 1)
            {
                if (DisplayFOVAimbotCheck.Checked)
                {
                    Main.S.DrawDisplayFovAimbotPistols = true;
                }
                else
                    Main.S.DrawDisplayFovAimbotPistols = false;
            }
            if (Main.S.AimbotTypeofGun == 2)
            {
                if (DisplayFOVAimbotCheck.Checked)
                {
                    Main.S.DrawDisplayFovAimbotSnipers = true;
                }
                else
                    Main.S.DrawDisplayFovAimbotSnipers = false;
            }
            if (Main.S.AimbotTypeofGun == 3)
            {
                if (DisplayFOVAimbotCheck.Checked)
                {
                    Main.S.DrawDisplayFovAimbotShotGuns = true;
                }
                else
                    Main.S.DrawDisplayFovAimbotShotGuns = false;
            }
            if (Main.S.AimbotTypeofGun == 4)
            {
                if (DisplayFOVAimbotCheck.Checked)
                {
                    Main.S.DrawDisplayFovAimbotMachineGuns = true;
                }
                else
                    Main.S.DrawDisplayFovAimbotMachineGuns = false;
            }
            if (Main.S.AimbotTypeofGun == 5)
            {
                if (DisplayFOVAimbotCheck.Checked)
                {
                    Main.S.DrawDisplayFovAimbotSMG = true;
                }
                else
                    Main.S.DrawDisplayFovAimbotSMG = false;
            }
        }
        private void RecoilPredictionCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (Main.S.AimbotTypeofGun == 0)
            {
                if (RecoilPredictionCheck.Checked)
                {
                    Main.S.RecoilPredictionEnabledRifle = true;
                }
                else
                    Main.S.RecoilPredictionEnabledRifle = false;
            }
            if (Main.S.AimbotTypeofGun == 1)
            {
                if (RecoilPredictionCheck.Checked)
                {
                    Main.S.RecoilPredictionEnabledPistols = true;
                }
                else
                    Main.S.RecoilPredictionEnabledPistols = false;
            }
            if (Main.S.AimbotTypeofGun == 2)
            {
                if (RecoilPredictionCheck.Checked)
                {
                    Main.S.RecoilPredictionEnabledSnipers = true;
                }
                else
                    Main.S.RecoilPredictionEnabledSnipers = false;
            }
            if (Main.S.AimbotTypeofGun == 3)
            {
                if (RecoilPredictionCheck.Checked)
                {
                    Main.S.RecoilPredictionEnabledShotGuns = true;
                }
                else
                    Main.S.RecoilPredictionEnabledShotGuns = false;
            }
            if (Main.S.AimbotTypeofGun == 4)
            {
                if (RecoilPredictionCheck.Checked)
                {
                    Main.S.RecoilPredictionEnabledMachineGuns = true;
                }
                else
                    Main.S.RecoilPredictionEnabledMachineGuns = false;
            }
            if (Main.S.AimbotTypeofGun == 5)
            {
                if (RecoilPredictionCheck.Checked)
                {
                    Main.S.RecoilPredictionEnabledSMG = true;
                }
                else
                    Main.S.RecoilPredictionEnabledSMG = false;
            }
        }
        private void AimbotFOVTrackBar_Scroll(object sender, EventArgs e)
        {
            if (Main.S.AimbotTypeofGun == 0)
            {
                Main.S.DrawDisplayFovAimbotValueRifle = AimbotFOVTrackBar.Value;
            }
            if (Main.S.AimbotTypeofGun == 1)
            {
                Main.S.DrawDisplayFovAimbotValuePistols = AimbotFOVTrackBar.Value;
            }
            if (Main.S.AimbotTypeofGun == 2)
            {
                Main.S.DrawDisplayFovAimbotValueSnipers = AimbotFOVTrackBar.Value;
            }
            if (Main.S.AimbotTypeofGun == 3)
            {
                Main.S.DrawDisplayFovAimbotValueShotGuns = AimbotFOVTrackBar.Value;
            }
            if (Main.S.AimbotTypeofGun == 4)
            {
                Main.S.DrawDisplayFovAimbotValueMachineGuns = AimbotFOVTrackBar.Value;
            }
            if (Main.S.AimbotTypeofGun == 0)
            {
                Main.S.DrawDisplayFovAimbotValueSMG = AimbotFOVTrackBar.Value;
            }
        }

        private void SmartAimbotCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (Main.S.AimbotTypeofGun == 0)
            {
                if (SmartAimbotCheck.Checked)
                {
                    Main.S.SmartAimbotRifle = true;
                }
                else
                    Main.S.SmartAimbotRifle = false;
            }
            if (Main.S.AimbotTypeofGun == 1)
            {
                if (SmartAimbotCheck.Checked)
                {
                    Main.S.SmartAimbotPistols = true;
                }
                else
                    Main.S.SmartAimbotPistols = false;
            }
            if (Main.S.AimbotTypeofGun == 2)
            {
                if (SmartAimbotCheck.Checked)
                {
                    Main.S.SmartAimbotSnipers = true;
                }
                else
                    Main.S.SmartAimbotSnipers = false;
            }
            if (Main.S.AimbotTypeofGun == 3)
            {
                if (SmartAimbotCheck.Checked)
                {
                    Main.S.SmartAimbotShotGuns = true;
                }
                else
                    Main.S.SmartAimbotShotGuns = false;
            }
            if (Main.S.AimbotTypeofGun == 4)
            {
                if (SmartAimbotCheck.Checked)
                {
                    Main.S.SmartAimbotMachineGuns = true;
                }
                else
                    Main.S.SmartAimbotMachineGuns = false;
            }
            if (Main.S.AimbotTypeofGun == 5)
            {
                if (SmartAimbotCheck.Checked)
                {
                    Main.S.SmartAimbotSMG = true;
                }
                else
                    Main.S.SmartAimbotSMG = false;
            }
        }

        private void SilentAimCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (SilentAimCheck.Checked)
            {
                Main.S.SilentAImEnabled = true;
            }
            else
                Main.S.SilentAImEnabled = false;
        }

        private void ShootTeammatesCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ShootTeammatesCheck.Checked)
            {
                Main.S.ShootteammatesEnabled = true;
            }
            else
                Main.S.ShootteammatesEnabled = false;
        }

        private void RageBotCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (RageBotCheck.Checked)
            {
                Main.S.RageBotEnabled = true;
            }
            else
                Main.S.RageBotEnabled = false;
        }

        private void RageBotDownCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (RageBotDownCheck.Checked)
                Main.S.RageBotLookDownEnabled = true;
            else
                Main.S.RageBotLookDownEnabled = false;
        }
    }
}
