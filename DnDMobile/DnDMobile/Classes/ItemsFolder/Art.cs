namespace DnDMobile.Classes.ItemsFolder
{
    public class Art
    {
        public string Description { get; set; }
        public string Value { get; set; }

        public Art(string description, string value)
        {
            this.Description = description;
            this.Value = value;
        }
    }
}
