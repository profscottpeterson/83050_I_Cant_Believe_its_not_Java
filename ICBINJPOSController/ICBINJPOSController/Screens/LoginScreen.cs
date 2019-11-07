using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICBINJPOSController
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();

        }


        //login screen
        private void LoginScreen_Load(object sender, EventArgs e)
        {
            //hide password
            this.passWordTextBox.UseSystemPasswordChar = true;

            //display first index in combo box 
            AuthSelect.SelectedIndex = 0;
        }


        //login button functions
        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Instance of new screens
            LoginScreen loginScreen = new LoginScreen();
            RegisterScreen registerScreen = new RegisterScreen();
            OptionsScreen optionsScreen = new OptionsScreen();
            ReportingScreen reportingScreen = new ReportingScreen();

            //instances of User and File classes
            User Users = new User();
            File Files = new File();

            try
            {   
                //Cashier login validation
                if(AuthSelect.SelectedIndex == 0)
                {
                    //***REMOVE, JUST ADDED FOR EASE OF USE
                    Users.employeeLoggedIn = true;

                    //Pass text box text into variable, open file, pass username & passwork into method
                    User.employeeName = userNameTextBox.Text;
                    User.employeePass = passWordTextBox.Text;
                    Files.OpenEmpFile();
                    Users.EmployeeLogin(User.employeeName, User.employeePass);
                    
                    if (Users.employeeLoggedIn == true)
                    {
                        MessageBox.Show("Successful Login!");
                        loginScreen.Hide();
                        registerScreen.ShowDialog();
                        this.userNameTextBox.Clear();
                        this.passWordTextBox.Clear();
                        this.userNameTextBox.Focus();
                    }
                    else if (Users.loginIncorrect == true)
                    {
                        MessageBox.Show("User Name and Password Incorrect!  Please Check and try again!");
                        Users.employeeLoggedIn = false;
                        this.userNameTextBox.Clear();
                        this.passWordTextBox.Clear();
                        this.userNameTextBox.Focus();
                    }  
                    else if (Users.loginBlank == true)
                    {
                        MessageBox.Show("Please Fill out both Username and Password Fields!");
                        Users.employeeLoggedIn = false;
                        this.userNameTextBox.Clear();
                        this.passWordTextBox.Clear();
                        this.userNameTextBox.Focus();
                    }
                }

                //Manager login validation
                if (AuthSelect.SelectedIndex == 1)
                {
                    //Pass text box text into variable, open file, pass username & passwork into method
                    User.managerName = userNameTextBox.Text;
                    User.managerPass = passWordTextBox.Text;
                    Files.OpenMgtFile();
                    Users.ManagerLogin(User.managerName, User.managerPass);

                    if (Users.managerLoggedIn == true)
                    {
                        MessageBox.Show("Successful Login!");
                        loginScreen.Hide();
                        reportingScreen.ShowDialog();
                        this.userNameTextBox.Clear();
                        this.passWordTextBox.Clear();
                        this.userNameTextBox.Focus();
                    }
                    else if (Users.loginIncorrect == true)
                    {
                        MessageBox.Show("User Name and Password Incorrect!  Please Check and try again!");
                        Users.managerLoggedIn = false;
                        this.userNameTextBox.Clear();
                        this.passWordTextBox.Clear();
                        this.userNameTextBox.Focus();
                    }
                    else if (Users.loginBlank == true)
                    {
                        MessageBox.Show("Please Fill out both Username and Password Fields!");
                        Users.managerLoggedIn = false;
                        this.userNameTextBox.Clear();
                        this.passWordTextBox.Clear();
                        this.userNameTextBox.Focus();
                    }
                }

                //Administrator login validation
                if (AuthSelect.SelectedIndex == 2)
                {
                    //Pass text box text into variable, open file, pass username & passwork into method
                    User.adminName = userNameTextBox.Text;
                    User.adminPass = passWordTextBox.Text;
                    Files.OpenAdminFile();
                    Users.AdminLogin(User.adminName, User.adminPass);

                    if (Users.administratorLoggedIn == true)
                    {
                        MessageBox.Show("Successful Login!");
                        loginScreen.Hide();
                        optionsScreen.ShowDialog();
                        this.userNameTextBox.Clear();
                        this.passWordTextBox.Clear();
                        this.userNameTextBox.Focus();
                    }
                    else if (Users.loginIncorrect == true)
                    {
                        MessageBox.Show("User Name and Password Incorrect!  Please Check and try again!");
                        Users.administratorLoggedIn = false;
                        this.userNameTextBox.Clear();
                        this.passWordTextBox.Clear();
                        this.userNameTextBox.Focus();
                    }
                    else if (Users.loginBlank == true)
                    {
                        MessageBox.Show("Please Fill out both Username and Password Fields!");
                        Users.administratorLoggedIn = false;
                        this.userNameTextBox.Clear();
                        this.passWordTextBox.Clear();
                        this.userNameTextBox.Focus();
                    }
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
