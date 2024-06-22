
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
	public class Magincia12Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1281, 1, -4, 0}, {1281, 1, -2, 0}, {1281, -2, -7, 0}// 1	2	3	
			, {1281, 4, -5, 0}, {1281, 1, -7, 0}, {1281, 1, -1, 0}// 4	5	6	
			, {1281, 1, -8, 0}, {1281, -2, -1, 0}, {1281, 5, -1, 0}// 7	8	9	
			, {1281, 5, -2, 0}, {1281, 5, -3, 0}, {1281, 5, -4, 0}// 10	11	12	
			, {1281, 5, -5, 0}, {1281, -1, -8, 0}, {1281, 5, -6, 0}// 13	14	15	
			, {1281, 5, -7, 0}, {1281, 5, -8, 0}, {1281, 4, -2, 0}// 16	17	18	
			, {1281, 4, -4, 0}, {1281, 4, -1, 0}, {1281, 3, -5, 0}// 19	20	21	
			, {1281, 3, -6, 0}, {1281, 0, -3, 0}, {1281, 0, -4, 0}// 22	23	24	
			, {1281, 3, -7, 0}, {1281, 4, -3, 0}, {1281, 0, -1, 0}// 25	26	27	
			, {1281, 0, -2, 0}, {1281, -1, -4, 0}, {1281, -1, -1, 0}// 28	29	30	
			, {1281, -1, -2, 0}, {1281, -1, -3, 0}, {1281, -2, -5, 0}// 31	32	33	
			, {1281, 3, -8, 0}, {1281, 3, -3, 0}, {1281, 3, -1, 0}// 34	35	36	
			, {1281, 3, -2, 0}, {1281, -2, -8, 0}, {1281, -1, -7, 0}// 37	38	39	
			, {1281, -1, -6, 0}, {1281, -2, -6, 0}, {1281, -1, -5, 0}// 40	41	42	
			, {1281, 0, -7, 0}, {1281, 0, -5, 0}, {1281, 1, -6, 0}// 43	44	45	
			, {1281, 1, -5, 0}, {1281, -2, -4, 0}, {1281, -2, -3, 0}// 46	47	48	
			, {1281, 0, -6, 0}, {1281, -2, -2, 0}, {345, -2, -9, 20}// 49	50	51	
			, {345, 5, -9, 20}, {345, 0, -9, 20}, {345, 3, -9, 20}// 52	53	54	
			, {346, -3, -8, 20}, {346, 5, -8, 20}, {347, -3, -9, 20}// 55	56	57	
			, {347, -3, -6, 20}, {347, 5, -6, 20}, {347, 5, -1, 20}// 58	59	60	
			, {347, -3, -1, 20}, {351, -3, -8, 0}, {351, 5, -8, 0}// 61	64	65	
			, {352, 0, -9, 0}, {352, -2, -9, 0}, {352, 3, -9, 0}// 66	67	68	
			, {352, 5, -9, 0}, {353, 2, -9, 0}, {353, -3, -3, 0}// 69	70	71	
			, {353, -3, -9, 0}, {353, 5, -3, 0}, {358, 5, -4, 30}// 72	73	84	
			, {358, -3, -4, 30}, {361, -3, -2, 40}, {361, -3, -1, 40}// 85	86	87	
			, {361, 5, -1, 40}, {361, 5, -2, 40}, {361, 5, -6, 40}// 88	89	90	
			, {361, -3, -6, 40}, {361, 5, -4, 40}, {361, 5, -5, 40}// 91	92	93	
			, {361, 5, -3, 40}, {361, -3, -5, 40}, {361, -3, -3, 40}// 94	95	96	
			, {361, 5, -7, 40}, {361, 5, -8, 40}, {361, -3, -8, 40}// 97	98	99	
			, {361, -3, -4, 40}, {361, -3, -7, 40}, {362, 1, -9, 40}// 100	101	102	
			, {362, 0, -9, 40}, {362, 2, -9, 40}, {362, 4, -9, 40}// 103	104	105	
			, {362, 3, -9, 40}, {362, -2, -9, 40}, {362, 5, -9, 40}// 106	107	108	
			, {362, -1, -9, 40}, {363, -3, -9, 40}, {394, -3, -5, 20}// 109	110	111	
			, {394, 5, -5, 20}, {395, -3, -3, 20}, {395, 5, -3, 20}// 112	113	114	
			, {396, 1, -9, 20}, {397, 2, -9, 20}, {404, -3, -7, 20}// 115	116	117	
			, {404, 5, -2, 20}, {404, -3, -2, 20}, {404, 5, -7, 20}// 118	119	120	
			, {1387, 5, -4, 50}, {1387, 5, -6, 50}, {1387, 5, -5, 50}// 121	122	123	
			, {1387, 5, -1, 50}, {1387, 5, -3, 50}, {1387, 5, -2, 50}// 124	125	126	
			, {1387, 5, -7, 50}, {1388, 5, -8, 50}, {1392, -2, -5, 50}// 127	128	129	
			, {1392, -2, -7, 50}, {1392, -2, -6, 50}, {1392, -2, -2, 50}// 130	131	132	
			, {1392, -2, -1, 50}, {1392, -2, -4, 50}, {1392, -2, -3, 50}// 133	134	135	
			, {1393, 0, -8, 50}, {1393, 1, -8, 50}, {1393, 3, -8, 50}// 136	137	138	
			, {1393, 2, -8, 50}, {1393, 4, -8, 50}, {1393, -1, -8, 50}// 139	140	141	
			, {1394, -2, -8, 50}, {1395, 3, -6, 50}, {1395, 2, -4, 50}// 142	143	144	
			, {1395, 4, -3, 50}, {1395, -1, -5, 50}, {1395, -1, -3, 50}// 145	146	147	
			, {1395, 1, -2, 50}, {1396, 3, -2, 50}, {1396, 1, -3, 50}// 148	149	150	
			, {1396, 2, -5, 50}, {1396, -1, -1, 50}, {1396, 3, -7, 50}// 151	152	153	
			, {1396, 4, -7, 50}, {1396, 4, -5, 50}, {1397, -1, -2, 50}// 154	155	156	
			, {1397, -1, -4, 50}, {1397, -1, -6, 50}, {1397, 3, -3, 50}// 157	158	159	
			, {1397, 3, -1, 50}, {1397, 3, -5, 50}, {1397, 3, -4, 50}// 160	161	162	
			, {1397, 4, -6, 50}, {1397, 4, -4, 50}, {1397, 4, -1, 50}// 163	164	165	
			, {1397, 1, -6, 50}, {1397, 0, -7, 50}, {1397, 0, -5, 50}// 166	167	168	
			, {1397, 0, -4, 50}, {1397, 2, -7, 50}, {1397, 2, -1, 50}// 169	170	171	
			, {1397, 2, -3, 50}, {1398, 2, -2, 50}, {1398, 1, -5, 50}// 172	173	174	
			, {1398, 0, -1, 50}, {1398, 4, -2, 50}, {1399, 1, -7, 50}// 175	176	177	
			, {1399, 1, -4, 50}, {1399, 1, -1, 50}, {1399, 0, -2, 50}// 178	179	180	
			, {1399, -1, -7, 50}, {1399, 0, -6, 50}, {1399, 0, -3, 50}// 181	182	183	
			, {1399, 2, -6, 50}, {1281, 0, -8, 0}, {3230, -4, -1, 0}// 184	185	186	
			, {3230, -4, -2, 0}, {3230, -4, -7, 0}, {3230, -4, -6, 0}// 187	188	189	
			, {1281, 3, -4, 0}, {1281, 4, -8, 0}, {1281, 4, -7, 0}// 190	191	192	
			, {1281, 2, -7, 0}, {1281, 2, -8, 0}, {1281, 4, -6, 0}// 193	194	195	
			, {1281, 2, -6, 0}, {1281, 2, -2, 0}, {1281, 2, -1, 0}// 196	197	198	
			, {1281, 2, -3, 0}, {1281, 2, -4, 0}, {1281, 2, -5, 0}// 199	200	201	
			, {1281, 1, -3, 0}, {6008, 5, 5, 0}, {1281, 1, 7, 0}// 202	203	204	
			, {1281, 3, 5, 0}, {1281, 1, 6, 0}, {1281, -2, 9, 0}// 205	206	207	
			, {1281, 3, 8, 0}, {1281, 3, 3, 0}, {1281, 3, 4, 0}// 208	209	210	
			, {1281, 3, 9, 0}, {1281, 3, 2, 0}, {1281, 1, 0, 0}// 211	212	213	
			, {1281, 1, 4, 0}, {1281, 1, 3, 0}, {1281, 5, 10, 0}// 214	215	216	
			, {1281, 5, 9, 0}, {1281, 5, 8, 0}, {1281, 5, 7, 0}// 217	218	219	
			, {1281, 5, 6, 0}, {1281, 5, 5, 0}, {1281, 5, 4, 0}// 220	221	222	
			, {1281, 5, 3, 0}, {1281, 5, 2, 0}, {1281, 5, 1, 0}// 223	224	225	
			, {1281, 5, 0, 0}, {1281, 4, 10, 0}, {1281, 4, 9, 0}// 226	227	228	
			, {1281, 4, 8, 0}, {1281, 4, 7, 0}, {1281, 4, 6, 0}// 229	230	231	
			, {1281, 4, 5, 0}, {1281, 4, 4, 0}, {1281, -2, 10, 0}// 232	233	234	
			, {1281, 4, 3, 0}, {1281, 4, 2, 0}, {1281, 4, 1, 0}// 235	236	237	
			, {1281, -2, 0, 0}, {1281, 1, 5, 0}, {1281, -2, 5, 0}// 238	239	240	
			, {1281, 4, 0, 0}, {1281, 0, 3, 0}, {1281, 0, 4, 0}// 241	242	243	
			, {1281, 0, 2, 0}, {1281, 0, 1, 0}, {1281, 0, 0, 0}// 244	245	246	
			, {1281, -1, 0, 0}, {1281, 3, 0, 0}, {1281, -2, 3, 0}// 247	248	249	
			, {1281, -2, 2, 0}, {1281, -2, 1, 0}, {1281, -1, 10, 0}// 250	251	252	
			, {1281, -1, 6, 0}, {1281, -1, 9, 0}, {1281, -1, 8, 0}// 253	254	255	
			, {1281, -2, 7, 0}, {1281, 0, 8, 0}, {1281, 0, 7, 0}// 256	257	258	
			, {1281, 0, 10, 0}, {1281, -2, 8, 0}, {1281, -1, 3, 0}// 259	260	261	
			, {1281, -1, 2, 0}, {1281, 0, 5, 0}, {1281, -1, 1, 0}// 262	263	264	
			, {1281, 0, 6, 0}, {1281, 0, 9, 0}, {1281, -1, 5, 0}// 265	266	267	
			, {1281, -1, 4, 0}, {1281, -1, 7, 0}, {1281, -2, 6, 0}// 268	269	270	
			, {1281, -2, 4, 0}, {345, -2, 10, 20}, {345, 3, 10, 20}// 271	272	273	
			, {345, 0, 10, 20}, {346, -3, 10, 20}, {347, 5, 4, 20}// 274	275	276	
			, {347, 5, 9, 20}, {347, -3, 9, 20}, {347, -3, 4, 20}// 277	278	279	
			, {350, 5, 10, 0}, {351, -3, 10, 0}, {352, -2, 10, 0}// 282	283	284	
			, {352, 0, 10, 0}, {352, 3, 10, 0}, {353, -3, 7, 0}// 285	286	287	
			, {353, -3, 2, 0}, {353, 2, 10, 0}, {353, 5, 2, 0}// 288	289	290	
			, {353, 5, 7, 0}, {358, 5, 6, 30}, {358, -3, 6, 30}// 291	302	303	
			, {358, 5, 1, 30}, {358, -3, 1, 30}, {360, 5, 10, 40}// 304	305	306	
			, {361, 5, 9, 40}, {361, 5, 8, 40}, {361, 5, 7, 40}// 307	308	309	
			, {361, -3, 6, 40}, {361, -3, 4, 40}, {361, -3, 3, 40}// 310	311	312	
			, {361, -3, 5, 40}, {361, -3, 9, 40}, {361, -3, 8, 40}// 313	314	315	
			, {361, -3, 2, 40}, {361, -3, 1, 40}, {361, -3, 0, 40}// 316	317	318	
			, {361, -3, 7, 40}, {361, -3, 10, 40}, {361, 5, 6, 40}// 319	320	321	
			, {361, 5, 0, 40}, {361, 5, 4, 40}, {361, 5, 5, 40}// 322	323	324	
			, {361, 5, 1, 40}, {361, 5, 3, 40}, {361, 5, 2, 40}// 325	326	327	
			, {362, 0, 10, 40}, {362, 1, 10, 40}, {362, 4, 10, 40}// 328	329	330	
			, {362, 2, 10, 40}, {362, 3, 10, 40}, {362, -2, 10, 40}// 331	332	333	
			, {362, -1, 10, 40}, {394, 5, 5, 20}, {394, -3, 0, 20}// 334	335	336	
			, {394, 5, 0, 20}, {394, -3, 5, 20}, {395, -3, 2, 20}// 337	338	339	
			, {395, 5, 7, 20}, {395, 5, 2, 20}, {395, -3, 7, 20}// 340	341	342	
			, {396, 1, 10, 20}, {397, 2, 10, 20}, {404, 5, 9, 20}// 343	344	345	
			, {404, 5, 3, 20}, {404, 5, 8, 20}, {404, -3, 3, 20}// 346	347	348	
			, {404, -3, 8, 20}, {1387, 5, 2, 50}, {1387, 5, 3, 50}// 349	350	351	
			, {1387, 5, 1, 50}, {1387, 5, 5, 50}, {1387, 5, 4, 50}// 352	353	354	
			, {1387, 5, 0, 50}, {1387, 5, 9, 50}, {1387, 5, 7, 50}// 355	356	357	
			, {1387, 5, 6, 50}, {1387, 5, 8, 50}, {1389, 3, 10, 50}// 358	359	360	
			, {1389, 0, 10, 50}, {1389, 2, 10, 50}, {1389, -1, 10, 50}// 361	362	363	
			, {1389, 4, 10, 50}, {1389, 1, 10, 50}, {1390, -2, 10, 50}// 364	365	366	
			, {1391, 5, 10, 50}, {1392, -2, 3, 50}, {1392, -2, 4, 50}// 367	368	369	
			, {1392, -2, 1, 50}, {1392, -2, 2, 50}, {1392, -2, 6, 50}// 370	371	372	
			, {1392, -2, 7, 50}, {1392, -2, 5, 50}, {1392, -2, 0, 50}// 373	374	375	
			, {1392, -2, 8, 50}, {1392, -2, 9, 50}, {1395, 3, 4, 50}// 376	377	378	
			, {1395, 2, 1, 50}, {1395, 2, 6, 50}, {1395, 4, 9, 50}// 379	380	381	
			, {1395, 4, 2, 50}, {1395, 4, 7, 50}, {1395, 0, 8, 50}// 382	383	384	
			, {1395, -1, 0, 50}, {1395, -1, 6, 50}, {1395, 0, 3, 50}// 385	386	387	
			, {1396, 0, 4, 50}, {1396, 0, 6, 50}, {1396, 0, 1, 50}// 388	389	390	
			, {1396, 2, 4, 50}, {1396, -1, 7, 50}, {1396, 2, 9, 50}// 391	392	393	
			, {1396, 4, 8, 50}, {1396, 4, 5, 50}, {1396, 4, 0, 50}// 394	395	396	
			, {1397, -1, 8, 50}, {1397, -1, 9, 50}, {1397, -1, 4, 50}// 397	398	399	
			, {1397, -1, 5, 50}, {1397, -1, 3, 50}, {1397, -1, 2, 50}// 400	401	402	
			, {1397, -1, 1, 50}, {1397, 2, 5, 50}, {1397, 2, 0, 50}// 403	404	405	
			, {1397, 2, 8, 50}, {1397, 3, 9, 50}, {1397, 4, 3, 50}// 406	407	408	
			, {1397, 4, 4, 50}, {1397, 4, 1, 50}, {1397, 3, 2, 50}// 409	410	411	
			, {1397, 3, 3, 50}, {1397, 3, 1, 50}, {1397, 3, 6, 50}// 412	413	414	
			, {1397, 0, 9, 50}, {1397, 0, 7, 50}, {1397, 0, 2, 50}// 415	416	417	
			, {1397, 1, 6, 50}, {1397, 1, 2, 50}, {1397, 1, 0, 50}// 418	419	420	
			, {1398, 1, 7, 50}, {1398, 1, 4, 50}, {1398, 1, 1, 50}// 421	422	423	
			, {1398, 0, 5, 50}, {1398, 3, 5, 50}, {1398, 3, 7, 50}// 424	425	426	
			, {1398, 2, 3, 50}, {1399, 0, 0, 50}, {1399, 3, 8, 50}// 427	428	429	
			, {1399, 3, 0, 50}, {1399, 4, 6, 50}, {1399, 1, 9, 50}// 430	431	432	
			, {1399, 1, 5, 50}, {1399, 1, 3, 50}, {1399, 1, 8, 50}// 433	434	435	
			, {1399, 2, 7, 50}, {1399, 2, 2, 50}, {3230, -4, 4, 0}// 436	437	438	
			, {3230, -4, 2, 0}, {1281, 3, 10, 0}, {1281, 1, 8, 0}// 439	440	441	
			, {1281, 3, 7, 0}, {1281, 3, 6, 0}, {1281, 1, 9, 0}// 442	443	444	
			, {1281, 1, 10, 0}, {1281, 2, 9, 0}, {1281, 2, 8, 0}// 445	446	447	
			, {1281, 2, 7, 0}, {1281, 2, 6, 0}, {1281, 2, 4, 0}// 448	449	450	
			, {1281, 2, 5, 0}, {1281, 2, 3, 0}, {1281, 2, 2, 0}// 451	452	453	
			, {1281, 2, 1, 0}, {1281, 1, 1, 0}, {1281, 1, 2, 0}// 454	455	456	
			, {1281, 2, 0, 0}, {1281, 2, 10, 0}, {1281, 3, 1, 0}// 457	458	459	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Magincia12AddonDeed();
			}
		}

		[ Constructable ]
		public Magincia12Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 348, 4, -9, 20, 0, 0, "", 1);// 62
			AddComplexComponent( (BaseAddon) this, 348, -1, -9, 20, 0, 0, "", 1);// 63
			AddComplexComponent( (BaseAddon) this, 354, 5, -2, 0, 0, 0, "", 1);// 74
			AddComplexComponent( (BaseAddon) this, 354, 5, -7, 0, 0, 0, "", 1);// 75
			AddComplexComponent( (BaseAddon) this, 354, 5, -6, 0, 0, 0, "", 1);// 76
			AddComplexComponent( (BaseAddon) this, 354, 5, -1, 0, 0, 0, "", 1);// 77
			AddComplexComponent( (BaseAddon) this, 354, -3, -6, 0, 0, 0, "", 1);// 78
			AddComplexComponent( (BaseAddon) this, 354, -3, -7, 0, 0, 0, "", 1);// 79
			AddComplexComponent( (BaseAddon) this, 354, -3, -1, 0, 0, 0, "", 1);// 80
			AddComplexComponent( (BaseAddon) this, 354, -3, -2, 0, 0, 0, "", 1);// 81
			AddComplexComponent( (BaseAddon) this, 355, -1, -9, 0, 0, 0, "", 1);// 82
			AddComplexComponent( (BaseAddon) this, 355, 4, -9, 0, 0, 0, "", 1);// 83
			AddComplexComponent( (BaseAddon) this, 348, 4, 10, 20, 0, 0, "", 1);// 280
			AddComplexComponent( (BaseAddon) this, 348, -1, 10, 20, 0, 0, "", 1);// 281
			AddComplexComponent( (BaseAddon) this, 354, 5, 8, 0, 0, 0, "", 1);// 292
			AddComplexComponent( (BaseAddon) this, 354, 5, 9, 0, 0, 0, "", 1);// 293
			AddComplexComponent( (BaseAddon) this, 354, 5, 3, 0, 0, 0, "", 1);// 294
			AddComplexComponent( (BaseAddon) this, 354, 5, 4, 0, 0, 0, "", 1);// 295
			AddComplexComponent( (BaseAddon) this, 354, -3, 9, 0, 0, 0, "", 1);// 296
			AddComplexComponent( (BaseAddon) this, 354, -3, 3, 0, 0, 0, "", 1);// 297
			AddComplexComponent( (BaseAddon) this, 354, -3, 4, 0, 0, 0, "", 1);// 298
			AddComplexComponent( (BaseAddon) this, 354, -3, 8, 0, 0, 0, "", 1);// 299
			AddComplexComponent( (BaseAddon) this, 355, -1, 10, 0, 0, 0, "", 1);// 300
			AddComplexComponent( (BaseAddon) this, 355, 4, 10, 0, 0, 0, "", 1);// 301

		}

		public Magincia12Addon( Serial serial ) : base( serial )
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

	public class Magincia12AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Magincia12Addon();
			}
		}

		[Constructable]
		public Magincia12AddonDeed()
		{
			Name = "Magincia12";
		}

		public Magincia12AddonDeed( Serial serial ) : base( serial )
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