#region Mystic Online           Jamze C. McConnell            http://www.MysticOnline.org
/*
o   o           o              o-o       o            
|\ /|           |  o          o   o      | o          
| O | o  o o-o -o-    o-o     |   | o-o  |   o-o  o-o 
|   | |  |  \   |  | |        o   o |  | | | |  | |-' 
o   o o--O o-o  o  |  o-o      o-o  o  o o | o  o o-o 
         |     Mystic Online 2009, Jamze C. McConnell                                      
      o--o           
*/
#endregion Mystic Online    

using System;
using Server.Mobiles;
using Server.Items;
using Server.Spells;
using Server.Engines.VeteranRewards;

namespace Server.Items
{
    public class RideableBoura : EtherealMount
    {
        public override int LabelNumber { get { return 1150006; } }

        [Constructable]
        public RideableBoura()
            : base(0x46F9, 0x3EC6, 0) // Adjusted constructor to include hue parameter
        {
        }

        public RideableBoura(Serial serial)
            : base(serial)
        {
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
