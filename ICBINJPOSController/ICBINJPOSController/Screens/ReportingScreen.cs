using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICBINJPOSController
{
    public partial class ReportingScreen : Form
    {   
        // Report fields to hold built report values.
        Report dailyReport = new Report();
        Report userReport = new Report();

        public ReportingScreen()
        {
            InitializeComponent();
        }

        private void ReportingScreen_Load(object sender, EventArgs e)
        {
            // Upon load of screen list employees to select from.
            using (StreamReader employees = new StreamReader("employeeAuth.txt"))
            {
                string fileLines = "";

                while ((fileLines = employees.ReadLine()) != null && !employees.EndOfStream)
                {
                    // File delimeter is a space.
                    String[] lineSegment = fileLines.Split(' ');

                    // Add user name to listbox.
                    userLbx.Items.Add(lineSegment[1]);
                }
            }

        }

        private void userShowReportBtn_Click(object sender, EventArgs e)
        {
            if (userLbx.SelectedIndex != -1)
            {
                // Selected user.
                string userSelected = userLbx.SelectedItem.ToString();

                // Set the reports user.
                userReport.ReportUser = userSelected;
                // Build a report, filling report values from a file.
                userReport.BuildReport(true, userReport.ReportUser);
                

                // Display report variables to matching tbxs.
                currentUserLabel.Text = userReport.ReportUser;
                userTotalNumOfTransLabel.Text = userReport.NumOfTransactions.ToString();
                userTotalTaxLabel.Text = userReport.TotalTax.ToString();
                userTotalCashSalesLabel.Text = userReport.TotalCashSales.ToString();
                userTotalCreditSalesLabel.Text = userReport.TotalCreditSales.ToString();
            }
            else
            {
                MessageBox.Show("Please select a user.");
            }
        }

        private void dailyShowReportBtn_Click(object sender, EventArgs e)                            
        {

            // Build a report, filling report values from a file.
            dailyReport.BuildReport(false, "");

            dailyTotalNumOfTransLabel.Text = dailyReport.NumOfTransactions.ToString();
            dailyTotalTaxLabel.Text = dailyReport.TotalTax.ToString();
            dailyTotalCashSalesLabel.Text = dailyReport.TotalCashSales.ToString();
            dailyTotalCreditSalesLabel.Text = dailyReport.TotalCreditSales.ToString();
        }

        private void printUserReportBtn_Click(object sender, EventArgs e)
        {
            userReport.PrintReport(true, userReport);
            userReport.ClearSavedTransactions(true, userReport.ReportUser);
            userReport = null;
            
        }

        private void printDailyReport_Click(object sender, EventArgs e)
        {
            dailyReport.PrintReport(false, dailyReport);
            dailyReport.ClearSavedTransactions(false, "");
            dailyReport = null;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            //clear out all reporting info on screen
            currentUserLabel.Text = "   ";
            userTotalNumOfTransLabel.Text = "   ";
            userTotalTaxLabel.Text = "   ";
            userTotalCashSalesLabel.Text = "   ";
            userTotalCreditSalesLabel.Text = "   ";

            dailyTotalNumOfTransLabel.Text = "   ";
            dailyTotalTaxLabel.Text = "   ";
            dailyTotalCashSalesLabel.Text = "   ";
            dailyTotalCreditSalesLabel.Text = "   ";

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OptionsScreen os = new OptionsScreen();
            os.ShowDialog();
        }

    }
}
