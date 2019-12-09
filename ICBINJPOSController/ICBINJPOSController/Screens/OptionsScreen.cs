using System;
using System.Drawing;
using System.Windows.Forms;

namespace ICBINJPOSController
{
    public partial class OptionsScreen : Form
    {
        User Users = new User();
        
        public OptionsScreen()
        {
            InitializeComponent();
        }

        private void OptionsScreen_Load(object sender, EventArgs e)
        {    
            //enable/disable function validation for employee
            if(User.employeeLoggedIn == true)
            {
                registerBtn.Enabled = true;
                registerBtn.BackColor = Color.Coral;
                reportingBtn.Enabled = false;
                reportingBtn.BackColor = Color.RosyBrown;
                adminBtn.Enabled = false;
                adminBtn.BackColor = Color.RosyBrown;
                signOutBtn.Enabled = true;
                signOutBtn.BackColor = Color.Coral;

                blank1btn.Enabled = false;
                blank1btn.BackColor = Color.RosyBrown;
                blank2btn.Enabled = false;
                blank2btn.BackColor = Color.RosyBrown;
                blank3btn.Enabled = false;
                blank3btn.BackColor = Color.RosyBrown;
                blank4btn.Enabled = false;
                blank4btn.BackColor = Color.RosyBrown;
                blank5btn.Enabled = false;
                blank5btn.BackColor = Color.RosyBrown;
                blank6btn.Enabled = false;
                blank6btn.BackColor = Color.RosyBrown;
                blank7btn.Enabled = false;
                blank7btn.BackColor = Color.RosyBrown;
                blank8btn.Enabled = false;
                blank8btn.BackColor = Color.RosyBrown;
                blank9btn.Enabled = false;
                blank9btn.BackColor = Color.RosyBrown;
                blank10btn.Enabled = false;
                blank10btn.BackColor = Color.RosyBrown;
                blank11btn.Enabled = false;
                blank11btn.BackColor = Color.RosyBrown;
                blank12btn.Enabled = false;
                blank12btn.BackColor = Color.RosyBrown;
            }
            //enable/disable function validation for mananger
            else if (User.managerLoggedIn == true)
            {
                registerBtn.Enabled = false;
                registerBtn.BackColor = Color.Coral;
                reportingBtn.Enabled = true;
                reportingBtn.BackColor = Color.Coral;
                adminBtn.Enabled = false;
                adminBtn.BackColor = Color.RosyBrown;
                signOutBtn.Enabled = true;
                signOutBtn.BackColor = Color.Coral;

                blank1btn.Enabled = false;
                blank1btn.BackColor = Color.RosyBrown;
                blank2btn.Enabled = false;
                blank2btn.BackColor = Color.RosyBrown;
                blank3btn.Enabled = false;
                blank3btn.BackColor = Color.RosyBrown;
                blank4btn.Enabled = false;
                blank4btn.BackColor = Color.RosyBrown;
                blank5btn.Enabled = false;
                blank5btn.BackColor = Color.RosyBrown;
                blank6btn.Enabled = false;
                blank6btn.BackColor = Color.RosyBrown;
                blank7btn.Enabled = false;
                blank7btn.BackColor = Color.RosyBrown;
                blank8btn.Enabled = false;
                blank8btn.BackColor = Color.RosyBrown;
                blank9btn.Enabled = false;
                blank9btn.BackColor = Color.RosyBrown;
                blank10btn.Enabled = false;
                blank10btn.BackColor = Color.RosyBrown;
                blank11btn.Enabled = false;
                blank11btn.BackColor = Color.RosyBrown;
                blank12btn.Enabled = false;
                blank12btn.BackColor = Color.RosyBrown;
            }
            //enable/disable function validation for administrator
            else if (User.administratorLoggedIn == true)
            {
                registerBtn.Enabled = false;
                registerBtn.BackColor = Color.RosyBrown;
                reportingBtn.Enabled = false;
                reportingBtn.BackColor = Color.RosyBrown;
                adminBtn.Enabled = true;
                adminBtn.BackColor = Color.Coral;
                signOutBtn.Enabled = true;
                signOutBtn.BackColor = Color.Coral;

                blank1btn.Enabled = false;
                blank1btn.BackColor = Color.RosyBrown;
                blank2btn.Enabled = false;
                blank2btn.BackColor = Color.RosyBrown;
                blank3btn.Enabled = false;
                blank3btn.BackColor = Color.RosyBrown;
                blank4btn.Enabled = false;
                blank4btn.BackColor = Color.RosyBrown;
                blank5btn.Enabled = false;
                blank5btn.BackColor = Color.RosyBrown;
                blank6btn.Enabled = false;
                blank6btn.BackColor = Color.RosyBrown;
                blank7btn.Enabled = false;
                blank7btn.BackColor = Color.RosyBrown;
                blank8btn.Enabled = false;
                blank8btn.BackColor = Color.RosyBrown;
                blank9btn.Enabled = false;
                blank9btn.BackColor = Color.RosyBrown;
                blank10btn.Enabled = false;
                blank10btn.BackColor = Color.RosyBrown;
                blank11btn.Enabled = false;
                blank11btn.BackColor = Color.RosyBrown;
                blank12btn.Enabled = false;
                blank12btn.BackColor = Color.RosyBrown;
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            RegisterScreen registerScreen = new RegisterScreen();
            this.Hide();
            registerScreen.ShowDialog();
        }

        private void reportingBtn_Click(object sender, EventArgs e)
        {
            ReportingScreen reportingScreen = new ReportingScreen();
            this.Hide();
            reportingScreen.ShowDialog();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            AdminScreen adminScreen = new AdminScreen();
            this.Hide();
            adminScreen.ShowDialog();
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users.SignOut();
            
        }
    }
}
