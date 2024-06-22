#region References
using System;

using Server.Items;
using Server.Mobiles;
#endregion

namespace Server
{
	public class LootPack
	{
		public static int GetLuckChance(Mobile killer, Mobile victim)
		{
			if (!Core.AOS)
			{
				return 0;
			}

			int luck = killer is PlayerMobile ? ((PlayerMobile)killer).RealLuck : killer.Luck;

            PlayerMobile pmKiller = killer as PlayerMobile;
			if (pmKiller != null && pmKiller.SentHonorContext != null && pmKiller.SentHonorContext.Target == victim)
			{
				luck += pmKiller.SentHonorContext.PerfectionLuckBonus;
			}

			if (luck < 0)
			{
				return 0;
			}

			if (!Core.SE && luck > 1200)
			{
				luck = 1200;
			}

			return GetLuckChance(luck);
		}

        public static int GetLuckChance(int luck)
        {
            return (int)(Math.Pow(luck, 1 / 1.8) * 100);
        }

		public static int GetLuckChanceForKiller(Mobile m)
		{
            BaseCreature dead = m as BaseCreature;

            if (dead == null)
                return 240;

			var list = dead.GetLootingRights();

			DamageStore highest = null;

			for (int i = 0; i < list.Count; ++i)
			{
				DamageStore ds = list[i];

				if (ds.m_HasRight && (highest == null || ds.m_Damage > highest.m_Damage))
				{
					highest = ds;
				}
			}

			if (highest == null)
			{
				return 0;
			}

			return GetLuckChance(highest.m_Mobile, dead);
		}

		public static bool CheckLuck(int chance)
		{
			return (chance > Utility.Random(10000));
		}

		private readonly LootPackEntry[] m_Entries;

		public LootPack(LootPackEntry[] entries)
		{
			m_Entries = entries;
		}

		public void Generate(Mobile from, Container cont, bool spawning, int luckChance)
		{
			if (cont == null)
			{
				return;
			}

			bool checkLuck = Core.AOS;

			for (int i = 0; i < m_Entries.Length; ++i)
			{
				LootPackEntry entry = m_Entries[i];

				bool shouldAdd = (entry.Chance > Utility.Random(10000));

				if (!shouldAdd && checkLuck)
				{
					checkLuck = false;

					if (CheckLuck(luckChance))
					{
						shouldAdd = (entry.Chance > Utility.Random(10000));
					}
				}

				if (!shouldAdd)
				{
					continue;
				}

				Item item = entry.Construct(from, luckChance, spawning);

				if (item != null)
				{
					if (!item.Stackable || !cont.TryDropItem(from, item, false))
					{
						cont.DropItem(item);
					}
				}
			}
		}

		public static readonly LootPackItem[] Gold = new[] {new LootPackItem(typeof(Gold), 1)};

		public static readonly LootPackItem[] Instruments = new[] {new LootPackItem(typeof(BaseInstrument), 1)};

		public static readonly LootPackItem[] LowScrollItems = new[]
		{
            new LootPackItem(typeof(ClumsyScroll), 1)
        };

		public static readonly LootPackItem[] MedScrollItems = new[]
		{
			new LootPackItem(typeof(ArchCureScroll), 1)
		};

		public static readonly LootPackItem[] HighScrollItems = new[]
		{
			new LootPackItem(typeof(SummonAirElementalScroll), 1)
		};

		public static readonly LootPackItem[] GemItems = new[] {new LootPackItem(typeof(Amber), 1)};

		public static readonly LootPackItem[] PotionItems = new[]
		{
			new LootPackItem(typeof(AgilityPotion), 1), new LootPackItem(typeof(StrengthPotion), 1),
			new LootPackItem(typeof(RefreshPotion), 1), new LootPackItem(typeof(LesserCurePotion), 1),
			new LootPackItem(typeof(LesserHealPotion), 1), new LootPackItem(typeof(LesserPoisonPotion), 1)
		};

		#region Old Magic Items
		public static readonly LootPackItem[] OldMagicItems = new[]
		{
			new LootPackItem(typeof(BaseJewel), 1), new LootPackItem(typeof(BaseArmor), 4),
			new LootPackItem(typeof(BaseWeapon), 3), new LootPackItem(typeof(BaseRanged), 1),
			new LootPackItem(typeof(BaseShield), 1)
		};
		#endregion

		#region AOS Magic Items
		public static readonly LootPackItem[] AosMagicItemsPoor = new[]
		{
			new LootPackItem(typeof(BaseWeapon), 3), new LootPackItem(typeof(BaseRanged), 1),
			new LootPackItem(typeof(BaseArmor), 4), new LootPackItem(typeof(BaseShield), 1),
			new LootPackItem(typeof(BaseJewel), 2)
		};

		public static readonly LootPackItem[] AosMagicItemsMeagerType1 = new[]
		{
			new LootPackItem(typeof(BaseWeapon), 56), new LootPackItem(typeof(BaseRanged), 14),
			new LootPackItem(typeof(BaseArmor), 81), new LootPackItem(typeof(BaseShield), 11),
			new LootPackItem(typeof(BaseJewel), 42)
		};

		public static readonly LootPackItem[] AosMagicItemsMeagerType2 = new[]
		{
			new LootPackItem(typeof(BaseWeapon), 28), new LootPackItem(typeof(BaseRanged), 7),
			new LootPackItem(typeof(BaseArmor), 40), new LootPackItem(typeof(BaseShield), 5),
			new LootPackItem(typeof(BaseJewel), 21)
		};

		public static readonly LootPackItem[] AosMagicItemsAverageType1 = new[]
		{
			new LootPackItem(typeof(BaseWeapon), 90), new LootPackItem(typeof(BaseRanged), 23),
			new LootPackItem(typeof(BaseArmor), 130), new LootPackItem(typeof(BaseShield), 17),
			new LootPackItem(typeof(BaseJewel), 68)
		};

		public static readonly LootPackItem[] AosMagicItemsAverageType2 = new[]
		{
			new LootPackItem(typeof(BaseWeapon), 54), new LootPackItem(typeof(BaseRanged), 13),
			new LootPackItem(typeof(BaseArmor), 77), new LootPackItem(typeof(BaseShield), 10),
			new LootPackItem(typeof(BaseJewel), 40)
		};

		public static readonly LootPackItem[] AosMagicItemsRichType1 = new[]
		{
			new LootPackItem(typeof(BaseWeapon), 211), new LootPackItem(typeof(BaseRanged), 53),
			new LootPackItem(typeof(BaseArmor), 303), new LootPackItem(typeof(BaseShield), 39),
			new LootPackItem(typeof(BaseJewel), 158)
		};

		public static readonly LootPackItem[] AosMagicItemsRichType2 = new[]
		{
			new LootPackItem(typeof(BaseWeapon), 170), new LootPackItem(typeof(BaseRanged), 43),
			new LootPackItem(typeof(BaseArmor), 245), new LootPackItem(typeof(BaseShield), 32),
			new LootPackItem(typeof(BaseJewel), 128)
		};

		public static readonly LootPackItem[] AosMagicItemsFilthyRichType1 = new[]
		{
			new LootPackItem(typeof(BaseWeapon), 219), new LootPackItem(typeof(BaseRanged), 55),
			new LootPackItem(typeof(BaseArmor), 315), new LootPackItem(typeof(BaseShield), 41),
			new LootPackItem(typeof(BaseJewel), 164)
		};

		public static readonly LootPackItem[] AosMagicItemsFilthyRichType2 = new[]
		{
			new LootPackItem(typeof(BaseWeapon), 239), new LootPackItem(typeof(BaseRanged), 60),
			new LootPackItem(typeof(BaseArmor), 343), new LootPackItem(typeof(BaseShield), 90),
			new LootPackItem(typeof(BaseJewel), 45)
		};

		public static readonly LootPackItem[] AosMagicItemsUltraRich = new[]
		{
			new LootPackItem(typeof(BaseWeapon), 276), new LootPackItem(typeof(BaseRanged), 69),
			new LootPackItem(typeof(BaseArmor), 397), new LootPackItem(typeof(BaseShield), 52),
			new LootPackItem(typeof(BaseJewel), 207)
		};
		
		public static readonly LootPackItem[] NewFilthyRichItems = new LootPackItem[]
		{
			// Make sure YourNewItem is a valid Item-derived class
			
			new LootPackItem(typeof(RandomMagicWeapon), 100), // Adjust chance as needed
			new LootPackItem(typeof(RandomMagicArmor), 100),
			new LootPackItem(typeof(RandomMagicClothing), 100),
			new LootPackItem(typeof(RandomMagicClothingX), 100),
			new LootPackItem(typeof(RandomMagicClothingXA), 100),
			new LootPackItem(typeof(RandomMagicClothingXB), 100),
			new LootPackItem(typeof(RandomMagicClothingXC), 100),
			new LootPackItem(typeof(RandomMagicClothingXD), 100),
			new LootPackItem(typeof(RandomMagicJewelry), 100),
			new LootPackItem(typeof(RandomMagicWeaponA), 100),
			new LootPackItem(typeof(RandomMagicWeaponB), 100),
			new LootPackItem(typeof(RandomMagicWeaponC), 100),
			new LootPackItem(typeof(RandomMagicWeaponD), 100),
			new LootPackItem(typeof(RandomMagicWeaponE), 100),
			new LootPackItem(typeof(RandomMagicWeaponF), 100),
			new LootPackItem(typeof(RandomMagicWeaponG), 100),
			new LootPackItem(typeof(RandomMagicWeaponH), 100),
			new LootPackItem(typeof(RandomMagicWeaponI), 100),
			new LootPackItem(typeof(RandomMagicWeaponJ), 100),
			new LootPackItem(typeof(RandomMagicWeaponK), 100),
			new LootPackItem(typeof(RandomMagicWeaponL), 100),
			new LootPackItem(typeof(RandomMagicWeaponM), 100),
			new LootPackItem(typeof(RandomSkillJewelryA), 100),
			new LootPackItem(typeof(RandomSkillJewelryAA), 100),
			new LootPackItem(typeof(RandomSkillJewelryAB), 100),
			new LootPackItem(typeof(RandomSkillJewelryAC), 100),
			new LootPackItem(typeof(RandomSkillJewelryAD), 100),
			new LootPackItem(typeof(RandomSkillJewelryAE), 100),
			new LootPackItem(typeof(RandomSkillJewelryAF), 100),
			new LootPackItem(typeof(RandomSkillJewelryAG), 100),
			new LootPackItem(typeof(RandomSkillJewelryAH), 100),
			new LootPackItem(typeof(RandomSkillJewelryAI), 100),
			new LootPackItem(typeof(RandomSkillJewelryAJ), 100),
			new LootPackItem(typeof(RandomSkillJewelryAK), 100),
			new LootPackItem(typeof(RandomSkillJewelryAL), 100),
			new LootPackItem(typeof(RandomSkillJewelryAM), 100),
			new LootPackItem(typeof(RandomSkillJewelryAN), 100),
			new LootPackItem(typeof(RandomSkillJewelryAO), 100),
			new LootPackItem(typeof(RandomSkillJewelryAP), 100),
			new LootPackItem(typeof(RandomSkillJewelryB), 100),
			new LootPackItem(typeof(RandomSkillJewelryC), 100),
			new LootPackItem(typeof(RandomSkillJewelryD), 100),
			new LootPackItem(typeof(RandomSkillJewelryE), 100),
			new LootPackItem(typeof(RandomSkillJewelryF), 100),
			new LootPackItem(typeof(RandomSkillJewelryG), 100),
			new LootPackItem(typeof(RandomSkillJewelryH), 100),
			new LootPackItem(typeof(RandomSkillJewelryI), 100),
			new LootPackItem(typeof(RandomSkillJewelryJ), 100),
			new LootPackItem(typeof(RandomSkillJewelryK), 100),
			new LootPackItem(typeof(RandomSkillJewelryL), 100),
			new LootPackItem(typeof(RandomSkillJewelryM), 100),
			new LootPackItem(typeof(RandomSkillJewelryN), 100),
			new LootPackItem(typeof(RandomSkillJewelryO), 100),
			new LootPackItem(typeof(RandomSkillJewelryP), 100),
			new LootPackItem(typeof(RandomSkillJewelryQ), 100),
			new LootPackItem(typeof(RandomSkillJewelryR), 100),
			new LootPackItem(typeof(RandomSkillJewelryS), 100),
			new LootPackItem(typeof(RandomSkillJewelryT), 100),
			new LootPackItem(typeof(RandomSkillJewelryU), 100),
			new LootPackItem(typeof(RandomSkillJewelryV), 100),
			new LootPackItem(typeof(RandomSkillJewelryW), 100),
			new LootPackItem(typeof(RandomSkillJewelryX), 100),
			new LootPackItem(typeof(RandomSkillJewelryY), 100),
			new LootPackItem(typeof(RandomSkillJewelryZ), 100),
			new LootPackItem(typeof(RandomSkillJewelryX), 100),
			new LootPackItem(typeof(RandomSkillJewelryXA), 100),
			new LootPackItem(typeof(RandomSkillJewelryXB), 100),
			new LootPackItem(typeof(RandomSkillJewelryXC), 100),
			new LootPackItem(typeof(RandomSkillJewelryXD), 100),
			new LootPackItem(typeof(RandomSkillJewelryXE), 100),
			new LootPackItem(typeof(RandomSkillJewelryXX), 100),
			new LootPackItem(typeof(RandomMagicArmor), 100),
			new LootPackItem(typeof(RandomMagicArmor), 100),
			new LootPackItem(typeof(RandomMagicArmor), 100),
			new LootPackItem(typeof(RandomMagicArmor), 100),
			new LootPackItem(typeof(RandomMagicArmor), 100),
			new LootPackItem(typeof(RandomMagicArmor), 100),
			new LootPackItem(typeof(RandomMagicArmor), 100),
			new LootPackItem(typeof(RandomMagicArmor), 100),
			new LootPackItem(typeof(RandomMagicArmor), 100),
			new LootPackItem(typeof(RandomMagicArmor), 100), // Adjust chance as needed
			new LootPackItem(typeof(AlchemyAugmentCrystal), 100),
			new LootPackItem(typeof(AnatomyAugmentCrystal), 100),
			new LootPackItem(typeof(AnimalLoreAugmentCrystal), 100),
			new LootPackItem(typeof(AnimalTamingAugmentCrystal), 100),
			new LootPackItem(typeof(ArcheryAugmentCrystal), 100),
			new LootPackItem(typeof(ArmsLoreAugmentCrystal), 100),
			new LootPackItem(typeof(ArmSlotChangeDeed), 100),
			new LootPackItem(typeof(BagOfBombs), 100),
			new LootPackItem(typeof(BagOfHealth), 100),
			new LootPackItem(typeof(BagOfJuice), 100),
			new LootPackItem(typeof(BanishingOrb), 100),
			new LootPackItem(typeof(BanishingRod), 100),
			new LootPackItem(typeof(BeggingAugmentCrystal), 100),
			new LootPackItem(typeof(BeltSlotChangeDeed), 100),
			new LootPackItem(typeof(BlacksmithyAugmentCrystal), 100),
			new LootPackItem(typeof(BloodSword), 100),
			new LootPackItem(typeof(BootsOfCommand), 100),
			new LootPackItem(typeof(BraceletSlotChangeDeed), 100),
			new LootPackItem(typeof(BushidoAugmentCrystal), 100),
			new LootPackItem(typeof(CampingAugmentCrystal), 100),
			new LootPackItem(typeof(CapacityIncreaseDeed), 100),
			new LootPackItem(typeof(CarpentryAugmentCrystal), 100),
			new LootPackItem(typeof(CartographyAugmentCrystal), 100),
			new LootPackItem(typeof(ChestSlotChangeDeed), 100),
			new LootPackItem(typeof(ChivalryAugmentCrystal), 100),
			new LootPackItem(typeof(ColdHitAreaCrystal), 100),
			new LootPackItem(typeof(ColdResistAugmentCrystal), 100),
			new LootPackItem(typeof(CookingAugmentCrystal), 100),
			new LootPackItem(typeof(CurseAugmentCrystal), 100),
			new LootPackItem(typeof(DetectingHiddenAugmentCrystal), 100),
			new LootPackItem(typeof(DiscordanceAugmentCrystal), 100),
			new LootPackItem(typeof(DispelAugmentCrystal), 100),
			new LootPackItem(typeof(EarringSlotChangeDeed), 100),
			new LootPackItem(typeof(EnergyHitAreaCrystal), 100),
			new LootPackItem(typeof(EnergyResistAugmentCrystal), 100),
			new LootPackItem(typeof(FatigueAugmentCrystal), 100),
			new LootPackItem(typeof(FencingAugmentCrystal), 100),
			new LootPackItem(typeof(FireballAugmentCrystal), 100),
			new LootPackItem(typeof(FireHitAreaCrystal), 100),
			new LootPackItem(typeof(FireResistAugmentCrystal), 100),
			new LootPackItem(typeof(FishingAugmentCrystal), 100),
			new LootPackItem(typeof(FletchingAugmentCrystal), 100),
			new LootPackItem(typeof(FocusAugmentCrystal), 100),
			new LootPackItem(typeof(FootwearSlotChangeDeed), 100),
			new LootPackItem(typeof(ForensicEvaluationAugmentCrystal), 100),
			new LootPackItem(typeof(GlovesOfCommand), 100),
			new LootPackItem(typeof(HarmAugmentCrystal), 100),
			new LootPackItem(typeof(HeadSlotChangeDeed), 100),
			new LootPackItem(typeof(HealingAugmentCrystal), 100),
			new LootPackItem(typeof(HerdingAugmentCrystal), 100),
			new LootPackItem(typeof(HidingAugmentCrystal), 100),
			new LootPackItem(typeof(ImbuingAugmentCrystal), 100),
			new LootPackItem(typeof(InscriptionAugmentCrystal), 100),
			new LootPackItem(typeof(ItemIdentificationAugmentCrystal), 100),
			new LootPackItem(typeof(JesterHatOfCommand), 100),
			new LootPackItem(typeof(LegsSlotChangeDeed), 100),
			new LootPackItem(typeof(LifeLeechAugmentCrystal), 100),
			new LootPackItem(typeof(LightningAugmentCrystal), 100),
			new LootPackItem(typeof(LockpickingAugmentCrystal), 100),
			new LootPackItem(typeof(LowerAttackAugmentCrystal), 100),
			new LootPackItem(typeof(LuckAugmentCrystal), 100),
			new LootPackItem(typeof(LumberjackingAugmentCrystal), 100),
			new LootPackItem(typeof(MaceFightingAugmentCrystal), 100),
			new LootPackItem(typeof(MageryAugmentCrystal), 100),
			new LootPackItem(typeof(ManaDrainAugmentCrystal), 100),
			new LootPackItem(typeof(ManaLeechAugmentCrystal), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MeditationAugmentCrystal), 100),
			new LootPackItem(typeof(MiningAugmentCrystal), 100),
			new LootPackItem(typeof(MirrorOfKalandra), 100),
			new LootPackItem(typeof(MusicianshipAugmentCrystal), 100),
			new LootPackItem(typeof(NeckSlotChangeDeed), 100),
			new LootPackItem(typeof(NecromancyAugmentCrystal), 100),
			new LootPackItem(typeof(NinjitsuAugmentCrystal), 100),
			new LootPackItem(typeof(OneHandedTransformDeed), 100),
			new LootPackItem(typeof(ParryingAugmentCrystal), 100),
			new LootPackItem(typeof(PeacemakingAugmentCrystal), 100),
			new LootPackItem(typeof(PhysicalHitAreaCrystal), 100),
			new LootPackItem(typeof(PhysicalResistAugmentCrystal), 100),
			new LootPackItem(typeof(PlateLeggingsOfCommand), 100),
			new LootPackItem(typeof(PoisonHitAreaCrystal), 100),
			new LootPackItem(typeof(PoisoningAugmentCrystal), 100),
			new LootPackItem(typeof(PoisonResistAugmentCrystal), 100),
			new LootPackItem(typeof(ProvocationAugmentCrystal), 100),
			new LootPackItem(typeof(RemoveTrapAugmentCrystal), 100),
			new LootPackItem(typeof(ResistingSpellsAugmentCrystal), 100),
			new LootPackItem(typeof(RingSlotChangeDeed), 100),
			new LootPackItem(typeof(RodOfOrcControl), 100),
			new LootPackItem(typeof(ShirtSlotChangeDeed), 100),
			new LootPackItem(typeof(SnoopingAugmentCrystal), 100),
			new LootPackItem(typeof(SpellweavingAugmentCrystal), 100),
			new LootPackItem(typeof(SpiritSpeakAugmentCrystal), 100),
			new LootPackItem(typeof(StaminaLeechAugmentCrystal), 100),
			new LootPackItem(typeof(StealingAugmentCrystal), 100),
			new LootPackItem(typeof(StealthAugmentCrystal), 100),
			new LootPackItem(typeof(SwingSpeedAugmentCrystal), 100),
			new LootPackItem(typeof(SwordsmanshipAugmentCrystal), 100),
			new LootPackItem(typeof(TacticsAugmentCrystal), 100),
			new LootPackItem(typeof(TailoringAugmentCrystal), 100),
			new LootPackItem(typeof(TalismanSlotChangeDeed), 100),
			new LootPackItem(typeof(TasteIDAugmentCrystal), 100),
			new LootPackItem(typeof(ThrowingAugmentCrystal), 100),
			new LootPackItem(typeof(TinkeringAugmentCrystal), 100),
			new LootPackItem(typeof(TrackingAugmentCrystal), 100),
			new LootPackItem(typeof(VeterinaryAugmentCrystal), 100),
			new LootPackItem(typeof(WeaponSpeedAugmentCrystal), 100),
			new LootPackItem(typeof(WrestlingAugmentCrystal), 100),
			new LootPackItem(typeof(PetSlotDeed), 100),
			new LootPackItem(typeof(PetBondDeed), 100),
			new LootPackItem(typeof(SkillOrb), 100),
			new LootPackItem(typeof(StatCapOrb), 100),
			new LootPackItem(typeof(SkillOrb), 100),
			new LootPackItem(typeof(StatCapOrb), 100),
			new LootPackItem(typeof(SkillOrb), 100),
			new LootPackItem(typeof(StatCapOrb), 100),
			new LootPackItem(typeof(SkillOrb), 100),
			new LootPackItem(typeof(StatCapOrb), 100),
			new LootPackItem(typeof(SkillOrb), 100),
			new LootPackItem(typeof(StatCapOrb), 100),
			new LootPackItem(typeof(SkillOrb), 100),
			new LootPackItem(typeof(StatCapOrb), 100),
			new LootPackItem(typeof(SkillOrb), 100),
			new LootPackItem(typeof(StatCapOrb), 100),
			new LootPackItem(typeof(SkillOrb), 100),
			new LootPackItem(typeof(StatCapOrb), 100),
			new LootPackItem(typeof(SkillOrb), 100),
			new LootPackItem(typeof(StatCapOrb), 100),
			new LootPackItem(typeof(SkillOrb), 100),
			new LootPackItem(typeof(StatCapOrb), 100),
			new LootPackItem(typeof(SkillOrb), 100),
			new LootPackItem(typeof(StatCapOrb), 100),
			new LootPackItem(typeof(SkillOrb), 100),
			new LootPackItem(typeof(StatCapOrb), 100),
			new LootPackItem(typeof(SkillOrb), 100),
			new LootPackItem(typeof(StatCapOrb), 100),
			new LootPackItem(typeof(SkillOrb), 100),
			new LootPackItem(typeof(StatCapOrb), 100),
			new LootPackItem(typeof(SkillOrb), 100),
			new LootPackItem(typeof(StatCapOrb), 100),
			new LootPackItem(typeof(SkillOrb), 100),
			new LootPackItem(typeof(StatCapOrb), 100),
			new LootPackItem(typeof(SkillOrb), 100),
			new LootPackItem(typeof(StatCapOrb), 100),
			new LootPackItem(typeof(SkillOrb), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(MaxxiaScroll), 100),
			new LootPackItem(typeof(AbysmalHorrorSummoningMateria), 100),
			new LootPackItem(typeof(AcidElementalSummoningMateria), 100),
			new LootPackItem(typeof(AgapiteElementalSummoningMateria), 100),
			new LootPackItem(typeof(AirElementalSummoningMateria), 100),
			new LootPackItem(typeof(AlligatorSummoningMateria), 100),
			new LootPackItem(typeof(AncientLichSummoningMateria), 100),
			new LootPackItem(typeof(AncientWyrmSummoningMateria), 100),
			new LootPackItem(typeof(AntLionSummoningMateria), 100),
			new LootPackItem(typeof(ArcaneDaemonSummoningMateria), 100),
			new LootPackItem(typeof(ArcticOgreLordSummoningMateria), 100),
			new LootPackItem(typeof(AxeBreathMateria), 100),
			new LootPackItem(typeof(AxeCircleMateria), 100),
			new LootPackItem(typeof(AxeLineMateria), 100),
			new LootPackItem(typeof(BakeKitsuneSummoningMateria), 100),
			new LootPackItem(typeof(BalronSummoningMateria), 100),
			new LootPackItem(typeof(BarracoonSummoningMateria), 100),
			new LootPackItem(typeof(BeeBreathMateria), 100),
			new LootPackItem(typeof(BeeCircleMateria), 100),
			new LootPackItem(typeof(BeeLineMateria), 100),
			new LootPackItem(typeof(BeetleSummoningMateria), 100),
			new LootPackItem(typeof(BlackBearSummoningMateria), 100),
			new LootPackItem(typeof(BlackDragoonPirateMateria), 100),
			new LootPackItem(typeof(BlackSolenInfiltratorQueenSummoningMateria), 100),
			new LootPackItem(typeof(BlackSolenInfiltratorWarriorMateria), 100),
			new LootPackItem(typeof(BlackSolenQueenSummoningMateria), 100),
			new LootPackItem(typeof(BlackSolenWarriorSummoningMateria), 100),
			new LootPackItem(typeof(BlackSolenWorkerSummoningMateria), 100),
			new LootPackItem(typeof(BladesBreathMateria), 100),
			new LootPackItem(typeof(BladesCircleMateria), 100),
			new LootPackItem(typeof(BladesLineMateria), 100),
			new LootPackItem(typeof(BloodElementalSummoningGem), 100),
			new LootPackItem(typeof(BloodSwarmGem), 100),
			new LootPackItem(typeof(BoarSummoningMateria), 100),
			new LootPackItem(typeof(BogleSummoningMateria), 100),
			new LootPackItem(typeof(BoglingSummoningMateria), 100),
			new LootPackItem(typeof(BogThingSummoningMateria), 100),
			new LootPackItem(typeof(BoneDemonSummoningMateria), 100),
			new LootPackItem(typeof(BoneKnightSummoningMateria), 100),
			new LootPackItem(typeof(BoneMagiSummoningMateria), 100),
			new LootPackItem(typeof(BoulderBreathMateria), 100),
			new LootPackItem(typeof(BoulderCircleMateria), 100),
			new LootPackItem(typeof(BoulderLineMateria), 100),
			new LootPackItem(typeof(BrigandSummoningMateria), 100),
			new LootPackItem(typeof(BronzeElementalSummoningMateria), 100),
			new LootPackItem(typeof(BrownBearSummoningMateria), 100),
			new LootPackItem(typeof(BullFrogSummoningMateria), 100),
			new LootPackItem(typeof(BullSummoningMateria), 100),
			new LootPackItem(typeof(CatSummoningMateria), 100),
			new LootPackItem(typeof(CentaurSummoningMateria), 100),
			new LootPackItem(typeof(ChaosDaemonSummoningMateria), 100),
			new LootPackItem(typeof(ChaosDragoonEliteSummoningMateria), 100),
			new LootPackItem(typeof(ChaosDragoonSummoningMateria), 100),
			new LootPackItem(typeof(ChickenSummoningMateria), 100),
			new LootPackItem(typeof(CopperElementalSummoningMateria), 100),
			new LootPackItem(typeof(CorpserSummoningMateria), 100),
			new LootPackItem(typeof(CorrosiveSlimeSummoningMateria), 100),
			new LootPackItem(typeof(CorruptedSoulMateria), 100),
			new LootPackItem(typeof(CougarSummoningMateria), 100),
			new LootPackItem(typeof(CowSummoningMateria), 100),
			new LootPackItem(typeof(CraneSummoningMateria), 100),
			new LootPackItem(typeof(CrankBreathMateria), 100),
			new LootPackItem(typeof(CrankCircleMateria), 100),
			new LootPackItem(typeof(CrankLineMateria), 100),
			new LootPackItem(typeof(CrimsonDragonSummoningMateria), 100),
			new LootPackItem(typeof(CrystalElementalSummoningMateria), 100),
			new LootPackItem(typeof(CurtainBreathMateria), 100),
			new LootPackItem(typeof(CurtainCircleMateria), 100),
			new LootPackItem(typeof(CurtainLineMateria), 100),
			new LootPackItem(typeof(CuSidheSummoningMateria), 100),
			new LootPackItem(typeof(CyclopsSummoningMateria), 100),
			new LootPackItem(typeof(DaemonSummoningMateria), 100),
			new LootPackItem(typeof(DarkWispSummoningMateria), 100),
			new LootPackItem(typeof(DarkWolfSummoningMateria), 100),
			new LootPackItem(typeof(DeathWatchBeetleSummoningMateria), 100),
			new LootPackItem(typeof(DeepSeaSerpentSummoningMateria), 100),
			new LootPackItem(typeof(DeerBreathMateria), 100),
			new LootPackItem(typeof(DeerCircleMateria), 100),
			new LootPackItem(typeof(DeerLineMateria), 100),
			new LootPackItem(typeof(DemonKnightSummoningMateria), 100),
			new LootPackItem(typeof(DesertOstardSummoningMateria), 100),
			new LootPackItem(typeof(DevourerSummoningMateria), 100),
			new LootPackItem(typeof(DireWolfSummoningMateria), 100),
			new LootPackItem(typeof(DogSummoningMateria), 100),
			new LootPackItem(typeof(DolphinSummoningMateria), 100),
			new LootPackItem(typeof(DopplegangerSummoningMateria), 100),
			new LootPackItem(typeof(DragonSummoningMateria), 100),
			new LootPackItem(typeof(DrakeSummoningMateria), 100),
			new LootPackItem(typeof(DreadSpiderSummoningMateria), 100),
			new LootPackItem(typeof(DullCopperElementalSummoningMateria), 100),
			new LootPackItem(typeof(DVortexBreathMateria), 100),
			new LootPackItem(typeof(DVortexCircleMateria), 100),
			new LootPackItem(typeof(DVortexLineMateria), 100),
			new LootPackItem(typeof(EagleSummoningMateria), 100),
			new LootPackItem(typeof(EarthElementalSummoningMateria), 100),
			new LootPackItem(typeof(EfreetSummoningMateria), 100),
			new LootPackItem(typeof(ElderGazerSummoningMateria), 100),
			new LootPackItem(typeof(EliteNinjaSummoningMateria), 100),
			new LootPackItem(typeof(EttinSummoningMateria), 100),
			new LootPackItem(typeof(EvilHealerSummoningMateria), 100),
			new LootPackItem(typeof(EvilMageSummoningMateria), 100),
			new LootPackItem(typeof(ExecutionerMateria), 100),
			new LootPackItem(typeof(ExodusMinionSummoningMateria), 100),
			new LootPackItem(typeof(ExodusOverseerSummoningMateria), 100),
			new LootPackItem(typeof(FanDancerSummoningMateria), 100),
			new LootPackItem(typeof(FeralTreefellowSummoningMateria), 100),
			new LootPackItem(typeof(FetidEssenceMateria), 100),
			new LootPackItem(typeof(FireBeetleSummoningMateria), 100),
			new LootPackItem(typeof(FireElementalSummoningMateria), 100),
			new LootPackItem(typeof(FireGargoyleSummoningMateria), 100),
			new LootPackItem(typeof(FireSteedSummoningMateria), 100),
			new LootPackItem(typeof(FlaskBreathMateria), 100),
			new LootPackItem(typeof(FlaskCircleMateria), 100),
			new LootPackItem(typeof(FlaskLineMateria), 100),
			new LootPackItem(typeof(FleshGolemSummoningMateria), 100),
			new LootPackItem(typeof(FleshRendererSummoningMateria), 100),
			new LootPackItem(typeof(ForestOstardSummoningMateria), 100),
			new LootPackItem(typeof(FrenziedOstardSummoningMateria), 100),
			new LootPackItem(typeof(FrostOozeSummoningMateria), 100),
			new LootPackItem(typeof(FrostSpiderSummoningMateria), 100),
			new LootPackItem(typeof(FrostTrollSummoningMateria), 100),
			new LootPackItem(typeof(FTreeCircleMateria), 100),
			new LootPackItem(typeof(FTreeLineMateria), 100),
			new LootPackItem(typeof(GamanSummoningMateria), 100),
			new LootPackItem(typeof(GargoyleSummoningMateria), 100),
			new LootPackItem(typeof(GasBreathMateria), 100),
			new LootPackItem(typeof(GasCircleMateria), 100),
			new LootPackItem(typeof(GasLineMateria), 100),
			new LootPackItem(typeof(GateBreathMateria), 100),
			new LootPackItem(typeof(GateCircleMateria), 100),
			new LootPackItem(typeof(GateLineMateria), 100),
			new LootPackItem(typeof(GazerSummoningMateria), 100),
			new LootPackItem(typeof(GhoulSummoningMateria), 100),
			new LootPackItem(typeof(GiantBlackWidowSummoningMateria), 100),
			new LootPackItem(typeof(GiantRatSummoningMateria), 100),
			new LootPackItem(typeof(GiantSerpentSummoningMateria), 100),
			new LootPackItem(typeof(GiantSpiderSummoningMateria), 100),
			new LootPackItem(typeof(GiantToadSummoningMateria), 100),
			new LootPackItem(typeof(GibberlingSummoningMateria), 100),
			new LootPackItem(typeof(GlowBreathMateria), 100),
			new LootPackItem(typeof(GlowCircleMateria), 100),
			new LootPackItem(typeof(GlowLineMateria), 100),
			new LootPackItem(typeof(GoatSummoningMateria), 100),
			new LootPackItem(typeof(GoldenElementalSummoningMateria), 100),
			new LootPackItem(typeof(GolemSummoningMateria), 100),
			new LootPackItem(typeof(GoreFiendSummoningMateria), 100),
			new LootPackItem(typeof(GorillaSummoningMateria), 100),
			new LootPackItem(typeof(GreaterDragonSummoningMateria), 100),
			new LootPackItem(typeof(GreaterMongbatSummoningMateria), 100),
			new LootPackItem(typeof(GreatHartSummoningMateria), 100),
			new LootPackItem(typeof(GreyWolfSummoningMateria), 100),
			new LootPackItem(typeof(GrizzlyBearSummoningMateria), 100),
			new LootPackItem(typeof(GuillotineBreathMateria), 100),
			new LootPackItem(typeof(GuillotineCircleMateria), 100),
			new LootPackItem(typeof(GuillotineLineMateria), 100),
			new LootPackItem(typeof(HarpySummoningMateria), 100),
			new LootPackItem(typeof(HeadBreathMateria), 100),
			new LootPackItem(typeof(HeadCircleMateria), 100),
			new LootPackItem(typeof(HeadlessOneSummoningMateria), 100),
			new LootPackItem(typeof(HeadLineMateria), 100),
			new LootPackItem(typeof(HealerMateria), 100),
			new LootPackItem(typeof(HeartBreathMateria), 100),
			new LootPackItem(typeof(HeartCircleMateria), 100),
			new LootPackItem(typeof(HeartLineMateria), 100),
			new LootPackItem(typeof(HellCatSummoningMateria), 100),
			new LootPackItem(typeof(HellHoundSummoningMateria), 100),
			new LootPackItem(typeof(HellSteedSummoningMateria), 100),
			new LootPackItem(typeof(HindSummoningMateria), 100),
			new LootPackItem(typeof(HiryuSummoningMateria), 100),
			new LootPackItem(typeof(HorseSummoningMateria), 100),
			new LootPackItem(typeof(IceElementalSummoningMateria), 100),
			new LootPackItem(typeof(IceFiendSummoningMateria), 100),
			new LootPackItem(typeof(IceSerpentSummoningMateria), 100),
			new LootPackItem(typeof(IceSnakeSummoningMateria), 100),
			new LootPackItem(typeof(ImpSummoningMateria), 100),
			new LootPackItem(typeof(JackRabbitSummoningMateria), 100),
			new LootPackItem(typeof(KazeKemonoSummoningMateria), 100),
			new LootPackItem(typeof(KirinSummoningMateria), 100),
			new LootPackItem(typeof(LavaLizardSummoningMateria), 100),
			new LootPackItem(typeof(LavaSerpentSummoningMateria), 100),
			new LootPackItem(typeof(LavaSnakeSummoningMateria), 100),
			new LootPackItem(typeof(LesserHiryuSummoningMateria), 100),
			new LootPackItem(typeof(LichLordSummoningMateria), 100),
			new LootPackItem(typeof(LichSummoningMateria), 100),
			new LootPackItem(typeof(LizardmanSummoningMateria), 100),
			new LootPackItem(typeof(LlamaSummoningMateria), 100),
			new LootPackItem(typeof(MaidenBreathMateria), 100),
			new LootPackItem(typeof(MaidenCircleMateria), 100),
			new LootPackItem(typeof(MaidenLineMateria), 100),
			new LootPackItem(typeof(MinotaurCaptainSummoningMateria), 100),
			new LootPackItem(typeof(MountainGoatSummoningMateria), 100),
			new LootPackItem(typeof(MummySummoningMateria), 100),
			new LootPackItem(typeof(MushroomBreathMateria), 100),
			new LootPackItem(typeof(MushroomCircleMateria), 100),
			new LootPackItem(typeof(MushroomLineMateria), 100),
			new LootPackItem(typeof(NightmareSummoningMateria), 100),
			new LootPackItem(typeof(NutcrackerBreathMateria), 100),
			new LootPackItem(typeof(NutcrackerCircleMateria), 100),
			new LootPackItem(typeof(NutcrackerLineMateria), 100),
			new LootPackItem(typeof(OFlaskBreathMateria), 100),
			new LootPackItem(typeof(OFlaskCircleMateria), 100),
			new LootPackItem(typeof(OFlaskMateria), 100),
			new LootPackItem(typeof(OgreLordSummoningMateria), 100),
			new LootPackItem(typeof(OgreSummoningMateria), 100),
			new LootPackItem(typeof(OniSummoningMateria), 100),
			new LootPackItem(typeof(OphidianArchmageSummoningMateria), 100),
			new LootPackItem(typeof(OphidianKnightSummoningMateria), 100),
			new LootPackItem(typeof(OrcBomberSummoningMateria), 100),
			new LootPackItem(typeof(OrcBruteSummoningMateria), 100),
			new LootPackItem(typeof(OrcCaptainSummoningMateria), 100),
			new LootPackItem(typeof(OrcishLordSummoningMateria), 100),
			new LootPackItem(typeof(OrcishMageSummoningMateria), 100),
			new LootPackItem(typeof(OrcSummoningMateria), 100),
			new LootPackItem(typeof(PackHorseSummoningMateria), 100),
			new LootPackItem(typeof(PackLlamaSummoningMateria), 100),
			new LootPackItem(typeof(PantherSummoningMateria), 100),
			new LootPackItem(typeof(ParaBreathMateria), 100),
			new LootPackItem(typeof(ParaCircleMateria), 100),
			new LootPackItem(typeof(ParaLineMateria), 100),
			new LootPackItem(typeof(PhoenixSummoningMateria), 100),
			new LootPackItem(typeof(PigSummoningMateria), 100),
			new LootPackItem(typeof(PixieSummoningMateria), 100),
			new LootPackItem(typeof(PlagueBeastSummoningMateria), 100),
			new LootPackItem(typeof(PoisonElementalSummoningMateria), 100),
			new LootPackItem(typeof(PolarBearSummoningMateria), 100),
			new LootPackItem(typeof(RabbitSummoningMateria), 100),
			new LootPackItem(typeof(RaiJuSummoningMateria), 100),
			new LootPackItem(typeof(RatmanArcherSummoningMateria), 100),
			new LootPackItem(typeof(RatmanMageSummoningMateria), 100),
			new LootPackItem(typeof(RatmanSummoningMateria), 100),
			new LootPackItem(typeof(RatSummoningMateria), 100),
			new LootPackItem(typeof(ReaperSummoningMateria), 100),
			new LootPackItem(typeof(RevenantSummoningMateria), 100),
			new LootPackItem(typeof(RidgebackSummoningMateria), 100),
			new LootPackItem(typeof(RikktorSummoningMateria), 100),
			new LootPackItem(typeof(RoninSummoningMateria), 100),
			new LootPackItem(typeof(RuneBeetleSummoningMateria), 100),
			new LootPackItem(typeof(RuneBreathMateria), 100),
			new LootPackItem(typeof(RuneCircleMateria), 100),
			new LootPackItem(typeof(RuneLineMateria), 100),
			new LootPackItem(typeof(SatyrSummoningMateria), 100),
			new LootPackItem(typeof(SavageShamanSummoningMateria), 100),
			new LootPackItem(typeof(SavageSummoningMateria), 100),
			new LootPackItem(typeof(SawBreathMateria), 100),
			new LootPackItem(typeof(SawCircleMateria), 100),
			new LootPackItem(typeof(SawLineMateria), 100),
			new LootPackItem(typeof(ScaledSwampDragonSummoningMateria), 100),
			new LootPackItem(typeof(ScorpionSummoningMateria), 100),
			new LootPackItem(typeof(SeaSerpentSummoningMateria), 100),
			new LootPackItem(typeof(ShadowWispSummoningMateria), 100),
			new LootPackItem(typeof(ShadowWyrmSummoningMateria), 100),
			new LootPackItem(typeof(SheepSummoningMateria), 100),
			new LootPackItem(typeof(SilverSerpentSummoningMateria), 100),
			new LootPackItem(typeof(SilverSteedSummoningMateria), 100),
			new LootPackItem(typeof(SkeletalDragonSummoningMateria), 100),
			new LootPackItem(typeof(SkeletalKnightSummoningMateria), 100),
			new LootPackItem(typeof(SkeletalMageSummoningMateria), 100),
			new LootPackItem(typeof(SkeletalMountSummoningMateria), 100),
			new LootPackItem(typeof(SkeletonBreathMateria), 100),
			new LootPackItem(typeof(SkeletonCircleMateria), 100),
			new LootPackItem(typeof(SkeletonLineMateria), 100),
			new LootPackItem(typeof(SkeletonSummoningMateria), 100),
			new LootPackItem(typeof(SkullBreathMateria), 100),
			new LootPackItem(typeof(SkullCircleMateria), 100),
			new LootPackItem(typeof(SkullLineMateria), 100),
			new LootPackItem(typeof(SlimeSummoningMateria), 100),
			new LootPackItem(typeof(SmokeBreathMateria), 100),
			new LootPackItem(typeof(SmokeCircleMateria), 100),
			new LootPackItem(typeof(SmokeLineMateria), 100),
			new LootPackItem(typeof(SnakeSummoningMateria), 100),
			new LootPackItem(typeof(SnowElementalSummoningMateria), 100),
			new LootPackItem(typeof(SnowLeopardSummoningMateria), 100),
			new LootPackItem(typeof(SocketDeed), 100),
			new LootPackItem(typeof(SocketDeed1), 100),
			new LootPackItem(typeof(SocketDeed2), 100),
			new LootPackItem(typeof(SocketDeed3), 100),
			new LootPackItem(typeof(SocketDeed4), 100),
			new LootPackItem(typeof(SocketDeed5), 100),
			new LootPackItem(typeof(SparkleBreathMateria), 100),
			new LootPackItem(typeof(SparkleCircleMateria), 100),
			new LootPackItem(typeof(SparkleLineMateria), 100),
			new LootPackItem(typeof(SpikeBreathMateria), 100),
			new LootPackItem(typeof(SpikeCircleMateria), 100),
			new LootPackItem(typeof(SpikeLineMateria), 100),
			new LootPackItem(typeof(StoneBreathMateria), 100),
			new LootPackItem(typeof(StoneCircleMateria), 100),
			new LootPackItem(typeof(StoneLineMateria), 100),
			new LootPackItem(typeof(SuccubusSummoningMateria), 100),
			new LootPackItem(typeof(TimeBreathMateria), 100),
			new LootPackItem(typeof(TimeCircleMateria), 100),
			new LootPackItem(typeof(TimeLineMateria), 100),
			new LootPackItem(typeof(TitanSummoningMateria), 100),
			new LootPackItem(typeof(ToxicElementalSummoningMateria), 100),
			new LootPackItem(typeof(TrapBreathMateria), 100),
			new LootPackItem(typeof(TrapCircleMateria), 100),
			new LootPackItem(typeof(TrapLineMateria), 100),
			new LootPackItem(typeof(TreeBreathMateria), 100),
			new LootPackItem(typeof(TroglodyteSummoningMateria), 100),
			new LootPackItem(typeof(TrollSummoningMateria), 100),
			new LootPackItem(typeof(UnicornSummoningMateria), 100),
			new LootPackItem(typeof(ValoriteElementalSummoningMateria), 100),
			new LootPackItem(typeof(VampireBatSummoningMateria), 100),
			new LootPackItem(typeof(VeriteElementalSummoningMateria), 100),
			new LootPackItem(typeof(VortexBreathMateria), 100),
			new LootPackItem(typeof(VortexCircleMateria), 100),
			new LootPackItem(typeof(VortexLineMateria), 100),
			new LootPackItem(typeof(WalrusSummoningMateria), 100),
			new LootPackItem(typeof(WaterBreathMateria), 100),
			new LootPackItem(typeof(WaterCircleMateria), 100),
			new LootPackItem(typeof(WaterElementalSummoningMateria), 100),
			new LootPackItem(typeof(WaterLineMateria), 100),
			new LootPackItem(typeof(WhiteWolfSummoningMateria), 100),
			new LootPackItem(typeof(WhiteWyrmSummoningMateria), 100),
			new LootPackItem(typeof(WispSummoningMateria), 100),
			new LootPackItem(typeof(WraithSummoningMateria), 100),
			new LootPackItem(typeof(WyvernSummoningMateria), 100),
			new LootPackItem(typeof(ZombieSummoningMateria), 100),
			new LootPackItem(typeof(MythicAmethyst), 100),
			new LootPackItem(typeof(LegendaryAmethyst), 100),
			new LootPackItem(typeof(AncientAmethyst), 100),
			new LootPackItem(typeof(FenCrystal), 100),
			new LootPackItem(typeof(RhoCrystal), 100),
			new LootPackItem(typeof(RysCrystal), 100),
			new LootPackItem(typeof(WyrCrystal), 100),
			new LootPackItem(typeof(FreCrystal), 100),
			new LootPackItem(typeof(TorCrystal), 100),
			new LootPackItem(typeof(VelCrystal), 100),
			new LootPackItem(typeof(XenCrystal), 100),
			new LootPackItem(typeof(PolCrystal), 100),
			new LootPackItem(typeof(WolCrystal), 100),
			new LootPackItem(typeof(BalCrystal), 100),
			new LootPackItem(typeof(TalCrystal), 100),
			new LootPackItem(typeof(JalCrystal), 100),
			new LootPackItem(typeof(RalCrystal), 100),
			new LootPackItem(typeof(KalCrystal), 100),
			new LootPackItem(typeof(MythicDiamond), 100),
			new LootPackItem(typeof(LegendaryDiamond), 100),
			new LootPackItem(typeof(AncientDiamond), 100),
			new LootPackItem(typeof(MythicEmerald), 100),
			new LootPackItem(typeof(LegendaryEmerald), 100),
			new LootPackItem(typeof(AncientEmerald), 100),
			new LootPackItem(typeof(KeyAugment), 100),
			new LootPackItem(typeof(RadiantRhoCrystal), 100),
			new LootPackItem(typeof(RadiantRysCrystal), 100),
			new LootPackItem(typeof(RadiantWyrCrystal), 100),
			new LootPackItem(typeof(RadiantFreCrystal), 100),
			new LootPackItem(typeof(RadiantTorCrystal), 100),
			new LootPackItem(typeof(RadiantVelCrystal), 100),
			new LootPackItem(typeof(RadiantXenCrystal), 100),
			new LootPackItem(typeof(RadiantPolCrystal), 100),
			new LootPackItem(typeof(RadiantWolCrystal), 100),
			new LootPackItem(typeof(RadiantBalCrystal), 100),
			new LootPackItem(typeof(RadiantTalCrystal), 100),
			new LootPackItem(typeof(RadiantJalCrystal), 100),
			new LootPackItem(typeof(RadiantRalCrystal), 100),
			new LootPackItem(typeof(RadiantKalCrystal), 100),
			new LootPackItem(typeof(MythicRuby), 100),
			new LootPackItem(typeof(LegendaryRuby), 100),
			new LootPackItem(typeof(AncientRuby), 100),
			new LootPackItem(typeof(TyrRune), 100),
			new LootPackItem(typeof(AhmRune), 100),
			new LootPackItem(typeof(MorRune), 100),
			new LootPackItem(typeof(MefRune), 100),
			new LootPackItem(typeof(YlmRune), 100),
			new LootPackItem(typeof(KotRune), 100),
			new LootPackItem(typeof(JorRune), 100),
			new LootPackItem(typeof(MythicSapphire), 100),
			new LootPackItem(typeof(LegendarySapphire), 100),
			new LootPackItem(typeof(AncientSapphire), 100),
			new LootPackItem(typeof(MythicSkull), 100),
			new LootPackItem(typeof(AncientSkull), 100),
			new LootPackItem(typeof(LegendarySkull), 100),
			new LootPackItem(typeof(GlimmeringGranite), 100),
			new LootPackItem(typeof(GlimmeringClay), 100),
			new LootPackItem(typeof(GlimmeringHeartstone), 100),
			new LootPackItem(typeof(GlimmeringGypsum), 100),
			new LootPackItem(typeof(GlimmeringIronOre), 100),
			new LootPackItem(typeof(GlimmeringOnyx), 100),
			new LootPackItem(typeof(GlimmeringMarble), 100),
			new LootPackItem(typeof(GlimmeringPetrifiedWood), 100),
			new LootPackItem(typeof(GlimmeringLimestone), 100),
			new LootPackItem(typeof(GlimmeringBloodrock), 100),
			new LootPackItem(typeof(MythicTourmaline), 100),
			new LootPackItem(typeof(LegendaryTourmaline), 100),
			new LootPackItem(typeof(AncientTourmaline), 100),
			new LootPackItem(typeof(MythicWood), 100),
			new LootPackItem(typeof(LegendaryWood), 100),
			new LootPackItem(typeof(AncientWood), 100)
			
		};
		#endregion

		#region ML definitions
		public static readonly LootPack MlRich =
			new LootPack(
				new[]
				{
					new LootPackEntry(true, Gold, 100.00, "4d50+450"),
					new LootPackEntry(false, AosMagicItemsRichType1, 100.00, 1, 3, 0, 75),
					new LootPackEntry(false, AosMagicItemsRichType1, 80.00, 1, 3, 0, 75),
					new LootPackEntry(false, AosMagicItemsRichType1, 60.00, 1, 5, 0, 100),
					new LootPackEntry(false, Instruments, 1.00, 1)
				});
		#endregion

		#region SE definitions
		public static readonly LootPack SePoor =
			new LootPack(
				new[]
				{
					new LootPackEntry(true, Gold, 100.00, "2d10+20"), new LootPackEntry(false, AosMagicItemsPoor, 1.00, 1, 5, 0, 100),
					new LootPackEntry(false, Instruments, 0.02, 1),
					new LootPackEntry(false, NewFilthyRichItems, 1.00, "1") // Assuming you want 1 item

				});

		public static readonly LootPack SeMeager =
			new LootPack(
				new[]
				{
					new LootPackEntry(true, Gold, 100.00, "4d10+40"),
					new LootPackEntry(false, AosMagicItemsMeagerType1, 20.40, 1, 2, 0, 50),
					new LootPackEntry(false, AosMagicItemsMeagerType2, 10.20, 1, 5, 0, 100),
					new LootPackEntry(false, Instruments, 0.10, 1),
					new LootPackEntry(false, NewFilthyRichItems, 2.00, "1") // Assuming you want 1 item

				});

		public static readonly LootPack SeAverage =
			new LootPack(
				new[]
				{
					new LootPackEntry(true, Gold, 100.00, "8d10+100"),
					new LootPackEntry(false, AosMagicItemsAverageType1, 32.80, 1, 7, 50, 100),
					new LootPackEntry(false, AosMagicItemsAverageType1, 32.80, 1, 7, 50, 100),
					new LootPackEntry(false, AosMagicItemsAverageType2, 19.50, 1, 7, 50, 100),
					new LootPackEntry(false, Instruments, 0.40, 1),
					new LootPackEntry(false, NewFilthyRichItems, 3.00, "1") // Assuming you want 1 item
				});

		public static readonly LootPack SeRich =
			new LootPack(
				new[]
				{
					new LootPackEntry(true, Gold, 100.00, "15d10+225"),
					new LootPackEntry(false, AosMagicItemsRichType1, 76.30, 1, 7, 50, 100),
					new LootPackEntry(false, AosMagicItemsRichType1, 76.30, 1, 7, 50, 100),
					new LootPackEntry(false, AosMagicItemsRichType2, 61.70, 1, 7, 50, 100),
					new LootPackEntry(false, Instruments, 1.00, 1),
					new LootPackEntry(false, NewFilthyRichItems, 5.00, "1") // Assuming you want 1 item
				});

		public static readonly LootPack SeFilthyRich =
			new LootPack(
				new[]
				{
					new LootPackEntry(true, Gold, 100.00, "3d100+400"),
					new LootPackEntry(false, AosMagicItemsFilthyRichType1, 79.50, 1, 7, 50, 100),
					new LootPackEntry(false, AosMagicItemsFilthyRichType1, 79.50, 1, 7, 50, 100),
					new LootPackEntry(false, AosMagicItemsFilthyRichType2, 77.60, 1, 7, 50, 100),
					new LootPackEntry(false, Instruments, 2.00, 1),
					new LootPackEntry(false, NewFilthyRichItems, 100.00, "1") // Assuming you want 1 item
				});

		public static readonly LootPack SeUltraRich =
			new LootPack(
				new[]
				{
					new LootPackEntry(true, Gold, 100.00, "6d100+600"),
					new LootPackEntry(false, AosMagicItemsUltraRich, 100.00, 1, 7, 50, 100),
					new LootPackEntry(false, AosMagicItemsUltraRich, 100.00, 1, 7, 50, 100),
					new LootPackEntry(false, AosMagicItemsUltraRich, 100.00, 1, 7, 50, 100),
					new LootPackEntry(false, AosMagicItemsUltraRich, 100.00, 1, 7, 50, 100),
					new LootPackEntry(false, AosMagicItemsUltraRich, 100.00, 1, 7, 50, 100),
					new LootPackEntry(false, AosMagicItemsUltraRich, 100.00, 1, 7, 50, 100),
					new LootPackEntry(false, Instruments, 2.00, 1),
					new LootPackEntry(false, NewFilthyRichItems, 100.00, "2") // Assuming you want 1 item
				});

		public static readonly LootPack SeSuperBoss =
			new LootPack(
				new[]
				{
					new LootPackEntry(true, Gold, 100.00, "10d100+800"),
					new LootPackEntry(false, AosMagicItemsUltraRich, 100.00, 1, 7, 50, 100),
					new LootPackEntry(false, AosMagicItemsUltraRich, 100.00, 1, 7, 50, 100),
					new LootPackEntry(false, AosMagicItemsUltraRich, 100.00, 1, 7, 50, 100),
					new LootPackEntry(false, AosMagicItemsUltraRich, 100.00, 1, 7, 50, 100),
					new LootPackEntry(false, AosMagicItemsUltraRich, 100.00, 1, 7, 50, 100),
					new LootPackEntry(false, AosMagicItemsUltraRich, 100.00, 1, 7, 50, 100),
					new LootPackEntry(false, AosMagicItemsUltraRich, 100.00, 1, 7, 50, 100),
					new LootPackEntry(false, AosMagicItemsUltraRich, 100.00, 1, 7, 50, 100),
					new LootPackEntry(false, AosMagicItemsUltraRich, 100.00, 1, 7, 50, 100),
					new LootPackEntry(false, AosMagicItemsUltraRich, 100.00, 1, 7, 50, 100),
					new LootPackEntry(false, Instruments, 2.00, 1),
					new LootPackEntry(false, NewFilthyRichItems, 100.00, "3") // Assuming you want 1 item
				});
		#endregion

		#region AOS definitions
		public static readonly LootPack AosPoor =
			new LootPack(
				new[]
				{
					new LootPackEntry(true, Gold, 100.00, "1d10+10"), new LootPackEntry(false, AosMagicItemsPoor, 0.02, 1, 5, 0, 90),
					new LootPackEntry(false, Instruments, 0.02, 1)
				});

		public static readonly LootPack AosMeager =
			new LootPack(
				new[]
				{
					new LootPackEntry(true, Gold, 100.00, "3d10+20"),
					new LootPackEntry(false, AosMagicItemsMeagerType1, 1.00, 1, 2, 0, 10),
					new LootPackEntry(false, AosMagicItemsMeagerType2, 0.20, 1, 5, 0, 90),
					new LootPackEntry(false, Instruments, 0.10, 1)
				});

		public static readonly LootPack AosAverage =
			new LootPack(
				new[]
				{
					new LootPackEntry(true, Gold, 100.00, "5d10+50"),
					new LootPackEntry(false, AosMagicItemsAverageType1, 5.00, 1, 4, 0, 20),
					new LootPackEntry(false, AosMagicItemsAverageType1, 2.00, 1, 3, 0, 50),
					new LootPackEntry(false, AosMagicItemsAverageType2, 0.50, 1, 5, 0, 90),
					new LootPackEntry(false, Instruments, 0.40, 1)
				});

		public static readonly LootPack AosRich =
			new LootPack(
				new[]
				{
					new LootPackEntry(true, Gold, 100.00, "10d10+150"),
					new LootPackEntry(false, AosMagicItemsRichType1, 20.00, 1, 4, 0, 40),
					new LootPackEntry(false, AosMagicItemsRichType1, 10.00, 1, 5, 0, 60),
					new LootPackEntry(false, AosMagicItemsRichType2, 1.00, 1, 5, 0, 90), new LootPackEntry(false, Instruments, 1.00, 1)
				});

		public static readonly LootPack AosFilthyRich =
			new LootPack(
				new[]
				{
					new LootPackEntry(true, Gold, 100.00, "2d100+200"),
					new LootPackEntry(false, AosMagicItemsFilthyRichType1, 33.00, 1, 4, 0, 50),
					new LootPackEntry(false, AosMagicItemsFilthyRichType1, 33.00, 1, 4, 0, 60),
					new LootPackEntry(false, AosMagicItemsFilthyRichType2, 20.00, 1, 5, 0, 75),
					new LootPackEntry(false, AosMagicItemsFilthyRichType2, 5.00, 1, 5, 0, 100),
					new LootPackEntry(false, Instruments, 2.00, 1)
				});

		public static readonly LootPack AosUltraRich =
			new LootPack(
				new[]
				{
					new LootPackEntry(true, Gold, 100.00, "5d100+500"),
					new LootPackEntry(false, AosMagicItemsUltraRich, 100.00, 1, 7, 50, 100),
					new LootPackEntry(false, AosMagicItemsUltraRich, 100.00, 1, 7, 50, 100),
					new LootPackEntry(false, AosMagicItemsUltraRich, 100.00, 1, 7, 50, 100),
					new LootPackEntry(false, AosMagicItemsUltraRich, 100.00, 1, 7, 50, 100),
					new LootPackEntry(false, AosMagicItemsUltraRich, 100.00, 1, 7, 50, 100),
					new LootPackEntry(false, AosMagicItemsUltraRich, 100.00, 1, 5, 35, 100),
					new LootPackEntry(false, Instruments, 2.00, 1)
				});

		public static readonly LootPack AosSuperBoss =
			new LootPack(
				new[]
				{
					new LootPackEntry(true, Gold, 100.00, "5d100+500"),
					new LootPackEntry(false, AosMagicItemsUltraRich, 100.00, 1, 7, 50, 100),
					new LootPackEntry(false, AosMagicItemsUltraRich, 100.00, 1, 7, 50, 100),
					new LootPackEntry(false, AosMagicItemsUltraRich, 100.00, 1, 7, 50, 100),
					new LootPackEntry(false, AosMagicItemsUltraRich, 100.00, 1, 7, 50, 100),
					new LootPackEntry(false, AosMagicItemsUltraRich, 100.00, 1, 7, 50, 100),
					new LootPackEntry(false, AosMagicItemsUltraRich, 100.00, 1, 7, 50, 100),
					new LootPackEntry(false, AosMagicItemsUltraRich, 100.00, 1, 7, 50, 100),
					new LootPackEntry(false, AosMagicItemsUltraRich, 100.00, 1, 7, 50, 100),
					new LootPackEntry(false, AosMagicItemsUltraRich, 100.00, 1, 5, 50, 100),
					new LootPackEntry(false, AosMagicItemsUltraRich, 100.00, 1, 5, 50, 100),
					new LootPackEntry(false, Instruments, 2.00, 1)
				});
		#endregion

		#region Pre-AOS definitions
		public static readonly LootPack OldPoor =
			new LootPack(new[] {new LootPackEntry(true, Gold, 100.00, "1d25"), new LootPackEntry(false, Instruments, 0.02, 1)});

		public static readonly LootPack OldMeager =
			new LootPack(
				new[]
				{
					new LootPackEntry(true, Gold, 100.00, "5d10+25"), new LootPackEntry(false, Instruments, 0.10, 1),
					new LootPackEntry(false, OldMagicItems, 1.00, 1, 1, 0, 60),
					new LootPackEntry(false, OldMagicItems, 0.20, 1, 1, 10, 70)
				});

		public static readonly LootPack OldAverage =
			new LootPack(
				new[]
				{
					new LootPackEntry(true, Gold, 100.00, "10d10+50"), new LootPackEntry(false, Instruments, 0.40, 1),
					new LootPackEntry(false, OldMagicItems, 5.00, 1, 1, 20, 80),
					new LootPackEntry(false, OldMagicItems, 2.00, 1, 1, 30, 90),
					new LootPackEntry(false, OldMagicItems, 0.50, 1, 1, 40, 100)
				});

		public static readonly LootPack OldRich =
			new LootPack(
				new[]
				{
					new LootPackEntry(true, Gold, 100.00, "10d10+250"), new LootPackEntry(false, Instruments, 1.00, 1),
					new LootPackEntry(false, OldMagicItems, 20.00, 1, 1, 60, 100),
					new LootPackEntry(false, OldMagicItems, 10.00, 1, 1, 65, 100),
					new LootPackEntry(false, OldMagicItems, 1.00, 1, 1, 70, 100)
				});

		public static readonly LootPack OldFilthyRich =
			new LootPack(
				new[]
				{
					new LootPackEntry(true, Gold, 100.00, "2d125+400"), new LootPackEntry(false, Instruments, 2.00, 1),
					new LootPackEntry(false, OldMagicItems, 33.00, 1, 1, 50, 100),
					new LootPackEntry(false, OldMagicItems, 33.00, 1, 1, 60, 100),
					new LootPackEntry(false, OldMagicItems, 20.00, 1, 1, 70, 100),
					new LootPackEntry(false, OldMagicItems, 5.00, 1, 1, 80, 100)
				});

		public static readonly LootPack OldUltraRich =
			new LootPack(
				new[]
				{
					new LootPackEntry(true, Gold, 100.00, "5d100+500"), new LootPackEntry(false, Instruments, 2.00, 1),
					new LootPackEntry(false, OldMagicItems, 100.00, 1, 1, 40, 100),
					new LootPackEntry(false, OldMagicItems, 100.00, 1, 1, 40, 100),
					new LootPackEntry(false, OldMagicItems, 100.00, 1, 1, 50, 100),
					new LootPackEntry(false, OldMagicItems, 100.00, 1, 1, 50, 100),
					new LootPackEntry(false, OldMagicItems, 100.00, 1, 1, 60, 100),
					new LootPackEntry(false, OldMagicItems, 100.00, 1, 1, 60, 100)
				});

		public static readonly LootPack OldSuperBoss =
			new LootPack(
				new[]
				{
					new LootPackEntry(true, Gold, 100.00, "5d100+500"), new LootPackEntry(false, Instruments, 2.00, 1),
					new LootPackEntry(false, OldMagicItems, 100.00, 1, 1, 40, 100),
					new LootPackEntry(false, OldMagicItems, 100.00, 1, 1, 40, 100),
					new LootPackEntry(false, OldMagicItems, 100.00, 1, 1, 40, 100),
					new LootPackEntry(false, OldMagicItems, 100.00, 1, 1, 50, 100),
					new LootPackEntry(false, OldMagicItems, 100.00, 1, 1, 50, 100),
					new LootPackEntry(false, OldMagicItems, 100.00, 1, 1, 50, 100),
					new LootPackEntry(false, OldMagicItems, 100.00, 1, 1, 60, 100),
					new LootPackEntry(false, OldMagicItems, 100.00, 1, 1, 60, 100),
					new LootPackEntry(false, OldMagicItems, 100.00, 1, 1, 60, 100),
					new LootPackEntry(false, OldMagicItems, 100.00, 1, 1, 70, 100)
				});
		#endregion

		#region Generic accessors
		public static LootPack Poor { get { return Core.SE ? SePoor : Core.AOS ? AosPoor : OldPoor; } }
		public static LootPack Meager { get { return Core.SE ? SeMeager : Core.AOS ? AosMeager : OldMeager; } }
		public static LootPack Average { get { return Core.SE ? SeAverage : Core.AOS ? AosAverage : OldAverage; } }
		public static LootPack Rich { get { return Core.SE ? SeRich : Core.AOS ? AosRich : OldRich; } }
		public static LootPack FilthyRich { get { return Core.SE ? SeFilthyRich : Core.AOS ? AosFilthyRich : OldFilthyRich; } }
		public static LootPack UltraRich { get { return Core.SE ? SeUltraRich : Core.AOS ? AosUltraRich : OldUltraRich; } }
		public static LootPack SuperBoss { get { return Core.SE ? SeSuperBoss : Core.AOS ? AosSuperBoss : OldSuperBoss; } }
		#endregion

		public static readonly LootPack LowScrolls = new LootPack(new[] {new LootPackEntry(false, LowScrollItems, 100.00, 1)});

		public static readonly LootPack MedScrolls = new LootPack(new[] {new LootPackEntry(false, MedScrollItems, 100.00, 1)});

		public static readonly LootPack HighScrolls =
			new LootPack(new[] {new LootPackEntry(false, HighScrollItems, 100.00, 1)});

		public static readonly LootPack Gems = new LootPack(new[] {new LootPackEntry(false, GemItems, 100.00, 1)});

		public static readonly LootPack Potions = new LootPack(new[] {new LootPackEntry(false, PotionItems, 100.00, 1)});

		#region Mondain's Legacy
		public static readonly LootPackItem[] ParrotItem = new[] {new LootPackItem(typeof(ParrotItem), 1)};

		public static readonly LootPack Parrot = new LootPack(new[] {new LootPackEntry(false, ParrotItem, 10.00, 1)});
		#endregion
	}

	public class LootPackEntry
	{
		private LootPackDice m_Quantity;

		private int m_MaxProps, m_MinIntensity, m_MaxIntensity;

		private readonly bool m_AtSpawnTime;

		private LootPackItem[] m_Items;

		public int Chance { get; set; }

		public LootPackDice Quantity { get { return m_Quantity; } set { m_Quantity = value; } }

		public int MaxProps { get { return m_MaxProps; } set { m_MaxProps = value; } }

		public int MinIntensity { get { return m_MinIntensity; } set { m_MinIntensity = value; } }

		public int MaxIntensity { get { return m_MaxIntensity; } set { m_MaxIntensity = value; } }

		public LootPackItem[] Items { get { return m_Items; } set { m_Items = value; } }

		public static bool IsInTokuno(IEntity e)
		{
			if (e == null)
			{
				return false;
			}

            Region r = Region.Find(e.Location, e.Map);

			if (r.IsPartOf("Fan Dancer's Dojo"))
			{
				return true;
			}

			if (r.IsPartOf("Yomotsu Mines"))
			{
				return true;
			}

			return e.Map == Map.Tokuno;
		}

		#region Mondain's Legacy
		public static bool IsMondain(IEntity e)
		{
            if (e == null)
                return false;

			return MondainsLegacy.IsMLRegion(Region.Find(e.Location, e.Map));
		}
		#endregion

		#region Stygian Abyss
		public static bool IsStygian/*Abyss*/(IEntity e)
		{
            if (e == null)
                return false;

            return e.Map == Map.TerMur || (!IsInTokuno(e) && !IsMondain(e) && Utility.RandomBool());
		}
		#endregion

		public Item Construct(Mobile from, int luckChance, bool spawning)
		{
			if (m_AtSpawnTime != spawning)
			{
				return null;
			}

			int totalChance = 0;

			for (int i = 0; i < m_Items.Length; ++i)
			{
				totalChance += m_Items[i].Chance;
			}

			int rnd = Utility.Random(totalChance);

			for (int i = 0; i < m_Items.Length; ++i)
			{
				LootPackItem item = m_Items[i];

                if (rnd < item.Chance)
                {
                    return Mutate(from, luckChance, item.Construct(IsInTokuno(from), IsMondain(from), IsStygian(from)));
                }

				rnd -= item.Chance;
			}

			return null;
		}

		private int GetRandomOldBonus()
		{
			int rnd = Utility.RandomMinMax(m_MinIntensity, m_MaxIntensity);

			if (50 > rnd)
			{
				return 1;
			}
			else
			{
				rnd -= 50;
			}

			if (25 > rnd)
			{
				return 2;
			}
			else
			{
				rnd -= 25;
			}

			if (14 > rnd)
			{
				return 3;
			}
			else
			{
				rnd -= 14;
			}

			if (8 > rnd)
			{
				return 4;
			}

			return 5;
		}

		public Item Mutate(Mobile from, int luckChance, Item item)
		{
			if (item != null)
			{
				if (item is BaseWeapon && 1 > Utility.Random(100))
				{
					item.Delete();
					item = new FireHorn();
					return item;
				}

				if (item is BaseWeapon || item is BaseArmor || item is BaseJewel || item is BaseHat)
				{
					if (Core.AOS)
					{
                        // Try to generate a new random item based on the creature killed
                        if (Core.HS && RandomItemGenerator.Enabled && from is BaseCreature)
                        {
                            if (RandomItemGenerator.GenerateRandomItem(item, ((BaseCreature)from).LastKiller, (BaseCreature)from))
                                return item;
                        }

                        int bonusProps = GetBonusProperties();
						int min = m_MinIntensity;
						int max = m_MaxIntensity;

						if (bonusProps < m_MaxProps && LootPack.CheckLuck(luckChance))
						{
							++bonusProps;
						}

						int props = 1 + bonusProps;

						// Make sure we're not spawning items with 6 properties.
						if (props > m_MaxProps)
						{
							props = m_MaxProps;
						}

                        // Use the older style random generation
						if (item is BaseWeapon)
						{
							BaseRunicTool.ApplyAttributesTo((BaseWeapon)item, false, luckChance, props, m_MinIntensity, m_MaxIntensity);
						}
						else if (item is BaseArmor)
						{
							BaseRunicTool.ApplyAttributesTo((BaseArmor)item, false, luckChance, props, m_MinIntensity, m_MaxIntensity);
						}
						else if (item is BaseJewel)
						{
							BaseRunicTool.ApplyAttributesTo((BaseJewel)item, false, luckChance, props, m_MinIntensity, m_MaxIntensity);
						}
						else if (item is BaseHat)
						{
							BaseRunicTool.ApplyAttributesTo((BaseHat)item, false, luckChance, props, m_MinIntensity, m_MaxIntensity);
						}
					}
					else // not aos
					{
						if (item is BaseWeapon)
						{
							BaseWeapon weapon = (BaseWeapon)item;

							if (80 > Utility.Random(100))
							{
								weapon.AccuracyLevel = (WeaponAccuracyLevel)GetRandomOldBonus();
							}

							if (60 > Utility.Random(100))
							{
								weapon.DamageLevel = (WeaponDamageLevel)GetRandomOldBonus();
							}

							if (40 > Utility.Random(100))
							{
								weapon.DurabilityLevel = (WeaponDurabilityLevel)GetRandomOldBonus();
							}

							if (5 > Utility.Random(100))
							{
								weapon.Slayer = SlayerName.Silver;
							}

							if (from != null && weapon.AccuracyLevel == 0 && weapon.DamageLevel == 0 && weapon.DurabilityLevel == 0 &&
								weapon.Slayer == SlayerName.None && 5 > Utility.Random(100))
							{
								weapon.Slayer = SlayerGroup.GetLootSlayerType(from.GetType());
							}
						}
						else if (item is BaseArmor)
						{
							BaseArmor armor = (BaseArmor)item;

							if (80 > Utility.Random(100))
							{
								armor.ProtectionLevel = (ArmorProtectionLevel)GetRandomOldBonus();
							}

							if (40 > Utility.Random(100))
							{
								armor.Durability = (ArmorDurabilityLevel)GetRandomOldBonus();
							}
						}
					}
				}
				else if (item is BaseInstrument)
				{
					SlayerName slayer = SlayerName.None;

					if (Core.AOS)
					{
						slayer = BaseRunicTool.GetRandomSlayer();
					}
					else
					{
						slayer = SlayerGroup.GetLootSlayerType(from.GetType());
					}

					if (slayer == SlayerName.None)
					{
						item.Delete();
						return null;
					}

					BaseInstrument instr = (BaseInstrument)item;

					instr.Quality = ItemQuality.Normal;
					instr.Slayer = slayer;
				}

				if (item.Stackable)
				{
					item.Amount = m_Quantity.Roll();
				}
			}

			return item;
		}

		public LootPackEntry(bool atSpawnTime, LootPackItem[] items, double chance, string quantity)
			: this(atSpawnTime, items, chance, new LootPackDice(quantity), 0, 0, 0)
		{ }

		public LootPackEntry(bool atSpawnTime, LootPackItem[] items, double chance, int quantity)
			: this(atSpawnTime, items, chance, new LootPackDice(0, 0, quantity), 0, 0, 0)
		{ }

		public LootPackEntry(
			bool atSpawnTime,
			LootPackItem[] items,
			double chance,
			string quantity,
			int maxProps,
			int minIntensity,
			int maxIntensity)
			: this(atSpawnTime, items, chance, new LootPackDice(quantity), maxProps, minIntensity, maxIntensity)
		{ }

		public LootPackEntry(
			bool atSpawnTime, LootPackItem[] items, double chance, int quantity, int maxProps, int minIntensity, int maxIntensity)
			: this(atSpawnTime, items, chance, new LootPackDice(0, 0, quantity), maxProps, minIntensity, maxIntensity)
		{ }

		public LootPackEntry(
			bool atSpawnTime,
			LootPackItem[] items,
			double chance,
			LootPackDice quantity,
			int maxProps,
			int minIntensity,
			int maxIntensity)
		{
			m_AtSpawnTime = atSpawnTime;
			m_Items = items;
			Chance = (int)(100 * chance);
			m_Quantity = quantity;
			m_MaxProps = maxProps;
			m_MinIntensity = minIntensity;
			m_MaxIntensity = maxIntensity;
		}

		public int GetBonusProperties()
		{
			int p0 = 0, p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;

			switch (m_MaxProps)
			{
				case 1:
					p0 = 3;
					p1 = 1;
					break;
				case 2:
					p0 = 6;
					p1 = 3;
					p2 = 1;
					break;
				case 3:
					p0 = 10;
					p1 = 6;
					p2 = 3;
					p3 = 1;
					break;
				case 4:
					p0 = 16;
					p1 = 12;
					p2 = 6;
					p3 = 5;
					p4 = 1;
					break;
				case 5:
					p0 = 30;
					p1 = 25;
					p2 = 20;
					p3 = 15;
					p4 = 9;
					p5 = 1;
					break;
			}

			int pc = p0 + p1 + p2 + p3 + p4 + p5;

			int rnd = Utility.Random(pc);

			if (rnd < p5)
			{
				return 5;
			}
			else
			{
				rnd -= p5;
			}

			if (rnd < p4)
			{
				return 4;
			}
			else
			{
				rnd -= p4;
			}

			if (rnd < p3)
			{
				return 3;
			}
			else
			{
				rnd -= p3;
			}

			if (rnd < p2)
			{
				return 2;
			}
			else
			{
				rnd -= p2;
			}

			if (rnd < p1)
			{
				return 1;
			}

			return 0;
		}
	}

	public class LootPackItem
	{
		private Type m_Type;

		public Type Type { get { return m_Type; } set { m_Type = value; } }

		public int Chance { get; set; }

		private static readonly Type[] m_BlankTypes = new[] {typeof(BlankScroll)};

		private static readonly Type[][] m_NecroTypes = new[]
		{
			new[] // low
			{
				typeof(AnimateDeadScroll), typeof(BloodOathScroll), typeof(CorpseSkinScroll), typeof(CurseWeaponScroll),
				typeof(EvilOmenScroll), typeof(HorrificBeastScroll), typeof(MindRotScroll), typeof(PainSpikeScroll),
				typeof(SummonFamiliarScroll), typeof(WraithFormScroll)
			},
			new[] // med
			{typeof(LichFormScroll), typeof(PoisonStrikeScroll), typeof(StrangleScroll), typeof(WitherScroll)},
			((Core.SE)
				 ? new[] // high
				 {typeof(VengefulSpiritScroll), typeof(VampiricEmbraceScroll), typeof(ExorcismScroll)}
				 : new[] // high
				 {typeof(VengefulSpiritScroll), typeof(VampiricEmbraceScroll)})
		};

        private static readonly SpellbookType[] m_BookTypes = new[]
        {
            SpellbookType.Regular, SpellbookType.Necromancer, SpellbookType.Mystic
        };

        private static readonly int[][] m_ScrollIndexMin = new[]
        {
            new[] {0, 8, 16, 24, 32, 40, 48, 56},
            new[] {0, 2, 4, 6, 8, 10, 12, 14},
            new[] {0, 2, 4, 6, 8, 10, 12, 14},
        };

        private static readonly int[][] m_ScrollIndexMax = new[]
        {
            new[] {7, 15, 23, 31, 39, 47, 55, 63},
            new[] {1, 3, 5, 7, 9, 11, 13, 14},
            new[] {1, 3, 5, 7, 9, 11, 13, 14},
        };

        public static Item RandomScroll(int minCircle, int maxCircle)
		{
			--minCircle;
			--maxCircle;

            int minIndex, maxIndex, rnd, rndMax;
            SpellbookType spellBookType;

            // Magery scrolls are weighted at 4 because there are four times as many magery
            // spells as other scolls of magic
            rndMax = 4;
            if (Core.ML)
                rndMax += 2;
            else if (Core.AOS)
                rndMax += 1;
            rnd = Utility.Random(rndMax);
            rnd -= 3;
            if (rnd < 0)
                rnd = 0;

            minIndex = m_ScrollIndexMin[rnd][minCircle];
            maxIndex = m_ScrollIndexMax[rnd][maxCircle];
            if (rnd == 2 && maxCircle == 7)
                ++maxIndex;
            spellBookType = m_BookTypes[rnd];

            return Loot.RandomScroll(minIndex, maxIndex, spellBookType);
		}

		public Item Construct(bool inTokuno, bool isMondain, bool isStygian)
		{
			try
			{
				Item item;

				if (m_Type == typeof(BaseRanged))
				{
					item = Loot.RandomRangedWeapon(inTokuno, isMondain, isStygian );
				}
				else if (m_Type == typeof(BaseWeapon))
				{
					item = Loot.RandomWeapon(inTokuno, isMondain, isStygian );
				}
				else if (m_Type == typeof(BaseArmor))
				{
					item = Loot.RandomArmorOrHat(inTokuno, isMondain, isStygian);
				}
				else if (m_Type == typeof(BaseShield))
				{
					item = Loot.RandomShield(isStygian);
				}
				else if (m_Type == typeof(BaseJewel))
				{
					item = Core.AOS ? Loot.RandomJewelry(isStygian) : Loot.RandomArmorOrShieldOrWeapon(isStygian);
				}
				else if (m_Type == typeof(BaseInstrument))
				{
					item = Loot.RandomInstrument();
				}
				else if (m_Type == typeof(Amber)) // gem
				{
					item = Loot.RandomGem();
				}
				else if (m_Type == typeof(ClumsyScroll)) // low scroll
				{
					item = RandomScroll(1, 3);
				}
				else if (m_Type == typeof(ArchCureScroll)) // med scroll
				{
					item = RandomScroll(4, 7);
				}
				else if (m_Type == typeof(SummonAirElementalScroll)) // high scroll
				{
					item = RandomScroll(8, 8);
				}
				else
				{
					item = Activator.CreateInstance(m_Type) as Item;
				}

				return item;
			}
			catch
			{ }

			return null;
		}

		public LootPackItem(Type type, int chance)
		{
			m_Type = type;
			Chance = chance;
		}
	}

	public class LootPackDice
	{
		private int m_Count, m_Sides, m_Bonus;

		public int Count { get { return m_Count; } set { m_Count = value; } }

		public int Sides { get { return m_Sides; } set { m_Sides = value; } }

		public int Bonus { get { return m_Bonus; } set { m_Bonus = value; } }

		public int Roll()
		{
			int v = m_Bonus;

			for (int i = 0; i < m_Count; ++i)
			{
				v += Utility.Random(1, m_Sides);
			}

			return v;
		}

		public LootPackDice(string str)
		{
			int start = 0;
			int index = str.IndexOf('d', start);

			if (index < start)
			{
				return;
			}

			m_Count = Utility.ToInt32(str.Substring(start, index - start));

			bool negative;

			start = index + 1;
			index = str.IndexOf('+', start);

			if (negative = (index < start))
			{
				index = str.IndexOf('-', start);
			}

			if (index < start)
			{
				index = str.Length;
			}

			m_Sides = Utility.ToInt32(str.Substring(start, index - start));

			if (index == str.Length)
			{
				return;
			}

			start = index + 1;
			index = str.Length;

			m_Bonus = Utility.ToInt32(str.Substring(start, index - start));

			if (negative)
			{
				m_Bonus *= -1;
			}
		}

		public LootPackDice(int count, int sides, int bonus)
		{
			m_Count = count;
			m_Sides = sides;
			m_Bonus = bonus;
		}
	}
}