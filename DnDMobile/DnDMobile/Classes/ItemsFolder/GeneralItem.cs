namespace DnDMobile.Classes.ItemsFolder
{
    class GeneralItem
    {
        public string Description { get; set; }
        public string Value { get; set; }
        public string Weight { get; set; }
        public string Classification { get; set; }


        // Constructor.
        public GeneralItem(string description, string value, string weight, string classification)
        {
            this.Description = description;
            this.Value = value;
            this.Weight = weight;
            this.Classification = classification;
        }
    }
}
