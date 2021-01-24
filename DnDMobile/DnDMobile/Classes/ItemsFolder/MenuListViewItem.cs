namespace DnDMobile.Classes.ItemsFolder
{
    class MenuListViewItem
    {
        public string Name { get; }
        public int Count { get; }
        public MenuOptions Type { get; }

        public MenuListViewItem(string name, MenuOptions type)
        {
            this.Name = name;
            this.Type = type;
        }

        public MenuListViewItem(string name, int count)
        {
            this.Name = name;
            this.Count = count;
        }

        public MenuListViewItem(string name, int count, MenuOptions type)
        {
            this.Name = name;
            this.Count = count;
            this.Type = type;
        }
    }
}
