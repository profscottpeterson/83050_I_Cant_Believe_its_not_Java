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
        private List<string> desc = new List<string>();
        public AdminScreen()
        {
            InitializeComponent();
        }

        private void AdminScreen_Load(object sender, EventArgs e)
        {
          
        }

        private void showItemsBtn_Click(object sender, EventArgs e)
        {
            using (StreamReader itemStream = new StreamReader("DrinkMenu.txt"))
            {
                string item = "";

                while ((item = itemStream.ReadLine()) != null && !itemStream.EndOfStream)
                {
                    string[] entries = item.Split(",".ToCharArray());

                    itemLbx.Items.Add(entries[0] + "    " + entries[1] + "  " + entries[2] + "  " + entries[3]);
                    
                }
            }
        }

        private void itemLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(itemLbx.SelectedIndex != -1)
            {
                //string selection = itemLbx.Items[itemLbx.SelectedIndex].ToString();
                //descLbl.Text = selection.ToString();
                
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
