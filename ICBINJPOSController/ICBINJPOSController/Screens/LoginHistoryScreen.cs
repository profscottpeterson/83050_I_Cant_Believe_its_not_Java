using System;
using System.Windows.Forms;
using System.IO;

namespace ICBINJPOSController
{
    public partial class LoginHistoryScreen : Form
    {
        public LoginHistoryScreen()
        {
            InitializeComponent();
        }

        //load screen
        private void LoginHistoryScreen_Load(object sender, EventArgs e)
        {
            //open file and write to list box
            using (StreamReader histStream = new StreamReader("loginHist.txt"))
            {
                string hist;

                while ((hist = histStream.ReadLine()) != null)
                {
                    loginHistLbx.Items.Add(hist);
                }
            }
        }

        //go back to admin screen
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            loginHistLbx.Items.Clear();
        }

        private void clearHistBtn_Click(object sender, EventArgs e)
        {
            //set message box dialog message and title
            string message = "Are you sure you want to clear the Login History?";
            string title = "Clear Login History!";

            //set message box buttons with message dialog
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            //results if yes button clicked
            if (result == DialogResult.Yes)
            {
                //overwrite current file for new modified file
                File.WriteAllText("loginHist.txt", null);

                //clear listbox
                loginHistLbx.Items.Clear();

                //clear file confirmation
                MessageBox.Show("Login History has been cleared!");
            }
            //results if no button clicked
            else if (result == DialogResult.No)
            {
                //changes not saved message
                MessageBox.Show("Changes have not been saved!");
            }
        }
    }
}
