using System.Collections.Generic;
using System.Linq;

namespace DnDMobile.Classes.ItemsFolder.ItemLists
{
    class GeneralItems
    {
        public static List<GeneralItem> GenItems { get; } = new List<GeneralItem>()
        {
            new GeneralItem("Abacus", "2 gp",  "2 lb", ItemTypes.GeneralGood),
            new GeneralItem("Acid (vial)", "25 gp", "1 lb", ItemTypes.GeneralGood),
            new GeneralItem("Alchemist's fire (flask)", "50 gp", "1 lb", ItemTypes.GeneralGood),
            new GeneralItem("Antitoxin (vial)", "50 gp", "-", ItemTypes.GeneralGood),
            new GeneralItem("Backpack", "2 gp", "5 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Ball bearings (bag of 1,000)", "1 gp", "2 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Barrel",  "2 gp", "70 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Basket",  "4 sp", "2 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Bedroll", "1 gp", "7 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Bell", "1 gp", "-", ItemTypes.GeneralGood),
            new GeneralItem("Blanket", "5 sp", "3 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Block and tackle", "1 gp", "5 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Book", "25 gp", "5 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Bottle, glass",   "2 gp", "2 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Bucket",  "5 cp", "2 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Caltrops (bag of 20)", "1 gp", "2 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Candle",  "1 cp", "-", ItemTypes.GeneralGood),
            new GeneralItem("Case, crossbow bolt", "1 gp", "1 lb", ItemTypes.GeneralGood),
            new GeneralItem("Case, map or scroll", "1 gp", "1 lb", ItemTypes.GeneralGood),
            new GeneralItem("Chain (10 feet)", "5 gp", "10 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Chalk (1 piece)", "1 cp", "-", ItemTypes.GeneralGood),
            new GeneralItem("Chest", "5 gp", "25 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Climber's kit", "25 gp", "12 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Clothes, common", "5 sp", "3 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Clothes, costume", "5 gp", "4 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Clothes, fine", "15 gp", "6 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Clothes, traveler's", "2 gp", "4 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Component pouch", "25 gp", "2 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Crowbar", "2 gp", "5 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Fishing tackle", "1 gp",  "4 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Flask or tankard", "2 cp", "1 lb", ItemTypes.GeneralGood),
            new GeneralItem("Grappling hook", "2 gp",  "4 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Hammer",  "1 gp", "3 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Hammer, sledge", "2 gp",  "10 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Healer's kit", "5 gp", "3 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Holy water (flask)",  "25 gp", "1 lb", ItemTypes.GeneralGood),
            new GeneralItem("Hourglass", "25 gp", "1 lb", ItemTypes.GeneralGood),
            new GeneralItem("Hunting trap", "5 gp", "25 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Ink (1 ounce bottle)", "10 gp", "-", ItemTypes.GeneralGood),
            new GeneralItem("Ink pen", "2 cp", "-", ItemTypes.GeneralGood),
            new GeneralItem("Jug or pitcher", "2 cp", "4 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Ladder (10 foot)", "1 sp", "25 lb", ItemTypes.GeneralGood),
            new GeneralItem("Lamp", "5 sp", "1 lb", ItemTypes.GeneralGood),
            new GeneralItem("Lantern, bullseye", "10 gp", "2 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Lantern, hooded", "5 gp", "2 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Lock", "10 gp", "1 lb", ItemTypes.GeneralGood),
            new GeneralItem("Magnifying glass", "100 gp", "-", ItemTypes.GeneralGood),
            new GeneralItem("Manacles", "2 gp", "6 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Mess kit", "2 sp", "1 lb", ItemTypes.GeneralGood),
            new GeneralItem("Mirror, steel", "5 gp", "1/2 lb", ItemTypes.GeneralGood),
            new GeneralItem("Oil (flask)", "1 sp", "1 lb", ItemTypes.GeneralGood),
            new GeneralItem("Paper (one sheet)", "2 sp", "-", ItemTypes.GeneralGood),
            new GeneralItem("Parchment (one sheet)", "1 sp", "-", ItemTypes.GeneralGood),
            new GeneralItem("Perfume (vial)", "5 gp", "-", ItemTypes.GeneralGood),
            new GeneralItem("Pick, miner's", "2 gp", "10 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Piton", "5 cp", "1/4 lb", ItemTypes.GeneralGood),
            new GeneralItem("Poison, basic (vial)", "100 gp", "-", ItemTypes.GeneralGood),
            new GeneralItem("Pole (10-foot)", "5 cp", "7 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Pot, iron", "2 gp", "10 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Potion of Healing (2d4 + 2)", "50 gp", "1/2 lb", ItemTypes.GeneralGood),
            new GeneralItem("Potion of Greater Healing (4d4 + 4)", "200-250 gp", "1/2 lb", ItemTypes.GeneralGood),
            new GeneralItem("Potion of Superior Healing (8d4 + 8)", "2000-2500 gp", "1/2 lb", ItemTypes.GeneralGood),
            new GeneralItem("Potion of Supreme Healing (10d4 + 20)", "20000-25000 gp", "1/2 lb", ItemTypes.GeneralGood),
            new GeneralItem("Pouch", "5 sp", "1 lb", ItemTypes.GeneralGood),
            new GeneralItem("Quiver", "1 gp", "1 lb", ItemTypes.GeneralGood),
            new GeneralItem("Ram, portable", "4 gp", "35 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Rations (1 day)", "5 sp", "2 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Robes", "1 gp", "4 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Rope, hempen (50 feet)", "1 gp", "10 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Rope, silk (50 feet)", "10 gp", "5 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Sack", "1 cp", "1/2 lb", ItemTypes.GeneralGood),
            new GeneralItem("Scale, merchant's", "5 gp", "3 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Sealing wax", "5 sp", "-", ItemTypes.GeneralGood),
            new GeneralItem("Shovel", "2 gp", "5 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Signal whistle", "5 cp",  "-", ItemTypes.GeneralGood),
            new GeneralItem("Signet ring"," 5 gp", "-", ItemTypes.GeneralGood),
            new GeneralItem("Soap", "2 cp", "-", ItemTypes.GeneralGood),
            new GeneralItem("Spellbook", "50 gp", "3 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Spikes, iron (10)", "1 gp", "5 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Spyglass", "1,000 gp", "1 lb", ItemTypes.GeneralGood),
            new GeneralItem("Tent, two-person", "2 gp", "20 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Tinderbox", "5 sp", "1 lb", ItemTypes.GeneralGood),
            new GeneralItem("Torch", "1 cp", "1 lb", ItemTypes.GeneralGood),
            new GeneralItem("Vial", "1 gp", "-", ItemTypes.GeneralGood),
            new GeneralItem("Waterskin (full)", "2 sp", "5 lbs", ItemTypes.GeneralGood),
            new GeneralItem("Whetstone", "1 cp", "1 lb", ItemTypes.GeneralGood)
        };


        public static List<GeneralItem> Ammunition { get; }= new List<GeneralItem>()
        {
            new GeneralItem("Arrows (20)", "1 gp", "1 lb", ItemTypes.Ammunition),
            new GeneralItem("Blowgun Needles (50)", "1 gp", "1 lb", ItemTypes.Ammunition),
            new GeneralItem("Crossbow Bolts (20)", "1 gp", "1 1/2 lbs", ItemTypes.Ammunition),
            new GeneralItem("Sling Bullets (20)", "4 cp", "1 1/2 lbs", ItemTypes.Ammunition)
        };


        public static List<GeneralItem> ArcaneFocui { get; } = new List<GeneralItem>()
        {
            new GeneralItem("Crystal", "10 gp", "1 lb", ItemTypes.ArcaneFocus),
            new GeneralItem("Orb", "20 gp", "3 lbs", ItemTypes.ArcaneFocus),
            new GeneralItem("Rod", "10 gp", "2 lb", ItemTypes.ArcaneFocus),
            new GeneralItem("Staff", "5 gp", "4 lbs", ItemTypes.ArcaneFocus),
            new GeneralItem("Wand", "10 gp", "1 lb", ItemTypes.ArcaneFocus)
        };


        public static List<GeneralItem> DruidicFocui { get; } = new List<GeneralItem>()
        {
            new GeneralItem("Sprig of Mistletoe", "1 gp", "-", ItemTypes.DruidicFocus),
            new GeneralItem("Totem", "1 gp", "-", ItemTypes.DruidicFocus),
            new GeneralItem("Wooden Staff", "5 gp", "4 lbs", ItemTypes.DruidicFocus),
            new GeneralItem("Yew Wand", "10 gp", "1 lb", ItemTypes.DruidicFocus)
        };


        public static List<GeneralItem> HolySymbols { get; } = new List<GeneralItem>()
        {
            new GeneralItem("Amulet", "5 gp", "1 lb", ItemTypes.HolySymbol),
            new GeneralItem("Emblem", "5 gp", "-", ItemTypes.HolySymbol),
            new GeneralItem("Reliquary", "5 gp", "2 lbs", ItemTypes.HolySymbol)
        };


        public static List<GeneralItem> All { get; } = ConcatenateLists();


        public static int Count { get; } = All.Count;


        private static List<GeneralItem> ConcatenateLists()
        {
            List<GeneralItem> items = new List<GeneralItem>();
            items = items.Concat(GenItems).Concat(Ammunition).Concat(ArcaneFocui).Concat(DruidicFocui).Concat(HolySymbols).ToList();
            items.Sort((x, y) => x.Description.CompareTo(y.Description));
            return items;
        }
    }
}
