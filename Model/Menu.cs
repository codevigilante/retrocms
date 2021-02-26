using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Menu
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public MenuItem[] Items { get; set; }
    }
}
