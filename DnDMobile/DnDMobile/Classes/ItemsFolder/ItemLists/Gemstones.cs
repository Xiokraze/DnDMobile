using System.Collections.Generic;
using System.Linq;

namespace DnDMobile.Classes.ItemsFolder.ItemLists
{
    class Gemstones
    {
        public static List<Gem> Gems10 { get; } = new List<Gem>()
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


        public static List<Gem> Gems50 = new List<Gem>()
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


        public static List<Gem> Gems100 = new List<Gem>()
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


        public static List<Gem> Gems500 = new List<Gem>()
        {
            new Gem("Alexandrite", "transparent dark green", StaticVariables.gp500),
            new Gem("Aquamarine", "transparent pale blue-green", StaticVariables.gp500),
            new Gem("Black Pearl", "opaque pure black", StaticVariables.gp500),
            new Gem("Blue Spinel", "transparent deep blue", StaticVariables.gp500),
            new Gem("Peridot", "transparent rich olive green", StaticVariables.gp500),
            new Gem("Topaz", "transparent golden yellow", StaticVariables.gp500)
        };


        public static List<Gem> Gems1000 = new List<Gem>()
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


        public static List<Gem> Gems5000 = new List<Gem>()
        {
            new Gem("Black Sapphire", "translucent lustrous black with glowing highlights", StaticVariables.gp5000),
            new Gem("Diamond", "transparent blue-white, canary, pink, brown, or blue", StaticVariables.gp5000),
            new Gem("Jacinth", "transparent fiery orange", StaticVariables.gp5000),
            new Gem("Ruby", "transparent clear red to deep crimson", StaticVariables.gp5000)
        };


        public static List<Gem> All { get; } = ConcatenateLists();


        public static int Count { get; } = All.Count;


        private static List<Gem> ConcatenateLists()
        {
            List<Gem> items = new List<Gem>();
            items = items.Concat(Gems10).Concat(Gems50).Concat(Gems100).Concat(Gems500).Concat(Gems1000).Concat(Gems5000).ToList();
            items.Sort((x, y) => x.Description.CompareTo(y.Description));
            return items;
        }
    }
}
