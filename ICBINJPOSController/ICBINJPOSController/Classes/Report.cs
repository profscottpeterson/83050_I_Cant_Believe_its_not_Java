using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            string path = @"UserReport.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(DateTime.Today);
                    sw.WriteLine("Current User: " + LoginScreen.userReport.ReportUser);
                    sw.WriteLine("Total Number of Transactions: " + LoginScreen.userReport.NumOfTransactions);
                    sw.WriteLine("Total Tax: " + LoginScreen.userReport.TotalTax);
                    sw.WriteLine("Total Cash Sales " + LoginScreen.userReport.TotalCashSales);
                    sw.WriteLine("Total Credit Sales: " + LoginScreen.userReport.TotalCreditSales);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(DateTime.Today);
                    sw.WriteLine("Current User: " + LoginScreen.userReport.ReportUser);
                    sw.WriteLine("Total Number of Transactions: " + LoginScreen.userReport.NumOfTransactions);
                    sw.WriteLine("Total Tax: " + LoginScreen.userReport.TotalTax);
                    sw.WriteLine("Total Cash Sales " + LoginScreen.userReport.TotalCashSales);
                    sw.WriteLine("Total Credit Sales: " + LoginScreen.userReport.TotalCreditSales);
                }

            }
        }
        public void PrintDailyReport()
        {
            string path = @"UserReport.txt";
            if (!File.Exists(path))
            {

                using (StreamWriter swrite = File.CreateText(path))
                {
                    swrite.WriteLine(DateTime.Today);
                    swrite.WriteLine("Total Number of Transactions: " + LoginScreen.dailyReport.NumOfTransactions);
                    swrite.WriteLine("Total Tax: " + LoginScreen.dailyReport.TotalTax);
                    swrite.WriteLine("Total Cash Sales " + LoginScreen.dailyReport.TotalCashSales);
                    swrite.WriteLine("Total Credit Sales: " + LoginScreen.dailyReport.TotalCreditSales);
                }
            }
            else
            {
                using (StreamWriter swrite = File.AppendText(path))
                {
                    swrite.WriteLine(DateTime.Today);
                    swrite.WriteLine("Total Number of Transactions: " + LoginScreen.dailyReport.NumOfTransactions);
                    swrite.WriteLine("Total Tax: " + LoginScreen.dailyReport.TotalTax);
                    swrite.WriteLine("Total Cash Sales " + LoginScreen.dailyReport.TotalCashSales);
                    swrite.WriteLine("Total Credit Sales: " + LoginScreen.dailyReport.TotalCreditSales);
                }

            }
        }
    }
}
