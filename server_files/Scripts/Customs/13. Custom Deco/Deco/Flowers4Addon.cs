
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
	public class Flowers4Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {5131, 0, 1, 0}// 3	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Flowers4AddonDeed();
			}
		}

		[ Constructable ]
		public Flowers4Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 3195, -1, 0, 20, 2067, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 3195, -1, 0, 7, 2065, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 3133, 0, 0, 7, 0, -1, "Sage", 1);// 4
			AddComplexComponent( (BaseAddon) this, 3133, 0, 0, 11, 0, -1, "Oregano", 1);// 5
			AddComplexComponent( (BaseAddon) this, 3133, 0, 0, 16, 0, -1, "Oregano", 1);// 6
			AddComplexComponent( (BaseAddon) this, 3314, 1, -1, 7, 2947, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 3314, 0, 0, 8, 2947, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 3185, 0, 0, 22, 2065, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 3195, 0, 0, 13, 2065, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 3195, 1, 0, 22, 2065, -1, "", 1);// 11

		}

		public Flowers4Addon( Serial serial ) : base( serial )
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

	public class Flowers4AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Flowers4Addon();
			}
		}

		[Constructable]
		public Flowers4AddonDeed()
		{
			Name = "Flowers4";
		}

		public Flowers4AddonDeed( Serial serial ) : base( serial )
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