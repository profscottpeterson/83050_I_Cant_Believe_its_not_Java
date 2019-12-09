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
        Report userReport;
        Report dailyReport;

        public ReportingScreen()
        {
            InitializeComponent();
        }

        private void ReportingScreen_Load(object sender, EventArgs e)
        {
            printUserReportBtn.Enabled = false;

            // Upon load of screen list employees to select from.
            using (StreamReader employees = new StreamReader("employeeAuth.txt"))
            {
                string fileLines = "";

                while (!employees.EndOfStream && (fileLines = employees.ReadLine()) != null)
                {
                    // Check for blank lines.
                    if (fileLines != null && fileLines != "")
                    {

                        // File delimeter is a space.
                        String[] lineSegment = fileLines.Split(' ');

                        // Add user name to listbox.
                        userLbx.Items.Add(lineSegment[1]);
                    }
                    else
                    {
                        fileLines.Skip(fileLines.Length);
                    }
                }
            }
        }

        private void userShowReportBtn_Click(object sender, EventArgs e)
        {
            userReport = new Report();
            if (userLbx.SelectedIndex != -1)
            {
                // Selected user.
                string userSelected = userLbx.SelectedItem.ToString();

                // Set the reports user.
                userReport.ReportUser = userSelected;
                // Build a report, filling report values from a file.
                if (userReport.BuildReport(true, userReport.ReportUser))
                {
                    // Display report variables to matching tbxs.
                    userLbl.Text = userReport.ReportUser;
                    userTotalNumOfTransLabel.Text = userReport.NumOfTransactions.ToString();
                    userTotalTaxLabel.Text = userReport.TotalTax.ToString("c");
                    userTotalCashSalesLabel.Text = userReport.TotalCashSales.ToString("c");
                    userTotalCreditSalesLabel.Text = userReport.TotalCreditSales.ToString("c");

                    userShowReportBtn.Enabled = false;
                    userLbx.Enabled = false;
                    printUserReportBtn.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Please select a user.");
            }
        }

        private void dailyShowReportBtn_Click(object sender, EventArgs e)
        {
            dailyReport = new Report();
            // Build a report, filling report values from a file.
            dailyReport.BuildReport(false, "");

            dailyTotalNumOfTransLabel.Text = dailyReport.NumOfTransactions.ToString();
            dailyTotalTaxLabel.Text = dailyReport.TotalTax.ToString("c");
            dailyTotalCashSalesLabel.Text = dailyReport.TotalCashSales.ToString("c");
            dailyTotalCreditSalesLabel.Text = dailyReport.TotalCreditSales.ToString("c");
        }

        private void printUserReportBtn_Click(object sender, EventArgs e)
        {
            if (userReport.PrintReport(true, userReport))
            {
                userReport.ClearSavedTransactions(true, userReport.ReportUser);
                userReport = null;
                ClearUserReportLabels();
                printUserReportBtn.Enabled = false;
                showDailyReportBtn.Enabled = false;
                clearBtn.Enabled = false;
            }
            else
            {
                MessageBox.Show("The file is empty, there are no new transactions to report.");
            }
        }

        private void printDailyReport_Click(object sender, EventArgs e)
        {
            if (dailyReport.PrintReport(false, dailyReport))
            {
                dailyReport.ClearSavedTransactions(false, "");
                ClearDailyReportLabels();
                dailyReport = null;
                printDailyReport.Enabled = false;
                showDailyReportBtn.Enabled = false;
            }
            else
            {
                MessageBox.Show("The file is empty, there are no new transactions to report.");
            }
        }

        private void clearUserBtn_Click(object sender, EventArgs e)
        {
            ClearUserReportLabels();
            userShowReportBtn.Enabled = true;
            userLbx.Enabled = true;
            userLbx.SelectedIndex = -1;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            // Clear out all daily reporting info on screen
            ClearDailyReportLabels();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OptionsScreen os = new OptionsScreen();
            os.ShowDialog();
        }

        public void ClearUserReportLabels()
        {
            userLbl.Text = "";
            userTotalNumOfTransLabel.Text = "";
            userTotalTaxLabel.Text = "";
            userTotalCashSalesLabel.Text = "";
            userTotalCreditSalesLabel.Text = "";
        }

        public void ClearDailyReportLabels()
        {
            dailyTotalNumOfTransLabel.Text = "";
            dailyTotalTaxLabel.Text = "";
            dailyTotalCashSalesLabel.Text = "";
            dailyTotalCreditSalesLabel.Text = "";
        }
    }
}
