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

namespace ZBase.Forms
{
    public partial class UCMisc : UserControl
    {
        public UCMisc()
        {
            InitializeComponent();
        }


        public void UCMisc_Load()
        {
            if (Main.S.BunnyhopEnabled)
                BunnyhopCheck.CheckState = CheckState.Checked;
            if (!Main.S.BunnyhopEnabled)
                BunnyhopCheck.CheckState = CheckState.Unchecked;
            if (Main.S.FAKELAGEnabled)
                FakeLagCheck.CheckState = CheckState.Checked;
            if (Main.S.FOVEnabled)
                FOVChangerCheck.CheckState = CheckState.Checked;
            if (Main.S.NightMode)
                NightModeCheck.CheckState = CheckState.Checked;
            if (Main.S.AntiFlashEnabled)
                AntiFlashCheck.CheckState = CheckState.Checked;
            if (Main.S.NoHandsEnabled)
                NoHandsCheck.CheckState = CheckState.Checked;
            if (Main.S.THIRDPERSONEnabled)
                ThirdPersonCheck.CheckState = CheckState.Checked;
            if (!Main.S.FAKELAGEnabled)
                FakeLagCheck.CheckState = CheckState.Unchecked;
            if (!Main.S.FOVEnabled)
                FOVChangerCheck.CheckState = CheckState.Unchecked;
            if (!Main.S.NightMode)
                NightModeCheck.CheckState = CheckState.Unchecked;
            if (!Main.S.AntiFlashEnabled)
                AntiFlashCheck.CheckState = CheckState.Unchecked;
            if (!Main.S.NoHandsEnabled)
                NoHandsCheck.CheckState = CheckState.Unchecked;
            if (!Main.S.THIRDPERSONEnabled)
                ThirdPersonCheck.CheckState = CheckState.Unchecked;
            if (!Main.S.AntiAimEnabled)
                AntiAimCheck.CheckState = CheckState.Unchecked;
            if (Main.S.AntiAimEnabled)
                AntiAimCheck.CheckState = CheckState.Checked;
            //////////////////////////////////////////////////////
            if (Main.S.AntiFlashAlpha >= 0 && Main.S.AntiFlashAlpha < 256)
                AntiFlashTrackBar.Value = Main.S.AntiFlashAlpha;
            if (Main.S.FOVValue >= 0)
                FOVChangerTXT.Text = (Main.S.FOVValue).ToString();
        }

        private void FOVChangerCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (FOVChangerCheck.Checked)
            {
                Main.S.FOVEnabled = true;
            }
            else
                Main.S.FOVEnabled = false;
        }

        private void FOVChangerTXT_TextChanged(object sender, EventArgs e)
        {
            Main.S.FOVValue = int.Parse(FOVChangerTXT.Text);
        }

        private void AntiFlashLabel_Click(object sender, EventArgs e)
        {

        }

        private void AntiFlashTrackBar_Scroll(object sender, EventArgs e)
        {
            Main.S.AntiFlashAlpha = AntiFlashTrackBar.Value;
        }

        private void AntiFlashCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (AntiFlashCheck.Checked)
            {
                Main.S.AntiFlashEnabled = true;
            }
            else
                Main.S.AntiFlashEnabled = false;
        }

        private void NoHandsCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (NoHandsCheck.Checked)
            {
                Main.S.NoHandsEnabled = true;
            }
            else
                Main.S.NoHandsEnabled = false;
        }

        private void ThirdPersonCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ThirdPersonCheck.Checked)
            {
                Main.S.THIRDPERSONEnabled = true;
            }
            else
                Main.S.THIRDPERSONEnabled = false;
        }

        private void NightModeCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (NightModeCheck.Checked)
            {
                Main.S.NightMode = true;
            }
            else
                Main.S.NightMode = false;
        }

        private void FakeLagCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (FakeLagCheck.Checked)
            {
                Main.S.FAKELAGEnabled = true;
            }
            else
                Main.S.FAKELAGEnabled = false;
        }

        private void FakeLagTXT_TextChanged(object sender, EventArgs e)
        {
            Main.S.FAKELAGValue = int.Parse(FakeLagTXT.Text);
        }

        private void BunnyhopCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (BunnyhopCheck.Checked)
            {
                Main.S.BunnyhopEnabled = true;
            }
            else
                Main.S.BunnyhopEnabled = false;
        }

        private void AntiAimCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (AntiAimCheck.Checked)
            {
                Main.S.AntiAimEnabled = true;
            }
            else
                Main.S.AntiAimEnabled = false;
        }

        private void HitMarkerCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (HitMarkerCheck.Checked)
                Main.S.HitmarkerEnabled = true;
            else
                Main.S.HitmarkerEnabled = false;
        }
    }
}
