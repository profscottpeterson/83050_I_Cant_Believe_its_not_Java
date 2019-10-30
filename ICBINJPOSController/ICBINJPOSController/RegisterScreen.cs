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
    public partial class RegisterScreen : Form
    {
        // Fields go here
        string currentDate = DateTime.Now.ToShortDateString();
        int quantitySelected = 1;
        string sizeSelected = "";

        public RegisterScreen()
        {
            InitializeComponent();
           
            // Show current date.
            lblTodaysDate.Text = currentDate;
            // Show current user.
            lblCurrentUser.Text = User.UName;
        }



        
        
        public void OpenTransaction()
        {
            
        } 

        public void AddItem(string buttonText, double price)
        {
            CheckSize();
            
            double itemPrice = FindPrice(sizeSelected, price);

            Item item = new Item(quantitySelected, buttonText, sizeSelected, itemPrice);

            lbxOrder.Items.Add(item.Quantity.ToString() + " " + item.Size + " " + item.Description + "\t" + item.Price.ToString());
            // Empty field values.
            quantitySelected = 1;
            sizeSelected = "";
            
        }

        // Not sure this is needed. 10.29.19 DM
        public bool IsQuantitySelected (int quantitySelected)
        {   
            if (quantitySelected > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CheckSize()
        {
            if (rbSmall.Checked == true)
            {
                sizeSelected = rbSmall.Text;
            }
            else if (rbMed.Checked == true)
            {
                sizeSelected = rbMed.Text;
            }
            else if (rbLarge.Checked == true)
            {
                sizeSelected = rbLarge.Text;
            }
            else
            {
                // If a size isn't selected, message user.
                MessageBox.Show("Please select a size to proceed.");
            }
        }

        public double FindPrice(string sizeSelected, double price)
        {

            if (sizeSelected == "Small")
            {
                return price * .5;
            }
            else if (sizeSelected == "Medium")
            {
                return price * .75;
            }
            else 
            {
                return price;
            }
        }
        private void btnCoffee_Click(object sender, EventArgs e)
        {
            AddItem(btnCoffee.Text, 5.00);
        }
    }
}
