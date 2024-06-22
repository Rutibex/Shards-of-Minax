
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
	public class StoveBigEastAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2879, 1, 1, 1}, {7134, 1, 0, 5}, {1276, 1, 0, 1}// 1	2	3	
			, {2541, 1, -1, 12}, {7134, 1, -1, 5}, {1276, 1, -1, 1}// 4	5	6	
			, {2416, 1, -1, 18}, {2450, 1, 1, 7}, {2422, 1, 1, 8}// 7	8	9	
			, {2533, 1, 0, 12}, {7134, 1, -2, 0}, {7826, 1, 1, 13}// 10	11	12	
			, {5628, 1, 2, 9}, {2879, 1, 2, 1}, {3133, 1, 2, 10}// 13	14	15	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new StoveBigEastAddonDeed();
			}
		}

		[ Constructable ]
		public StoveBigEastAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 441, 0, -1, 0, 1899, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 82, 1, 0, 3, 1899, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 82, 1, 0, 1, 1899, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 1180, 1, 0, 5, 1891, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 6571, 1, 0, 8, 0, 0, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 85, 1, 0, 5, 1899, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 85, 1, 0, 8, 1899, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 82, 1, 0, 10, 1899, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 62, 1, -1, 1, 1899, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 1180, 1, 0, 12, 1891, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 82, 1, -1, 3, 1899, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 1180, 1, -1, 5, 1891, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 6571, 1, -1, 8, 0, 0, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 82, 1, -1, 10, 1899, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 62, 1, -2, 1, 1899, -1, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 1180, 1, -1, 12, 1891, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 82, 1, -1, 1, 1899, -1, "", 1);// 32

		}

		public StoveBigEastAddon( Serial serial ) : base( serial )
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

	public class StoveBigEastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new StoveBigEastAddon();
			}
		}

		[Constructable]
		public StoveBigEastAddonDeed()
		{
			Name = "StoveBigEast";
		}

		public StoveBigEastAddonDeed( Serial serial ) : base( serial )
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