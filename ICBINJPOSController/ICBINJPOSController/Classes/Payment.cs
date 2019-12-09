using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICBINJPOSController
{
    public class Payment
    {
        // Holds last four digits of credit card, for receipt.
        private static string creditCardNum;

        public static string CreditCardNum
        {
            get { return creditCardNum; }
            set { creditCardNum = value; }
        }

        // Check if Credit Card processed successfully.
        private static bool creditSuccessful;

        public static bool CreditSuccessful
        {
            get { return creditSuccessful; }
            set { creditSuccessful = value; }
        }

        // Tracks current balance throughout transaction.
        private static double currentBalance;

        public static double CurrentBalance
        {
            get { return currentBalance; }
            set { currentBalance = value; }
        }

        // Amount recieved from customer.
        private static double tendered;

        public static double Tendered
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

        // Track if payment completed.
        private static bool paymentComplete;

        public static bool PaymentComplete
        {
            get { return paymentComplete; }
            set { paymentComplete = value; }
        }

        public Payment()
        {
           // Reset static values.
            creditCardNum = "";
            creditSuccessful = false;
            currentBalance = 0;
            tendered = 0;
            paymentComplete = false;
        }

        public void RunCreditCard()
        {
            // Check that credit card number and expiration date are valid.
        }

        public static void OpenDrawer()
        {
            // Open the register drawer.
            System.Windows.Forms.MessageBox.Show("Drawer Opened.");
        }
    }
}
