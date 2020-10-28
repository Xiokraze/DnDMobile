namespace DnDMobile.Classes.ItemsFolder
{
    public class Gem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }


        public Gem(string name, string description, string value)
        {
            this.Name = name;
            this.Description = description;
            this.Value = value;
        }
    }
}
