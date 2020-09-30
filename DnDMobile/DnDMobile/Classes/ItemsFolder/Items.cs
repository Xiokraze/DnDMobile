using System.Collections.Generic;

namespace DnDMobile.Classes.ItemsFolder
{
    class Items
    {
        private List<Armor> StandardLightArmor { get; } = FetchStandardLightArmor();
        private List<Armor> StandardMediumArmor { get; } = FetchStandardMediumArmor();
        private List<Armor> StandardHeavyArmor { get; } = FetchStandardHeavyArmor();
        private List<Armor> StandardShields { get; } = FetchStandardShilelds();
        private List<Weapon> SimpleMeleeWeapons { get; } = FetchSimpleMeleeWeapons();
        private List<Weapon> SimpleRangedWeapons { get; } = FetchSimpleRangedWeapons();
        private List<Weapon> MartialMeleeWeapons { get; } = FetchMartialMeleeWeapons();
        private List<Weapon> MartialRangedWeapons { get; } = FetchMartialRangedWeapons();
        private List<GeneralItem> GeneralItems { get; } = FetchGeneralItems();
        private List<GeneralItem> GeneralItemsAmmunition { get; } = FetchGeneralItemsAmmunition();
        private List<GeneralItem> GeneralItemsArcaneFocus { get; } = FetchGeneralItemsArcaneFocus();
        private List<GeneralItem> GeneralItemsDruidicFocus { get; } = FetchGeneralItemsDruidicFocus();
        private List<GeneralItem> GeneralItemsHolySymbol { get; } = FetchGeneralItemsHolySymbol();
        private List<string> GeneralItemsTrinkets { get; } = FetchGeneralItemsTrinkets();

        public Items() { }


        public int GetNumberOfWeaponsCount()
        {
            int simpleMeleeCount = SimpleMeleeWeapons.Count;
            int simpleRangedCount = SimpleRangedWeapons.Count;
            int martialMeleeCount = MartialMeleeWeapons.Count;
            int martialRangedCount = MartialRangedWeapons.Count;
            return simpleMeleeCount + simpleRangedCount + martialMeleeCount + martialRangedCount;
        }


        public int GetNumberOfArmorCount()
        {
            int lightArmorCount = StandardLightArmor.Count;
            int mediumArmorCount = StandardMediumArmor.Count;
            int heavyArmorCount = StandardHeavyArmor.Count;
            int shieldCount = StandardShields.Count;
            return lightArmorCount + mediumArmorCount + heavyArmorCount + shieldCount;
        }


        public int GetGeneralItemsCount()
        {
            int generalItemCount = GeneralItems.Count;
            int ammunitionCount = GeneralItemsAmmunition.Count;
            int arcaneFocusCount = GeneralItemsArcaneFocus.Count;
            int druidicFocusCount = GeneralItemsDruidicFocus.Count;
            int holySymbolCount = GeneralItemsHolySymbol.Count;
            return generalItemCount + ammunitionCount + arcaneFocusCount + druidicFocusCount + holySymbolCount;
        }


        public int GetEquipmentCount()
        {
            int weaponsCount = GetNumberOfWeaponsCount();
            int armorCount = GetNumberOfArmorCount();
            int generalItemsCount = GetGeneralItemsCount();
            return weaponsCount + armorCount + generalItemsCount;
        }


        public List<Armor> GetStandardLightArmor()
        {
            return StandardLightArmor;
        }


        public List<Armor> GetStandardMediumArmor()
        {
            return StandardMediumArmor;
        }


        public List<Armor> GetStandardHeavyArmor()
        {
            return StandardHeavyArmor;
        }


        public List<Armor> GetStandardShields()
        {
            return StandardShields;
        }


        public List<Weapon> GetSimpleMeleeWeapons()
        {
            return SimpleMeleeWeapons;
        }


        public List<Weapon> GetSimpleRangedWeapons()
        {
            return SimpleRangedWeapons;
        }


        public List<Weapon> GetMartialMeleeWeapons()
        {
            return MartialMeleeWeapons;
        }


        public List<Weapon> GetMartialRangedWeapons()
        {
            return MartialRangedWeapons;
        }


        public List<GeneralItem> GetGeneralItems()
        {
            return GeneralItems;
        }


        public List<GeneralItem> GetGeneralItemsAmmunition()
        {
            return GeneralItemsAmmunition;
        }


        public List<GeneralItem> GetGeneralItemsArcaneFocusn()
        {
            return GeneralItemsArcaneFocus;
        }


        public List<GeneralItem> GetGeneralItemsDruidicFocus()
        {
            return GeneralItemsDruidicFocus;
        }


        public List<GeneralItem> GetGeneralItemsHolySymbol()
        {
            return GeneralItemsHolySymbol;
        }


        public List<string> GetGeneralItemsTrinkets()
        {
            return GeneralItemsTrinkets;
        }


        private static List<Armor> FetchStandardLightArmor()
        {
            List<Armor> lightArmor = new List<Armor>
            {
                new Armor("Padded", "5 gp", "11 + Dex Modifier", "-", "Disadvantage", "8 lbs"),
                new Armor("Leather", "10 gp", "11 + Dex Modifier", "-", "-", "10 lbs"),
                new Armor("Studded Leather", "45 gp", "12 + Dex Modifier", "-", "-", "13 lbs")
            };
            return lightArmor;
        }


        private static List<Armor> FetchStandardMediumArmor()
        {
            List<Armor> mediumArmor = new List<Armor>
            {
                new Armor("Hide", "10 gp", "12 + Dex Modifier (Max 2)", "-", "-", "12 lbs"),
                new Armor("Chain Shirt", "50 gp", "13 + Dex Modifier (Max 2)", "-", "-", "20 lbs"),
                new Armor("Scale Mail", "50 gp", "14 + Dex Modifier (Max 2)", "-", "Disadvantage", "45 lbs"),
                new Armor("Breastplate", "400 gp", "14 + Dex Modifier (Max 2)", "-", "-", "20 lbs"),
                new Armor("Half Plate", "750 gp", "15 + Dex Modifier (Max 2)", "-", "Disadvantage", "40 lbs")
            };
            return mediumArmor;
        }


        private static List<Armor> FetchStandardHeavyArmor()
        {
            List<Armor> heavyArmor = new List<Armor>
            {
                new Armor("Ring Mail", "30 gp", "14", "-", "Disadvantage", "40 lbs"),
                new Armor("Chain Mail", "75 gp", "16", "13", "Disadvantage", "55 lbs"),
                new Armor("Splint", "200 gp", "17", "15", "Disadvantage", "60 lbs"),
                new Armor("Plate", "1,500 gp", "18", "15", "Disadvantage", "65 lbs")
            };
            return heavyArmor;
        }


        private static List<Armor> FetchStandardShilelds()
        {
            List<Armor> shields = new List<Armor>
            {
                new Armor("Shield", "10 gp", "+2", "-", "-", "6 lbs")
            };
            return shields;
        }


        private static List<Weapon> FetchSimpleMeleeWeapons()
        {
            List<Weapon> simpleMeleeWeapons = new List<Weapon>
            {
                new Weapon("Club", "1 sp", "1d4 bludgeoning", "2 lbs", "Light"),
                new Weapon("Dagger", "2 gp", "1d4 piercing",  "1 lbs", "Finesse, Light, Thrown (range 20/60)"),
                new Weapon("Greatclub", "2 sp", "1d8 bludgeoning", "10 lbs", "Two-handed"),
                new Weapon("Handaxe", "5 gp", "1d6 slashing", "2 lbs", "Light, Thrown (range 20/60)"),
                new Weapon("Javelin", "5 sp", "1d6 piercing", "2 lbs", "Thrown (range 30/120)"),
                new Weapon("Light Hammer", "2 gp", "1d4 bludgeoning", "2 lbs", "Light, Thrown (range 20/60)"),
                new Weapon("Mace", "5 gp", "1d6 bludgeoning", "4 lbs",  "-"),
                new Weapon("Quarterstaff", "2 sp", "1d6 bludgeoning", "4 lbs", "Versatile (1d8)"),
                new Weapon("Sickle", "1 gp", "1d4 slashing", "2 lbs", "Light"),
                new Weapon("Spear", "1 gp", "1d6 piercing", "3 lbs", "Thrown (range 20/60), Versatile (1d8)")
            };
            return simpleMeleeWeapons;
        }


        private static List<Weapon> FetchSimpleRangedWeapons()
        {
            List<Weapon> simpleRangedWeapons = new List<Weapon>
            {
                new Weapon("Crossbow, Light", "25 gp", "1d8 piercing", "5 lbs", "Ammunition (range 80/320), Loading, Two-handed"),
                new Weapon("Dart", "5 cp", "1d4 piercing", "1/4 lbs", "Finesse, Thrown (range 20/60)"),
                new Weapon("Shortbow", "25 gp", "1d6 piercing", "2 lbs", "Ammunition (range 80/320), Two-handed"),
                new Weapon("Sling", "1 sp", "1d4 bludgeoning", "-", "Ammunition (range 30/120)")
            };
            return simpleRangedWeapons;
        }


        private static List<Weapon> FetchMartialMeleeWeapons()
        {
            List<Weapon> martialMeleeWeapons = new List<Weapon>
            {
                new Weapon("Battleaxe", "10 gp", "1d8 slashing", "4 lbs", "Versatile (1d10)"),
                new Weapon("Flail", "10 gp", "1d8 bludgeoning", "2 lbs", "-"),
                new Weapon("Glaive", "20 gp", "1d10 slashing", "6 lbs", "Heavy, Reach, Two-handed"),
                new Weapon("Greataxe", "30 gp", "1d12 slashing", "7 lbs", "Heavy, Two-handed"),
                new Weapon("Greatsword", "50 gp", "2d6 slashing", "6 lbs", "Heavy, Two-handed"),
                new Weapon("Halberd", "20 gp",    "1d10 slashing", "6 lbs", "Heavy, Reach, Two-handed"),
                new Weapon("Lance", "10 gp", "1d12 piercing", "6 lbs", "Reach, Special"),
                new Weapon("Longsword", "15 gp", "1d8 slashing", "3 lbs", "Versatile (1d10)"),
                new Weapon("Maul", "10 gp", "2d6 bludgeoning", "10 lbs", "Heavy, Two-handed"),
                new Weapon("Morningstar", "15 gp", "1d8 piercing", "4 lbs", "-"),
                new Weapon("Pike", "5 gp", "1d10 piercing", "18 lbs", "Heavy, Reach, Two-handed"),
                new Weapon("Rapier", "25 gp", "1d8 piercing", "2 lbs", "Finesse"),
                new Weapon("Scimitar", "25 gp", "1d6 slashing", "3 lbs", "Finesse, Light"),
                new Weapon("Shortsword", "10 gp", "1d6 piercing", "2 lbs", "Finesse, Light"),
                new Weapon("Trident", "5 gp", "1d6 piercing", "4 lbs", "Thrown (range 20/60), Versatile (1d8)"),
                new Weapon("War Pick", "5 gp", "1d8 piercing", "2 lbs", "-"),
                new Weapon("Warhammer", "15 gp", "1d8 bludgeoning", "2 lbs", "Versatile (1d10)"),
                new Weapon("Whip", "2 gp", "1d4 slashing", "3 lbs", "Finesse, Reach")
            };
            return martialMeleeWeapons;
        }


        private static List<Weapon> FetchMartialRangedWeapons()
        {
            List<Weapon> martialRangedWeapons = new List<Weapon>
            {
                new Weapon("Blowgun", "10 gp", "1 piercing", "1 lbs", "Ammunition (range 25/100), Loading"),
                new Weapon("Crossbow, Hand", "75 gp", "1d6 piercing", "3 lbs", "Ammunition (range 30/120), Light, Loading"),
                new Weapon("Crossbow, Heavy", "50 gp", "1d10 piercing", "18 lbs", "Ammunition (range 100/400), Heavy, Loading, Two-handed"),
                new Weapon("Longbow", "50 gp", "1d8 piercing", "2 lbs", "Ammunition (range 150/600), Heavy, Two-handed"),
                new Weapon("Net", "1 gp", "-", "3 lbs", "Special, Thrown (range 5/15)")
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
                new GeneralItem("Bell",    "1 gp", "-", "General Good"),
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
                new GeneralItem("Potion of healing", "50 gp", "1/2 lb", "General Good"),
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
    }
}
