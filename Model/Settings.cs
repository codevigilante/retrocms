using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Settings
    {
        public Site Site { get; set; }
        public Menu[] Menus { get; set; }

        public Menu GetMenuByLocation(string location)
        {
            foreach (Menu menu in Menus)
            {
                if (String.Compare(menu.Location, location, true) == 0)
                {
                    return (menu);
                }
            }

            return (null);
        }
    }
}
