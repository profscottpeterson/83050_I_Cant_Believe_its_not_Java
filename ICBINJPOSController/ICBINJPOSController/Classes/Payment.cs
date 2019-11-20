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


        // Tracks current balance throughout transaction.
        private double currentBalance;

        public double CurrentBalance
        {
            get { return currentBalance; }
            set { currentBalance = value; }
        }



        // Amount recieved from customer.
        private double tendered;

        public double Tendered
        {
            get { return tendered; }
            set { tendered = value; }
        }



        // Cash collected from customer.
        private double totalCashCollected;

        public double TotalCashCollected
        {
            get { return totalCashCollected; }
            set { totalCashCollected = value; }
        }

        private double totalCreditCollected;

        public double TotalCreditCollected
        {
            get { return totalCreditCollected; }
            set { totalCreditCollected = value; }
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
