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
        Payment pay = new Payment();
        

        public PaymentScreen()
        {
            InitializeComponent();
        }

        private void PaymentScreen_Load(object sender, EventArgs e)
        {
            Payment.CurrentBalance = Transaction.Total;
            this.lblTotal.Text = Transaction.Total.ToString("c");
            this.lblBalanceDue.Text = Transaction.Total.ToString("n2");
            lblStillDue.Visible = false;
        }

        public void CalcCurrentBalance(double tendered, bool IsCash)
        {
            double beginningBal = Payment.CurrentBalance;
            Payment.CurrentBalance -= tendered;
            this.lblPayments.Text += String.Format("-" + tendered.ToString("n2") + "\n");

            // Paid in full, display change due to customer.
            if (Payment.CurrentBalance <= 0)
            {
                if (IsCash)
                {
                    // Keep a running total of cash collected.
                    pay.TotalCashCollected += beginningBal;
                    if (Payment.CurrentBalance <= 0)
                    {
                        pay.OpenDrawer();
                    }
                }
                else
                {
                    // Keep a running total of credit collected.
                    pay.TotalCreditCollected += Payment.CurrentBalance;
                }

                Payment.PaymentComplete = true;
                // Display the amount owed to customer.
                lblDue.Text = Payment.CurrentBalance.ToString("c");
               
                // Do not allow a cancelation when payment is processed.
                btnCancel.Enabled = false;
                // Hide still due label.
                lblStillDue.Visible = false;
                // Disable controls.
                btnCash.Enabled = false;
                btnCredit.Enabled = false;
                tbxTendered.Visible = false;
            }
            else
            {   // There is still a Balance Due 
                if (IsCash)
                {
                    // Keep a running total of cash collected.
                    pay.TotalCashCollected += tendered;
                }
                else
                {
                    // Keep a running total of credit collected.
                    pay.TotalCreditCollected += tendered;
                }

                //Still owe money message user.
                MessageBox.Show("A balance of " + Payment.CurrentBalance.ToString("c") + " is still owed.");

                lblBalanceDue.Text = Payment.CurrentBalance.ToString("n2");
                // Clear payment tender label
                tbxTendered.Text = "";
                tbxTendered.Focus();

                // Display Still Due warning label.
                lblStillDue.Visible = true;
            }
        }
        private void btn5Dollars_Click(object sender, EventArgs e)
        {
            tbxTendered.Text = "5.00";
            CalcCurrentBalance(5, true);
        }

        private void btn10Dollars_Click(object sender, EventArgs e)
        {
            tbxTendered.Text = "10.00";
            CalcCurrentBalance(10, true);
        }

        private void btn20Dollars_Click(object sender, EventArgs e)
        {
            tbxTendered.Text = "20.00";
            CalcCurrentBalance(20, true);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxTendered.Text = "";
        }

       
        private void btnCredit_Click(object sender, EventArgs e)
        {
            if (tbxTendered.Text == "")
            {
                Payment.Tendered = Payment.CurrentBalance;
                tbxTendered.Text = Payment.CurrentBalance.ToString("n2");
            }
            else
            {
                double parsedTenderAmnt = 0;
                double.TryParse(tbxTendered.Text, out parsedTenderAmnt);
                Payment.Tendered = parsedTenderAmnt;
            }

            // Display a new credit processing screen.
            CreditProcessing cpScreen = new CreditProcessing();
            cpScreen.ShowDialog();

            //If credit approved, add to credit totals.
            if (Payment.CreditSuccessful)
            {
                CalcCurrentBalance(Payment.Tendered, false);
                pay.TotalCreditCollected = Payment.Tendered;
            }
            else
            {
                // Credit Processing failed
                Payment.Tendered = 0;
                tbxTendered.Text = "";
            }
        }

        // User enters the amount of cash given with keypad, clicks cash, calculate change due.
        private void btnCash_Click(object sender, EventArgs e)
        {
            double amountPaid;

            if (double.TryParse(tbxTendered.Text, out amountPaid))
            {
                this.CalcCurrentBalance(amountPaid, true);
            }
            else
            {
                MessageBox.Show("Invalid tendered amount entered, try again.");
                tbxTendered.Text = "";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Deleting the last character in tendered label
            // by using .Remove to remove what is after the length
            // given in parathesis. If there is only one character long
            // it will clear the label
            string tempVar;
            tempVar = tbxTendered.Text;
            if (tempVar.Length <= 1)
            {
                tbxTendered.Text = "";
            }
            else
            {
                tempVar = tempVar.Remove(tempVar.Length - 1);
                tbxTendered.Text = tempVar;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (Payment.PaymentComplete)
            {
                this.Close();

                Report userTransactions = new Report();
                Report dailyTransactions = new Report();

                // Save Transaction information to  file.
                userTransactions.SaveTransaction(true, User.employeeName, Transaction.Tax, pay.TotalCashCollected, pay.TotalCreditCollected);
                dailyTransactions.SaveTransaction(false, "", Transaction.Tax, pay.TotalCashCollected, pay.TotalCreditCollected);
            }
            else
            {
                MessageBox.Show("There is still a balance of " + Payment.CurrentBalance.ToString("c") + " due.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbxTendered.Text += "1";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            tbxTendered.Text += "2";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            tbxTendered.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbxTendered.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbxTendered.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbxTendered.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbxTendered.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbxTendered.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbxTendered.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tbxTendered.Text += "0";
        }
        private void btnDecPt_Click(object sender, EventArgs e)
        {
            tbxTendered.Text += ".";
        }
    }
}
