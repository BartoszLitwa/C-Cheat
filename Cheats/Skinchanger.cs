using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZBase.Classes;
using ZBase.Utilities;

namespace ZBase.Cheats
{
    class Skinchanger
    {
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
        public static void Run()
        {
            while (true)
            {
                if (G.Engine.GameState == GameState.FULL_CONNECTED)
                {
                    if (Main.S.ForceFullUpdate || Tools.HoldingKey(Keys.VK_END))
                    {
                        Memory.WriteMemory<IntPtr>(Memory.ReadMemory<int>((int)Memory.Engine + Main.O.signatures.dwClientState) + 0x174, -1);

                    }
                    if (Main.S.KnifeChangerEnabled)
                    {
                        int activeWeapon = Memory.ReadMemory<int>(G.Engine.LocalPlayer.EntityBase + Main.O.netvars.m_hActiveWeapon) & 0xfff;
                        activeWeapon = Memory.ReadMemory<int>((int)Memory.Client + Main.O.signatures.dwEntityList + (activeWeapon - 1) * 0x10);
                        short weaponID2 = Memory.ReadMemory<short>(activeWeapon + Main.O.netvars.m_iItemDefinitionIndex);

                        if (weaponID2 == (int)WeaponsID.KNIFE || weaponID2 == (int)WeaponsID.KNIFE_T)
                        {
                            Knife = Memory.ReadMemory<int>(G.Engine.LocalPlayer.EntityBase + m_hViewModel) & 0xfff;
                            Knife = Memory.ReadMemory<int>((int)Memory.Client + Main.O.signatures.dwEntityList + (Knife - 1) * 0x10);
                            KnifeModelIndex = Memory.ReadMemory<int>(Knife + m_nModelIndex) ;
                            KnifeViewModelIndex = Memory.ReadMemory<int>(Knife + m_iViewModelIndex);

                            if (KnifeModelIndex > 0)
                            {
                                bool IsCT = false;
                                if (G.Engine.LocalPlayer.Team == 3)
                                    IsCT = true;

                                KnifeModelIndex = IsCT ? KnifeModelIndex + Main.I.SelectedKnife + 24: KnifeModelIndex + Main.I.SelectedKnife;
                            }

                            if (KnifeModelIndex > 0)
                            {
                                Memory.WriteMemory<short>(Knife + m_nModelIndex, KnifeModelIndex);
                                Memory.WriteMemory<short>(activeWeapon + m_nModelIndex, KnifeModelIndex);
                                Memory.WriteMemory<short>(activeWeapon + Main.O.netvars.m_iItemDefinitionIndex, Main.I.SelectedKnifeID);
                                Memory.WriteMemory<short>(activeWeapon + m_iViewModelIndex, KnifeModelIndex);
                            }
                        }
                        else if (weaponID2 == Main.I.SelectedKnifeID)
                        {
                            if (KnifeModelIndex > 0)
                            {
                                Memory.WriteMemory<short>(Knife + m_nModelIndex, KnifeModelIndex);
                                Memory.WriteMemory<short>(activeWeapon + m_nModelIndex, KnifeModelIndex);
                                Memory.WriteMemory<short>(activeWeapon + Main.O.netvars.m_iItemDefinitionIndex, Main.I.SelectedKnifeID);
                                Memory.WriteMemory<short>(activeWeapon + m_iViewModelIndex, KnifeModelIndex);
                            }
                        }
                        if (Main.S.SkinChangerEnabled)
                        {
                            for (int i = 0; i < 8; i++)
                            {
                                int weaponbase = Memory.ReadMemory<int>(G.Engine.LocalPlayer.EntityBase + Main.O.netvars.m_hMyWeapons + i * 0x4) & 0xFFF;
                                weaponbase = Memory.ReadMemory<int>((int)Memory.Client + Main.O.signatures.dwEntityList + (weaponbase - 1) * 16);
                                int weaponIDD = Memory.ReadMemory<int>(weaponbase + Main.O.netvars.m_iItemDefinitionIndex);
                                //SkinsId https://totalcsgo.com/skin-ids WeaponID https://tf2b.com/itemlist.php?gid=730
                                const int itemIDHigh = -1;
                                const int entityQuality = 3;
                                const float fallbackWear = 0.0001f;
                                int myWeapons = Memory.ReadMemory<int>(G.Engine.LocalPlayer.EntityBase + Main.O.netvars.m_hMyWeapons + i * 0x4) & 0xfff;
                                int weaponEntity = Memory.ReadMemory<int>((int)Memory.Client + Main.O.signatures.dwEntityList + (myWeapons - 1) * 0x10);
                                if (weaponEntity == 0) { continue; }
                                int weaponID = weaponIDD;
                                int fallbackPaint = 0;
                                if (weaponID == (int)WeaponsID.DEAGLE || weaponID == (int)WeaponsID.DEAGLEOnline) { fallbackPaint = Main.S.SkinDeasertEagle; } /* Desert Eagle | Blaze */
                                else if (weaponID == (int)WeaponsID.BERETTAS || weaponID == (int)WeaponsID.BERETTASOnline) { fallbackPaint = Main.S.SkinDualBerettas; } /* Dual Berettas | Cobra Strike */
                                else if (weaponID == (int)WeaponsID.FIVESEVEN || weaponID == (int)WeaponsID.FIVESEVENOnline) { fallbackPaint = Main.S.SkinFiveSeven; } /* Five-SeveN | Hyper Beast */
                                else if (weaponID == (int)WeaponsID.GLOCK || weaponID == (int)WeaponsID.GLOCKOnline) { fallbackPaint = Main.S.SkinGlock18; } /* Glock-18 | Fade */
                                else if (weaponID == (int)WeaponsID.AK47 || weaponID == (int)WeaponsID.AK47Online) { fallbackPaint = Main.S.SkinAK47; } /* AK-47 | Empress */
                                else if (weaponID == (int)WeaponsID.AUG || weaponID == (int)WeaponsID.AUGOnline) { fallbackPaint = Main.S.SkinAUG; } /* AUG | Akihabara Accept */
                                else if (weaponID == (int)WeaponsID.AWP || weaponID == (int)WeaponsID.AWPOnline) { fallbackPaint = Main.S.SkinAWP; } /* AWP | Asiimov */
                                else if (weaponID == (int)WeaponsID.FAMAS || weaponID == (int)WeaponsID.FAMASOnline) { fallbackPaint = Main.S.SkinFamas; } /* FAMAS | Eye of Athena */
                                else if (weaponID == (int)WeaponsID.G3SG1 || weaponID == (int)WeaponsID.G3SG1Online) { fallbackPaint = Main.S.SkinG3SG1; } /* G3SG1 | Flux */
                                else if (weaponID == (int)WeaponsID.GALILAR || weaponID == (int)WeaponsID.GALILAROnline) { fallbackPaint = Main.S.SkinGalilAR; } /* Galil AR | Chatterbox */
                                else if (weaponID == (int)WeaponsID.M249 || weaponID == (int)WeaponsID.M249Online) { fallbackPaint = Main.S.SkinM249; } /* M249 | System Lock */
                                else if (weaponID == (int)WeaponsID.M4A4 || weaponID == (int)WeaponsID.M4A4Online) { fallbackPaint = Main.S.SkinM4A4; } /* M4A4 - Howl */
                                else if (weaponID == (int)WeaponsID.MAC10 || weaponID == (int)WeaponsID.MAC10Online) { fallbackPaint = Main.S.SkinMac10; } /* MAC-10 | Neon Rider */
                                else if (weaponID == (int)WeaponsID.P90 || weaponID == (int)WeaponsID.P90Online) { fallbackPaint = Main.S.SkinP90; } /* P90 | Shallow Grave */
                                else if (weaponID == (int)WeaponsID.UMP45 || weaponID == (int)WeaponsID.UMP45Online) { fallbackPaint = Main.S.SkinUMP45; } /* UMP-45 | Arctic Wolf */
                                else if (weaponID == (int)WeaponsID.MP5SD || weaponID == (int)WeaponsID.MP5SDOnline || weaponID == (int)WeaponsID.MP5SDOnline2) { fallbackPaint = Main.S.SkinMP5; } /* MP5| Arctic Wolf */
                                else if (weaponID == (int)WeaponsID.XM1014 || weaponID == (int)WeaponsID.XM1014Online) { fallbackPaint = Main.S.SkinXM1014; } /* XM1014 | Tranquility */
                                else if (weaponID == (int)WeaponsID.BIZON || weaponID == (int)WeaponsID.BIZONOnline) { fallbackPaint = Main.S.SkinPPBizon; } /* PP-Bizon | Judgement of Anubis */
                                else if (weaponID == (int)WeaponsID.MAG7 || weaponID == (int)WeaponsID.MAG7Online) { fallbackPaint = Main.S.SkinMag7; } /* MP7 | Bloodsport */
                                else if (weaponID == (int)WeaponsID.NEGEV || weaponID == (int)WeaponsID.NEGEVOnline) { fallbackPaint = Main.S.SkinNegev; } /* Negev | Power Loader */
                                else if (weaponID == (int)WeaponsID.SAWEDOFF || weaponID == (int)WeaponsID.SAWEDOFFOnline) { fallbackPaint = Main.S.SkinSawedOff; } /* Sawed-Off | Devourer */
                                else if (weaponID == (int)WeaponsID.TEC9 || weaponID == (int)WeaponsID.TEC9Online) { fallbackPaint = Main.S.SkinTec9; } /* Tec-9 | Fuel Injector */
                                else if (weaponID == (int)WeaponsID.P2000 || weaponID == (int)WeaponsID.P2000Online) { fallbackPaint = Main.S.SkinP2000; } /* P2000 | Imperial Dragon */
                                else if (weaponID == (int)WeaponsID.MP7 || weaponID == (int)WeaponsID.MP7Online) { fallbackPaint = Main.S.SkinMP7; } /* MP7 | Bloodsport */
                                else if (weaponID == (int)WeaponsID.MP9 || weaponID == (int)WeaponsID.MP9Online) { fallbackPaint = Main.S.SkinMP9; } /* MP9 | Rose Iron */
                                else if (weaponID == (int)WeaponsID.NOVA || weaponID == (int)WeaponsID.NOVAOnline) { fallbackPaint = Main.S.SkinNova; } /* Nova | Hyper Beast */
                                else if (weaponID == (int)WeaponsID.P250 || weaponID == (int)WeaponsID.P250Online) { fallbackPaint = Main.S.SkinP250; } /* P250 | See Ya Later */
                                else if (weaponID == (int)WeaponsID.SCAR20 || weaponID == (int)WeaponsID.SCAR20Online) { fallbackPaint = Main.S.SkinSCAR20; } /* SCAR-20 | Cyrex */
                                else if (weaponID == (int)WeaponsID.SG556 || weaponID == (int)WeaponsID.SG556Online) { fallbackPaint = Main.S.SkinSG553; } /* SG 553 | Integrale */
                                else if (weaponID == (int)WeaponsID.SSG08 || weaponID == (int)WeaponsID.SSG08Online) { fallbackPaint = Main.S.SkinSSG08; } /* SSG 08 | Dragonfire */
                                else if (weaponID == (int)WeaponsID.M4A1S || weaponID == (int)WeaponsID.M4A1SOnline || weaponID == (int)WeaponsID.M4A1SOnline2) { fallbackPaint = Main.S.SkinM4A1S; } /* M4A1-S | Hot Rod */
                                else if (weaponID == (int)WeaponsID.USPS || weaponID == (int)WeaponsID.USPSOnline || weaponID == (int)WeaponsID.USPSOnline2) { fallbackPaint = Main.S.SkinUSPS; } /* USP-S | Neo-Noir */
                                else if (weaponID == (int)WeaponsID.CZ75A || weaponID == (int)WeaponsID.CZ75AOnline || weaponID == (int)WeaponsID.CZ75AOnline2) { fallbackPaint = Main.S.SkinCZ75; } /* CZ75-Auto | Neo-Noir */
                                else if (weaponID == (int)WeaponsID.WEAPON_KNIFE_GG || weaponID == (int)WeaponsID.KNIFE || weaponID == (int)WeaponsID.KNIFE_T || weaponID == Main.I.SelectedKnifeID)
                                {
                                    switch (Main.S.SelectedKnifeSkin)
                                    {
                                        case 0:
                                            fallbackPaint = (int)Skins.Fade;
                                            break;
                                        case 1:
                                            fallbackPaint = (int)Skins.CrimsonWeb;
                                            break;
                                        case 2:
                                            fallbackPaint = (int)Skins.Marble_Fade;
                                            break;
                                        case 3:
                                            fallbackPaint = (int)Skins.CaseHardened;
                                            break;
                                        case 4:
                                            fallbackPaint = (int)Skins.TigerTooth;
                                            break;
                                        case 5:
                                            fallbackPaint = (int)Skins.Doppler_SAPPHIRE;
                                            break;
                                        case 6:
                                            fallbackPaint = (int)Skins.Doppler_RUBY;
                                            break;
                                        case 7:
                                            fallbackPaint = (int)Skins.Doppler_BLACKPEARL;
                                            break;
                                        case 8:
                                            fallbackPaint = (int)Skins.Doppler_1;
                                            break;
                                        case 9:
                                            fallbackPaint = (int)Skins.Doppler_2;
                                            break;
                                        case 10:
                                            fallbackPaint = (int)Skins.Doppler_3;
                                            break;
                                        case 11:
                                            fallbackPaint = (int)Skins.Doppler_PHASE1;
                                            break;
                                        case 12:
                                            fallbackPaint = (int)Skins.Doppler_PHASE2;
                                            break;
                                        case 13:
                                            fallbackPaint = (int)Skins.Doppler_PHASE3;
                                            break;
                                        case 14:
                                            fallbackPaint = (int)Skins.Doppler_PHASE4;
                                            break;
                                        case 15:
                                            fallbackPaint = (int)Skins.GammaDoppler_EMERALD;
                                            break;
                                        case 16:
                                            fallbackPaint = (int)Skins.GammaDoppler_PHASE1;
                                            break;
                                        case 17:
                                            fallbackPaint = (int)Skins.GammaDoppler_PHASE2;
                                            break;
                                        case 18:
                                            fallbackPaint = (int)Skins.GammaDoppler_PHASE3;
                                            break;
                                        case 19:
                                            fallbackPaint = (int)Skins.GammaDoppler_PHASE4;
                                            break;
                                        case 20:
                                            fallbackPaint = (int)Skins.Slaughter;
                                            break;
                                        case 21:
                                            fallbackPaint = (int)Skins.Ultraviolet;
                                            break;
                                        case 22:
                                            fallbackPaint = (int)Skins.Ultraviolet_1;
                                            break;
                                        case 23:
                                            fallbackPaint = (int)Skins.Ultraviolet_2;
                                            break;
                                        case 24:
                                            fallbackPaint = (int)Skins.Lore_M9BAYONET;
                                            break;
                                        case 25:
                                            fallbackPaint = (int)Skins.Lore_KARAMBIT;
                                            break;
                                        case 26:
                                            fallbackPaint = (int)Skins.Lore_GUT;
                                            break;
                                        case 27:
                                            fallbackPaint = (int)Skins.Lore_FLIP;
                                            break;
                                        case 28:
                                            fallbackPaint = (int)Skins.Lore_BAYONET;
                                            break;
                                        case 29:
                                            fallbackPaint = (int)Skins.Autotronic_M9BAYONET;
                                            break;
                                        case 30:
                                            fallbackPaint = (int)Skins.Autotronic_KARAMBIT;
                                            break;
                                        case 31:
                                            fallbackPaint = (int)Skins.Autotronic_GUT;
                                            break;
                                        case 32:
                                            fallbackPaint = (int)Skins.Autotronic_FLIP;
                                            break;
                                        case 33:
                                            fallbackPaint = (int)Skins.Autotronic_BAYONET;
                                            break;
                                        case 34:
                                            fallbackPaint = (int)Skins.Freehand_M9BAYONET;
                                            break;
                                        case 35:
                                            fallbackPaint = (int)Skins.Freehand;
                                            break;
                                        case 36:
                                            fallbackPaint = (int)Skins.BrightWater_M9BAYONET;
                                            break;
                                        case 37:
                                            fallbackPaint = (int)Skins.BrightWater;
                                            break;
                                        case 38:
                                            fallbackPaint = (int)Skins.RustCoat;
                                            break;
                                        case 39:
                                            fallbackPaint = (int)Skins.RustCoat_2;
                                            break;
                                        case 40:
                                            fallbackPaint = (int)Skins.RustCoat_3;
                                            break;
                                        case 41:
                                            fallbackPaint = (int)Skins.ForestDDPAT;
                                            break;
                                        case 42:
                                            fallbackPaint = (int)Skins.SafariMesh;
                                            break;
                                        case 43:
                                            fallbackPaint = (int)Skins.Stained;
                                            break;
                                        default:
                                            break;
                                    }
                                    Memory.WriteMemory<int>(myWeapons + m_nModelIndex, KnifeModelIndex);
                                    Memory.WriteMemory<int>(myWeapons + m_iViewModelIndex, KnifeModelIndex);
                                    Memory.WriteMemory<int>(myWeapons + Main.O.netvars.m_iItemDefinitionIndex, Main.I.SelectedKnifeID);
                                }
                                else
                                {
                                    Memory.WriteMemory<IntPtr>(weaponEntity + Main.O.netvars.m_iEntityQuality, entityQuality);
                                }
                                Memory.WriteMemory<IntPtr>(weaponEntity + Main.O.netvars.m_iItemIDHigh, itemIDHigh);
                                Memory.WriteMemory<IntPtr>(weaponEntity + Main.O.netvars.m_nFallbackPaintKit, fallbackPaint);
                                Memory.WriteMemory<float>(weaponEntity + Main.O.netvars.m_flFallbackWear, Main.S.FloatWearValue);
                                //Memory.WriteProcessMemory((int)Memory.ProcessHandle, weaponEntity + Main.O.netvars.m_szCustomName, strings, sizeof(strings), null);
                                if (Main.S.StatTrakValue > 0)
                                    Memory.WriteMemory<int>(weaponEntity + Main.O.netvars.m_nFallbackStatTrak, Main.S.StatTrakValue);
                            }
                        }
                    }
                    if (!Main.S.FasterChangersEnabled)
                        Thread.Sleep(1);
                }
            }
        }
    }
}
