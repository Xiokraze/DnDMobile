using System.Collections.Generic;

namespace DnDMobile.Classes.ItemsFolder
{
    class Items
    {
        public List<Armor> StandardLightArmor { get; } = FetchStandardLightArmor();
        public List<Armor> StandardMediumArmor { get; } = FetchStandardMediumArmor();
        public List<Armor> StandardHeavyArmor { get; } = FetchStandardHeavyArmor();
        public List<Armor> StandardShields { get; } = FetchStandardShilelds();
        public List<Weapon> SimpleMeleeWeapons { get; } = FetchSimpleMeleeWeapons();
        public List<Weapon> SimpleRangedWeapons { get; } = FetchSimpleRangedWeapons();
        public List<Weapon> MartialMeleeWeapons { get; } = FetchMartialMeleeWeapons();
        public List<Weapon> MartialRangedWeapons { get; } = FetchMartialRangedWeapons();
        public List<GeneralItem> GeneralItems { get; } = FetchGeneralItems();
        public List<GeneralItem> GeneralItemsAmmunition { get; } = FetchGeneralItemsAmmunition();
        public List<GeneralItem> GeneralItemsArcaneFocus { get; } = FetchGeneralItemsArcaneFocus();
        public List<GeneralItem> GeneralItemsDruidicFocus { get; } = FetchGeneralItemsDruidicFocus();
        public List<GeneralItem> GeneralItemsHolySymbol { get; } = FetchGeneralItemsHolySymbol();
        public List<string> GeneralItemsTrinkets { get; } = FetchGeneralItemsTrinkets();
        public List<Art> Art25 { get; } = FetchArt25();
        public List<Art> Art250 { get; } = FetchArt250();
        public List<Art> Art750 { get; } = FetchArt750();
        public List<Art> Art2500 { get; } = FetchArt2500();
        public List<Art> Art7500 { get; } = FetchArt7500();
        public List<Gem> Gems10 { get; } = FetchGems10();
        public List<Gem> Gems50 { get; } = FetchGems50();
        public List<Gem> Gems100 { get; } = FetchGems100();
        public List<Gem> Gems500 { get; } = FetchGems500();
        public List<Gem> Gems1000 { get; } = FetchGems1000();
        public List<Gem> Gems5000 { get; } = FetchGems5000();

        public Items() { }


        public int GetNumberOfWeaponsCount() { return SimpleMeleeWeapons.Count + SimpleRangedWeapons.Count + MartialMeleeWeapons.Count + MartialRangedWeapons.Count; }
        public int GetNumberOfArmorCount() { return StandardLightArmor.Count + StandardMediumArmor.Count + StandardHeavyArmor.Count + StandardShields.Count; }
        public int GetGeneralItemsCount() { return GeneralItems.Count + GeneralItemsAmmunition.Count + GeneralItemsArcaneFocus.Count + GeneralItemsDruidicFocus.Count + GeneralItemsHolySymbol.Count; }
        public int GetEquipmentCount() { return GetNumberOfWeaponsCount() + GetNumberOfArmorCount() + GetGeneralItemsCount() + GetTrinketCount() + GetArtCount() + GetGemCount(); }
        public int GetTrinketCount() { return GeneralItemsTrinkets.Count; }
        public int GetArtCount() { return Art25.Count + Art250.Count + Art750.Count + Art2500.Count + Art7500.Count; }
        public int GetGemCount() { return Gems10.Count + Gems50.Count + Gems100.Count + Gems500.Count + Gems1000.Count + Gems5000.Count; }


        private static List<Armor> FetchStandardLightArmor()
        {
            List<Armor> lightArmor = new List<Armor>
            {
                new Armor("Padded", "5 gp", "11 + Dex Modifier", "-", "Disadvantage", "8 lbs", StaticVariables.lightAmor),
                new Armor("Leather", "10 gp", "11 + Dex Modifier", "-", "-", "10 lbs", StaticVariables.lightAmor),
                new Armor("Studded Leather", "45 gp", "12 + Dex Modifier", "-", "-", "13 lbs", StaticVariables.lightAmor)
            };
            return lightArmor;
        }


        private static List<Armor> FetchStandardMediumArmor()
        {
            List<Armor> mediumArmor = new List<Armor>
            {
                new Armor("Hide", "10 gp", "12 + Dex Modifier (Max 2)", "-", "-", "12 lbs", StaticVariables.mediumAmor),
                new Armor("Chain Shirt", "50 gp", "13 + Dex Modifier (Max 2)", "-", "-", "20 lbs", StaticVariables.mediumAmor),
                new Armor("Scale Mail", "50 gp", "14 + Dex Modifier (Max 2)", "-", "Disadvantage", "45 lbs", StaticVariables.mediumAmor),
                new Armor("Breastplate", "400 gp", "14 + Dex Modifier (Max 2)", "-", "-", "20 lbs", StaticVariables.mediumAmor),
                new Armor("Half Plate", "750 gp", "15 + Dex Modifier (Max 2)", "-", "Disadvantage", "40 lbs", StaticVariables.mediumAmor)
            };
            return mediumArmor;
        }


        private static List<Armor> FetchStandardHeavyArmor()
        {
            List<Armor> heavyArmor = new List<Armor>
            {
                new Armor("Ring Mail", "30 gp", "14", "-", "Disadvantage", "40 lbs", StaticVariables.heavyAmor),
                new Armor("Chain Mail", "75 gp", "16", "13", "Disadvantage", "55 lbs", StaticVariables.heavyAmor),
                new Armor("Splint", "200 gp", "17", "15", "Disadvantage", "60 lbs", StaticVariables.heavyAmor),
                new Armor("Plate", "1,500 gp", "18", "15", "Disadvantage", "65 lbs", StaticVariables.heavyAmor)
            };
            return heavyArmor;
        }


        private static List<Armor> FetchStandardShilelds()
        {
            List<Armor> shields = new List<Armor>
            {
                new Armor("Shield", "10 gp", "+2", "-", "-", "6 lbs", StaticVariables.shields)
            };
            return shields;
        }


        private static List<Weapon> FetchSimpleMeleeWeapons()
        {
            List<Weapon> simpleMeleeWeapons = new List<Weapon>
            {
                new Weapon("Club", "1 sp", "1d4 bludgeoning", "2 lbs", "Light", StaticVariables.simpleMelee),
                new Weapon("Dagger", "2 gp", "1d4 piercing",  "1 lbs", "Finesse, Light, Thrown (range 20/60)", StaticVariables.simpleMelee),
                new Weapon("Greatclub", "2 sp", "1d8 bludgeoning", "10 lbs", "Two-handed", StaticVariables.simpleMelee),
                new Weapon("Handaxe", "5 gp", "1d6 slashing", "2 lbs", "Light, Thrown (range 20/60)", StaticVariables.simpleMelee),
                new Weapon("Javelin", "5 sp", "1d6 piercing", "2 lbs", "Thrown (range 30/120)", StaticVariables.simpleMelee),
                new Weapon("Light Hammer", "2 gp", "1d4 bludgeoning", "2 lbs", "Light, Thrown (range 20/60)", StaticVariables.simpleMelee),
                new Weapon("Mace", "5 gp", "1d6 bludgeoning", "4 lbs",  "-", StaticVariables.simpleMelee),
                new Weapon("Quarterstaff", "2 sp", "1d6 bludgeoning", "4 lbs", "Versatile (1d8)", StaticVariables.simpleMelee),
                new Weapon("Sickle", "1 gp", "1d4 slashing", "2 lbs", "Light", StaticVariables.simpleMelee),
                new Weapon("Spear", "1 gp", "1d6 piercing", "3 lbs", "Thrown (range 20/60), Versatile (1d8)", StaticVariables.simpleMelee)
            };
            return simpleMeleeWeapons;
        }


        private static List<Weapon> FetchSimpleRangedWeapons()
        {
            List<Weapon> simpleRangedWeapons = new List<Weapon>
            {
                new Weapon("Crossbow, Light", "25 gp", "1d8 piercing", "5 lbs", "Ammunition (range 80/320), Loading, Two-handed", StaticVariables.simpleRanged),
                new Weapon("Dart", "5 cp", "1d4 piercing", "1/4 lbs", "Finesse, Thrown (range 20/60)", StaticVariables.simpleRanged),
                new Weapon("Shortbow", "25 gp", "1d6 piercing", "2 lbs", "Ammunition (range 80/320), Two-handed", StaticVariables.simpleRanged),
                new Weapon("Sling", "1 sp", "1d4 bludgeoning", "-", "Ammunition (range 30/120)", StaticVariables.simpleRanged)
            };
            return simpleRangedWeapons;
        }


        private static List<Weapon> FetchMartialMeleeWeapons()
        {
            List<Weapon> martialMeleeWeapons = new List<Weapon>
            {
                new Weapon("Battleaxe", "10 gp", "1d8 slashing", "4 lbs", "Versatile (1d10)", StaticVariables.martialMelee),
                new Weapon("Flail", "10 gp", "1d8 bludgeoning", "2 lbs", "-", StaticVariables.martialMelee),
                new Weapon("Glaive", "20 gp", "1d10 slashing", "6 lbs", "Heavy, Reach, Two-handed", StaticVariables.martialMelee),
                new Weapon("Greataxe", "30 gp", "1d12 slashing", "7 lbs", "Heavy, Two-handed", StaticVariables.martialMelee),
                new Weapon("Greatsword", "50 gp", "2d6 slashing", "6 lbs", "Heavy, Two-handed", StaticVariables.martialMelee),
                new Weapon("Halberd", "20 gp",    "1d10 slashing", "6 lbs", "Heavy, Reach, Two-handed", StaticVariables.martialMelee),
                new Weapon("Lance", "10 gp", "1d12 piercing", "6 lbs", "Reach, Special", StaticVariables.martialMelee),
                new Weapon("Longsword", "15 gp", "1d8 slashing", "3 lbs", "Versatile (1d10)", StaticVariables.martialMelee),
                new Weapon("Maul", "10 gp", "2d6 bludgeoning", "10 lbs", "Heavy, Two-handed", StaticVariables.martialMelee),
                new Weapon("Morningstar", "15 gp", "1d8 piercing", "4 lbs", "-", StaticVariables.martialMelee),
                new Weapon("Pike", "5 gp", "1d10 piercing", "18 lbs", "Heavy, Reach, Two-handed", StaticVariables.martialMelee),
                new Weapon("Rapier", "25 gp", "1d8 piercing", "2 lbs", "Finesse", StaticVariables.martialMelee),
                new Weapon("Scimitar", "25 gp", "1d6 slashing", "3 lbs", "Finesse, Light", StaticVariables.martialMelee),
                new Weapon("Shortsword", "10 gp", "1d6 piercing", "2 lbs", "Finesse, Light", StaticVariables.martialMelee),
                new Weapon("Trident", "5 gp", "1d6 piercing", "4 lbs", "Thrown (range 20/60), Versatile (1d8)", StaticVariables.martialMelee),
                new Weapon("War Pick", "5 gp", "1d8 piercing", "2 lbs", "-", StaticVariables.martialMelee),
                new Weapon("Warhammer", "15 gp", "1d8 bludgeoning", "2 lbs", "Versatile (1d10)", StaticVariables.martialMelee),
                new Weapon("Whip", "2 gp", "1d4 slashing", "3 lbs", "Finesse, Reach", StaticVariables.martialMelee)
            };
            return martialMeleeWeapons;
        }


        private static List<Weapon> FetchMartialRangedWeapons()
        {
            List<Weapon> martialRangedWeapons = new List<Weapon>
            {
                new Weapon("Blowgun", "10 gp", "1 piercing", "1 lbs", "Ammunition (range 25/100), Loading", StaticVariables.martialRanged),
                new Weapon("Crossbow, Hand", "75 gp", "1d6 piercing", "3 lbs", "Ammunition (range 30/120), Light, Loading", StaticVariables.martialRanged),
                new Weapon("Crossbow, Heavy", "50 gp", "1d10 piercing", "18 lbs", "Ammunition (range 100/400), Heavy, Loading, Two-handed", StaticVariables.martialRanged),
                new Weapon("Longbow", "50 gp", "1d8 piercing", "2 lbs", "Ammunition (range 150/600), Heavy, Two-handed", StaticVariables.martialRanged),
                new Weapon("Net", "1 gp", "-", "3 lbs", "Special, Thrown (range 5/15)", StaticVariables.martialRanged)
            };
            return martialRangedWeapons;
        }


        private static List<GeneralItem> FetchGeneralItems()
        {
            List<GeneralItem> generalItems = new List<GeneralItem>()
            {
                new GeneralItem("Abacus", "2 gp",  "2 lb", "General Good"),
                new GeneralItem("Acid (vial)", "25 gp", "1 lb", "General Good"),
                new GeneralItem("Alchemist's fire (flask)", "50 gp", "1 lb", "General Good"),
                new GeneralItem("Antitoxin (vial)", "50 gp", "-", "General Good"),
                new GeneralItem("Backpack", "2 gp", "5 lbs", "General Good"),
                new GeneralItem("Ball bearings (bag of 1,000)", "1 gp", "2 lbs", "General Good"),
                new GeneralItem("Barrel",  "2 gp", "70 lbs", "General Good"),
                new GeneralItem("Basket",  "4 sp", "2 lbs", "General Good"),
                new GeneralItem("Bedroll", "1 gp", "7 lbs", "General Good"),
                new GeneralItem("Bell", "1 gp", "-", "General Good"),
                new GeneralItem("Blanket", "5 sp", "3 lbs", "General Good"),
                new GeneralItem("Block and tackle", "1 gp", "5 lbs", "General Good"),
                new GeneralItem("Book", "25 gp", "5 lbs", "General Good"),
                new GeneralItem("Bottle, glass",   "2 gp", "2 lbs", "General Good"),
                new GeneralItem("Bucket",  "5 cp", "2 lbs", "General Good"),
                new GeneralItem("Caltrops (bag of 20)", "1 gp", "2 lbs", "General Good"),
                new GeneralItem("Candle",  "1 cp", "-", "General Good"),
                new GeneralItem("Case, crossbow bolt", "1 gp", "1 lb", "General Good"),
                new GeneralItem("Case, map or scroll", "1 gp", "1 lb", "General Good"),
                new GeneralItem("Chain (10 feet)", "5 gp", "10 lbs", "General Good"),
                new GeneralItem("Chalk (1 piece)", "1 cp", "-", "General Good"),
                new GeneralItem("Chest", "5 gp", "25 lbs", "General Good"),
                new GeneralItem("Climber's kit", "25 gp", "12 lbs", "General Good"),
                new GeneralItem("Clothes, common", "5 sp", "3 lbs", "General Good"),
                new GeneralItem("Clothes, costume", "5 gp", "4 lbs", "General Good"),
                new GeneralItem("Clothes, fine", "15 gp", "6 lbs", "General Good"),
                new GeneralItem("Clothes, traveler's", "2 gp", "4 lbs", "General Good"),
                new GeneralItem("Component pouch", "25 gp", "2 lbs", "General Good"),
                new GeneralItem("Crowbar", "2 gp", "5 lbs", "General Good"),
                new GeneralItem("Fishing tackle", "1 gp",  "4 lbs", "General Good"),
                new GeneralItem("Flask or tankard", "2 cp", "1 lb", "General Good"),
                new GeneralItem("Grappling hook", "2 gp",  "4 lbs", "General Good"),
                new GeneralItem("Hammer",  "1 gp", "3 lbs", "General Good"),
                new GeneralItem("Hammer, sledge", "2 gp",  "10 lbs", "General Good"),
                new GeneralItem("Healer's kit", "5 gp", "3 lbs", "General Good"),
                new GeneralItem("Holy water (flask)",  "25 gp", "1 lb", "General Good"),
                new GeneralItem("Hourglass", "25 gp", "1 lb", "General Good"),
                new GeneralItem("Hunting trap", "5 gp", "25 lbs", "General Good"),
                new GeneralItem("Ink (1 ounce bottle)", "10 gp", "-", "General Good"),
                new GeneralItem("Ink pen", "2 cp", "-", "General Good"),
                new GeneralItem("Jug or pitcher", "2 cp", "4 lbs", "General Good"),
                new GeneralItem("Ladder (10 foot)", "1 sp", "25 lb", "General Good"),
                new GeneralItem("Lamp", "5 sp", "1 lb", "General Good"),
                new GeneralItem("Lantern, bullseye", "10 gp", "2 lbs", "General Good"),
                new GeneralItem("Lantern, hooded", "5 gp", "2 lbs", "General Good"),
                new GeneralItem("Lock", "10 gp", "1 lb", "General Good"),
                new GeneralItem("Magnifying glass", "100 gp", "-", "General Good"),
                new GeneralItem("Manacles", "2 gp", "6 lbs", "General Good"),
                new GeneralItem("Mess kit", "2 sp", "1 lb", "General Good"),
                new GeneralItem("Mirror, steel", "5 gp", "1/2 lb", "General Good"),
                new GeneralItem("Oil (flask)", "1 sp", "1 lb", "General Good"),
                new GeneralItem("Paper (one sheet)", "2 sp", "-", "General Good"),
                new GeneralItem("Parchment (one sheet)", "1 sp", "-", "General Good"),
                new GeneralItem("Perfume (vial)", "5 gp", "-", "General Good"),
                new GeneralItem("Pick, miner's", "2 gp", "10 lbs", "General Good"),
                new GeneralItem("Piton", "5 cp", "1/4 lb", "General Good"),
                new GeneralItem("Poison, basic (vial)", "100 gp", "-", "General Good"),
                new GeneralItem("Pole (10-foot)", "5 cp", "7 lbs", "General Good"),
                new GeneralItem("Pot, iron", "2 gp", "10 lbs", "General Good"),
                new GeneralItem("Potion of Healing (2d4 + 2)", "50 gp", "1/2 lb", "General Good"),
                new GeneralItem("Potion of Greater Healing (4d4 + 4)", "200-250 gp", "1/2 lb", "General Good"),
                new GeneralItem("Potion of Superior Healing (8d4 + 8)", "2000-2500 gp", "1/2 lb", "General Good"),
                new GeneralItem("Potion of Supreme Healing (10d4 + 20)", "20000-25000 gp", "1/2 lb", "General Good"),
                new GeneralItem("Pouch", "5 sp", "1 lb", "General Good"),
                new GeneralItem("Quiver", "1 gp", "1 lb", "General Good"),
                new GeneralItem("Ram, portable", "4 gp", "35 lbs", "General Good"),
                new GeneralItem("Rations (1 day)", "5 sp", "2 lbs", "General Good"),
                new GeneralItem("Robes", "1 gp", "4 lbs", "General Good"),
                new GeneralItem("Rope, hempen (50 feet)", "1 gp", "10 lbs", "General Good"),
                new GeneralItem("Rope, silk (50 feet)", "10 gp", "5 lbs", "General Good"),
                new GeneralItem("Sack", "1 cp", "1/2 lb", "General Good"),
                new GeneralItem("Scale, merchant's", "5 gp", "3 lbs", "General Good"),
                new GeneralItem("Sealing wax", "5 sp", "-", "General Good"),
                new GeneralItem("Shovel", "2 gp", "5 lbs", "General Good"),
                new GeneralItem("Signal whistle", "5 cp",  "-", "General Good"),
                new GeneralItem("Signet ring"," 5 gp", "-", "General Good"),
                new GeneralItem("Soap", "2 cp", "-", "General Good"),
                new GeneralItem("Spellbook", "50 gp", "3 lbs", "General Good"),
                new GeneralItem("Spikes, iron (10)", "1 gp", "5 lbs", "General Good"),
                new GeneralItem("Spyglass", "1,000 gp", "1 lb", "General Good"),
                new GeneralItem("Tent, two-person", "2 gp", "20 lbs", "General Good"),
                new GeneralItem("Tinderbox", "5 sp", "1 lb", "General Good"),
                new GeneralItem("Torch", "1 cp", "1 lb", "General Good"),
                new GeneralItem("Vial", "1 gp", "-", "General Good"),
                new GeneralItem("Waterskin (full)", "2 sp", "5 lbs", "General Good"),
                new GeneralItem("Whetstone", "1 cp", "1 lb", "General Good")
            };
            return generalItems;
        }


        private static List<GeneralItem> FetchGeneralItemsAmmunition()
        {
            List<GeneralItem> ammunition = new List<GeneralItem>()
            {
                new GeneralItem("Arrows (20)", "1 gp", "1 lb", "Ammunition"),
                new GeneralItem("Blowgun Needles (50)", "1 gp", "1 lb", "Ammunition"),
                new GeneralItem("Crossbow Bolts (20)", "1 gp", "1 1/2 lbs", "Ammunition"),
                new GeneralItem("Sling Bullets (20)", "4 cp", "1 1/2 lbs", "Ammunition")
            };
            return ammunition;
        }


        private static List<GeneralItem> FetchGeneralItemsArcaneFocus()
        {
            List<GeneralItem> arcaneFocus = new List<GeneralItem>()
            {
                new GeneralItem("Crystal", "10 gp", "1 lb", "Arcane Focus"),
                new GeneralItem("Orb", "20 gp", "3 lbs", "Arcane Focus"),
                new GeneralItem("Rod", "10 gp", "2 lb", "Arcane Focus"),
                new GeneralItem("Staff", "5 gp", "4 lbs", "Arcane Focus"),
                new GeneralItem("Wand", "10 gp", "1 lb", "Arcane Focus")
            };
            return arcaneFocus;
        }


        private static List<GeneralItem> FetchGeneralItemsDruidicFocus()
        {
            List<GeneralItem>druidicFocus = new List<GeneralItem>()
            {
                new GeneralItem("Sprig of Mistletoe", "1 gp", "-", "Druidic Focus"),
                new GeneralItem("Totem", "1 gp", "-", "Druidic Focus"),
                new GeneralItem("Wooden Staff", "5 gp", "4 lbs", "Druidic Focus"),
                new GeneralItem("Yew Wand", "10 gp", "1 lb", "Druidic Focus")
            };
            return druidicFocus;
        }


        private static List<GeneralItem> FetchGeneralItemsHolySymbol()
        {
            List<GeneralItem> holySymbol = new List<GeneralItem>()
            {
                new GeneralItem("Amulet", "5 gp", "1 lb", "Holy Symbol"),
                new GeneralItem("Emblem", "5 gp", "-", "Holy Symbol"),
                new GeneralItem("Reliquary", "5 gp", "2 lbs", "Holy Symbol")
            };
            return holySymbol;
        }

        private static List<string> FetchGeneralItemsTrinkets()
        {
            List<string> trinkets = new List<string>()
            {
                "A mummified goblin hand",
                "A piece of crystal that faintly glows in the moonlight",
                "A gold coin minted in an unknown land",
                "A diary written in a language you don’t know",
                "A brass ring that never tarnishes",
                "An old chess piece made from glass",
                "A pair of knucklebone dice, each with a skull symbol on the side that would normally show six pips",
                "A small idol depicting a nightmarish creature that gives you unsettling dreams when you sleep near it",
                "A rope necklace from which dangles four mummified elf fingers",
                "The deed for a parcel of land in a realm unknown to you",
                "A 1-ounce block made from an unknown material",
                "A small cloth doll skewered with needles",
                "A tooth from an unknown beast",
                "An enormous scale, perhaps from a dragon",
                "A bright green feather",
                "An old divination card bearing your likeness",
                "A glass orb filled with moving smoke",
                "A 1-pound egg with a bright red shell",
                "A pipe that blows bubbles",
                "A glass jar containing a weird bit of flesh floating in pickling fluid",
                "A tiny gnome-crafted music box that plays a song you dimly remember from your childhood",
                "A small wooden statuette of a smug halfling",
                "A brass orb etched with strange runes",
                "A multicolored stone disk",
                "A tiny silver icon of a raven",
                "A bag containing forty-seven humanoid teeth, one of which is rotten",
                "A shard of obsidian that always feels warm to the touch",
                "A dragon's bony talon hanging from a plain leather necklace",
                "A pair of old socks",
                "A blank book whose pages refuse to hold ink, chalk, graphite, or any other substance or marking",
                "A silver badge in the shape of a five-pointed star",
                "A knife that belonged to a relative",
                "A glass vial filled with nail clippings",
                "A rectangular metal device with two tiny metal cups on one end that throws sparks when wet",
                "A white, sequined glove sized for a human",
                "A vest with one hundred tiny pockets",
                "A small, weightless stone block",
                "A tiny sketch portrait of a goblin",
                "An empty glass vial that smells of perfume when opened",
                "A gemstone that looks like a lump of coal when examined by anyone but you",
                "A scrap of cloth from an old banner",
                "A rank insignia from a lost legionnaire",
                "A tiny silver bell without a clapper",
                "A mechanical canary inside a gnome-crafted lamp",
                "A tiny chest carved to look like it has numerous feet on the bottom",
                "A dead sprite inside a clear glass bottle",
                "A metal can that has no opening but sounds as if it is filled with liquid, sand, spiders, or broken glass (your choice)",
                "A glass orb filled with water, in which swims a clockwork goldfish",
                "A silver spoon with an M engraved on the handle",
                "A whistle made from gold-colored wood",
                "A dead scarab beetle the size of your hand",
                "Two toy soldiers, one with a missing head",
                "A small box filled with different-sized buttons",
                "A candle that can’t be lit",
                "A tiny cage with no door",
                "An old key",
                "An indecipherable treasure map",
                "A hilt from a broken sword",
                "A rabbit’s foot",
                "A glass eye",
                "A cameo carved in the likeness of a hideous person",
                "A silver skull the size of a coin",
                " An alabaster mask",
                "A pyramid of sticky black incense that smells very bad",
                "A nightcap that, when worn, gives you pleasant dreams",
                "A single caltrop made from bone",
                "A gold monocle frame without the lens",
                "A 1-inch cube, each side painted a different color",
                "A crystal knob from a door",
                "A small packet filled with pink dust",
                "A fragment of a beautiful song, written as musical notes on two pieces of parchment",
                "A silver teardrop earring made from a real teardrop",
                "The shell of an egg painted with scenes of human misery in disturbing detail",
                "A fan that, when unfolded, shows a sleeping cat",
                "A set of bone pipes",
                "A four-leaf clover pressed inside a book discussing manners and etiquette",
                "A sheet of parchment upon which is drawn a complex mechanical contraption",
                "An ornate scabbard that fits no blade you have found so far",
                "An invitation to a party where a murder happened",
                "A bronze pentacle with an etching of a rat's head in its center",
                "A purple handkerchief embroidered with the name of a powerful archmage",
                "Half of a floorplan for a temple, castle, or some other structure",
                "A bit of folded cloth that, when unfolded, turns into a stylish cap",
                "A receipt of deposit at a bank in a far-flung city",
                "A diary with seven missing pages",
                "An empty silver snuffbox bearing an inscription on the surface that says “dreams”",
                "An iron holy symbol devoted to an unknown god",
                "A book that tells the story of a legendary hero's rise and fall, with the last chapter missing",
                "A vial of dragon blood",
                "An ancient arrow of elven design",
                "A needle that never bends",
                "An ornate brooch of dwarven design",
                "An empty wine bottle bearing a pretty label that says, “The Wizard of Wines Winery, Red Dragon Crush, 331422-W”",
                "A mosaic tile with a multicolored, glazed surface",
                "A petrified mouse",
                "A black pirate flag adorned with a dragon's skull and crossbones",
                "A tiny mechanical crab or spider that moves about when it’s not being observed",
                "A glass jar containing lard with a label that reads, Griffon Grease",
                "A wooden box with a ceramic bottom that holds a living worm with a head on each end of its body",
                "A metal urn containing the ashes of a hero"
            };
            return trinkets;
        }


        private static List<Art> FetchArt25()
        {
            List<Art> art = new List<Art>()
            {
                new Art("Silver ewer", StaticVariables.gp25),
                new Art("Carved bone statuette", StaticVariables.gp25),
                new Art("Small gold bracelet", StaticVariables.gp25),
                new Art("Cloth-of-gold vestments", StaticVariables.gp25),
                new Art("Black velvet mask stitched with silver thread", StaticVariables.gp25),
                new Art("Copper chalice with silver filigree", StaticVariables.gp25),
                new Art("Pair of engraved bone dice", StaticVariables.gp25),
                new Art("Small mirror set in a painted wooden frame", StaticVariables.gp25),
                new Art("Embroidered silk handkerchief", StaticVariables.gp25),
                new Art("Gold locket with a painted portrait inside", StaticVariables.gp25)
            };
            return art;
        }


        private static List<Art> FetchArt250()
        {
            List<Art> art = new List<Art>()
            {
                new Art("Gold ring set with bloodstones", StaticVariables.gp250),
                new Art("Carved ivory statuette", StaticVariables.gp250),
                new Art("Large gold bracelet", StaticVariables.gp250),
                new Art("Silver necklace with a gemstone pendant", StaticVariables.gp250),
                new Art("Bronze crown", StaticVariables.gp250),
                new Art("Silk robe with gold embroidery", StaticVariables.gp250),
                new Art("Large well-made tapestry", StaticVariables.gp250),
                new Art("Brass mug with jade inlay", StaticVariables.gp250),
                new Art("Box of turquoise animal figurines", StaticVariables.gp250),
                new Art("Gold bird cage with electrum filigree", StaticVariables.gp250)
            };
            return art;
        }


        private static List<Art> FetchArt750()
        {
            List<Art> art = new List<Art>()
            {
                new Art("Silver chalice set with moonstones", StaticVariables.gp750),
                new Art("Silver-plated steel longsword with jet set in hilt", StaticVariables.gp750),
                new Art("Carved harp of exotic wood with ivory inlay and zircon gems", StaticVariables.gp750),
                new Art("Small gold idol", StaticVariables.gp750),
                new Art("Gold dragon comb set with red garnets as eyes", StaticVariables.gp750),
                new Art("Bottle stopper cork embossed with gold leaf and set with amethysts", StaticVariables.gp750),
                new Art("Ceremonial electrum dagger with a black pearl in the pommel", StaticVariables.gp750),
                new Art("Silver and gold brooch", StaticVariables.gp750),
                new Art("Obsidian statuette with gold fittings and inlay", StaticVariables.gp750),
                new Art("Painted gold war mask", StaticVariables.gp750)
            };
            return art;
        }


        private static List<Art> FetchArt2500()
        {
            List<Art> art = new List<Art>()
            {
                new Art("Fine gold chain set with a fire opal", StaticVariables.gp2500),
                new Art("Old masterpiece painting", StaticVariables.gp2500),
                new Art("Embroidered silk and velvet mantle set with numerous moonstones", StaticVariables.gp2500),
                new Art("Platinum bracelet set with a sapphire", StaticVariables.gp2500),
                new Art("Embroidered glove set with jewel chips", StaticVariables.gp2500),
                new Art("Jeweled anklet", StaticVariables.gp2500),
                new Art("Gold music box", StaticVariables.gp2500),
                new Art("Gold circlet set with four aquamarines", StaticVariables.gp2500),
                new Art("Eye patch with a mock eye set in blue sapphire and moonstone", StaticVariables.gp2500),
                new Art("A necklace string of small pink pearls", StaticVariables.gp2500)
            };
            return art;
        }


        private static List<Art> FetchArt7500()
        {
            List<Art> art = new List<Art>()
            {
                new Art("Jeweled gold crown", StaticVariables.gp7500),
                new Art("Jeweled platinum ring", StaticVariables.gp7500),
                new Art("Small gold statuette set with rubies", StaticVariables.gp7500),
                new Art("Gold cup set with emeralds", StaticVariables.gp7500),
                new Art("Gold jewelry box with platinum filigree", StaticVariables.gp7500),
                new Art("Painted gold child’s sarcophagus", StaticVariables.gp7500),
                new Art("Jade game board with solid gold playing pieces", StaticVariables.gp7500),
                new Art("Bejeweled ivory drinking horn with gold filigree", StaticVariables.gp7500)
            };
            return art;
        }


        private static List<Gem> FetchGems10()
        {
            List<Gem> gems = new List<Gem>()
            {
                new Gem("Azurite", "opaque mottled deep blue", StaticVariables.gp10),
                new Gem("Banded Agate", "translucent striped brown, blue, white, or red", StaticVariables.gp10),
                new Gem("Blue Quartz", "transparent pale blue", StaticVariables.gp10),
                new Gem("Eye Agate", "translucent circles or gray, white, brown, blue, or green", StaticVariables.gp10),
                new Gem("Hematite", "opaque gray-black", StaticVariables.gp10),
                new Gem("Lapis Lazuli", "opaque light and dark blue with yellow flecks", StaticVariables.gp10),
                new Gem("Malachite", "opaque striated light and dark green)", StaticVariables.gp10),
                new Gem("Moss Agate", "translucent pink or yellow-white with mossy gray or green markings", StaticVariables.gp10),
                new Gem("Obsidian", "opaque black", StaticVariables.gp10),
                new Gem("Rhodochrosite", "opaque light pink", StaticVariables.gp10),
                new Gem("Tiger Eye", "translucent brown with golden center", StaticVariables.gp10),
                new Gem("Turquoise", "opaque light blue-green", StaticVariables.gp10)
            };
            return gems;
        }


        private static List<Gem> FetchGems50()
        {
            List<Gem> gems = new List<Gem>()
            {
                new Gem("Bloodstone", "opaque dark gray with red flecks", StaticVariables.gp50),
                new Gem("Carnelian", "opaque orange to red-brown", StaticVariables.gp50),
                new Gem("Chalcedony", "opaque white", StaticVariables.gp50),
                new Gem("Chrysoprase", "translucent green", StaticVariables.gp50),
                new Gem("Citrine", "transparent pale yellow-brown", StaticVariables.gp50),
                new Gem("Jasper", "opaque blue, black, or brown", StaticVariables.gp50),
                new Gem("Moonstone", "translucent white with pale blue glow", StaticVariables.gp50),
                new Gem("Onyx", "opaque bands of black and white, or pure black or white", StaticVariables.gp50),
                new Gem("Quartz", "transparent white, smoky gray, or yellow", StaticVariables.gp50),
                new Gem("Sardonyx", "opaque bands of red and white", StaticVariables.gp50),
                new Gem("Star rose quartz", "translucent rosy stone with white star-shaped center", StaticVariables.gp50),
                new Gem("Zircon", "transparent pale blue-green", StaticVariables.gp50)
            };
            return gems;
        }


        private static List<Gem> FetchGems100()
        {
            List<Gem> gems = new List<Gem>()
            {
                new Gem("Amber", "transparent watery gold to rich gold", StaticVariables.gp100),
                new Gem("Amethyst", "transparent deep purple", StaticVariables.gp100),
                new Gem("Chrysoberyl", "transparent yellow-green to pale green", StaticVariables.gp100),
                new Gem("Coral", "opaque crimson", StaticVariables.gp100),
                new Gem("Garnet", "transparent red, brown-green, or violet", StaticVariables.gp100),
                new Gem("Jade", "translucent light green, deep green, or white", StaticVariables.gp100),
                new Gem("Jet", "opaque deep black", StaticVariables.gp100),
                new Gem("Pearl", "opaque lustrous white, yellow, or pink", StaticVariables.gp100),
                new Gem("Spinel", "transparent red, red-brown, or deep green", StaticVariables.gp100),
                new Gem("Tourmaline", "transparent pale green, blue, brown, or red", StaticVariables.gp100)
            };
            return gems;
        }


        private static List<Gem> FetchGems500()
        {
            List<Gem> gems = new List<Gem>()
            {
                new Gem("Alexandrite", "transparent dark green", StaticVariables.gp500),
                new Gem("Aquamarine", "transparent pale blue-green", StaticVariables.gp500),
                new Gem("Black Pearl", "opaque pure black", StaticVariables.gp500),
                new Gem("Blue Spinel", "transparent deep blue", StaticVariables.gp500),
                new Gem("Peridot", "transparent rich olive green", StaticVariables.gp500),
                new Gem("Topaz", "transparent golden yellow", StaticVariables.gp500)
            };
            return gems;
        }


        private static List<Gem> FetchGems1000()
        {
            List<Gem> gems = new List<Gem>()
            {
                new Gem("Black Opal", "translucent dark green with black mottling and golden flecks", StaticVariables.gp1000),
                new Gem("Blue Sapphire", "transparent blue-white to medium blue", StaticVariables.gp1000),
                new Gem("Emerald", "transparent deep bright green", StaticVariables.gp1000),
                new Gem("Fire Opal", "translucent fiery red", StaticVariables.gp1000),
                new Gem("Opal", "translucent pale blue with green and golden mottling", StaticVariables.gp1000),
                new Gem("Star Ruby", "translucent ruby with white star-shaped center", StaticVariables.gp1000),
                new Gem("Star Sapphire", "translucent blue sapphire with white star-shaped center", StaticVariables.gp1000),
                new Gem("Yellow Sapphire", "transparent fiery yellow or yellow-green", StaticVariables.gp1000)
            };
            return gems;
        }


        private static List<Gem> FetchGems5000()
        {
            List<Gem> gems = new List<Gem>()
            {
                new Gem("Black Sapphire", "translucent lustrous black with glowing highlights", StaticVariables.gp5000),
                new Gem("Diamond", "transparent blue-white, canary, pink, brown, or blue", StaticVariables.gp5000),
                new Gem("Jacinth", "transparent fiery orange", StaticVariables.gp5000),
                new Gem("Ruby", "transparent clear red to deep crimson", StaticVariables.gp5000)
            };
            return gems;
        }
    }
}
