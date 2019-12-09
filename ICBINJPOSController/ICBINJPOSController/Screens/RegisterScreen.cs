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
    public partial class RegisterScreen : Form
    {
        // Fields go here
        private string currentDate = DateTime.Now.ToShortDateString();

        //TODO test
        private string currentUser;

        ////does this need to be am empty constant in order to hold the number up adding to it?
        private int currentTransNum = 1;

        private Transaction currentTransaction;

        private CoffeeShopMenu menu = new CoffeeShopMenu();
        private User Users = new User();

        // Holds string value of quantity button selected.
        private string strQuantity = ""; 

        // Holds final numeric quantity selected.
        private int quantitySelected = 1;
        
        // Holds the size selected by checkbox.
        private string sizeSelected = "";

        public RegisterScreen()
        {
            InitializeComponent();
        }

        public void OpenTransaction()
        {
            // Show current date.
            dateLbl.Text = currentDate;
            quantityLbl.Text = "1";
            this.currentUser = User.employeeName;

            // Show current user using static var.
            UsersNameLbl.Text = currentUser;

            //***Use currentUser field when ready.
            this.currentTransaction = new Transaction(DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), currentUser , currentTransNum);
          
        }

        // Close Transaction when payment is processed.
        public void CloseAndOpenNewTransaction()
        {
            ResetFields();
            ResetControls();
            this.currentTransaction = null;

            // Increase transaction number by one for next transaction.
            this.currentTransNum = currentTransNum + 1;
            
            //TODO test
            OpenTransaction();
            
        }

        public void ChangeQuantity(string quantityBtnText)
        {
            
            int tempQuantity;

            // Concatenate string quantity to allow values over 9.
            this.strQuantity = this.strQuantity + quantityBtnText;
            quantityLbl.Text = this.strQuantity;

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
                this.sizeSelected = "Med";
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
            // Returns a zero if price is not found.
            double price = 0;
            List<Item> tempMenu = this.menu.IcbinjMenu.ToList();
            
            // Find the item's price in the menu
            foreach (Item i in tempMenu)
            {
                if (i.Description == itemBtnSelected)
                {
                    // Modify menu price according to size.
                    if (sizeSelected == "Small")
                    {
                        price = i.PriceOptions[0] * quantity;
                      
                    }
                    else if (sizeSelected == "Medium")
                    {
                        price = i.PriceOptions[1] * quantity;
                        
                    }
                    else
                    {
                        // Large price
                        price = i.PriceOptions[2] * quantity;
                    }

                    break;
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
                        MessageBox.Show("Sorry item price not found, seek administrator's assistance.");
                    }
                    else
                    {
                        // Create an Item
                        Item lineItem = new Item(this.quantitySelected, buttonText, this.sizeSelected, itemPrice);

                        // Add the Item to the Order listbox.
                        OrderLbx.Items.Add(lineItem.Quantity.ToString() + " " + lineItem.Size + " " + lineItem.Description + "\t\t" + lineItem.Price.ToString("c"));

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

            // Reset field values.
            this.ResetFields();
            // Reset sizes.
            this.ResetRadioButtons();
            // Change quantity to default value.
            this.quantityLbl.Text = "1";
        }

        public void PrintReceipt()
        {
            // checks the existance of file and either creates it or updates it
            string path = @"Receipt.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter writer = File.CreateText(path))
                {
                    // writes receipt to text file

                    //write date, time, user, and transaction number to receipt
                    writer.WriteLine("Date: " + currentTransaction.TransDate + " " + currentTransaction.TransTime);
                    writer.WriteLine("Current User: " + currentTransaction.CurrentUser);
                    writer.WriteLine("Transaction: " + currentTransaction.TransNum);

                    //write order to receipt
                    foreach (var item in currentTransaction.Order)
                    {
                        writer.WriteLine(item.Quantity.ToString() + " " + item.Size + " " + item.Description + "\t\t" + item.Price.ToString("c"));
                    }

                    // checks to see if credit card was used then writes last four of card
                    if (Payment.CreditSuccessful == true)
                    {
                        writer.WriteLine("Payment via Credit Card:" + Payment.CreditCardNum);
                    }

                    // writes price info to receipt
                    writer.WriteLine("Subtotal: " + subtotalPriceLbl.Text + "  ||  " +
                                     "Taxes: " + taxPriceLbl.Text + "  ||  " +
                                     "Total: " + totalPriceLbl.Text);
                }

            }
            else
            {
                using (StreamWriter writer = File.AppendText(path))
                {
                    // writes receipt to text file

                    //write date, time, user, and transaction number to receipt
                    writer.WriteLine("Date: " + currentTransaction.TransDate + " " + currentTransaction.TransTime);
                    writer.WriteLine("Current User: " + currentTransaction.CurrentUser);
                    writer.WriteLine("Transaction: " + currentTransaction.TransNum);

                    //write order to receipt
                    foreach (var item in currentTransaction.Order)
                    {
                        writer.WriteLine(item.Quantity.ToString() + " " + item.Size + " " + item.Description + "\t\t" + item.Price.ToString("c"));
                    }

                    // checks to see if credit card was used then writes last four of card
                    if (Payment.CreditSuccessful == true)
                    {
                        writer.WriteLine("Payment via Credit Card:" + Payment.CreditCardNum);
                    }

                    // writes price info to receipt
                    writer.WriteLine("Subtotal: " + subtotalPriceLbl.Text + "  ||  " +
                                     "Taxes: " + taxPriceLbl.Text + "  ||  " +
                                     "Total: " + totalPriceLbl.Text);
                }
            }
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
            AddItemToOrder(waterBtn.Text);
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

        private void payBtn_Click(object sender, EventArgs e)
        {
            //TODO payment screen and processing
            PaymentScreen paymentScreen = new PaymentScreen();
            paymentScreen.ShowDialog();

            if (Payment.PaymentComplete)
            {
                // Sends Receipt to Text file
                PrintReceipt();

                // If payment is successfull close transaction.
                this.CloseAndOpenNewTransaction();
            }
            
            
        }

        private void voidBtn_Click(object sender, EventArgs e)
        {
            if (OrderLbx.SelectedIndex != -1)
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
            else
            {
                MessageBox.Show("Please select an item to void.");
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            // Open a new transaction, reset fields and controls.
            // Open transaction does not increase transaction number.
            this.OpenTransaction();
            this.ResetFields();
            this.ResetControls();
        }

        public void ResetFields()
        {
            // Reset field values.
            this.quantitySelected = 1;
            this.strQuantity = "";
            this.sizeSelected = "";
        }

        public void ResetRadioButtons()
        {
            this.largeRadioBtn.Checked = false;
            this.mediumRadioBtn.Checked = false;
            this.smallRadioBtn.Checked = false;
        }

        public void ResetControls()
        {
            //Reset RadioButtons
            this.ResetRadioButtons();

            // Reset Controls
            this.subtotalPriceLbl.Text = "";
            this.taxPriceLbl.Text = "";
            this.totalPriceLbl.Text = "";
            this.OrderLbx.Items.Clear();
            this.quantityLbl.Text = "";
        }



        private void vanillaBtn_Click(object sender, EventArgs e)
        {
            AddItemToOrder("Vanilla Flavor");
        }

        private void mochaBtn_Click(object sender, EventArgs e)
        {
            AddItemToOrder("Mocha Flavor");
        }

        private void caramelBtn_Click(object sender, EventArgs e)
        {
            AddItemToOrder("Caramel Flavor");
        }
        

        private void hazelnutBtn_Click(object sender, EventArgs e)
        {
            AddItemToOrder("Hazelnut Flavor");
        }

        private void strawberryBtn_Click(object sender, EventArgs e)
        {
            AddItemToOrder("Strawberry Flavor");
        }

        

        private void backButton_Click(object sender, EventArgs e)
        {
            //Go back to options screen
            this.Hide();
            Users.GoBack();
            
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            //sign out & go back to login screen
            this.Hide();
            Users.SignOut();
            
        }

        private void RegisterScreen_Load(object sender, EventArgs e)
        {
            // Start a new Transaction
            this.OpenTransaction();
        }
    }
}
