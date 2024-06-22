using System;
using Server;
using Server.Mobiles;
using Server.Engines.XmlSpawner2;

namespace Server.Items
{
    // ---------------------------------------------------
    // Dog Summoning Materia
    // This materia, when socketed, gives a 99% chance to summon a Dog on hit
    // ---------------------------------------------------

    public class DogSummoningMateria : BaseSocketAugmentation
    {

        [Constructable]
        public DogSummoningMateria() : base(0x280A) // Change the item ID to match your materia graphic
        {
            Name = "Summoning Dog Materia";
            Hue = Utility.RandomMinMax(1, 3000); // Assign a random hue between 1 and 3000
        }
        
        public override int SocketsRequired { get { return 1; } } // Number of sockets required for this materia
        
        public override int Icon { get { return 0x280A; } } // Icon to use in the socketing menu

        public override int IconXOffset { get { return 8; } } // Icon offset for the X axis in the socketing menu

        public override int IconYOffset { get { return 20; } } // Icon offset for the Y axis in the socketing menu

        public DogSummoningMateria( Serial serial ) : base( serial )
        {
        }

        public override string OnIdentify(Mobile from)
        {
            // This description will appear when the materia is identified
            return "Grants a 99% chance on hit to summon a Dog.";
        }

        public override bool OnAugment(Mobile from, object target)
        {
            if (target is BaseWeapon)
            {
                // Attach the summoning effect to the weapon
                XmlAttach.AttachTo(target, new XmlSummonStrike("Dog", 99, 5.0));
                return true;
            }
            return false;
        }

        public override bool CanAugment(Mobile from, object target)
        {
            // Can only augment weapons
            return target is BaseWeapon;
        }
        
        public override bool CanRecover(Mobile from, object target, int version)
        {
            // Can recover from weapons
            return target is BaseWeapon;
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0); // version 0
        }
        
        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}