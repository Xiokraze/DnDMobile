using System.Collections.Generic;
using System.Linq;

namespace DnDMobile.Classes.ItemsFolder.ItemLists
{
    class Weapons
    {
        public static List<Weapon> SimpleMelee { get; } = new List<Weapon>
        {
            new Weapon("Club", "1 sp", "1d4 bludgeoning", "2 lbs", "Light", ItemTypes.SimpleMelee),
            new Weapon("Dagger", "2 gp", "1d4 piercing",  "1 lbs", "Finesse, Light, Thrown (range 20/60)", ItemTypes.SimpleMelee),
            new Weapon("Greatclub", "2 sp", "1d8 bludgeoning", "10 lbs", "Two-handed", ItemTypes.SimpleMelee),
            new Weapon("Handaxe", "5 gp", "1d6 slashing", "2 lbs", "Light, Thrown (range 20/60)", ItemTypes.SimpleMelee),
            new Weapon("Javelin", "5 sp", "1d6 piercing", "2 lbs", "Thrown (range 30/120)", ItemTypes.SimpleMelee),
            new Weapon("Light Hammer", "2 gp", "1d4 bludgeoning", "2 lbs", "Light, Thrown (range 20/60)", ItemTypes.SimpleMelee),
            new Weapon("Mace", "5 gp", "1d6 bludgeoning", "4 lbs",  "-", ItemTypes.SimpleMelee),
            new Weapon("Quarterstaff", "2 sp", "1d6 bludgeoning", "4 lbs", "Versatile (1d8)", ItemTypes.SimpleMelee),
            new Weapon("Sickle", "1 gp", "1d4 slashing", "2 lbs", "Light", ItemTypes.SimpleMelee),
            new Weapon("Spear", "1 gp", "1d6 piercing", "3 lbs", "Thrown (range 20/60), Versatile (1d8)", ItemTypes.SimpleMelee)
        };


        public static List<Weapon> SimpleRanged { get; } = new List<Weapon>
        {
            new Weapon("Crossbow, Light", "25 gp", "1d8 piercing", "5 lbs", "Ammunition (range 80/320), Loading, Two-handed", ItemTypes.SimpleRanged),
            new Weapon("Dart", "5 cp", "1d4 piercing", "1/4 lbs", "Finesse, Thrown (range 20/60)", ItemTypes.SimpleRanged),
            new Weapon("Shortbow", "25 gp", "1d6 piercing", "2 lbs", "Ammunition (range 80/320), Two-handed", ItemTypes.SimpleRanged),
            new Weapon("Sling", "1 sp", "1d4 bludgeoning", "-", "Ammunition (range 30/120)", ItemTypes.SimpleRanged)
        };


        public static List<Weapon> MartialMelee { get; } = new List<Weapon>
        {
            new Weapon("Battleaxe", "10 gp", "1d8 slashing", "4 lbs", "Versatile (1d10)", ItemTypes.MartialMelee),
            new Weapon("Flail", "10 gp", "1d8 bludgeoning", "2 lbs", "-", ItemTypes.MartialMelee),
            new Weapon("Glaive", "20 gp", "1d10 slashing", "6 lbs", "Heavy, Reach, Two-handed", ItemTypes.MartialMelee),
            new Weapon("Greataxe", "30 gp", "1d12 slashing", "7 lbs", "Heavy, Two-handed", ItemTypes.MartialMelee),
            new Weapon("Greatsword", "50 gp", "2d6 slashing", "6 lbs", "Heavy, Two-handed", ItemTypes.MartialMelee),
            new Weapon("Halberd", "20 gp", "1d10 slashing", "6 lbs", "Heavy, Reach, Two-handed", ItemTypes.MartialMelee),
            new Weapon("Lance", "10 gp", "1d12 piercing", "6 lbs", "Reach, Special", ItemTypes.MartialMelee),
            new Weapon("Longsword", "15 gp", "1d8 slashing", "3 lbs", "Versatile (1d10)", ItemTypes.MartialMelee),
            new Weapon("Maul", "10 gp", "2d6 bludgeoning", "10 lbs", "Heavy, Two-handed", ItemTypes.MartialMelee),
            new Weapon("Morningstar", "15 gp", "1d8 piercing", "4 lbs", "-", ItemTypes.MartialMelee),
            new Weapon("Pike", "5 gp", "1d10 piercing", "18 lbs", "Heavy, Reach, Two-handed", ItemTypes.MartialMelee),
            new Weapon("Rapier", "25 gp", "1d8 piercing", "2 lbs", "Finesse", ItemTypes.MartialMelee),
            new Weapon("Scimitar", "25 gp", "1d6 slashing", "3 lbs", "Finesse, Light", ItemTypes.MartialMelee),
            new Weapon("Shortsword", "10 gp", "1d6 piercing", "2 lbs", "Finesse, Light", ItemTypes.MartialMelee),
            new Weapon("Trident", "5 gp", "1d6 piercing", "4 lbs", "Thrown (range 20/60), Versatile (1d8)", ItemTypes.MartialMelee),
            new Weapon("War Pick", "5 gp", "1d8 piercing", "2 lbs", "-", ItemTypes.MartialMelee),
            new Weapon("Warhammer", "15 gp", "1d8 bludgeoning", "2 lbs", "Versatile (1d10)", ItemTypes.MartialMelee),
            new Weapon("Whip", "2 gp", "1d4 slashing", "3 lbs", "Finesse, Reach", ItemTypes.MartialMelee)
        };


        public static List<Weapon> MartialRanged { get; } = new List<Weapon>
        {
            new Weapon("Blowgun", "10 gp", "1 piercing", "1 lbs", "Ammunition (range 25/100), Loading", ItemTypes.MartialRanged),
            new Weapon("Crossbow, Hand", "75 gp", "1d6 piercing", "3 lbs", "Ammunition (range 30/120), Light, Loading", ItemTypes.MartialRanged),
            new Weapon("Crossbow, Heavy", "50 gp", "1d10 piercing", "18 lbs", "Ammunition (range 100/400), Heavy, Loading, Two-handed", ItemTypes.MartialRanged),
            new Weapon("Longbow", "50 gp", "1d8 piercing", "2 lbs", "Ammunition (range 150/600), Heavy, Two-handed", ItemTypes.MartialRanged),
            new Weapon("Net", "1 gp", "-", "3 lbs", "Special, Thrown (range 5/15)", ItemTypes.MartialRanged)
        };


        public static List<Weapon> All { get; } = ConcatenateLists();


        public static int Count { get; } = All.Count;


        private static List<Weapon> ConcatenateLists()
        {
            List<Weapon> items = new List<Weapon>();
            items = items.Concat(SimpleMelee).Concat(SimpleRanged).Concat(MartialMelee).Concat(MartialRanged).ToList();
            items.Sort((x, y) => x.Description.CompareTo(y.Description));
            return items;
        }
    }
}
