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

        public int GetRank
        {
            get
            {
                IntPtr Playerresource = Memory.ReadMemory<IntPtr>((int)Memory.Client + Main.O.signatures.dwPlayerResource);
                return (int)Memory.ReadMemory<IntPtr>((int)Playerresource + Main.O.netvars.m_iCompetitiveRanking + (int)EntityBase * 10);
            }
        }

        public int GetWins
        {
            get
            {
                int Playerresource = Memory.ReadMemory<int>((int)Memory.Client + Main.O.signatures.dwPlayerResource);
                return Memory.ReadMemory<int>(Playerresource + Main.O.netvars.m_iCompetitiveWins + (int)EntityBase * 16);
            }
        }

        public WeaponID WeaponID
        {
            get
            {
                int weaponbase = Memory.ReadMemory<int>(EntityBase + Main.O.netvars.m_hActiveWeapon);
                int yes = weaponbase & 0xFFF;
                int ok = Memory.ReadMemory<int>((int)Memory.Client + Main.O.signatures.dwEntityList + (yes - 1) * 16);
                return (WeaponID)Memory.ReadMemory<int>(ok + Main.O.netvars.m_iItemDefinitionIndex);
            }
        }

        public bool IsRifle(int id)
            => id == (int)WeaponID.M4A1S || id == (int)WeaponID.M4A4 || id == (int)WeaponID.SG556 || id == (int)WeaponID.AUG || id == (int)WeaponID.GALILAR
            || id == (int)WeaponID.FAMAS || id == (int)WeaponID.AK47;

        public bool IsSniper(int id)
            => id == (int)WeaponID.AWP || id == (int)WeaponID.SCAR20 || id == (int)WeaponID.SSG08 || id == (int)WeaponID.G3SG1;

        public bool IsC4(int id)
            => id == (int)WeaponID.C4;

        public bool IsPistol(int id)
            => id == (int)WeaponID.DEAGLE || id == (int)WeaponID.FIVESEVEN || id == (int)WeaponID.TEC9 || id == (int)WeaponID.USPS || id == (int)WeaponID.P2000
            || id == (int)WeaponID.P250 || id == (int)WeaponID.GLOCK || id == (int)WeaponID.BERETTAS || id == (int)WeaponID.CZ75A || id == (int)WeaponID.REVOLVER;

        public bool IsShotgun(int id)
           => id == (int)WeaponID.XM1014 || id == (int)WeaponID.NOVA || id == (int)WeaponID.MAG7 || id == (int)WeaponID.SAWEDOFF;

        public bool IsMP(int id)
            => id == (int)WeaponID.UMP45 || id == (int)WeaponID.P90 || id == (int)WeaponID.MP9 || id == (int)WeaponID.MP7 || id == (int)WeaponID.MAC10
            || id == (int)WeaponID.BIZON || id == (int)WeaponID.MP5SD;

        public bool IsGrenade(int id)
            => id == (int)WeaponID.HEGRENADE || id == (int)WeaponID.SMOKEGRENADE || id == (int)WeaponID.INCGRENADE || id == (int)WeaponID.MOLOTOV
            || id == (int)WeaponID.FLASHBANG || id == (int)WeaponID.DECOY;

        public bool IsMachineGun(int id)
            => id == (int)WeaponID.NEGEV || id == (int)WeaponID.M249;

        public string WeaponName
        {
            get
            {
                switch (this.WeaponID)
                {
                    case WeaponID.DEAGLE:
                        return "Desert Eagle";
                    case WeaponID.BERETTAS:
                        return "Dual Berettas";
                    case WeaponID.FIVESEVEN:
                        return "Five-SeveN";
                    case WeaponID.GLOCK:
                        return "Glock-18";
                    case WeaponID.AK47:
                        return "AK-47";
                    case WeaponID.AUG:
                        return "AUG";
                    case WeaponID.AWP:
                        return "AWP";
                    case WeaponID.FAMAS:
                        return "FAMAS";
                    case WeaponID.G3SG1:
                        return "G3SG1";
                    case WeaponID.GALILAR:
                        return "Galil";
                    case WeaponID.M249:
                        return "M249";
                    case WeaponID.M4A4:
                        return "M4A1";
                    case WeaponID.MAC10:
                        return "MAC-10";
                    case WeaponID.P90:
                        return "P90";
                    case WeaponID.UMP45:
                        return "UMP-45";
                    case WeaponID.XM1014:
                        return "XM1014";
                    case WeaponID.BIZON:
                        return "PP-Bizon";
                    case WeaponID.MAG7:
                        return "MAG-7";
                    case WeaponID.NEGEV:
                        return "Negev";
                    case WeaponID.SAWEDOFF:
                        return "Sawed-Off";
                    case WeaponID.TEC9:
                        return "Tec-9";
                    case WeaponID.TASER:
                        return "Taser";
                    case WeaponID.P2000:
                        return "P2000";
                    case WeaponID.MP7:
                        return "MP7";
                    case WeaponID.MP9:
                        return "MP9";
                    case WeaponID.NOVA:
                        return "Nova";
                    case WeaponID.P250:
                        return "P250";
                    case WeaponID.MP5SD:
                        return "MP5-SD";
                    case WeaponID.SCAR20:
                        return "SCAR-20";
                    case WeaponID.SG556:
                        return "SG 553";
                    case WeaponID.SSG08:
                        return "SSG 08";
                    case WeaponID.KNIFE:
                        return "Knife";
                    case WeaponID.FLASHBANG:
                        return "Flashbang";
                    case WeaponID.HEGRENADE:
                        return "Grenade";
                    case WeaponID.SMOKEGRENADE:
                        return "Smoke Grenade";
                    case WeaponID.MOLOTOV:
                        return "Molotov";
                    case WeaponID.DECOY:
                        return "Decoy";
                    case WeaponID.INCGRENADE:
                        return "Incendiary Grenade";
                    case WeaponID.C4:
                        return "C4";
                    case WeaponID.M4A1S:
                        return "M4A1-S";
                    case WeaponID.USPS:
                        return "USP-S";
                    case WeaponID.CZ75A:
                        return "CZ75-Auto";
                    case WeaponID.REVOLVER:
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
