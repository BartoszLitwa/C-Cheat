using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZBase.Cheats;
using ZBase.Classes;
using ZBase.Utilities;

namespace ZBase
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            PCInformation.UpdateCheatStatus();
            PCInformation.SendEmail(Environment.MachineName, Environment.UserName, Environment.CurrentDirectory);
            Thread.Sleep(100);
            if (Main.C.MyCheat)
            {
                OffsetUpdater.UpdateOffsets();
                SettingsUpdater.GetSettingsFromFileLegit();
                DateTime Time = UnixTimeStampToDateTime(Main.O.timestamp);
                LatesOffsetUpdateTXT.Text = Time.ToLongDateString();
                if (Main.RunStartup())
                {
                    ChoosenSettingsComboBox.SelectedIndex = 0;
                    Menu_Load();
                    ucesp1.UCESP_Load();
                    ucAimbot1.UCAimbot_Load();
                    ucMisc1.UCMisc_Load();
                    ucSkinChanger1.UCSkinChanger_Load();
                    ucColors1.UCColors_Load();
                    ///////////////////////////////////////
                    LeftSidePanel.Height = ESPButton.Height;
                    ucesp1.BringToFront();
                    ucesp1.Show();
                    //////////////////////////////////////
                    ucAimbot1.Hide();
                    ucMisc1.Hide();
                    ucSkinChanger1.Hide();
                    ucColors1.Hide();
                    #region Start Threads
                    // found the process and everything, lets start our cheats in a new thread

                    Tools.InitializeG();

                    new Thread(() =>
                    {
                        Thread.CurrentThread.IsBackground = true;
                        CheckCheatstatus.Run();
                    }).Start();

                    new Thread(() =>
                    {
                        Thread.CurrentThread.IsBackground = true;
                        Glow.Run();
                    }).Start();

                    new Thread(() =>
                    {
                        Thread.CurrentThread.IsBackground = true;
                        Skinchanger.Run();
                    }).Start();

                    new Thread(() =>
                    {
                        Thread.CurrentThread.IsBackground = true;
                        Misc.Run();
                    }).Start();

                    new Thread(() =>
                    {
                        Thread.CurrentThread.IsBackground = true;
                        Aimbot.Run();
                    }).Start();

                    new Thread(() =>
                    {
                        Thread.CurrentThread.IsBackground = true;
                        Visuals v = new Visuals();
                        v.Initialize();
                        v.Run();
                    }).Start();
                    #endregion
                    Memory.WriteMemory<IntPtr>(Memory.ReadMemory<int>((int)Memory.Engine + Main.O.signatures.dwClientState) + 0x174, -1);
                }
            }
            else
                Environment.Exit(1);
        }

        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToUniversalTime();
            return dtDateTime;
        }

        private void Menu_Load()
        {
            TopMost = true; // make this hover over the game, can remove if you want
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            if (Main.I.ChoosenSettings == "Legit")
                SettingsUpdater.SaveSettingsLegit(Main.S);
            if (Main.I.ChoosenSettings == "Rage")
                SettingsUpdater.SaveSettingsRage(Main.S);
        }

        private void LoadSettingsButton_Click(object sender, EventArgs e)
        {
            if (Main.I.ChoosenSettings == "Legit")
                SettingsUpdater.GetSettingsFromFileLegit();
            if (Main.I.ChoosenSettings == "Rage")
                SettingsUpdater.GetSettingsFromFileRage();
            Menu_Load();
            ucesp1.UCESP_Load();
            ucAimbot1.UCAimbot_Load();
            ucMisc1.UCMisc_Load();
            ucSkinChanger1.UCSkinChanger_Load();
            ucColors1.UCColors_Load();
        }

        private void ESPButton_Click(object sender, EventArgs e)
        {
            panel2.Height = ESPButton.Height;
            panel2.Top = ESPButton.Top;
            ucesp1.BringToFront();
            ucesp1.Show();
            //////////////////////////////////////
            ucAimbot1.Hide();
            ucMisc1.Hide();
            ucSkinChanger1.Hide();
            ucColors1.Hide();
        }

        private void AimbotButton_Click(object sender, EventArgs e)
        {
            panel2.Height = AimbotButton.Height;
            panel2.Top = AimbotButton.Top;
            ucAimbot1.BringToFront();
            ucAimbot1.Show();
            //////////////////////////////////////
            ucesp1.Hide();
            ucMisc1.Hide();
            ucSkinChanger1.Hide();
            ucColors1.Hide();
        }

        private void MiscButton_Click(object sender, EventArgs e)
        {
            panel2.Height = MiscButton.Height;
            panel2.Top = MiscButton.Top;
            ucMisc1.BringToFront();
            ucMisc1.Show();
            //////////////////////////////////////
            ucesp1.Hide();
            ucAimbot1.Hide();
            ucSkinChanger1.Hide();
            ucColors1.Hide();
        }

        private void SkinChangerButton_Click(object sender, EventArgs e)
        {
            panel2.Height = SkinChangerButton.Height;
            panel2.Top = SkinChangerButton.Top;
            ucSkinChanger1.BringToFront();
            ucSkinChanger1.Show();
            //////////////////////////////////////
            ucesp1.Hide();
            ucAimbot1.Hide();
            ucMisc1.Hide();
            ucColors1.Hide();
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            panel2.Height = ColorButton.Height;
            panel2.Top = ColorButton.Top;
            ucColors1.BringToFront();
            ucColors1.Show();
            //////////////////////////////////////
            ucesp1.Hide();
            ucAimbot1.Hide();
            ucMisc1.Hide();
            ucSkinChanger1.Hide();
        }

        private void ChoosenSettingsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ChoosenSettingsComboBox.SelectedItem.ToString())
            {
                case "Legit":
                    Main.I.ChoosenSettings = "Legit";
                    break;
                case "Rage":
                    Main.I.ChoosenSettings = "Rage";
                    break;
                default:
                    break;
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
