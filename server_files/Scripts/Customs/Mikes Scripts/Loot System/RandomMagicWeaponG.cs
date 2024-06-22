using System;
using Server;
using Server.Items;
using Server.Engines.XmlSpawner2;

public class RandomMagicWeaponG : BaseWeapon
{
    // List of possible prefixes and suffixes for the weapon name
    private static string[] prefixes = { "Mighty", "Powerful", "Mystic", "Enchanted", "Arcane", "Enchanted", "Mystical", "Elemental", "Eternal", "Infernal", "Celestial", "Eldritch", "Spectral", "Tempest", "Frozen", "Blazing", "Thunder", "Shadow", "Radiant", "Dark", "Light", "Phantom", "Void", "Ethereal", "Necrotic", "Divine", "Astral", "Prismatic", "Runic", "Venomous", "Frost", "Storm", "Invisible", "Invincible", "Majestic", "Cursed", "Blessed", "Soulbound", "Vortex", "Twilight", "Dawn", "Dusk", "Starforged", "Moonlit", "Sunflare", "Comet", "Eclipse", "Galactic", "Cosmic", "Dimensional", "Temporal", "Spatial", "Quantum", "Mythic", "Legendary", "Ancient", "Primordial", "Forgotten", "Unseen", "Chaos", "Harmony", "Balance", "Rage", "Serenity", "Oblivion", "Creation", "Destruction", "Rebirth", "Fate", "Dream", "Nightmare", "Illusion", "Reality", "Vision", "Ghostly", "Glorious", "Sacred", "Unholy", "Vigilant", "Warrior's", "Sorcerer's", "Seer's", "Dragon's", "Titan's", "Phoenix", "Demonic", "Angelic", "Heavenly", "Abyssal", "Solar", "Lunar", "Stellar", "Voidwalker's", "Battleworn", "Savage", "Berserker's", "Monarch's", "Guardian's", "Pirate's", "Royal", "Revenant", "Warden's", "Spectral", "Stormbringer's", "Windwalker's", "Flamebearer's", "Icewrought", "Thunderous", "Stoneskin", "Nature's", "Beastmaster's", "Shamanic", "Witch's", "Siren's", "Mercurial", "Adamant", "Sylvan", "Arcanist's", "Noble", "Explorer's", "Sentry's", "Ranger's", "Corsair's", "Assassin's", "Necromancer's", "Paladin's", "Rogue's", "Cleric's", "Elementalist's", "Chronomancer's", "Geomancer's", "Pyromancer's", "Hydromancer's", "Aeromancer's", "Biomancer's", "Cybernetic", "Technomancer's", "Alchemist's", "Summoner's", "Psionic", "Sage's", "Prophet's", "Martyr's", "Zealot's", "Reclaimer's", "Pioneer's", "Innovator's", "Vindicator's", "Arbiter's", "Sentinel's", "Defender's", "Avenger's", "Champion's", "Conqueror's", "Master's", "Primeval", "Arcadian", "Myrmidon's", "Valkyrie's", "Bard's", "Jester's", "Gladiator's", "Knight's", "Samurai's", "Ninja's", "Viking's", "Pilgrim's", "Hermit's", "Sculptor's", "Painter's", "Poet's", "Minstrel's", "Troubadour's", "Wanderer's", "Explorer's", "Adventurer's", "Seeker's", "Scholar's", "Philosopher's", "Oracle's", "Muse's", "Mystic's", "Seer's", "Soothsayer's", "Prognosticator's", "Diviner's", "Augur's", "Sibyl's", "Clairvoyant's", "Telepath's", "Empath's", "Psychic's", "Medium's", "Spiritualist's", "Channeler's", "Shapeshifter's", "Transformer's", "Metamorph's", "Changeling's", "Morpher's", "Transmuter's", "Alchemist's", "Chemist's", "Potioneer's", "Apothecary's", "Herbalist's", "Botanist's", "Horticulturist's", "Agronomist's", "Cultivator's", "Farmer's", "Gardener's", "Landscaper's", "Arborist's", "Forester's", "Logger's", "Woodcutter's", "Carpenter's", "Joiner's", "Cabinetmaker's", "Woodworker's", "Craftsman's", "Artisan's", "Maker's", "Creator's", "Inventor's", "Designer's", "Architect's", "Engineer's", "Builder's", "Constructor's", "Fabricator's", "Manufacturer's", "Producer's", "Director's", "Manager's", "Supervisor's", "Coordinator's", "Organizer's", "Planner's", "Strategist's", "Analyst's", "Consultant's", "Advisor's", "Counselor's", "Mentor's", "Tutor's", "Teacher's", "Instructor's", "Educator's", "Professor's", "Lecturer's", "Trainer's", "Coach's", "Drillmaster's", "Taskmaster's", "Mastermind's", "Genius's", "Savant's", "Expert's", "Specialist's", "Professional's", "Technician's", "Mechanic's", "Operator's", "Worker's", "Laborer's", "Handyman's", "Repairman's", "Serviceman's", "Maintenance's", "Custodian's", "Janitor's", "Cleaner's", "Sanitation's", "Hygienist's", "Health's", "Medical's", "Nurse's", "Doctor's", "Physician's", "Surgeon's", "Dentist's", "Pharmacist's", "Therapist's", "Psychologist's", "Psychiatrist's", "Counselor's", "Social Worker's", "Case Manager's", "Advocate's", "Mediator's", "Negotiator's", "Arbitrator's", "Judge's", "Magistrate's", "Jurist's", "Lawyer's", "Attorney's", "Counsel's", "Solicitor's", "Barrister's", "Advocate's", "Prosecutor's", "Defender's", "Litigator's", "Trial Lawyer's", "Appellate Lawyer's", "Legal Advisor's", "Legal Consultant's", "Legal Analyst's", "Paralegal's", "Legal Assistant's", "Clerk's", "Secretary's", "Assistant's", "Aide's", "Helper's", "Support's", "Backer's", "Sponsor's", "Patron's", "Benefactor's", "Donor's", "Contributor's", "Investor's", "Shareholder's", "Stakeholder's", "Partner's", "Co-owner's", "Joint Venture's", "Syndicate's", "Consortium's", "Alliance's", "Coalition's", "Federation's", "Union's", "Association's", "Society's", "Club's", "Group's", "Team's", "Crew's", "Gang's", "Band's", "Troupe's", "Company's", "Corporation's", "Enterprise's", "Firm's", "Business's", "Agency's", "Bureau's", "Office's", "Department's", "Division's", "Section's", "Unit's", "Branch's", "Subsidiary's", "Affiliate's", "Franchise's", "Chain's", "Outlet's", "Store's", "Shop's", "Boutique's", "Emporium's", "Marketplace's", "Mart's", "Mall's", "Plaza's", "Center's", "Complex's", "Hub's", "Terminal's", "Station's", "Port's", "Harbor's", "Marina's", "Dock's", "Wharf's", "Quay's", "Pier's", "Jetty's", "Breakwater's", "Seawall's", "Bulwark's", "Rampart's", "Bastion's", "Fortress's", "Castle's", "Palace's", "Manor's", "Mansion's", "Estate's", "Villa's", "Chateau's", "Lodge's", "Cabin's", "Cottage's", "Bungalow's", "Hut's", "Shack's", "Shed's", "Barn's", "Stable's", "Kennel's", "Cattery's", "Aviary's", "Aquarium's", "Zoo's", "Safari Park's", "Wildlife Reserve's", "Nature Preserve's", "National Park's", "State Park's", "Provincial Park's", "Regional Park's", "City Park's", "Public Garden's", "Botanical Garden's", "Arboretum's", "Greenhouse's", "Nursery's", "Farm's", "Ranch's", "Plantation's", "Orchard's", "Vineyard's", "Winery's", "Brewery's", "Distillery's", "Factory's", "Mill's", "Plant's", "Workshop's", "Studio's", "Gallery's", "Museum's", "Library's", "Archive's", "Repository's", "Depot's", "Warehouse's", "Storage's", "Silo's", "Tank's", "Reservoir's", "Container's", "Vessel's", "Ship's", "Boat's", "Vessel's", "Craft's", "Yacht's", "Sailboat's", "Motorboat's", "Speedboat's", "Ferry's", "Cruise Ship's", "Liner's", "Tanker's", "Freighter's", "Cargo Ship's", "Container Ship's", "Battleship's", "Destroyer's", "Frigate's", "Submarine's", "Aircraft Carrier's", "Warship's", "Naval Ship's", "Military Vessel's", "Patrol Boat's", "Coast Guard Cutter's", "Icebreaker's", "Research Vessel's", "Exploration Ship's", "Adventure's", "Expedition's", "Voyage's", "Journey's", "Trip's", "Tour's", "Excursion's", "Outing's", "Safari's", "Trek's", "Hike's", "Walk's", "Stroll's", "Ramble's", "Wander's", "Roam's", "Travel's", "Venture's", "Quest's", "Mission's", "Campaign's", "Crusade's", "Drive's", "Push's", "Effort's", "Attempt's", "Trial's", "Test's", "Experiment's", "Study's", "Investigation's", "Inquiry's", "Research's", "Exploration's", "Discovery's", "Find's", "Revelation's", "Uncovering's", "Exposure's", "Reveal's", "Show's", "Presentation's", "Display's", "Exhibition's", "Demonstration's", "Performance's", "Act's", "Scene's", "Episode's", "Chapter's", "Volume's", "Book's", "Publication's", "Release's", "Launch's", "Debut's", "Premiere's", "Opening's", "Introduction's", "Inauguration's", "Commencement's", "Start's", "Beginning's", "Origin's", "Genesis's", "Creation's", "Formation's", "Development's", "Evolution's", "Progress's", "Advancement's", "Improvement's", "Enhancement's", "Upgrade's", "Update's", "Revision's", "Modification's", "Change's", "Alteration's", "Transformation's", "Conversion's", "Switch's", "Substitution's", "Replacement's", "Exchange's", "Trade's", "Swap's", "Shift's", "Transfer's", "Movement's", "Motion's", "Action's", "Activity's", "Operation's", "Function's", "Process's", "Procedure's", "Method's", "Technique's", "Strategy's", "Tactic's", "Plan's", "Scheme's", "Design's", "Blueprint's", "Outline's", "Sketch's", "Draft's", "Diagram's", "Chart's", "Map's", "Plan's", "Layout's", "Arrangement's", "Organization's", "Structure's", "Framework's", "System's", "Network's", "Grid's", "Matrix's", "Web's", "Complex's", "Compound's", "Aggregate's", "Mixture's", "Blend's", "Combination's", "Amalgamation's", "Integration's", "Union's", "Fusion's", "Merger's", "Consolidation's", "Unification's", "Synthesis's", "Harmonization's", "Coordination's", "Alignment's", "Congruence's", "Correspondence's", "Match's", "Pairing's", "Coupling's", "Linkage's", "Connection's", "Bond's", "Tie's", "Relationship's", "Association's", "Affiliation's", "Partnership's", "Collaboration's", "Cooperation's", "Teamwork's", "Synergy's", "Interplay's", "Interaction's", "Interrelation's", "Interdependence's", "Mutuality's", "Reciprocity's", "Exchange's", "Dialogue's", "Conversation's", "Discussion's", "Debate's", "Argument's", "Dispute's", "Controversy's", "Conflict's", "Struggle's", "Fight's", "Battle's", "War's", "Combat's", "Engagement's", "Encounter's", "Skirmish's", "Clash's", "Confrontation's", "Showdown's", "Face-off's", "Duel's", "Matchup's", "Competition's", "Contest's", "Tournament's", "Championship's", "Race's", "Game's", "Sport's", "Event's", "Occasion's", "Celebration's", "Festival's", "Fair's", "Carnival's", "Party's", "Gathering's", "Meeting's", "Assembly's", "Convention's", "Conference's", "Symposium's", "Seminar's", "Workshop's", "Course's", "Class's" };
    private static string[] suffixes = { "Promise", "Destiny", "Legacy", "Fury", "Whisper", "Echo", "Bane", "Dream", "Nightmare", "Vision", "Wraith", "Phantom", "Mirage", "Eclipse", "Aurora", "Vortex", "Tempest", "Inferno", "Blizzard", "Torrent", "Quake", "Rift", "Void", "Nebula", "Galaxy", "Meteor", "Comet", "Astral", "Cosmos", "Reverie", "Serenity", "Chaos", "Harmony", "Zenith", "Nadir", "Apex", "Nexus", "Genesis", "Terminus", "Vertex", "Maelstrom", "Cyclone", "Tsunami", "Inferno", "Cataclysm", "Paradox", "Anomaly", "Enigma", "Phenomenon", "Mystique", "Oblivion", "Eternity", "Infinity", "Epoch", "Era", "Saga", "Myth", "Legend", "Fable", "Tale", "Odyssey", "Quest", "Journey", "Voyage", "Expedition", "Crusade", "War", "Rebellion", "Revolution", "Uprising", "Empire", "Dynasty", "Realm", "Dominion", "Kingdom", "Ascendancy", "Conquest", "Triumph", "Dominance", "Supremacy", "Guardian", "Protector", "Sentinel", "Avenger", "Crusader", "Martyr", "Champion", "Behemoth", "Leviathan", "Titan", "Colossus", "Goliath", "Sphinx", "Phoenix", "Dragon", "Serpent", "Wyrm", "Gryphon", "Pegasus", "Unicorn", "Cerberus", "Kraken", "Hydra", "Chimera", "Basilisk", "Valkyrie", "Sorcerer", "Necromancer", "Paladin", "Ranger", "Assassin", "Berserker", "Monk", "Priest", "Shaman", "Wizard", "Warlock", "Mage", "Druid", "Knight", "Squire", "Arcanist", "Enchanter", "Sage", "Prophet", "Seer", "Oracle", "Diviner", "Mystic", "Hermit", "Recluse", "Nomad", "Pilgrim", "Wanderer", "Explorer", "Adventurer", "Pioneer", "Vanguard", "Pathfinder", "Trailblazer", "Scout", "Reaver", "Slayer", "Warrior", "Hunter", "Silhouette", "Reflection", "Glimmer", "Shimmer", "Spark", "Flame", "Ember", "Flash", "Shadow", "Light", "Dawn", "Dusk", "Noon", "Midnight", "Twilight", "Eclipse", "Solstice", "Equinox", "Horizon", "Zenith" };

    // Random number generator
    private static Random rand = new Random();

    // Array of weapon types
    private static Type[] weaponTypes = new Type[]
	{
        typeof(Broadsword), typeof(Cutlass), typeof(Katana), typeof(Longsword), typeof(Scimitar), typeof(VikingSword),
        typeof(Axe), typeof(BattleAxe), typeof(DoubleAxe), typeof(ExecutionersAxe), typeof(LargeBattleAxe), typeof(TwoHandedAxe),
        typeof(WarAxe), typeof(Club), typeof(HammerPick), typeof(Mace), typeof(Maul), typeof(WarHammer), typeof(WarMace),
        typeof(Bardiche), typeof(Halberd), typeof(Lance), typeof(Pike), typeof(ShortSpear), typeof(Spear), typeof(WarFork),
        typeof(CompositeBow), typeof(Crossbow), typeof(HeavyCrossbow), typeof(RepeatingCrossbow), typeof(Bow),
        typeof(Dagger), typeof(Kryss), typeof(SkinningKnife), typeof(ShortSpear), typeof(Spear), typeof(Pitchfork),
        typeof(BlackStaff), typeof(GnarledStaff), typeof(QuarterStaff), typeof(ShepherdsCrook),
        // Special weapons (if applicable to your server)
        typeof(BladedStaff), typeof(Scythe), typeof(Scepter),
        typeof(MagicWand) // If you want to include magical staves or wands
	};

    [Constructable]
    public RandomMagicWeaponG() : base(GetRandomItemID())
    {
        Type selectedType = weaponTypes[rand.Next(weaponTypes.Length)];
        BaseWeapon tempWeapon = (BaseWeapon)Activator.CreateInstance(selectedType);

        // Generate a random name for the weapon
        string name = prefixes[rand.Next(prefixes.Length)] + " " + suffixes[rand.Next(suffixes.Length)];
        this.Name = name;

        // Initialize weapon attributes
        InitializeWeaponAttributes(tempWeapon);

        this.Hue = rand.Next(1, 3001); // Generates a random number between 1 and 3000

		// Add the socket attachment code here
		Random rnd = new Random();
		int numberOfSockets = rnd.Next(0, 7); // Random.Next is inclusive on the lower bound and exclusive on the upper bound

		// Attach the XmlSockets attribute with the randomly determined number of sockets
		XmlAttach.AttachTo(this, new XmlSockets(numberOfSockets));

        // Clean up the temporary weapon instance
        tempWeapon.Delete();
    }

    private void InitializeWeaponAttributes(BaseWeapon tempWeapon)
    {
        // Set common attributes
        this.Attributes.AttackChance = rand.Next(10, 50);
        this.Attributes.DefendChance = rand.Next(10, 50);
        this.Speed = (float)Math.Round(rand.NextDouble() * 9.9 + 0.1, 1);
        this.Attributes.SpellChanneling = 1;

        // Tiered system for weapon damage
        double tierChance = rand.NextDouble(); // Generate a random double between 0.0 and 1.0
        if (tierChance < 0.05) // Very rare
        {
            this.MinDamage = rand.Next(1, 80); // Higher minimum damage for very rare weapons
            this.MaxDamage = rand.Next(80, 350); // Maximum damage reaches up to 500
            this.WeaponAttributes.HitLeechHits = rand.Next(20, 41);
            this.WeaponAttributes.HitLeechStam = rand.Next(20, 41);
            this.WeaponAttributes.HitLeechMana = rand.Next(20, 41);
        }
        else if (tierChance < 0.2) // Rare
        {
            this.MinDamage = rand.Next(1, 70);
            this.MaxDamage = rand.Next(70, 200);
            this.WeaponAttributes.HitFireball = rand.Next(20, 41); // Chance of Fireball
            this.WeaponAttributes.HitMagicArrow = rand.Next(10, 21); // Chance to cast Magic Arrow
            this.WeaponAttributes.HitLeechHits = rand.Next(10, 21);
        }
        else if (tierChance < 0.5) // Uncommon
        {
            this.MinDamage = rand.Next(1, 50);
            this.MaxDamage = rand.Next(50, 150);
            this.WeaponAttributes.HitLeechStam = rand.Next(10, 26);
            this.WeaponAttributes.HitLeechMana = rand.Next(10, 26);
        }
        else // Common
        {
            this.MinDamage = rand.Next(1, 30);
            this.MaxDamage = rand.Next(30, 100);
        }

        // Optionally adjust speed based on tier to balance gameplay, if desired
        // E.g., very rare weapons could be slightly slower to offset their high damage
    }

    // Adjustments to other parts of the class aren't necessary for the tiered system,
    // but ensure your class structure and other methods properly support these changes.

    private static int GetRandomItemID()
    {
        // Instantiate a temporary object to get its ItemID
        Type selectedType = weaponTypes[rand.Next(weaponTypes.Length)];
        BaseWeapon tempWeapon = (BaseWeapon)Activator.CreateInstance(selectedType);
        int itemID = tempWeapon.ItemID;

        // No need to delete here, as it will be deleted after attributes initialization
        return itemID;
    }

    public RandomMagicWeaponG(Serial serial) : base(serial) { }

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
