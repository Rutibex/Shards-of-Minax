using System;
using Server;
using Server.Items;
using Server.Mobiles;
using Server.Network;
using Server.Targeting;

namespace Server.Items
{
    public class HealersKit : Item
    {
        [Constructable]
        public HealersKit() : base(0x1EB8)
        {
            Name = "Healer's Kit";
            Hue = 0x47E;
        }

        public HealersKit(Serial serial) : base(serial)
        {
        }

        public override void OnDoubleClick(Mobile from)
        {
            if (!IsChildOf(from.Backpack))
            {
                from.SendLocalizedMessage(1042001); // This must be in your backpack to use it.
                return;
            }

            if (from.Skills[SkillName.Veterinary].Value < 80.0)
            {
                from.SendLocalizedMessage(1042002); // You do not have enough skill to use this.
                return;
            }

            from.SendMessage("Select a pet to heal.");
            from.Target = new PetTarget(this);
        }

        private class PetTarget : Target
        {
            private HealersKit m_Kit;

            public PetTarget(HealersKit kit) : base(12, false, TargetFlags.Beneficial)
            {
                m_Kit = kit;
            }

            protected override void OnTarget(Mobile from, object targeted)
            {
                if (targeted is BaseCreature)
                {
                    BaseCreature pet = (BaseCreature)targeted;

                    if (pet.Controlled && pet.ControlMaster == from)
                    {
                        pet.Hits += Utility.RandomMinMax(50, 70);
                        pet.FixedParticles(0x376A, 9, 32, 5007, EffectLayer.Waist);
                        pet.PlaySound(0x1F2);
                        from.SendMessage("You have healed your pet.");
                    }
                    else
                    {
                        from.SendMessage("This is not your pet.");
                    }
                }
                else
                {
                    from.SendMessage("That is not a pet.");
                }
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }

    public class AnimalCompanion : Item
    {
        [Constructable]
        public AnimalCompanion() : base(0x211F)
        {
            Name = "Animal Companion";
            Hue = 0x47E;
        }

        public AnimalCompanion(Serial serial) : base(serial)
        {
        }

        public override void OnDoubleClick(Mobile from)
        {
            if (!IsChildOf(from.Backpack))
            {
                from.SendLocalizedMessage(1042001); // This must be in your backpack to use it.
                return;
            }

            from.SendMessage("An animal companion has been summoned.");
            BaseCreature pet = new Dog();
            pet.ControlMaster = from;
            pet.Controlled = true;
            pet.IsBonded = true;
            pet.MoveToWorld(from.Location, from.Map);
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }

    public class PetRevivePotion : Item
    {
        [Constructable]
        public PetRevivePotion() : base(0xF0B)
        {
            Name = "Pet Revive Potion";
            Hue = 0x47E;
        }

        public PetRevivePotion(Serial serial) : base(serial)
        {
        }

        public override void OnDoubleClick(Mobile from)
        {
            if (!IsChildOf(from.Backpack))
            {
                from.SendLocalizedMessage(1042001); // This must be in your backpack to use it.
                return;
            }

            if (from.Skills[SkillName.Veterinary].Value < 90.0)
            {
                from.SendLocalizedMessage(1042002); // You do not have enough skill to use this.
                return;
            }

            from.SendMessage("Select a pet to revive.");
            from.Target = new ReviveTarget(this);
        }

        private class ReviveTarget : Target
        {
            private PetRevivePotion m_Potion;

            public ReviveTarget(PetRevivePotion potion) : base(12, false, TargetFlags.Beneficial)
            {
                m_Potion = potion;
            }

            protected override void OnTarget(Mobile from, object targeted)
            {
                if (targeted is BaseCreature)
                {
                    BaseCreature pet = (BaseCreature)targeted;

                    if (pet.Controlled && pet.ControlMaster == from && pet.IsDeadPet)
                    {
                        pet.ResurrectPet();
                        pet.Hits = pet.HitsMax / 2;
                        pet.FixedParticles(0x376A, 9, 32, 5007, EffectLayer.Waist);
                        pet.PlaySound(0x214);
                        from.SendMessage("You have revived your pet.");
                        m_Potion.Delete();
                    }
                    else
                    {
                        from.SendMessage("This is not your dead pet.");
                    }
                }
                else
                {
                    from.SendMessage("That is not a pet.");
                }
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }

    public class PetCollar : Item
    {
        [Constructable]
        public PetCollar() : base(0x1086)
        {
            Name = "Pet Collar";
            Hue = 0x47E;
        }

        public PetCollar(Serial serial) : base(serial)
        {
        }

        public override void OnDoubleClick(Mobile from)
        {
            if (!IsChildOf(from.Backpack))
            {
                from.SendLocalizedMessage(1042001); // This must be in your backpack to use it.
                return;
            }

            if (from.Skills[SkillName.AnimalTaming].Value < 70.0)
            {
                from.SendLocalizedMessage(1042002); // You do not have enough skill to use this.
                return;
            }

            from.SendMessage("Select a pet to equip with the collar.");
            from.Target = new CollarTarget(this);
        }

        private class CollarTarget : Target
        {
            private PetCollar m_Collar;

            public CollarTarget(PetCollar collar) : base(12, false, TargetFlags.Beneficial)
            {
                m_Collar = collar;
            }

            protected override void OnTarget(Mobile from, object targeted)
            {
                if (targeted is BaseCreature)
                {
                    BaseCreature pet = (BaseCreature)targeted;

                    if (pet.Controlled && pet.ControlMaster == from)
                    {
                        pet.VirtualArmor += 10; // Boost pet's armor
                        pet.FixedParticles(0x375A, 10, 15, 5013, EffectLayer.Head);
                        pet.PlaySound(0x1F4);
                        from.SendMessage("You have equipped your pet with the collar.");
                        m_Collar.Delete();
                    }
                    else
                    {
                        from.SendMessage("This is not your pet.");
                    }
                }
                else
                {
                    from.SendMessage("That is not a pet.");
                }
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}
