using System;
using Server;
using Server.Items;
using Server.Targeting;

namespace Server.Items
{
    public class VeterinaryAugmentCrystal : Item
    {
        [Constructable]
        public VeterinaryAugmentCrystal() : base(0x1F1C)  // Random item graphic, you can change this.
        {
            Name = "Veterinary Augment Crystal";
            Hue = 1176; // Random hue for differentiation, can be changed to your liking.
        }

        public VeterinaryAugmentCrystal(Serial serial) : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0); // Version.
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }

        public override void OnDoubleClick(Mobile from)
        {
            if (!IsChildOf(from.Backpack))
            {
                from.SendMessage("The crystal needs to be in your pack.");
                return;
            }

            from.SendMessage("Which armor or clothing item would you like to augment for veterinary?");
            from.Target = new VeterinaryAugmentTarget(this);
        }

        private class VeterinaryAugmentTarget : Target
        {
            private VeterinaryAugmentCrystal m_Crystal;

            public VeterinaryAugmentTarget(VeterinaryAugmentCrystal crystal) : base(1, false, TargetFlags.None)
            {
                m_Crystal = crystal;
            }

            protected override void OnTarget(Mobile from, object targeted)
            {
                if (m_Crystal.Deleted || m_Crystal.RootParent != from)
                    return;

                int bonus = Utility.Random(1, 25);  // Generates a random number between 1 and 25.

                if (targeted is BaseArmor)
                {
                    BaseArmor armor = targeted as BaseArmor;
                    armor.SkillBonuses.SetValues(0, SkillName.Veterinary, bonus); // Setting the random bonus.
                    from.SendMessage(String.Format("The armor has been augmented with a +{0} veterinary bonus.", bonus));
                    m_Crystal.Delete();
                }
                else if (targeted is BaseClothing)
                {
                    BaseClothing clothing = targeted as BaseClothing;
                    clothing.SkillBonuses.SetValues(0, SkillName.Veterinary, bonus); // Setting the random bonus.
                    from.SendMessage(String.Format("The clothing has been augmented with a +{0} veterinary bonus.", bonus));
                    m_Crystal.Delete();
                }
                else
                {
                    from.SendMessage("You can't augment that for veterinary.");
                }
            }
        }
    }
}
