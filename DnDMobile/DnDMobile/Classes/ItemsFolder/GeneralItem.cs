namespace DnDMobile.Classes.ItemsFolder
{
    public class GeneralItem
    {
        public string Description { get; set; }
        public string Value { get; set; }
        public string Weight { get; set; }
        public string Type { get; set; }


        // Constructor.
        public GeneralItem(string description, string value, string weight, string type)
        {
            this.Description = description;
            this.Value = value;
            this.Weight = weight;
            this.Type = type;
        }
    }
}
