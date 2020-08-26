namespace DnDMobile.Classes
{
    class GeneralItem
    {
        public string Description { get; set; }
        public string Value { get; set; }
        public string Weight { get; set; }


        // Constructor.
        public GeneralItem(string description, string value, string weight)
        {
            this.Description = description;
            this.Value = value;
            this.Weight = weight;
        }
    }
}
