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
        private string currentDate = DateTime.Now.ToShortDateString();

        //TODO test
        private string currentUser = User.employeeName;

        ////does this need to be am empty constant in order to hold the number up adding to it?
        private int currentTransNum = 1;

        private Transaction currentTransaction;

        // Holds string value of quantity button selected.
        private string strQuantity = ""; 

        // Holds final numeric quantity selected.
        private int quantitySelected = 1;

        // Holds the size selected by checkbox.
        private string sizeSelected = "";

        public RegisterScreen()
        {

            InitializeComponent();

            // Show current date.
            UsersNameLbl.Text = currentDate;
            // Show current user using static var.
            //UsersNameLbl.Text = User.employeeName;

            OpenTransaction();
        }

        public void OpenTransaction()
        {
            //***This may not be necessary
            //***Use currentUser field when ready.
            this.currentTransaction = new Transaction(DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), currentUser , currentTransNum);
        }

        // Close Transaction when payment is processed.
        public void CloseTransaction()
        {
            // Increase transactoin number by one for next transaction.
            this.currentTransNum = currentTransNum + 1;
            this.currentUser = "";
            //TODO test
            this.currentTransaction = new Transaction(DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), currentUser, currentTransNum);
            OrderLbx.Items.Clear();
        }

        public void ChangeQuantity(string quantityBtnText)
        {
            // Added this so there is no longer an error.
            int tempQuantity;

            // Concatenate string quantity to allow values over 9.
            this.strQuantity = this.strQuantity + quantityBtnText;

            if (int.TryParse(this.strQuantity, out tempQuantity))
            {
                this.quantitySelected = tempQuantity;
            }
            else
            {
                // If string quantity can't be parsed, message user.
                MessageBox.Show("Invalid quantity please try again.");
            }
        }

        public bool CheckSize()
        {
            
            if (smallRadioBtn.Checked == true)
            {
                this.sizeSelected = smallRadioBtn.Text;
                return true;
            }
            else if (mediumRadioBtn.Checked == true)
            {
                this.sizeSelected = mediumRadioBtn.Text;
                return true;
            }
            else if (largeRadioBtn.Checked == true)
            {
                this.sizeSelected = largeRadioBtn.Text;
                return true;
            }
            else
            {
                // If a size isn't selected, message user.
                MessageBox.Show("Please select a size to proceed.");
                return false;
            }
        }

        public double FindPrice(string sizeSelected, int quantity, string itemBtnSelected)
        {
            double price = 0;
            Menu m = new Menu();

            // Find the item's price in the menu
            foreach (Item i in m.icbinjMenu)
            {
                if (itemBtnSelected == i.Description)
                {
                    // Modify menu price according to size.
                    if (sizeSelected == "Small")
                    {
                        price = i.Price * .5 * quantity;

                        // Checks to see if flavor is being used or not and adds 50 cents extra
                        if (FlavorsPanel.GetItemChecked(5))
                        {
                            // Does nothing but use as placeholder for no flavor choice
                        }
                        else
                        {
                            // Adds 50 cents for cost of flavor
                            price = price + .5;
                        }
                    }
                    else if (sizeSelected == "Medium")
                    {
                        price = i.Price * .75 * quantity;

                        // Checks to see if flavor is being used or not and adds 50 cents extra
                        if (FlavorsPanel.GetItemChecked(5))
                        {
                            // Does nothing but use as placeholder for no flavor choice
                        }
                        else
                        {
                            // Adds 50 cents for cost of flavor
                            price = price + .5;
                        }
                    }
                    else
                    {
                        // Large is equivilent to original menu price
                        price = i.Price * quantity;

                        // Checks to see if flavor is being used or not and adds 50 cents extra
                        if (FlavorsPanel.GetItemChecked(5))
                        {
                            // Does nothing but use as placeholder for no flavor choice
                        }
                        else
                        {
                            // Adds 50 cents for cost of flavor
                            price = price + .5;
                        }
                    }
                }
            }  

            // Return the adjusted price from menu. If item not found it will return zero. Check for zero, to indicate error.
            return price;
        }


        public void AddItemToOrder(string buttonText)
        {
            if (this.quantitySelected > 0)
            {

                if (this.CheckSize())
                {
                    // Find the price of the item selected.
                    double itemPrice = FindPrice(this.sizeSelected, this.quantitySelected, buttonText);

                    // If menu item is not found.
                    if (itemPrice == 0)
                    {
                        MessageBox.Show("Sorry item not found, seek administrator's assistance.");
                    }
                    else
                    {
                        // Create an Item
                        Item lineItem = new Item(this.quantitySelected, buttonText, this.sizeSelected, itemPrice);

                        // Add the Item to the Order listbox.
                        OrderLbx.Items.Add(lineItem.Quantity.ToString() + " " + lineItem.Size + " " + lineItem.Description + "\t" + lineItem.Price.ToString());

                        // Add line item price to Order list.
                        this.currentTransaction.Order.Add(lineItem);

                        this.Totals();

                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid quantity, must be larger than zero.");
            }

            // Empty field values.
            this.quantitySelected = 1;
            this.strQuantity = "";
            this.sizeSelected = "";
        }

        public void Totals()
        {
            // Call subtotal and display in label.
            subtotalPriceLbl.Text = this.currentTransaction.CalcSubTotal();

            // Calculate tax and display in label.
            taxPriceLbl.Text = this.currentTransaction.CalcTax();

            // Calculate Grand Total and display in label.
            totalPriceLbl.Text = this.currentTransaction.CalcTotal();
        }

        private void voidBtn_Click(object sender, EventArgs e)
        {
            // Variable to hold item selected, must store in var, because listbox order changes on removal.
            int currentSelection = OrderLbx.SelectedIndex;

            // Find the line item selected and remove it.
            OrderLbx.Items.RemoveAt(currentSelection);

            // Remove line item selected from current order.
            currentTransaction.Order.RemoveAt(currentSelection);

            // Subtract line item price to transaction subtotal.
            this.Totals(); 
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            //TODO payment screen and processing

            // If payment is successfull close transaction.
            this.CloseTransaction();

            // Open a new transaction.
            this.OpenTransaction();
        }

        private void cancelBtn_Click(object sender, EventArgs e)


        {
            //TODO TEST THAT ACUALLY CANCELED
           this.CloseTransaction();
            //// Removes all items from order listbox
            //OrderLbx.Items.Clear();

            //for(int x=0;x < currentTransaction.Order.Count; x++)
            //{
            //    currentTransaction.Order.RemoveAt(x);
            //}

            //// Return all values to $0.00
            //this.Totals();
        }


        private void qty1Btn_Click(object sender, EventArgs e)
        {
            ChangeQuantity("1");
        }

        private void qty2Btn_Click(object sender, EventArgs e)
        {
            ChangeQuantity("2");
        }

        private void qty3Btn_Click(object sender, EventArgs e)
        {
            ChangeQuantity("3");
        }

        private void qty4Btn_Click(object sender, EventArgs e)
        {
            ChangeQuantity("4");
        }

        private void qty5Btn_Click(object sender, EventArgs e)
        {
            ChangeQuantity("5");
        }

        private void qty6Btn_Click(object sender, EventArgs e)
        {
            ChangeQuantity("6");
        }

        private void qty7Btn_Click(object sender, EventArgs e)
        {
            ChangeQuantity("7");
        }

        private void qty8Btn_Click(object sender, EventArgs e)
        {
            ChangeQuantity("8");
        }

        private void qty9Btn_Click(object sender, EventArgs e)
        {
            ChangeQuantity("9");
        }

        private void qty0Btn_Click(object sender, EventArgs e)
        {
            ChangeQuantity("0");
        }

        private void coffeeBtn_Click(object sender, EventArgs e)
        {
            AddItemToOrder(coffeeBtn.Text);
        }

        private void cappuchinoBtn_Click(object sender, EventArgs e)
        {
            AddItemToOrder(cappuchinoBtn.Text);
        }
        private void teaBtn_Click(object sender, EventArgs e)
        {
            AddItemToOrder(teaBtn.Text);
        }

        private void espressoBtn_Click(object sender, EventArgs e)
        {
            AddItemToOrder(espressoBtn.Text);
        }

        private void cocoaBtn_Click(object sender, EventArgs e)
        {
            AddItemToOrder(cocoaBtn.Text);
        }

        private void chaiBtn_Click(object sender, EventArgs e)
        {
            AddItemToOrder(chaiBtn.Text);
        }

        private void icedCoffeeBtn_Click(object sender, EventArgs e)
        {
            AddItemToOrder(icedCoffeeBtn.Text);
        }

        private void smoothieBtn_Click(object sender, EventArgs e)
        {
            AddItemToOrder(smoothieBtn.Text);
        }

        private void icedTeaBtn_Click(object sender, EventArgs e)
        {
            AddItemToOrder(icedTeaBtn.Text);
        }

        private void frappuchinoBtn_Click(object sender, EventArgs e)
        {
            AddItemToOrder(frappuchinoBtn.Text);
        }

        private void refresherBtn_Click(object sender, EventArgs e)
        {
            AddItemToOrder(refresherBtn.Text);
        }

        private void milkBtn_Click(object sender, EventArgs e)
        {
            AddItemToOrder(milkBtn.Text);
        }

        private void waterBtn_Click(object sender, EventArgs e)
        {
            AddItemToOrder(coffeeBtn.Text);
        }

        private void pepsiBtn_Click(object sender, EventArgs e)
        {
            AddItemToOrder(pepsiBtn.Text);
        }

        private void cokeBtn_Click(object sender, EventArgs e)
        {
            AddItemToOrder(cokeBtn.Text);
        }

        private void sevenUpBtn_Click(object sender, EventArgs e)
        {
            AddItemToOrder(sevenUpBtn.Text);
        }

        private void muscleMilkBtn_Click(object sender, EventArgs e)
        {
            AddItemToOrder(muscleMilkBtn.Text);
        }

        private void orangeJuiceBtn_Click(object sender, EventArgs e)
        {
            AddItemToOrder(orangeJuiceBtn.Text);
        }

        private void RegisterScreen_Load(object sender, EventArgs e)
        {

        }
    }


}
