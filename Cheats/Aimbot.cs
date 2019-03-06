using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZBase.Classes;
using ZBase.Utilities;

namespace ZBase.Cheats
{
    class Aimbot
    {
        public static void Run()
        {
            while (true)
            {
                string activeweapon = G.Engine.LocalPlayer.WeaponName;
                int WeaponID = (int)G.Engine.LocalPlayer.WeaponID;
                if (!Main.S.RageBotEnabled)
                {
                     if (G.Engine.LocalPlayer.IsRifle(WeaponID) && Main.S.AimbotEnabledRifle)
                         UseAimbot(activeweapon, Main.S.AimbotEnabledRifle, Main.S.AimbotSpottedByMaskRifle, Main.S.RecoilPredictionEnabledRifle, Main.S.aimbotSmoothRifle, Main.S.SmartAimbotRifle, Main.S.SilentAImEnabled, Main.S.ShootteammatesEnabled, Main.S.ClosesBoneAimbotEnabled, Main.S.DrawDisplayFovAimbotValueRifle, Main.S.AimbotBoneIDRifle, Main.S.aimbotSmoothValueRifle);

                     if (G.Engine.LocalPlayer.IsPistol(WeaponID) || WeaponID == 62 && Main.S.AimbotEnabledPistols)
                         UseAimbot(activeweapon, Main.S.AimbotEnabledPistols, Main.S.AimbotSpottedByMaskPistols, Main.S.RecoilPredictionEnabledPistols, Main.S.aimbotSmoothPistols, Main.S.SmartAimbotPistols, Main.S.SilentAImEnabled, Main.S.ShootteammatesEnabled, Main.S.ClosesBoneAimbotEnabled, Main.S.DrawDisplayFovAimbotValuePistols, Main.S.AimbotBoneIDPistols, Main.S.aimbotSmoothValuePistols);

                     if (G.Engine.LocalPlayer.IsSniper(WeaponID) && Main.S.AimbotEnabledSnipers)
                         UseAimbot(activeweapon, Main.S.AimbotEnabledSnipers, Main.S.AimbotSpottedByMaskSnipers, Main.S.RecoilPredictionEnabledSnipers, Main.S.aimbotSmoothSnipers, Main.S.SmartAimbotSnipers, Main.S.SilentAImEnabled, Main.S.ShootteammatesEnabled, Main.S.ClosesBoneAimbotEnabled, Main.S.DrawDisplayFovAimbotValueSnipers, Main.S.AimbotBoneIDSnipers, Main.S.aimbotSmoothValueSnipers);

                     if (G.Engine.LocalPlayer.IsShotgun(WeaponID) && Main.S.AimbotEnabledShotGuns)
                         UseAimbot(activeweapon, Main.S.AimbotEnabledShotGuns, Main.S.AimbotSpottedByMaskShotGuns, Main.S.RecoilPredictionEnabledShotGuns, Main.S.aimbotSmoothShotGuns, Main.S.SmartAimbotShotGuns, Main.S.SilentAImEnabled, Main.S.ShootteammatesEnabled, Main.S.ClosesBoneAimbotEnabled, Main.S.DrawDisplayFovAimbotValueShotGuns, Main.S.AimbotBoneIDShotGuns, Main.S.aimbotSmoothValueShotGuns);

                     if (G.Engine.LocalPlayer.IsMachineGun(WeaponID) && Main.S.AimbotEnabledMachineGuns)
                         UseAimbot(activeweapon, Main.S.AimbotEnabledMachineGuns, Main.S.AimbotSpottedByMaskMachineGuns, Main.S.RecoilPredictionEnabledMachineGuns, Main.S.aimbotSmoothMachineGuns, Main.S.SmartAimbotMachineGuns, Main.S.SilentAImEnabled, Main.S.ShootteammatesEnabled, Main.S.ClosesBoneAimbotEnabled, Main.S.DrawDisplayFovAimbotValueMachineGuns, Main.S.AimbotBoneIDMachineGuns, Main.S.aimbotSmoothValueMachineGuns);

                     if (G.Engine.LocalPlayer.IsMP(WeaponID) && Main.S.AimbotEnabledSMG) // SMG
                         UseAimbot(activeweapon, Main.S.AimbotEnabledSMG, Main.S.AimbotSpottedByMaskSMG, Main.S.RecoilPredictionEnabledSMG, Main.S.aimbotSmoothSMG, Main.S.SmartAimbotSMG, Main.S.SilentAImEnabled, Main.S.ShootteammatesEnabled, Main.S.ClosesBoneAimbotEnabled, Main.S.DrawDisplayFovAimbotValueSMG, Main.S.AimbotBoneIDSMG, Main.S.aimbotSmoothValueSMG);
                }
                if (Main.S.KnifeBotEnabled)
                {
                    if (activeweapon == "Knife")
                    {
                        Entity Player = Tools.GetPlayerbyDistance();
                        if (Player.Distance < 81)
                        {
                            Vector2 AimAngle = Tools.CalcAngle(G.Engine.LocalPlayer.EyePosition, Player.HeadPosition);
                            AimAngle = Tools.NormalizeAngles(AimAngle);
                            AimAngle = Tools.ClampAngle(AimAngle);
                            G.Engine.ViewAngles = AimAngle;

                            G.Engine.Shoot();
                            G.Engine.Shoot2();
                        }
                    }
                }
                if (Main.S.ZeusBotEnabled)
                {
                    if (activeweapon == "Unknown")
                    {
                        Entity Player = Tools.GetPlayerbyDistance();
                        int health = Player.Health;
                        Vector2 AimAngle = Tools.CalcAngle(G.Engine.LocalPlayer.EyePosition, Player.HeadPosition);
                        AimAngle = Tools.NormalizeAngles(AimAngle);
                        AimAngle = Tools.ClampAngle(AimAngle);
                        if (Player.Distance < 230 && health < 67)
                        {
                            G.Engine.ViewAngles = AimAngle;

                            G.Engine.Shoot();
                            G.Engine.Shoot2();
                        }
                        if (Player.Distance < 220 && health < 80)
                        {
                            G.Engine.ViewAngles = AimAngle;

                            G.Engine.Shoot();
                            G.Engine.Shoot2();
                        }
                        if (Player.Distance < 210 && health < 90)
                        {
                            G.Engine.ViewAngles = AimAngle;

                            G.Engine.Shoot();
                            G.Engine.Shoot2();
                        }
                        if (Player.Distance < 200 && health < 92)
                        {
                            G.Engine.ViewAngles = AimAngle;

                            G.Engine.Shoot();
                            G.Engine.Shoot2();
                        }
                        if (Player.Distance < 190 && health < 95)
                        {
                            G.Engine.ViewAngles = AimAngle;

                            G.Engine.Shoot();
                            G.Engine.Shoot2();
                        }
                        if (Player.Distance < 185)
                        {
                            G.Engine.ViewAngles = AimAngle;

                            G.Engine.Shoot();
                            G.Engine.Shoot2();
                        }
                    }
                }
                if (Main.S.BunnyhopEnabled)
                {
                    if (Tools.HoldingKey(Keys.VK_SPACE))
                    {
                        if (G.Engine.LocalPlayer.Flags == 257 || G.Engine.LocalPlayer.Flags == 263)
                        {
                            G.Engine.Jump();
                        }
                    }
                }
                if (Main.S.AutoPistolEnabled)
                {
                    if (Tools.HoldingKey(Keys.VK_LBUTTON) && (activeweapon == "Desert Eagle" || activeweapon == "Dual Berettas" || activeweapon == "Dual Berettas"
                        || activeweapon == "Five-SeveN" || activeweapon == "Glock-18" || activeweapon == "Tec-9" || activeweapon == "P2000"
                        || activeweapon == "P250" || activeweapon == "USP-S"))
                    {
                        G.Engine.Shoot();
                    }
                }
                if (Main.S.TriggerbotEnabled)
                {
                    int myteam = G.Engine.LocalPlayer.Team;
                    var crosshairEntity = Tools.GetEntityBaseFromCrosshair(G.Engine.LocalPlayer.CrosshairID);
                    int EntityTeam = Memory.ReadMemory<int>(crosshairEntity + Main.O.netvars.m_iTeamNum);
                    if (EntityTeam != myteam)
                    {
                        Thread.Sleep(Main.S.TriggerbotValue);
                        G.Engine.Shoot();
                    }
                }
                if (Main.S.RageBotEnabled && activeweapon != "Knife" && activeweapon != "C4" && activeweapon != "Incendiary Grenade"
                            && activeweapon != "Molotov" && activeweapon != "Decoy" && activeweapon != "Smoke Grenade" && activeweapon != "Grenade" && activeweapon != "Flashbang")
                {
                    Vector2 AimAngle = new Vector2(89,0);
                    if (Main.S.RageBotLookDownEnabled)
                        G.Engine.ViewAngles = AimAngle;

                    Entity Player = Tools.GetPlayerbyDistance();
                    if (Player != null)
                    {
                        AimAngle = Tools.CalcAngle(G.Engine.LocalPlayer.EyePosition, Player.HeadPosition);
                        Vector2 PunchAngle = G.Engine.LocalPlayer.AimPunchAngle * 2;
                        AimAngle -= PunchAngle;
                        AimAngle = Tools.NormalizeAngles(AimAngle);
                        AimAngle = Tools.ClampAngle(AimAngle);
                        G.Engine.ViewAngles = AimAngle;
                    }
                }
                Thread.Sleep(1);
            }
            void UseAimbot(string activeweapon, bool aimbotenabled, bool AimbotSpottedByMask, bool RecoilPredictionEnabled, bool aimbotSmooth, bool smartaimbot, bool SilentAim, bool ShootTeammates,
                            bool closestbone, int DrawDisplayFovAimbotValue, int AimbotBoneID, int aimbotSmoothValue)
            {
                if (aimbotenabled && Tools.HoldingKey(Keys.VK_LBUTTON) && activeweapon != "Knife" && activeweapon != "C4" && activeweapon != "Incendiary Grenade"
                            && activeweapon != "Molotov" && activeweapon != "Decoy" && activeweapon != "Smoke Grenade" && activeweapon != "Grenade" && activeweapon != "Flashbang")
                {
                if (Main.S.CheckInAirEnabled)
                    if (G.Engine.LocalPlayer.Flags != 263 && G.Engine.LocalPlayer.Flags != 257)
                     { goto End; }
                if (Main.S.CheckFlashedEnabled)
                    if (G.Engine.LocalPlayer.FlashDuration > 1)
                    { goto End; }
                
                    Entity Player = null;
                    if (ShootTeammates)
                    {
                        Player = Tools.GetFovPlayer(DrawDisplayFovAimbotValue);
                    }
                    if (!ShootTeammates)
                    {
                        Player = Tools.GetFovPlayerEnemies(DrawDisplayFovAimbotValue);
                    }
                    Vector2 AimAngle = new Vector2();
                    Vector2 OldAngle = G.Engine.ViewAngles;
                    if (Player != null && Player.SpottedByMask && AimbotSpottedByMask && !Player.Dormant)
                    {
                        if (smartaimbot)
                        {
                            if (Player.Health > 30)
                                AimAngle = Tools.CalcAngle(G.Engine.LocalPlayer.EyePosition, Player.GetBonePosition(AimbotBoneID));
                            if (Player.Health <= 30)
                                AimAngle = Tools.CalcAngle(G.Engine.LocalPlayer.EyePosition, Player.GetBonePosition(6));
                        }
                        if (!smartaimbot)
                        {
                            AimAngle = Tools.CalcAngle(G.Engine.LocalPlayer.EyePosition, Player.GetBonePosition(AimbotBoneID));
                        }
                        if (closestbone)
                        {
                            Vector3 HeadAngle = Player.GetBonePosition(8);
                            Vector3 ChestAngle = Player.GetBonePosition(6);
                            Vector3 StomachAngle = Player.GetBonePosition(5);
                            Vector2 HeadAngle2; HeadAngle2.X = HeadAngle.X; HeadAngle2.Y = HeadAngle.Y;
                            Vector2 ChestAngle2; ChestAngle2.X = ChestAngle.X; ChestAngle2.Y = ChestAngle.Y;
                            Vector2 StomachAngle2; StomachAngle2.X = StomachAngle.X; StomachAngle2.Y = StomachAngle.Y;
                            float Headdis = Vector2.Distance(G.Engine.ViewAngles, HeadAngle2);
                            float Chestdis = Vector2.Distance(G.Engine.ViewAngles, ChestAngle2);
                            float Stomachdis = Vector2.Distance(G.Engine.ViewAngles, StomachAngle2);
                            if (Headdis < Chestdis || Headdis < Stomachdis)
                                AimAngle = Tools.CalcAngle(G.Engine.LocalPlayer.EyePosition, Player.GetBonePosition(8)); ;
                            if (Chestdis < Headdis || Chestdis < Stomachdis)
                                AimAngle = Tools.CalcAngle(G.Engine.LocalPlayer.EyePosition, Player.GetBonePosition(6)); ;
                            if (Stomachdis < Chestdis || Stomachdis < Headdis)
                                AimAngle = Tools.CalcAngle(G.Engine.LocalPlayer.EyePosition, Player.GetBonePosition(5)); ;
                        }
                        if (RecoilPredictionEnabled)
                        {
                            Vector2 PunchAngle = G.Engine.LocalPlayer.AimPunchAngle * 2;
                            AimAngle -= PunchAngle;
                        }
                        AimAngle = Tools.NormalizeAngles(AimAngle);
                        AimAngle = Tools.ClampAngle(AimAngle);
                        if (aimbotSmooth)
                        {
                            var delta = AimAngle - G.Engine.ViewAngles;
                            delta /= aimbotSmoothValue;
                            AimAngle = G.Engine.ViewAngles + delta;
                            Thread.Sleep(1);
                        }
                        AimAngle = Tools.NormalizeAngles(AimAngle);
                        AimAngle = Tools.ClampAngle(AimAngle);
                        G.Engine.ViewAngles = AimAngle;
                        if (SilentAim)
                        {
                            Thread.Sleep(1);
                            G.Engine.ViewAngles = OldAngle;
                        }
                    }
                    if (Player != null && !AimbotSpottedByMask && !Player.Dormant)
                    {
                        if (smartaimbot)
                        {
                            if (Player.Health > 30)
                                AimAngle = Tools.CalcAngle(G.Engine.LocalPlayer.EyePosition, Player.GetBonePosition(AimbotBoneID));
                            if (Player.Health <= 30)
                                AimAngle = Tools.CalcAngle(G.Engine.LocalPlayer.EyePosition, Player.GetBonePosition(6));
                        }
                        if (!smartaimbot)
                        {
                            AimAngle = Tools.CalcAngle(G.Engine.LocalPlayer.EyePosition, Player.GetBonePosition(AimbotBoneID));
                        }
                        if (RecoilPredictionEnabled)
                        {
                            Vector2 PunchAngle = G.Engine.LocalPlayer.AimPunchAngle * 2;
                            AimAngle -= PunchAngle;
                        }
                        AimAngle = Tools.NormalizeAngles(AimAngle);
                        AimAngle = Tools.ClampAngle(AimAngle);
                        if (aimbotSmooth)
                        {
                            var delta = AimAngle - G.Engine.ViewAngles;
                            delta /= aimbotSmoothValue;
                            AimAngle = G.Engine.ViewAngles + delta;
                            Thread.Sleep(1);
                        }
                        AimAngle = Tools.NormalizeAngles(AimAngle);
                        AimAngle = Tools.ClampAngle(AimAngle);
                        G.Engine.ViewAngles = AimAngle;
                        if (SilentAim)
                        {
                            Thread.Sleep(1);
                            G.Engine.ViewAngles = OldAngle;
                        }
                    }
                    End: { }
                }
            }
        }
    }
}
