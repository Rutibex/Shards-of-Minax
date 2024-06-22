
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
	public class Magincia3Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3349, -9, -11, 3}, {3465, -9, -13, 2}, {353, 0, -11, 0}// 1	2	3	
			, {3223, -6, -12, 2}, {1332, 0, 5, 0}, {1332, 0, 4, 0}// 4	5	6	
			, {1332, 0, 3, 0}, {1332, 0, 2, 0}, {1332, 0, 1, 0}// 7	8	9	
			, {1332, 0, 0, 0}, {1332, 0, -1, 0}, {1332, 0, -2, 0}// 10	11	12	
			, {1332, -1, 5, 0}, {1332, -1, 4, 0}, {1332, -1, 3, 0}// 13	14	15	
			, {1332, -1, 2, 0}, {1332, -1, 1, 0}, {1332, -1, 0, 0}// 16	17	18	
			, {1332, -1, -1, 0}, {1332, -1, -2, 0}, {1332, -2, 5, 0}// 19	20	21	
			, {1332, -2, 4, 0}, {1332, -2, 3, 0}, {1332, -2, 2, 0}// 22	23	24	
			, {1332, -2, 1, 0}, {1332, -2, 0, 0}, {1332, -2, -1, 0}// 25	26	27	
			, {1332, -2, -2, 0}, {1332, -3, 5, 0}, {1332, -3, 4, 0}// 28	29	30	
			, {1332, -3, 3, 0}, {1332, -3, 2, 0}, {1332, -3, 1, 0}// 31	32	33	
			, {1332, -3, 0, 0}, {1332, -3, -1, 0}, {1332, -3, -2, 0}// 34	35	36	
			, {1332, -4, 5, 0}, {1332, -4, 4, 0}, {1332, -4, 3, 0}// 37	38	39	
			, {1332, -4, 2, 0}, {1332, -4, 1, 0}, {1332, -4, 0, 0}// 40	41	42	
			, {1332, -4, -1, 0}, {1332, -4, -2, 0}, {1332, -5, 5, 0}// 43	44	45	
			, {1332, -5, 4, 0}, {1332, -5, 3, 0}, {1332, -5, 2, 0}// 46	47	48	
			, {1332, -5, 1, 0}, {1332, -5, 0, 0}, {1332, -5, -1, 0}// 49	50	51	
			, {1332, -5, -2, 0}, {1332, -6, 5, 0}, {1332, -6, 4, 0}// 52	53	54	
			, {1332, -6, 3, 0}, {1332, -6, 2, 0}, {1332, -6, 1, 0}// 55	56	57	
			, {1332, -6, 0, 0}, {1332, -6, -1, 0}, {1332, -6, -2, 0}// 58	59	60	
			, {1332, -7, 4, 0}, {1332, -7, 5, 0}, {1332, -7, 3, 0}// 61	62	63	
			, {1332, -7, 2, 0}, {1332, -7, 1, 0}, {1332, -7, 0, 0}// 64	65	66	
			, {1332, -7, -1, 0}, {1332, -7, -2, 0}, {3378, -9, -10, 3}// 67	68	69	
			, {3378, -7, -5, 0}, {3342, -4, -6, 0}, {3410, -7, 5, 0}// 70	71	72	
			, {3411, -6, 4, 0}, {2758, -1, 1, 1}, {2758, -3, 1, 1}// 73	74	75	
			, {2758, -2, 2, 1}, {2759, 0, 2, 1}, {2760, 0, 1, 1}// 76	77	78	
			, {2760, -1, 2, 1}, {2760, -3, 2, 1}, {2760, -2, 1, 1}// 79	80	81	
			, {2760, 0, 2, 0}, {2762, -4, 0, 1}, {2763, -4, 3, 1}// 82	83	84	
			, {2765, -4, 1, 1}, {2765, -4, 2, 1}, {2766, -2, 0, 1}// 85	86	87	
			, {2766, 0, 0, 1}, {2766, -1, 0, 1}, {2766, -3, 0, 1}// 88	89	90	
			, {2768, -3, 3, 1}, {2768, 0, 3, 1}, {2768, -1, 3, 1}// 91	92	93	
			, {2768, -2, 3, 1}, {2933, -7, 3, 0}, {2934, -7, -1, 0}// 94	95	96	
			, {2938, -7, 1, 0}, {2938, -7, 2, 0}, {2938, -7, 0, 0}// 97	98	99	
			, {3718, -7, 0, 4}, {350, 0, -3, 0}, {351, -8, 2, 0}// 100	101	102	
			, {351, -8, 3, 0}, {351, -8, 4, 0}, {351, -8, 0, 0}// 103	104	105	
			, {351, -8, 1, 0}, {351, -8, 5, 0}, {351, -8, -2, 0}// 106	107	108	
			, {351, -8, -1, 0}, {351, 0, -4, 0}, {351, 0, -8, 0}// 109	110	111	
			, {351, 0, -9, 0}, {351, 0, -7, 0}, {351, 0, -5, 0}// 112	113	114	
			, {351, 0, -6, 0}, {351, 0, -10, 0}, {352, -7, -3, 0}// 115	116	117	
			, {352, -4, 5, 0}, {352, -4, -3, 0}, {352, -3, 5, 0}// 118	119	120	
			, {352, -3, -3, 0}, {352, -7, 5, 0}, {352, -5, -3, 0}// 121	122	123	
			, {352, -5, 5, 0}, {352, -6, -3, 0}, {352, -6, 5, 0}// 124	125	126	
			, {352, -1, -3, 0}, {352, -2, -3, 0}, {352, 0, 5, 0}// 127	128	129	
			, {352, -2, 5, 0}, {352, -1, 5, 0}, {353, -8, -3, 0}// 130	131	132	
			, {1471, -6, 2, 32}, {1471, 0, 2, 32}, {1471, -1, 2, 32}// 133	134	135	
			, {1471, -3, 2, 32}, {1471, -7, 2, 32}, {1471, -4, 2, 32}// 136	137	138	
			, {1471, -2, 2, 32}, {1471, -5, 2, 32}, {1472, -7, 3, 29}// 139	140	141	
			, {1472, -7, 4, 26}, {1472, -7, 5, 23}, {1472, -3, 5, 23}// 142	143	144	
			, {1472, -3, 3, 29}, {1472, -3, 4, 26}, {1472, -2, 3, 29}// 145	146	147	
			, {1472, -2, 4, 26}, {1472, -2, 5, 23}, {1472, -4, 3, 29}// 148	149	150	
			, {1472, -4, 4, 26}, {1472, 0, 5, 23}, {1472, 0, 4, 26}// 151	152	153	
			, {1472, 0, 3, 29}, {1472, -1, 4, 26}, {1472, -1, 3, 29}// 154	155	156	
			, {1472, -4, 5, 23}, {1472, -1, 5, 23}, {1472, -6, 5, 23}// 157	158	159	
			, {1472, -6, 3, 29}, {1472, -6, 4, 26}, {1472, -5, 4, 26}// 160	161	162	
			, {1472, -5, 5, 23}, {1472, -5, 3, 29}, {1473, -6, -2, 20}// 163	164	165	
			, {1473, -6, -1, 23}, {1473, -2, 1, 29}, {1473, -5, -1, 23}// 166	167	168	
			, {1473, -5, -2, 20}, {1473, -5, 0, 26}, {1473, 0, -1, 23}// 169	170	171	
			, {1473, -5, 1, 29}, {1473, 0, -2, 20}, {1473, -4, 0, 26}// 172	173	174	
			, {1473, -6, 0, 26}, {1473, -6, 1, 29}, {1473, 0, 0, 26}// 175	176	177	
			, {1473, -7, 0, 26}, {1473, -3, 0, 26}, {1473, -4, 1, 29}// 178	179	180	
			, {1473, -4, -1, 23}, {1473, -7, -1, 23}, {1473, -7, -2, 20}// 181	182	183	
			, {1473, 0, 1, 29}, {1473, -4, -2, 20}, {1473, -3, 1, 29}// 184	185	186	
			, {1473, -2, -1, 23}, {1473, -2, -2, 20}, {1473, -2, 0, 26}// 187	188	189	
			, {1473, -3, -2, 20}, {1473, -3, -1, 23}, {1473, -7, 1, 29}// 190	191	192	
			, {1473, -1, -2, 20}, {1473, -1, -1, 23}, {1473, -1, 1, 29}// 193	194	195	
			, {1473, -1, 0, 26}, {3226, -3, -6, 0}, {3223, -8, -5, 1}// 196	197	198	
			, {3315, -6, 10, 0}, {3316, -6, 11, 0}, {3395, -9, 7, 0}// 199	200	201	
			, {3396, -8, 6, 0}, {3408, -9, 7, 0}, {3409, -8, 6, 0}// 202	203	204	
			, {351, 0, 12, 0}, {351, 0, 13, 0}, {351, 0, 11, 0}// 205	206	207	
			, {351, 0, 10, 0}, {351, 0, 9, 0}, {351, 0, 8, 0}// 208	209	210	
			, {351, 0, 7, 0}, {351, 0, 6, 0}, {1472, -7, 6, 20}// 211	212	213	
			, {1472, -3, 6, 20}, {1472, -2, 6, 20}, {1472, -4, 6, 20}// 214	215	216	
			, {1472, 0, 6, 20}, {1472, -1, 6, 20}, {1472, -6, 6, 20}// 217	218	219	
			, {1472, -5, 6, 20}, {352, 1, -11, 0}, {352, 5, -11, 0}// 220	221	222	
			, {352, 2, -11, 0}, {352, 4, -11, 0}, {352, 3, -11, 0}// 223	224	225	
			, {352, 7, -11, 0}, {352, 8, -11, 0}, {352, 6, -11, 0}// 226	227	228	
			, {1330, 2, 0, 0}, {1330, 6, -6, 0}, {1330, 8, 5, 0}// 229	230	231	
			, {1330, 8, 4, 0}, {1330, 8, 3, 0}, {1330, 8, 2, 0}// 232	233	234	
			, {1330, 8, 1, 0}, {1330, 8, 0, 0}, {1330, 8, -1, 0}// 235	236	237	
			, {1330, 8, -2, 1}, {1330, 8, -3, 0}, {1330, 8, -5, 0}// 238	239	240	
			, {1330, 8, -6, 0}, {1330, 8, -4, 0}, {1330, 8, -7, 0}// 241	242	243	
			, {1330, 8, -8, 0}, {1330, 8, -9, 0}, {1330, 8, -10, 0}// 244	245	246	
			, {1330, 7, 5, 0}, {1330, 7, 4, 0}, {1330, 7, 3, 0}// 247	248	249	
			, {1330, 7, 2, 0}, {1330, 7, 1, 0}, {1330, 7, 0, 0}// 250	251	252	
			, {1330, 7, -1, 0}, {1330, 7, -2, 0}, {1330, 7, -3, 0}// 253	254	255	
			, {1330, 7, -4, 0}, {1330, 7, -5, 0}, {1330, 7, -6, 0}// 256	257	258	
			, {1330, 7, -7, 0}, {1330, 3, -9, 0}, {1330, 2, -3, 0}// 259	260	261	
			, {1330, 7, -8, 0}, {1330, 7, -9, 0}, {2758, 4, -3, 1}// 262	263	264	
			, {2758, 4, -7, 1}, {2758, 4, -5, 1}, {2758, 5, -6, 1}// 265	266	267	
			, {2758, 4, 1, 1}, {2758, 5, -4, 1}, {2758, 5, 2, 1}// 268	269	270	
			, {2758, 3, 2, 1}, {2759, 5, -3, 1}, {2759, 4, -6, 1}// 271	272	273	
			, {2759, 5, -7, 1}, {2759, 4, -4, 1}, {2759, 1, 2, 1}// 274	275	276	
			, {2759, 5, -5, 1}, {2759, 1, 1, 1}, {2760, 5, 1, 1}// 277	278	279	
			, {2760, 4, 2, 1}, {2760, 2, 1, 1}, {2760, 2, 2, 1}// 280	281	282	
			, {2760, 3, 1, 1}, {2761, 6, 3, 1}, {2761, 6, -2, 1}// 283	284	285	
			, {2762, 3, 5, 1}, {2762, 3, -8, 1}, {2763, 3, -2, 1}// 286	287	288	
			, {2764, 6, -8, 1}, {2764, 6, 0, 1}, {2764, 6, 5, 1}// 289	290	291	
			, {2765, 3, -3, 1}, {2765, 3, -4, 1}, {2765, 3, -5, 1}// 292	293	294	
			, {2765, 3, -7, 1}, {2765, 3, -6, 1}, {2766, 5, 5, 1}// 295	296	297	
			, {2766, 4, 5, 1}, {2766, 4, 0, 1}, {2766, 1, 0, 1}// 298	299	300	
			, {2766, 5, 0, 1}, {2766, 5, -8, 1}, {2766, 4, -8, 1}// 301	302	303	
			, {2766, 2, 0, 1}, {2766, 3, 0, 1}, {2767, 6, -5, 1}// 304	305	306	
			, {2767, 6, -4, 1}, {2767, 6, -3, 1}, {2767, 6, -6, 1}// 307	308	309	
			, {2767, 6, 2, 1}, {2767, 6, -7, 1}, {2767, 6, 1, 1}// 310	311	312	
			, {2768, 5, -2, 1}, {2768, 2, 3, 1}, {2768, 4, -2, 1}// 313	314	315	
			, {2768, 3, 3, 1}, {2768, 4, 3, 1}, {2768, 5, 3, 1}// 316	317	318	
			, {2768, 1, 3, 1}, {2933, 1, -4, 0}, {2934, 1, -7, 0}// 319	320	321	
			, {2938, 1, -6, 0}, {2938, 1, -5, 0}, {3888, 1, -4, 4}// 322	323	324	
			, {3886, 1, -4, 4}, {3884, 1, -4, 4}, {3883, 1, -5, 4}// 325	326	327	
			, {3880, 1, -6, 4}, {3879, 1, -4, 4}, {3877, 1, -5, 4}// 328	329	330	
			, {3876, 1, -6, 4}, {3875, 1, -6, 4}, {3872, 1, -4, 4}// 331	332	333	
			, {3869, 1, -6, 4}, {3868, 1, -6, 4}, {3867, 1, -4, 4}// 334	335	336	
			, {3862, 1, -6, 4}, {3860, 1, -7, 4}, {3857, 1, -6, 4}// 337	338	339	
			, {3856, 1, -7, 4}, {3855, 1, -5, 4}, {3855, 1, -6, 4}// 340	341	342	
			, {351, 8, -5, 0}, {351, 8, -9, 0}, {351, 8, -6, 0}// 343	344	345	
			, {351, 8, 5, 0}, {351, 8, -1, 0}, {351, 8, -10, 0}// 346	347	348	
			, {353, 8, 4, 0}, {366, 8, -2, 0}, {367, 8, -4, 0}// 349	352	353	
			, {404, 8, 1, 0}, {404, 8, 2, 0}, {404, 8, 3, 0}// 354	355	356	
			, {404, 8, 0, 0}, {1327, 3, -10, 20}, {1328, 6, -10, 20}// 357	358	359	
			, {1329, 2, -10, 20}, {1330, 1, -10, 20}, {1330, 4, -10, 20}// 360	361	362	
			, {1459, 5, 0, 32}, {1459, 5, -4, 32}, {1459, 5, -5, 32}// 363	364	365	
			, {1459, 5, -2, 32}, {1459, 5, -1, 32}, {1459, 5, -3, 32}// 366	367	368	
			, {1459, 5, 1, 32}, {1459, 5, -10, 32}, {1459, 5, -9, 32}// 369	370	371	
			, {1459, 5, -6, 32}, {1459, 5, -8, 32}, {1459, 5, -7, 32}// 372	373	374	
			, {1459, 5, 3, 32}, {1459, 5, 5, 32}, {1459, 5, 4, 32}// 375	376	377	
			, {1460, 6, -9, 29}, {1460, 6, -10, 29}, {1460, 6, -6, 29}// 378	379	380	
			, {1460, 6, -7, 29}, {1460, 6, -8, 29}, {1460, 7, 5, 26}// 381	382	383	
			, {1460, 7, 4, 26}, {1460, 7, 3, 26}, {1460, 7, -10, 26}// 384	385	386	
			, {1460, 7, -7, 26}, {1460, 7, -8, 26}, {1460, 7, -9, 26}// 387	388	389	
			, {1460, 7, 0, 26}, {1460, 7, -1, 26}, {1460, 7, 2, 26}// 390	391	392	
			, {1460, 7, 1, 26}, {1460, 7, -4, 26}, {1460, 7, -5, 26}// 393	394	395	
			, {1460, 7, -6, 26}, {1460, 7, -2, 26}, {1460, 7, -3, 26}// 396	397	398	
			, {1460, 8, 1, 23}, {1460, 8, 2, 23}, {1460, 8, 0, 23}// 399	400	401	
			, {1460, 8, 3, 23}, {1460, 8, 4, 23}, {1460, 8, 5, 23}// 402	403	404	
			, {1460, 8, -9, 23}, {1460, 8, -10, 23}, {1460, 8, -6, 23}// 405	406	407	
			, {1460, 8, -7, 23}, {1460, 8, -8, 23}, {1460, 8, -2, 23}// 408	409	410	
			, {1460, 8, -1, 23}, {1460, 8, -5, 23}, {1460, 8, -4, 23}// 411	412	413	
			, {1460, 8, -3, 23}, {1460, 9, 5, 20}, {1460, 9, 4, 20}// 414	415	416	
			, {1460, 9, 3, 20}, {1460, 9, 2, 20}, {1460, 9, -3, 20}// 417	418	419	
			, {1460, 9, -2, 20}, {1460, 9, -4, 20}, {1460, 9, -6, 20}// 420	421	422	
			, {1460, 9, -5, 20}, {1460, 9, -1, 20}, {1460, 9, 0, 20}// 423	424	425	
			, {1460, 9, 1, 20}, {1460, 6, 0, 29}, {1460, 6, 1, 29}// 426	427	428	
			, {1460, 6, 2, 29}, {1460, 6, -1, 29}, {1460, 6, -5, 29}// 429	430	431	
			, {1460, 6, -4, 29}, {1460, 6, -2, 29}, {1460, 6, -3, 29}// 432	433	434	
			, {1460, 6, 3, 29}, {1460, 6, 5, 29}, {1460, 6, 4, 29}// 435	436	437	
			, {1460, 9, -10, 20}, {1460, 9, -9, 20}, {1460, 9, -8, 20}// 438	439	440	
			, {1460, 9, -7, 20}, {1461, 2, -5, 23}, {1461, 2, -4, 23}// 441	442	443	
			, {1461, 2, -3, 23}, {1461, 2, -6, 23}, {1461, 2, -2, 23}// 444	445	446	
			, {1461, 2, -8, 23}, {1461, 2, -7, 23}, {1461, 2, -9, 23}// 447	448	449	
			, {1461, 2, -10, 23}, {1461, 4, -9, 29}, {1461, 4, -10, 29}// 450	451	452	
			, {1461, 3, -5, 26}, {1461, 4, -8, 29}, {1461, 4, -5, 29}// 453	454	455	
			, {1461, 4, -6, 29}, {1461, 4, -7, 29}, {1461, 3, -3, 26}// 456	457	458	
			, {1461, 3, -4, 26}, {1461, 4, -4, 29}, {1461, 4, 5, 29}// 459	460	461	
			, {1461, 4, 4, 29}, {1461, 3, -6, 26}, {1461, 4, -2, 29}// 462	463	464	
			, {1461, 4, -3, 29}, {1461, 4, -1, 29}, {1461, 3, -8, 26}// 465	466	467	
			, {1461, 3, -7, 26}, {1461, 4, 0, 29}, {1461, 3, -1, 26}// 468	469	470	
			, {1461, 3, 5, 26}, {1461, 3, -2, 26}, {1461, 3, -10, 26}// 471	472	473	
			, {1461, 3, -9, 26}, {1461, 1, -6, 20}, {1461, 1, -7, 20}// 474	475	476	
			, {1461, 1, -4, 20}, {1461, 1, -5, 20}, {1461, 1, -3, 20}// 477	478	479	
			, {1461, 1, -10, 20}, {1461, 1, -9, 20}, {1461, 1, -8, 20}// 480	481	482	
			, {1462, 3, 4, 26}, {1462, 2, 5, 23}, {1462, 4, 3, 29}// 483	484	485	
			, {1464, 1, -2, 20}, {1464, 3, 0, 26}, {1464, 2, -1, 23}// 486	487	488	
			, {1464, 4, 1, 29}, {1469, 5, 2, 32}, {1471, 1, 2, 32}// 489	490	491	
			, {1471, 4, 2, 32}, {1471, 2, 2, 32}, {1471, 3, 2, 32}// 492	493	494	
			, {1472, 1, 4, 26}, {1472, 1, 3, 29}, {1472, 1, 5, 23}// 495	496	497	
			, {1472, 2, 4, 26}, {1472, 2, 3, 29}, {1472, 3, 3, 29}// 498	499	500	
			, {1473, 1, 1, 29}, {1473, 3, 1, 29}, {1473, 1, -1, 23}// 501	502	503	
			, {1473, 1, 0, 26}, {1473, 2, 1, 29}, {1473, 2, 0, 26}// 504	505	506	
			, {1330, 7, -10, 0}, {1330, 6, 5, 0}, {1330, 6, 4, 0}// 507	508	509	
			, {1330, 2, -1, 0}, {1330, 6, 3, 0}, {1330, 6, 2, 0}// 510	511	512	
			, {1330, 5, 5, 0}, {1330, 6, 1, 0}, {1330, 6, 0, 0}// 513	514	515	
			, {1330, 6, -1, 0}, {1330, 6, -2, 0}, {1330, 6, -3, 0}// 516	517	518	
			, {1330, 6, -4, 0}, {1330, 6, -5, 0}, {1330, 6, -7, 0}// 519	520	521	
			, {1330, 6, -8, 0}, {1330, 6, -9, 0}, {1330, 6, -10, 0}// 522	523	524	
			, {1330, 5, 4, 0}, {1330, 5, 3, 0}, {1330, 5, 2, 0}// 525	526	527	
			, {1330, 5, 1, 0}, {1330, 5, 0, 0}, {1330, 5, -1, 0}// 528	529	530	
			, {1330, 5, -2, 0}, {1330, 5, -3, 0}, {1330, 5, -5, 0}// 531	532	533	
			, {1330, 5, -6, 0}, {1330, 5, -4, 0}, {3053, 9, -1, 0}// 534	535	536	
			, {1330, 3, 2, 0}, {1330, 2, -5, 0}, {1330, 2, -4, 0}// 537	538	539	
			, {1330, 3, -10, 0}, {1330, 3, 3, 0}, {1330, 3, 5, 0}// 540	541	542	
			, {1330, 3, 4, 0}, {1330, 3, -4, 0}, {1330, 2, 4, 0}// 543	544	545	
			, {1330, 2, 5, 0}, {1330, 2, 3, 0}, {1330, 2, -7, 0}// 546	547	548	
			, {1330, 2, 2, 0}, {1330, 2, 1, 0}, {1330, 2, -6, 0}// 549	550	551	
			, {1330, 3, -3, 0}, {1330, 3, -2, 0}, {1330, 3, -1, 0}// 552	553	554	
			, {1330, 3, 1, 0}, {1330, 3, 0, 0}, {1330, 3, -6, 0}// 555	556	557	
			, {1330, 3, -5, 0}, {1330, 3, -7, 0}, {1330, 3, -8, 0}// 558	559	560	
			, {1330, 1, -7, 0}, {1330, 1, -6, 0}, {1330, 1, -5, 0}// 561	562	563	
			, {1330, 1, -3, 0}, {1330, 2, -2, 0}, {1330, 1, 2, 0}// 564	565	566	
			, {1330, 1, -9, 0}, {1330, 1, -8, 0}, {1330, 1, -10, 0}// 567	568	569	
			, {1330, 1, -1, 0}, {1330, 1, 0, 0}, {1330, 1, 1, 0}// 570	571	572	
			, {1330, 1, 3, 0}, {1330, 1, -2, 0}, {1330, 1, 4, 0}// 573	574	575	
			, {1330, 1, 5, 0}, {1330, 1, -4, 0}, {1330, 2, -10, 0}// 576	577	578	
			, {1330, 2, -9, 0}, {1330, 2, -8, 0}, {1330, 4, 5, 0}// 579	580	581	
			, {1330, 4, 4, 0}, {1330, 4, 3, 0}, {1330, 4, 2, 0}// 582	583	584	
			, {1330, 4, 1, 0}, {1330, 4, 0, 0}, {1330, 5, -7, 0}// 585	586	587	
			, {1330, 5, -8, 0}, {1330, 5, -9, 0}, {1330, 5, -10, 0}// 588	589	590	
			, {1330, 4, -10, 0}, {1330, 4, -9, 0}, {1330, 4, -8, 0}// 591	592	593	
			, {1330, 4, -7, 0}, {1330, 4, -6, 0}, {1330, 4, -5, 0}// 594	595	596	
			, {1330, 4, -4, 0}, {1330, 4, -3, 0}, {1330, 4, -2, 0}// 597	598	599	
			, {1330, 4, -1, 0}, {1330, 5, 13, 0}, {1330, 8, 13, 0}// 600	601	602	
			, {1330, 8, 12, 0}, {1330, 8, 11, 0}, {1330, 8, 10, 0}// 603	604	605	
			, {1330, 8, 9, 0}, {1330, 8, 8, 0}, {1330, 8, 7, 0}// 606	607	608	
			, {1330, 8, 6, 0}, {1330, 7, 13, 0}, {1330, 7, 12, 0}// 609	610	611	
			, {1330, 7, 11, 0}, {1330, 7, 10, 0}, {1330, 7, 9, 0}// 612	613	614	
			, {1330, 7, 8, 0}, {1330, 7, 7, 0}, {1330, 7, 6, 0}// 615	616	617	
			, {1330, 1, 11, 0}, {2758, 5, 8, 1}, {2758, 5, 6, 1}// 618	619	620	
			, {2758, 5, 10, 1}, {2758, 4, 7, 1}, {2758, 4, 9, 1}// 621	622	623	
			, {2759, 5, 7, 1}, {2759, 4, 8, 1}, {2759, 4, 6, 1}// 624	625	626	
			, {2759, 5, 9, 1}, {2759, 4, 10, 1}, {2761, 6, 11, 1}// 627	628	629	
			, {2763, 3, 11, 1}, {2765, 3, 6, 1}, {2765, 3, 7, 1}// 630	631	632	
			, {2765, 3, 8, 1}, {2765, 3, 10, 1}, {2765, 3, 9, 1}// 633	634	635	
			, {2767, 6, 10, 1}, {2767, 6, 8, 1}, {2767, 6, 9, 1}// 636	637	638	
			, {2767, 6, 7, 1}, {2767, 6, 6, 1}, {2768, 5, 11, 1}// 639	640	641	
			, {2768, 4, 11, 1}, {2933, 1, 10, 0}, {2934, 1, 7, 0}// 642	643	644	
			, {2938, 1, 9, 0}, {2938, 1, 8, 0}, {3887, 1, 10, 4}// 645	646	647	
			, {3887, 1, 8, 4}, {3882, 1, 9, 4}, {3881, 2, 10, 7}// 648	649	650	
			, {3881, 2, 8, 7}, {3880, 1, 9, 4}, {3880, 1, 7, 4}// 651	652	653	
			, {3879, 1, 9, 4}, {3875, 1, 10, 4}, {3875, 1, 8, 4}// 654	655	656	
			, {3874, 1, 8, 4}, {3874, 1, 10, 4}, {3872, 1, 7, 4}// 657	658	659	
			, {3872, 1, 9, 4}, {3871, 1, 9, 4}, {3869, 1, 10, 4}// 660	661	662	
			, {3869, 1, 8, 4}, {3868, 1, 9, 4}, {3868, 1, 7, 4}// 663	664	665	
			, {350, 8, 13, 0}, {351, 8, 9, 0}, {352, 4, 13, 0}// 666	667	668	
			, {352, 1, 13, 0}, {352, 5, 13, 0}, {352, 2, 13, 0}// 669	670	671	
			, {352, 3, 13, 0}, {352, 7, 13, 0}, {352, 6, 13, 0}// 672	673	674	
			, {366, 8, 8, 0}, {367, 8, 6, 0}, {1459, 5, 9, 32}// 677	678	679	
			, {1459, 5, 7, 32}, {1459, 5, 6, 32}, {1459, 5, 8, 32}// 680	681	682	
			, {1459, 5, 14, 32}, {1459, 5, 13, 32}, {1459, 5, 12, 32}// 683	684	685	
			, {1459, 5, 11, 32}, {1459, 5, 10, 32}, {1460, 7, 11, 26}// 686	687	688	
			, {1460, 7, 10, 26}, {1460, 7, 14, 26}, {1460, 7, 13, 26}// 689	690	691	
			, {1460, 7, 12, 26}, {1460, 7, 6, 26}, {1460, 7, 9, 26}// 692	693	694	
			, {1460, 7, 8, 26}, {1460, 7, 7, 26}, {1460, 8, 6, 23}// 695	696	697	
			, {1460, 8, 7, 23}, {1460, 8, 11, 23}, {1460, 8, 12, 23}// 698	699	700	
			, {1460, 8, 13, 23}, {1460, 8, 8, 23}, {1460, 8, 9, 23}// 701	702	703	
			, {1460, 8, 10, 23}, {1460, 8, 14, 23}, {1460, 6, 13, 29}// 704	705	706	
			, {1460, 6, 14, 29}, {1460, 9, 6, 20}, {1460, 6, 9, 29}// 707	708	709	
			, {1460, 9, 7, 20}, {1460, 6, 10, 29}, {1460, 6, 12, 29}// 710	711	712	
			, {1460, 6, 11, 29}, {1460, 9, 13, 20}, {1460, 9, 12, 20}// 713	714	715	
			, {1460, 9, 14, 20}, {1460, 9, 9, 20}, {1460, 6, 7, 29}// 716	717	718	
			, {1460, 9, 8, 20}, {1460, 6, 8, 29}, {1460, 9, 10, 20}// 719	720	721	
			, {1460, 6, 6, 29}, {1460, 9, 11, 20}, {1461, 2, 7, 23}// 722	723	724	
			, {1461, 2, 8, 23}, {1461, 2, 6, 23}, {1461, 2, 13, 23}// 725	726	727	
			, {1461, 2, 14, 23}, {1461, 2, 12, 23}, {1461, 2, 9, 23}// 728	729	730	
			, {1461, 2, 10, 23}, {1461, 2, 11, 23}, {1461, 4, 6, 29}// 731	732	733	
			, {1461, 4, 7, 29}, {1461, 4, 10, 29}, {1461, 4, 9, 29}// 734	735	736	
			, {1461, 4, 8, 29}, {1461, 3, 6, 26}, {1461, 3, 7, 26}// 737	738	739	
			, {1461, 3, 11, 26}, {1461, 3, 10, 26}, {1461, 3, 9, 26}// 740	741	742	
			, {1461, 3, 12, 26}, {1461, 3, 8, 26}, {1461, 3, 14, 26}// 743	744	745	
			, {1461, 3, 13, 26}, {1461, 4, 13, 29}, {1461, 4, 12, 29}// 746	747	748	
			, {1461, 4, 11, 29}, {1461, 4, 14, 29}, {1461, 1, 7, 20}// 749	750	751	
			, {1461, 1, 10, 20}, {1461, 1, 11, 20}, {1461, 1, 8, 20}// 752	753	754	
			, {1461, 1, 9, 20}, {1461, 1, 14, 20}, {1461, 1, 13, 20}// 755	756	757	
			, {1461, 1, 12, 20}, {1462, 1, 6, 20}, {1330, 6, 13, 0}// 758	759	760	
			, {1330, 6, 12, 0}, {1330, 6, 11, 0}, {1330, 6, 10, 0}// 761	762	763	
			, {1330, 6, 9, 0}, {1330, 6, 8, 0}, {1330, 6, 7, 0}// 764	765	766	
			, {1330, 6, 6, 0}, {1330, 5, 12, 0}, {1330, 5, 11, 0}// 767	768	769	
			, {1330, 5, 10, 0}, {1330, 5, 9, 0}, {1330, 5, 8, 0}// 770	771	772	
			, {1330, 5, 7, 0}, {1330, 5, 6, 0}, {1330, 1, 12, 0}// 773	774	775	
			, {1330, 1, 13, 0}, {1330, 2, 11, 0}, {1330, 2, 10, 0}// 776	777	778	
			, {1330, 3, 6, 0}, {1330, 2, 8, 0}, {1330, 2, 13, 0}// 779	780	781	
			, {1330, 2, 7, 0}, {1330, 2, 9, 0}, {1330, 2, 6, 0}// 782	783	784	
			, {1330, 2, 12, 0}, {1330, 1, 8, 0}, {1330, 1, 10, 0}// 785	786	787	
			, {1330, 1, 9, 0}, {1330, 1, 6, 0}, {1330, 1, 7, 0}// 788	789	790	
			, {1330, 3, 7, 0}, {1330, 3, 8, 0}, {1330, 3, 9, 0}// 791	792	793	
			, {1330, 3, 10, 0}, {1330, 3, 11, 0}, {1330, 3, 12, 0}// 794	795	796	
			, {1330, 4, 8, 0}, {1330, 4, 9, 0}, {1330, 4, 10, 0}// 797	798	799	
			, {1330, 4, 12, 0}, {1330, 4, 11, 0}, {1330, 4, 7, 0}// 800	801	802	
			, {1330, 4, 6, 0}, {1330, 4, 13, 0}, {1330, 3, 13, 0}// 803	804	805	
			, {351, 8, 12, 0}// 806	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Magincia3AddonDeed();
			}
		}

		[ Constructable ]
		public Magincia3Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 354, 8, -8, 0, 0, 0, "", 1);// 350
			AddComplexComponent( (BaseAddon) this, 354, 8, -7, 0, 0, 0, "", 1);// 351
			AddComplexComponent( (BaseAddon) this, 354, 8, 10, 0, 0, 0, "", 1);// 675
			AddComplexComponent( (BaseAddon) this, 354, 8, 11, 0, 0, 0, "", 1);// 676

		}

		public Magincia3Addon( Serial serial ) : base( serial )
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

	public class Magincia3AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Magincia3Addon();
			}
		}

		[Constructable]
		public Magincia3AddonDeed()
		{
			Name = "Magincia3";
		}

		public Magincia3AddonDeed( Serial serial ) : base( serial )
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