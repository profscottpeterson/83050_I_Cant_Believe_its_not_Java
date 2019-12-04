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
        static public Report dailyReport = new Report();
        static public Report userReport = new Report();


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
                    User.employeeLoggedIn = true;

                    //Pass text box text into variable, open file, pass username & passwork into method
                    User.employeeName = userNameTextBox.Text;
                    User.employeePass = passWordTextBox.Text;
                    Files.OpenEmpFile();
                    Users.EmployeeLogin(User.employeeName, User.employeePass);
                    
                    if (User.employeeLoggedIn == true)
                    {
                        MessageBox.Show("Successful Login.");                 
                        this.Hide();
                        //**options screen test
                        //OptionsScreen registerScreen = new OptionsScreen();

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
                    User.managerLoggedIn = true;

                    //Pass text box text into variable, open file, pass username & passwork into method
                    User.managerName = userNameTextBox.Text;
                    User.managerPass = passWordTextBox.Text;
                    Files.OpenMgtFile();
                    Users.ManagerLogin(User.managerName, User.managerPass);

                    if (User.managerLoggedIn == true)
                    {
                        MessageBox.Show("Successful Login.");
                        this.Hide();
                        //**options screen test
                        //OptionsScreen reportingScreen = new OptionsScreen();

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
                    User.adminName = userNameTextBox.Text;
                    User.adminPass = passWordTextBox.Text;
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
