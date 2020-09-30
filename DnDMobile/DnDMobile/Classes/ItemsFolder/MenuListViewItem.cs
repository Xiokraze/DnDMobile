using System;
using System.Collections.Generic;
using System.Text;

namespace DnDMobile.Classes.ItemsFolder
{
    class MenuListViewItem
    {
        public string Name { get; set; }
        public int Count { get; set; }

        public MenuListViewItem(string name, int count)
        {
            this.Name = name;
            this.Count = count;
        }
    }
}
