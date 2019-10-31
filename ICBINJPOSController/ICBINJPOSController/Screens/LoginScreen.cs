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

            try
            {   
                //Cashier login validation
                if(AuthSelect.SelectedIndex == 0)
                {
                    var Employee = new User();

                    Employee.employeeName = userNameTextBox.Text;
                    Employee.employeePass = passWordTextBox.Text;
                    Employee.OpenEmpFile();
                    Employee.EmployeeLogin(Employee.employeeName, Employee.employeePass);

                    if (Employee.employeeLoggedIn == true)
                    {
                        MessageBox.Show("Successful Login!");
                        loginScreen.Hide();
                        registerScreen.ShowDialog();
                        this.userNameTextBox.Clear();
                        this.passWordTextBox.Clear();
                        this.userNameTextBox.Focus();
                    }
                    else if (Employee.loginIncorrect == true)
                    {
                        MessageBox.Show("User Name and Password Incorrect!  Please Check and try again!");
                        Employee.employeeLoggedIn = false;
                        this.userNameTextBox.Clear();
                        this.passWordTextBox.Clear();
                        this.userNameTextBox.Focus();
                    }  
                    else if (Employee.loginBlank == true)
                    {
                        MessageBox.Show("Please Fill out both Username and Password Fields!");
                        Employee.employeeLoggedIn = false;
                        this.userNameTextBox.Clear();
                        this.passWordTextBox.Clear();
                        this.userNameTextBox.Focus();
                    }
                }

                //Manager login validation
                if (AuthSelect.SelectedIndex == 1)
                {
                    var Manager = new User();

                    Manager.managerName = userNameTextBox.Text;
                    Manager.managerPass = passWordTextBox.Text;
                    Manager.OpenMgtFile();
                    Manager.ManagerLogin(Manager.managerName, Manager.managerPass);

                    if (Manager.managerLoggedIn == true)
                    {
                        MessageBox.Show("Successful Login!");
                        loginScreen.Hide();
                        reportingScreen.ShowDialog();
                        this.userNameTextBox.Clear();
                        this.passWordTextBox.Clear();
                        this.userNameTextBox.Focus();
                    }
                    else if (Manager.loginIncorrect == true)
                    {
                        MessageBox.Show("User Name and Password Incorrect!  Please Check and try again!");
                        Manager.managerLoggedIn = false;
                        this.userNameTextBox.Clear();
                        this.passWordTextBox.Clear();
                        this.userNameTextBox.Focus();
                    }
                    else if (Manager.loginBlank == true)
                    {
                        MessageBox.Show("Please Fill out both Username and Password Fields!");
                        Manager.managerLoggedIn = false;
                        this.userNameTextBox.Clear();
                        this.passWordTextBox.Clear();
                        this.userNameTextBox.Focus();
                    }
                }

                //Administrator login validation
                if (AuthSelect.SelectedIndex == 2)
                {
                    var Administrator = new User();

                    Administrator.adminName = userNameTextBox.Text;
                    Administrator.adminPass = passWordTextBox.Text;
                    Administrator.OpenAdminFile();
                    Administrator.AdminLogin(Administrator.adminName, Administrator.adminPass);

                    if (Administrator.administratorLoggedIn == true)
                    {
                        MessageBox.Show("Successful Login!");
                        loginScreen.Hide();
                        optionsScreen.ShowDialog();
                        this.userNameTextBox.Clear();
                        this.passWordTextBox.Clear();
                        this.userNameTextBox.Focus();
                    }
                    else if (Administrator.loginIncorrect == true)
                    {
                        MessageBox.Show("User Name and Password Incorrect!  Please Check and try again!");
                        Administrator.administratorLoggedIn = false;
                        this.userNameTextBox.Clear();
                        this.passWordTextBox.Clear();
                        this.userNameTextBox.Focus();
                    }
                    else if (Administrator.loginBlank == true)
                    {
                        MessageBox.Show("Please Fill out both Username and Password Fields!");
                        Administrator.administratorLoggedIn = false;
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
