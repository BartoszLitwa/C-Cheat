using System;
using System.Numerics;
using GameOverlay.Drawing;
using GameOverlay.Windows;
using ZBase.Classes;
using ZBase.Utilities;
using Color = System.Drawing.Color;

namespace ZBase.Cheats
{
    public class Visuals
    {
        #region dx shid
        private OverlayWindow _window;
        private Graphics _graphics;

        public Visuals()
        {
            _window = new OverlayWindow(Main.ScreenRect.left, Main.ScreenRect.top, Main.ScreenSize.Width, Main.ScreenSize.Height)
            {
                IsTopmost = true,
                IsVisible = true
            };
            _window.SizeChanged += _window_SizeChanged;
            _graphics = new Graphics()
            {
                MeasureFPS = true,
                Height = _window.Height,
                PerPrimitiveAntiAliasing = true,
                TextAntiAliasing = true,
                UseMultiThreadedFactories = false,
                VSync = true,
                Width = _window.Width,
                WindowHandle = IntPtr.Zero
            };
        }

        ~Visuals()
        {
            _graphics.Dispose();
            _window.Dispose();
        }

        public void Initialize()
        {
            _window.CreateWindow();
            _graphics.WindowHandle = _window.Handle; // set the target handle before calling Setup()
            _graphics.Setup();
        }

        private void _window_SizeChanged(object sender, OverlaySizeEventArgs e)
        {
            if (_graphics == null) return;

            if (_graphics.IsInitialized)
            {
                // after the Graphics surface is initialized you can only use the Resize method in order to enqueue a size change
                _graphics.Resize(e.Width, e.Height);
            }
            else
            {
                // otherwise just set its members
                _graphics.Width = e.Width;
                _graphics.Height = e.Height;
            }
        }
        #endregion
        public void Run()
        {
            #region things
            var gfx = _graphics;
            SolidBrush GetBrushColor(Color color)
            {
                return gfx.CreateSolidBrush(color.R, color.G, color.B, color.A);
            }
            #endregion
            #region Draw
            while (true)
            {
                gfx.BeginScene();
                gfx.ClearScene();
                // start drawings here
                Color CrosshairColor = Color.Green;
                int PlayerHealth = 100;
                int TypeOfGun = (int)G.Engine.LocalPlayer.WeaponID;
                DrawTextWithBackground("CRNYY's Cheat", 10, 0, 10, Color.Maroon, Color.Black);
                if (Main.S.ESP)
                {
                    if (Main.S.DebugEnabled)
                    {

                            //DrawTextWithBackground(.ToString(), Main.MidScreen.X, 0, 10, Color.Maroon, Color.White);
                           // DrawTextWithBackground(Chestdis.ToString(), Main.MidScreen.X, 20, 10, Color.Maroon, Color.White);
                           // DrawTextWithBackground(Stomachdis.ToString(), Main.MidScreen.X, 40, 10, Color.Maroon, Color.White);

                    }
                    //////////
                    if (!Main.S.RageBotEnabled)
                    {
                        if (Main.S.DrawDisplayFovAimbotRifle && G.Engine.LocalPlayer.IsRifle(TypeOfGun))
                        {
                            DrawCircle(Main.MidScreen.X, Main.MidScreen.Y, Main.S.DrawDisplayFovAimbotValueRifle, Color.White);
                        }
                        if (Main.S.DrawDisplayFovAimbotPistols && G.Engine.LocalPlayer.IsPistol(TypeOfGun))
                        {
                            DrawCircle(Main.MidScreen.X, Main.MidScreen.Y, Main.S.DrawDisplayFovAimbotValuePistols, Color.White);
                        }
                        if (Main.S.DrawDisplayFovAimbotSnipers && G.Engine.LocalPlayer.IsSniper(TypeOfGun))
                        {
                            DrawCircle(Main.MidScreen.X, Main.MidScreen.Y, Main.S.DrawDisplayFovAimbotValueSnipers, Color.White);
                        }
                        if (Main.S.DrawDisplayFovAimbotShotGuns && G.Engine.LocalPlayer.IsShotgun(TypeOfGun))
                        {
                            DrawCircle(Main.MidScreen.X, Main.MidScreen.Y, Main.S.DrawDisplayFovAimbotValueShotGuns, Color.White);
                        }
                        if (Main.S.DrawDisplayFovAimbotMachineGuns && G.Engine.LocalPlayer.IsMachineGun(TypeOfGun))
                        {
                            DrawCircle(Main.MidScreen.X, Main.MidScreen.Y, Main.S.DrawDisplayFovAimbotValueMachineGuns, Color.White);
                        }
                        if (Main.S.DrawDisplayFovAimbotSMG && G.Engine.LocalPlayer.IsMP(TypeOfGun))
                        {
                            DrawCircle(Main.MidScreen.X, Main.MidScreen.Y, Main.S.DrawDisplayFovAimbotValueSMG, Color.White);
                        }
                    }
                    if (Main.S.DrawSmartCrosshairEnabled)
                    {
                        int myteam = G.Engine.LocalPlayer.Team;
                        var crosshairEntity = Tools.GetEntityBaseFromCrosshair(G.Engine.LocalPlayer.CrosshairID);
                        int EntityTeam = Memory.ReadMemory<int>(crosshairEntity + Main.O.netvars.m_iTeamNum);
                        if (EntityTeam != myteam)
                        {
                            CrosshairColor = Color.Red;
                        }
                        if (EntityTeam == myteam)
                        {
                            CrosshairColor = Color.Blue;
                        }
                        if (EntityTeam != myteam && EntityTeam != 2 && EntityTeam != 3)
                            CrosshairColor = Color.Green;
                    }
                    if (Main.S.RecoilCrosshairEnabled)
                    {
                        int cos = 90;
                        if ((Main.S.RecoilPredictionEnabledRifle && G.Engine.LocalPlayer.IsRifle(TypeOfGun)) || (Main.S.RecoilPredictionEnabledPistols && G.Engine.LocalPlayer.IsPistol(TypeOfGun))
                            || (Main.S.RecoilPredictionEnabledSnipers && G.Engine.LocalPlayer.IsSniper(TypeOfGun)) || (Main.S.RecoilPredictionEnabledShotGuns && G.Engine.LocalPlayer.IsShotgun(TypeOfGun))
                            || (Main.S.RecoilPredictionEnabledMachineGuns && G.Engine.LocalPlayer.IsMachineGun(TypeOfGun)) || (Main.S.RecoilPredictionEnabledSMG && G.Engine.LocalPlayer.IsMP(TypeOfGun)))
                        {
                            cos = 180;
                        }
                        float x = Main.MidScreen.X;
                        float y = Main.MidScreen.Y;
                        float dy = Main.ScreenSize.Height / cos;
                        float dx = Main.ScreenSize.Width / cos;
                        x -= (dx * G.Engine.LocalPlayer.AimPunchAngle.Y);
                        y += (dy * G.Engine.LocalPlayer.AimPunchAngle.X);
                        if (Main.S.TypeOfCrosshair == 0)
                            DrawCrosshair(CrosshairStyle.Dot, x, y, 10, 2, CrosshairColor);
                        if (Main.S.TypeOfCrosshair == 1)
                            DrawCrosshair(CrosshairStyle.Plus, x, y, 10, 2, CrosshairColor);
                        if (Main.S.TypeOfCrosshair == 2)
                            DrawCrosshair(CrosshairStyle.Cross, x, y, 10, 2, CrosshairColor);
                        if (Main.S.TypeOfCrosshair == 3)
                            DrawCrosshair(CrosshairStyle.Gap, x, y, 10, 2, CrosshairColor);
                        if (Main.S.TypeOfCrosshair == 4)
                            DrawCrosshair(CrosshairStyle.Diagonal, x, y, 10, 2, CrosshairColor);
                    }
                    if (Main.S.CrosshairSniperEnabled)
                    {
                        if (Main.S.TypeOfCrosshair == 0)
                            DrawCrosshair(CrosshairStyle.Dot, Main.MidScreen.X, Main.MidScreen.Y, 10, 2, CrosshairColor);
                        if (Main.S.TypeOfCrosshair == 1)
                            DrawCrosshair(CrosshairStyle.Plus, Main.MidScreen.X, Main.MidScreen.Y, 10, 2, CrosshairColor);
                        if (Main.S.TypeOfCrosshair == 2)
                            DrawCrosshair(CrosshairStyle.Cross, Main.MidScreen.X, Main.MidScreen.Y, 10, 2, CrosshairColor);
                        if (Main.S.TypeOfCrosshair == 3)
                            DrawCrosshair(CrosshairStyle.Gap, Main.MidScreen.X, Main.MidScreen.Y, 10, 2, CrosshairColor);
                        if (Main.S.TypeOfCrosshair == 4)
                            DrawCrosshair(CrosshairStyle.Diagonal, Main.MidScreen.X, Main.MidScreen.Y, 10, 2, CrosshairColor);
                    }
                    if (Main.S.DrawHealthBarLeftSide)
                    {
                        int healthme = G.Engine.LocalPlayer.Health;
                        if(healthme > 100)
                        {
                            healthme = 100;
                        }
                        Color HealthColorMe = Tools.HealthGradient(Tools.HealthToPercent((int)healthme));
                        DrawFilledBox(Main.ScreenRect.left, Main.ScreenRect.bottom, 10, -(Main.ScreenSize.Height * (healthme / 100f)), HealthColorMe);
                    }
                    if (Main.S.DrawWeaponESP)
                    {
                        #region WeaponESP
                        int gp = Memory.ReadMemory<int>((int)Memory.Client + Main.O.signatures.dwGlowObjectManager);
                        int ObjectCount = Memory.ReadMemory<int>((int)Memory.Client + Main.O.signatures.dwGlowObjectManager + 0x4);
                        for (int i = 0; i < ObjectCount; i++)
                        {
                            int EntityBase = Memory.ReadMemory<int>(gp + 0x38 * i); //Entity
                            int one = Memory.ReadMemory<int>(EntityBase + 0x8);
                            int two = Memory.ReadMemory<int>(one + 0x8);
                            int three = Memory.ReadMemory<int>(two + 0x1);
                            int ClassID = Memory.ReadMemory<int>(three + 0x14);
                            Vector3 pos0 = new Vector3(0, 0, 0);
                            Vector2 pos02 = new Vector2(0, 0);
                            Vector3 entitypos = Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecOrigin);
                            Vector2 entityw2spos = Tools.WorldToScreen(entitypos);
                            if (entitypos != pos0 && Tools.InScreenPos(entityw2spos.X,entityw2spos.Y))
                            {
                                switch (ClassID)
                                {
                                    case 1: //AK47
                                        if (Main.S.GlowAK47)
                                        {
                                            Main.I.PosAK47 = Tools.WorldToScreen(Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecOrigin));
                                            if (Main.I.PosAK47 != pos02)
                                                DrawText("AK47", Main.I.PosAK47.X, Main.I.PosAK47.Y, 8, Color.White);
                                        }
                                        break;
                                    case 44: //Deagle
                                        if (Main.S.GlowDeagle)
                                        {
                                            Main.I.PosDeagle = Tools.WorldToScreen(Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecOrigin));
                                            if (Main.I.PosDeagle != pos02)
                                                DrawText("Deagle", Main.I.PosDeagle.X, Main.I.PosDeagle.Y, 8, Color.White);
                                        }
                                        break;
                                    case 228: //AUG
                                        if (Main.S.GlowAUG)
                                        {
                                            Main.I.PosAUG = Tools.WorldToScreen(Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecOrigin));
                                            if (Main.I.PosAUG != pos02)
                                                DrawText("AUG", Main.I.PosAUG.X, Main.I.PosAUG.Y, 8, Color.White);
                                        }
                                        break;
                                    case 229: //AWP
                                        if (Main.S.GlowAWP)
                                        {
                                            Main.I.PosAWP = Tools.WorldToScreen(Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecOrigin));
                                            if (Main.I.PosAWP != pos02)
                                                DrawText("AWP", Main.I.PosAWP.X, Main.I.PosAWP.Y, 8, Color.White);
                                        }
                                        break;
                                    case 245: //M4
                                        if (Main.S.GlowM4)
                                        {
                                            Main.I.PosM4 = Tools.WorldToScreen(Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecOrigin));
                                            if (Main.I.PosM4 != pos02)
                                                DrawText("M4", Main.I.PosM4.X, Main.I.PosM4.Y, 8, Color.White);
                                        }
                                        break;
                                    case 231: //Bizon
                                        if (Main.S.GlowBizon)
                                        {
                                            Main.I.PosBizon = Tools.WorldToScreen(Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecOrigin));
                                            if (Main.I.PosBizon != pos02)
                                                DrawText("Bizon", Main.I.PosBizon.X, Main.I.PosBizon.Y, 8, Color.White);
                                        }
                                        break;
                                    case 235: //Elite Berettas
                                        if (Main.S.GlowBerettas)
                                        {
                                            Main.I.PosBerettas = Tools.WorldToScreen(Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecOrigin));
                                            if (Main.I.PosBerettas != pos02)
                                                DrawText("Berettas", Main.I.PosBerettas.X, Main.I.PosBerettas.Y, 8, Color.White);
                                        }
                                        break;
                                    case 236: //Famas
                                        if (Main.S.GlowFamas)
                                        {
                                            Main.I.PosFamas = Tools.WorldToScreen(Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecOrigin));
                                            if (Main.I.PosFamas != pos02)
                                                DrawText("Famas", Main.I.PosFamas.X, Main.I.PosFamas.Y, 8, Color.White);
                                        }
                                        break;
                                    case 237: //Five-Seven
                                        if (Main.S.GlowFiveSeven)
                                        {
                                            Main.I.PosFiveSeven = Tools.WorldToScreen(Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecOrigin));
                                            if (Main.I.PosFiveSeven != pos02)
                                                DrawText("Five-Seven", Main.I.PosFiveSeven.X, Main.I.PosFiveSeven.Y, 8, Color.White);
                                        }
                                        break;
                                    case 238: //G3SG1
                                        if (Main.S.GlowG3SG1)
                                        {
                                            Main.I.PosG3SG1 = Tools.WorldToScreen(Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecOrigin));
                                            if (Main.I.PosG3SG1 != pos02)
                                                DrawText("G3SG1", Main.I.PosG3SG1.X, Main.I.PosG3SG1.Y, 8, Color.White);
                                        }
                                        break;
                                    case 240: //GalilAR
                                        if (Main.S.GlowGalil)
                                        {
                                            Main.I.PosGalilAR = Tools.WorldToScreen(Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecOrigin));
                                            if (Main.I.PosGalilAR != pos02)
                                                DrawText("GalilAR", Main.I.PosGalilAR.X, Main.I.PosGalilAR.Y, 8, Color.White);
                                        }
                                        break;
                                    case 241: //Glock
                                        if (Main.S.GlowGlock18)
                                        {
                                            Main.I.PosGlock = Tools.WorldToScreen(Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecOrigin));
                                            if (Main.I.PosGlock != pos02)
                                                DrawText("Glock-18", Main.I.PosGlock.X, Main.I.PosGlock.Y, 8, Color.White);
                                        }
                                        break;
                                    case 242: //P2000
                                        if (Main.S.GlowP2000)
                                        {
                                            Main.I.PosP2000 = Tools.WorldToScreen(Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecOrigin));
                                            if (Main.I.PosP2000 != pos02)
                                                DrawText("P2000", Main.I.PosP2000.X, Main.I.PosP2000.Y, 8, Color.White);
                                        }
                                        break;
                                    case 243: //M249
                                        if (Main.S.GlowM249)
                                        {
                                            Main.I.PosM249 = Tools.WorldToScreen(Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecOrigin));
                                            if (Main.I.PosM249 != pos02)
                                                DrawText("M249", Main.I.PosM249.X, Main.I.PosM249.Y, 8, Color.White);
                                        }
                                        break;
                                    case 246: //Mac10
                                        if (Main.S.GlowMac10)
                                        {
                                            Main.I.PosMac10 = Tools.WorldToScreen(Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecOrigin));
                                            if (Main.I.PosMac10 != pos02)
                                                DrawText("Mac10", Main.I.PosMac10.X, Main.I.PosMac10.Y, 8, Color.White);
                                        }
                                        break;
                                    case 247: //Mag-7
                                        if (Main.S.GlowMag7)
                                        {
                                            Main.I.PosMag7 = Tools.WorldToScreen(Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecOrigin));
                                            if (Main.I.PosMag7 != pos02)
                                                DrawText("Mag-7", Main.I.PosMag7.X, Main.I.PosMag7.Y, 8, Color.White);
                                        }
                                        break;
                                    case 249: //MP5
                                        if (Main.S.GlowMP5)
                                        {
                                            Main.I.PosMP5 = Tools.WorldToScreen(Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecOrigin));
                                            if (Main.I.PosMP5 != pos02)
                                                DrawText("MP5", Main.I.PosMP5.X, Main.I.PosMP5.Y, 8, Color.White);
                                        }
                                        break;
                                    case 250: //MP7
                                        if (Main.S.GlowMP7)
                                        {
                                            Main.I.PosMP7 = Tools.WorldToScreen(Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecOrigin));
                                            if (Main.I.PosMP7 != pos02)
                                                DrawText("MP7", Main.I.PosMP7.X, Main.I.PosMP7.Y, 8, Color.White);
                                        }
                                        break;
                                    case 248: //MP9
                                        if (Main.S.GlowMP9)
                                        {
                                            Main.I.PosMP9 = Tools.WorldToScreen(Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecOrigin));
                                            if (Main.I.PosMP9 != pos02)
                                                DrawText("MP9", Main.I.PosMP9.X, Main.I.PosMP9.Y, 8, Color.White);
                                        }
                                        break;
                                    case 251: //Negev
                                        if (Main.S.GlowNegev)
                                        {
                                            Main.I.PosNegev = Tools.WorldToScreen(Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecOrigin));
                                            if (Main.I.PosNegev != pos02)
                                                DrawText("Negev", Main.I.PosNegev.X, Main.I.PosNegev.Y, 8, Color.White);
                                        }
                                        break;
                                    case 252: //Nova
                                        if (Main.S.GlowNova)
                                        {
                                            Main.I.PosNova = Tools.WorldToScreen(Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecOrigin));
                                            if (Main.I.PosNova != pos02)
                                                DrawText("Nova", Main.I.PosNova.X, Main.I.PosNova.Y, 8, Color.White);
                                        }
                                        break;
                                    case 254: //CZ75
                                        if (Main.S.GlowCZ75)
                                        {
                                            Main.I.PosCZ75 = Tools.WorldToScreen(Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecOrigin));
                                            if (Main.I.PosCZ75 != pos02)
                                                DrawText("CZ75", Main.I.PosCZ75.X, Main.I.PosCZ75.Y, 8, Color.White);
                                        }
                                        break;
                                    case 255: //P90
                                        if (Main.S.GlowP90)
                                        {
                                            Main.I.PosP90 = Tools.WorldToScreen(Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecOrigin));
                                            if (Main.I.PosP90 != pos02)
                                                DrawText("P90", Main.I.PosP90.X, Main.I.PosP90.Y, 8, Color.White);
                                        }
                                        break;
                                    case 256: //Sawed-Off
                                        if (Main.S.GlowSawedOff)
                                        {
                                            Main.I.PosSawedOff = Tools.WorldToScreen(Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecOrigin));
                                            if (Main.I.PosSawedOff != pos02)
                                                DrawText("Sawed-Off", Main.I.PosSawedOff.X, Main.I.PosSawedOff.Y, 8, Color.White);
                                        }
                                        break;
                                    case 257: //Scar20
                                        if (Main.S.GlowSCAR20)
                                        {
                                            Main.I.PosScar20 = Tools.WorldToScreen(Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecOrigin));
                                            if (Main.I.PosScar20 != pos02)
                                                DrawText("Scar20", Main.I.PosScar20.X, Main.I.PosScar20.Y, 8, Color.White);
                                        }
                                        break;
                                    case 258: //Scout
                                        if (Main.S.GlowSSG08)
                                        {
                                            Main.I.PosScout = Tools.WorldToScreen(Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecOrigin));
                                            if (Main.I.PosScout != pos02)
                                                DrawText("Scout", Main.I.PosScout.X, Main.I.PosScout.Y, 8, Color.White);
                                        }
                                        break;
                                    case 262: //SSG08
                                        if (Main.S.GlowSSG08)
                                        {
                                            Main.I.PosSSG08 = Tools.WorldToScreen(Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecOrigin));
                                            if (Main.I.PosSSG08 != pos02)
                                                DrawText("SSG08", Main.I.PosSSG08.X, Main.I.PosSSG08.Y, 8, Color.White);
                                        }
                                        break;
                                    case 263: //Taser
                                        if (Main.S.GlowTaser)
                                        {
                                            Main.I.PosTaser = Tools.WorldToScreen(Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecOrigin));
                                            if (Main.I.PosTaser != pos02)
                                                DrawText("Taser", Main.I.PosTaser.X, Main.I.PosTaser.Y, 8, Color.White);
                                        }
                                        break;
                                    case 264: //Tec-9
                                        if (Main.S.GlowTec9)
                                        {
                                            Main.I.PosTec9 = Tools.WorldToScreen(Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecOrigin));
                                            if (Main.I.PosTec9 != pos02)
                                                DrawText("Tec-9", Main.I.PosTec9.X, Main.I.PosTec9.Y, 8, Color.White);
                                        }
                                        break;
                                    case 266: //UMP45
                                        if (Main.S.GlowUMP45)
                                        {
                                            Main.I.PosUMP45 = Tools.WorldToScreen(Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecOrigin));
                                            if (Main.I.PosUMP45 != pos02)
                                                DrawText("UMP45", Main.I.PosUMP45.X, Main.I.PosUMP45.Y, 8, Color.White);
                                        }
                                        break;
                                    case 267: //USP-S
                                        if (Main.S.GlowP2000)
                                        {
                                            Main.I.PosUSP = Tools.WorldToScreen(Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecOrigin));
                                            if (Main.I.PosUSP != pos02)
                                                DrawText("Deagle", Main.I.PosUSP.X, Main.I.PosUSP.Y, 8, Color.White);
                                        }
                                        break;
                                    case 268: //XM1014
                                        if (Main.S.GlowXM1014)
                                        {
                                            Main.I.PosXM1014 = Tools.WorldToScreen(Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecOrigin));
                                            if (Main.I.PosXM1014 != pos02)
                                                DrawText("XM1014", Main.I.PosXM1014.X, Main.I.PosXM1014.Y, 8, Color.White);
                                        }
                                        break;
                                    //////////////////////// Grenades /////////////////////////////////////////////
                                    case 75: //Flash
                                        if (Main.S.GlowFlash)
                                        {
                                        }
                                        break;
                                    case 152: //Smoke
                                        if (Main.S.GlowSmoke)
                                        {
                                        }
                                        break;
                                    case 110: //Molo
                                        if (Main.S.GlowMolo)
                                        {
                                        }
                                        break;
                                    case 94: //HeGrenade
                                        if (Main.S.GlowHEGrenade)
                                        {
                                        }
                                        break;
                                    case 45: //Decoy
                                        if (Main.S.GlowDecoy)
                                        {
                                        }
                                        break;
                                    case 204: //Flash
                                        if (Main.S.GlowFlash)
                                        {
                                        }
                                        break;
                                    case 153: //Smoke
                                        if (Main.S.GlowSmoke)
                                        {
                                        }
                                        break;
                                    case 111: //Molo
                                        if (Main.S.GlowMolo)
                                        {
                                        }
                                        break;
                                    case 97: //incendiary
                                        if (Main.S.GlowMolo)
                                        {
                                        }
                                        break;
                                    case 46: //Decoy
                                        if (Main.S.GlowDecoy)
                                        {
                                        }
                                        break;
                                    case 32: //C4
                                        if (Main.S.GlowC4)
                                        {
                                            Main.I.PosC4 = Tools.WorldToScreen(Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecOrigin));
                                            if (Main.I.PosC4 != pos02)
                                                DrawText("C4", Main.I.PosC4.X, Main.I.PosC4.Y, 8, Color.White);
                                        }
                                        break;
                                    case 126: //Planted C4
                                        if (Main.S.GlowC4)
                                        {
                                        }
                                        break;
                                    case 34: //Chicken
                                        if (Main.S.GlowChicken)
                                        {
                                            Main.I.PosChicken = Tools.WorldToScreen(Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecOrigin));
                                            if (Main.I.PosChicken != pos02)
                                                DrawText("Chicken", Main.I.PosChicken.X, Main.I.PosChicken.Y, 8, Color.White);
                                        }
                                        break;
                                }

                            }
                        }
                        #endregion WeaponESP
                    }
                    foreach (Entity Player in G.EntityList)
                    {
                        if (Player.EntityBase != G.Engine.LocalPlayer.EntityBase)
                        {
                            Vector2 Player2DPos = Tools.WorldToScreen(Player.Position);
                            Vector2 Player2DHeadPos = Tools.WorldToScreen(Player.HeadPosition);
                            Vector2 Player2DNeckPos = Tools.WorldToScreen(Player.GetBonePosition(7));
                            if (!Tools.IsNullVector2(Player2DPos) && !Tools.IsNullVector2(Player2DHeadPos) && Player.Valid)
                            {
                                ///////////////////////////////////////////////
                                float Radius = (Player2DHeadPos.Y - Player2DNeckPos.Y) / 2;
                                float FromHeadToNeck = (Player2DNeckPos.Y - Player2DHeadPos.Y);
                                Player2DHeadPos.Y -= FromHeadToNeck * 2.3f;
                                Player2DPos.Y += FromHeadToNeck;
                                float BoxHeight = Player2DPos.Y - Player2DHeadPos.Y;
                                float BoxHeight2 = Player2DHeadPos.Y - Player2DPos.Y;
                                float BoxWidth = (BoxHeight / 2);
                                float BoxWidth2 = (BoxHeight2 / 2);
                                float xx = Player2DPos.X - (BoxWidth / 2);
                                float xp = Player2DPos.X + (BoxWidth / 2);
                                float hy = Player2DHeadPos.Y - 12;
                                float wy = Player2DNeckPos.Y;
                                float dy = Player2DNeckPos.Y - 3;
                                float by = Player2DPos.Y;
                                float Health = Player.Health;
                                Color HealthColor = Tools.HealthGradient(Tools.HealthToPercent((int)Health));
                                float xLeft = Player2DPos.X - (BoxWidth / 2) - 8;
                                float xRight = Player2DPos.X + (BoxWidth / 2) + 2;
                                float yHead = Player2DHeadPos.Y;
                                float yFoot = Player2DPos.Y;
                                float yNeck = Player2DNeckPos.Y;
                                float w = 4;
                                float h = BoxHeight;
                                float HealthHeight = (Health * h) / 100;
                                int Armor = Player.Armor;
                                float ArmorHeight = (Armor * h) / 100;
                                PlayerHealth = Player.Health;
                                string EntityHealth = Player.Health.ToString();
                                string EntityWeapon = Player.WeaponName;
                                float Dis = (Player.Distance / 100);
                                string Distance = string.Format("{0:0.##}", Dis); //Robi stringa do 2 miejsc po przecinku
                                Main.S.WielkoscFont = (Player2DHeadPos.Y - Player2DNeckPos.Y) / 5;
                                float fon = (8 * h) /10;
                                string font = string.Format("{0:0}", fon);
                                int fonth = 6;
                                //wierd ass calculations for box height, dont judge
                                Color drawcolor;
                                if (Player.IsTeammate)
                                    drawcolor = Main.S.ESPColorTeammates;
                                else
                                    drawcolor = Main.S.ESPColorEnemies;
                                ////////////////////////////////////////////////////////////////
                                if(Main.S.DrawAimspotEnabled)
                                {
                                    if (G.Engine.LocalPlayer.IsRifle(TypeOfGun))
                                    {
                                        if (!Player.IsTeammate)
                                        {
                                            Vector2 BoneAimspot = Tools.WorldToScreen(Player.GetBonePosition(Main.S.AimbotBoneIDRifle));
                                            DrawCircle(BoneAimspot.X, BoneAimspot.Y, Radius, Color.Blue);
                                            DrawText("A", BoneAimspot.X, BoneAimspot.Y, 8, Color.Blue);
                                        }
                                    }
                                    if (G.Engine.LocalPlayer.IsPistol(TypeOfGun))
                                    {
                                        if (!Player.IsTeammate)
                                        {
                                            Vector2 BoneAimspot = Tools.WorldToScreen(Player.GetBonePosition(Main.S.AimbotBoneIDPistols));
                                            DrawCircle(BoneAimspot.X, BoneAimspot.Y, Radius, Color.Blue);
                                            DrawText("A", BoneAimspot.X, BoneAimspot.Y, 8, Color.Blue);
                                        }
                                    }
                                    if (G.Engine.LocalPlayer.IsSniper(TypeOfGun))
                                    {
                                        if (!Player.IsTeammate)
                                        {
                                            Vector2 BoneAimspot = Tools.WorldToScreen(Player.GetBonePosition(Main.S.AimbotBoneIDSnipers));
                                            DrawCircle(BoneAimspot.X, BoneAimspot.Y, Radius, Color.Blue);
                                            DrawText("A", BoneAimspot.X, BoneAimspot.Y, 8, Color.Blue);
                                        }
                                    }
                                    if (G.Engine.LocalPlayer.IsShotgun(TypeOfGun))
                                    {
                                        if (!Player.IsTeammate)
                                        {
                                            Vector2 BoneAimspot = Tools.WorldToScreen(Player.GetBonePosition(Main.S.AimbotBoneIDShotGuns));
                                            DrawCircle(BoneAimspot.X, BoneAimspot.Y, Radius, Color.Blue);
                                            DrawText("A", BoneAimspot.X, BoneAimspot.Y, 8, Color.Blue);
                                        }
                                    }
                                    if (G.Engine.LocalPlayer.IsMachineGun(TypeOfGun))
                                    {
                                        if (!Player.IsTeammate)
                                        {
                                            Vector2 BoneAimspot = Tools.WorldToScreen(Player.GetBonePosition(Main.S.AimbotBoneIDMachineGuns));
                                            DrawCircle(BoneAimspot.X, BoneAimspot.Y, Radius, Color.Blue);
                                            DrawText("A", BoneAimspot.X, BoneAimspot.Y, 8, Color.Blue);
                                        }
                                    }
                                    if (G.Engine.LocalPlayer.IsMP(TypeOfGun))
                                    {
                                        if (!Player.IsTeammate)
                                        {
                                            Vector2 BoneAimspot = Tools.WorldToScreen(Player.GetBonePosition(Main.S.AimbotBoneIDSMG));
                                            DrawCircle(BoneAimspot.X, BoneAimspot.Y, Radius, Color.Blue);
                                            DrawText("A", BoneAimspot.X, BoneAimspot.Y, 8, Color.Blue);
                                        }
                                    }
                                }
                                if (Main.S.DrawBoneIDs)
                                    DrawBoneIDs(Player);
                                if (Main.S.BoneEnabled) //kazdy model postaci ma inne bone id
                                {
                                    #region BoneESP
                                    if (Player.IsTeammate && Main.S.BoneTeammates)
                                    {
                                        if (Main.S.BoneESPMap == 0) //Mirage
                                        {
                                            if (Player.Team == 2) //tt
                                            {
                                                DrawBoneESP(Player, 68, 75, 67, 74, 0, 6, 11, 39, 12, 40, 13, 41, 8);
                                            }
                                            if (Player.Team == 3) //ct
                                            {
                                                DrawBoneESP(Player, 74, 83, 73, 82, 0, 6, 11, 40, 12, 41, 13, 42, 8);
                                            }
                                        }
                                        if (Main.S.BoneESPMap == 1) //Cache
                                        {
                                            if (Player.Team == 2)
                                            {
                                                DrawBoneESP(Player, 67, 74, 66, 73, 0, 6, 10, 38, 11, 39, 13, 41, 8);
                                            }
                                            if (Player.Team == 3)
                                            {
                                                DrawBoneESP(Player, 71, 78, 70, 77, 0, 6, 11, 40, 12, 41, 13, 42, 8);
                                            }
                                        }
                                        if (Main.S.BoneESPMap == 2) //Dust2
                                        {
                                            if (Player.Team == 2)
                                            {
                                                DrawBoneESP(Player, 68, 75, 67, 74, 0, 6, 11, 39, 12, 40, 13, 41, 8);
                                            }
                                            if (Player.Team == 3)
                                            {
                                                DrawBoneESP(Player, 72, 79, 71, 78, 0, 6, 11, 41, 12, 42, 13, 43, 8);
                                            }
                                        }
                                        if (Main.S.BoneESPMap == 3) //Inferno
                                        {
                                            if (Player.Team == 2)
                                            {
                                                DrawBoneESP(Player, 67, 74, 66, 73, 0, 6, 10, 38, 11, 39, 13, 41, 8);
                                            }
                                            if (Player.Team == 3)
                                            {
                                                DrawBoneESP(Player, 74, 83, 73, 82, 0, 6, 11, 40, 12, 41, 13, 42, 8);
                                            }
                                        }
                                        if (Main.S.BoneESPMap == 4) //CobbleStone
                                        {
                                            if (Player.Team == 2)
                                            {
                                                DrawBoneESP(Player, 67, 74, 66, 73, 0, 6, 10, 38, 11, 39, 13, 41, 8);
                                            }
                                            if (Player.Team == 3)
                                            {
                                                DrawBoneESP(Player, 71, 78, 70, 77, 0, 6, 11, 40, 12, 41, 13, 42, 8);
                                            }
                                        }
                                        if (Main.S.BoneESPMap == 5) //Train
                                        {
                                            if (Player.Team == 2)
                                            {
                                                DrawBoneESP(Player, 67, 74, 66, 73, 0, 6, 10, 38, 11, 39, 13, 41, 8);
                                            }
                                            if (Player.Team == 3)
                                            {
                                                DrawBoneESP(Player, 67, 74, 66, 73, 0, 6, 10, 38, 11, 39, 13, 41, 8);
                                            }
                                        }
                                        if (Main.S.BoneESPMap == 6) //Overpass
                                        {
                                            if (Player.Team == 2)
                                            {
                                                DrawBoneESP(Player, 67, 74, 66, 73, 0, 6, 10, 38, 11, 39, 13, 41, 8);
                                            }
                                            if (Player.Team == 3)
                                            {
                                                DrawBoneESP(Player, 67, 74, 66, 73, 0, 6, 10, 38, 11, 39, 13, 41, 8);
                                            }
                                        }
                                        if (Main.S.BoneESPMap == 7) //Nuke
                                        {
                                            if (Player.Team == 2)
                                            {
                                                DrawBoneESP(Player, 67, 74, 66, 73, 0, 6, 10, 38, 11, 39, 13, 41, 8);
                                            }
                                            if (Player.Team == 3)
                                            {
                                                DrawBoneESP(Player, 73, 82, 72, 81, 0, 6, 11, 39, 12, 40, 13, 42, 8);
                                            }
                                        }
                                        if (Main.S.BoneESPMap == 8) //Office
                                        {
                                            if (Player.Team == 2) //tt
                                            {
                                                DrawBoneESP(Player, 69, 76, 68, 75, 0, 6, 12, 40, 13, 41, 36, 64, 8);
                                            }
                                            if (Player.Team == 3) //ct
                                            {
                                                DrawBoneESP(Player, 73, 82, 72, 81, 0, 6, 11, 39, 12, 40, 13, 41, 8);
                                            }
                                        }
                                    }
                                    if (!Player.IsTeammate)
                                    {
                                        if (Main.S.BoneESPMap == 0) //Mirage
                                        {
                                            if (Player.Team == 2) //tt
                                            {
                                                DrawBoneESP(Player, 68, 75, 67, 74, 0, 6, 11, 39, 12, 40, 13, 41, 8);
                                            }
                                            if (Player.Team == 3) //ct
                                            {
                                                DrawBoneESP(Player, 74, 83, 73, 82, 0, 6, 11, 40, 12, 41, 13, 42, 8);
                                            }
                                        }
                                        if (Main.S.BoneESPMap == 1) //Cache
                                        {
                                            if (Player.Team == 2)
                                            {
                                                DrawBoneESP(Player, 67, 74, 66, 73, 0, 6, 10, 38, 11, 39, 13, 41, 8);
                                            }
                                            if (Player.Team == 3)
                                            {
                                                DrawBoneESP(Player, 71, 78, 70, 77, 0, 6, 11, 40, 12, 41, 13, 42, 8);
                                            }
                                        }
                                        if (Main.S.BoneESPMap == 2) //Dust2
                                        {
                                            if (Player.Team == 2)
                                            {
                                                DrawBoneESP(Player, 68, 75, 67, 74, 0, 6, 11, 39, 12, 40, 13, 41, 8);
                                            }
                                            if (Player.Team == 3)
                                            {
                                                DrawBoneESP(Player, 72, 79, 71, 78, 0, 6, 11, 41, 12, 42, 13, 43, 8);
                                            }
                                        }
                                        if (Main.S.BoneESPMap == 3) //Inferno
                                        {
                                            if (Player.Team == 2)
                                            {
                                                DrawBoneESP(Player, 67, 74, 66, 73, 0, 6, 10, 38, 11, 39, 13, 41, 8);
                                            }
                                            if (Player.Team == 3)
                                            {
                                                DrawBoneESP(Player, 74, 83, 73, 82, 0, 6, 11, 40, 12, 41, 13, 42, 8);
                                            }
                                        }
                                        if (Main.S.BoneESPMap == 4) //CobbleStone
                                        {
                                            if (Player.Team == 2)
                                            {
                                                DrawBoneESP(Player, 67, 74, 66, 73, 0, 6, 10, 38, 11, 39, 13, 41, 8);
                                            }
                                            if (Player.Team == 3)
                                            {
                                                DrawBoneESP(Player, 71, 78, 70, 77, 0, 6, 11, 40, 12, 41, 13, 42, 8);
                                            }
                                        }
                                        if (Main.S.BoneESPMap == 5) //Train
                                        {
                                            if (Player.Team == 2)
                                            {
                                                DrawBoneESP(Player, 67, 74, 66, 73, 0, 6, 10, 38, 11, 39, 13, 41, 8);
                                            }
                                            if (Player.Team == 3)
                                            {
                                                DrawBoneESP(Player, 67, 74, 66, 73, 0, 6, 10, 38, 11, 39, 13, 41, 8);
                                            }
                                        }
                                        if (Main.S.BoneESPMap == 6) //Overpass
                                        {
                                            if (Player.Team == 2)
                                            {
                                                DrawBoneESP(Player, 67, 74, 66, 73, 0, 6, 10, 38, 11, 39, 13, 41, 8);
                                            }
                                            if (Player.Team == 3)
                                            {
                                                DrawBoneESP(Player, 67, 74, 66, 73, 0, 6, 10, 38, 11, 39, 13, 41, 8);
                                            }
                                        }
                                        if (Main.S.BoneESPMap == 7) //Nuke
                                        {
                                            if (Player.Team == 2)
                                            {
                                                DrawBoneESP(Player, 67, 74, 66, 73, 0, 6, 10, 38, 11, 39, 13, 41, 8);
                                            }
                                            if (Player.Team == 3)
                                            {
                                                DrawBoneESP(Player, 73, 82, 72, 81, 0, 6, 11, 39, 12, 40, 13, 42, 8);
                                            }
                                        }
                                        if (Main.S.BoneESPMap == 8) //Office
                                        {
                                            if (Player.Team == 2) //tt
                                            {
                                                DrawBoneESP(Player, 69, 76, 68, 75, 0, 6, 12, 40, 13, 41, 36, 64, 8);
                                            }
                                            if (Player.Team == 3) //ct
                                            {
                                                DrawBoneESP(Player, 73, 82, 72, 81, 0, 6, 11, 39, 12, 40, 13, 41, 8);
                                            }
                                        }
                                    }
                                    #endregion
                                }
                                ////ESP BAR health
                                if (Main.S.DrawHealthBar)
                                {
                                    DrawBox(xLeft, yFoot, w, -h, Color.Black, 1);
                                    DrawFilledBox(xLeft + 1, yFoot + 1, 3, -HealthHeight + 1, HealthColor);
                                }
                                if (Main.S.DrawArmorBar)
                                {
                                    DrawBox(xRight, yFoot, w, -h, Color.Black, 1);
                                    DrawFilledBox(xRight + 1, yFoot + 1, 3, -ArmorHeight + 1, Color.Blue);
                                }
                                /////ESP Boxy
                                if (Main.S.ESPBoxEnabled)
                                {
                                    if (Player.IsTeammate && Main.S.BoxTeammates)
                                    {
                                        if (Main.S.TypeOfESPBOX == 0)
                                        {
                                            DrawBox(Player2DPos.X - (BoxWidth / 2), Player2DHeadPos.Y, BoxWidth, BoxHeight, drawcolor);
                                        }
                                        if (Main.S.TypeOfESPBOX == 1)
                                        {
                                            DrawOutlineBox(Player2DPos.X - (BoxWidth / 2), Player2DHeadPos.Y, BoxWidth, BoxHeight, drawcolor);
                                        }
                                        if (Main.S.TypeOfESPBOX == 2)
                                        {
                                            DrawBoxEdge(Player2DPos.X - (BoxWidth / 2), Player2DHeadPos.Y, BoxWidth, BoxHeight, drawcolor);
                                        }
                                        if (Main.S.TypeOfESPBOX == 3)
                                        {
                                            DrawFilledBox(Player2DPos.X - (BoxWidth / 2), Player2DHeadPos.Y, BoxWidth, BoxHeight, drawcolor);
                                        }
                                        if (Main.S.TypeOfESPBOX == 4)
                                        {
                                            DrawRoundedBox(Player2DPos.X - (BoxWidth / 2), Player2DHeadPos.Y, BoxWidth, BoxHeight, 30, drawcolor);
                                        }
                                    }
                                    if (!Player.IsTeammate)
                                    {
                                        if (Main.S.TypeOfESPBOX == 0)
                                        {
                                            DrawBox(Player2DPos.X - (BoxWidth / 2), Player2DHeadPos.Y, BoxWidth, BoxHeight, drawcolor);
                                        }
                                        if (Main.S.TypeOfESPBOX == 1)
                                        {
                                            DrawOutlineBox(Player2DPos.X - (BoxWidth / 2), Player2DHeadPos.Y, BoxWidth, BoxHeight, drawcolor);
                                        }
                                        if (Main.S.TypeOfESPBOX == 2)
                                        {
                                            DrawBoxEdge(Player2DPos.X - (BoxWidth / 2), Player2DHeadPos.Y, BoxWidth, BoxHeight, drawcolor);
                                        }
                                        if (Main.S.TypeOfESPBOX == 3)
                                        {
                                            DrawFilledBox(Player2DPos.X - (BoxWidth / 2), Player2DHeadPos.Y, BoxWidth, BoxHeight, drawcolor);
                                        }
                                        if (Main.S.TypeOfESPBOX == 4)
                                        {
                                            DrawRoundedBox(Player2DPos.X - (BoxWidth / 2), Player2DHeadPos.Y, BoxWidth, BoxHeight, 30, drawcolor);
                                        }
                                    }
                                }
                                ////SnapLine
                                if (Main.S.DrawSnaplines)
                                {
                                    if (!Main.S.SnaplinesHealthBased)
                                        HealthColor = Main.S.SnapLinesColorEnemies;
                                    #region Snaplines
                                    switch (Main.S.SnapLinesPos)
                                    {
                                        case "Top":
                                            if (Player.IsTeammate && Main.S.SnapLinesTeammates)
                                            {
                                                DrawLine(Main.MidScreen.X, 0, Player2DPos.X, Player2DPos.Y, Main.S.SnapLinesColorTeammates, Main.S.SnaplinesValue);
                                            }
                                            if (!Player.IsTeammate)
                                                DrawLine(Main.MidScreen.X, 0, Player2DPos.X, Player2DPos.Y, HealthColor, Main.S.SnaplinesValue);
                                            break;
                                        case "Bottom":
                                            if (Player.IsTeammate && Main.S.SnapLinesTeammates)
                                            {
                                                DrawLine(Main.MidScreen.X, Main.MidScreen.Y + Main.MidScreen.Y, Player2DPos.X, Player2DPos.Y, Main.S.SnapLinesColorTeammates, Main.S.SnaplinesValue);
                                            }
                                            if (!Player.IsTeammate)
                                                DrawLine(Main.MidScreen.X, Main.MidScreen.Y + Main.MidScreen.Y, Player2DPos.X, Player2DPos.Y, HealthColor, Main.S.SnaplinesValue);
                                            break;
                                        case "Right":
                                            if (Player.IsTeammate && Main.S.SnapLinesTeammates)
                                            {
                                                DrawLine(Main.MidScreen.X + Main.MidScreen.X, Main.MidScreen.Y, Player2DPos.X, Player2DPos.Y, Main.S.SnapLinesColorTeammates, Main.S.SnaplinesValue);
                                            }
                                            if (!Player.IsTeammate)
                                                DrawLine(Main.MidScreen.X + Main.MidScreen.X, Main.MidScreen.Y, Player2DPos.X, Player2DPos.Y, HealthColor, Main.S.SnaplinesValue);
                                            break;
                                        case "Left":
                                            if (Player.IsTeammate && Main.S.SnapLinesTeammates)
                                            {
                                                DrawLine(0, Main.MidScreen.Y, Player2DPos.X, Player2DPos.Y, Main.S.SnapLinesColorTeammates, Main.S.SnaplinesValue);
                                            }
                                            if (!Player.IsTeammate)
                                                DrawLine(0, Main.MidScreen.Y, Player2DPos.X, Player2DPos.Y, HealthColor, Main.S.SnaplinesValue);
                                            break;
                                        case "Mid":
                                            if (Player.IsTeammate && Main.S.SnapLinesTeammates)
                                            {
                                                DrawLine(Main.MidScreen.X, Main.MidScreen.Y, Player2DPos.X, Player2DPos.Y, Main.S.SnapLinesColorTeammates, Main.S.SnaplinesValue);
                                            }
                                            if (!Player.IsTeammate)
                                                DrawLine(Main.MidScreen.X, Main.MidScreen.Y, Player2DPos.X, Player2DPos.Y, HealthColor, Main.S.SnaplinesValue);
                                            break;
                                        default:
                                            break;
                                    }
                                    #endregion
                                }
                                ////////// Stringi z danymi
                                if (Main.S.DrawHealthString && Tools.InScreenPos(xx, hy))
                                {
                                    DrawText("Health: " + Player.Health.ToString(), xx, hy, fonth, drawcolor);
                                }
                                if (Main.S.DrawWeaponString && Tools.InScreenPos(xp, wy))
                                {
                                    DrawText(Player.WeaponName, xp, wy, fonth, drawcolor);
                                }
                                if (Main.S.DrawDistanceString && Tools.InScreenPos(xx, by))
                                {
                                    DrawText(Distance + "m", xx, by, fonth, drawcolor);
                                }
                                if (Main.S.DrawScopedEnabled && Tools.InScreenPos(xp, by) && Player.Scoped)
                                {
                                    DrawText("Scoped", xp, by, fonth, drawcolor);
                                }
                            }
                        }
                    }
                }
                //end drawings
                gfx.EndScene();
            }
            #endregion
            #region drawing functions
            void DrawBoneIDs(Entity Player)
            {
                for (int i = 0; i < 100; i++)
                {
                    Vector2 Bonei = Tools.WorldToScreen(Player.GetBonePosition(i));
                    string ii = i.ToString();
                    if (Tools.InScreenPos(Bonei.X, Bonei.Y))
                        DrawText(ii, Bonei.X, Bonei.Y, 9, Color.White);
                }
            }
            void DrawBoneESP(Entity Player, int LFoot, int RFoot, int LKnee, int RKnee, int Pelviss, int Chestt, int LArm, int RArm, int LElbow, int RElbow, int LHand, int RHand, int Headd)
            {
                Vector2 LeftFoot = Tools.WorldToScreen(Player.GetBonePosition(LFoot));
                Vector2 RightFoot = Tools.WorldToScreen(Player.GetBonePosition(RFoot));
                Vector2 LeftKnee = Tools.WorldToScreen(Player.GetBonePosition(LKnee));
                Vector2 RightKnee = Tools.WorldToScreen(Player.GetBonePosition(RKnee));
                Vector2 Pelvis = Tools.WorldToScreen(Player.GetBonePosition(Pelviss));
                Vector2 Chest = Tools.WorldToScreen(Player.GetBonePosition(Chestt));
                Vector2 LeftArm = Tools.WorldToScreen(Player.GetBonePosition(LArm));
                Vector2 RightArm = Tools.WorldToScreen(Player.GetBonePosition(RArm));
                Vector2 LeftElbow = Tools.WorldToScreen(Player.GetBonePosition(LElbow));
                Vector2 RightElbow = Tools.WorldToScreen(Player.GetBonePosition(RElbow));
                Vector2 LeftHand = Tools.WorldToScreen(Player.GetBonePosition(LHand));
                Vector2 RightHand = Tools.WorldToScreen(Player.GetBonePosition(RHand));
                Vector2 Head = Tools.WorldToScreen(Player.GetBonePosition(Headd));
                float Headradius = (Head.Y - Chest.Y) / 2;
                if(Tools.InScreenPos(LeftFoot.X,LeftFoot.Y) && Tools.InScreenPos(LeftKnee.X,LeftKnee.Y))
                    DrawLine(LeftFoot.X, LeftFoot.Y, LeftKnee.X, LeftKnee.Y, Color.White, 2);
                if (Tools.InScreenPos(RightFoot.X, RightFoot.Y) && Tools.InScreenPos(RightKnee.X, RightKnee.Y))
                    DrawLine(RightFoot.X, RightFoot.Y, RightKnee.X, RightKnee.Y, Color.White, 2);
                if (Tools.InScreenPos(LeftKnee.X, LeftKnee.Y) && Tools.InScreenPos(Pelvis.X, Pelvis.Y))
                    DrawLine(LeftKnee.X, LeftKnee.Y, Pelvis.X, Pelvis.Y, Color.White, 2);
                if (Tools.InScreenPos(RightKnee.X, RightKnee.Y) && Tools.InScreenPos(Pelvis.X, Pelvis.Y))
                    DrawLine(RightKnee.X, RightKnee.Y, Pelvis.X, Pelvis.Y, Color.White, 2);
                if (Tools.InScreenPos(Pelvis.X, Pelvis.Y) && Tools.InScreenPos(Chest.X, Chest.Y))
                    DrawLine(Pelvis.X, Pelvis.Y, Chest.X, Chest.Y, Color.White, 2);
                if (Tools.InScreenPos(Chest.X, Chest.Y) && Tools.InScreenPos(LeftArm.X, LeftArm.Y))
                    DrawLine(Chest.X, Chest.Y, LeftArm.X, LeftArm.Y, Color.White, 2);
                if (Tools.InScreenPos(Chest.X, Chest.Y) && Tools.InScreenPos(RightArm.X, RightArm.Y))
                    DrawLine(Chest.X, Chest.Y, RightArm.X, RightArm.Y, Color.White, 2);
                if (Tools.InScreenPos(LeftArm.X, LeftArm.Y) && Tools.InScreenPos(LeftElbow.X, LeftElbow.Y))
                    DrawLine(LeftArm.X, LeftArm.Y, LeftElbow.X, LeftElbow.Y, Color.White, 2);
                if (Tools.InScreenPos(RightArm.X, RightArm.Y) && Tools.InScreenPos(RightElbow.X, RightElbow.Y))
                    DrawLine(RightArm.X, RightArm.Y, RightElbow.X, RightElbow.Y, Color.White, 2);
                if (Tools.InScreenPos(LeftElbow.X, LeftElbow.Y) && Tools.InScreenPos(LeftHand.X, LeftHand.Y))
                    DrawLine(LeftElbow.X, LeftElbow.Y, LeftHand.X, LeftHand.Y, Color.White, 2);
                if (Tools.InScreenPos(RightElbow.X, RightElbow.Y) && Tools.InScreenPos(RightHand.X, RightHand.Y))
                    DrawLine(RightElbow.X, RightElbow.Y, RightHand.X, RightHand.Y, Color.White, 2);
                if (Tools.InScreenPos(Chest.X, Chest.Y) && Tools.InScreenPos(Head.X, Head.Y))
                    DrawLine(Chest.X, Chest.Y, Head.X, Head.Y, Color.White, 2);
                if (Tools.InScreenPos(Head.X, Head.Y))
                    DrawCircle(Head.X, Head.Y, Headradius, Color.White);
            }
            void DrawBoxEdge(float x, float y, float width, float height, Color color, float thiccness = 2.0f)
            {
                gfx.DrawRectangleEdges(GetBrushColor(color), x, y, x + width, y + height, thiccness);
            }

            void DrawText(string text, float x, float y, int size, Color color, bool bold = false, bool italic = false)
            {
                if (Tools.InScreenPos(x, y))
                {
                    gfx.DrawText(_graphics.CreateFont("Arial", 16, bold, italic), GetBrushColor(color), x, y, text);
                }
            }

            void DrawTextWithBackground(string text, float x, float y, int size, Color color, Color backcolor, bool bold = false, bool italic = false)
            {
                if (Tools.InScreenPos(x, y))
                {
                    gfx.DrawTextWithBackground(_graphics.CreateFont("Arial", 16, bold, italic), GetBrushColor(color), GetBrushColor(backcolor), x, y, text);
                }
            }

            void DrawLine(float fromx, float fromy, float tox, float toy, Color color, float thiccness = 2.0f)
            {
                gfx.DrawLine(GetBrushColor(color), fromx, fromy, tox, toy, thiccness);
            }

            void DrawFilledBox(float x, float y, float width, float height, Color color)
            {
                gfx.FillRectangle(GetBrushColor(color), x, y, x + width, y + height);
            }

            void DrawCircle(float x, float y, float radius, Color color, float thiccness = 1)
            {
                gfx.DrawCircle(GetBrushColor(color), x, y, radius, thiccness);
            }

            void DrawCrosshair(CrosshairStyle style, float x, float y, float size, float thiccness, Color color)
            {
                gfx.DrawCrosshair(GetBrushColor(color), x, y, size, thiccness, style);
            }

            void DrawFillOutlineBox(float x, float y, float width, float height, Color color, Color fillcolor, float thiccness = 1.0f)
            {
                gfx.OutlineFillRectangle(GetBrushColor(color), GetBrushColor(fillcolor), x, y, x + width, y + height, thiccness);
            }

            void DrawBox(float x, float y, float width, float height, Color color, float thiccness = 2.0f)
            {
                gfx.DrawRectangle(GetBrushColor(color), x, y, x + width, y + height, thiccness);
            }

            void DrawOutlineBox(float x, float y, float width, float height, Color color, float thiccness = 2.0f)
            {
                gfx.OutlineRectangle(GetBrushColor(Color.FromArgb(0, 0, 0)), GetBrushColor(color), x, y, x + width, y + height, thiccness);
            }

            void DrawRoundedBox(float x, float y, float width, float height, float radius, Color color, float thiccness = 2.0f)
            {
                gfx.DrawRoundedRectangle(GetBrushColor(color), x, y, x + width, y + height, radius, thiccness);
            }
            #endregion
        }
    }
}
