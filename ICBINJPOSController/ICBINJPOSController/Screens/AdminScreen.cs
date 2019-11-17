using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ICBINJPOSController
{
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
        }

        private void AdminScreen_Load(object sender, EventArgs e)
        {
            //disable buttons until future use
            deleteItemBtn.Enabled = false;
            deleteItemBtn.BackColor = Color.RosyBrown;
            addItemBtn.Enabled = false;
            addItemBtn.BackColor = Color.RosyBrown;

            //open file and write to list box
            using (StreamReader itemStream = new StreamReader("DrinkMenu.txt"))
            {
                string item;

                while ((item = itemStream.ReadLine()) != null)
                {
                    string[] entries = item.Split(",".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);

                    itemLbx.Items.Add(entries[0] + ", " + entries[1] + ", " + entries[2] + ", " + entries[3]);

                }
            }
        }

     

        private void itemLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(itemLbx.SelectedIndex != -1)
            {
                string items = itemLbx.SelectedItem.ToString();
                string[] item = items.Split(",".ToCharArray());

                descLbl.Text = item[0];
                smallPriceTxt.Text = item[1].ToString();
                mediumPriceTxt.Text = item[2].ToString();
                largePriceTxt.Text = item[3].ToString();

                //string selection = itemLbx.Items[itemLbx.SelectedIndex].ToString();
                //descLbl.Text = selection.ToString();
             
            }
        }

        private void modifyItemBtn_Click(object sender, EventArgs e)
        {
            //clear list box
            itemLbx.Items.Clear();

            if (itemLbx.SelectedIndex != -1)
            {
                string items = itemLbx.SelectedItem.ToString();
                string[] item = items.Split(",".ToCharArray());

                //item[0] = descLbl.Text;
                //item[1] = smallPriceTxt.Text;
                //item[2] = mediumPriceTxt.Text;
                //item[3] = largePriceTxt.Text;

                //string selection = itemLbx.Items[itemLbx.SelectedIndex].ToString();
                //descLbl.Text = selection.ToString();

            }
        }
    }
}
