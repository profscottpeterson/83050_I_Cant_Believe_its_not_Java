using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICBINJPOSController
{
    public class Transaction
    {
        private string transDate;

        public string TransDate
        {
            get { return transDate; }
            set { transDate = value; }
        }

        private string transTime;

        public string TransTime
        {
            get { return transTime; }
            set { transTime = value; }
        }


        /// <summary>
        /// This field is the current user.
        /// </summary>
        private string currentUser;

        public string CurrentUser
        {
            // ***Should this be read-only?***
            get { return currentUser; }
            set { currentUser = value; }
        }

        /// <summary>
        /// This field is the transaction number.
        /// </summary>
        private int transNum;

        public int TransNum
        {
            get { return transNum; }
            set { transNum = value; }
        }

        /// <summary>
        /// This field is a list of all items in an order.
        /// </summary>
        private List<Item> order;

        public List<Item> Order
        {
            get { return order; }
            set { order = value; }
        }

        private double subtotal;

        public double Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }

       
        // *** Is this correct way to set class var constants?
        public const double TaxRate = 0.055;
        

        private double tax;

        public double Tax
        {
            get { return tax; }
            set { tax = value; }
        }

        private static double total;

        public static double Total
        {
            get { return total; }
            set { total = value; }
        }
         
        public string CalcSubTotal()
        {
            this.Subtotal = this.Order.Sum(x => x.Price);
            return this.Subtotal.ToString("c");
        }

        public string CalcTax()
        {
            this.Tax = (this.Subtotal * Transaction.TaxRate);
            return this.Tax.ToString("c");
        }

        public string CalcTotal()
        {
            Total = (this.Subtotal + this.Tax);
            return Total.ToString("c");
        }

        public Transaction(string transDate, string transTime, string currentUser, int transNumber )
        {
            this.TransDate = transDate;
            this.TransTime = transTime;
            this.CurrentUser = currentUser;
            this.transNum = transNumber;
            this.Order = new List<Item>();
        }
    }
}