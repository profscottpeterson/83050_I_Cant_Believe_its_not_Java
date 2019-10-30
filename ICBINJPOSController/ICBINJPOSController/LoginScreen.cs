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
            try
            {
                //Cashier login validation
                if(AuthSelect.SelectedIndex == 0)
                {
                    var Employee = new User();

                    Employee.EmployeeName = userNameTextBox.Text;
                    Employee.EmployeePass = passWordTextBox.Text;
                    Employee.OpenEmpFile();
                    Employee.EmployeeLogin(Employee.EmployeeName, Employee.EmployeePass);
                    this.userNameTextBox.Clear();
                    this.passWordTextBox.Clear();
                    this.userNameTextBox.Focus();
                }

                //Manager login validation
                if (AuthSelect.SelectedIndex == 1)
                {
                    var Manager = new User();

                    Manager.ManagerName = userNameTextBox.Text;
                    Manager.ManagerPass = passWordTextBox.Text;
                    Manager.OpenMgtFile();
                    Manager.ManagerLogin(Manager.ManagerName, Manager.ManagerPass);
                    this.userNameTextBox.Clear();
                    this.passWordTextBox.Clear();
                    this.userNameTextBox.Focus();
                }

                //Administrator login validation
                if (AuthSelect.SelectedIndex == 2)
                {
                    var Administrator = new User();

                    Administrator.AdminName = userNameTextBox.Text;
                    Administrator.AdminPass = passWordTextBox.Text;
                    Administrator.OpenAdminFile();
                    Administrator.AdminLogin(Administrator.AdminName, Administrator.AdminPass);
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
