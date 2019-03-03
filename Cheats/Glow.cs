using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZBase.Classes;
using ZBase.Utilities;

namespace ZBase.Cheats
{
    class Glow
    {
        public static int ToneMapScale = 0x521DB78;
        public static void glow(int glowObj, int ent, float r, float g, float b, float a, int glowstyle)
        {
            Memory.WriteMemory<float>(glowObj + 0x38 * ent + 0x4, r / 255);
            Memory.WriteMemory<float>(glowObj + 0x38 * ent + 0x8, g / 255);
            Memory.WriteMemory<float>(glowObj + 0x38 * ent + 0xC, b / 255);
            Memory.WriteMemory<float>(glowObj + 0x38 * ent + 0x10, a);
            Memory.WriteMemory<int>(glowObj + 0x38 * ent + 0x2C, glowstyle);
            Memory.WriteMemory<bool>(glowObj + 0x38 * ent + 0x24, true);
            Memory.WriteMemory<bool>(glowObj + 0x38 * ent + 0x25, false);
        }
        public static void Run()
        {
            while (true)
            {
                if (Main.S.NightMode)
                {
                    Memory.WriteMemory<byte>((int)Memory.Client + ToneMapScale, 0.075f);
                }
               if (Main.S.GlowEnabled)
               {
                    int gp = Memory.ReadMemory<int>((int)Memory.Client + Main.O.signatures.dwGlowObjectManager);
                    int ObjectCount = Memory.ReadMemory<int>((int)Memory.Client + Main.O.signatures.dwGlowObjectManager + 0x4);
                    for (int i = 1; i < ObjectCount; i++)
                    {
                        int EntityBase = Memory.ReadMemory<int>(gp + 0x38 * i); //Entity
                        int EntityTeam = Memory.ReadMemory<int>(EntityBase + Main.O.netvars.m_iTeamNum);
                        int entityHealth = Memory.ReadMemory<int>(EntityBase + Main.O.netvars.m_iHealth);
                        int one = Memory.ReadMemory<int>(EntityBase + 0x8);
                        int two = Memory.ReadMemory<int>(one + 0x8);
                        int three = Memory.ReadMemory<int>(two + 0x1);
                        int ClassID = Memory.ReadMemory<int>(three + 0x14);
                        switch (ClassID)
                        {
                            case 1: //AK47
                                glow(gp, i, 255, 0, 0, 255, 0);
                                break;
                            case 44: //Deagle
                                glow(gp, i, 255, 0, 0, 255, 0);
                                break;
                            case 228: //AUG
                                glow(gp, i, 255, 0, 0, 255, 0);
                                break;
                            case 229: //AWP
                                glow(gp, i, 255, 0, 0, 255, 0);
                                break;
                            case 245: //M4
                                glow(gp, i, 255, 0, 0, 255, 0);
                                break;
                            case 231: //Bizon
                                glow(gp, i, 255, 0, 0, 255, 0);
                                break;
                            case 235: //Elite Berettas
                                glow(gp, i, 255, 0, 0, 255, 0);
                                break;
                            case 236: //Famas
                                glow(gp, i, 255, 0, 0, 255, 0);
                                break;
                            case 237: //Five-Seven
                                glow(gp, i, 255, 0, 0, 255, 0);
                                break;
                            case 238: //G3SG1
                                glow(gp, i, 255, 0, 0, 255, 0);
                                break;
                            case 240: //GalilAR
                                glow(gp, i, 255, 0, 0, 255, 0);
                                break;
                            case 241: //Glock
                                glow(gp, i, 255, 0, 0, 255, 0);
                                break;
                            case 242: //P2000
                                glow(gp, i, 255, 0, 0, 255, 0);
                                break;
                            case 243: //M249
                                glow(gp, i, 255, 0, 0, 255, 0);
                                break;
                            case 246: //Mac10
                                glow(gp, i, 255, 0, 0, 255, 0);
                                break;
                            case 247: //Mag-7
                                glow(gp, i, 255, 0, 0, 255, 0);
                                break;
                            case 248: //MP5
                                glow(gp, i, 255, 0, 0, 255, 0);
                                break;
                            case 249: //MP7
                                glow(gp, i, 255, 0, 0, 255, 0);
                                break;
                            case 250: //MP9
                                glow(gp, i, 255, 0, 0, 255, 0);
                                break;
                            case 251: //Negev
                                glow(gp, i, 255, 0, 0, 255, 0);
                                break;
                            case 252: //Nova
                                glow(gp, i, 255, 0, 0, 255, 0);
                                break;
                            case 254: //P250
                                glow(gp, i, 255, 0, 0, 255, 0);
                                break;
                            case 255: //P90
                                glow(gp, i, 255, 0, 0, 255, 0);
                                break;
                            case 256: //Sawed-Off
                                glow(gp, i, 255, 0, 0, 255, 0);
                                break;
                            case 257: //Scar20
                                glow(gp, i, 255, 0, 0, 255, 0);
                                break;
                            case 258: //Scout
                                glow(gp, i, 255, 0, 0, 255, 0);
                                break;
                            case 262: //SSG08
                                glow(gp, i, 255, 0, 0, 255, 0);
                                break;
                            case 263: //Taser
                                glow(gp, i, 255, 0, 0, 255, 0);
                                break;
                            case 264: //Tec-9
                                glow(gp, i, 255, 0, 0, 255, 0);
                                break;
                            case 266: //UMP45
                                glow(gp, i, 255, 0, 0, 255, 0);
                                break;
                            case 267: //USP-S
                                glow(gp, i, 255, 0, 0, 255, 0);
                                break;
                            case 268: //XM1014
                                glow(gp, i, 255, 0, 0, 255, 0);
                                break;
                            //////////////////////// Grenades /////////////////////////////////////////////
                            case 75: //Flash
                                glow(gp, i, 255, 255, 255, 255, 0);
                                break;
                            case 152: //Smoke
                                glow(gp, i, 255, 255, 255, 255, 0);
                                break;
                            case 110: //Molo
                                glow(gp, i, 255, 255, 255, 255, 0);
                                break;
                            case 94: //HeGrenade
                                glow(gp, i, 255, 255, 255, 255, 0);
                                break;
                            case 45: //Decoy
                                glow(gp, i, 255, 255, 255, 255, 0);
                                break;
                            case 204: //Flash
                                glow(gp, i, 255, 255, 255, 255, 0);
                                break;
                            case 153: //Smoke
                                glow(gp, i, 255, 255, 255, 255, 0);
                                break;
                            case 111: //Molo
                                glow(gp, i, 255, 255, 255, 255, 0);
                                break;
                            case 97: //incendiary
                                glow(gp, i, 255, 255, 255, 255, 0);
                                break;
                            case 46: //Decoy
                                glow(gp, i, 255, 255, 255, 255, 0);
                                break;
                            case 32: //C4
                                glow(gp, i, 255, 255, 255, 255, 0);
                                break;
                            case 126: //Planted C4
                                glow(gp, i, 255, 255, 255, 255, 0);
                                break;
                            case 34: //Chicken
                                glow(gp, i, 255, 255, 255, 255, 0);
                                break;
                            //////////////////////// Players /////////////////////////////////////////////
                            case 38: //Players
                                if (EntityTeam == G.Engine.LocalPlayer.Team && Main.S.GlowTeammates)
                                    glow(gp, i, 0, 0, 255, 255, Main.S.GlowValue);
                                if (EntityTeam != G.Engine.LocalPlayer.Team)
                                    glow(gp, i, 255 - 2.55f * entityHealth, 2.55f * entityHealth, 0, 255, Main.S.GlowValue);
                                break;
                            default:
                                break;
                        }
                           
                    }
               }
                foreach (Entity Player in G.EntityList)
                {
                    float Health = Player.Health;
                    Color HealthColor = Tools.HealthGradient(Tools.HealthToPercent((int)Health));
                    if (Main.S.RadarHackEnabled)
                    {
                        if (Player.IsTeammate == false)
                        {
                            Player.Spotted = true;
                        }
                    }
                    if (Main.S.ChamsEnabled && !Player.IsLocalPlayer)
                    {
                        if (Player.IsTeammate && Main.S.ChamsTeammates)
                        {
                            Player.Cham(Color.Blue);
                            G.Engine.ModelBrightness = Main.S.ChamsValue;
                        }
                        if (!Player.IsTeammate)
                            Player.Cham(HealthColor);
                        G.Engine.ModelBrightness = Main.S.ChamsValue;
                    }
                    if (!Main.S.ChamsEnabled)
                    {
                        Player.ResetChams();
                        G.Engine.ModelBrightness = 0;
                    }
                    if (Main.S.FOVEnabled && G.Engine.LocalPlayer.WeaponName != "AWP" && G.Engine.LocalPlayer.WeaponName != "SSG 08" && G.Engine.LocalPlayer.WeaponName != "SCAR-20" && G.Engine.LocalPlayer.WeaponName != "G3SG1")
                    {
                        Memory.WriteMemory<int>(G.Engine.LocalPlayer.EntityBase + Main.O.netvars.m_iFOV, Main.S.FOVValue);
                    }
                    if (!Main.S.FOVEnabled && (G.Engine.LocalPlayer.WeaponName == "AWP" || G.Engine.LocalPlayer.WeaponName == "SSG 08" || G.Engine.LocalPlayer.WeaponName == "SCAR-20" || G.Engine.LocalPlayer.WeaponName == "G3SG1"))
                    {
                        Memory.WriteMemory<int>(G.Engine.LocalPlayer.EntityBase + Main.O.netvars.m_iFOVStart, 1);
                    }
                    if (Main.S.AntiFlashEnabled)
                    {
                        int FlashDur = G.Engine.LocalPlayer.FlashDuration;
                        if (FlashDur > 0)
                        {
                            G.Engine.LocalPlayer.FlashMaxAlpha = Main.S.AntiFlashAlpha * 2.55f;
                        }
                    }
                }
                Thread.Sleep(1);
            }
        }
    }
}
