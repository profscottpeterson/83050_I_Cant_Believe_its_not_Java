using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICBINJPOSController
{
    public class Menu
    {
        public List<Item> icbinjMenu;

        public Menu()
        {
            // Temporary list to hold the menu.
            List<Item> tempList = new List<Item>();

            Item item = new Item("Coffee", 5.00);
            tempList.Add(item);

            item = new Item("Cappuccino", 3.00);
            tempList.Add(item);

            item = new Item("Tea", 3.00);
            tempList.Add(item);

            item = new Item("Espresso", 3.00);
            tempList.Add(item);

            item = new Item("Orange Juice", 4.00);
            tempList.Add(item);

            

            this.icbinjMenu = tempList;
        }
    }
}
