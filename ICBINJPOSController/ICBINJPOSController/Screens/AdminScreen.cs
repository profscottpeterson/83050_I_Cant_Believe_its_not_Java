
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
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
        }
        //numeric flag for User ID validation
        private bool numeric;

        //lists to hold ID, Usernames and Passwords
        private List<string> EmpID = new List<string>();
        private List<string> EmpUserName = new List<string>();
        private List<string> EmpPassWord = new List<string>();

        //Instantiation of User class
        User Users = new User();

        //add user button
        private void addUserBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //if cashiser is selected
                if (userSelectComboBox.SelectedIndex == 0)
                {
                    //open corresponding file
                    using (StreamReader empFile = new StreamReader("employeeAuth.txt"))
                    {
                        //variable to hold line
                        string emp = "";

                        //read line emp, split each whitespace separated entry to an array & add to list
                        while ((emp = empFile.ReadLine()) != null && !empFile.EndOfStream)
                        {
                            string[] entries = emp.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                            EmpID.Add(entries[0]);
                            EmpUserName.Add(entries[1]);
                            EmpPassWord.Add(entries[2]);
                        }
                    }
                    
                    //validate text boxes are not blank
                    if (userIdTxt.Text != "" && userTxt.Text != "" && passwordTxt.Text != "")
                    {
                        //loop through ID textbox to validate characters are numeric, set flags on condition
                        for (var x = 0; x < userIdTxt.TextLength;)
                        {
                            if(Char.IsDigit(userIdTxt.Text, x))
                            {
                                x++;
                                numeric = true;
                            }
                            else
                            {
                                numeric = false;
                                break;
                            }
                           
                        }

                        //validate numeric flag for ID validation
                        if(numeric == true)
                        {
                            //validate User ID is not already in use
                            if (!EmpID.Contains(userIdTxt.Text))
                            {
                                //Validate Password is not already in use
                                if (!EmpPassWord.Contains(passwordTxt.Text))
                                {
                                    //validate password length
                                    if(passwordTxt.MaxLength >= 3 && passwordTxt.MaxLength <=15)
                                    {
                                        //open corresponding file and append new line, reset form for next entry
                                        using (StreamWriter empLine = File.AppendText("employeeAuth.txt"))
                                        {
                                            empLine.WriteLine(userIdTxt.Text + " " + userTxt.Text + " " + passwordTxt.Text);
                                            MessageBox.Show("New Employee has been added!");
                                            userIdTxt.Clear();
                                            userTxt.Clear();
                                            passwordTxt.Clear();
                                            userIdTxt.Focus();
                                        }
                                    }
                                    //error messaging for password length
                                    else
                                    {
                                        MessageBox.Show("Pasword must be between 3 and 15 characters!");
                                        passwordTxt.Clear();
                                        passwordTxt.Focus();
                                    }
                                }
                                //error messaging for password in use
                                else
                                {
                                    MessageBox.Show("Please enter a different password!");
                                    passwordTxt.Clear();
                                    passwordTxt.Focus();
                                }
                            }
                            //error messaging for User ID in use
                            else
                            {
                                MessageBox.Show("ID alreayd in use! Please enter a new ID!");
                                userIdTxt.Clear();
                                userIdTxt.Focus();
                            }
                        }
                        //error messaging for non numeric User ID
                        else
                        {
                            MessageBox.Show("User ID must be of type numeric!");
                        }                       
                    }
                    //error messaging for blank text fields
                    else
                    {
                        MessageBox.Show("Please fill out all fields!");
                        userIdTxt.Clear();
                        userTxt.Clear();
                        passwordTxt.Clear();
                        userIdTxt.Focus();
                    }
                }

                //if Manager is selected
                if (userSelectComboBox.SelectedIndex == 1)
                {
                    MessageBox.Show("Incomplete code");
                    //using (StreamReader mgtFile = new StreamReader("managementAuth.txt"))
                    //{

                    //}
                }

                //if Administrator is selected
                if (userSelectComboBox.SelectedIndex == 2)
                {
                    MessageBox.Show("Incomplete code");
                    //using (StreamReader adminFile = new StreamReader("administratorAuth.txt"))
                    //{

                    //}
                }

                //if nothing is selected
                if (userSelectComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a User Type!");
                    userSelectComboBox.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("File loading error, Please contact System Administrator!");
            }
            
        }

        //load file menu upon page loading
        private void AdminScreen_Load(object sender, EventArgs e)
        {
            //disable buttons until future use
            deleteItemBtn.Enabled = false;
            deleteItemBtn.BackColor = Color.RosyBrown;
            addItemBtn.Enabled = false;
            addItemBtn.BackColor = Color.RosyBrown;

            //open file and write to list box
            using (StreamReader itemStream = new StreamReader("DrinkMenu.txt"))
            {
                string item;

                while ((item = itemStream.ReadLine()) != null)
                {
                    string[] entries = item.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                    itemLbx.Items.Add(entries[0] + ", " + entries[1] + ", " + entries[2] + ", " + entries[3]);

                }
            }
        }


        //select box functionality
        private void itemLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if index is selected in listbox
            if (itemLbx.SelectedIndex != -1)
            {
                //write selected index to list
                string items = itemLbx.SelectedItem.ToString();
                //separate list into an array by comma delimiter
                string[] item = items.Split(",".ToCharArray());

                //write array index contents to labels and textboxes
                descLbl.Text = item[0].ToString();
                smallPriceTxt.Text = item[1].ToString();
                mediumPriceTxt.Text = item[2].ToString();
                largePriceTxt.Text = item[3].ToString();
            }
        }

        //modify button functionality
        private void modifyItemBtn_Click(object sender, EventArgs e)
        {
            //if index is selected in listbox
            if (itemLbx.SelectedIndex != -1)
            {
                //copy selected index items to string variable
                string items = itemLbx.SelectedItem.ToString();

                //copy string variable into seperate array entries delimited by comma
                string[] item = items.Split(",".ToCharArray());

                //copy current text box text into array indexes
                item[0] = descLbl.Text;
                item[1] = smallPriceTxt.Text;
                item[2] = mediumPriceTxt.Text;
                item[3] = largePriceTxt.Text;

                //loop through item array
                for(var z = 1; z < 4;)
                {
                    //validate array field length
                    if (item[z].Length >= 4 && item[z].Length <= 6)
                    {
                        z++;
                    }
                    //error message for invalid array field length
                    else
                    {
                        MessageBox.Show("Price must be between $0.00 and $99.99!");
                        break;
                    }
                    //validate that all items in array are proper length
                    if(z == 4)
                    {
                        //loop through each array index
                        for (var x = 1; x < 4; x++)
                        {
                            //loop through characters in each array index to validate characters are valid, set flags on condition
                            for (var i = 0; i < item[x].Length;)
                            {
                                if (Char.IsPunctuation(item[x], i) || Char.IsWhiteSpace(item[x], i) || Char.IsDigit(item[x], i))
                                {
                                    i++;
                                    numeric = true;
                                }
                                else
                                {
                                    numeric = false;
                                    break;
                                }

                            }
                            //evaluate condition of character loop
                            if (numeric == false)
                            {
                                break;
                            }
                        }
                        //evaluate condition of index loop
                        if (numeric == true)
                        {
                            //copy array entries to a string variable
                            string newItems = item[0] + "," + item[1] + "," + item[2] + "," + item[3];

                            //add string variale and remove current items at selected index
                            itemLbx.Items.Insert(itemLbx.SelectedIndex, newItems);
                            itemLbx.Items.RemoveAt(itemLbx.SelectedIndex);
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid cost as a whole dollar amount!");
                        }
                    }
                }

                //clear text boxes
                descLbl.Text = " ";
                smallPriceTxt.Clear();
                mediumPriceTxt.Clear();
                largePriceTxt.Clear();
            }
            //error message if no item selected
            else
            {
                MessageBox.Show("Please select an item to modify!");
            }
        }

        //save button functionality
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //set message box dialog message and title
            string message = "Are you sure you want to save changes to Drink Menu?";
            string title = "Save New Drink Menu!";

            //set message box buttons with message dialog
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            //results if yes button clicked
            if (result == DialogResult.Yes)
            {
                //clear text file 
                File.WriteAllText("DrinkMenu.txt", String.Empty);

                //open drink menu, loop through file and write new list box contents to text file
                using (StreamWriter NewDrinkMenu = new StreamWriter("DrinkMenu.txt"))
                {
                    foreach (var line in itemLbx.Items)
                    {
                        NewDrinkMenu.WriteLine(line.ToString());
                    }
                }

                //show changes saved message
                MessageBox.Show("Changes have been saved!");
            }

            //results if no button clicked
            else if (result == DialogResult.No)
            {
                //changes not saved message
                MessageBox.Show("Changes have not been saved!");

                //clear list box 
                itemLbx.Items.Clear();

                //open drink menu, loop through file and write unchanged drink menu to list box
                using (StreamReader itemStream = new StreamReader("DrinkMenu.txt"))
                {
                    string item;

                    while ((item = itemStream.ReadLine()) != null)
                    {
                        string[] entries = item.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                        itemLbx.Items.Add(entries[0] + ", " + entries[1] + ", " + entries[2] + ", " + entries[3]);

                    }
                }

                //clear text boxes
                descLbl.Text = " ";
                smallPriceTxt.Clear();
                mediumPriceTxt.Clear();
                largePriceTxt.Clear();
            }
        }

        private void clearTextBtn_Click(object sender, EventArgs e)
        {
            //clear text boxes
            descLbl.Text = " ";
            smallPriceTxt.Clear();
            mediumPriceTxt.Clear();
            largePriceTxt.Clear();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            //go back to options screen
            this.Hide();
            Users.GoBack();
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            //sign out & go back to login screen
            this.Hide();
            Users.SignOut();
        }

    }
}
