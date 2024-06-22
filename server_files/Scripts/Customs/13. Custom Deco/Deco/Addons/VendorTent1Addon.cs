
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class VendorTent1Addon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new VendorTent1AddonDeed();
			}
		}

		[ Constructable ]
		public VendorTent1Addon()
		{



			AddComplexComponent( (BaseAddon) this, 879, -2, -1, 0, 1459, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 873, 1, 2, 0, 1459, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 1535, -1, 1, 20, 1459, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 875, -2, -2, 0, 1459, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 878, -1, -2, 0, 1459, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 1543, 0, 1, 23, 1459, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 873, -1, 2, 0, 1459, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 877, 2, -2, 0, 1459, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 1535, -1, 0, 20, 1459, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 1541, 2, -1, 20, 1459, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 878, 1, -2, 0, 1459, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 873, 0, 2, 0, 1459, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 1543, -1, 2, 20, 1459, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 878, 0, -2, 0, 1459, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 1542, -1, -1, 20, 1459, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 1536, 1, -1, 20, 1459, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 1541, 1, 0, 23, 1459, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 872, 2, 2, 0, 1459, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 1542, 0, 0, 23, 1459, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 1540, 1, 1, 23, 1459, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 1536, 0, -1, 20, 1459, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 1537, 1, 2, 20, 1459, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 879, -2, 0, 0, 1459, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 879, -2, 1, 0, 1459, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 1537, 0, 2, 20, 1459, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 876, -2, 2, 0, 1459, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 1538, 2, 1, 20, 1459, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 1538, 2, 0, 20, 1459, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 1540, 2, 2, 20, 1459, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 874, 2, -1, 0, 1459, -1, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 874, 2, 1, 0, 1459, -1, "", 1);// 31

		}

		public VendorTent1Addon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
        }

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class VendorTent1AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new VendorTent1Addon();
			}
		}

		[Constructable]
		public VendorTent1AddonDeed()
		{
			Name = "VendorTent1";
		}

		public VendorTent1AddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}