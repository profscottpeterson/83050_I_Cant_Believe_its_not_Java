using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ICBINJPOSController
{
    public partial class LoginScreen : Form
    {
        //open login screen
        public LoginScreen()
        {
            InitializeComponent();

            //hide password
            this.passWordTextBox.UseSystemPasswordChar = true;

            //display first index in combo box 
            AuthSelect.SelectedIndex = 0;
        }


        //lists to hold ID, Usernames and Passwords
        List<string> empID = new List<string>();
        List<string> empUserName = new List<string>();
        List<string> empPassWord = new List<string>();
        List<string> mgtID = new List<string>();
        List<string> mgtUserName = new List<string>();
        List<string> mgtPassWord = new List<string>();
        List<string> adminID = new List<string>();
        List<string> adminUserName = new List<string>();
        List<string> adminPassWord = new List<string>();


        //string to hold message box messages
        string msgtxt;


        //login screen
        private void LoginScreen_Load(object sender, EventArgs e)
        {
            try
            {
                //instantiate stream reader file
                StreamReader streamEmployee = new StreamReader("employeeAuth.txt");
                string emp = "";

                //read line emp, split each whitespace separated entry to an array & add to list
                while ((emp = streamEmployee.ReadLine()) != null)
                {
                    string[] entries = emp.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    empID.Add(entries[0]);
                    empUserName.Add(entries[1]);
                    empPassWord.Add(entries[2]);
                }


                //instantiate stream reader file
                StreamReader streamManagement = new StreamReader("managementAuth.txt");
                string mgt = "";

                //read line mgt, split each whitespace separated entry to an array & add to list
                while ((mgt = streamManagement.ReadLine()) != null)
                {
                    string[] entries = mgt.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    mgtID.Add(entries[0]);
                    mgtUserName.Add(entries[1]);
                    mgtPassWord.Add(entries[2]);
                }


                //instantiate stream reader file
                StreamReader streamAdministrator = new StreamReader("administratorAuth.txt");
                string admin = "";

                //read line admin, split each whitespace separated entry to an array & add to list
                while ((admin = streamAdministrator.ReadLine()) != null)
                {
                    string[] entries = admin.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    adminID.Add(entries[0]);
                    adminUserName.Add(entries[1]);
                    adminPassWord.Add(entries[2]);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }



        //login button functions
        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                //if employee username and password correct
                if (true) //(AuthSelect.SelectedIndex == 0 && empUserName.Contains(userNameTextBox.Text) && empPassWord.Contains(passWordTextBox.Text) && Array.IndexOf(empUserName.ToArray(), userNameTextBox.Text) == Array.IndexOf(empPassWord.ToArray(), passWordTextBox.Text))
                {
                    RegisterScreen registerScreen = new RegisterScreen();
                    MessageBox.Show("Successful Login!");
                    msgtxt = "Successful Login!";
                    this.Hide();
                    registerScreen.ShowDialog();


                    //login login attempt to loginHist.txt file
                    StreamWriter successHist = new StreamWriter("loginHist.txt", true);
                    successHist.WriteLine("*" + userNameTextBox.Text + " ," + passWordTextBox.Text + " ," + msgtxt + " - " + DateTime.Now);
                    successHist.Close();
                    this.userNameTextBox.Clear();
                    this.passWordTextBox.Clear();
                    this.userNameTextBox.Focus();
                }
                //if manager username and password correct
                else if (AuthSelect.SelectedIndex == 1 && mgtUserName.Contains(userNameTextBox.Text) && mgtPassWord.Contains(passWordTextBox.Text) && Array.IndexOf(mgtUserName.ToArray(), userNameTextBox.Text) == Array.IndexOf(mgtPassWord.ToArray(), passWordTextBox.Text))
                {
                    ReportingScreen reportingScreen = new ReportingScreen();
                    MessageBox.Show("Successful Login!");
                    msgtxt = "Successful Login!";
                    this.Hide();
                    reportingScreen.ShowDialog();


                    //login login attempt to loginHist.txt file
                    StreamWriter successHist = new StreamWriter("loginHist.txt", true);
                    successHist.WriteLine("*" + userNameTextBox.Text + " ," + passWordTextBox.Text + " ," + msgtxt + " - " + DateTime.Now);
                    successHist.Close();
                    this.userNameTextBox.Clear();
                    this.passWordTextBox.Clear();
                    this.userNameTextBox.Focus();
                }
                //if administrator username and password correct
                else if (AuthSelect.SelectedIndex == 2 && adminUserName.Contains(userNameTextBox.Text) && adminPassWord.Contains(passWordTextBox.Text) && Array.IndexOf(adminUserName.ToArray(), userNameTextBox.Text) == Array.IndexOf(adminPassWord.ToArray(), passWordTextBox.Text))
                {
                    OptionsScreen optionsScreen = new OptionsScreen();
                    MessageBox.Show("Successful Login!");
                    msgtxt = "Successful Login!";
                    this.Hide();
                    optionsScreen.ShowDialog();


                    //login login attempt to loginHist.txt file
                    StreamWriter successHist = new StreamWriter("loginHist.txt", true);
                    successHist.WriteLine("*" + userNameTextBox.Text + " ," + passWordTextBox.Text + " ," + msgtxt + " - " + DateTime.Now);
                    successHist.Close();
                    this.userNameTextBox.Clear();
                    this.passWordTextBox.Clear();
                    this.userNameTextBox.Focus();
                    
                }
                //if employee username or password incorrect
                else if (AuthSelect.SelectedIndex == 0 && (userNameTextBox.Text != "") || (passWordTextBox.Text != "") && Array.IndexOf(empUserName.ToArray(), userNameTextBox.Text) != Array.IndexOf(empPassWord.ToArray(), passWordTextBox.Text))
                {
                    MessageBox.Show("User Name and Password Incorrect!  Please Check and try again!");
                    msgtxt = "User Name and Password Incorrect!  Please Check and try again!";

                    //login login attempt to loginHist.txt file
                    StreamWriter incorrectHist = new StreamWriter("loginHist.txt", true);
                    incorrectHist.WriteLine("*" + userNameTextBox.Text + " ," + passWordTextBox.Text + " ," + msgtxt + " - " + DateTime.Now);
                    incorrectHist.Close();

                    this.userNameTextBox.Clear();
                    this.passWordTextBox.Clear();
                    this.userNameTextBox.Focus();
                }
                //if manager username or password incorrect
                else if (AuthSelect.SelectedIndex == 1 && (userNameTextBox.Text != "") || (passWordTextBox.Text != "") && Array.IndexOf(mgtUserName.ToArray(), userNameTextBox.Text) != Array.IndexOf(mgtPassWord.ToArray(), passWordTextBox.Text))
                {
                    MessageBox.Show("User Name and Password Incorrect!  Please Check and try again!");
                    msgtxt = "User Name and Password Incorrect!  Please Check and try again!";

                    //login login attempt to loginHist.txt file
                    StreamWriter incorrectHist = new StreamWriter("loginHist.txt", true);
                    incorrectHist.WriteLine("*" + userNameTextBox.Text + " ," + passWordTextBox.Text + " ," + msgtxt + " - " + DateTime.Now);
                    incorrectHist.Close();

                    this.userNameTextBox.Clear();
                    this.passWordTextBox.Clear();
                    this.userNameTextBox.Focus();
                }
                //if administrator username or password incorrect
                else if (AuthSelect.SelectedIndex == 2 && (userNameTextBox.Text != "") || (passWordTextBox.Text != "") && Array.IndexOf(adminUserName.ToArray(), userNameTextBox.Text) != Array.IndexOf(adminPassWord.ToArray(), passWordTextBox.Text))
                {
                    MessageBox.Show("User Name and Password Incorrect!  Please Check and try again!");
                    msgtxt = "User Name and Password Incorrect!  Please Check and try again!";

                    //login login attempt to loginHist.txt file
                    StreamWriter incorrectHist = new StreamWriter("loginHist.txt", true);
                    incorrectHist.WriteLine("*" + userNameTextBox.Text + " ," + passWordTextBox.Text + " ," + msgtxt + " - " + DateTime.Now);
                    incorrectHist.Close();

                    this.userNameTextBox.Clear();
                    this.passWordTextBox.Clear();
                    this.userNameTextBox.Focus();
                }
                //if username or password left blank
                else if ((userNameTextBox.Text == "") || (passWordTextBox.Text == ""))
                {
                    MessageBox.Show("Please Fill out both Username and Password Fields!");
                    msgtxt = "Please Fill out both Username and Password Fields!";

                    //login login attempt to loginHist.txt file
                    StreamWriter blankFormHist = new StreamWriter("loginHist.txt", true);
                    blankFormHist.WriteLine("*" + userNameTextBox.Text + " ," + passWordTextBox.Text + " ," + msgtxt + " - " + DateTime.Now);
                    blankFormHist.Close();

                    this.userNameTextBox.Clear();
                    this.passWordTextBox.Clear();
                    this.userNameTextBox.Focus();
                }

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }      
        }

        //clear button functions
        private void clearButton_Click(object sender, EventArgs e)
        {
            this.userNameTextBox.Clear();
            this.passWordTextBox.Clear();
            this.userNameTextBox.Focus();
        }
    }
}
