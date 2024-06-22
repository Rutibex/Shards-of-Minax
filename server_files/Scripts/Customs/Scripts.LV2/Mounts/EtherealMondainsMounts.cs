using System;
using Server.Mobiles;

namespace Server.Items
{
    public class EtherealChargeroftheFallen : EtherealMount
    {
        [Constructable]
        public EtherealChargeroftheFallen() : base(0x3E92, 0x11676, 0)
        {
            Name = "Ethereal Charger of the Fallen Statuette";
            LootType = LootType.Blessed;
        }

        public EtherealChargeroftheFallen(Serial serial) : base(serial)
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
            if (Name != "Ethereal Charger of the Fallen Statuette")
                Name = "Ethereal Charger of the Fallen Statuette";
        }
    }

    public class EtherealChimera : EtherealMount
    {
        [Constructable]
        public EtherealChimera() : base(0x3E90, 0x11669, 0)
        {
            Name = "Ethereal Chimera Statuette";
            LootType = LootType.Blessed;
        }

        public EtherealChimera(Serial serial) : base(serial)
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
            if (Name != "Ethereal Chimera Statuette")
                Name = "Ethereal Chimera Statuette";
        }
    }
}
