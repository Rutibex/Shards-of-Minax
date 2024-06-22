// Treasure Chest Pack - Version 0.99I
// By Nerun

using Server;
using Server.Items;
using Server.Multis;
using Server.Network;
using System;

namespace Server.Items
{
    public class CustomLoot
    {
        public static Item[] ItemList = new Item[]
        {
            new Apple(),
            new Apple(),
            new Apple(),
            new Apple(),
            new RandomMagicWeapon(), // Adjust chance as needed
            new RandomMagicArmor(),
            new RandomMagicClothing(),
            new RandomMagicClothingX(),
            new RandomMagicClothingXA(),
            new RandomMagicClothingXB(),
            new RandomMagicClothingXC(),
            new RandomMagicClothingXD(),
            new RandomMagicJewelry(),
            new RandomMagicWeaponA(),
            new RandomMagicWeaponB(),
            new RandomMagicWeaponC(),
            new RandomMagicWeaponD(),
            new RandomMagicWeaponE(),
            new RandomMagicWeaponF(),
            new RandomMagicWeaponG(),
            new RandomMagicWeaponH(),
            new RandomMagicWeaponI(),
            new RandomMagicWeaponJ(),
            new RandomMagicWeaponK(),
            new RandomMagicWeaponL(),
            new RandomMagicWeaponM(),
            new RandomSkillJewelryA(),
            new RandomSkillJewelryAA(),
            new RandomSkillJewelryAB(),
            new RandomSkillJewelryAC(),
            new RandomSkillJewelryAD(),
            new RandomSkillJewelryAE(),
            new RandomSkillJewelryAF(),
            new RandomSkillJewelryAG(),
            new RandomSkillJewelryAH(),
            new RandomSkillJewelryAI(),
            new RandomSkillJewelryAJ(),
            new RandomSkillJewelryAK(),
            new RandomSkillJewelryAL(),
            new RandomSkillJewelryAM(),
            new RandomSkillJewelryAN(),
            new RandomSkillJewelryAO(),
            new RandomSkillJewelryAP(),
            new RandomSkillJewelryB(),
            new RandomSkillJewelryC(),
            new RandomSkillJewelryD(),
            new RandomSkillJewelryE(),
            new RandomSkillJewelryF(),
            new RandomSkillJewelryG(),
            new RandomSkillJewelryH(),
            new RandomSkillJewelryI(),
            new RandomSkillJewelryJ(),
            new RandomSkillJewelryK(),
            new RandomSkillJewelryL(),
            new RandomSkillJewelryM(),
            new RandomSkillJewelryN(),
            new RandomSkillJewelryO(),
            new RandomSkillJewelryP(),
            new RandomSkillJewelryQ(),
            new RandomSkillJewelryR(),
            new RandomSkillJewelryS(),
            new RandomSkillJewelryT(),
            new RandomSkillJewelryU(),
            new RandomSkillJewelryV(),
            new RandomSkillJewelryW(),
            new RandomSkillJewelryX(),
            new RandomSkillJewelryY(),
            new RandomSkillJewelryZ(),
            new RandomSkillJewelryX(),
            new RandomSkillJewelryXA(),
            new RandomSkillJewelryXB(),
            new RandomSkillJewelryXC(),
            new RandomSkillJewelryXD(),
            new RandomSkillJewelryXE(),
            new RandomSkillJewelryXX(),
            new RandomMagicArmor(),
            new RandomMagicArmor(),
            new RandomMagicArmor(),
            new RandomMagicArmor(),
            new RandomMagicArmor(),
            new RandomMagicArmor(),
            new RandomMagicArmor(),
            new RandomMagicArmor(),
            new RandomMagicArmor(),
            new RandomMagicArmor(),
            new AlchemyAugmentCrystal(),
            new AnatomyAugmentCrystal(),
            new AnimalLoreAugmentCrystal(),
            new AnimalTamingAugmentCrystal(),
            new ArcheryAugmentCrystal(),
            new ArmsLoreAugmentCrystal(),
            new ArmSlotChangeDeed(),
            new BagOfBombs(),
            new BagOfHealth(),
            new BagOfJuice(),
            new BanishingOrb(),
            new BanishingRod(),
            new BeggingAugmentCrystal(),
            new BeltSlotChangeDeed(),
            new BlacksmithyAugmentCrystal(),
            new BloodSword(),
            new BootsOfCommand(),
            new BraceletSlotChangeDeed(),
            new BushidoAugmentCrystal(),
            new CampingAugmentCrystal(),
            new CapacityIncreaseDeed(),
            new CarpentryAugmentCrystal(),
            new CartographyAugmentCrystal(),
            new ChestSlotChangeDeed(),
            new ChivalryAugmentCrystal(),
            new ColdHitAreaCrystal(),
            new ColdResistAugmentCrystal(),
            new CookingAugmentCrystal(),
            new CurseAugmentCrystal(),
            new DetectingHiddenAugmentCrystal(),
            new DiscordanceAugmentCrystal(),
            new DispelAugmentCrystal(),
            new EarringSlotChangeDeed(),
            new EnergyHitAreaCrystal(),
            new EnergyResistAugmentCrystal(),
            new FatigueAugmentCrystal(),
            new FencingAugmentCrystal(),
            new FireballAugmentCrystal(),
            new FireHitAreaCrystal(),
            new FireResistAugmentCrystal(),
            new FishingAugmentCrystal(),
            new FletchingAugmentCrystal(),
            new FocusAugmentCrystal(),
            new FootwearSlotChangeDeed(),
            new ForensicEvaluationAugmentCrystal(),
            new GlovesOfCommand(),
            new HarmAugmentCrystal(),
            new HeadSlotChangeDeed(),
            new HealingAugmentCrystal(),
            new HerdingAugmentCrystal(),
            new HidingAugmentCrystal(),
            new ImbuingAugmentCrystal(),
            new InscriptionAugmentCrystal(),
            new ItemIdentificationAugmentCrystal(),
            new JesterHatOfCommand(),
            new LegsSlotChangeDeed(),
            new LifeLeechAugmentCrystal(),
            new LightningAugmentCrystal(),
            new LockpickingAugmentCrystal(),
            new LowerAttackAugmentCrystal(),
            new LuckAugmentCrystal(),
            new LumberjackingAugmentCrystal(),
            new MaceFightingAugmentCrystal(),
            new MageryAugmentCrystal(),
            new ManaDrainAugmentCrystal(),
            new ManaLeechAugmentCrystal(),
            new MaxxiaScroll(),
            new MeditationAugmentCrystal(),
            new MiningAugmentCrystal(),
            new MirrorOfKalandra(),
            new MusicianshipAugmentCrystal(),
            new NeckSlotChangeDeed(),
            new NecromancyAugmentCrystal(),
            new NinjitsuAugmentCrystal(),
            new OneHandedTransformDeed(),
            new ParryingAugmentCrystal(),
            new PeacemakingAugmentCrystal(),
            new PhysicalHitAreaCrystal(),
            new PhysicalResistAugmentCrystal(),
            new PlateLeggingsOfCommand(),
            new PoisonHitAreaCrystal(),
            new PoisoningAugmentCrystal(),
            new PoisonResistAugmentCrystal(),
            new ProvocationAugmentCrystal(),
            new RemoveTrapAugmentCrystal(),
            new ResistingSpellsAugmentCrystal(),
            new RingSlotChangeDeed(),
            new RodOfOrcControl(),
            new ShirtSlotChangeDeed(),
            new SnoopingAugmentCrystal(),
            new SpellweavingAugmentCrystal(),
            new SpiritSpeakAugmentCrystal(),
            new StaminaLeechAugmentCrystal(),
            new StealingAugmentCrystal(),
            new StealthAugmentCrystal(),
            new SwingSpeedAugmentCrystal(),
            new SwordsmanshipAugmentCrystal(),
            new TacticsAugmentCrystal(),
            new TailoringAugmentCrystal(),
            new TalismanSlotChangeDeed(),
            new TasteIDAugmentCrystal(),
            new ThrowingAugmentCrystal(),
            new TinkeringAugmentCrystal(),
            new TrackingAugmentCrystal(),
            new VeterinaryAugmentCrystal(),
            new WeaponSpeedAugmentCrystal(),
            new WrestlingAugmentCrystal(),
            new PetSlotDeed(),
            new PetBondDeed(),
            new SkillOrb(),
            new StatCapOrb(),
            new SkillOrb(),
            new StatCapOrb(),
            new SkillOrb(),
            new StatCapOrb(),
            new SkillOrb(),
            new StatCapOrb(),
            new SkillOrb(),
            new StatCapOrb(),
            new SkillOrb(),
            new StatCapOrb(),
            new SkillOrb(),
            new StatCapOrb(),
            new SkillOrb(),
            new StatCapOrb(),
            new SkillOrb(),
            new StatCapOrb(),
            new SkillOrb(),
            new StatCapOrb(),
            new SkillOrb(),
            new StatCapOrb(),
            new SkillOrb(),
            new StatCapOrb(),
            new SkillOrb(),
            new StatCapOrb(),
            new SkillOrb(),
            new StatCapOrb(),
            new SkillOrb(),
            new StatCapOrb(),
            new SkillOrb(),
            new StatCapOrb(),
            new SkillOrb(),
            new StatCapOrb(),
            new SkillOrb(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new MaxxiaScroll(),
            new AbysmalHorrorSummoningMateria(),
            new AcidElementalSummoningMateria(),
            new AgapiteElementalSummoningMateria(),
            new AirElementalSummoningMateria(),
            new AlligatorSummoningMateria(),
            new AncientLichSummoningMateria(),
            new AncientWyrmSummoningMateria(),
            new AntLionSummoningMateria(),
            new ArcaneDaemonSummoningMateria(),
            new ArcticOgreLordSummoningMateria(),
            new AxeBreathMateria(),
            new AxeCircleMateria(),
            new AxeLineMateria(),
            new BakeKitsuneSummoningMateria(),
            new BalronSummoningMateria(),
            new BarracoonSummoningMateria(),
            new BeeBreathMateria(),
            new BeeCircleMateria(),
            new BeeLineMateria(),
            new BeetleSummoningMateria(),
            new BlackBearSummoningMateria(),
            new BlackDragoonPirateMateria(),
            new BlackSolenInfiltratorQueenSummoningMateria(),
            new BlackSolenInfiltratorWarriorMateria(),
            new BlackSolenQueenSummoningMateria(),
            new BlackSolenWarriorSummoningMateria(),
            new BlackSolenWorkerSummoningMateria(),
            new BladesBreathMateria(),
            new BladesCircleMateria(),
            new BladesLineMateria(),
            new BloodElementalSummoningGem(),
            new BloodSwarmGem(),
            new BoarSummoningMateria(),
            new BogleSummoningMateria(),
            new BoglingSummoningMateria(),
            new BogThingSummoningMateria(),
            new BoneDemonSummoningMateria(),
            new BoneKnightSummoningMateria(),
            new BoneMagiSummoningMateria(),
            new BoulderBreathMateria(),
            new BoulderCircleMateria(),
            new BoulderLineMateria(),
            new BrigandSummoningMateria(),
            new BronzeElementalSummoningMateria(),
            new BrownBearSummoningMateria(),
            new BullFrogSummoningMateria(),
            new BullSummoningMateria(),
            new CatSummoningMateria(),
            new CentaurSummoningMateria(),
            new ChaosDaemonSummoningMateria(),
            new ChaosDragoonEliteSummoningMateria(),
            new ChaosDragoonSummoningMateria(),
            new ChickenSummoningMateria(),
            new CopperElementalSummoningMateria(),
            new CorpserSummoningMateria(),
            new CorrosiveSlimeSummoningMateria(),
            new CorruptedSoulMateria(),
            new CougarSummoningMateria(),
            new CowSummoningMateria(),
            new CraneSummoningMateria(),
            new CrankBreathMateria(),
            new CrankCircleMateria(),
            new CrankLineMateria(),
            new CrimsonDragonSummoningMateria(),
            new CrystalElementalSummoningMateria(),
            new CurtainBreathMateria(),
            new CurtainCircleMateria(),
            new CurtainLineMateria(),
            new CuSidheSummoningMateria(),
            new CyclopsSummoningMateria(),
            new DaemonSummoningMateria(),
            new DarkWispSummoningMateria(),
            new DarkWolfSummoningMateria(),
            new DeathWatchBeetleSummoningMateria(),
            new DeepSeaSerpentSummoningMateria(),
            new DeerBreathMateria(),
            new DeerCircleMateria(),
            new DeerLineMateria(),
            new DemonKnightSummoningMateria(),
            new DesertOstardSummoningMateria(),
            new DevourerSummoningMateria(),
            new DireWolfSummoningMateria(),
            new DogSummoningMateria(),
            new DolphinSummoningMateria(),
            new DopplegangerSummoningMateria(),
            new DragonSummoningMateria(),
            new DrakeSummoningMateria(),
            new DreadSpiderSummoningMateria(),
            new DullCopperElementalSummoningMateria(),
            new DVortexBreathMateria(),
            new DVortexCircleMateria(),
            new DVortexLineMateria(),
            new EagleSummoningMateria(),
            new EarthElementalSummoningMateria(),
            new EfreetSummoningMateria(),
            new ElderGazerSummoningMateria(),
            new EliteNinjaSummoningMateria(),
            new EttinSummoningMateria(),
            new EvilHealerSummoningMateria(),
            new EvilMageSummoningMateria(),
            new ExecutionerMateria(),
            new ExodusMinionSummoningMateria(),
            new ExodusOverseerSummoningMateria(),
            new FanDancerSummoningMateria(),
            new FeralTreefellowSummoningMateria(),
            new FetidEssenceMateria(),
            new FireBeetleSummoningMateria(),
            new FireElementalSummoningMateria(),
            new FireGargoyleSummoningMateria(),
            new FireSteedSummoningMateria(),
            new FlaskBreathMateria(),
            new FlaskCircleMateria(),
            new FlaskLineMateria(),
            new FleshGolemSummoningMateria(),
            new FleshRendererSummoningMateria(),
            new ForestOstardSummoningMateria(),
            new FrenziedOstardSummoningMateria(),
            new FrostOozeSummoningMateria(),
            new FrostSpiderSummoningMateria(),
            new FrostTrollSummoningMateria(),
            new FTreeCircleMateria(),
            new FTreeLineMateria(),
            new GamanSummoningMateria(),
            new GargoyleSummoningMateria(),
            new GasBreathMateria(),
            new GasCircleMateria(),
            new GasLineMateria(),
            new GateBreathMateria(),
            new GateCircleMateria(),
            new GateLineMateria(),
            new GazerSummoningMateria(),
            new GhoulSummoningMateria(),
            new GiantBlackWidowSummoningMateria(),
            new GiantRatSummoningMateria(),
            new GiantSerpentSummoningMateria(),
            new GiantSpiderSummoningMateria(),
            new GiantToadSummoningMateria(),
            new GibberlingSummoningMateria(),
            new GlowBreathMateria(),
            new GlowCircleMateria(),
            new GlowLineMateria(),
            new GoatSummoningMateria(),
            new GoldenElementalSummoningMateria(),
            new GolemSummoningMateria(),
            new GoreFiendSummoningMateria(),
            new GorillaSummoningMateria(),
            new GreaterDragonSummoningMateria(),
            new GreaterMongbatSummoningMateria(),
            new GreatHartSummoningMateria(),
            new GreyWolfSummoningMateria(),
            new GrizzlyBearSummoningMateria(),
            new GuillotineBreathMateria(),
            new GuillotineCircleMateria(),
            new GuillotineLineMateria(),
            new HarpySummoningMateria(),
            new HeadBreathMateria(),
            new HeadCircleMateria(),
            new HeadlessOneSummoningMateria(),
            new HeadLineMateria(),
            new HealerMateria(),
            new HeartBreathMateria(),
            new HeartCircleMateria(),
            new HeartLineMateria(),
            new HellCatSummoningMateria(),
            new HellHoundSummoningMateria(),
            new HellSteedSummoningMateria(),
            new HindSummoningMateria(),
            new HiryuSummoningMateria(),
            new HorseSummoningMateria(),
            new IceElementalSummoningMateria(),
            new IceFiendSummoningMateria(),
            new IceSerpentSummoningMateria(),
            new IceSnakeSummoningMateria(),
            new ImpSummoningMateria(),
            new JackRabbitSummoningMateria(),
            new KazeKemonoSummoningMateria(),
            new KirinSummoningMateria(),
            new LavaLizardSummoningMateria(),
            new LavaSerpentSummoningMateria(),
            new LavaSnakeSummoningMateria(),
            new LesserHiryuSummoningMateria(),
            new LichLordSummoningMateria(),
            new LichSummoningMateria(),
            new LizardmanSummoningMateria(),
            new LlamaSummoningMateria(),
            new MaidenBreathMateria(),
            new MaidenCircleMateria(),
            new MaidenLineMateria(),
            new MinotaurCaptainSummoningMateria(),
            new MountainGoatSummoningMateria(),
            new MummySummoningMateria(),
            new MushroomBreathMateria(),
            new MushroomCircleMateria(),
            new MushroomLineMateria(),
            new NightmareSummoningMateria(),
            new NutcrackerBreathMateria(),
            new NutcrackerCircleMateria(),
            new NutcrackerLineMateria(),
            new OFlaskBreathMateria(),
            new OFlaskCircleMateria(),
            new OFlaskMateria(),
            new OgreLordSummoningMateria(),
            new OgreSummoningMateria(),
            new OniSummoningMateria(),
            new OphidianArchmageSummoningMateria(),
            new OphidianKnightSummoningMateria(),
            new OrcBomberSummoningMateria(),
            new OrcBruteSummoningMateria(),
            new OrcCaptainSummoningMateria(),
            new OrcishLordSummoningMateria(),
            new OrcishMageSummoningMateria(),
            new OrcSummoningMateria(),
            new PackHorseSummoningMateria(),
            new PackLlamaSummoningMateria(),
            new PantherSummoningMateria(),
            new ParaBreathMateria(),
            new ParaCircleMateria(),
            new ParaLineMateria(),
            new PhoenixSummoningMateria(),
            new PigSummoningMateria(),
            new PixieSummoningMateria(),
            new PlagueBeastSummoningMateria(),
            new PoisonElementalSummoningMateria(),
            new PolarBearSummoningMateria(),
            new RabbitSummoningMateria(),
            new RaiJuSummoningMateria(),
            new RatmanArcherSummoningMateria(),
            new RatmanMageSummoningMateria(),
            new RatmanSummoningMateria(),
            new RatSummoningMateria(),
            new ReaperSummoningMateria(),
            new RevenantSummoningMateria(),
            new RidgebackSummoningMateria(),
            new RikktorSummoningMateria(),
            new RoninSummoningMateria(),
            new RuneBeetleSummoningMateria(),
            new RuneBreathMateria(),
            new RuneCircleMateria(),
            new RuneLineMateria(),
            new SatyrSummoningMateria(),
            new SavageShamanSummoningMateria(),
            new SavageSummoningMateria(),
            new SawBreathMateria(),
            new SawCircleMateria(),
            new SawLineMateria(),
            new ScaledSwampDragonSummoningMateria(),
            new ScorpionSummoningMateria(),
            new SeaSerpentSummoningMateria(),
            new ShadowWispSummoningMateria(),
            new ShadowWyrmSummoningMateria(),
            new SheepSummoningMateria(),
            new SilverSerpentSummoningMateria(),
            new SilverSteedSummoningMateria(),
            new SkeletalDragonSummoningMateria(),
            new SkeletalKnightSummoningMateria(),
            new SkeletalMageSummoningMateria(),
            new SkeletalMountSummoningMateria(),
            new SkeletonBreathMateria(),
            new SkeletonCircleMateria(),
            new SkeletonLineMateria(),
            new SkeletonSummoningMateria(),
            new SkullBreathMateria(),
            new SkullCircleMateria(),
            new SkullLineMateria(),
            new SlimeSummoningMateria(),
            new SmokeBreathMateria(),
            new SmokeCircleMateria(),
            new SmokeLineMateria(),
            new SnakeSummoningMateria(),
            new SnowElementalSummoningMateria(),
            new SnowLeopardSummoningMateria(),
            new SocketDeed(),
            new SocketDeed1(),
            new SocketDeed2(),
            new SocketDeed3(),
            new SocketDeed4(),
            new SocketDeed5(),
            new SparkleBreathMateria(),
            new SparkleCircleMateria(),
            new SparkleLineMateria(),
            new SpikeBreathMateria(),
            new SpikeCircleMateria(),
            new SpikeLineMateria(),
            new StoneBreathMateria(),
            new StoneCircleMateria(),
            new StoneLineMateria(),
            new SuccubusSummoningMateria(),
            new TimeBreathMateria(),
            new TimeCircleMateria(),
            new TimeLineMateria(),
            new TitanSummoningMateria(),
            new ToxicElementalSummoningMateria(),
            new TrapBreathMateria(),
            new TrapCircleMateria(),
            new TrapLineMateria(),
            new TreeBreathMateria(),
            new TroglodyteSummoningMateria(),
            new TrollSummoningMateria(),
            new UnicornSummoningMateria(),
            new ValoriteElementalSummoningMateria(),
            new VampireBatSummoningMateria(),
            new VeriteElementalSummoningMateria(),
            new VortexBreathMateria(),
            new VortexCircleMateria(),
            new VortexLineMateria(),
            new WalrusSummoningMateria(),
            new WaterBreathMateria(),
            new WaterCircleMateria(),
            new WaterElementalSummoningMateria(),
            new WaterLineMateria(),
            new WhiteWolfSummoningMateria(),
            new WhiteWyrmSummoningMateria(),
            new WispSummoningMateria(),
            new WraithSummoningMateria(),
            new WyvernSummoningMateria(),
            new ZombieSummoningMateria(),
            new MythicAmethyst(),
            new LegendaryAmethyst(),
            new AncientAmethyst(),
            new FenCrystal(),
            new RhoCrystal(),
            new RysCrystal(),
            new WyrCrystal(),
            new FreCrystal(),
            new TorCrystal(),
            new VelCrystal(),
            new XenCrystal(),
            new PolCrystal(),
            new WolCrystal(),
            new BalCrystal(),
            new TalCrystal(),
            new JalCrystal(),
            new RalCrystal(),
            new KalCrystal(),
            new MythicDiamond(),
            new LegendaryDiamond(),
            new AncientDiamond(),
            new MythicEmerald(),
            new LegendaryEmerald(),
            new AncientEmerald(),
            new KeyAugment(),
            new RadiantRhoCrystal(),
            new RadiantRysCrystal(),
            new RadiantWyrCrystal(),
            new RadiantFreCrystal(),
            new RadiantTorCrystal(),
            new RadiantVelCrystal(),
            new RadiantXenCrystal(),
            new RadiantPolCrystal(),
            new RadiantWolCrystal(),
            new RadiantBalCrystal(),
            new RadiantTalCrystal(),
            new RadiantJalCrystal(),
            new RadiantRalCrystal(),
            new RadiantKalCrystal(),
            new MythicRuby(),
            new LegendaryRuby(),
            new AncientRuby(),
            new TyrRune(),
            new AhmRune(),
            new MorRune(),
            new MefRune(),
            new YlmRune(),
            new KotRune(),
            new JorRune(),
            new MythicSapphire(),
            new LegendarySapphire(),
            new AncientSapphire(),
            new MythicSkull(),
            new AncientSkull(),
            new LegendarySkull(),
            new GlimmeringGranite(),
            new GlimmeringClay(),
            new GlimmeringHeartstone(),
            new GlimmeringGypsum(),
            new GlimmeringIronOre(),
            new GlimmeringOnyx(),
            new GlimmeringMarble(),
            new GlimmeringPetrifiedWood(),
            new GlimmeringLimestone(),
            new GlimmeringBloodrock(),
            new MythicTourmaline(),
            new LegendaryTourmaline(),
            new AncientTourmaline(),
            new MythicWood(),
            new LegendaryWood(),
            new AncientWood(),
            new Apple()
            // Add other items as needed
        };

        public static Item GetRandomItem()
        {
            return ItemList[Utility.Random(ItemList.Length)];
        }
    }

// ---------- [Level 1] ----------
// Large, Medium and Small Crate
	[FlipableAttribute( 0xe3e, 0xe3f )] 
	public class TreasureLevel1 : BaseTreasureChestMod 
	{ 
		public override int DefaultGumpID{ get{ return 0x49; } }

		[Constructable] 
		public TreasureLevel1() : base( Utility.RandomList( 0xE3C, 0xE3E, 0x9a9 ) )
		{ 
			RequiredSkill = 52;
			LockLevel = this.RequiredSkill - Utility.Random( 1, 10 );
			MaxLockLevel = this.RequiredSkill;
			TrapType = TrapType.MagicTrap;
			TrapPower = 1 * Utility.Random( 1, 25 );

            DropItem(new Gold(30, 100));
            DropItem(new Bolt(10));
            DropItem(Loot.RandomClothing());

            AddLoot(Loot.RandomWeapon());
            AddLoot(Loot.RandomArmorOrShield());
            AddLoot(Loot.RandomJewelry());

			for (int i = Utility.Random(3) + 1; i > 0; i--) // random 1 to 3
				DropItem( Loot.RandomGem() );

            DropItem(CustomLoot.GetRandomItem()); // Add one item from the list
		}

		public TreasureLevel1( Serial serial ) : base( serial ) 
		{ 
		} 

		public override void Serialize( GenericWriter writer ) 
		{ 
			base.Serialize( writer ); 

			writer.Write( (int) 0 ); // version 
		} 

		public override void Deserialize( GenericReader reader ) 
		{ 
			base.Deserialize( reader ); 

			int version = reader.ReadInt();
		} 
	}

// ---------- [Level 1 Hybrid] ----------
// Large, Medium and Small Crate
	[FlipableAttribute( 0xe3e, 0xe3f )] 
	public class TreasureLevel1h : BaseTreasureChestMod 
	{ 
		public override int DefaultGumpID{ get{ return 0x49; } }

		[Constructable] 
		public TreasureLevel1h() : base( Utility.RandomList( 0xE3C, 0xE3E, 0x9a9 ) ) 
		{ 
			RequiredSkill = 56;
			LockLevel = this.RequiredSkill - Utility.Random( 1, 10 );
			MaxLockLevel = this.RequiredSkill;
			TrapType = TrapType.MagicTrap;
			TrapPower = 1 * Utility.Random( 1, 25 );

			DropItem( new Gold( 10, 40 ) );
			DropItem( new Bolt( 5 ) );
			switch ( Utility.Random( 6 )) 
			{ 
				case 0: DropItem( new Candelabra()  ); break; 
				case 1: DropItem( new Candle() ); break; 
				case 2: DropItem( new CandleLarge() ); break; 
				case 3: DropItem( new CandleLong() ); break; 
				case 4: DropItem( new CandleShort() ); break; 
				case 5: DropItem( new CandleSkull() ); break; 
			}
			switch ( Utility.Random( 2 )) 
			{ 
				case 0: DropItem( new Shoes( Utility.Random( 1, 2 ) ) ); break; 
				case 1: DropItem( new Sandals( Utility.Random( 1, 2 ) ) ); break; 
			}

			switch ( Utility.Random( 3 )) 
			{ 
				case 0: DropItem( new BeverageBottle(BeverageType.Ale) ); break;
				case 1: DropItem( new BeverageBottle(BeverageType.Liquor) ); break;
				case 2: DropItem( new Jug(BeverageType.Cider) ); break;
			}

            DropItem(CustomLoot.GetRandomItem()); // Add one item from the list
		} 

		public TreasureLevel1h( Serial serial ) : base( serial ) 
		{ 
		} 

		public override void Serialize( GenericWriter writer ) 
		{ 
			base.Serialize( writer ); 

			writer.Write( (int) 0 ); // version 
		} 

		public override void Deserialize( GenericReader reader ) 
		{ 
			base.Deserialize( reader ); 

			int version = reader.ReadInt(); 
		} 
	}

// ---------- [Level 2] ----------
// Large, Medium and Small Crate
// Wooden, Metal and Metal Golden Chest
// Keg and Barrel
	[FlipableAttribute( 0xe43, 0xe42 )] 
	public class TreasureLevel2 : BaseTreasureChestMod 
	{
		[Constructable] 
		public TreasureLevel2() : base( Utility.RandomList( 0xe3c, 0xE3E, 0x9a9, 0xe42, 0x9ab, 0xe40, 0xe7f, 0xe77 ) ) 
		{ 
			RequiredSkill = 72;
			LockLevel = this.RequiredSkill - Utility.Random( 1, 10 );
			MaxLockLevel = this.RequiredSkill;
			TrapType = TrapType.MagicTrap;
			TrapPower = 2 * Utility.Random( 1, 25 );

			DropItem( new Gold( 70, 100 ) );
			DropItem( new Arrow( 10 ) );
			DropItem( Loot.RandomPotion() );
			for( int i = Utility.Random( 1, 2 ); i > 1; i-- )
			{
				Item ReagentLoot = Loot.RandomReagent();
				ReagentLoot.Amount = Utility.Random( 1, 2 );
				DropItem( ReagentLoot );
			}
			if (Utility.RandomBool()) //50% chance
				for (int i = Utility.Random(8) + 1; i > 0; i--)
					DropItem(Loot.RandomScroll(0, 39, SpellbookType.Regular));

			if (Utility.RandomBool()) //50% chance
				for (int i = Utility.Random(6) + 1; i > 0; i--)
					DropItem( Loot.RandomGem() );

            for (int i = 0; i < 2; i++) // Add two items from the list
                DropItem(CustomLoot.GetRandomItem());
		} 

		public TreasureLevel2( Serial serial ) : base( serial ) 
		{ 
		} 

		public override void Serialize( GenericWriter writer ) 
		{ 
			base.Serialize( writer ); 

			writer.Write( (int) 0 ); // version 
		} 

		public override void Deserialize( GenericReader reader ) 
		{ 
			base.Deserialize( reader ); 

			int version = reader.ReadInt(); 
		} 
	} 

// ---------- [Level 3] ----------
// Wooden, Metal and Metal Golden Chest
	[FlipableAttribute( 0x9ab, 0xe7c )] 
	public class TreasureLevel3 : BaseTreasureChestMod 
	{ 
		public override int DefaultGumpID{ get{ return 0x4A; } }

		[Constructable] 
		public TreasureLevel3() : base( Utility.RandomList( 0x9ab, 0xe40, 0xe42 ) ) 
		{ 
			RequiredSkill = 84;
			LockLevel = this.RequiredSkill - Utility.Random( 1, 10 );
			MaxLockLevel = this.RequiredSkill;
			TrapType = TrapType.MagicTrap;
			TrapPower = 3 * Utility.Random( 1, 25 );

			DropItem( new Gold( 180, 240 ) );
			DropItem( new Arrow( 10 ) );

			for( int i = Utility.Random( 1, 3 ); i > 1; i-- )
			{
				Item ReagentLoot = Loot.RandomReagent();
				ReagentLoot.Amount = Utility.Random( 1, 9 );
				DropItem( ReagentLoot );
			}

			for ( int i = Utility.Random( 1, 3 ); i > 1; i-- )
				DropItem( Loot.RandomPotion() );

			if ( 0.67 > Utility.RandomDouble() ) //67% chance = 2/3
				for (int i = Utility.Random(12) + 1; i > 0; i--)
					DropItem(Loot.RandomScroll(0, 47, SpellbookType.Regular));

			if ( 0.67 > Utility.RandomDouble() ) //67% chance = 2/3
				for (int i = Utility.Random(9) + 1; i > 0; i--)
					DropItem( Loot.RandomGem() );

			for( int i = Utility.Random( 1, 3 ); i > 1; i-- )
				DropItem( Loot.RandomWand() );

			// Magical ArmorOrWeapon
			for( int i = Utility.Random( 1, 3 ); i > 1; i-- )
			{
				Item item = Loot.RandomArmorOrShieldOrWeapon();

                if (!Core.AOS)
                {
                    if (item is BaseWeapon)
                    {
                        BaseWeapon weapon = (BaseWeapon)item;
                        weapon.DamageLevel = (WeaponDamageLevel)Utility.Random(3);
                        weapon.AccuracyLevel = (WeaponAccuracyLevel)Utility.Random(3);
                        weapon.DurabilityLevel = (WeaponDurabilityLevel)Utility.Random(3);
                        weapon.Quality = ItemQuality.Normal;
                    }
                    else if (item is BaseArmor)
                    {
                        BaseArmor armor = (BaseArmor)item;
                        armor.ProtectionLevel = (ArmorProtectionLevel)Utility.Random(3);
                        armor.Durability = (ArmorDurabilityLevel)Utility.Random(3);
                        armor.Quality = ItemQuality.Normal;
                    }
                }
                else
                    AddLoot(item);
			}

			for( int i = Utility.Random( 1, 2 ); i > 1; i-- )
				AddLoot( Loot.RandomClothing() );

			for( int i = Utility.Random( 1, 2 ); i > 1; i-- )
                AddLoot(Loot.RandomJewelry());

            for (int i = 0; i < 3; i++) // Add three items from the list
                DropItem(CustomLoot.GetRandomItem());
		} 

		public TreasureLevel3( Serial serial ) : base( serial ) 
		{ 
		} 

		public override void Serialize( GenericWriter writer ) 
		{ 
			base.Serialize( writer ); 

			writer.Write( (int) 0 ); // version 
		} 

		public override void Deserialize( GenericReader reader ) 
		{ 
			base.Deserialize( reader ); 

			int version = reader.ReadInt(); 
		} 
	} 

// ---------- [Level 4] ----------
// Wooden, Metal and Metal Golden Chest
	[FlipableAttribute( 0xe41, 0xe40 )] 
	public class TreasureLevel4 : BaseTreasureChestMod 
	{ 
		[Constructable] 
		public TreasureLevel4() : base( Utility.RandomList( 0xe40, 0xe42, 0x9ab ) )
		{ 
			RequiredSkill = 92;
			LockLevel = this.RequiredSkill - Utility.Random( 1, 10 );
			MaxLockLevel = this.RequiredSkill;
			TrapType = TrapType.MagicTrap;
			TrapPower = 4 * Utility.Random( 1, 25 );

			DropItem( new Gold( 200, 400 ) );
			DropItem( new BlankScroll( Utility.Random( 1, 4 ) ) );
			
			for( int i = Utility.Random( 1, 4 ); i > 1; i-- )
			{
				Item ReagentLoot = Loot.RandomReagent();
				ReagentLoot.Amount = Utility.Random( 6, 12 );
				DropItem( ReagentLoot );
			}
	
			for ( int i = Utility.Random( 1, 4 ); i > 1; i-- )
				DropItem( Loot.RandomPotion() );
			
			if ( 0.75 > Utility.RandomDouble() ) //75% chance = 3/4
				for (int i = Utility.RandomMinMax(8,16); i > 0; i--)
					DropItem(Loot.RandomScroll(0, 47, SpellbookType.Regular));

			if ( 0.75 > Utility.RandomDouble() ) //75% chance = 3/4
				for (int i = Utility.RandomMinMax(6,12) + 1; i > 0; i--)
					DropItem( Loot.RandomGem() );

			for( int i = Utility.Random( 1, 4 ); i > 1; i-- )
				DropItem( Loot.RandomWand() );

			// Magical ArmorOrWeapon
			for( int i = Utility.Random( 1, 4 ); i > 1; i-- )
			{
				Item item = Loot.RandomArmorOrShieldOrWeapon();

                if (!Core.AOS)
                {
                    if (item is BaseWeapon)
                    {
                        BaseWeapon weapon = (BaseWeapon)item;
                        weapon.DamageLevel = (WeaponDamageLevel)Utility.Random(4);
                        weapon.AccuracyLevel = (WeaponAccuracyLevel)Utility.Random(4);
                        weapon.DurabilityLevel = (WeaponDurabilityLevel)Utility.Random(4);
                        weapon.Quality = ItemQuality.Normal;
                    }
                    else if (item is BaseArmor)
                    {
                        BaseArmor armor = (BaseArmor)item;
                        armor.ProtectionLevel = (ArmorProtectionLevel)Utility.Random(4);
                        armor.Durability = (ArmorDurabilityLevel)Utility.Random(4);
                        armor.Quality = ItemQuality.Normal;
                    }
                }
                else
                    AddLoot(item);
			}

			for( int i = Utility.Random( 1, 2 ); i > 1; i-- )
				AddLoot( Loot.RandomClothing() );
			
			for( int i = Utility.Random( 1, 2 ); i > 1; i-- )
				AddLoot( Loot.RandomJewelry() );

            for (int i = 0; i < 4; i++) // Add four items from the list
                DropItem(CustomLoot.GetRandomItem());
			
			//DropItem( new MagicCrystalBall() );

			// Magic clothing (not implemented)
			
			// Magic jewelry (not implemented)
		} 

		public TreasureLevel4( Serial serial ) : base( serial ) 
		{ 
		} 

		public override void Serialize( GenericWriter writer ) 
		{ 
			base.Serialize( writer ); 

			writer.Write( (int) 0 ); // version 
		} 

		public override void Deserialize( GenericReader reader ) 
		{ 
			base.Deserialize( reader ); 

			int version = reader.ReadInt(); 
		} 
	} 

}
