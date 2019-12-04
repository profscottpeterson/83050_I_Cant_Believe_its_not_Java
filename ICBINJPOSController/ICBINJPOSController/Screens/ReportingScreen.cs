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
        public ReportingScreen()
        {
            InitializeComponent();
        }

        private void userReportBtn_Click(object sender, EventArgs e)
        {
            // TODO
            // Select a user.
            string userSelected = userLbx.SelectedItem.ToString();



           
                                     
                // Find the user report file by standardized filename or User class variable.


                // Print to screen to simulate printing report?
            







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

            dailyTotalNumOfTransLabel.Visible = false;
            dailyTotalTaxLabel.Visible = false;
            dailyTotalCashSalesLabel.Visible = false;
            dailyTotalCreditSalesLabel.Visible = false;
        }

        private void dailyReportBtn_Click(object sender, EventArgs e)
        {
            dailyTotalNumOfTransLabel.Visible = true;
            dailyTotalTaxLabel.Visible = true;
            dailyTotalCashSalesLabel.Visible = true;
            dailyTotalCreditSalesLabel.Visible = true;

            dailyTotalNumOfTransLabel.Text = LoginScreen.dailyReport.NumOfTransactions.ToString();
            dailyTotalTaxLabel.Text = LoginScreen.dailyReport.TotalTax.ToString();
            dailyTotalCashSalesLabel.Text = LoginScreen.dailyReport.TotalCashSales.ToString();
            dailyTotalCreditSalesLabel.Text = LoginScreen.dailyReport.TotalCreditSales.ToString();
        }
    }
}
