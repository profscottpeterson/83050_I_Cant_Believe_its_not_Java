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
            //instances of User and File classes
            User Users = new User();
            Files Files = new Files();

            try
            {   
                //Cashier login validation
                if(AuthSelect.SelectedIndex == 0)
                {
                    //***REMOVE, JUST ADDED FOR EASE OF USE
                    //User.employeeLoggedIn = true;

                    //Pass text box text into variable, open file, pass username & passwork into method
                    User.employeeName = userNameTextBox.Text.Trim();
                    User.employeePass = passWordTextBox.Text.Trim();
                    Files.OpenEmpFile();
                    Users.EmployeeLogin(User.employeeName, User.employeePass);
                    
                    if (User.employeeLoggedIn == true)
                    {
                        MessageBox.Show("Successful Login.");                 
                        this.Hide();
                        RegisterScreen registerScreen = new RegisterScreen();
                        registerScreen.ShowDialog();
                        this.userNameTextBox.Clear();
                        this.passWordTextBox.Clear();
                        this.userNameTextBox.Focus();
                    }
                    else if (User.loginIncorrect == true)
                    {
                        MessageBox.Show("User Name and Password Incorrect.  Please Check and try again.");
                        User.employeeLoggedIn = false;
                        this.userNameTextBox.Clear();
                        this.passWordTextBox.Clear();
                        this.userNameTextBox.Focus();
                    }  
                    else if (User.loginBlank == true)
                    {
                        MessageBox.Show("Please Fill out both Username and Password Fields.");
                        User.employeeLoggedIn = false;
                        this.userNameTextBox.Clear();
                        this.passWordTextBox.Clear();
                        this.userNameTextBox.Focus();
                    }
                }

                //Manager login validation
                if (AuthSelect.SelectedIndex == 1)
                {
                    //***REMOVE, JUST ADDED FOR EASE OF USE
                    //User.managerLoggedIn = true;

                    //Pass text box text into variable, open file, pass username & passwork into method
                    User.managerName = userNameTextBox.Text.Trim();
                    User.managerPass = passWordTextBox.Text.Trim();
                    Files.OpenMgtFile();
                    Users.ManagerLogin(User.managerName, User.managerPass);

                    if (User.managerLoggedIn == true)
                    {
                        MessageBox.Show("Successful Login.");
                        this.Hide();
                        ReportingScreen reportingScreen = new ReportingScreen();
                        reportingScreen.ShowDialog();
                        this.userNameTextBox.Clear();
                        this.passWordTextBox.Clear();
                        this.userNameTextBox.Focus();
                    }
                    else if (User.loginIncorrect == true)
                    {
                        MessageBox.Show("User Name and Password Incorrect. Please Check and try again.");
                        User.managerLoggedIn = false;
                        this.userNameTextBox.Clear();
                        this.passWordTextBox.Clear();
                        this.userNameTextBox.Focus();
                    }
                    else if (User.loginBlank == true)
                    {
                        MessageBox.Show("Please Fill out both Username and Password Fields.");
                        User.managerLoggedIn = false;
                        this.userNameTextBox.Clear();
                        this.passWordTextBox.Clear();
                        this.userNameTextBox.Focus();
                    }
                }

                //Administrator login validation
                if (AuthSelect.SelectedIndex == 2)
                {
                    //***REMOVE, JUST ADDED FOR EASE OF USE
                    User.administratorLoggedIn = true;

                    //Pass text box text into variable, open file, pass username & passwork into method
                    User.adminName = userNameTextBox.Text.Trim();
                    User.adminPass = passWordTextBox.Text.Trim();
                    Files.OpenAdminFile();
                    Users.AdminLogin(User.adminName, User.adminPass);

                    if (User.administratorLoggedIn == true)
                    {
                        MessageBox.Show("Successful Login.");
                        this.Hide();
                        OptionsScreen optionsScreen = new OptionsScreen();
                        optionsScreen.ShowDialog();
                        this.userNameTextBox.Clear();
                        this.passWordTextBox.Clear();
                        this.userNameTextBox.Focus();
                    }
                    else if (User.loginIncorrect == true)
                    {
                        MessageBox.Show("User Name and Password Incorrect. Please Check and try again.");
                        User.administratorLoggedIn = false;
                        this.userNameTextBox.Clear();
                        this.passWordTextBox.Clear();
                        this.userNameTextBox.Focus();
                    }
                    else if (User.loginBlank == true)
                    {
                        MessageBox.Show("Please Fill out both Username and Password Fields.");
                        User.administratorLoggedIn = false;
                        this.userNameTextBox.Clear();
                        this.passWordTextBox.Clear();
                        this.userNameTextBox.Focus();
                    }
                }

                //if nothing is selected
                if (AuthSelect.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a User Type!");
                    AuthSelect.Focus();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("File loading error, Please contact System Administrator!");
            }
        }

        //clear button functions
        private void clearButton_Click(object sender, EventArgs e)
        {
            this.AuthSelect.SelectedIndex = -1;
            this.AuthSelect.Focus();
            this.userNameTextBox.Clear();
            this.passWordTextBox.Clear();
            this.userNameTextBox.Focus();
        }
        
    }
}
