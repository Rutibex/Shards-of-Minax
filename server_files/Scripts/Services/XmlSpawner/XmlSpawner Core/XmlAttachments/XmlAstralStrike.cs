using System;
using Server;
using Server.Items;
using Server.Mobiles;
using Server.Spells;

namespace Server.Engines.XmlSpawner2
{
    public class XmlAstralStrike : XmlAttachment
    {
        private int m_Damage = 0;
        private TimeSpan m_Refractory = TimeSpan.FromSeconds(5);
        private DateTime m_EndTime;
        private TimeSpan m_Duration = TimeSpan.FromSeconds(10); // Duration of the astral effect

        [CommandProperty(AccessLevel.GameMaster)]
        public int Damage { get { return m_Damage; } set { m_Damage = value; } }

        [CommandProperty(AccessLevel.GameMaster)]
        public TimeSpan Refractory { get { return m_Refractory; } set { m_Refractory = value; } }

        [CommandProperty(AccessLevel.GameMaster)]
        public TimeSpan Duration { get { return m_Duration; } set { m_Duration = value; } }

        public XmlAstralStrike(ASerial serial) : base(serial) { }

        [Attachable]
        public XmlAstralStrike(int damage, double duration)
        {
            m_Damage = damage;
            Duration = TimeSpan.FromSeconds(duration);
        }

        public override void OnWeaponHit(Mobile attacker, Mobile defender, BaseWeapon weapon, int damageGiven)
        {
            if (DateTime.Now < m_EndTime) return;

            if (defender != null && attacker != null)
            {
                defender.SendMessage("You are struck by astral energy!");
                defender.BeginAction(typeof(XmlAstralStrike));

                Timer.DelayCall(TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1), (int)Duration.TotalSeconds,
                    new TimerStateCallback(AstralEffect), new object[] { defender, 0 });

                m_EndTime = DateTime.Now + Refractory;
            }
        }

        private void AstralEffect(object state)
        {
            object[] states = (object[])state;
            Mobile defender = (Mobile)states[0];
            int count = (int)states[1];

            if (defender != null && !defender.Deleted && defender.Alive && count < Duration.TotalSeconds)
            {
                defender.Damage(m_Damage, defender); // Applying astral damage every second
                defender.FixedParticles(0x3A9C, 10, 30, 5052, EffectLayer.LeftFoot); // Astral effect
                states[1] = count + 1;
            }
            else if (defender != null)
            {
                defender.EndAction(typeof(XmlAstralStrike));
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0); // version
            writer.Write(m_Damage);
            writer.Write(m_Refractory);
            writer.Write(m_EndTime - DateTime.Now);
            writer.Write(m_Duration);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

            if (version >= 0)
            {
                m_Damage = reader.ReadInt();
                Refractory = reader.ReadTimeSpan();
                TimeSpan remaining = reader.ReadTimeSpan();
                m_EndTime = DateTime.Now + remaining;
                m_Duration = reader.ReadTimeSpan();
            }
        }

        public override string OnIdentify(Mobile from)
        {
            return "Astral Strike Damage " + m_Damage + " for " + Duration.TotalSeconds + " secs every second. " + Refractory.TotalSeconds + " secs between uses.";
        }
    }
}
