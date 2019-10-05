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
        public LoginScreen()
        {
            InitializeComponent();
        }

        List<string> userName = new List<string>();
        List<string> passWord = new List<string>();


        private void LoginScreen_Load(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader(@"Authentication.txt");
            string line = "";
            
            while((line = streamReader.ReadLine()) != null)
            {
                string[] entries = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                userName.Add(entries[0]);
                passWord.Add(entries[1]);
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userName.Contains(userNameTextBox.Text) && passWord.Contains(passWordTextBox.Text) && Array.IndexOf(userName.ToArray(), userNameTextBox.Text) == Array.IndexOf(passWord.ToArray(), passWordTextBox.Text))
            {
                OptionsScreen optionsScreen = new OptionsScreen(); 
                this.Close();
                optionsScreen.ShowDialog();
               
               
            }
           /*
            if(userName.Contains(userNameTextBox.Text) && passWord.Contains(passWordTextBox.Text) && Array.IndexOf(userName.ToArray(), userNameTextBox.Text) != Array.IndexOf(passWord.ToArray(), passWordTextBox.Text))
            {

            }
            */
            
        }
    }
}
