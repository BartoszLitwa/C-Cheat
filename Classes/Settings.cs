using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ZBase.Classes
{
    public class Settings
    {
        public bool BunnyhopEnabled { get; set; }
        public bool ESP { get; set; }
        public float WielkoscFont { get; set; }
        public bool ESPBoxEnabled { get; set; }
        public bool BoxTeammates { get; set; }
        public int TypeOfESPBOX { get; set; }
        public int TypeOfCrosshair { get; set; }
        public bool DrawSmartCrosshairEnabled { get; set; }
        public bool BoneEnabled { get; set; }
        public bool BoneTeammates { get; set; }
        public int BoneESPMap { get; set; }
        public bool DrawDefuseCountDown { get; set; }
        public bool DrawWeaponESP { get; set; }
        public bool DrawInReload { get; set; }
        public bool DrawSnaplines { get; set; }
        public string SnapLinesPos { get; set; }
        public bool SnapLinesTeammates { get; set; }
        public int SnaplinesValue { get; set; }
        public bool DrawHealthBar { get; set; }
        public bool DrawHealthString { get; set; }
        public bool DrawWeaponString { get; set; }
        public bool DrawHealthBarLeftSide { get; set; }
        public bool DrawArmorBar { get; set; }
        public bool DrawAimspotEnabled { get; set; }
        public bool DrawBoneIDs { get; set; }
        public bool CrosshairSniperEnabled { get; set; }
        public bool DrawDistanceString { get; set; }
        ///////////////////////////////////////////////////////
        public bool GlowEnabled { get; set; }
        public int GlowValue { get; set; }
        public bool GlowTeammates { get; set; }
        public bool GlowPlayers { get; set; }
        public bool GlowAK47 { get; set; }
        public bool GlowDeagle { get; set; }
        public bool GlowAUG { get; set; }
        public bool GlowAWP { get; set; }
        public bool GlowBerettas { get; set; }
        public bool GlowBizon { get; set; }
        public bool GlowC4 { get; set; }
        public bool GlowChicken { get; set; }
        public bool GlowFamas { get; set; }
        public bool GlowFiveSeven { get; set; }
        public bool GlowG3SG1 { get; set; }
        public bool GlowGalil { get; set; }
        public bool GlowGlock18 { get; set; }
        public bool GlowM249 { get; set; }
        public bool GlowM4 { get; set; }
        public bool GlowMac10 { get; set; }
        public bool GlowMag7 { get; set; }
        public bool GlowMP5 { get; set; }
        public bool GlowMP7 { get; set; }
        public bool GlowMP9 { get; set; }
        public bool GlowNegev { get; set; }
        public bool GlowNova { get; set; }
        public bool GlowP2000 { get; set; }
        public bool GlowP250 { get; set; }
        public bool GlowP90 { get; set; }
        public bool GlowSawedOff { get; set; }
        public bool GlowSCAR20 { get; set; }
        public bool GlowSSG08 { get; set; }
        public bool GlowTec9 { get; set; }
        public bool GlowUMP45 { get; set; }
        public bool GlowXM1014 { get; set; }
        public bool GlowCZ75 { get; set; }
        public bool GlowTaser { get; set; }
        public bool GlowHEGrenade { get; set; }
        public bool GlowMolo { get; set; }
        public bool GlowDecoy { get; set; }
        public bool GlowSmoke { get; set; }
        public bool GlowFlash { get; set; }
        ///////////////////////////////////////////////////////
        public bool NoHandsEnabled { get; set; }
        public bool SkinChangerEnabled { get; set; }
        public bool KnifeChangerEnabled { get; set; }
        public string SelectedKnife { get; set; }
        public bool RecoilCrosshairEnabled { get; set; }
        public bool RecoilControlSystemEnabled { get; set; }
        public bool ForceFullUpdate { get; set; }
        public bool RCSEnabled { get; set; }
        public int RCSValue { get; set; }
        public bool FAKELAGEnabled { get; set; }
        public int FAKELAGValue { get; set; }
        public bool THIRDPERSONEnabled { get; set; }
        public bool RadarHackEnabled { get; set; }
        public bool TriggerbotEnabled { get; set; }
        public int TriggerbotValue { get; set; }
        public bool ChamsEnabled { get; set; }
        public int ChamsValue { get; set; }
        public bool ChamsTeammates { get; set; }
        public bool AntiFlashEnabled { get; set; }
        public int AntiFlashAlpha { get; set; }
        public bool FOVEnabled { get; set; }
        public int FOVValue { get; set; }
        public bool AutoPistolEnabled { get; set; }
        public bool DrawScopedEnabled { get; set; }
        public bool NightMode { get; set; }
        public bool AntiAimEnabled { get; set; }
        public int AimbotTypeofGun { get; set; }
        public bool KnifeBotEnabled { get; set; }
        public bool ZeusBotEnabled { get; set; }
        public bool SilentAImEnabled { get; set; }
        public bool ShootteammatesEnabled { get; set; }
        public bool RageBotEnabled { get; set; }
        public bool RageBotLookDownEnabled { get; set; }
        public bool ClosesBoneAimbotEnabled { get; set; }
        public bool CheckFlashedEnabled { get; set; }
        public bool CheckInAirEnabled { get; set; }
        ////////////////////////////////////////////////////
        public bool AimbotEnabledRifle { get; set; }
        public bool DrawDisplayFovAimbotRifle { get; set; }
        public int DrawDisplayFovAimbotValueRifle { get; set; }
        public int AimbotValueRifle { get; set; }
        public int AimbotBoneIDRifle { get; set; }
        public bool AimbotSpottedByMaskRifle { get; set; }
        public bool RecoilPredictionEnabledRifle { get; set; }
        public bool aimbotSmoothRifle { get; set; }
        public int aimbotSmoothValueRifle { get; set; }
        public bool SmartAimbotRifle { get; set; }
        ////////////////////////////////////////////////////
        public bool AimbotEnabledPistols { get; set; }
        public bool DrawDisplayFovAimbotPistols { get; set; }
        public int DrawDisplayFovAimbotValuePistols { get; set; }
        public int AimbotValuePistols { get; set; }
        public int AimbotBoneIDPistols { get; set; }
        public bool AimbotSpottedByMaskPistols { get; set; }
        public bool RecoilPredictionEnabledPistols { get; set; }
        public bool aimbotSmoothPistols { get; set; }
        public int aimbotSmoothValuePistols { get; set; }
        public bool SmartAimbotPistols { get; set; }
        ////////////////////////////////////////////////////
        public bool AimbotEnabledSnipers { get; set; }
        public bool DrawDisplayFovAimbotSnipers { get; set; }
        public int DrawDisplayFovAimbotValueSnipers { get; set; }
        public int AimbotValueSnipers { get; set; }
        public int AimbotBoneIDSnipers { get; set; }
        public bool AimbotSpottedByMaskSnipers { get; set; }
        public bool RecoilPredictionEnabledSnipers { get; set; }
        public bool aimbotSmoothSnipers { get; set; }
        public int aimbotSmoothValueSnipers { get; set; }
        public bool SmartAimbotSnipers { get; set; }
        ////////////////////////////////////////////////////
        public bool AimbotEnabledShotGuns { get; set; }
        public bool DrawDisplayFovAimbotShotGuns { get; set; }
        public int DrawDisplayFovAimbotValueShotGuns { get; set; }
        public int AimbotValueShotGuns { get; set; }
        public int AimbotBoneIDShotGuns { get; set; }
        public bool AimbotSpottedByMaskShotGuns { get; set; }
        public bool RecoilPredictionEnabledShotGuns { get; set; }
        public bool aimbotSmoothShotGuns { get; set; }
        public int aimbotSmoothValueShotGuns { get; set; }
        public bool SmartAimbotShotGuns { get; set; }
        ////////////////////////////////////////////////////
        public bool AimbotEnabledMachineGuns { get; set; }
        public bool DrawDisplayFovAimbotMachineGuns { get; set; }
        public int DrawDisplayFovAimbotValueMachineGuns { get; set; }
        public int AimbotValueMachineGuns { get; set; }
        public int AimbotBoneIDMachineGuns { get; set; }
        public bool AimbotSpottedByMaskMachineGuns { get; set; }
        public bool RecoilPredictionEnabledMachineGuns { get; set; }
        public bool aimbotSmoothMachineGuns { get; set; }
        public int aimbotSmoothValueMachineGuns { get; set; }
        public bool SmartAimbotMachineGuns { get; set; }
        ////////////////////////////////////////////////////
        public bool AimbotEnabledSMG { get; set; }
        public bool DrawDisplayFovAimbotSMG { get; set; }
        public int DrawDisplayFovAimbotValueSMG { get; set; }
        public int AimbotValueSMG { get; set; }
        public int AimbotBoneIDSMG { get; set; }
        public bool AimbotSpottedByMaskSMG { get; set; }
        public bool RecoilPredictionEnabledSMG { get; set; }
        public bool aimbotSmoothSMG { get; set; }
        public int aimbotSmoothValueSMG { get; set; }
        public bool SmartAimbotSMG { get; set; }
        /////////////////////////////////////////////////
        public int SkinDeasertEagle { get; set; }
        public int SkinDualBerettas { get; set; }
        public int SkinFiveSeven { get; set; }
        public int SkinGlock18 { get; set; }
        public int SkinAK47 { get; set; }
        public int SkinAUG { get; set; }
        public int SkinAWP { get; set; }
        public int SkinFamas { get; set; }
        public int SkinG3SG1 { get; set; }
        public int SkinGalilAR { get; set; }
        public int SkinM249 { get; set; }
        public int SkinM4A4 { get; set; }
        public int SkinMac10 { get; set; }
        public int SkinP90 { get; set; }
        public int SkinUMP45 { get; set; }
        public int SkinMP5 { get; set; }
        public int SkinXM1014 { get; set; }
        public int SkinPPBizon { get; set; }
        public int SkinMag7 { get; set; }
        public int SkinNegev { get; set; }
        public int SkinSawedOff { get; set; }
        public int SkinTec9 { get; set; }
        public int SkinP2000 { get; set; }
        public int SkinMP7 { get; set; }
        public int SkinMP9 { get; set; }
        public int SkinNova { get; set; }
        public int SkinP250 { get; set; }
        public int SkinSCAR20 { get; set; }
        public int SkinSG553 { get; set; }
        public int SkinSSG08 { get; set; }
        public int SkinM4A1S { get; set; }
        public int SkinUSPS { get; set; }
        public int SkinCZ75 { get; set; }
        ///////////////////////////////////////////////
    }
}
