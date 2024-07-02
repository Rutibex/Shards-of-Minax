using System;
using System.Collections.Generic;
using Server.Items;

namespace Server.Mobiles
{
    public class SBBanker : SBInfo
    {
        private readonly List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
        private readonly IShopSellInfo m_SellInfo = new InternalSellInfo();
        public SBBanker()
        {
        }

        public override IShopSellInfo SellInfo
        {
            get
            {
                return m_SellInfo;
            }
        }
        public override List<GenericBuyInfo> BuyInfo
        {
            get
            {
                return m_BuyInfo;
            }
        }

        public class InternalBuyInfo : List<GenericBuyInfo>
        {
            public InternalBuyInfo()
            {
                Add(new GenericBuyInfo("1041243", typeof(ContractOfEmployment), 1252, 20, 0x14F0, 0));

                if (Multis.BaseHouse.NewVendorSystem)
                    Add(new GenericBuyInfo("1062332", typeof(VendorRentalContract), 1252, 20, 0x14F0, 0x672));
                Add(new GenericBuyInfo("1047016", typeof(CommodityDeed), 5, 20, 0x14F0, 0x47));
				Add(new GenericBuyInfo(typeof(MaxxiaScroll), 10000, 99, 0xE34, 0));
				Add(new GenericBuyInfo(typeof(HeritageSovereign), 500, 99, 0x1F31, 0));
				Add(new GenericBuyInfo(typeof(GenderChangeDeed), 5000, 10, 0x14F0, 0));
				Add(new GenericBuyInfo(typeof(MurderRemovalDeed), 5000, 10, 0x14F0, 0));
				Add(new GenericBuyInfo(typeof(ClothingBlessDeed), 5000, 10, 0x14F0, 0));
				Add(new GenericBuyInfo(typeof(AdventurersContract), 5000, 10, 0x14F0, 0));
				Add(new GenericBuyInfo(typeof(HeritageToken), 5000, 10, 0x367A, 0));
            }
        }

        public class InternalSellInfo : GenericSellInfo
        {
            public InternalSellInfo()
            {
            }
        }
    }
}