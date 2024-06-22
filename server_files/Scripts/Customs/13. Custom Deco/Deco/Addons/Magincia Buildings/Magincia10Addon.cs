
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
	public class Magincia10Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {352, -9, -8, 1}, {352, -8, -8, 1}, {352, -1, -8, 1}// 1	2	3	
			, {352, 3, -8, 1}, {352, 0, -8, 1}, {352, -2, -8, 1}// 4	5	6	
			, {352, 2, -8, 1}, {352, 1, -8, 1}, {352, -6, -8, 1}// 7	8	9	
			, {352, -5, -8, 1}, {352, -7, -8, 1}, {352, -3, -8, 1}// 10	11	12	
			, {352, -4, -8, 1}, {353, -10, -8, 1}, {1281, -6, -6, 1}// 13	14	15	
			, {1281, -6, -7, 1}, {1281, 2, -4, 1}, {1281, 2, -5, 1}// 16	17	18	
			, {1281, 2, -6, 1}, {1281, -7, 6, 1}, {1281, -7, 5, 1}// 19	20	21	
			, {1281, 2, -1, 1}, {1281, 2, -2, 1}, {1281, 2, -3, 1}// 22	23	24	
			, {351, -10, -5, 1}, {1281, -9, 7, 1}, {1281, -7, 1, 1}// 25	26	27	
			, {1281, -6, 6, 1}, {1281, -5, 1, 1}, {1281, -5, 0, 1}// 28	29	30	
			, {1281, -2, -5, 1}, {1281, -9, 6, 1}, {1281, -9, 4, 1}// 31	32	33	
			, {1281, -9, 3, 1}, {1281, -9, 8, 1}, {1281, -7, 7, 1}// 34	35	36	
			, {1281, -3, 6, 1}, {1281, -8, 6, 1}, {1281, -3, -2, 1}// 37	38	39	
			, {1281, 1, 7, 1}, {1281, -4, -2, 1}, {1281, -5, -1, 1}// 40	41	42	
			, {1281, -7, 4, 1}, {1281, -4, 8, 1}, {1281, -3, 0, 1}// 43	44	45	
			, {1281, -3, 1, 1}, {1281, -3, 2, 1}, {1281, -3, 3, 1}// 46	47	48	
			, {1281, -4, 3, 1}, {1281, -5, -5, 1}, {1281, -4, 7, 1}// 49	50	51	
			, {1281, 1, 6, 1}, {1281, -4, 6, 1}, {1281, -4, 5, 1}// 52	53	54	
			, {1281, -4, 4, 1}, {1281, -1, 6, 1}, {1281, -5, 2, 1}// 55	56	57	
			, {1281, -5, 3, 1}, {1281, -1, 7, 1}, {1281, -1, 2, 1}// 58	59	60	
			, {1281, -1, 1, 1}, {1281, 0, 8, 1}, {1281, 0, 6, 1}// 61	62	63	
			, {1281, 1, 8, 1}, {1281, 0, 7, 1}, {1281, 2, 8, 1}// 64	65	66	
			, {1281, -1, 8, 1}, {1281, -3, 5, 1}, {1281, -1, 5, 1}// 67	68	69	
			, {1281, -1, 4, 1}, {1281, -2, -1, 1}, {1281, -2, -2, 1}// 70	71	72	
			, {1281, -4, -5, 1}, {1281, -3, -5, 1}, {1281, -1, 3, 1}// 73	74	75	
			, {1281, -2, 2, 1}, {1281, -2, 4, 1}, {1281, -2, 1, 1}// 76	77	78	
			, {1281, -2, 0, 1}, {1281, -3, 8, 1}, {1281, -3, 7, 1}// 79	80	81	
			, {1281, -4, 1, 1}, {1281, -4, 2, 1}, {1281, -4, 0, 1}// 82	83	84	
			, {1281, -9, 0, 1}, {1281, -5, 7, 1}, {1281, -9, 2, 1}// 85	86	87	
			, {1281, -9, 1, 1}, {1281, -3, -1, 1}, {2792, -2, -5, 2}// 88	89	90	
			, {1281, -2, 7, 1}, {1281, -2, 8, 1}, {1281, -2, 6, 1}// 91	92	93	
			, {1281, -2, 5, 1}, {1281, -8, 2, 1}, {1281, -2, 3, 1}// 94	95	96	
			, {1281, -8, 1, 1}, {1281, -8, 4, 1}, {1281, -8, 5, 1}// 97	98	99	
			, {1281, -6, 5, 1}, {1281, -6, 1, 1}, {1281, -8, 3, 1}// 100	101	102	
			, {1281, -5, -2, 1}, {1281, -5, 8, 1}, {1281, -8, 7, 1}// 103	104	105	
			, {1281, -8, 0, 1}, {1281, -7, 2, 1}, {1281, -8, 8, 1}// 106	107	108	
			, {1281, -7, 0, 1}, {1281, -1, 0, 1}, {1281, -4, -1, 1}// 109	110	111	
			, {1281, -5, -6, 1}, {1281, -7, 3, 1}, {1281, -5, 5, 1}// 112	113	114	
			, {1281, -5, 6, 1}, {1281, -6, 2, 1}, {1281, -1, -4, 1}// 115	116	117	
			, {1281, -6, -2, 1}, {1281, -6, -1, 1}, {1281, -7, -1, 1}// 118	119	120	
			, {1281, -7, -2, 1}, {1281, -8, -1, 1}, {1281, -8, -2, 1}// 121	122	123	
			, {1281, -9, -1, 1}, {1281, -9, -2, 1}, {1281, -9, 5, 1}// 124	125	126	
			, {1281, -6, 4, 1}, {1281, -6, 3, 1}, {1281, -1, -3, 1}// 127	128	129	
			, {1281, 2, -7, 1}, {1281, -1, -5, 1}, {1281, -1, -6, 1}// 130	131	132	
			, {1281, -3, 4, 1}, {1281, -7, 8, 1}, {1281, -6, 0, 1}// 133	134	135	
			, {1281, -6, 8, 1}, {1281, -6, 7, 1}, {1281, -5, 4, 1}// 136	137	138	
			, {1281, -1, 2, 1}, {1281, -1, 3, 1}, {1281, -1, 1, 1}// 139	140	141	
			, {1281, -1, 0, 1}, {1281, -1, -2, 1}, {1281, 0, -7, 1}// 142	143	144	
			, {1281, -1, -1, 1}, {1281, 0, -6, 1}, {1281, -1, 7, 0}// 145	146	147	
			, {1281, -1, 6, 1}, {1281, -1, 5, 1}, {1281, -1, -7, 1}// 148	149	150	
			, {1281, 0, -1, 1}, {1281, 0, 0, 1}, {1281, 0, -2, 1}// 151	152	153	
			, {1281, 0, -3, 1}, {1281, 0, -4, 1}, {1281, 0, -5, 1}// 154	155	156	
			, {1281, 0, 5, 1}, {1281, 0, 6, 1}, {1281, 0, 4, 1}// 157	158	159	
			, {1281, 0, 3, 1}, {1281, 0, 2, 1}, {1281, 0, 1, 1}// 160	161	162	
			, {1281, -1, 4, 1}, {1281, 1, -4, 1}, {1281, 1, -5, 1}// 163	164	165	
			, {1281, 1, -6, 1}, {1281, 1, -7, 1}, {1281, 0, 7, 0}// 166	167	168	
			, {1281, 2, 4, 0}, {1281, 2, 3, 0}, {1281, 2, 2, 0}// 169	170	171	
			, {1281, 2, 1, 0}, {1281, 2, 0, 0}, {1281, 2, -1, 0}// 172	173	174	
			, {1281, 2, -2, 0}, {1281, 2, -3, 0}, {1281, 2, -4, 0}// 175	176	177	
			, {1281, 2, -5, 0}, {1281, 2, -6, 0}, {1281, 2, -7, 0}// 178	179	180	
			, {1281, 1, 7, 0}, {1281, 1, 5, 1}, {1281, 1, 4, 1}// 181	182	183	
			, {1281, 1, 3, 1}, {1281, 1, 2, 1}, {1281, 1, 1, 1}// 184	185	186	
			, {1281, 1, 0, 1}, {1281, 1, -1, 1}, {1281, 1, -2, 1}// 187	188	189	
			, {1281, 1, -3, 1}, {1281, 2, 5, 0}, {1281, 2, 6, 0}// 190	191	192	
			, {1281, 2, 7, 0}, {1281, -4, -6, 1}, {1281, -2, -7, 1}// 193	194	195	
			, {1281, -4, -7, 1}, {2680, -8, 5, 1}, {2681, -8, 4, 1}// 196	197	198	
			, {2684, -9, 5, 1}, {2685, -9, 4, 1}, {2787, -2, 7, 2}// 199	200	201	
			, {2787, -1, -2, 2}, {2788, 2, -7, 2}, {2788, -7, -5, 3}// 202	203	204	
			, {2788, -6, 2, 2}, {2789, -7, -2, 2}, {2789, 2, -1, 2}// 205	206	207	
			, {2789, -6, 7, 2}, {2790, -2, 2, 2}, {2790, -1, -5, 2}// 208	209	210	
			, {2791, 2, -4, 2}, {2791, -6, 3, 2}, {2791, -7, -3, 2}// 211	212	213	
			, {2791, 2, -6, 2}, {2791, -6, 4, 2}, {2791, 2, -2, 2}// 214	215	216	
			, {2791, 2, -3, 2}, {2791, -6, 6, 2}, {2791, 2, -5, 2}// 217	218	219	
			, {2791, -7, -4, 3}, {2791, -6, 5, 2}, {2792, -4, -5, 2}// 220	221	222	
			, {2792, -4, 2, 2}, {2792, -3, 2, 2}, {2792, 3, -7, 2}// 223	224	225	
			, {2792, -3, -5, 2}, {2792, -5, 2, 2}, {2792, -5, -5, 2}// 226	227	228	
			, {2792, -6, -5, 3}, {2793, -2, 6, 2}, {2793, -2, 4, 2}// 229	230	231	
			, {2793, -2, 5, 2}, {2793, -2, 3, 2}, {2793, -1, -3, 2}// 232	233	234	
			, {2793, -1, -4, 2}, {2794, -4, -2, 2}, {2794, -2, -2, 2}// 235	236	237	
			, {2794, -3, 7, 2}, {2794, -5, -2, 2}, {2794, -4, 7, 2}// 238	239	240	
			, {2794, -5, 7, 3}, {2794, -3, -2, 2}, {2794, 3, -1, 2}// 241	242	243	
			, {2794, -6, -2, 2}, {2795, 3, -6, 2}, {2795, -3, 3, 2}// 244	245	246	
			, {2795, 3, -2, 2}, {2795, -3, 6, 2}, {2795, 3, -3, 2}// 247	248	249	
			, {2795, -5, 3, 2}, {2795, 3, -5, 2}, {2795, -5, 6, 2}// 250	251	252	
			, {2795, 3, -4, 2}, {2796, -3, 4, 2}, {2796, -4, 5, 2}// 253	254	255	
			, {2796, -4, 4, 2}, {2796, -4, 3, 2}, {2797, -4, -3, 1}// 256	257	258	
			, {2797, -4, -4, 1}, {2797, -4, 3, 1}, {2797, -5, 5, 2}// 259	260	261	
			, {2797, -6, -3, 1}, {2797, -4, 6, 2}, {2797, -3, -4, 1}// 262	263	264	
			, {2797, -5, -3, 2}, {2797, -3, 4, 1}, {2797, -3, 5, 2}// 265	266	267	
			, {2797, -2, -4, 2}, {2797, -3, -3, 2}, {2797, -5, 4, 2}// 268	269	270	
			, {2797, -6, -4, 1}, {2797, -5, -4, 1}, {2797, -2, -3, 2}// 271	272	273	
			, {2876, -9, 3, 1}, {2947, -2, -4, 1}, {2948, -2, -3, 1}// 274	275	276	
			, {2949, -6, -3, 1}, {2950, -4, -3, 1}, {2950, -6, -4, 1}// 277	278	279	
			, {2950, -5, -4, 1}, {2950, -3, -4, 1}, {2950, -3, -3, 1}// 280	281	282	
			, {2950, -4, -4, 3}, {2950, -5, -3, 1}, {4162, -3, -4, 5}// 283	284	285	
			, {4160, -3, -4, 5}, {3707, -2, -7, 1}, {2517, -2, -3, 5}// 286	287	288	
			, {2516, -4, -3, 5}, {350, 3, 8, 1}, {351, -10, 6, 1}// 289	290	291	
			, {351, -10, 5, 1}, {351, -10, 7, 1}, {351, -10, 8, 1}// 292	293	294	
			, {351, -10, 1, 1}, {351, -10, 0, 1}, {351, -10, -1, 1}// 295	296	297	
			, {351, -10, 2, 1}, {351, -10, 4, 1}, {351, -10, 3, 1}// 298	299	300	
			, {351, -10, -6, 1}, {351, -10, -7, 1}, {351, -10, -4, 1}// 301	302	303	
			, {351, -10, -2, 1}, {351, -10, -3, 1}, {351, -10, -4, 1}// 304	305	306	
			, {351, 3, 7, 2}, {351, 3, 6, 1}, {351, 3, 2, 1}// 307	308	309	
			, {351, 3, 2, 1}, {352, -9, 8, 1}, {352, -1, 8, 1}// 310	311	312	
			, {352, -2, 8, 1}, {352, 2, 8, 1}, {352, 0, 8, 1}// 313	314	315	
			, {352, 1, 8, 1}, {352, -6, 8, 1}, {352, -5, 8, 1}// 316	317	318	
			, {352, -8, 8, 1}, {352, -7, 8, 1}, {353, -5, 8, 18}// 319	320	321	
			, {353, 3, 1, 1}, {353, -3, 8, 1}, {363, -1, 8, 21}// 322	323	324	
			, {363, -7, 8, 21}, {366, 3, 5, 1}, {367, 3, 3, 1}// 325	326	327	
			, {398, -4, 8, 18}, {402, -3, 8, 18}, {1460, 0, 8, 37}// 328	329	330	
			, {1460, 0, 7, 37}, {1460, 0, 1, 37}, {1460, 0, 2, 37}// 331	332	333	
			, {1460, 0, 3, 37}, {1460, 0, 0, 37}, {1460, 0, -3, 37}// 334	335	336	
			, {1460, 0, -4, 37}, {1460, 0, -2, 37}, {1460, 0, -1, 37}// 337	338	339	
			, {1460, 0, 6, 37}, {1460, 0, 5, 37}, {1460, 0, 4, 37}// 340	341	342	
			, {1460, 3, 6, 28}, {1460, 3, 5, 28}, {1460, -2, 8, 43}// 343	344	345	
			, {1460, 3, 8, 28}, {1460, -2, -2, 43}, {1460, 3, 7, 28}// 346	347	348	
			, {1460, -2, 7, 43}, {1460, -2, -1, 43}, {1460, -2, 0, 43}// 349	350	351	
			, {1460, -2, 4, 43}, {1460, -2, 5, 43}, {1460, -2, 6, 43}// 352	353	354	
			, {1460, -2, 1, 43}, {1460, -2, 2, 43}, {1460, -2, 3, 43}// 355	356	357	
			, {1460, -2, -4, 43}, {1460, -2, -3, 43}, {1460, -1, -4, 40}// 358	359	360	
			, {1460, -1, 0, 40}, {1460, -1, 1, 40}, {1460, -1, -3, 40}// 361	362	363	
			, {1460, -1, -2, 40}, {1460, -1, -1, 40}, {1460, -1, 2, 40}// 364	365	366	
			, {1460, -1, 3, 40}, {1460, -1, 4, 40}, {1460, -1, 8, 40}// 367	368	369	
			, {1460, -1, 5, 40}, {1460, -1, 6, 40}, {1460, -1, 7, 40}// 370	371	372	
			, {1460, 3, 4, 28}, {1460, 3, 2, 28}, {1460, 3, 3, 28}// 373	374	375	
			, {1460, 3, 1, 28}, {1460, 1, 7, 34}, {1460, 1, 8, 34}// 376	377	378	
			, {1460, 1, 4, 34}, {1460, 1, 5, 34}, {1460, 1, 6, 34}// 379	380	381	
			, {1460, 1, 3, 34}, {1460, 1, 1, 34}, {1460, 1, 2, 34}// 382	383	384	
			, {1460, 1, -1, 34}, {1460, 1, 0, 34}, {1460, 2, 6, 31}// 385	386	387	
			, {1460, 2, 7, 31}, {1460, 2, 8, 31}, {1460, 2, 3, 31}// 388	389	390	
			, {1460, 2, 4, 31}, {1460, 2, 5, 31}, {1460, 2, 0, 31}// 391	392	393	
			, {1460, 2, 1, 31}, {1460, 2, 2, 31}, {1461, -6, 8, 34}// 394	395	396	
			, {1461, -4, 7, 40}, {1461, -4, 8, 40}, {1461, -3, 1, 43}// 397	398	399	
			, {1461, -3, 2, 43}, {1461, -3, 0, 43}, {1461, -3, -1, 43}// 400	401	402	
			, {1461, -4, 6, 40}, {1461, -6, 3, 34}, {1461, -3, 8, 43}// 403	404	405	
			, {1461, -6, 2, 34}, {1461, -6, 1, 34}, {1461, -6, 0, 34}// 406	407	408	
			, {1461, -6, 5, 34}, {1461, -6, 4, 34}, {1461, -3, 5, 43}// 409	410	411	
			, {1461, -3, 6, 43}, {1461, -3, 3, 43}, {1461, -3, 7, 43}// 412	413	414	
			, {1461, -3, 4, 43}, {1461, -6, -1, 34}, {1461, -3, -2, 43}// 415	416	417	
			, {1461, -6, 7, 34}, {1461, -4, -1, 40}, {1461, -4, 0, 40}// 418	419	420	
			, {1461, -3, -4, 43}, {1461, -4, 5, 40}, {1461, -4, 4, 40}// 421	422	423	
			, {1461, -3, -3, 43}, {1461, -4, 1, 40}, {1461, -4, 3, 40}// 424	425	426	
			, {1461, -4, 2, 40}, {1461, -6, 6, 34}, {1461, -8, 3, 28}// 427	428	429	
			, {1461, -8, 2, 28}, {1461, -8, 1, 28}, {1461, -9, 8, 25}// 430	431	432	
			, {1461, -9, 7, 25}, {1461, -5, 3, 37}, {1461, -8, 6, 28}// 433	434	435	
			, {1461, -8, 5, 28}, {1461, -8, 4, 28}, {1461, -8, 7, 28}// 436	437	438	
			, {1461, -8, 8, 28}, {1461, -9, 6, 25}, {1461, -5, 5, 37}// 439	440	441	
			, {1461, -9, 2, 25}, {1461, -9, 5, 25}, {1461, -9, 4, 25}// 442	443	444	
			, {1461, -9, 3, 25}, {1461, -5, 4, 37}, {1461, -7, 4, 31}// 445	446	447	
			, {1461, -7, 5, 31}, {1461, -7, 8, 31}, {1461, -7, 7, 31}// 448	449	450	
			, {1461, -7, 6, 31}, {1461, -7, 2, 31}, {1461, -7, 3, 31}// 451	452	453	
			, {1461, -5, -1, 37}, {1461, -5, -2, 37}, {1461, -7, 1, 31}// 454	455	456	
			, {1461, -5, -3, 37}, {1461, -5, -4, 37}, {1461, -7, 0, 31}// 457	458	459	
			, {1461, -4, -2, 40}, {1461, -4, -4, 40}, {1461, -4, -3, 40}// 460	461	462	
			, {1461, -5, 8, 37}, {1461, -5, 7, 37}, {1461, -5, 6, 37}// 463	464	465	
			, {1461, -5, 2, 37}, {1461, -5, 0, 37}, {1461, -5, 1, 37}// 466	467	468	
			, {1462, -8, 0, 28}, {1462, -6, -2, 34}, {1462, -9, 1, 25}// 469	470	471	
			, {1462, -7, -1, 31}, {1463, 1, -4, 34}, {1464, -6, -4, 34}// 472	473	474	
			, {1465, 2, -1, 31}, {1465, 3, 0, 28}, {1465, 1, -2, 34}// 475	476	477	
			, {1471, -6, -3, 37}, {1471, 3, -3, 37}, {1471, 2, -3, 37}// 478	479	480	
			, {1471, -7, -3, 37}, {1471, 1, -3, 37}, {1471, -9, -3, 37}// 481	482	483	
			, {1471, -8, -3, 37}, {1472, 2, -2, 34}, {1472, 3, -1, 31}// 484	485	486	
			, {1472, 3, -2, 34}, {1472, -7, -2, 34}, {1472, -9, 0, 28}// 487	488	489	
			, {1472, -9, -2, 34}, {1472, -9, -1, 31}, {1472, -8, -2, 34}// 490	491	492	
			, {1472, -8, -1, 31}, {1473, -1, -7, 25}, {1473, -1, -6, 28}// 493	494	495	
			, {1473, 3, -7, 25}, {1473, 3, -6, 28}, {1473, -1, -5, 31}// 496	497	498	
			, {1473, 0, -7, 25}, {1473, 0, -6, 28}, {1473, -3, -5, 31}// 499	500	501	
			, {1473, 0, -5, 31}, {1473, -3, -7, 25}, {1473, -3, -6, 28}// 502	503	504	
			, {1473, -8, -5, 31}, {1473, -8, -4, 34}, {1473, -8, -6, 28}// 505	506	507	
			, {1473, -8, -7, 25}, {1473, 1, -7, 25}, {1473, 1, -5, 31}// 508	509	510	
			, {1473, 1, -6, 28}, {1473, -5, -7, 25}, {1473, -5, -6, 28}// 511	512	513	
			, {1473, -5, -5, 31}, {1473, -9, -7, 25}, {1473, -7, -4, 34}// 514	515	516	
			, {1473, 2, -5, 31}, {1473, -9, -6, 28}, {1473, 2, -6, 28}// 517	518	519	
			, {1473, -6, -7, 25}, {1473, -6, -6, 28}, {1473, 3, -4, 34}// 520	521	522	
			, {1473, 3, -5, 31}, {1473, 2, -7, 25}, {1473, -6, -5, 31}// 523	524	525	
			, {1473, -4, -5, 31}, {1473, -2, -7, 25}, {1473, -7, -6, 28}// 526	527	528	
			, {1473, -7, -7, 25}, {1473, -7, -5, 31}, {1473, -2, -5, 31}// 529	530	531	
			, {1473, -2, -6, 28}, {1473, 2, -4, 34}, {1473, -4, -6, 28}// 532	533	534	
			, {1473, -9, -5, 31}, {1473, -4, -7, 25}, {1473, -9, -4, 34}// 535	536	537	
			, {1281, -8, -6, 1}, {1281, -8, -5, 1}, {1281, -8, -7, 1}// 538	539	540	
			, {1281, -9, -3, 1}, {1281, -9, -4, 1}, {1281, -9, -5, 1}// 541	542	543	
			, {1281, -9, -6, 1}, {1281, -9, -7, 1}, {1281, -8, -3, 1}// 544	545	546	
			, {1281, -8, -4, 1}, {1281, -5, -7, 1}, {1281, -3, -6, 1}// 547	548	549	
			, {1281, -3, -7, 1}, {1281, -2, -6, 1}, {1281, -7, -6, 1}// 550	551	552	
			, {1281, -7, -7, 1}, {1281, 3, -7, 1}, {1460, 0, 9, 37}// 553	554	555	
			, {1460, -2, 9, 43}, {1460, 3, 9, 28}, {1460, -1, 9, 40}// 556	557	558	
			, {1460, 1, 9, 34}, {1460, 2, 9, 31}, {1461, -6, 9, 34}// 559	560	561	
			, {1461, -4, 9, 40}, {1461, -3, 9, 43}, {1461, -9, 9, 25}// 562	563	564	
			, {1461, -8, 9, 28}, {1461, -5, 9, 37}, {1461, -7, 9, 31}// 565	566	567	
			, {352, 7, -8, 1}, {352, 5, -8, 1}, {352, 6, -8, 1}// 568	569	570	
			, {352, 4, -8, 0}, {1281, 6, -3, 1}, {1281, 6, -4, 1}// 571	572	573	
			, {1281, 4, -7, 1}, {361, 7, -5, 21}, {405, 8, -5, 1}// 574	575	576	
			, {1281, 7, -2, 1}, {1281, 7, -4, 2}, {1281, 7, -3, 1}// 577	578	579	
			, {1281, 7, 0, 1}, {1281, 7, -1, 1}, {1281, 7, -5, 1}// 580	581	582	
			, {1281, 7, -6, 1}, {1281, 6, -5, 1}, {1281, 5, -7, 1}// 583	584	585	
			, {1281, 6, -6, 1}, {2792, 6, -7, 2}, {2792, 5, -7, 2}// 586	587	588	
			, {2792, 4, -7, 2}, {2793, 6, -6, 2}, {2793, 6, -5, 2}// 589	590	591	
			, {2793, 6, -1, 2}, {2793, 6, -2, 2}, {2793, 6, -3, 2}// 592	593	594	
			, {2793, 6, -4, 2}, {2794, 5, -1, 2}, {2794, 4, -1, 2}// 595	596	597	
			, {2795, 5, -2, 2}, {2795, 4, -6, 2}, {2795, 5, -4, 2}// 598	599	600	
			, {2795, 5, -3, 2}, {2795, 5, -5, 2}, {2795, 5, -6, 2}// 601	602	603	
			, {2795, 4, -2, 2}, {2796, 4, -3, 2}, {2796, 4, -5, 2}// 604	605	606	
			, {2797, 4, -4, 2}, {2860, 8, -7, 1}, {350, 7, 1, 1}// 607	608	609	
			, {351, 7, -2, 1}, {351, 7, -7, 1}, {351, 7, -5, 1}// 610	611	612	
			, {352, 6, 1, 1}, {352, 5, 1, 1}, {352, 4, 1, 1}// 613	614	615	
			, {353, 7, -3, 1}, {356, 9, 8, 1}, {357, 4, 8, 1}// 616	619	620	
			, {357, 8, 8, 1}, {357, 7, 8, 1}, {357, 5, 8, 1}// 621	622	623	
			, {357, 6, 8, 1}, {358, 9, 7, 1}, {358, 9, 5, 1}// 624	625	626	
			, {358, 9, 6, 1}, {358, 9, 1, 1}, {358, 9, 2, 1}// 627	628	629	
			, {358, 9, 4, 1}, {358, 9, 3, 1}, {363, 7, -6, 21}// 630	631	632	
			, {363, 7, -2, 21}, {399, 7, -4, 18}, {400, 7, -3, 18}// 633	634	635	
			, {405, 8, -2, 1}, {405, 7, -5, 1}, {1460, 4, 5, 25}// 636	637	638	
			, {1460, 4, 4, 25}, {1460, 4, 2, 25}, {1460, 4, 3, 25}// 639	640	641	
			, {1460, 4, 6, 25}, {1460, 4, 7, 25}, {1460, 4, 8, 25}// 642	643	644	
			, {1465, 4, 1, 25}, {1471, 4, -3, 37}, {1471, 6, -3, 37}// 645	646	647	
			, {1471, 5, -3, 37}, {1471, 8, -3, 37}, {1471, 7, -3, 37}// 648	649	650	
			, {1472, 4, -1, 31}, {1472, 4, 0, 28}, {1472, 4, -2, 34}// 651	652	653	
			, {1472, 5, -2, 34}, {1472, 5, 0, 28}, {1472, 5, 1, 25}// 654	655	656	
			, {1472, 5, -1, 31}, {1472, 7, -1, 31}, {1472, 7, -2, 34}// 657	658	659	
			, {1472, 7, 1, 25}, {1472, 6, -2, 34}, {1472, 7, 0, 28}// 660	661	662	
			, {1472, 6, -1, 31}, {1472, 6, 0, 28}, {1472, 6, 1, 25}// 663	664	665	
			, {1472, 8, -1, 31}, {1472, 8, -2, 34}, {1472, 8, 0, 28}// 666	667	668	
			, {1472, 8, 1, 25}, {1473, 7, -7, 25}, {1473, 7, -6, 28}// 669	670	671	
			, {1473, 7, -5, 31}, {1473, 7, -4, 34}, {1473, 6, -6, 28}// 672	673	674	
			, {1473, 5, -5, 31}, {1473, 6, -7, 25}, {1473, 5, -4, 34}// 675	676	677	
			, {1473, 6, -5, 31}, {1473, 6, -4, 34}, {1473, 4, -7, 25}// 678	679	680	
			, {1473, 4, -6, 28}, {1473, 8, -7, 25}, {1473, 4, -5, 31}// 681	682	683	
			, {1473, 4, -4, 34}, {1473, 8, -5, 31}, {1473, 8, -6, 28}// 684	685	686	
			, {1473, 5, -7, 25}, {1473, 5, -6, 28}, {1473, 8, -4, 34}// 687	688	689	
			, {3235, 10, 1, 1}, {3235, 6, 4, 1}, {3231, 6, 6, 1}// 690	691	692	
			, {3222, 6, 5, 2}, {3205, 6, 4, 1}, {1281, 7, -7, 1}// 693	694	695	
			, {1281, 6, -7, 1}, {1281, 6, -2, 1}, {1281, 6, -1, 1}// 696	697	698	
			, {1460, 4, 9, 25}// 699	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Magincia10AddonDeed();
			}
		}

		[ Constructable ]
		public Magincia10Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 354, 7, -1, 1, 0, 0, "", 1);// 617
			AddComplexComponent( (BaseAddon) this, 354, 7, -6, 1, 0, 0, "", 1);// 618

		}

		public Magincia10Addon( Serial serial ) : base( serial )
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

	public class Magincia10AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Magincia10Addon();
			}
		}

		[Constructable]
		public Magincia10AddonDeed()
		{
			Name = "Magincia10";
		}

		public Magincia10AddonDeed( Serial serial ) : base( serial )
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