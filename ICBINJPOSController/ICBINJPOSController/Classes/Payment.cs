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

        // Cash recieved from customer.
        private double cashRec;

        public double CashRec
        {
            get { return cashRec; }
            set { cashRec = value; }
        }

        // Cash due to customer.
        private double cashDue;

        public double CashDue
        {
            get { return cashDue; }
            set { cashDue = value; }
        }

        public double CalcCashDue()
        {    
            // Transaction.Total is static
            this.cashDue = Transaction.Total - this.cashRec;

            if (this.cashDue > 0)
            {
                this.OpenDrawer();
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
