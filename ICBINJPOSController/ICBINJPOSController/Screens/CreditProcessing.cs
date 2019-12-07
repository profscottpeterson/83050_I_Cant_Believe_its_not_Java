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
    public partial class CreditProcessing : Form
    {
        public CreditProcessing()
        {
            InitializeComponent();
        }

        bool cardNumFinished, monthFinished = false;
        // Holds the credit card input from user.
        string userInput = "";

        private void CreditProcessing_Load(object sender, EventArgs e)
        {
            // Display the current Balance Being Charged to the card.
            lblTotalCharge.Text = Payment.Tendered.ToString("c");
            // Credit Card Number entered first so place focus on its tbx.
            tbxEnterCardNum.Focus();
        }
        
        public void EnterData(string input)
        {
            userInput += input;

            if (cardNumFinished == false)
            {
                tbxEnterCardNum.Text = userInput;

            }
            else if (monthFinished == false)
            {
                tbxMonth.Text = userInput;
            }
            else
            {
                tbxYear.Text = userInput;
            }
        }

        private void tbxEnterCardNum_TextChanged(object sender, EventArgs e)
        {
            // Remove invalid characters.
            string tempCC = tbxEnterCardNum.Text.Replace(".|,|-", "");
            tbxEnterCardNum.Text = tempCC;

            // Make sure the CC is 16 digits long.
            if (tempCC.Length == 16)
            {
                double tempCardNum;

                if (double.TryParse(tbxEnterCardNum.Text, out tempCardNum))
                {
                    userInput = "";
                    MessageBox.Show("Please enter expiration date");
                    cardNumFinished = true;
                    tbxMonth.Focus();
                }
                else
                {
                    MessageBox.Show("Only enter numeric values.");
                    tbxEnterCardNum.Text = "";
                }
            }
        }

        private void tbxMonth_TextChanged(object sender, EventArgs e)
        {
            if (tbxMonth.TextLength == 2)
            {
                // Int to hold month input by user.
                int userMonth = 0;

                if (int.TryParse(tbxMonth.Text, out userMonth))
                {
                    if (userMonth > 0 && userMonth < 13)
                    {
                        monthFinished = true;

                        // Put focus on year tbx for user entry.
                        tbxYear.Focus();

                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid month, 01-12.");
                        tbxMonth.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Only enter numeric values.");
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (tbxEnterCardNum.TextLength < 17)
            {
                if (tbxMonth.TextLength == 2 && tbxYear.TextLength == 2)
                {
                    // Holds the integer month the user entered.
                    int userMonth = 0;
                    // Holds the integer year the user entered.
                    int userYr = 0;

                    // Convert textbox strings to ints.
                    int.TryParse(tbxMonth.Text, out userMonth);
                    int.TryParse(tbxYear.Text, out userYr);

                    // Find the days in the month selected for that year.
                    int daysInMonth = DateTime.DaysInMonth(userYr, userMonth);
                    string userDate = tbxMonth.Text + "/" + daysInMonth + "/20" + tbxYear.Text;
                    DateTime expDate = Convert.ToDateTime(userDate);

                    DateTime.TryParse(userDate, out expDate);

                    if (expDate >= DateTime.Today)
                    {
                        MessageBox.Show("Successful Transaction.");
                        Payment.CreditSuccessful = true;

                        // Get the last four chars of the credit card number.
                        string last4CreditCard = tbxEnterCardNum.Text.Remove(0, 12);
                        Payment.CreditCardNum = last4CreditCard;

                        ActiveForm.Close();
                    }
                    else
                    {
                        MessageBox.Show(this, "This card expired " + expDate.ToShortDateString() + " .\nPlease try a different payment method.");
                        tbxMonth.Text = "";
                        tbxYear.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a two digit month and a two digit year.");
                }
            }
            else
            {
                MessageBox.Show(this, "Please enter all 16 digits of the account number.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Payment.CreditSuccessful = false;
            ActiveForm.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxEnterCardNum.Text = "";
            tbxMonth.Text = "";
            tbxYear.Text = "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            EnterData("1");
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            EnterData("2");
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            EnterData("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            EnterData("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            EnterData("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            EnterData("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            EnterData("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            EnterData("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            EnterData("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            EnterData("0");
        }


        private void btnDecPt_Click(object sender, EventArgs e)
        {
            EnterData(".");
        }
    }
}
