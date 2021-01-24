using System.Collections.Generic;
using System.Linq;

namespace DnDMobile.Classes.ItemsFolder.ItemLists
{
    class ArtList
    {
        public static List<Art> Art25 { get; } = new List<Art>()
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


        public static List<Art> Art250 { get; } = new List<Art>()
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


        public static List<Art> Art750 { get; } = new List<Art>()
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


        public static List<Art> Art2500 { get; } = new List<Art>()
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


        public static List<Art> Art7500 { get; } = new List<Art>()
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


        public static List<Art> All { get; } = ConcatenateLists();


        public static int Count { get; } = All.Count;


        private static List<Art> ConcatenateLists()
        {
            List<Art> items = new List<Art>();
            items = items.Concat(Art25).Concat(Art250).Concat(Art750).Concat(Art2500).Concat(Art7500).ToList();
            items.Sort((x, y) => x.Description.CompareTo(y.Description));
            return items;
        }
    }
}
