using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZBase.Classes;
using ZBase.Utilities;

namespace ZBase.Cheats
{
    class Misc
    {
        public static int m_hViewModel = 0x32F8;
        public static int m_bClientSideAnimation = 0x289C;
        public static int m_nModelIndex = 0x258;
        public static int m_iViewModelIndex = 0x3220;
        public static int m_iWorldModelIndex = 0x3224;
        public static int m_iWorldDroppedModelIndex = 0x3228;
        public static int m_hWeaponWorldModel = 0x3234;
        public static Vector2 oldPunch;
        public static void Run()
        {
            int[] stats = new int[2];
            while (true)
            {
                if (G.Engine.GameState == GameState.FULL_CONNECTED)
                {
                    int BaseAddress = Memory.ReadMemory<int>((int)Memory.Client + Main.O.signatures.dwLocalPlayer);
                    if (Main.S.AntiAimEnabled)
                    {
                        Memory.WriteMemory<float>(G.Engine.LocalPlayer.EntityBase + Main.O.netvars.m_viewPunchAngle + 0x4, 180);
                        Vector2 cos = G.Engine.ViewAngles;
                        cos.Y -= 180;
                        if (cos.Y < 180) cos.Y += 360;
                        G.Engine.ViewAngles = cos;
                        Thread.Sleep(10);
                        Main.S.AntiAimEnabled = false;
                        //bool isrealangle = true;
                        //int antiaimvalue = 90;
                        //Vector2 clientangle = G.Engine.ViewAngles;
                        //if (G.Engine.LocalPlayer.ShotsFired == 0)
                        //{
                        //    if (isrealangle)
                        //    {
                        //       
                        //        clientangle.Y += antiaimvalue;
                        //        if (clientangle.Y < -180)
                        //            clientangle.Y += 360;
                        //        G.Engine.ViewAngles = clientangle;
                        //        Memory.WriteMemory<float>(G.Engine.LocalPlayer.EntityBase + Main.O.netvars.m_viewPunchAngle + 0x4, antiaimvalue);
                        //        isrealangle = false;
                        //    }
                        //}
                        //if (G.Engine.LocalPlayer.ShotsFired > 0)
                        //{
                        //    if (!isrealangle)
                        //    {
                        //        clientangle.Y -= antiaimvalue;
                        //        if (clientangle.Y > 180)
                        //            clientangle.Y -= 360;
                        //        G.Engine.ViewAngles = clientangle;
                        //        Memory.WriteMemory<float>(G.Engine.LocalPlayer.EntityBase + Main.O.netvars.m_viewPunchAngle + 0x4, 0);
                        //        isrealangle = true;
                        //    }
                        //}
                    }
                    if (Main.S.HitmarkerEnabled)
                    {
                        int hits = 0;
                        var crosshairEntity = Tools.GetEntityBaseFromCrosshair(G.Engine.LocalPlayer.CrosshairID);
                        int health = Memory.ReadMemory<int>(crosshairEntity + Main.O.netvars.m_iHealth);
                        if (health > 0 && health < 1337)
                        {
                            stats[0] = crosshairEntity;
                            stats[1] = health;
                            while(Tools.GetEntityBaseFromCrosshair(G.Engine.LocalPlayer.CrosshairID) == stats[0] || Memory.ReadMemory<int>(crosshairEntity + Main.O.netvars.m_iHealth) > 0)
                            {
                                if (Memory.ReadMemory<int>(Tools.GetEntityBaseFromCrosshair(G.Engine.LocalPlayer.CrosshairID) + Main.O.netvars.m_iHealth) > 0 && Tools.GetEntityBaseFromCrosshair(G.Engine.LocalPlayer.CrosshairID) != stats[0])
                                    break;

                                health = Memory.ReadMemory<int>(crosshairEntity + Main.O.netvars.m_iHealth);
                                if (health < stats[1])
                                {
                                    Main.I.ShowCrosshair = true;
                                    hitSound(hits);
                                    hits += 1;
                                    stats[1] = health;
                                }

                            }
                            stats[0] = -1;
                            stats[1] = -1;
                            Main.I.ShowCrosshair = false;
                        }
                    }
                    if (Main.S.TriggerbotEnabled)
                    {
                        if (Main.I.TriggerBotOn)
                        {
                            Thread.Sleep(Main.S.TriggerbotValue);
                            G.Engine.Shoot();
                        }
                    }
                    if (Main.S.FAKELAGEnabled)//Broken
                    {
                        Memory.WriteMemory<bool>((int)Memory.Engine + Main.O.signatures.dwbSendPackets, false);
                        Thread.Sleep(Main.S.FAKELAGValue);
                        Memory.WriteMemory<bool>((int)Memory.Engine + Main.O.signatures.dwbSendPackets, true);
                    }
                    if (Main.S.THIRDPERSONEnabled)
                    {
                        Memory.WriteMemory<bool>(G.Engine.LocalPlayer.EntityBase + Main.O.netvars.m_iObserverMode, true);
                    }
                    if (!Main.S.THIRDPERSONEnabled)
                    {
                        Memory.WriteMemory<bool>(G.Engine.LocalPlayer.EntityBase + Main.O.netvars.m_iObserverMode, false);
                    }
                    if (Main.S.ForceFullUpdate || Tools.HoldingKey(Keys.VK_END))
                    {
                        bool knife = Main.S.KnifeChangerEnabled;
                        if (knife)
                            Main.S.KnifeChangerEnabled = false;
                        //Thread.Sleep(100);
                        Memory.WriteMemory<IntPtr>(Memory.ReadMemory<int>((int)Memory.Engine + Main.O.signatures.dwClientState) + 0x174, -1);
                        //Thread.Sleep(100);
                        Main.S.KnifeChangerEnabled = knife;
                    }
                    int modelIndex = 0;
                    if (Main.S.KnifeChangerEnabled)
                    {
                        int activeWeapon = Memory.ReadMemory<int>(BaseAddress + Main.O.netvars.m_hActiveWeapon) & 0xfff;
                        int weaponEntity2 = Memory.ReadMemory<int>((int)Memory.Client + Main.O.signatures.dwEntityList + (activeWeapon - 1) * 0x10);
                        if (weaponEntity2 == 0) { continue; }

                        short weaponID2 = Memory.ReadMemory<short>(weaponEntity2 + Main.O.netvars.m_iItemDefinitionIndex);

                        int weaponViewModelID = Memory.ReadMemory<int>(weaponEntity2 + m_iViewModelIndex);

                        if (weaponID2 == 41 && weaponViewModelID > 0)
                        {
                            modelIndex = weaponViewModelID + Main.I.SelectedKnife + 24;
                        }
                        if (weaponID2 == 42 && weaponViewModelID > 0)
                        {
                            modelIndex = weaponViewModelID + Main.I.SelectedKnife + 24;
                        }
                        else if (weaponID2 == 59 && weaponViewModelID > 0)
                        {
                            modelIndex = weaponViewModelID + Main.I.SelectedKnife;
                        }
                        else if (weaponID2 != modelIndex || modelIndex == 0) { continue; }

                        int knifeViewmodel = Memory.ReadMemory<int>(BaseAddress + m_hViewModel) & 0xfff; //Mysle ze m_hViewModel jest zly
                        int knifeEntity = Memory.ReadMemory<int>((int)Memory.Client + Main.O.signatures.dwEntityList + (knifeViewmodel - 1) * 0x10);
                        if (knifeEntity == 0) { continue; }
                        if (weaponID2 == 41 || weaponID2 == 42 || weaponID2 == 59)
                        {
                            Memory.WriteMemory<short>(knifeEntity + m_nModelIndex, modelIndex);
                            Memory.WriteMemory<short>(activeWeapon + m_nModelIndex, modelIndex);
                            Memory.WriteMemory<short>(activeWeapon + Main.O.netvars.m_iItemDefinitionIndex, 500);
                            Memory.WriteMemory<IntPtr>(activeWeapon + m_iViewModelIndex, modelIndex);
                        }
                    }
                    if (Main.S.SkinChangerEnabled)
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            int weaponbase = Memory.ReadMemory<int>(BaseAddress + Main.O.netvars.m_hMyWeapons + i * 0x4);
                            int yes = weaponbase & 0xFFF;
                            int ok = Memory.ReadMemory<int>((int)Memory.Client + Main.O.signatures.dwEntityList + (yes - 1) * 16);
                            int weaponIDD = Memory.ReadMemory<int>(ok + Main.O.netvars.m_iItemDefinitionIndex);

                            //SkinsId https://totalcsgo.com/skin-ids
                            // WeaponID https://tf2b.com/itemlist.php?gid=730
                            const int itemIDHigh = -1;
                            const int entityQuality = 3;
                            const float fallbackWear = 0.0001f;
                            int myWeapons = Memory.ReadMemory<int>(BaseAddress + Main.O.netvars.m_hMyWeapons + i * 0x4) & 0xfff;
                            int weaponEntity = Memory.ReadMemory<int>((int)Memory.Client + Main.O.signatures.dwEntityList + (myWeapons - 1) * 0x10);
                            if (weaponEntity == 0) { continue; }
                            int weaponID = weaponIDD;
                            int fallbackPaint = 0;
                            if (weaponID == 1) { fallbackPaint = Main.S.SkinDeasertEagle; } /* Desert Eagle | Blaze */
                            else if (weaponID == 2) { fallbackPaint = Main.S.SkinDualBerettas; } /* Dual Berettas | Cobra Strike */
                            else if (weaponID == 3) { fallbackPaint = Main.S.SkinFiveSeven; } /* Five-SeveN | Hyper Beast */
                            else if (weaponID == 4) { fallbackPaint = Main.S.SkinGlock18; } /* Glock-18 | Fade */
                            else if (weaponID == 7) { fallbackPaint = Main.S.SkinAK47; } /* AK-47 | Empress */
                            else if (weaponID == 8) { fallbackPaint = Main.S.SkinAUG; } /* AUG | Akihabara Accept */
                            else if (weaponID == 9) { fallbackPaint = Main.S.SkinAWP; } /* AWP | Asiimov */
                            else if (weaponID == 10) { fallbackPaint = Main.S.SkinFamas; } /* FAMAS | Eye of Athena */
                            else if (weaponID == 11) { fallbackPaint = Main.S.SkinG3SG1; } /* G3SG1 | Flux */
                            else if (weaponID == 13) { fallbackPaint = Main.S.SkinGalilAR; } /* Galil AR | Chatterbox */
                            else if (weaponID == 14) { fallbackPaint = Main.S.SkinM249; } /* M249 | System Lock */
                            else if (weaponID == 16) { fallbackPaint = Main.S.SkinM4A4; } /* M4A4 - Howl */
                            else if (weaponID == 17) { fallbackPaint = Main.S.SkinMac10; } /* MAC-10 | Neon Rider */
                            else if (weaponID == 19) { fallbackPaint = Main.S.SkinP90; } /* P90 | Shallow Grave */
                            else if (weaponID == 23) { fallbackPaint = Main.S.SkinUMP45; } /* UMP-45 | Arctic Wolf */
                            else if (weaponID == 24) { fallbackPaint = Main.S.SkinMP5; } /* MP5| Arctic Wolf */
                            else if (weaponID == 25) { fallbackPaint = Main.S.SkinXM1014; } /* XM1014 | Tranquility */
                            else if (weaponID == 26) { fallbackPaint = Main.S.SkinPPBizon; } /* PP-Bizon | Judgement of Anubis */
                            else if (weaponID == 27) { fallbackPaint = Main.S.SkinMag7; } /* MP7 | Bloodsport */
                            else if (weaponID == 28) { fallbackPaint = Main.S.SkinNegev; } /* Negev | Power Loader */
                            else if (weaponID == 29) { fallbackPaint = Main.S.SkinSawedOff; } /* Sawed-Off | Devourer */
                            else if (weaponID == 30) { fallbackPaint = Main.S.SkinTec9; } /* Tec-9 | Fuel Injector */
                            else if (weaponID == 32) { fallbackPaint = Main.S.SkinP2000; } /* P2000 | Imperial Dragon */
                            else if (weaponID == 33) { fallbackPaint = Main.S.SkinMP7; } /* MP7 | Bloodsport */
                            else if (weaponID == 34) { fallbackPaint = Main.S.SkinMP9; } /* MP9 | Rose Iron */
                            else if (weaponID == 35) { fallbackPaint = Main.S.SkinNova; } /* Nova | Hyper Beast */
                            else if (weaponID == 36) { fallbackPaint = Main.S.SkinP250; } /* P250 | See Ya Later */
                            else if (weaponID == 38) { fallbackPaint = Main.S.SkinSCAR20; } /* SCAR-20 | Cyrex */
                            else if (weaponID == 39) { fallbackPaint = Main.S.SkinSG553; } /* SG 553 | Integrale */
                            else if (weaponID == 40) { fallbackPaint = Main.S.SkinSSG08; } /* SSG 08 | Dragonfire */
                            else if (weaponID == 60) { fallbackPaint = Main.S.SkinM4A1S; } /* M4A1-S | Hot Rod */
                            else if (weaponID == 61) { fallbackPaint = Main.S.SkinUSPS; } /* USP-S | Neo-Noir */
                            else if (weaponID == 63) { fallbackPaint = Main.S.SkinCZ75; } /* CZ75-Auto | Neo-Noir */
                            else if (weaponID == 41 || weaponID == 42 || weaponID == 59)
                            {
                                Memory.WriteMemory<int>(myWeapons + m_nModelIndex, modelIndex);
                                Memory.WriteMemory<int>(myWeapons + m_iViewModelIndex, modelIndex);
                                Memory.WriteMemory<int>(myWeapons + Main.O.netvars.m_iItemDefinitionIndex, 500);
                            }
                            else
                            {

                                Memory.WriteMemory<IntPtr>(weaponEntity + Main.O.netvars.m_iEntityQuality, entityQuality);
                            }
                            Memory.WriteMemory<IntPtr>(weaponEntity + Main.O.netvars.m_iItemIDHigh, itemIDHigh);
                            Memory.WriteMemory<IntPtr>(weaponEntity + Main.O.netvars.m_nFallbackPaintKit, fallbackPaint);
                            Memory.WriteMemory<float>(weaponEntity + Main.O.netvars.m_flFallbackWear, fallbackWear);
                        }
                    }
                    if (Main.S.RCSEnabled)
                    {
                        Vector2 punchVector;
                        Vector2 viewAngle;
                        Vector2 finalAngle;
                        int ShotsFired = G.Engine.LocalPlayer.ShotsFired;
                        if (Tools.HoldingKey(Keys.VK_LBUTTON) && Main.S.RCSValue != 0)
                        {
                            if (ShotsFired > Main.S.RCSValue)
                            {
                                punchVector = G.Engine.LocalPlayer.AimPunchAngle;

                                punchVector.X = punchVector.X * 2.0f;
                                punchVector.Y = punchVector.Y * 2.0f;

                                viewAngle = Memory.ReadMemory<Vector2>(Memory.ReadMemory<int>((int)Memory.Engine + Main.O.signatures.dwClientState) + Main.O.signatures.dwClientState_ViewAngles);

                                finalAngle.X = viewAngle.X - (punchVector.X - oldPunch.X);
                                finalAngle.Y = viewAngle.Y - (punchVector.Y - oldPunch.Y);
                                finalAngle = Tools.NormalizeAngles(finalAngle);
                                finalAngle = Tools.ClampAngle(finalAngle);
                                Memory.WriteMemory<float>(Memory.ReadMemory<int>((int)Memory.Engine + Main.O.signatures.dwClientState) + Main.O.signatures.dwClientState_ViewAngles, finalAngle.X);
                                Memory.WriteMemory<float>(Memory.ReadMemory<int>((int)Memory.Engine + Main.O.signatures.dwClientState) + Main.O.signatures.dwClientState_ViewAngles + 0x4, finalAngle.Y);

                                oldPunch = punchVector;
                            }
                            else
                            {
                                oldPunch.X = 0;
                                oldPunch.Y = 0;
                                finalAngle.X = 0;
                                finalAngle.Y = 0;
                            }
                        }
                    }
                }
                Thread.Sleep(1);
            }
        }
        public static void hitSound(int hits)
        {
            //Needed for autorifle weapons.
            if (hits % 3 == 0)
                PlaySong();
            if (hits % 4 == 1)
                PlaySong();
            if (hits % 4 == 2)
                PlaySong();
            if (hits % 4 == 3)
                PlaySong();
        }
        public static void PlaySong()
        {
            SoundPlayer Player = new SoundPlayer("skeethitmarker.wav");
            Player.Play();
        }
    }
}
