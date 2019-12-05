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

        // This method saves transactions to csv text file.
        public void SaveTransaction(bool isUser, string username, double tax, double cashSales, double creditSales)
        {

            string reportPath = "";

            if (isUser)
            {
                reportPath = @"" + username + "Transactions.txt";
            }
            else
            {
                reportPath = @"EODtransactions.txt";
            }

            // Append text creates the file if it doesn't already exist.
            using (StreamWriter sw = File.AppendText(reportPath))
            {
                // If this is a user report write username, otherwise ignore.
                if (isUser)
                {
                    sw.Write(username + ",");
                }
                else
                {
                    sw.Write(" ,");
                }
                
                sw.Write(tax.ToString() + ",");
                sw.Write(cashSales.ToString() + ",");
                sw.WriteLine(creditSales.ToString());
            }
        }

        public void ClearSavedTransactions(bool isUser, string username)
        {
            string transactionFile = "";

            if (isUser)
            {
                transactionFile = @"" + username + "Transactions.txt";
            }
            else
            {
                transactionFile = @"EODtransactions.txt";
            }

            if (File.Exists(transactionFile))
            {
                File.Delete(transactionFile);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Unable to clear transactions, file does not exist.");
            }

        }
        public void BuildReport(bool isUser, string username)
        {
            string path = "";

            if (isUser)
            {
                path = @"" + username + "Transactions.txt";
            }
            else
            {
                path = @"EODtransactions.txt";
            }

            try
            {
                using (StreamReader openFile = new StreamReader(path))
                {
                    // Holds each transaction line read from file.
                    string transaction;

                    // How many times the transaction line should be split.
                    int numOfSplits = 4;

                    // Holds each segment of the line.
                    string[] lineSegmentArray = new string[numOfSplits];

                    // Read a line of text from file if not empty and not end of stream.
                    while ((transaction = openFile.ReadLine()) != null || !openFile.EndOfStream)
                    {
                        // Split the line into an array. Uses a delimeter (,) char to split.
                        lineSegmentArray = transaction.Split(',');

                        // Read each value in the file to the class variables.

                        double parsedDouble = 0.00;

                        // Add Transaction to class vars
                        // read username if building a user report.
                        if (isUser && this.reportUser == "")
                        {
                            this.ReportUser = lineSegmentArray[0];
                        }

                        // Transaction value increases with each line read, for a count.
                        this.NumOfTransactions += 1;

                       
                        if (double.TryParse(lineSegmentArray[1], out parsedDouble))
                        {
                            this.TotalTax += parsedDouble;
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("Tax corrupted, seek administrator assistance.");
                        }


                        if (double.TryParse(lineSegmentArray[2], out parsedDouble))
                        {
                            this.TotalCashSales += parsedDouble;
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("Cash sales corrupted, seek administrator assistance.");
                        }


                        if (double.TryParse(lineSegmentArray[3], out parsedDouble))
                        {
                            this.TotalCreditSales += parsedDouble;
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("Credit sales corrupted, seek administrator assistance.");
                        }
                    }

                }
            }
            catch (IOException)
            {
                System.Windows.Forms.MessageBox.Show("User transaction file doesn't exist.");
            }
            catch (IndexOutOfRangeException)
            {
                System.Windows.Forms.MessageBox.Show("Transaction file corrupted, seek administrator assistance.");
            }
        }
       
        public void PrintReport(bool isUser, Report report)
        {
            string reportPath = "";

            if (isUser)
            {
                reportPath = @"" + report.reportUser + "Report.txt";
            }
            else
            {
                reportPath = @"EODreport.txt";
            }

            try
            {
                using (StreamWriter sw = File.AppendText(reportPath))
                {
                    // Write report values to file.
                    sw.WriteLine(DateTime.Today);
                    sw.WriteLine("Report ran by: " + User.employeeName);
                    if (isUser)
                    { sw.WriteLine("User: " + report.ReportUser); }
                    sw.WriteLine("Total Number of Transactions: " + report.NumOfTransactions);
                    sw.WriteLine("Total Tax: " + report.TotalTax);
                    sw.WriteLine("Total Cash Sales " + report.TotalCashSales);
                    sw.WriteLine("Total Credit Sales: " + report.TotalCreditSales);
                }
            }
            catch (IOException)
            {
                System.Windows.Forms.MessageBox.Show("Report failed, file write error.");
            }
        }
    }
}
