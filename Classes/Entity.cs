using ZBase.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ZBase.Classes
{
    public class Entity
    {
        public int EntityBase;

        public Entity(int Base)
        {
            EntityBase = Base;
        }

        public player_info_s PlayerInfo(int PlayerId)
        {
                int uInfoTable = Memory.ReadMemory<int>(Main.O.signatures.dwClientState + Main.O.signatures.dwClientState_PlayerInfo);
                int items = Memory.ReadMemory<int>(Memory.ReadMemory<int>(uInfoTable + 0x3C) + 0xC);
                return Memory.ReadMemory<player_info_s>(Memory.ReadMemory<int>(items + 0x20 + ((PlayerId /*- 1*/) * 0x34)));
        }

        public int Health
        {
            get
            {
                return Memory.ReadMemory<int>(EntityBase + Main.O.netvars.m_iHealth);
            }
        }

        public int Armor
        {
            get
            {
                return Memory.ReadMemory<int>(EntityBase + Main.O.netvars.m_ArmorValue);
            }
        }

        public float FlashMaxAlpha
        {
            get
            {
                return Memory.ReadMemory<int>(EntityBase + Main.O.netvars.m_flFlashMaxAlpha);
            }
            set
            {
                Memory.WriteMemory<int>(EntityBase + Main.O.netvars.m_flFlashMaxAlpha, value);
            }
        }

        public int GlowIndex
        {
            get
            {
                return Memory.ReadMemory<int>(EntityBase + Main.O.netvars.m_iGlowIndex);
            }
        }

        public int Team
        {
            get
            {
                return Memory.ReadMemory<int>(EntityBase + Main.O.netvars.m_iTeamNum);
            }
        }

        public int Flags
        {
            get
            {
                return Memory.ReadMemory<int>(EntityBase + Main.O.netvars.m_fFlags);
            }
        }

        public bool IsTeammate
        {
            get
            {
                return Team == G.Engine.LocalPlayer.Team;
            }
        }

        public Vector3 Position
        {
            get
            {
                return Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecOrigin);
            }
        }

        public Vector3 EyePosition
        {
            get
            {
                return Position + Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecViewOffset);
            }
        }

        public Vector3 HeadPosition
        {
            get
            {
                return GetBonePosition(8);
            }
        }

        public Vector3 GetBonePosition(int BoneID)
        {
            int bonematrix = Memory.ReadMemory<int>(EntityBase + Main.O.netvars.m_dwBoneMatrix);
            float x = Memory.ReadMemory<float>(bonematrix + 0x30 * BoneID + 0x0C);
            float y = Memory.ReadMemory<float>(bonematrix + 0x30 * BoneID + 0x1C);
            float z = Memory.ReadMemory<float>(bonematrix + 0x30 * BoneID + 0x2C);
            return new Vector3(x, y, z);
        }

        public bool Spotted
        {
            get
            {
                return Memory.ReadMemory<bool>(EntityBase + Main.O.netvars.m_bSpotted);
            }
            set
            {
                Memory.WriteMemory<bool>(EntityBase + Main.O.netvars.m_bSpotted, Convert.ToByte(value));
            }
        }

        public bool SpottedByMask
        {
            get
            {
                return Memory.ReadMemory<bool>(EntityBase + Main.O.netvars.m_bSpottedByMask);
            }
            set
            {
                Memory.WriteMemory<bool>(EntityBase + Main.O.netvars.m_bSpottedByMask, Convert.ToByte(value));
            }
        }

        public bool IsLocalPlayer
        {
            get
            {
                return G.Engine.LocalPlayer.EntityBase == EntityBase;
            }
        }

        public int FlashDuration
        {
            get
            {
                return Memory.ReadMemory<int>(EntityBase + Main.O.netvars.m_flFlashDuration);
            }
            set
            {
                Memory.WriteMemory<int>(EntityBase + Main.O.netvars.m_flFlashDuration, value);
            }
        }

        public bool Dormant
        {
            get
            {
                return Memory.ReadMemory<bool>(EntityBase + Main.O.signatures.m_bDormant);
            }
        }

        public bool Immunity
        {
            get
            {
                return Memory.ReadMemory<bool>(EntityBase + Main.O.netvars.m_bGunGameImmunity);
            }
        }

        public int CrosshairID
        {
            get
            {
                return Memory.ReadMemory<int>(EntityBase + Main.O.netvars.m_iCrosshairId);
            }
        }

        public void Glow(Color color, int glowstyle)
        {
            GlowStruct GlowObj = new GlowStruct();

            GlowObj = Memory.ReadMemory<GlowStruct>(G.Engine.GlowObjectManager + GlowIndex * 0x38);

            GlowObj.r = (float)color.R / 255;
            GlowObj.g = (float)color.G / 255;
            GlowObj.b = (float)color.B / 255;
            GlowObj.a = (float)color.A / 255;
            GlowObj.m_bRenderWhenOccluded = true;
            GlowObj.m_bRenderWhenUnoccluded = false;
            GlowObj.GlowStyle = glowstyle;

            Memory.WriteMemory<GlowStruct>(G.Engine.GlowObjectManager + GlowIndex * 0x38, GlowObj);
        }

        public void Cham(Color color)
        {
            // these only show while visible
            Memory.WriteMemory<int>(EntityBase + Main.O.netvars.m_clrRender, color.R);
            Memory.WriteMemory<int>(EntityBase + Main.O.netvars.m_clrRender + 1, color.G);
            Memory.WriteMemory<int>(EntityBase + Main.O.netvars.m_clrRender + 2, color.B);
            Memory.WriteMemory<int>(EntityBase + Main.O.netvars.m_clrRender + 3, color.A);
        }
        public void ResetChams()
        {
            Cham(Color.FromArgb(255, 255, 255, 255));
        }

        public char Names
        {
            get
            {
                return Memory.ReadMemory<char>(EntityBase + Main.O.netvars.m_szCustomName);
            }
        }

        public bool Alive
        {
            get
            {
                if (Health > 0 && Health <= 100)
                    return true;
                return false;
            }
        }

        public bool Dead
        {
            get
            {
                if (!Alive)
                    return true;
                return false;
            }
        }

        public bool IsPlayer
        {
            get
            {
                if (Team == 2 || Team == 3)
                    return true;
                else if (Team == 0 || Team == 1)
                    return false;
                else
                    return false;
            }
        }

        public Ranks GetRank(int PlayerIndex)
        {
                int PlayerResource = Memory.ReadMemory<int>((int)Memory.Client + Main.O.signatures.dwPlayerResource);
                return (Ranks)Memory.ReadMemory<int>(PlayerResource + Main.O.netvars.m_iCompetitiveRanking + PlayerIndex * 4);
        }

        public int GetWins(int PlayerIndex)
        {
                int PlayerResource = Memory.ReadMemory<int>((int)Memory.Client + Main.O.signatures.dwPlayerResource);
                return Memory.ReadMemory<int>(PlayerResource + Main.O.netvars.m_iCompetitiveWins + PlayerIndex * 4);
        }

        public WeaponsID WeaponID
        {
            get
            {
                int weaponbase = Memory.ReadMemory<int>(EntityBase + Main.O.netvars.m_hActiveWeapon);
                int yes = weaponbase & 0xFFF;
                int ok = Memory.ReadMemory<int>((int)Memory.Client + Main.O.signatures.dwEntityList + (yes - 1) * 16);
                return (WeaponsID)Memory.ReadMemory<int>(ok + Main.O.netvars.m_iItemDefinitionIndex);
            }
        }

        public bool IsRifle(int id)
            => id == (int)WeaponsID.M4A1S || id == (int)WeaponsID.M4A1SOnline || id == (int)WeaponsID.M4A1SOnline2 || id == (int)WeaponsID.M4A4 || id == (int)WeaponsID.SG556
            || id == (int)WeaponsID.AUG || id == (int)WeaponsID.GALILAR || id == (int)WeaponsID.FAMAS || id == (int)WeaponsID.AK47;

        public bool IsSniper(int id)
            => id == (int)WeaponsID.AWP || id == (int)WeaponsID.SCAR20 || id == (int)WeaponsID.SSG08 || id == (int)WeaponsID.G3SG1;

        public bool IsC4(int id)
            => id == (int)WeaponsID.C4;

        public bool IsPistol(int id)
            => id == (int)WeaponsID.DEAGLE || id == (int)WeaponsID.FIVESEVEN || id == (int)WeaponsID.TEC9 || id == (int)WeaponsID.USPS || id == (int)WeaponsID.USPSOnline 
            || id == (int)WeaponsID.USPSOnline2 || id == (int)WeaponsID.P2000|| id == (int)WeaponsID.P250 || id == (int)WeaponsID.GLOCK || id == (int)WeaponsID.BERETTAS
            || id == (int)WeaponsID.CZ75A || id == (int)WeaponsID.CZ75AOnline || id == (int)WeaponsID.CZ75AOnline2 || id == (int)WeaponsID.REVOLVER || id == (int)WeaponsID.REVOLVEROnline
            || id == (int)WeaponsID.REVOLVEROnline2;

        public bool IsShotgun(int id)
           => id == (int)WeaponsID.XM1014 || id == (int)WeaponsID.NOVA || id == (int)WeaponsID.MAG7 || id == (int)WeaponsID.SAWEDOFF;

        public bool IsMP(int id)
            => id == (int)WeaponsID.UMP45 || id == (int)WeaponsID.P90 || id == (int)WeaponsID.MP9 || id == (int)WeaponsID.MP7 || id == (int)WeaponsID.MAC10
            || id == (int)WeaponsID.BIZON || id == (int)WeaponsID.MP5SD || id == (int)WeaponsID.MP5SDOnline || id == (int)WeaponsID.MP5SDOnline2;

        public bool IsGrenade(int id)
            => id == (int)WeaponsID.HEGRENADE || id == (int)WeaponsID.SMOKEGRENADE || id == (int)WeaponsID.INCGRENADE || id == (int)WeaponsID.MOLOTOV
            || id == (int)WeaponsID.FLASHBANG || id == (int)WeaponsID.DECOY;

        public bool IsMachineGun(int id)
            => id == (int)WeaponsID.NEGEV || id == (int)WeaponsID.M249;

        public string WeaponName
        {
            get
            {
                switch (this.WeaponID)
                {
                    case WeaponsID.DEAGLE:
                        return "Desert Eagle";
                    case WeaponsID.BERETTAS:
                        return "Dual Berettas";
                    case WeaponsID.FIVESEVEN:
                        return "Five-SeveN";
                    case WeaponsID.GLOCK:
                        return "Glock-18";
                    case WeaponsID.AK47:
                        return "AK-47";
                    case WeaponsID.AUG:
                        return "AUG";
                    case WeaponsID.AWP:
                        return "AWP";
                    case WeaponsID.FAMAS:
                        return "FAMAS";
                    case WeaponsID.G3SG1:
                        return "G3SG1";
                    case WeaponsID.GALILAR:
                        return "Galil";
                    case WeaponsID.M249:
                        return "M249";
                    case WeaponsID.M4A4:
                        return "M4A1";
                    case WeaponsID.MAC10:
                        return "MAC-10";
                    case WeaponsID.P90:
                        return "P90";
                    case WeaponsID.UMP45:
                        return "UMP-45";
                    case WeaponsID.XM1014:
                        return "XM1014";
                    case WeaponsID.BIZON:
                        return "PP-Bizon";
                    case WeaponsID.MAG7:
                        return "MAG-7";
                    case WeaponsID.NEGEV:
                        return "Negev";
                    case WeaponsID.SAWEDOFF:
                        return "Sawed-Off";
                    case WeaponsID.TEC9:
                        return "Tec-9";
                    case WeaponsID.TASER:
                        return "Taser";
                    case WeaponsID.TASEROnline:
                        return "Taser";
                    case WeaponsID.P2000:
                        return "P2000";
                    case WeaponsID.MP7:
                        return "MP7";
                    case WeaponsID.MP9:
                        return "MP9";
                    case WeaponsID.NOVA:
                        return "Nova";
                    case WeaponsID.P250:
                        return "P250";
                    case WeaponsID.MP5SD:
                        return "MP5-SD";
                    case WeaponsID.MP5SDOnline:
                        return "MP5-SD";
                    case WeaponsID.MP5SDOnline2:
                        return "MP5-SD";
                    case WeaponsID.SCAR20:
                        return "SCAR-20";
                    case WeaponsID.SG556:
                        return "SG 553";
                    case WeaponsID.SSG08:
                        return "SSG 08";
                    case WeaponsID.KNIFE:
                        return "Knife";
                    case WeaponsID.FLASHBANG:
                        return "Flashbang";
                    case WeaponsID.HEGRENADE:
                        return "Grenade";
                    case WeaponsID.SMOKEGRENADE:
                        return "Smoke Grenade";
                    case WeaponsID.MOLOTOV:
                        return "Molotov";
                    case WeaponsID.DECOY:
                        return "Decoy";
                    case WeaponsID.INCGRENADE:
                        return "Incendiary Grenade";
                    case WeaponsID.C4:
                        return "C4";
                    case WeaponsID.M4A1S:
                        return "M4A1-S";
                    case WeaponsID.USPS:
                        return "USP-S";
                    case WeaponsID.USPSOnline:
                        return "USP-S";
                    case WeaponsID.USPSOnline2:
                        return "USP-S";
                    case WeaponsID.CZ75A:
                        return "CZ75-Auto";
                    case WeaponsID.CZ75AOnline:
                        return "CZ75-Auto";
                    case WeaponsID.CZ75AOnline2:
                        return "CZ75-Auto";
                    case WeaponsID.REVOLVER:
                        return "R8 Revolver";
                    case WeaponsID.REVOLVEROnline:
                        return "R8 Revolver";
                    case WeaponsID.REVOLVEROnline2:
                        return "R8 Revolver";
                    default:
                        return "Unknown";
                }
            }
        }

        public bool Valid
        {
            get
            {
                if (Dormant)
                    return false;
                if (Dead)
                    return false;
                if (!IsPlayer)
                    return false;
                return true;
            }
        }

        public Vector2 AimPunchAngle
        {
            get
            {
                return Memory.ReadMemory<Vector2>(EntityBase + Main.O.netvars.m_aimPunchAngle);
            }
            set
            {
                Memory.WriteMemory<Vector2>(EntityBase + Main.O.netvars.m_aimPunchAngle, value);
            }
        }
        public Vector2 ViewPunchAngle
        {
            get
            {
                return Memory.ReadMemory<Vector2>(EntityBase + Main.O.netvars.m_viewPunchAngle);
            }
            set
            {
                Memory.WriteMemory<Vector2>(EntityBase + Main.O.netvars.m_viewPunchAngle, value);
            }
        }
        public int ShotsFired
        {
            get
            {
                return Memory.ReadMemory<int>(EntityBase + Main.O.netvars.m_iShotsFired);
            }
        }
        public Vector3 Velocity
        {
            get
            {
                return Memory.ReadMemory<Vector3>(EntityBase + Main.O.netvars.m_vecVelocity);
            }
        }

        public byte MouseEnable
        {
            get
            {
                return Memory.ReadMemory<byte>((int)Memory.Client + Main.O.signatures.dwMouseEnable);
            }
        }

        public bool Scoped
        {
            get
            {
                return Memory.ReadMemory<bool>(EntityBase + Main.O.netvars.m_bIsScoped);
            }
        }
        public float Distance
        {
            get
            {
                return Vector3.Distance(G.Engine.LocalPlayer.Position, Position);
            }
        }
    }
}
