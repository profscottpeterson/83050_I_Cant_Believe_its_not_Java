using System;
using System.Windows.Forms;

namespace ICBINJPOSController
{
    public partial class ModifyUserScreen : Form
    {
        //variables to hold new username and password
        static public string newUser;
        static public string newPass;

        //variable to hold static bool
        static public bool cancelled;

        public ModifyUserScreen()
        {
            InitializeComponent();
            //focus on username text box upon load
            newUserTxt.Focus();
        }

        //save changes to username or password
        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //trim text inputs
                newUserTxt.Text.Trim();
                newPassTxt.Text.Trim();

                //if new username entered
                if (newUserTxt.Text != "" && newPassTxt.Text == "")
                {
                    //validate username length
                    if (newUserTxt.TextLength >= 3 && newUserTxt.TextLength <= 15)
                    {
                        //set message box dialog message and title
                        string message = "Are you sure you want to modify Username?";
                        string title = "Modify User Confirmation!";

                        //set message box buttons with message dialog
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons);

                        //results if yes button clicked
                        if (result == DialogResult.Yes)
                        {
                            //changes have been saved message
                            MessageBox.Show("Changes have been saved!");

                            //add username text to static variable and close modify user screen
                            newUser = newUserTxt.Text;
                            cancelled = false;
                            this.Close();
                        }
                        //results if no button clicked
                        else if (result == DialogResult.No)
                        {
                            //changes not saved message
                            MessageBox.Show("Changes have not been saved!");

                            //clear text boxes
                            newUserTxt.Clear();
                            newPassTxt.Clear();
                            newUserTxt.Focus();
                        }
                    }
                    //error messaging for username length
                    else
                    {
                        MessageBox.Show("Username must be between 3 and 15 characters!");
                        newUserTxt.Clear();
                        newUserTxt.Focus();
                    }
                }

                //if new password entered
                else if (newUserTxt.Text == "" && newPassTxt.Text != "")
                {
                    //Validate Password is not already in use
                    if (!Files.empPassWord.Contains(newPassTxt.Text))
                    {
                        //validate password length
                        if (newPassTxt.TextLength >= 3 && newPassTxt.TextLength <= 15)
                        {
                            //set message box dialog message and title
                            string message = "Are you sure you want to modify Password?";
                            string title = "Modify User Confirmation!";

                            //set message box buttons with message dialog
                            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                            DialogResult result = MessageBox.Show(message, title, buttons);

                            //results if yes button clicked
                            if (result == DialogResult.Yes)
                            {
                                //changes have been saved message
                                MessageBox.Show("Changes have been saved!");

                                //add username text to static variable and close modify user screen
                                newPass = newPassTxt.Text;
                                cancelled = false;
                                this.Close();
                            }
                            //results if no button clicked
                            else if (result == DialogResult.No)
                            {
                                //changes not saved message
                                MessageBox.Show("Changes have not been saved!");

                                //clear text boxes
                                newUserTxt.Clear();
                                newPassTxt.Clear();
                                newUserTxt.Focus();
                            }
                        }
                        //error messaging for password length
                        else
                        {
                            MessageBox.Show("Pasword must be between 3 and 15 characters!");
                            newPassTxt.Clear();
                            newPassTxt.Focus();
                        }
                    }
                    //error messaging for password in use
                    else
                    {
                        MessageBox.Show("Please enter a different password!");
                        newPassTxt.Clear();
                        newPassTxt.Focus();
                    }
                }

                //if username and password text entered
                else if (newUserTxt.Text != "" && newPassTxt.Text != "")
                {
                    //validate username length
                    if (newUserTxt.TextLength >= 3 && newUserTxt.TextLength <= 15)
                    {
                        //Validate Password is not already in use
                        if (!Files.empPassWord.Contains(newPassTxt.Text))
                        {
                            //validate password length
                            if (newPassTxt.TextLength >= 3 && newPassTxt.TextLength <= 15)
                            {
                                //set message box dialog message and title
                                string message = "Are you sure you want to modify Username & Password?";
                                string title = "Modify User Confirmation!";

                                //set message box buttons with message dialog
                                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                                DialogResult result = MessageBox.Show(message, title, buttons);

                                //results if yes button clicked
                                if (result == DialogResult.Yes)
                                {
                                    //changes have been saved message
                                    MessageBox.Show("Changes have been saved!");

                                    //add username and password text to static variable and close modify user screen
                                    newUser = newUserTxt.Text;
                                    newPass = newPassTxt.Text;
                                    cancelled = false;
                                    this.Close();
                                }
                                //results if no button clicked
                                else if (result == DialogResult.No)
                                {
                                    //changes not saved message
                                    MessageBox.Show("Changes have not been saved!");

                                    //clear text boxes
                                    newUserTxt.Clear();
                                    newPassTxt.Clear();
                                    newUserTxt.Focus();
                                }
                            }
                            //error messaging for password length
                            else
                            {
                                MessageBox.Show("Pasword must be between 3 and 15 characters!");
                                newPassTxt.Clear();
                                newPassTxt.Focus();
                            }
                        }
                        //error messaging for password in use
                        else
                        {
                            MessageBox.Show("Please enter a different password!");
                            newPassTxt.Clear();
                            newPassTxt.Focus();
                        }
                        
                    }
                    //error messaging for username length
                    else
                    {
                        MessageBox.Show("Username must be between 3 and 15 characters!");
                        newUserTxt.Clear();
                        newUserTxt.Focus();
                    }
                }

                //error messaging if no text entered for username and password 
                else
                {
                    MessageBox.Show("You must enter a Username or Password to change!");
                    newUserTxt.Focus();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void cancelChangesBtn_Click(object sender, EventArgs e)
        {
            //close modify user menu
            MessageBox.Show("Modify User Menu cancelled!");
            cancelled = true;
            this.Close();
        }
    }
}