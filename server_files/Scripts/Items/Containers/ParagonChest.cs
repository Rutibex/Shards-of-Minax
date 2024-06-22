using System;
using System.Collections.Generic;

namespace Server.Items
{
    [Flipable]
    public class ParagonChest : LockableContainer
    {
        private static readonly int[] m_ItemIDs = new int[]
        {
            0x9AB, 0xE40, 0xE41, 0xE7C
        };
        private static readonly int[] m_Hues = new int[]
        {
            0x0, 0x455, 0x47E, 0x89F, 0x8A5, 0x8AB,
            0x966, 0x96D, 0x972, 0x973, 0x979
        };

        private static readonly Type[] m_PredefinedItems = new Type[]
        {
            typeof(Apple),
			typeof(RandomMagicWeapon), // Adjust chance as needed
			typeof(RandomMagicArmor),
			typeof(RandomMagicClothing),
			typeof(RandomMagicClothingX),
			typeof(RandomMagicClothingXA),
			typeof(RandomMagicClothingXB),
			typeof(RandomMagicClothingXC),
			typeof(RandomMagicClothingXD),
			typeof(RandomMagicJewelry),
			typeof(RandomMagicWeaponA),
			typeof(RandomMagicWeaponB),
			typeof(RandomMagicWeaponC),
			typeof(RandomMagicWeaponD),
			typeof(RandomMagicWeaponE),
			typeof(RandomMagicWeaponF),
			typeof(RandomMagicWeaponG),
			typeof(RandomMagicWeaponH),
			typeof(RandomMagicWeaponI),
			typeof(RandomMagicWeaponJ),
			typeof(RandomMagicWeaponK),
			typeof(RandomMagicWeaponL),
			typeof(RandomMagicWeaponM),
			typeof(RandomSkillJewelryA),
			typeof(RandomSkillJewelryAA),
			typeof(RandomSkillJewelryAB),
			typeof(RandomSkillJewelryAC),
			typeof(RandomSkillJewelryAD),
			typeof(RandomSkillJewelryAE),
			typeof(RandomSkillJewelryAF),
			typeof(RandomSkillJewelryAG),
			typeof(RandomSkillJewelryAH),
			typeof(RandomSkillJewelryAI),
			typeof(RandomSkillJewelryAJ),
			typeof(RandomSkillJewelryAK),
			typeof(RandomSkillJewelryAL),
			typeof(RandomSkillJewelryAM),
			typeof(RandomSkillJewelryAN),
			typeof(RandomSkillJewelryAO),
			typeof(RandomSkillJewelryAP),
			typeof(RandomSkillJewelryB),
			typeof(RandomSkillJewelryC),
			typeof(RandomSkillJewelryD),
			typeof(RandomSkillJewelryE),
			typeof(RandomSkillJewelryF),
			typeof(RandomSkillJewelryG),
			typeof(RandomSkillJewelryH),
			typeof(RandomSkillJewelryI),
			typeof(RandomSkillJewelryJ),
			typeof(RandomSkillJewelryK),
			typeof(RandomSkillJewelryL),
			typeof(RandomSkillJewelryM),
			typeof(RandomSkillJewelryN),
			typeof(RandomSkillJewelryO),
			typeof(RandomSkillJewelryP),
			typeof(RandomSkillJewelryQ),
			typeof(RandomSkillJewelryR),
			typeof(RandomSkillJewelryS),
			typeof(RandomSkillJewelryT),
			typeof(RandomSkillJewelryU),
			typeof(RandomSkillJewelryV),
			typeof(RandomSkillJewelryW),
			typeof(RandomSkillJewelryX),
			typeof(RandomSkillJewelryY),
			typeof(RandomSkillJewelryZ),
			typeof(RandomSkillJewelryX),
			typeof(RandomSkillJewelryXA),
			typeof(RandomSkillJewelryXB),
			typeof(RandomSkillJewelryXC),
			typeof(RandomSkillJewelryXD),
			typeof(RandomSkillJewelryXE),
			typeof(RandomSkillJewelryXX),
			typeof(RandomMagicArmor),
			typeof(RandomMagicArmor),
			typeof(RandomMagicArmor),
			typeof(RandomMagicArmor),
			typeof(RandomMagicArmor),
			typeof(RandomMagicArmor),
			typeof(RandomMagicArmor),
			typeof(RandomMagicArmor),
			typeof(RandomMagicArmor),
			typeof(RandomMagicArmor),
			typeof(AlchemyAugmentCrystal),
			typeof(AnatomyAugmentCrystal),
			typeof(AnimalLoreAugmentCrystal),
			typeof(AnimalTamingAugmentCrystal),
			typeof(ArcheryAugmentCrystal),
			typeof(ArmsLoreAugmentCrystal),
			typeof(ArmSlotChangeDeed),
			typeof(BagOfBombs),
			typeof(BagOfHealth),
			typeof(BagOfJuice),
			typeof(BanishingOrb),
			typeof(BanishingRod),
			typeof(BeggingAugmentCrystal),
			typeof(BeltSlotChangeDeed),
			typeof(BlacksmithyAugmentCrystal),
			typeof(BloodSword),
			typeof(BootsOfCommand),
			typeof(BraceletSlotChangeDeed),
			typeof(BushidoAugmentCrystal),
			typeof(CampingAugmentCrystal),
			typeof(CapacityIncreaseDeed),
			typeof(CarpentryAugmentCrystal),
			typeof(CartographyAugmentCrystal),
			typeof(ChestSlotChangeDeed),
			typeof(ChivalryAugmentCrystal),
			typeof(ColdHitAreaCrystal),
			typeof(ColdResistAugmentCrystal),
			typeof(CookingAugmentCrystal),
			typeof(CurseAugmentCrystal),
			typeof(DetectingHiddenAugmentCrystal),
			typeof(DiscordanceAugmentCrystal),
			typeof(DispelAugmentCrystal),
			typeof(EarringSlotChangeDeed),
			typeof(EnergyHitAreaCrystal),
			typeof(EnergyResistAugmentCrystal),
			typeof(FatigueAugmentCrystal),
			typeof(FencingAugmentCrystal),
			typeof(FireballAugmentCrystal),
			typeof(FireHitAreaCrystal),
			typeof(FireResistAugmentCrystal),
			typeof(FishingAugmentCrystal),
			typeof(FletchingAugmentCrystal),
			typeof(FocusAugmentCrystal),
			typeof(FootwearSlotChangeDeed),
			typeof(ForensicEvaluationAugmentCrystal),
			typeof(GlovesOfCommand),
			typeof(HarmAugmentCrystal),
			typeof(HeadSlotChangeDeed),
			typeof(HealingAugmentCrystal),
			typeof(HerdingAugmentCrystal),
			typeof(HidingAugmentCrystal),
			typeof(ImbuingAugmentCrystal),
			typeof(InscriptionAugmentCrystal),
			typeof(ItemIdentificationAugmentCrystal),
			typeof(JesterHatOfCommand),
			typeof(LegsSlotChangeDeed),
			typeof(LifeLeechAugmentCrystal),
			typeof(LightningAugmentCrystal),
			typeof(LockpickingAugmentCrystal),
			typeof(LowerAttackAugmentCrystal),
			typeof(LuckAugmentCrystal),
			typeof(LumberjackingAugmentCrystal),
			typeof(MaceFightingAugmentCrystal),
			typeof(MageryAugmentCrystal),
			typeof(ManaDrainAugmentCrystal),
			typeof(ManaLeechAugmentCrystal),
			typeof(MaxxiaScroll),
			typeof(MeditationAugmentCrystal),
			typeof(MiningAugmentCrystal),
			typeof(MirrorOfKalandra),
			typeof(MusicianshipAugmentCrystal),
			typeof(NeckSlotChangeDeed),
			typeof(NecromancyAugmentCrystal),
			typeof(NinjitsuAugmentCrystal),
			typeof(OneHandedTransformDeed),
			typeof(ParryingAugmentCrystal),
			typeof(PeacemakingAugmentCrystal),
			typeof(PhysicalHitAreaCrystal),
			typeof(PhysicalResistAugmentCrystal),
			typeof(PlateLeggingsOfCommand),
			typeof(PoisonHitAreaCrystal),
			typeof(PoisoningAugmentCrystal),
			typeof(PoisonResistAugmentCrystal),
			typeof(ProvocationAugmentCrystal),
			typeof(RemoveTrapAugmentCrystal),
			typeof(ResistingSpellsAugmentCrystal),
			typeof(RingSlotChangeDeed),
			typeof(RodOfOrcControl),
			typeof(ShirtSlotChangeDeed),
			typeof(SnoopingAugmentCrystal),
			typeof(SpellweavingAugmentCrystal),
			typeof(SpiritSpeakAugmentCrystal),
			typeof(StaminaLeechAugmentCrystal),
			typeof(StealingAugmentCrystal),
			typeof(StealthAugmentCrystal),
			typeof(SwingSpeedAugmentCrystal),
			typeof(SwordsmanshipAugmentCrystal),
			typeof(TacticsAugmentCrystal),
			typeof(TailoringAugmentCrystal),
			typeof(TalismanSlotChangeDeed),
			typeof(TasteIDAugmentCrystal),
			typeof(ThrowingAugmentCrystal),
			typeof(TinkeringAugmentCrystal),
			typeof(TrackingAugmentCrystal),
			typeof(VeterinaryAugmentCrystal),
			typeof(WeaponSpeedAugmentCrystal),
			typeof(WrestlingAugmentCrystal),
			typeof(PetSlotDeed),
			typeof(PetBondDeed),
			typeof(SkillOrb),
			typeof(StatCapOrb),
			typeof(SkillOrb),
			typeof(StatCapOrb),
			typeof(SkillOrb),
			typeof(StatCapOrb),
			typeof(SkillOrb),
			typeof(StatCapOrb),
			typeof(SkillOrb),
			typeof(StatCapOrb),
			typeof(SkillOrb),
			typeof(StatCapOrb),
			typeof(SkillOrb),
			typeof(StatCapOrb),
			typeof(SkillOrb),
			typeof(StatCapOrb),
			typeof(SkillOrb),
			typeof(StatCapOrb),
			typeof(SkillOrb),
			typeof(StatCapOrb),
			typeof(SkillOrb),
			typeof(StatCapOrb),
			typeof(SkillOrb),
			typeof(StatCapOrb),
			typeof(SkillOrb),
			typeof(StatCapOrb),
			typeof(SkillOrb),
			typeof(StatCapOrb),
			typeof(SkillOrb),
			typeof(StatCapOrb),
			typeof(SkillOrb),
			typeof(StatCapOrb),
			typeof(SkillOrb),
			typeof(StatCapOrb),
			typeof(SkillOrb),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(MaxxiaScroll),
			typeof(AbysmalHorrorSummoningMateria),
			typeof(AcidElementalSummoningMateria),
			typeof(AgapiteElementalSummoningMateria),
			typeof(AirElementalSummoningMateria),
			typeof(AlligatorSummoningMateria),
			typeof(AncientLichSummoningMateria),
			typeof(AncientWyrmSummoningMateria),
			typeof(AntLionSummoningMateria),
			typeof(ArcaneDaemonSummoningMateria),
			typeof(ArcticOgreLordSummoningMateria),
			typeof(AxeBreathMateria),
			typeof(AxeCircleMateria),
			typeof(AxeLineMateria),
			typeof(BakeKitsuneSummoningMateria),
			typeof(BalronSummoningMateria),
			typeof(BarracoonSummoningMateria),
			typeof(BeeBreathMateria),
			typeof(BeeCircleMateria),
			typeof(BeeLineMateria),
			typeof(BeetleSummoningMateria),
			typeof(BlackBearSummoningMateria),
			typeof(BlackDragoonPirateMateria),
			typeof(BlackSolenInfiltratorQueenSummoningMateria),
			typeof(BlackSolenInfiltratorWarriorMateria),
			typeof(BlackSolenQueenSummoningMateria),
			typeof(BlackSolenWarriorSummoningMateria),
			typeof(BlackSolenWorkerSummoningMateria),
			typeof(BladesBreathMateria),
			typeof(BladesCircleMateria),
			typeof(BladesLineMateria),
			typeof(BloodElementalSummoningGem),
			typeof(BloodSwarmGem),
			typeof(BoarSummoningMateria),
			typeof(BogleSummoningMateria),
			typeof(BoglingSummoningMateria),
			typeof(BogThingSummoningMateria),
			typeof(BoneDemonSummoningMateria),
			typeof(BoneKnightSummoningMateria),
			typeof(BoneMagiSummoningMateria),
			typeof(BoulderBreathMateria),
			typeof(BoulderCircleMateria),
			typeof(BoulderLineMateria),
			typeof(BrigandSummoningMateria),
			typeof(BronzeElementalSummoningMateria),
			typeof(BrownBearSummoningMateria),
			typeof(BullFrogSummoningMateria),
			typeof(BullSummoningMateria),
			typeof(CatSummoningMateria),
			typeof(CentaurSummoningMateria),
			typeof(ChaosDaemonSummoningMateria),
			typeof(ChaosDragoonEliteSummoningMateria),
			typeof(ChaosDragoonSummoningMateria),
			typeof(ChickenSummoningMateria),
			typeof(CopperElementalSummoningMateria),
			typeof(CorpserSummoningMateria),
			typeof(CorrosiveSlimeSummoningMateria),
			typeof(CorruptedSoulMateria),
			typeof(CougarSummoningMateria),
			typeof(CowSummoningMateria),
			typeof(CraneSummoningMateria),
			typeof(CrankBreathMateria),
			typeof(CrankCircleMateria),
			typeof(CrankLineMateria),
			typeof(CrimsonDragonSummoningMateria),
			typeof(CrystalElementalSummoningMateria),
			typeof(CurtainBreathMateria),
			typeof(CurtainCircleMateria),
			typeof(CurtainLineMateria),
			typeof(CuSidheSummoningMateria),
			typeof(CyclopsSummoningMateria),
			typeof(DaemonSummoningMateria),
			typeof(DarkWispSummoningMateria),
			typeof(DarkWolfSummoningMateria),
			typeof(DeathWatchBeetleSummoningMateria),
			typeof(DeepSeaSerpentSummoningMateria),
			typeof(DeerBreathMateria),
			typeof(DeerCircleMateria),
			typeof(DeerLineMateria),
			typeof(DemonKnightSummoningMateria),
			typeof(DesertOstardSummoningMateria),
			typeof(DevourerSummoningMateria),
			typeof(DireWolfSummoningMateria),
			typeof(DogSummoningMateria),
			typeof(DolphinSummoningMateria),
			typeof(DopplegangerSummoningMateria),
			typeof(DragonSummoningMateria),
			typeof(DrakeSummoningMateria),
			typeof(DreadSpiderSummoningMateria),
			typeof(DullCopperElementalSummoningMateria),
			typeof(DVortexBreathMateria),
			typeof(DVortexCircleMateria),
			typeof(DVortexLineMateria),
			typeof(EagleSummoningMateria),
			typeof(EarthElementalSummoningMateria),
			typeof(EfreetSummoningMateria),
			typeof(ElderGazerSummoningMateria),
			typeof(EliteNinjaSummoningMateria),
			typeof(EttinSummoningMateria),
			typeof(EvilHealerSummoningMateria),
			typeof(EvilMageSummoningMateria),
			typeof(ExecutionerMateria),
			typeof(ExodusMinionSummoningMateria),
			typeof(ExodusOverseerSummoningMateria),
			typeof(FanDancerSummoningMateria),
			typeof(FeralTreefellowSummoningMateria),
			typeof(FetidEssenceMateria),
			typeof(FireBeetleSummoningMateria),
			typeof(FireElementalSummoningMateria),
			typeof(FireGargoyleSummoningMateria),
			typeof(FireSteedSummoningMateria),
			typeof(FlaskBreathMateria),
			typeof(FlaskCircleMateria),
			typeof(FlaskLineMateria),
			typeof(FleshGolemSummoningMateria),
			typeof(FleshRendererSummoningMateria),
			typeof(ForestOstardSummoningMateria),
			typeof(FrenziedOstardSummoningMateria),
			typeof(FrostOozeSummoningMateria),
			typeof(FrostSpiderSummoningMateria),
			typeof(FrostTrollSummoningMateria),
			typeof(FTreeCircleMateria),
			typeof(FTreeLineMateria),
			typeof(GamanSummoningMateria),
			typeof(GargoyleSummoningMateria),
			typeof(GasBreathMateria),
			typeof(GasCircleMateria),
			typeof(GasLineMateria),
			typeof(GateBreathMateria),
			typeof(GateCircleMateria),
			typeof(GateLineMateria),
			typeof(GazerSummoningMateria),
			typeof(GhoulSummoningMateria),
			typeof(GiantBlackWidowSummoningMateria),
			typeof(GiantRatSummoningMateria),
			typeof(GiantSerpentSummoningMateria),
			typeof(GiantSpiderSummoningMateria),
			typeof(GiantToadSummoningMateria),
			typeof(GibberlingSummoningMateria),
			typeof(GlowBreathMateria),
			typeof(GlowCircleMateria),
			typeof(GlowLineMateria),
			typeof(GoatSummoningMateria),
			typeof(GoldenElementalSummoningMateria),
			typeof(GolemSummoningMateria),
			typeof(GoreFiendSummoningMateria),
			typeof(GorillaSummoningMateria),
			typeof(GreaterDragonSummoningMateria),
			typeof(GreaterMongbatSummoningMateria),
			typeof(GreatHartSummoningMateria),
			typeof(GreyWolfSummoningMateria),
			typeof(GrizzlyBearSummoningMateria),
			typeof(GuillotineBreathMateria),
			typeof(GuillotineCircleMateria),
			typeof(GuillotineLineMateria),
			typeof(HarpySummoningMateria),
			typeof(HeadBreathMateria),
			typeof(HeadCircleMateria),
			typeof(HeadlessOneSummoningMateria),
			typeof(HeadLineMateria),
			typeof(HealerMateria),
			typeof(HeartBreathMateria),
			typeof(HeartCircleMateria),
			typeof(HeartLineMateria),
			typeof(HellCatSummoningMateria),
			typeof(HellHoundSummoningMateria),
			typeof(HellSteedSummoningMateria),
			typeof(HindSummoningMateria),
			typeof(HiryuSummoningMateria),
			typeof(HorseSummoningMateria),
			typeof(IceElementalSummoningMateria),
			typeof(IceFiendSummoningMateria),
			typeof(IceSerpentSummoningMateria),
			typeof(IceSnakeSummoningMateria),
			typeof(ImpSummoningMateria),
			typeof(JackRabbitSummoningMateria),
			typeof(KazeKemonoSummoningMateria),
			typeof(KirinSummoningMateria),
			typeof(LavaLizardSummoningMateria),
			typeof(LavaSerpentSummoningMateria),
			typeof(LavaSnakeSummoningMateria),
			typeof(LesserHiryuSummoningMateria),
			typeof(LichLordSummoningMateria),
			typeof(LichSummoningMateria),
			typeof(LizardmanSummoningMateria),
			typeof(LlamaSummoningMateria),
			typeof(MaidenBreathMateria),
			typeof(MaidenCircleMateria),
			typeof(MaidenLineMateria),
			typeof(MinotaurCaptainSummoningMateria),
			typeof(MountainGoatSummoningMateria),
			typeof(MummySummoningMateria),
			typeof(MushroomBreathMateria),
			typeof(MushroomCircleMateria),
			typeof(MushroomLineMateria),
			typeof(NightmareSummoningMateria),
			typeof(NutcrackerBreathMateria),
			typeof(NutcrackerCircleMateria),
			typeof(NutcrackerLineMateria),
			typeof(OFlaskBreathMateria),
			typeof(OFlaskCircleMateria),
			typeof(OFlaskMateria),
			typeof(OgreLordSummoningMateria),
			typeof(OgreSummoningMateria),
			typeof(OniSummoningMateria),
			typeof(OphidianArchmageSummoningMateria),
			typeof(OphidianKnightSummoningMateria),
			typeof(OrcBomberSummoningMateria),
			typeof(OrcBruteSummoningMateria),
			typeof(OrcCaptainSummoningMateria),
			typeof(OrcishLordSummoningMateria),
			typeof(OrcishMageSummoningMateria),
			typeof(OrcSummoningMateria),
			typeof(PackHorseSummoningMateria),
			typeof(PackLlamaSummoningMateria),
			typeof(PantherSummoningMateria),
			typeof(ParaBreathMateria),
			typeof(ParaCircleMateria),
			typeof(ParaLineMateria),
			typeof(PhoenixSummoningMateria),
			typeof(PigSummoningMateria),
			typeof(PixieSummoningMateria),
			typeof(PlagueBeastSummoningMateria),
			typeof(PoisonElementalSummoningMateria),
			typeof(PolarBearSummoningMateria),
			typeof(RabbitSummoningMateria),
			typeof(RaiJuSummoningMateria),
			typeof(RatmanArcherSummoningMateria),
			typeof(RatmanMageSummoningMateria),
			typeof(RatmanSummoningMateria),
			typeof(RatSummoningMateria),
			typeof(ReaperSummoningMateria),
			typeof(RevenantSummoningMateria),
			typeof(RidgebackSummoningMateria),
			typeof(RikktorSummoningMateria),
			typeof(RoninSummoningMateria),
			typeof(RuneBeetleSummoningMateria),
			typeof(RuneBreathMateria),
			typeof(RuneCircleMateria),
			typeof(RuneLineMateria),
			typeof(SatyrSummoningMateria),
			typeof(SavageShamanSummoningMateria),
			typeof(SavageSummoningMateria),
			typeof(SawBreathMateria),
			typeof(SawCircleMateria),
			typeof(SawLineMateria),
			typeof(ScaledSwampDragonSummoningMateria),
			typeof(ScorpionSummoningMateria),
			typeof(SeaSerpentSummoningMateria),
			typeof(ShadowWispSummoningMateria),
			typeof(ShadowWyrmSummoningMateria),
			typeof(SheepSummoningMateria),
			typeof(SilverSerpentSummoningMateria),
			typeof(SilverSteedSummoningMateria),
			typeof(SkeletalDragonSummoningMateria),
			typeof(SkeletalKnightSummoningMateria),
			typeof(SkeletalMageSummoningMateria),
			typeof(SkeletalMountSummoningMateria),
			typeof(SkeletonBreathMateria),
			typeof(SkeletonCircleMateria),
			typeof(SkeletonLineMateria),
			typeof(SkeletonSummoningMateria),
			typeof(SkullBreathMateria),
			typeof(SkullCircleMateria),
			typeof(SkullLineMateria),
			typeof(SlimeSummoningMateria),
			typeof(SmokeBreathMateria),
			typeof(SmokeCircleMateria),
			typeof(SmokeLineMateria),
			typeof(SnakeSummoningMateria),
			typeof(SnowElementalSummoningMateria),
			typeof(SnowLeopardSummoningMateria),
			typeof(SocketDeed),
			typeof(SocketDeed1),
			typeof(SocketDeed2),
			typeof(SocketDeed3),
			typeof(SocketDeed4),
			typeof(SocketDeed5),
			typeof(SparkleBreathMateria),
			typeof(SparkleCircleMateria),
			typeof(SparkleLineMateria),
			typeof(SpikeBreathMateria),
			typeof(SpikeCircleMateria),
			typeof(SpikeLineMateria),
			typeof(StoneBreathMateria),
			typeof(StoneCircleMateria),
			typeof(StoneLineMateria),
			typeof(SuccubusSummoningMateria),
			typeof(TimeBreathMateria),
			typeof(TimeCircleMateria),
			typeof(TimeLineMateria),
			typeof(TitanSummoningMateria),
			typeof(ToxicElementalSummoningMateria),
			typeof(TrapBreathMateria),
			typeof(TrapCircleMateria),
			typeof(TrapLineMateria),
			typeof(TreeBreathMateria),
			typeof(TroglodyteSummoningMateria),
			typeof(TrollSummoningMateria),
			typeof(UnicornSummoningMateria),
			typeof(ValoriteElementalSummoningMateria),
			typeof(VampireBatSummoningMateria),
			typeof(VeriteElementalSummoningMateria),
			typeof(VortexBreathMateria),
			typeof(VortexCircleMateria),
			typeof(VortexLineMateria),
			typeof(WalrusSummoningMateria),
			typeof(WaterBreathMateria),
			typeof(WaterCircleMateria),
			typeof(WaterElementalSummoningMateria),
			typeof(WaterLineMateria),
			typeof(WhiteWolfSummoningMateria),
			typeof(WhiteWyrmSummoningMateria),
			typeof(WispSummoningMateria),
			typeof(WraithSummoningMateria),
			typeof(WyvernSummoningMateria),
			typeof(ZombieSummoningMateria),
			typeof(MythicAmethyst),
			typeof(LegendaryAmethyst),
			typeof(AncientAmethyst),
			typeof(FenCrystal),
			typeof(RhoCrystal),
			typeof(RysCrystal),
			typeof(WyrCrystal),
			typeof(FreCrystal),
			typeof(TorCrystal),
			typeof(VelCrystal),
			typeof(XenCrystal),
			typeof(PolCrystal),
			typeof(WolCrystal),
			typeof(BalCrystal),
			typeof(TalCrystal),
			typeof(JalCrystal),
			typeof(RalCrystal),
			typeof(KalCrystal),
			typeof(MythicDiamond),
			typeof(LegendaryDiamond),
			typeof(AncientDiamond),
			typeof(MythicEmerald),
			typeof(LegendaryEmerald),
			typeof(AncientEmerald),
			typeof(KeyAugment),
			typeof(RadiantRhoCrystal),
			typeof(RadiantRysCrystal),
			typeof(RadiantWyrCrystal),
			typeof(RadiantFreCrystal),
			typeof(RadiantTorCrystal),
			typeof(RadiantVelCrystal),
			typeof(RadiantXenCrystal),
			typeof(RadiantPolCrystal),
			typeof(RadiantWolCrystal),
			typeof(RadiantBalCrystal),
			typeof(RadiantTalCrystal),
			typeof(RadiantJalCrystal),
			typeof(RadiantRalCrystal),
			typeof(RadiantKalCrystal),
			typeof(MythicRuby),
			typeof(LegendaryRuby),
			typeof(AncientRuby),
			typeof(TyrRune),
			typeof(AhmRune),
			typeof(MorRune),
			typeof(MefRune),
			typeof(YlmRune),
			typeof(KotRune),
			typeof(JorRune),
			typeof(MythicSapphire),
			typeof(LegendarySapphire),
			typeof(AncientSapphire),
			typeof(MythicSkull),
			typeof(AncientSkull),
			typeof(LegendarySkull),
			typeof(GlimmeringGranite),
			typeof(GlimmeringClay),
			typeof(GlimmeringHeartstone),
			typeof(GlimmeringGypsum),
			typeof(GlimmeringIronOre),
			typeof(GlimmeringOnyx),
			typeof(GlimmeringMarble),
			typeof(GlimmeringPetrifiedWood),
			typeof(GlimmeringLimestone),
			typeof(GlimmeringBloodrock),
			typeof(MythicTourmaline),
			typeof(LegendaryTourmaline),
			typeof(AncientTourmaline),
			typeof(MythicWood),
			typeof(LegendaryWood),
			typeof(AncientWood),
			// Replace with your list of items
            // Add other items here
        };

        private string m_Name;

        [Constructable]
        public ParagonChest(string name, int level)
            : base(Utility.RandomList(m_ItemIDs))
        {
            m_Name = name;
            Hue = Utility.RandomList(m_Hues);
            Fill(level);
        }

        public ParagonChest(Serial serial)
            : base(serial)
        {
        }

        public override void OnSingleClick(Mobile from)
        {
            LabelTo(from, 1063449, m_Name);
        }

        public override void GetProperties(ObjectPropertyList list)
        {
            base.GetProperties(list);
            list.Add(1063449, m_Name);
        }

        public void Flip()
        {
            switch (ItemID)
            {
                case 0x9AB:
                    ItemID = 0xE7C;
                    break;
                case 0xE7C:
                    ItemID = 0x9AB;
                    break;
                case 0xE40:
                    ItemID = 0xE41;
                    break;
                case 0xE41:
                    ItemID = 0xE40;
                    break;
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0); // version
            writer.Write(m_Name);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
            m_Name = Utility.Intern(reader.ReadString());
        }

        private static void GetRandomAOSStats(out int attributeCount, out int min, out int max)
        {
            int rnd = Utility.Random(15);

            if (rnd < 1)
            {
                attributeCount = Utility.RandomMinMax(2, 6);
                min = 20;
                max = 70;
            }
            else if (rnd < 3)
            {
                attributeCount = Utility.RandomMinMax(2, 4);
                min = 20;
                max = 50;
            }
            else if (rnd < 6)
            {
                attributeCount = Utility.RandomMinMax(2, 3);
                min = 20;
                max = 40;
            }
            else if (rnd < 10)
            {
                attributeCount = Utility.RandomMinMax(1, 2);
                min = 10;
                max = 30;
            }
            else
            {
                attributeCount = 1;
                min = 10;
                max = 20;
            }
        }

        private void Fill(int level)
        {
            TrapType = TrapType.ExplosionTrap;
            TrapPower = level * 25;
            TrapLevel = level;
            Locked = true;

            switch (level)
            {
                case 1:
                    RequiredSkill = 36;
                    break;
                case 2:
                    RequiredSkill = 76;
                    break;
                case 3:
                    RequiredSkill = 84;
                    break;
                case 4:
                    RequiredSkill = 92;
                    break;
                case 5:
                    RequiredSkill = 100;
                    break;
                case 6:
                    RequiredSkill = 100;
                    break;
            }

            LockLevel = RequiredSkill - 10;
            MaxLockLevel = RequiredSkill + 40;

            DropItem(new Gold(level * 200));

            for (int i = 0; i < level; ++i)
                DropItem(Loot.RandomScroll(0, 63, SpellbookType.Regular));

            for (int i = 0; i < level * 2; ++i)
            {
                Item item;

                if (Core.AOS)
                    item = Loot.RandomArmorOrShieldOrWeaponOrJewelry();
                else
                    item = Loot.RandomArmorOrShieldOrWeapon();

                if (item != null && Core.HS && RandomItemGenerator.Enabled)
                {
                    int min, max;
                    TreasureMapChest.GetRandomItemStat(out min, out max);

                    RunicReforging.GenerateRandomItem(item, 0, min, max);

                    DropItem(item);
                    continue;
                }

                if (item is BaseWeapon)
                {
                    BaseWeapon weapon = (BaseWeapon)item;

                    if (Core.AOS)
                    {
                        int attributeCount;
                        int min, max;

                        GetRandomAOSStats(out attributeCount, out min, out max);

                        BaseRunicTool.ApplyAttributesTo(weapon, attributeCount, min, max);
                    }
                    else
                    {
                        weapon.DamageLevel = (WeaponDamageLevel)Utility.Random(6);
                        weapon.AccuracyLevel = (WeaponAccuracyLevel)Utility.Random(6);
                        weapon.DurabilityLevel = (WeaponDurabilityLevel)Utility.Random(6);
                    }

                    DropItem(item);
                }
                else if (item is BaseArmor)
                {
                    BaseArmor armor = (BaseArmor)item;

                    if (Core.AOS)
                    {
                        int attributeCount;
                        int min, max;

                        GetRandomAOSStats(out attributeCount, out min, out max);

                        BaseRunicTool.ApplyAttributesTo(armor, attributeCount, min, max);
                    }
                    else
                    {
                        armor.ProtectionLevel = (ArmorProtectionLevel)Utility.Random(6);
                        armor.Durability = (ArmorDurabilityLevel)Utility.Random(6);
                    }

                    DropItem(item);
                }
                else if (item is BaseHat)
                {
                    BaseHat hat = (BaseHat)item;

                    if (Core.AOS)
                    {
                        int attributeCount;
                        int min, max;

                        GetRandomAOSStats(out attributeCount, out min, out max);

                        BaseRunicTool.ApplyAttributesTo(hat, attributeCount, min, max);
                    }

                    DropItem(item);
                }
                else if (item is BaseJewel)
                {
                    int attributeCount;
                    int min, max;

                    GetRandomAOSStats(out attributeCount, out min, out max);

                    BaseRunicTool.ApplyAttributesTo((BaseJewel)item, attributeCount, min, max);

                    DropItem(item);
                }
            }

            for (int i = 0; i < level; i++)
            {
                Item item = Loot.RandomPossibleReagent();
                item.Amount = Utility.RandomMinMax(40, 60);
                DropItem(item);
            }

            for (int i = 0; i < level; i++)
            {
                Item item = Loot.RandomGem();
                DropItem(item);
            }

            DropItem(new TreasureMap(level + 1, (Siege.SiegeShard ? Map.Felucca : Utility.RandomBool() ? Map.Felucca : Map.Trammel)));

            // Adding 3 random items from predefined list
            AddRandomPredefinedItems();
        }

        private void AddRandomPredefinedItems()
        {
            for (int i = 0; i < 3; i++)
            {
                Type itemType = m_PredefinedItems[Utility.Random(m_PredefinedItems.Length)];
                Item item = (Item)Activator.CreateInstance(itemType);
                DropItem(item);
            }
        }
    }
}
