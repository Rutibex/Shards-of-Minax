using System;
using Server;
using Server.Network;
using Server.Items;
using Server.Mobiles;

namespace Server.Items
{
    public class TeleportToIlshenarItem : Item
    {
        [Constructable]
        public TeleportToIlshenarItem() : base(0x1F14)
        {
            Name = "Teleport to Ilshenar";
            Hue = 0x482;
            Movable = true;
        }

        public TeleportToIlshenarItem(Serial serial) : base(serial)
        {
        }

        public override void OnDoubleClick(Mobile from)
        {
            if (!IsChildOf(from.Backpack)) // Make sure the item is in the player's backpack
            {
                from.SendLocalizedMessage(1042001); // "That must be in your pack for you to use it."
                return;
            }

            // Teleport the player
            from.Map = Map.Ilshenar;
            from.Location = new Point3D(637, 929, -64);
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0); // Version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}
