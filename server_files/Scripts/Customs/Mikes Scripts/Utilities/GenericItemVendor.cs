using System;
using System.Collections.Generic;
using Server;
using Server.Gumps;
using Server.Network;
using Server.Mobiles;
using Server.Items;
using Server.Commands;

namespace Server.Gumps
{
    public class GenericItemVendor
    {
        public static void Initialize()
        {
            CommandSystem.Register("maxxiastore", AccessLevel.Player, new CommandEventHandler(OpenVendor_OnCommand));
        }

        [Usage("MaxxiaStore")]
        [Description("Opens the Maxxia Scroll Store")]
        public static void OpenVendor_OnCommand(CommandEventArgs e)
        {
            Mobile from = e.Mobile;
            if (from != null && from is PlayerMobile)
            {
                PlayerMobile pm = (PlayerMobile)from;
                from.CloseGump(typeof(GenericItemVendorGump));
                from.SendGump(new GenericItemVendorGump(pm, 0));
            }
        }
    }

    public class MaxxiaVendorItem
    {
        public Type ItemType { get; private set; }
        public string Name { get; private set; }
        public int ItemID { get; private set; }
        public int Price { get; private set; }

        public MaxxiaVendorItem(Type itemType, string name, int itemID, int price)
        {
            ItemType = itemType;
            Name = name;
            ItemID = itemID;
            Price = price;
        }
    }

    public class GenericItemVendorGump : Gump
    {
        private const int ItemsPerPage = 6;
        private PlayerMobile m_Owner;
        private int m_Page;

        private static List<MaxxiaVendorItem> MaxxiaVendorItems = new List<MaxxiaVendorItem>();

        static GenericItemVendorGump()
        {
            // Add your items here
            MaxxiaVendorItems.Add(new MaxxiaVendorItem(typeof(RoyalSkillCharter), "Royal Skill Charter", 5360, 2));
            MaxxiaVendorItems.Add(new MaxxiaVendorItem(typeof(RoyalStatCharter), "Royal Stat Charter", 5360, 3));
            MaxxiaVendorItems.Add(new MaxxiaVendorItem(typeof(RoyalPetsCharter), "Royal Pets Charter", 5360, 20));
            MaxxiaVendorItems.Add(new MaxxiaVendorItem(typeof(SkillOrb), "Skill Orb", 6249, 10));
            MaxxiaVendorItems.Add(new MaxxiaVendorItem(typeof(StatCapOrb), "Stat Cap Orb", 6249, 20));
            MaxxiaVendorItems.Add(new MaxxiaVendorItem(typeof(PetSlotDeed), "Pet Slot Deed", 5360, 50));
			MaxxiaVendorItems.Add(new MaxxiaVendorItem(typeof(CapacityIncreaseDeed), "Backpack Increase Deed", 5360, 50));
			MaxxiaVendorItems.Add(new MaxxiaVendorItem(typeof(BankCrystal), "Bank Crystal", 7964, 100));
			MaxxiaVendorItems.Add(new MaxxiaVendorItem(typeof(GemKey), "Gem Key", 12266, 100));
			MaxxiaVendorItems.Add(new MaxxiaVendorItem(typeof(AddonDeedKey), "Addon Deed Key", 7809, 100));
			MaxxiaVendorItems.Add(new MaxxiaVendorItem(typeof(WeaponKey), "Weapon Key", 10326, 100));
			MaxxiaVendorItems.Add(new MaxxiaVendorItem(typeof(ClothingKey), "Clothing Key", 9436, 100));
			MaxxiaVendorItems.Add(new MaxxiaVendorItem(typeof(BeverageKey), "Beverage Key", 39574, 100));
			MaxxiaVendorItems.Add(new MaxxiaVendorItem(typeof(ToolKey), "Tool Key", 7857, 100));
			MaxxiaVendorItems.Add(new MaxxiaVendorItem(typeof(BardsKey), "Bard Key", 3766, 100));
			MaxxiaVendorItems.Add(new MaxxiaVendorItem(typeof(WoodKey), "Wood Key", 7129, 100));
			MaxxiaVendorItems.Add(new MaxxiaVendorItem(typeof(PotionKey), "Potion Key", 6238, 100));
			MaxxiaVendorItems.Add(new MaxxiaVendorItem(typeof(TailorKey), "Tailor Key", 3997, 100));
			MaxxiaVendorItems.Add(new MaxxiaVendorItem(typeof(JewelryKey), "Jewelry Key", 2472, 100));
			MaxxiaVendorItems.Add(new MaxxiaVendorItem(typeof(MeatKey), "Meat Key", 9915, 100));
			MaxxiaVendorItems.Add(new MaxxiaVendorItem(typeof(ChampSkullKey), "Champ Skull Key", 8707, 100));
			MaxxiaVendorItems.Add(new MaxxiaVendorItem(typeof(GardenersKey), "Gardeners Key", 4023, 100));
			MaxxiaVendorItems.Add(new MaxxiaVendorItem(typeof(TreasureHuntersKey), "Treasure Hunters Key", 5358, 100));
			MaxxiaVendorItems.Add(new MaxxiaVendorItem(typeof(PSKey), "Power Scroll Key", 39591, 100));
			MaxxiaVendorItems.Add(new MaxxiaVendorItem(typeof(ScribesKey), "Scribes Key", 4030, 100));
			MaxxiaVendorItems.Add(new MaxxiaVendorItem(typeof(IngotKey), "Ingot Key", 7144, 100));
			MaxxiaVendorItems.Add(new MaxxiaVendorItem(typeof(ReagentKey), "Reagent Key", 6366, 100));
			MaxxiaVendorItems.Add(new MaxxiaVendorItem(typeof(FishKey), "Fish Key", 4090, 100));
			MaxxiaVendorItems.Add(new MaxxiaVendorItem(typeof(ChefKey), "Chef Key", 2541, 100));
			MaxxiaVendorItems.Add(new MaxxiaVendorItem(typeof(RunicToolKey), "Runic Tool Key", 7866, 100));
			MaxxiaVendorItems.Add(new MaxxiaVendorItem(typeof(JewelersKey), "Jewelers Key", 5995, 100));
			MaxxiaVendorItems.Add(new MaxxiaVendorItem(typeof(ArmorKey), "Armor Key", 15786, 100));
			MaxxiaVendorItems.Add(new MaxxiaVendorItem(typeof(ArmoryKey), "Armory Key", 15750, 100));
			MaxxiaVendorItems.Add(new MaxxiaVendorItem(typeof(MasterItemStoreKey), "Master Key", 5995, 100));
            // Add more items as needed
        }

        public GenericItemVendorGump(PlayerMobile owner, int page)
            : base(50, 50)
        {
            m_Owner = owner;
            m_Page = page;

            AddPage(0);
            AddBackground(0, 0, 600, 400, 9270);
            AddAlphaRegion(10, 10, 580, 380);

            AddHtml(20, 20, 560, 20, "<CENTER><BASEFONT COLOR=#FFFFFF>Maxxia Store</BASEFONT></CENTER>", false, false);

            int pageCount = (MaxxiaVendorItems.Count + ItemsPerPage - 1) / ItemsPerPage;

            if (page > 0)
                AddButton(550, 20, 4014, 4016, 1, GumpButtonType.Reply, 0); // Previous page

            if (page < pageCount - 1)
                AddButton(575, 20, 4005, 4007, 2, GumpButtonType.Reply, 0); // Next page

            AddHtml(-200, 20, 560, 20, String.Format("<CENTER><BASEFONT COLOR=#FFFFFF>Page {0}/{1}</BASEFONT></CENTER>", page + 1, pageCount), false, false);

            for (int i = 0; i < ItemsPerPage; ++i)
            {
                int index = (page * ItemsPerPage) + i;
                if (index >= MaxxiaVendorItems.Count)
                    break;

                MaxxiaVendorItem item = MaxxiaVendorItems[index];

                int xOffset = (i % 3) * 190;
                int yOffset = (i / 3) * 180;

                AddImageTiled(20 + xOffset, 50 + yOffset, 180, 170, 2624);
                AddAlphaRegion(25 + xOffset, 55 + yOffset, 170, 160);

                AddItem(70 + xOffset, 100 + yOffset, item.ItemID);
                AddHtml(25 + xOffset, 55 + yOffset, 170, 20, String.Format("<CENTER><BASEFONT COLOR=#FFFFFF>{0}</BASEFONT></CENTER>", item.Name), false, false);
                AddHtml(25 + xOffset, 180 + yOffset, 170, 20, String.Format("<CENTER><BASEFONT COLOR=#FFFFFF>Cost: {0} MaxxiaScroll</BASEFONT></CENTER>", item.Price), false, false);

                AddButton(155 + xOffset, 145 + yOffset, 4005, 4007, 100 + index, GumpButtonType.Reply, 0);
            }
        }

        public override void OnResponse(NetState sender, RelayInfo info)
        {
            Mobile from = sender.Mobile;

            switch (info.ButtonID)
            {
                case 1: // Previous page
                    from.SendGump(new GenericItemVendorGump(m_Owner, m_Page - 1));
                    break;
                case 2: // Next page
                    from.SendGump(new GenericItemVendorGump(m_Owner, m_Page + 1));
                    break;
                default:
                    if (info.ButtonID >= 100)
                    {
                        int index = info.ButtonID - 100;
                        if (index >= 0 && index < MaxxiaVendorItems.Count)
                        {
                            MaxxiaVendorItem MaxxiaVendorItem = MaxxiaVendorItems[index];
                            if (HasEnoughMaxxiaScrolls(from, MaxxiaVendorItem.Price))
                            {
                                ConsumeMaxxiaScrolls(from, MaxxiaVendorItem.Price);
                                GiveItem(from, MaxxiaVendorItem);
                                from.SendMessage(String.Format("You have purchased {0} for {1} MaxxiaScrolls.", MaxxiaVendorItem.Name, MaxxiaVendorItem.Price));
                            }
                            else
                            {
                                from.SendMessage(String.Format("You don't have enough MaxxiaScrolls. You need {0} to purchase {1}.", MaxxiaVendorItem.Price, MaxxiaVendorItem.Name));
                            }
                        }
                        from.SendGump(new GenericItemVendorGump(m_Owner, m_Page));
                    }
                    break;
            }
        }

        private bool HasEnoughMaxxiaScrolls(Mobile from, int requiredAmount)
        {
            int count = from.Backpack.GetAmount(typeof(MaxxiaScroll), true);
            return count >= requiredAmount;
        }

        private void ConsumeMaxxiaScrolls(Mobile from, int amount)
        {
            from.Backpack.ConsumeTotal(typeof(MaxxiaScroll), amount);
        }

        private void GiveItem(Mobile from, MaxxiaVendorItem MaxxiaVendorItem)
        {
            Item item = (Item)Activator.CreateInstance(MaxxiaVendorItem.ItemType);
            from.AddToBackpack(item);
        }
    }
}