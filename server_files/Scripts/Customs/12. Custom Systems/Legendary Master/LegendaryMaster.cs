using System;
using System.Linq;
using Server.Items;
using Server.Mobiles;
using System.Collections.Generic;

namespace Server.Custom.Misc
{
    public class LegendaryMaster : BaseCreature
    {
        private static List<SkillTaskInfo> taskInfos;

        private static TimeSpan TaskTime = TimeSpan.FromMinutes(60); // task time to start!

        private static TimeSpan ExtraTaskTime = TimeSpan.FromMinutes(10); // additional time added per kill!

        public static void Initialize()
        {
            EventSink.CreatureDeath += new CreatureDeathEventHandler(EventSink_CreatureDeath);
        }

        private static void EventSink_CreatureDeath(CreatureDeathEventArgs e)
        {
            if (e.Killer == null)
            {
                return;
            }

            if (e.Creature != null && ValidateName(e.Creature.GetType()))
            {
                if (taskInfos != null && taskInfos.Count > 0 && e.Killer is PlayerMobile)
                {
                    PlayerMobile pm = (PlayerMobile)e.Killer;
                    SkillTaskInfo currentInfo = null;

                    foreach (var info in taskInfos)
                    {
                        if (pm.Serial == info.PlayerSerial)
                        {
                            if (info.TargetName == e.Creature.GetType())
                            {
                                if (!info.Completed && info.TimeLimit > DateTime.Now)
                                {
                                    if (info.TaskAmount == 0)
                                    {
                                        pm.AddToBackpack(new PowerScroll(info.PlayerSkill, info.SkillCap + 5));

                                        pm.SendMessage(53, string.Format("You were rewarded a {0} {1} Powerscroll!", info.SkillCap + 5, info.PlayerSkill));

                                        TryGiveStatScroll(pm);
                                    }
                                }
                                else
                                {
                                    if (info.Completed)
                                    {
                                        pm.SendMessage(53, "You already completed this task!");
                                    }
                                    else
                                    {
                                        pm.SendMessage(53, "You ran out of time for this task!");
                                    }
                                }

                                currentInfo = info;
                            }
                        }
                    }

                    if (currentInfo != null)
                    {
                        if (currentInfo.TaskAmount > 0 && currentInfo.TimeLimit > DateTime.Now)
                        {
                            currentInfo.TaskAmount--;

                            currentInfo.TimeLimit += ExtraTaskTime;

                            currentInfo.TargetName = GetRandomCreature();

                            KillMessage(pm, currentInfo);
                        }
                        else
                        {
                            currentInfo.Completed = true;
                        }
                    }

                    CleanTaskInfos();
                }
            }
        }

        private static void TryGiveStatScroll(PlayerMobile pm)
        {
            if (Utility.RandomDouble() < 0.01)
            {
                if (Utility.RandomDouble() < 0.01)
                {
                    pm.AddToBackpack(new StatCapScroll(pm.StatCap + RandomStatScrollLevel()));
                }
                else
                {
                    pm.AddToBackpack(new StatCapScroll(pm.StatCap +  5));
                }

                pm.SendLocalizedMessage(1049524); // You have received a scroll of power!
            }
        }

        private static int RandomStatScrollLevel()
        {
            double random = Utility.RandomDouble();

            if (0.1 >= random)
                return 25;
            else if (0.25 >= random)
                return 20;
            else if (0.45 >= random)
                return 15;
            else if (0.70 >= random)
                return 10;
            return 5;
        }

        private static void CleanTaskInfos()
        {
            if (taskInfos != null && taskInfos.Count > 0)
            {
                taskInfos.RemoveAll(i => i.Completed);
            }
        }

        private static bool ValidateName(Type creature)
        {
            if (CreatureList().Contains(creature)) return true;

            return false;
        }

        private static Type GetRandomCreature()
        {
            return CreatureList()[Utility.Random(CreatureList().Count - 1)];
        }

        private static List<Type> creatureCache;

        private static List<Type> CreatureList()
        {
            if (creatureCache == null)
            {
                creatureCache = new List<Type>()
                {
                    typeof(Balron),
                    typeof(ShadowWyrm),
                    typeof(EvilMageLord),
                    typeof(AncientLich),
                    typeof(AncientWyrm),
                    typeof(SkeletalDragon),
                    typeof(WhiteWyrm)
                };
            }

            return creatureCache;
        }

        public override bool IsInvulnerable { get { return true; } }

        [Constructable]
        public LegendaryMaster() : base(AIType.AI_Vendor, FightMode.None, 10, 1, .2, .4)
        {
            if (taskInfos == null)
            {
                taskInfos = new List<SkillTaskInfo>();
            }

            Name = "Legendary Master of Skills";

            Body = 0x190;

            Hue = Race.RandomSkinHue();

            InitStats(150, 150, 150);

            SetWearable(new HoodedShroudOfShadows(), 0x481);

            SetWearable(new Sandals(), 0x481);

            Blessed = true;

            CantWalk = true;

            SpeechHue = 53;
        }

        public override bool HandlesOnSpeech(Mobile from)
        {
            return true;
        }

        public override void OnSpeech(SpeechEventArgs e)
        {
            if (e.Mobile is PlayerMobile && e.Mobile.InRange(Location, 5))
            {
                PlayerMobile pm = (PlayerMobile)e.Mobile;
                if (e.Speech.StartsWith("give task"))
                {
                    if (pm.IsStaff())
                    {
                        SayTo(pm, "I am on duty, waiting for a player to help!");

                        return;
                    }

                    if (taskInfos.Any(i => i.PlayerSerial == pm.Serial))
                    {
                        pm.SendMessage(53, "You already have a task!");

                        return;
                    }

                    foreach (var skill in pm.Skills)
                    {
                        if (e.Speech.EndsWith(skill.Name.ToLower()) && skill.Value > 99)
                        {
                            if (skill.Cap == 120)
                            {
                                if (skill.Value < 120)
                                {
                                    SayTo(pm, string.Format("You need to get {0} to {1}!", skill.Name, skill.Cap));

                                    SayTo(pm, "Have fun!");
                                }
                                else
                                {
                                    SayTo(pm, string.Format("Your {0} is already {1}, you're not fooling me!", skill.Name, skill.Value));
                                }
                            }
                            else
                            {
                                int skilldiff = (int)skill.Cap - 100;

                                skilldiff = skilldiff > 0 ? skilldiff / 5 : 0;

                                UpdateSkillTask(pm, skill, GetRandomCreature(), Utility.RandomMinMax(1, 3 + skilldiff));
                            }
                        }
                    }
                }
                else if (e.Speech.StartsWith("remove task"))
                {
                    if (taskInfos.Any(i => i.PlayerSerial == e.Mobile.Serial))
                    {
                        taskInfos.RemoveAll(ti => ti.PlayerSerial == e.Mobile.Serial);

                        SayTo(e.Mobile, "You are now free of any tasks!");
                    }
                    else
                    {
                        SayTo(e.Mobile, "You don't have any tasks!");
                    }
                }
                else
                {
                    if (Utility.RandomDouble() < 0.1)
                    {
                        SayTo(e.Mobile, "Do you need a task? I trade Powerscrolls!");
                    }
                }
            }

            base.OnSpeech(e);
        }

        private void UpdateSkillTask(PlayerMobile pm, Skill skill, Type target, int amount)
        {
            if (skill.Value == skill.Cap)
            {
                taskInfos.Add(new SkillTaskInfo()
                {
                    PlayerSerial = pm.Serial,
                    PlayerSkill = skill.SkillName,
                    SkillCap = skill.Cap,
                    TargetName = target,
                    TimeLimit = DateTime.Now + TaskTime,
                    TaskAmount = amount
                });

                KillMessage(pm, taskInfos.Last());

                Effects.SendBoltEffect(pm, true);
            }
            else
            {
                SayTo(pm, string.Format("You need to get {0} to {1}!", skill.Name, skill.Cap));

                SayTo(pm, "Come back when done!");
            }
        }

        private static void KillMessage(Mobile m, SkillTaskInfo info)
        {
            if (info.TaskAmount > 1)
            {
                m.SendMessage(53, string.Format("You have {0} minutes, to kill {1}!", info.TimeLimit, info.TargetName));
            }
            else
            {
                m.SendMessage(string.Format("Kill {0} to receive a {1} {2} powerscroll within {3} minutes!", info.TargetName, info.SkillCap + 5, info.PlayerSkill, info.TimeLimit));
            }
        }

        public LegendaryMaster(Serial serial) : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            if (taskInfos == null)
            {
                taskInfos = new List<SkillTaskInfo>();
            }
        }

        private class SkillTaskInfo
        {
            public Serial PlayerSerial;

            public SkillName PlayerSkill;

            public double SkillCap;

            public Type TargetName;

            public DateTime TimeLimit;

            public bool Completed = false;

            public int TaskAmount;
        }
    }
}
