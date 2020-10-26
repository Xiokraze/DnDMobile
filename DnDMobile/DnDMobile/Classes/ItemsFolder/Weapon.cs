namespace DnDMobile.Classes.ItemsFolder
{
    public class Weapon
    {
        public string Description { get; set; }
        public string Value { get; set; }
        public string Damage { get; set; }
        public string Weight { get; set; }
        public string Properties { get; set; }
        public string Type { get; set; }


        // Constructor.
        public Weapon(string description, string value, string damage, string weight, string properties, string type)
        {
            this.Description = description;
            this.Value = value;
            this.Damage = damage;
            this.Weight = weight;
            this.Properties = properties;
            this.Type = type;
        }
    }
}
