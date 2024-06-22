using System;
using Server;
using Server.Items;
using Server.Network;
using Server.Mobiles;

namespace Server.Items
{
    public class HotLavaTile : Item
    {
        private Timer m_Timer;
        private Timer m_DeleteTimer;
        public int Damage { get; set; }
        public TimeSpan AutoDelete { get; set; } // Duration before auto-deletion

        [Constructable]
        public HotLavaTile() : base(0x122A) // Use the appropriate item ID for a lava tile
        {
            Movable = false;
            Name = "a hot lava tile";
			Hue = 0x48; // Lava color

            Damage = 10; // Default damage

            m_Timer = Timer.DelayCall(TimeSpan.Zero, TimeSpan.FromSeconds(2), CheckForPlayers);

            AutoDelete = TimeSpan.FromSeconds(15); // Set the auto-delete time (5 minutes)
            StartDeleteTimer();
        }

        private void CheckForPlayers()
        {
            if (Deleted) return;

            IPooledEnumerable eable = GetMobilesInRange(0);
            foreach (Mobile m in eable)
            {
                
                m.Damage(Damage, m);
                
            }
            eable.Free();
        }

        private void StartDeleteTimer()
        {
            if (m_DeleteTimer != null)
                m_DeleteTimer.Stop();

            m_DeleteTimer = Timer.DelayCall(AutoDelete, DeleteTimer);
        }

        private void DeleteTimer()
        {
            this.Delete(); // Automatically delete the tile
        }

        public HotLavaTile(Serial serial) : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int) 0); // version
            writer.Write(Damage);
            writer.Write(AutoDelete);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
            Damage = reader.ReadInt();
            AutoDelete = reader.ReadTimeSpan();
            m_Timer = Timer.DelayCall(TimeSpan.Zero, TimeSpan.FromSeconds(2), CheckForPlayers);
            StartDeleteTimer(); // Restart the delete timer on server restart
        }
    }
}
