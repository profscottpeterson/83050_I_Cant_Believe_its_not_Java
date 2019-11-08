using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICBINJPOSController
{
    public class Payment
    {
        // Not sure if its secure to have cc num in an object
        private int creditCardNum;

        public int CreditCardNum
        {
            get { return creditCardNum; }
            set { creditCardNum = value; }
        }

        public int Expiration { get; set; }

        // Amount recieved from customer.
        private double tendered;

        public double Tendered
        {
            get { return tendered; }
            set { tendered = value; }
        }

        // Cash due to customer.
        private double cashDue;

        public double CashDue
        {
            get { return cashDue; }
            set { cashDue = value; }
        }

        public double CalcCashDue(double transTotal, double tendered)
        {
            this.cashDue = transTotal - tendered;

            if (this.cashDue > 0)
            {
                //Still owe money message user.
                System.Windows.Forms.MessageBox.Show("A balance of " + this.cashDue.ToString("c") + " is still owed.");
                return this.cashDue;

            }
            else if (this.cashDue < 0)
            {
                this.OpenDrawer();
                return this.cashDue;

            }
            else
            {
                // No change due, don't open drawer.
                return this.cashDue;

            }
        }

        public void RunCreditCard()
        {
            // Check that credit card number and expiration date are valid.
        }

        public void OpenDrawer()
        {
            // Open the register drawer.
        }
    }
}
