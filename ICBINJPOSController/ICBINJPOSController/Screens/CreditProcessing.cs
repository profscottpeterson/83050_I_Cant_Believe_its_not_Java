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

        bool cardNumFinished = false;
        // Holds the credit card input from user.
        string userInput = "";

        public void EnterData(string input)
        {
            userInput += input;

            if (cardNumFinished == false)
            {
                tbxEnterCardNum.Text = userInput;

            }
            else
            {
                monthTbx.Text = userInput;
            }
        }

        private void tbxEnterCardNum_TextChanged(object sender, EventArgs e)
        {
            this.ActiveControl = tbxEnterCardNum;
            tbxEnterCardNum.Focus();

            if (tbxEnterCardNum.TextLength == 16)
            {
                userInput = "";
                MessageBox.Show("Please enter expiration date");
                cardNumFinished = true;
                monthTbx.Show();
                yearTbx.Show();
                monthTbx.Focus();
            }
        }

        private void tbxEnterExpiration_TextChanged(object sender, EventArgs e)
        {
            if (monthTbx.TextLength == 2)
            {
                // Int to hold month input by user.
                int userMonth = 0;

                int.TryParse(monthTbx.Text, out userMonth);
                if (userMonth > 0 && userMonth < 13)
                {
                    // Put focus on year tbx for user entry.
                    yearTbx.Focus();
                }
                else
                {
                    MessageBox.Show("Please enter a valid month, 01-12.");
                }
            }
        }

        private void CreditProcessing_Load(object sender, EventArgs e)
        {
            // Display the current Balance Being Charged to the card.
            lblTotalCharge.Text = Payment.Tendered.ToString("c");
            // Credit Card Number entered first so place focus on its tbx.
            tbxEnterCardNum.Focus();

            monthTbx.Hide();
            yearTbx.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (tbxEnterCardNum.TextLength < 17)
            {
                if (monthTbx.TextLength == 2 && yearTbx.TextLength == 2)
                {
                    // Holds the integer month the user entered.
                    int userMonth = 0;
                    // Holds the integer year the user entered.
                    int userYr = 0;

                    // Convert textbox strings to ints.
                    int.TryParse(monthTbx.Text, out userMonth);
                    int.TryParse(yearTbx.Text, out userYr);

                    // Find the days in the month selected for that year.
                    int daysInMonth = DateTime.DaysInMonth(userYr, userMonth);
                    string userDate = monthTbx.Text + "/" + daysInMonth + "/20" + yearTbx.Text;
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
                        MessageBox.Show("This card expired " + expDate.ToShortDateString() + " .\nPlease try a different payment method.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a two digit month and a two digit year.");
                }
            }
            else
            {
                MessageBox.Show("Please enter all 16 digits of the account number.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Payment.CreditSuccessful = false;
            ActiveForm.Close();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Deleting the last character in tendered label
            // by using .Remove to remove what is after the length
            // given in parathesis. If there is only one character long
            // it will clear the label
            
            string tempVar;
            if (tbxEnterCardNum.Focused)
            {
                tempVar = tbxEnterCardNum.Text;
                if (tempVar.Length <= 1)
                {
                    tbxEnterCardNum.Text = "";
                }
                else
                {
                    tempVar = tempVar.Remove(tempVar.Length - 1);
                    tbxEnterCardNum.Text = tempVar;
                }
            }
        }

        //private void tbxEnterCardNum_Click(object sender, EventArgs e)
        //{
         //   tbxEnterCardNum.Focus();
        //}

        //private void tbxEnterCardNum_KeyDown(object sender, KeyEventArgs e)
       // {
        //    tbxEnterCardNum.Focus();
        //}
    }
}
