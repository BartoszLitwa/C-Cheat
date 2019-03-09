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
                    #region Glow
                    int gp = Memory.ReadMemory<int>((int)Memory.Client + Main.O.signatures.dwGlowObjectManager);
                    int ObjectCount = Memory.ReadMemory<int>((int)Memory.Client + Main.O.signatures.dwGlowObjectManager + 0x4);
                    for (int i = 0; i < ObjectCount; i++)
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
                            //case 136:
                            //    Memory.WriteMemory<int>(EntityBase + Main.O.netvars.m_clrRender, 255);
                            //    Memory.WriteMemory<int>(EntityBase + Main.O.netvars.m_clrRender + 1, 0);
                            //    Memory.WriteMemory<int>(EntityBase + Main.O.netvars.m_clrRender + 2, 0);
                            //    Memory.WriteMemory<int>(EntityBase + Main.O.netvars.m_clrRender + 3, 255);
                            //    break;
                            /////////////////////////////////////////////////////// Rifles
                            case 1: //AK47
                                if (Main.S.GlowAK47)
                                    glow(gp, i, Main.S.ESPColorRifles.R, Main.S.ESPColorRifles.G, Main.S.ESPColorRifles.B, 255, 0);
                                break;
                            case 228: //AUG
                                if (Main.S.GlowAUG)
                                    glow(gp, i, Main.S.ESPColorRifles.R, Main.S.ESPColorRifles.G, Main.S.ESPColorRifles.B, 255, 0);
                                break;
                            case 245: //M4
                                if (Main.S.GlowM4)
                                    glow(gp, i, Main.S.ESPColorRifles.R, Main.S.ESPColorRifles.G, Main.S.ESPColorRifles.B, 255, 0);
                                break;
                            case 236: //Famas
                                if (Main.S.GlowFamas)
                                    glow(gp, i, Main.S.ESPColorRifles.R, Main.S.ESPColorRifles.G, Main.S.ESPColorRifles.B, 255, 0);
                                break;
                            case 240: //GalilAR
                                if (Main.S.GlowGalil)
                                    glow(gp, i, Main.S.ESPColorRifles.R, Main.S.ESPColorRifles.G, Main.S.ESPColorRifles.B, 255, 0);
                                break;
                            /////////////////////////////////////////////////////// Pistols
                            case 44: //Deagle
                                if (Main.S.GlowDeagle)
                                    glow(gp, i, Main.S.ESPColorPistols.R, Main.S.ESPColorPistols.G, Main.S.ESPColorPistols.B, 255, 0);
                                break;
                            case 235: //Elite Berettas
                                if (Main.S.GlowBerettas)
                                    glow(gp, i, Main.S.ESPColorPistols.R, Main.S.ESPColorPistols.G, Main.S.ESPColorPistols.B, 255, 0);
                                break;
                            case 237: //Five-Seven
                                if (Main.S.GlowFiveSeven)
                                    glow(gp, i, Main.S.ESPColorPistols.R, Main.S.ESPColorPistols.G, Main.S.ESPColorPistols.B, 255, 0);
                                break;
                            case 241: //Glock
                                if (Main.S.GlowGlock18)
                                    glow(gp, i, Main.S.ESPColorPistols.R, Main.S.ESPColorPistols.G, Main.S.ESPColorPistols.B, 255, 0);
                                break;
                            case 242: //P2000
                                if (Main.S.GlowP2000)
                                    glow(gp, i, Main.S.ESPColorPistols.R, Main.S.ESPColorPistols.G, Main.S.ESPColorPistols.B, 255, 0);
                                break;
                            case 254: //P250
                                if (Main.S.GlowP250)
                                    glow(gp, i, Main.S.ESPColorPistols.R, Main.S.ESPColorPistols.G, Main.S.ESPColorPistols.B, 255, 0);
                                break;
                            case 264: //Tec-9
                                if (Main.S.GlowTec9)
                                    glow(gp, i, Main.S.ESPColorPistols.R, Main.S.ESPColorPistols.G, Main.S.ESPColorPistols.B, 255, 0);
                                break;
                            case 267: //USP-S
                                if (Main.S.GlowP2000)
                                    glow(gp, i, Main.S.ESPColorPistols.R, Main.S.ESPColorPistols.G, Main.S.ESPColorPistols.B, 255, 0);
                                break;
                            ///////////////////////////////////////////////////// Snipers
                            case 229: //AWP
                                if (Main.S.GlowAWP)
                                    glow(gp, i, Main.S.ESPColorSnipers.R, Main.S.ESPColorSnipers.G, Main.S.ESPColorSnipers.B, 255, 0);
                                break;
                            case 238: //G3SG1
                                if (Main.S.GlowG3SG1)
                                    glow(gp, i, Main.S.ESPColorSnipers.R, Main.S.ESPColorSnipers.G, Main.S.ESPColorSnipers.B, 255, 0);
                                break;
                            case 257: //Scar20
                                if (Main.S.GlowSCAR20)
                                    glow(gp, i, Main.S.ESPColorSnipers.R, Main.S.ESPColorSnipers.G, Main.S.ESPColorSnipers.B, 255, 0);
                                break;
                            case 258: //Scout
                                if (Main.S.GlowSSG08)
                                    glow(gp, i, Main.S.ESPColorSnipers.R, Main.S.ESPColorSnipers.G, Main.S.ESPColorSnipers.B, 255, 0);
                                break;
                            case 262: //SSG08
                                if (Main.S.GlowSSG08)
                                    glow(gp, i, Main.S.ESPColorSnipers.R, Main.S.ESPColorSnipers.G, Main.S.ESPColorSnipers.B, 255, 0);
                                break;
                            ///////////////////////////////////////////////////// Shotguns
                            case 247: //Mag-7
                                if (Main.S.GlowMag7)
                                    glow(gp, i, Main.S.ESPColorShotGuns.R, Main.S.ESPColorShotGuns.G, Main.S.ESPColorShotGuns.B, 255, 0);
                                break;
                            case 252: //Nova
                                if (Main.S.GlowNova)
                                    glow(gp, i, Main.S.ESPColorShotGuns.R, Main.S.ESPColorShotGuns.G, Main.S.ESPColorShotGuns.B, 255, 0);
                                break;
                            case 256: //Sawed-Off
                                if (Main.S.GlowSawedOff)
                                    glow(gp, i, Main.S.ESPColorShotGuns.R, Main.S.ESPColorShotGuns.G, Main.S.ESPColorShotGuns.B, 255, 0);
                                break;
                            case 268: //XM1014
                                if (Main.S.GlowXM1014)
                                    glow(gp, i, Main.S.ESPColorShotGuns.R, Main.S.ESPColorShotGuns.G, Main.S.ESPColorShotGuns.B, 255, 0);
                                break;
                            ///////////////////////////////////////////////////// MachineGuns
                            case 243: //M249
                                if (Main.S.GlowM249)
                                    glow(gp, i, Main.S.ESPColorMachineGuns.R, Main.S.ESPColorMachineGuns.G, Main.S.ESPColorMachineGuns.B, 255, 0);
                                break;
                            case 251: //Negev
                                if (Main.S.GlowNegev)
                                    glow(gp, i, Main.S.ESPColorMachineGuns.R, Main.S.ESPColorMachineGuns.G, Main.S.ESPColorMachineGuns.B, 255, 0);
                                break;
                            ///////////////////////////////////////////////////// SMG
                            case 231: //Bizon
                                if (Main.S.GlowBizon)
                                    glow(gp, i, Main.S.ESPColorSMG.R, Main.S.ESPColorSMG.G, Main.S.ESPColorSMG.B, 255, 0);
                                break;
                            case 246: //Mac10
                                if (Main.S.GlowMac10)
                                    glow(gp, i,  Main.S.ESPColorSMG.R, Main.S.ESPColorSMG.G, Main.S.ESPColorSMG.B, 255, 0);
                                break;
                            case 248: //MP5
                                if (Main.S.GlowMP5)
                                    glow(gp, i,  Main.S.ESPColorSMG.R, Main.S.ESPColorSMG.G, Main.S.ESPColorSMG.B, 255, 0);
                                break;
                            case 249: //MP7
                                if (Main.S.GlowMP7)
                                    glow(gp, i,  Main.S.ESPColorSMG.R, Main.S.ESPColorSMG.G, Main.S.ESPColorSMG.B, 255, 0);
                                break;
                            case 250: //MP9
                                if (Main.S.GlowMP9)
                                    glow(gp, i,  Main.S.ESPColorSMG.R, Main.S.ESPColorSMG.G, Main.S.ESPColorSMG.B, 255, 0);
                                break;
                            case 255: //P90
                                if (Main.S.GlowP90)
                                    glow(gp, i,  Main.S.ESPColorSMG.R, Main.S.ESPColorSMG.G, Main.S.ESPColorSMG.B, 255, 0);
                                break;
                            case 266: //UMP45
                                if (Main.S.GlowUMP45)
                                    glow(gp, i,  Main.S.ESPColorSMG.R, Main.S.ESPColorSMG.G, Main.S.ESPColorSMG.B, 255, 0);
                                break;


                            case 263: //Taser
                                if (Main.S.GlowTaser)
                                    glow(gp, i, 255, 0, 0, 255, 0);
                                break;
                            //////////////////////// Grenades /////////////////////////////////////////////
                            case 75: //Flash
                                if (Main.S.GlowFlash)
                                    glow(gp, i, 255, 255, 255, 255, 0);
                                break;
                            case 152: //Smoke
                                if (Main.S.GlowSmoke)
                                    glow(gp, i, 255, 255, 255, 255, 0);
                                break;
                            case 110: //Molo
                                if (Main.S.GlowMolo)
                                    glow(gp, i, 255, 255, 255, 255, 0);
                                break;
                            case 94: //HeGrenade
                                if (Main.S.GlowHEGrenade)
                                    glow(gp, i, 255, 255, 255, 255, 0);
                                break;
                            case 45: //Decoy
                                if (Main.S.GlowDecoy)
                                    glow(gp, i, 255, 255, 255, 255, 0);
                                break;
                            case 204: //Flash
                                if (Main.S.GlowFlash)
                                    glow(gp, i, 255, 255, 255, 255, 0);
                                break;
                            case 153: //Smoke
                                if (Main.S.GlowSmoke)
                                    glow(gp, i, 255, 255, 255, 255, 0);
                                break;
                            case 111: //Molo
                                if (Main.S.GlowMolo)
                                    glow(gp, i, 255, 255, 255, 255, 0);
                                break;
                            case 97: //incendiary
                                if (Main.S.GlowMolo)
                                    glow(gp, i, 255, 255, 255, 255, 0);
                                break;
                            case 46: //Decoy
                                if (Main.S.GlowDecoy)
                                    glow(gp, i, 255, 255, 255, 255, 0);
                                break;
                            case 32: //C4
                                if (Main.S.GlowC4)
                                    glow(gp, i, 255, 255, 255, 255, 0);
                                break;
                            case 126: //Planted C4
                                if (Main.S.GlowC4)
                                    glow(gp, i, 255, 255, 255, 255, 0);
                                break;
                            case 34: //Chicken
                                if (Main.S.GlowChicken)
                                    glow(gp, i, 255, 255, 255, 255, 0);
                                break;
                            //////////////////////// Players /////////////////////////////////////////////
                            case 38: //Players
                                if (Main.S.GlowPlayers)
                                {
                                    if (EntityTeam == G.Engine.LocalPlayer.Team && Main.S.GlowTeammates)
                                        glow(gp, i, Main.S.GlowColorTeammates.R, Main.S.GlowColorTeammates.G, Main.S.GlowColorTeammates.B, 255, Main.S.GlowValue);
                                    if (EntityTeam != G.Engine.LocalPlayer.Team)
                                        if(Main.S.GlowHealthBased)
                                            glow(gp, i, 255 - 2.55f * entityHealth, 2.55f * entityHealth, 0, 255, Main.S.GlowValue);
                                        if (!Main.S.GlowHealthBased)
                                            glow(gp, i, Main.S.GlowColorEnemies.R, Main.S.GlowColorEnemies.G, Main.S.GlowColorEnemies.B, 255, Main.S.GlowValue);
                                }
                                break;
                            default:
                                break;
                        }
                           
                    }
                    #endregion Glow
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
                            Player.Cham(Main.S.ChamsColorTeammates);
                            G.Engine.ModelBrightness = Main.S.ChamsValue;
                        }
                        if (!Player.IsTeammate)
                            if(Main.S.ChamsHealthBased)
                                Player.Cham(HealthColor);
                            if (!Main.S.ChamsHealthBased)
                                Player.Cham(Main.S.ChamsColorEnemies);
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
