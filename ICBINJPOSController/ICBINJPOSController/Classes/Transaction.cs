using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICBINJPOSController
{
    public class Transaction
    {
        /// <summary>
        /// This field is the current user.
        /// </summary>
        private User currentUser;
      
        public User CurrentUser
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

        public void SubTotal()
        {

        }

        public void CalcTax()
        {

        }

        public void CalcTotal()
        {

        }

        
    }
}