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

        public PaymentScreen()
        {
            InitializeComponent();
            this.lblBalance.Text = Transaction.Total.ToString("c");
            lblStillDue.Visible = false;
            
        }

        public void DisplayAmntDue(double amountPaid)
        {
            if (currentPayment.CalcCashDue(Transaction.Total, amountPaid) > 0)
            {
                lblStillDue.Visible = true;
                lblChangeSwitch.Visible = false;
            }
            else
            {
                lblChangeSwitch.Visible = true;
                lblStillDue.Visible = false;
            }
             
            lblDue.Text = currentPayment.CashDue.ToString("c");
        }

        private void btn5Dollars_Click(object sender, EventArgs e)
        {
            lblTendered.Text = "5.00";
            DisplayAmntDue(5);
        }

        private void btn10Dollars_Click(object sender, EventArgs e)
        {
            lblTendered.Text = "10.00";
            DisplayAmntDue(10);
        }

        private void btn20Dollars_Click(object sender, EventArgs e)
        {
            lblTendered.Text = "20.00";
            DisplayAmntDue(20);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblTendered.Text = "";
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            lblTendered.Text = "";
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnCredit_Click(object sender, EventArgs e)
        {

        }

        // User enters the amount of cash given with keypad, clicks cash, calculate change due.
        private void btnCash_Click(object sender, EventArgs e)
        {
            double amountPaid;

            if(double.TryParse(lblTendered.Text, out amountPaid))
            {
                this.DisplayAmntDue(amountPaid);
            }
            else
            {
                MessageBox.Show("Invalid tendered amount entered, try again.");
                lblTendered.Text = "";
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

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
