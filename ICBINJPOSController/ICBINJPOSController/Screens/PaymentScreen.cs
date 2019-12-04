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
        bool paymentComplete = false;

        public PaymentScreen()
        {
            InitializeComponent();

            Payment.CurrentBalance = Transaction.Total;
            this.lblTotal.Text = Transaction.Total.ToString("c");
            this.lblBalanceDue.Text = Transaction.Total.ToString("c");
            lblStillDue.Visible = false;

        }

        public void CalcCurrentBalance(double tendered, bool IsCash)
        {
            double beginningBal = Payment.CurrentBalance;
            Payment.CurrentBalance -= tendered;
            this.lblPayments.Text += String.Format("\n-" + tendered.ToString("n2"));

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
                
                paymentComplete = true;
                // Display the amount owed to customer.
                lblDue.Text = Payment.CurrentBalance.ToString("c");

                btnCash.Enabled = false;
                btnCredit.Enabled = false;
                // Do not allow a cancelation when payment is processed.
                btnCancel.Enabled = false;
                
                lblChangeSwitch.Visible = true;
                lblStillDue.Visible = false;
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

                lblBalanceDue.Text = Payment.CurrentBalance.ToString("c");
                // Clear payment tender label
                lblTendered.Text = "";
                lblTendered.Focus();

                // Display Still Due warning label.
                lblStillDue.Visible = true;
                lblChangeSwitch.Visible = false;
            }
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
                    LoginScreen.dailyReport.NumOfTransactions += 1;
                    LoginScreen.dailyReport.TotalTax += Transaction.Tax;
                    LoginScreen.dailyReport.TotalCashSales += pay.TotalCashCollected;
                    LoginScreen.dailyReport.TotalCreditSales +=  pay.TotalCreditCollected;
                              
                    //***Assign dailyReport to user when they log out???
                    LoginScreen.userReport = LoginScreen.dailyReport;
                    LoginScreen.userReport.ReportUser = User.employeeName;



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

            private void btnCredit_Click(object sender, EventArgs e)
            {
                if(lblTendered.Text == "")
                {
                    Payment.Tendered = Payment.CurrentBalance;
                    lblTendered.Text = Payment.CurrentBalance.ToString();
                }
                else
                {
                    double parsedTenderAmnt = 0;
                    double.TryParse(lblTendered.Text, out parsedTenderAmnt);
                    Payment.Tendered = parsedTenderAmnt;
                }

                // Display a new credit processing screen.
                CreditProcessing cpScreen = new CreditProcessing();
                cpScreen.ShowDialog();

            //If credit approved, add to credit totals.
            if (Payment.CreditSuccessful)
            {
                CalcCurrentBalance(Payment.Tendered, false);
                //pay.TotalCreditCollected = Payment.Tendered;
            }
            else
            {
                // Credit Processing failed
                Payment.Tendered = 0;
                lblTendered.Text = "";
            }
            }

            // User enters the amount of cash given with keypad, clicks cash, calculate change due.
            private void btnCash_Click(object sender, EventArgs e)
            {
                double amountPaid;

                if (double.TryParse(lblTendered.Text, out amountPaid))
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

        private void PaymentScreen_Load(object sender, EventArgs e)
        {

        }
    }
    }
