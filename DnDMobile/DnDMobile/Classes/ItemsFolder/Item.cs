namespace DnDMobile.Classes.ItemsFolder
{
    public class Item
    {
        public string Description { get; protected set; }
        public string Value { get; protected set; }

        public Item(string descr, string value)
        {
            this.Description = descr;
            this.Value = value;
        }
    }


    public class Art : Item
    { 
        public Art(string descr, string value) : base(descr, value)
        {
            this.Description = descr;
            this.Value = value;
        }
    }


    public class Gem : Item
    {
        public string Name { get; protected set; }

        public Gem(string name, string descr, string value) : base(descr, value)
        {
            this.Name = name;
            this.Description = descr;
            this.Value = value;
        }
    }


    public class GeneralItem : Item
    {
        public string Weight { get; protected set; }
        public ItemType Type { get; protected set; }
        public GeneralItem(string descr, string value, string weight, ItemType type) : base(descr, value)
        {
            this.Description = descr;
            this.Value = value;
            this.Weight = weight;
            this.Type = type;
        }
    }


    public class Weapon : GeneralItem
    {
        public string Damage { get; protected set; }
        public string Properties { get; protected set; }
        public Weapon(string descr, string value, string dmg, string weight, string properties, ItemType type) : base(descr, value, weight, type)
        {
            this.Description = descr;
            this.Value = value;
            this.Damage = dmg;
            this.Weight = weight;
            this.Properties = properties;
            this.Type = type;
        }
    }


    public class Armor : GeneralItem
    {
        public string ArmorClass { get; protected set; }
        public string RequiredStrength { get; protected set; }
        public string StealthImpact { get; protected set; }
        public Armor(string descr, string value, string ac, string str, string stealth, string weight, ItemType type) : base(descr, value, weight, type)
        {
            this.Description = descr;
            this.Value = value;
            this.ArmorClass = ac;
            this.RequiredStrength = str;
            this.StealthImpact = stealth;
            this.Weight = weight;
            this.Type = type;
        }
    }
}
