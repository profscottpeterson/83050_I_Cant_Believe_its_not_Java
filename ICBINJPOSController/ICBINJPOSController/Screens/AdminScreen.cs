using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICBINJPOSController
{
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
        }

        private CoffeeShopMenu Menu = new CoffeeShopMenu();

        private void AdminScreen_Load(object sender, EventArgs e)
        {
          
        }
       

        private void showItemsBtn_Click(object sender, EventArgs e)
        {
            List<Item> TempItems = this.Menu.IcbinjMenu.ToList();


            foreach(var i in TempItems)
            {
                itemLbx.Items.Add(i);
            }
        }

        private void modifyItemBtn_Click(object sender, EventArgs e)
        {

        }

        private void deleteItemBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
