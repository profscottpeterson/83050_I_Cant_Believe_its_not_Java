using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICBINJPOSController
{
    public class Report
    {
        private int numOfTransactions;

        public int NumOfTransactions
        {
            get { return numOfTransactions; }
            set { numOfTransactions = value; }
        }

        private double totalCashSales;

        public double TotalCashSales
        {
            get { return totalCashSales; }
            set { totalCashSales = value; }
        }

        private double totalCreditSales;

        public double TotalCreditSales
        {
            get { return totalCreditSales; }
            set { totalCreditSales = value; }
        }

        private double totalTax;

        public double TotalTax
        {
            get { return totalTax; }
            set { totalTax = value; }
        }

        private string reportUser;

        public string ReportUser
        {
            get { return reportUser; }
            set { reportUser = value; }
        }



        public void RunUserReport()
        {
            
        }

        public void RunDailyReport()
        {

        }
        public void PrintUserReport()
        {
           
        }
        public void PrintDailyReport()
        {

        }
    }
}
