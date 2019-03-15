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
        public static byte[] Shellcode = {
                                 0xBA,0x67,0x45,0x23,0x01,
                                 0xB9,0x67,0x45,0x23,0x01,
                                 0xB8,0x67,0x45,0x23,0x01,
                                 0xFF,0xD0,
                                 0xC3,
                                 0x12,0x12,0x12,0x12,0x12,0x12,0x12,0x12,0x12,0x12,0x12,0x12,0x12,0x12,0x12,0x12,
                                 0x12,0x12,0x12,0x12,0x12,0x12,0x12,0x12,0x12,0x12,0x12,0x12,0x12,0x12,0x12,0x12
                                 };
        public static int Size = Shellcode.Length;
        public static IntPtr Address;
        public static Int32 dwChangeClanTag;
        public static void Do(string tag, string name)
        {
            dwChangeClanTag = Main.O.signatures.dwSetClanTag;
            dwChangeClanTag += (int)Memory.Engine;
            if (Address == IntPtr.Zero)
            {
                Alloc();
                if (Address == IntPtr.Zero)
                    return;
                int tag_addr = (int)Address + 18;
                int name_addr = tag_addr + 16;
                Buffer.BlockCopy(BitConverter.GetBytes(name_addr), 0, Shellcode, 1, 4);
                Buffer.BlockCopy(BitConverter.GetBytes(tag_addr), 0, Shellcode, 6, 4);
                Buffer.BlockCopy(BitConverter.GetBytes(dwChangeClanTag), 0, Shellcode, 11, 4);
            }
            var tag_bytes = Encoding.UTF8.GetBytes(tag + "\0");
            var name_bytes = Encoding.UTF8.GetBytes(name + "\0");
            Buffer.BlockCopy(tag_bytes, 0, Shellcode, 18, tag_bytes.Length);
            Buffer.BlockCopy(name_bytes, 0, Shellcode, 34, name_bytes.Length);
            WinAPI.WriteProcessMemory(Memory.ProcessHandle, Address, Shellcode, Shellcode.Length, 0);
            IntPtr Thread = WinAPI.CreateRemoteThread(Memory.ProcessHandle, (IntPtr)null, IntPtr.Zero, Address, (IntPtr)null, 0, (IntPtr)null);
            WinAPI.WaitForSingleObject(Thread, 0xFFFFFFFF);
            WinAPI.CloseHandle(Thread);
        }
        public static void Alloc()
        {
            Address = G.SmartAlloc.SmartAlloc(Size);
        }
        public static int m_hViewModel = 0x32F8;
        public static int m_bClientSideAnimation = 0x289C;
        public static int m_nModelIndex = 0x258;
        public static int m_iViewModelIndex = 0x3220;
        public static int m_iWorldModelIndex = 0x3224;
        public static int m_iWorldDroppedModelIndex = 0x3228;
        public static int m_hWeaponWorldModel = 0x3234;
        public static int Knife = 0;
        public static int KnifeModelIndex = 0;
        public static int KnifeViewModelIndex = 0;
        public static Vector2 oldPunch;
        public static string OldClanTag = Main.S.ClanTagString;
        public static void Run()
        {
            if (Main.S.ClanTagChangerEnabled)
                Do(Main.S.ClanTagString, "Elo");

            int[] stats = new int[2];
            while (true)
            {
                if (G.Engine.GameState == GameState.FULL_CONNECTED)
                {
                    if (Main.S.ClanTagChangerEnabled)
                        if (OldClanTag != Main.S.ClanTagString)
                        {
                            Do(Main.S.ClanTagString, "Elo");
                            OldClanTag = Main.S.ClanTagString;
                        }

                    if (Main.S.NightMode || Main.S.ColoredHands)
                    {
                        for (int i = 0; i < 600; i++)
                        {
                            int Ent = Memory.ReadMemory<int>((int)Memory.Client + Main.O.signatures.dwEntityList + i * 0x10);
                            int EntityClassID = Memory.ReadMemory<int>(Memory.ReadMemory<int>(Memory.ReadMemory<int>(Memory.ReadMemory<int>(Ent + 0x8) + 0x8) + 0x1) + 0x14);
                            if (EntityClassID == 67 && Main.S.NightMode) // CEnvTonemapController
                            {
                                Memory.WriteMemory<int>(Ent + 0x9D8, 1);
                                Memory.WriteMemory<int>(Ent + 0x9D9, 1);
                                Memory.WriteMemory<byte>(Ent + 0x9DC, 0.085f);
                                Memory.WriteMemory<byte>(Ent + 0x9E0, 0.085f);
                            }
                            if (EntityClassID == 136 && Main.S.ColoredHands) //Predicted viewmodel
                            {
                                Memory.WriteMemory<int>(Ent + Main.O.netvars.m_clrRender, Main.S.ColorHands.R);             //r
                                Memory.WriteMemory<int>(Ent + Main.O.netvars.m_clrRender + 1, Main.S.ColorHands.G);         //g
                                Memory.WriteMemory<int>(Ent + Main.O.netvars.m_clrRender + 2, Main.S.ColorHands.B);    //b
                                Memory.WriteMemory<int>(Ent + Main.O.netvars.m_clrRender + 3, 255);         //alpha
                            }
                            if (EntityClassID == 67 && !Main.S.NightMode) // CEnvTonemapController
                            {
                                Memory.WriteMemory<int>(Ent + 0x9D8, 1);
                                Memory.WriteMemory<int>(Ent + 0x9D9, 1);
                                Memory.WriteMemory<byte>(Ent + 0x9DC, 1);
                                Memory.WriteMemory<byte>(Ent + 0x9E0, 1);
                            }
                            if (EntityClassID == 136 && !Main.S.ColoredHands) //Predicted viewmodel
                            {
                                Memory.WriteMemory<int>(Ent + Main.O.netvars.m_clrRender, 255);             //r
                                Memory.WriteMemory<int>(Ent + Main.O.netvars.m_clrRender + 1, 255);         //g
                                Memory.WriteMemory<int>(Ent + Main.O.netvars.m_clrRender + 2, 255);    //b
                                Memory.WriteMemory<int>(Ent + Main.O.netvars.m_clrRender + 3, 255);         //alpha
                            }
                        }
                        int BaseAddress = G.Engine.LocalPlayer.EntityBase;
                    }
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
                        crosshairEntity = 0;
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
                   
                        //        int activeWeapon = Memory.ReadMemory<int>(BaseAddress + Main.O.netvars.m_hActiveWeapon) & 0xfff;
                        //int weaponEntity2 = Memory.ReadMemory<int>((int)Memory.Client + Main.O.signatures.dwEntityList + (activeWeapon - 1) * 0x10);
                        //if (weaponEntity2 == 0) { continue; }

                        //short weaponID2 = Memory.ReadMemory<short>(weaponEntity2 + Main.O.netvars.m_iItemDefinitionIndex);

                        //int weaponViewModelID = Memory.ReadMemory<int>(weaponEntity2 + m_iViewModelIndex);

                        //if (weaponID2 == 42 && weaponViewModelID > 0)
                        //{
                        //    modelIndex = weaponViewModelID + Main.I.SelectedKnife + 24;
                        //}
                        //else if (weaponID2 == 59 && weaponViewModelID > 0)
                        //{
                        //    modelIndex = weaponViewModelID + Main.I.SelectedKnife;
                        //}

                        //int knifeViewmodel = Memory.ReadMemory<int>(BaseAddress + m_hViewModel) & 0xfff;
                        //int knifeEntity = Memory.ReadMemory<int>((int)Memory.Client + Main.O.signatures.dwEntityList + (knifeViewmodel - 1) * 0x10);
                        //if (knifeEntity == 0) { continue; }
                        //if (weaponID2 == 41 || weaponID2 == 42 || weaponID2 == 59 || weaponID2 == 500)
                        //{
                        //    Memory.WriteMemory<short>(knifeEntity + m_nModelIndex, modelIndex);
                        //    Memory.WriteMemory<short>(activeWeapon + m_nModelIndex, modelIndex);
                        //    Memory.WriteMemory<short>(activeWeapon + Main.O.netvars.m_iItemDefinitionIndex, 500);
                        //    Memory.WriteMemory<IntPtr>(activeWeapon + m_iViewModelIndex, modelIndex);
                        //}
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
                //Thread.Sleep(1);
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
