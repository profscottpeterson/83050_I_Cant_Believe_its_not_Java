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
    public partial class PaymentScreen : Form
    {
        Payment currentPayment = new Payment();
        bool paymentComplete = false;

        public PaymentScreen()
        {
            InitializeComponent();

            currentPayment.CurrentBalance = Transaction.Total;
            this.lblTotal.Text = Transaction.Total.ToString("c");
            lblStillDue.Visible = false;
            
        }

       // TODO OPEN DRAWER
        public void OpenDrawer()
        {
            MessageBox.Show("Drawer Opened.");
        }
           
        public void CalcCurrentBalance(double tendered, bool IsCash)
        {
            currentPayment.CurrentBalance -= tendered;
            
            // Paid in full, display change due to customer.
           
            if (currentPayment.CurrentBalance <= 0)
            {
                lblChangeSwitch.Visible = true;
                lblStillDue.Visible = false;
                paymentComplete = true;
                
                btnCash.Enabled = false;
                btnCredit.Enabled = false;
                
                // I want to change this, so more logical. So there can be cash and credit in same transaction. -DM
                currentPayment.TotalCashCollected = Transaction.Total;
            }

            // If there is still money due.
            else if (currentPayment.CurrentBalance > 0)
            { 
             
                //Still owe money message user.
                MessageBox.Show("A balance of " + currentPayment.CurrentBalance.ToString("c") + " is still owed.");

                lblBalanceDue.Text = currentPayment.CurrentBalance.ToString("c");

                // Display Still Due warning label.
                lblStillDue.Visible = true;
                lblChangeSwitch.Visible = false;

                // Clear payment tender label?
                
            }

            // Display the amount still owed by customer OR to customer.
            lblDue.Text = currentPayment.CurrentBalance.ToString("c");
        }

        private void btn5Dollars_Click(object sender, EventArgs e)
        {
            lblTendered.Text = "5.00";
            CalcCurrentBalance(5, true);
        }

        private void btn10Dollars_Click(object sender, EventArgs e)
        {
            lblTendered.Text = "10.00";
            CalcCurrentBalance(10, true);
        }

        private void btn20Dollars_Click(object sender, EventArgs e)
        {
            lblTendered.Text = "20.00";
            CalcCurrentBalance(20, true);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblTendered.Text = "";
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            if (paymentComplete)
            {
                this.Close();

                // Send a report of Transaction
                

            }
            else
            {
                MessageBox.Show("There is still a balance of " + currentPayment.CurrentBalance.ToString("c") + " due.");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            CreditProcessing cpScreen = new CreditProcessing();
            cpScreen.ShowDialog();
            //If credit approved, add to credit totals.
            if (true)
            {   
                // Change to that cash and credit can be in same Transaction.
                currentPayment.TotalCreditCollected = Transaction.Total;
            }
        }

        // User enters the amount of cash given with keypad, clicks cash, calculate change due.
        private void btnCash_Click(object sender, EventArgs e)
        {
            double amountPaid;

            if(double.TryParse(lblTendered.Text, out amountPaid))
            {
                this.CalcCurrentBalance(amountPaid, true);
            }
            else
            {
                MessageBox.Show("Invalid tendered amount entered, try again.");
                lblTendered.Text = "";
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Deleting the last character in tendered label
            // by using .Remove to remove what is after the length
            // given in parathesis. If there is only one character long
            // it will clear the label

            string tempVar;
            tempVar = lblTendered.Text;
            if (tempVar.Length <= 1)
            {
                lblTendered.Text = "";
            }
            else
            {
                tempVar = tempVar.Remove(tempVar.Length - 1);
                lblTendered.Text = tempVar;
            }


        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblTendered.Text += "1";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            lblTendered.Text += "2";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            lblTendered.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblTendered.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblTendered.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblTendered.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblTendered.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblTendered.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblTendered.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lblTendered.Text += "0";
        }
        private void btnDecPt_Click(object sender, EventArgs e)
        {
            lblTendered.Text += ".";
        }

        
    }
}
