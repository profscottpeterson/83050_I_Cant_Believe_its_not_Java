
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

        User Users = new User();
        string empty = " ";



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
                    string[] entries = item.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                    itemLbx.Items.Add(entries[0] + ", " + entries[1] + ", " + entries[2] + ", " + entries[3]);

                }
            }
        }



        private void itemLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if index is selected in listbox
            if (itemLbx.SelectedIndex != -1)
            {
                string items = itemLbx.SelectedItem.ToString();
                string[] item = items.Split(",".ToCharArray());

                descLbl.Text = item[0].ToString();
                smallPriceTxt.Text = item[1].ToString();
                mediumPriceTxt.Text = item[2].ToString();
                largePriceTxt.Text = item[3].ToString();

                //string selection = itemLbx.Items[itemLbx.SelectedIndex].ToString();
                //descLbl.Text = selection.ToString();

            }
        }


        private void modifyItemBtn_Click(object sender, EventArgs e)
        {
            //if index is selected in listbox
            if (itemLbx.SelectedIndex != -1)
            {
                //write selected line to a variable & split line into delimited array
                string items = itemLbx.SelectedItem.ToString();
                string[] item = items.Split(",".ToCharArray());

                                    //** add textbox validations

                //write text box text to array indexes
                item[0] = descLbl.Text;
                item[1] = smallPriceTxt.Text;
                item[2] = mediumPriceTxt.Text;
                item[3] = largePriceTxt.Text;

                //write array entries to a string variable
                string newItems = item[0] + "," + item[1] + "," + item[2] + "," + item[3];
                itemLbx.Items.Insert(itemLbx.SelectedIndex, newItems);
                itemLbx.Items.RemoveAt(itemLbx.SelectedIndex);

            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to save changes to Drink Menu?";
            string title = "Save New Drink Menu!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                //clear text file 
                File.WriteAllText("DrinkMenu.txt", String.Empty);

                //write new list box contents to text file
                using (StreamWriter NewDrinkMenu = new StreamWriter("DrinkMenu.txt"))
                {
                    foreach (var line in itemLbx.Items)
                    {
                        NewDrinkMenu.WriteLine(line.ToString());
                    }
                }

                //changes saved message
                MessageBox.Show("Changes have been saved!");
            }
            else if(result == DialogResult.No)
            {
                //changes not saved message
                MessageBox.Show("Changes have not been saved!");

                //clear list box 
                itemLbx.Items.Clear();

                //open file and write unchanged drink menu to list box
                using (StreamReader itemStream = new StreamReader("DrinkMenu.txt"))
                {
                    string item;

                    while ((item = itemStream.ReadLine()) != null)
                    {
                        string[] entries = item.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                        itemLbx.Items.Add(entries[0] + ", " + entries[1] + ", " + entries[2] + ", " + entries[3]);

                    }
                }

                //clear text boxes
                descLbl.Text = empty.ToString();
                smallPriceTxt.Text = empty.ToString();
                mediumPriceTxt.Text = empty.ToString();
                largePriceTxt.Text = empty.ToString();

            }
        }

        private void clearTextBtn_Click(object sender, EventArgs e)
        {
            //clear text boxes
            descLbl.Text = empty.ToString();
            smallPriceTxt.Text = empty.ToString();
            mediumPriceTxt.Text = empty.ToString();
            largePriceTxt.Text = empty.ToString();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            //go back to options screen
            this.Hide();
            Users.GoBack();
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            //sign out & go back to login screen
            this.Hide();
            Users.SignOut();
        }
    }
}
