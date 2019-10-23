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
           

        }
        //list to hold username and password
        List<string> userName = new List<string>();
        List<string> passWord = new List<string>();

        //string to hold message box messages
        string msgtxt;


        //login screen
        private void LoginScreen_Load(object sender, EventArgs e)
        {
            try
            {
                //instantiate stream reader file
                StreamReader streamReader = new StreamReader("auth.txt");
                string line = "";

                //read file lines, split each whitespace separated entry to an array & add to list
                while((line = streamReader.ReadLine()) != null)
                {
                    string[] entries = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    userName.Add(entries[1]);
                    passWord.Add(entries[2]);
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
            //if username and password correct
            if (userName.Contains(userNameTextBox.Text) && passWord.Contains(passWordTextBox.Text) && Array.IndexOf(userName.ToArray(), userNameTextBox.Text) == Array.IndexOf(passWord.ToArray(), passWordTextBox.Text))
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
            //if username or password incorrect
            else if((userNameTextBox.Text != "") || (passWordTextBox.Text != "") && Array.IndexOf(userName.ToArray(), userNameTextBox.Text) != Array.IndexOf(passWord.ToArray(), passWordTextBox.Text))
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
