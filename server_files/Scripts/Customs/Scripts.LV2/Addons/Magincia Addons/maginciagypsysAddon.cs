
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
	public class maginciagypsysAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {666, -7, -8, 0}, {699, -7, -1, 19}, {699, -7, 0, 19}// 1	9	10	
			, {699, -7, -2, 19}, {699, -7, -3, 19}, {699, -7, -4, 19}// 11	12	13	
			, {699, -7, -5, 19}, {699, -7, -6, 19}, {699, -7, -7, 19}// 14	15	16	
			, {700, -7, -8, 19}, {692, -7, 0, 0}, {699, -7, 4, 19}// 17	18	19	
			, {699, -7, 3, 19}, {699, -7, 2, 19}, {699, -7, 1, 19}// 27	28	29	
			, {699, -7, 5, 19}, {699, -7, 6, 19}, {699, -7, 7, 19}// 30	31	32	
			, {699, -7, 8, 19}, {699, -8, 7, 0}, {699, -7, 8, 0}// 33	34	35	
			, {691, -7, 1, 0}, {1179, 2, 0, 21}, {1179, 2, -1, 21}// 36	39	40	
			, {1179, -2, 0, 21}, {698, 7, -8, 19}, {698, 8, -8, 19}// 42	47	48	
			, {1179, 5, -3, 21}, {1179, 5, -1, 21}, {1179, 4, -1, 21}// 49	50	51	
			, {698, 4, -8, 19}, {1179, -3, -3, 21}, {1179, 1, -1, 21}// 52	53	55	
			, {698, 6, -8, 19}, {698, 5, -8, 19}, {1179, 0, -3, 21}// 56	57	58	
			, {1179, -2, -3, 21}, {1179, 5, 0, 21}, {1179, 9, -2, 21}// 59	62	63	
			, {1179, 1, -2, 21}, {698, 9, -8, 19}, {1179, 4, -2, 21}// 64	66	67	
			, {1179, 1, 0, 21}, {1179, 1, -3, 21}, {1179, 9, -3, 21}// 68	71	72	
			, {1179, -1, -2, 21}, {1179, 4, -3, 21}, {1179, 2, -2, 21}// 74	75	76	
			, {1179, 2, -3, 21}, {698, 9, -4, 20}, {1179, 5, -2, 21}// 77	78	79	
			, {1179, 9, -1, 21}, {1179, -1, -3, 21}, {1179, 0, -1, 21}// 80	81	82	
			, {1179, 0, 0, 21}, {1179, 6, -1, 21}, {1179, 6, 0, 21}// 83	84	85	
			, {1179, 6, -3, 21}, {1179, 6, -2, 21}, {1179, 3, -1, 21}// 87	88	89	
			, {1179, 3, 0, 21}, {1179, 3, -3, 21}, {1179, 3, -2, 21}// 90	91	92	
			, {1179, -2, -1, 21}, {1179, -5, -2, 21}, {1179, -2, -2, 21}// 93	94	95	
			, {1179, -5, 0, 21}, {1179, -5, -1, 21}, {1179, -3, 0, 21}// 96	97	98	
			, {1179, -3, -1, 21}, {1179, -5, -3, 21}, {692, 9, 0, 0}// 99	100	101	
			, {1179, -1, -1, 21}, {1179, -1, 0, 21}, {1179, 0, -2, 21}// 102	103	104	
			, {1179, -3, -2, 21}, {1179, 4, 0, 21}, {1179, -4, -3, 21}// 105	107	112	
			, {1179, -4, -2, 21}, {1179, -4, -1, 21}, {1179, 9, 0, 21}// 113	114	116	
			, {1179, 7, -3, 21}, {1179, 7, -2, 21}, {1179, 7, -1, 21}// 118	119	120	
			, {1179, 7, 0, 21}, {1179, 8, -3, 21}, {1179, 8, -2, 21}// 121	123	124	
			, {1179, 8, -1, 21}, {1179, 8, 0, 21}, {1179, -4, 0, 21}// 125	126	128	
			, {1179, -6, -1, 21}, {1179, -6, 0, 21}, {699, 9, -6, 19}// 129	130	141	
			, {699, 9, -5, 19}, {699, 9, -3, 19}, {699, 9, -4, 19}// 142	143	144	
			, {699, 9, -2, 19}, {699, 9, -1, 19}, {1179, -6, -3, 21}// 145	146	147	
			, {1179, -6, -2, 21}, {699, 9, -7, 19}, {699, 9, 0, 19}// 148	149	150	
			, {698, -6, -8, 19}, {698, -5, -8, 19}, {698, -4, -8, 19}// 151	152	153	
			, {698, -3, -8, 19}, {698, -2, -8, 19}, {698, -1, -8, 19}// 154	155	156	
			, {698, 0, -8, 19}, {698, 1, -8, 19}, {698, 2, -8, 19}// 157	158	159	
			, {698, 3, -8, 19}, {698, -5, -4, 20}, {698, -4, -4, 20}// 160	161	162	
			, {698, -3, -4, 20}, {698, 6, -4, 20}, {698, 7, -4, 20}// 163	164	165	
			, {698, 8, -4, 20}, {698, 4, -4, 20}, {698, 1, -4, 20}// 166	167	168	
			, {698, -1, -4, 20}, {698, -2, -4, 20}, {698, 3, -4, 20}// 169	170	171	
			, {698, 5, -4, 20}, {698, 0, -4, 20}, {698, 2, -4, 20}// 172	173	174	
			, {698, -6, -4, 20}, {690, 0, -4, 0}, {689, 1, -4, 0}// 175	178	179	
			, {689, 1, -8, 0}, {690, 0, -8, 0}, {690, 0, 8, 0}// 180	182	183	
			, {1179, 1, 3, 21}, {1179, 2, 1, 21}, {1179, 6, 4, 21}// 185	186	187	
			, {1179, 8, 3, 21}, {1179, -4, 4, 21}, {1179, 8, 4, 21}// 188	189	190	
			, {1179, -1, 2, 21}, {1179, 1, 2, 21}, {1179, -3, 3, 21}// 191	193	195	
			, {1179, 9, 3, 21}, {1179, 2, 2, 21}, {1179, -2, 1, 21}// 196	197	198	
			, {1179, -3, 4, 21}, {1179, 9, 4, 21}, {1179, -3, 2, 21}// 199	200	201	
			, {1179, 6, 3, 21}, {1179, 5, 4, 21}, {1179, 1, 4, 21}// 202	203	205	
			, {1179, 6, 2, 21}, {1179, 5, 2, 21}, {1179, -2, 3, 21}// 206	207	209	
			, {1179, 9, 2, 21}, {1179, 2, 3, 21}, {1179, -4, 2, 21}// 210	212	213	
			, {1179, -2, 4, 21}, {691, 9, 1, 0}, {1179, -4, 3, 21}// 214	215	216	
			, {1179, 4, 4, 21}, {1179, 2, 4, 21}, {1179, 3, 4, 21}// 217	218	219	
			, {1179, 5, 1, 21}, {1179, 1, 1, 21}, {698, -5, 8, 19}// 220	225	226	
			, {1179, 0, 1, 21}, {1179, 0, 2, 21}, {1179, 0, 3, 21}// 228	229	230	
			, {1179, 0, 4, 21}, {1179, 6, 1, 21}, {1179, 3, 1, 21}// 231	232	236	
			, {1179, 3, 2, 21}, {1179, -4, 1, 21}, {698, -6, 8, 19}// 237	238	239	
			, {1179, -3, 1, 21}, {1179, -1, 1, 21}, {1179, -1, 3, 21}// 240	241	242	
			, {1179, -5, 1, 21}, {1179, 4, 1, 21}, {1179, 4, 2, 21}// 243	244	245	
			, {1179, 4, 3, 21}, {1179, -2, 2, 21}, {1179, -1, 4, 21}// 246	247	248	
			, {698, -1, 8, 19}, {697, 9, 8, 19}, {1179, 3, 3, 21}// 249	250	251	
			, {1179, 5, 3, 21}, {698, -6, 4, 20}, {698, 0, 8, 19}// 252	253	254	
			, {1179, -5, 2, 21}, {1179, -5, 3, 21}, {1179, -5, 4, 21}// 255	256	257	
			, {1179, 8, 2, 21}, {1179, 8, 1, 21}, {1179, 9, 1, 21}// 258	259	260	
			, {1179, 7, 1, 21}, {1179, 7, 2, 21}, {1179, 7, 3, 21}// 261	262	263	
			, {1179, 7, 4, 21}, {1179, -6, 3, 21}, {1179, -6, 4, 21}// 264	266	267	
			, {698, 1, 8, 19}, {698, 2, 8, 19}, {698, 3, 8, 19}// 268	269	270	
			, {698, 4, 8, 19}, {1179, -6, 1, 21}, {1179, -6, 2, 21}// 271	272	273	
			, {689, 1, 8, 0}, {698, 5, 8, 19}, {698, 6, 8, 19}// 279	282	283	
			, {698, 7, 8, 19}, {698, 8, 8, 19}, {698, -4, 8, 19}// 284	285	286	
			, {698, -3, 8, 19}, {698, -2, 8, 19}, {699, 9, 2, 19}// 287	288	289	
			, {699, 9, 4, 19}, {699, 9, 3, 19}, {699, 9, 5, 19}// 290	291	292	
			, {699, 9, 6, 19}, {699, 9, 7, 19}, {699, 9, 1, 19}// 293	294	295	
			, {698, 5, 4, 20}, {698, 6, 4, 20}, {698, 7, 4, 20}// 299	302	306	
			, {698, 8, 4, 20}, {698, 9, 4, 20}, {698, 1, 4, 20}// 307	308	314	
			, {698, 2, 4, 20}, {698, 3, 4, 20}, {698, 4, 4, 20}// 315	316	317	
			, {698, -5, 4, 20}, {698, -4, 4, 20}, {698, -3, 4, 20}// 318	319	320	
			, {698, -2, 4, 20}, {698, -1, 4, 20}, {698, 0, 4, 20}// 321	322	323	
			, {690, 0, 4, 0}, {689, 1, 4, 0}// 324	325	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new maginciagypsysAddonDeed();
			}
		}

		[ Constructable ]
		public maginciagypsysAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 662, -7, -1, 0, 0, 0, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 662, -7, -7, 0, 0, 0, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 662, -7, -3, 0, 0, 0, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 662, -7, -4, 0, 0, 0, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 662, -7, -5, 0, 0, 0, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 662, -7, -6, 0, 0, 0, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 662, -7, -2, 0, 0, 0, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 662, -7, 2, 0, 0, 0, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 662, -7, 7, 0, 0, 0, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 662, -7, 8, 0, 0, 0, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 662, -7, 5, 0, 0, 0, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 662, -7, 6, 0, 0, 0, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 662, -7, 4, 0, 0, 0, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 662, -7, 3, 0, 0, 0, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 2854, -6, -7, 2, 0, 1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 661, -3, -4, 0, 0, 0, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 661, -2, -4, 0, 0, 0, "", 1);// 41
			AddComplexComponent( (BaseAddon) this, 662, 9, -3, 0, 0, 0, "", 1);// 43
			AddComplexComponent( (BaseAddon) this, 662, 9, -6, 0, 0, 0, "", 1);// 44
			AddComplexComponent( (BaseAddon) this, 662, 9, -5, 0, 0, 0, "", 1);// 45
			AddComplexComponent( (BaseAddon) this, 662, 9, -4, 0, 0, 0, "", 1);// 46
			AddComplexComponent( (BaseAddon) this, 662, 9, -1, 0, 0, 0, "", 1);// 54
			AddComplexComponent( (BaseAddon) this, 661, -3, -8, 0, 0, 0, "", 1);// 60
			AddComplexComponent( (BaseAddon) this, 661, -2, -8, 0, 0, 0, "", 1);// 61
			AddComplexComponent( (BaseAddon) this, 661, -1, -8, 0, 0, 0, "", 1);// 65
			AddComplexComponent( (BaseAddon) this, 661, -4, -8, 0, 0, 0, "", 1);// 69
			AddComplexComponent( (BaseAddon) this, 661, 2, -4, 0, 0, 0, "", 1);// 70
			AddComplexComponent( (BaseAddon) this, 661, -4, -4, 0, 0, 0, "", 1);// 73
			AddComplexComponent( (BaseAddon) this, 661, 4, -4, 0, 0, 0, "", 1);// 86
			AddComplexComponent( (BaseAddon) this, 661, 9, -4, 0, 0, 0, "", 1);// 106
			AddComplexComponent( (BaseAddon) this, 661, -1, -4, 0, 0, 0, "", 1);// 108
			AddComplexComponent( (BaseAddon) this, 661, -5, -4, 0, 0, 0, "", 1);// 109
			AddComplexComponent( (BaseAddon) this, 662, 9, -7, 0, 0, 0, "", 1);// 110
			AddComplexComponent( (BaseAddon) this, 661, 3, -4, 0, 0, 0, "", 1);// 111
			AddComplexComponent( (BaseAddon) this, 661, -6, -4, 0, 0, 0, "", 1);// 115
			AddComplexComponent( (BaseAddon) this, 661, 5, -4, 0, 0, 0, "", 1);// 117
			AddComplexComponent( (BaseAddon) this, 661, 8, -4, 0, 0, 0, "", 1);// 122
			AddComplexComponent( (BaseAddon) this, 662, 9, -2, 0, 0, 0, "", 1);// 127
			AddComplexComponent( (BaseAddon) this, 661, 2, -8, 0, 0, 0, "", 1);// 131
			AddComplexComponent( (BaseAddon) this, 661, 3, -8, 0, 0, 0, "", 1);// 132
			AddComplexComponent( (BaseAddon) this, 661, 4, -8, 0, 0, 0, "", 1);// 133
			AddComplexComponent( (BaseAddon) this, 661, 5, -8, 0, 0, 0, "", 1);// 134
			AddComplexComponent( (BaseAddon) this, 661, 6, -8, 0, 0, 0, "", 1);// 135
			AddComplexComponent( (BaseAddon) this, 661, 7, -8, 0, 0, 0, "", 1);// 136
			AddComplexComponent( (BaseAddon) this, 661, 8, -8, 0, 0, 0, "", 1);// 137
			AddComplexComponent( (BaseAddon) this, 661, 9, -8, 0, 0, 0, "", 1);// 138
			AddComplexComponent( (BaseAddon) this, 661, -6, -8, 0, 0, 0, "", 1);// 139
			AddComplexComponent( (BaseAddon) this, 661, -5, -8, 0, 0, 0, "", 1);// 140
			AddComplexComponent( (BaseAddon) this, 661, 7, -4, 0, 0, 1, "", 1);// 176
			AddComplexComponent( (BaseAddon) this, 661, 6, -4, 0, 0, 1, "", 1);// 177
			AddComplexComponent( (BaseAddon) this, 2854, 8, -7, 1, 0, 1, "", 1);// 181
			AddComplexComponent( (BaseAddon) this, 661, 6, 4, 0, 0, 0, "", 1);// 184
			AddComplexComponent( (BaseAddon) this, 661, 8, 8, 0, 0, 0, "", 1);// 192
			AddComplexComponent( (BaseAddon) this, 662, 9, 7, 0, 0, 0, "", 1);// 194
			AddComplexComponent( (BaseAddon) this, 661, -4, 8, 0, 0, 0, "", 1);// 204
			AddComplexComponent( (BaseAddon) this, 661, 3, 8, 0, 0, 0, "", 1);// 208
			AddComplexComponent( (BaseAddon) this, 662, 9, 8, 0, 0, 1, "", 1);// 211
			AddComplexComponent( (BaseAddon) this, 661, -5, 8, 0, 0, 0, "", 1);// 221
			AddComplexComponent( (BaseAddon) this, 662, 9, 5, 0, 0, 0, "", 1);// 222
			AddComplexComponent( (BaseAddon) this, 661, -6, 8, 0, 0, 1, "", 1);// 223
			AddComplexComponent( (BaseAddon) this, 661, 9, 8, 0, 0, 1, "", 1);// 224
			AddComplexComponent( (BaseAddon) this, 662, 9, 6, 0, 0, 0, "", 1);// 227
			AddComplexComponent( (BaseAddon) this, 662, 9, 2, 0, 0, 0, "", 1);// 233
			AddComplexComponent( (BaseAddon) this, 662, 9, 3, 0, 0, 0, "", 1);// 234
			AddComplexComponent( (BaseAddon) this, 662, 9, 4, 0, 0, 0, "", 1);// 235
			AddComplexComponent( (BaseAddon) this, 661, 7, 8, 0, 0, 0, "", 1);// 265
			AddComplexComponent( (BaseAddon) this, 661, 4, 8, 0, 0, 0, "", 1);// 274
			AddComplexComponent( (BaseAddon) this, 661, 5, 8, 0, 0, 0, "", 1);// 275
			AddComplexComponent( (BaseAddon) this, 661, 6, 8, 0, 0, 0, "", 1);// 276
			AddComplexComponent( (BaseAddon) this, 661, -2, 8, 0, 0, 0, "", 1);// 277
			AddComplexComponent( (BaseAddon) this, 661, -1, 8, 0, 0, 0, "", 1);// 278
			AddComplexComponent( (BaseAddon) this, 661, 2, 8, 0, 0, 0, "", 1);// 280
			AddComplexComponent( (BaseAddon) this, 661, -3, 8, 0, 0, 0, "", 1);// 281
			AddComplexComponent( (BaseAddon) this, 661, 9, 4, 0, 0, 1, "", 1);// 296
			AddComplexComponent( (BaseAddon) this, 661, 7, 4, 0, 0, 0, "", 1);// 297
			AddComplexComponent( (BaseAddon) this, 661, 5, 4, 0, 0, 0, "", 1);// 298
			AddComplexComponent( (BaseAddon) this, 661, 4, 4, 0, 0, 0, "", 1);// 300
			AddComplexComponent( (BaseAddon) this, 661, -6, 4, 0, 0, 0, "", 1);// 301
			AddComplexComponent( (BaseAddon) this, 661, -1, 4, 0, 0, 0, "", 1);// 303
			AddComplexComponent( (BaseAddon) this, 661, 2, 4, 0, 0, 0, "", 1);// 304
			AddComplexComponent( (BaseAddon) this, 661, 3, 4, 0, 0, 0, "", 1);// 305
			AddComplexComponent( (BaseAddon) this, 661, 8, 4, 0, 0, 1, "", 1);// 309
			AddComplexComponent( (BaseAddon) this, 661, -5, 4, 0, 0, 0, "", 1);// 310
			AddComplexComponent( (BaseAddon) this, 661, -4, 4, 0, 0, 0, "", 1);// 311
			AddComplexComponent( (BaseAddon) this, 661, -2, 4, 0, 0, 0, "", 1);// 312
			AddComplexComponent( (BaseAddon) this, 661, -3, 4, 0, 0, 0, "", 1);// 313
			AddComplexComponent( (BaseAddon) this, 2854, 8, 5, 1, 0, 1, "", 1);// 326
			AddComplexComponent( (BaseAddon) this, 2854, -6, 5, 2, 0, 1, "", 1);// 327

		}

		public maginciagypsysAddon( Serial serial ) : base( serial )
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

	public class maginciagypsysAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new maginciagypsysAddon();
			}
		}

		[Constructable]
		public maginciagypsysAddonDeed()
		{
			Name = "maginciagypsys";
		}

		public maginciagypsysAddonDeed( Serial serial ) : base( serial )
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