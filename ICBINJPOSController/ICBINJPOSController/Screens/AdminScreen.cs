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
using System.Globalization;

namespace ICBINJPOSController
{
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
        }
        //lists to hold ID, Usernames and Passwords
        private List<string> EmpID = new List<string>();
        private List<string> EmpUserName = new List<string>();
        private List<string> EmpPassWord = new List<string>();
        private List<string> MgtID = new List<string>();
        private List<string> MgtUserName = new List<string>();
        private List<string> MgtPassWord = new List<string>();
        private List<string> AdminID = new List<string>();
        private List<string> AdminUserName = new List<string>();
        private List<string> AdminPassWord = new List<string>();

        //varables to hold indexes
        private string id;
        private string name;
        private string pass;


        //validation flags
        private bool numeric;
        private bool delete;


        //variable to hold double
        double cost;


        //invalid characters
        char dollar = '$';


        //Instantiation of classes
        User Users = new User();
        Files Files = new Files();



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

                while ((item = itemStream.ReadLine()) != null && !itemStream.EndOfStream)
                {
                    string[] entries = item.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                    itemLbx.Items.Add(entries[0] + ", " + entries[1] + ", " + entries[2] + ", " + entries[3]);

                }
            }
        }


        //add user button
        private void addUserBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //if cashiser is selected
                if (userSelectComboBox.SelectedIndex == 0)
            {
                Files.OpenEmpFile();

                //validate text boxes are not blank
                if (userIdTxt.Text != "" && userNameTxt.Text != "" && passwordTxt.Text != "")
                {
                    //loop through ID textbox to validate characters are numeric, set flags on condition
                    for (var x = 0; x < userIdTxt.TextLength;)
                    {
                        if (Char.IsDigit(userIdTxt.Text, x))
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
                    if (numeric == true)
                    {
                        //validate User ID is not already in use
                        if (!Files.empID.Contains(userIdTxt.Text))
                        {
                            //Validate Password is not already in use
                            if (!Files.empPassWord.Contains(passwordTxt.Text))
                            {
                                //validate password length
                                if (passwordTxt.TextLength >= 3 && passwordTxt.TextLength <= 15)
                                {
                                    //open corresponding file and append new line, reset form for next entry
                                    using (StreamWriter empLine = File.AppendText("employeeAuth.txt"))
                                    {
                                        empLine.WriteLine(userIdTxt.Text + " " + userNameTxt.Text + " " + passwordTxt.Text);
                                        MessageBox.Show("New Employee has been added!");
                                        userIdTxt.Clear();
                                        userNameTxt.Clear();
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
                        userIdTxt.Clear();
                        userIdTxt.Focus();
                    }
                }
                //error messaging for blank text fields
                else
                {
                    MessageBox.Show("Please fill out all fields!");
                    userIdTxt.Clear();
                    userNameTxt.Clear();
                    passwordTxt.Clear();
                    userIdTxt.Focus();
                }
            }

            //if Manager is selected
            if (userSelectComboBox.SelectedIndex == 1)
            {
                Files.OpenMgtFile();

                //validate text boxes are not blank
                if (userIdTxt.Text != "" && userNameTxt.Text != "" && passwordTxt.Text != "")
                {
                    //loop through ID textbox to validate characters are numeric, set flags on condition
                    for (var x = 0; x < userIdTxt.TextLength;)
                    {
                        if (Char.IsDigit(userIdTxt.Text, x))
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
                    if (numeric == true)
                    {
                        //validate User ID is not already in use
                        if (!Files.mgtID.Contains(userIdTxt.Text))
                        {
                            //Validate Password is not already in use
                            if (!Files.mgtPassWord.Contains(passwordTxt.Text))
                            {
                                //validate password length
                                if (passwordTxt.TextLength >= 3 && passwordTxt.TextLength <= 15)
                                {
                                    //open corresponding file and append new line, reset form for next entry
                                    using (StreamWriter empLine = File.AppendText("managementAuth.txt"))
                                    {
                                        empLine.WriteLine(userIdTxt.Text + " " + userNameTxt.Text + " " + passwordTxt.Text);
                                        MessageBox.Show("New Manager has been added!");
                                        userIdTxt.Clear();
                                        userNameTxt.Clear();
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
                        userIdTxt.Clear();
                        userIdTxt.Focus();
                    }
                }
                //error messaging for blank text fields
                else
                {
                    MessageBox.Show("Please fill out all fields!");
                    userIdTxt.Clear();
                    userNameTxt.Clear();
                    passwordTxt.Clear();
                    userIdTxt.Focus();
                }
            }

            //if Administrator is selected
            if (userSelectComboBox.SelectedIndex == 2)
            {
                Files.OpenAdminFile();

                //validate text boxes are not blank
                if (userIdTxt.Text != "" && userNameTxt.Text != "" && passwordTxt.Text != "")
                {
                    //loop through ID textbox to validate characters are numeric, set flags on condition
                    for (var x = 0; x < userIdTxt.TextLength;)
                    {
                        if (Char.IsDigit(userIdTxt.Text, x))
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
                    if (numeric == true)
                    {
                        //validate User ID is not already in use
                        if (!Files.adminID.Contains(userIdTxt.Text))
                        {
                            //Validate Password is not already in use
                            if (!Files.adminPassWord.Contains(passwordTxt.Text))
                            {
                                //validate password length
                                if (passwordTxt.TextLength >= 3 && passwordTxt.TextLength <= 15)
                                {
                                    //open corresponding file and append new line, reset form for next entry
                                    using (StreamWriter empLine = File.AppendText("administratorAuth.txt"))
                                    {
                                        empLine.WriteLine(userIdTxt.Text + " " + userNameTxt.Text + " " + passwordTxt.Text);
                                        MessageBox.Show("New Administrator has been added!");
                                        userIdTxt.Clear();
                                        userNameTxt.Clear();
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
                        userIdTxt.Clear();
                        userIdTxt.Focus();
                    }
                }
                //error messaging for blank text fields
                else
                {
                    MessageBox.Show("Please fill out all fields!");
                    userIdTxt.Clear();
                    userNameTxt.Clear();
                    passwordTxt.Clear();
                    userIdTxt.Focus();
                }
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


        //select box functionality
        private void itemLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if index is selected in listbox
            if (itemLbx.SelectedIndex != -1)
            {
                //write selected index to list
                string items = itemLbx.SelectedItem.ToString();
                //separate list into an array by comma delimiter
                string[] item = items.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

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
                string[] item = items.Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                //copy current text box text into array indexes
                item[0] = descLbl.Text;
                item[1] = smallPriceTxt.Text;
                item[2] = mediumPriceTxt.Text;
                item[3] = largePriceTxt.Text;

                //loop through item array
                for (var z = 1; z < 4;)
                {
                    //validate array field length
                    if (item[z].Length >= 4 && item[z].Length <= 6)
                    {
                        if (double.TryParse(item[z], NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"), out cost))
                        {
                            z++;
                        }
                        else
                        {
                            MessageBox.Show("New price must be a valid decimal number!");
                            break;
                        }
                    }
                    //error message for invalid array field length
                    else
                    {
                        MessageBox.Show("New price must be between $0.00 and $99.99!");
                        break;
                    }
                    //validate that all items in array are proper length
                    if (z == 4)
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
                                    MessageBox.Show("Please do not use a $ sign or invalid characters when adding a price!");
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

                    while ((item = itemStream.ReadLine()) != null && !itemStream.EndOfStream)
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

        private void deleteUserBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //if cashiser is selected
                if (userSelectComboBox.SelectedIndex == 0)
                {
                    //instantiate stream reader file
                    using (StreamReader streamEmployee = new StreamReader("employeeAuth.txt"))
                    {
                        //variable to hold line
                        string emp = "";

                        //read line emp, split each whitespace separated entry to an array & add to list
                        while ((emp = streamEmployee.ReadLine()) != null && !streamEmployee.EndOfStream)
                        {
                            string[] entries = emp.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                            EmpID.Add(entries[0]);
                            EmpUserName.Add(entries[1]);
                            EmpPassWord.Add(entries[2]);
                        }
                    }
                    //validate text boxes are not blank
                    if (userIdTxt.Text != "" && userNameTxt.Text != "" && passwordTxt.Text != "")
                    {
                        //loop through ID textbox to validate characters are numeric, set flags on condition
                        for (var x = 0; x < userIdTxt.TextLength;)
                        {
                            if (Char.IsDigit(userIdTxt.Text, x))
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
                        if (numeric == true)
                        {
                            //validate User ID is correct
                            if (EmpID.Contains(userIdTxt.Text))
                            {
                                //validate User Name is correct
                                if (EmpUserName.Contains(userNameTxt.Text))
                                {
                                    //Validate Password is correct
                                    if (EmpPassWord.Contains(passwordTxt.Text))
                                    {
                                        //index counts
                                        var x = 0;

                                        using (StreamReader streamEmployee = new StreamReader("employeeAuth.txt"))
                                        {
                                            while ((streamEmployee.ReadLine()) != null && !streamEmployee.EndOfStream)
                                            {
                                                //add indexes to temp variables
                                                id = EmpID[x];
                                                name = EmpUserName[x];
                                                pass = EmpPassWord[x];

                                                //validate textbox contents are on the same index
                                                if (id == userIdTxt.Text && name == userNameTxt.Text && pass == passwordTxt.Text)
                                                {
                                                    delete = true;
                                                    break;
                                                }
                                                else
                                                {
                                                    delete = false;
                                                    x++;
                                                }
                                            }
                                        }
                                        if (delete == true)
                                        {
                                            //set message box dialog message and title
                                            string message = "Are you sure you want to delete user?";
                                            string title = "Delete User Confirmation!";

                                            //set message box buttons with message dialog
                                            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                                            DialogResult result = MessageBox.Show(message, title, buttons);

                                            //results if yes button clicked
                                            if (result == DialogResult.Yes)
                                            {
                                                var userFile = new List<string>(File.ReadAllLines("employeeAuth.txt"));
                                                userFile.RemoveAt(x);
                                                using (StreamWriter updateFile = new StreamWriter("employeeAuth.txt"))
                                                {
                                                    foreach(var U in userFile)
                                                    {
                                                        updateFile.WriteLine(U);
                                                    }
                                                 
                                                }

                                                //display confimation of delete user 
                                                MessageBox.Show("Selected Employee has been delete!");

                                                //clear text boxes
                                                userIdTxt.Clear();
                                                userNameTxt.Clear();
                                                passwordTxt.Clear();
                                                userIdTxt.Focus();
                                                delete = true;
                                                return;
                                            }
                                            //results if no button clicked
                                            else if (result == DialogResult.No)
                                            {
                                                //changes not saved message
                                                MessageBox.Show("Changes have not been saved!");

                                                //set delete flag
                                                delete = false;

                                                //clear text boxes
                                                userIdTxt.Clear();
                                                userNameTxt.Clear();
                                                passwordTxt.Clear();
                                                userIdTxt.Focus();
                                                return;
                                            }

                                        }
                                        else if (delete == false)
                                        {
                                            //changes not saved message
                                            MessageBox.Show("User information entered is incorrect!");

                                            //clear text boxes
                                            userIdTxt.Clear();
                                            userNameTxt.Clear();
                                            passwordTxt.Clear();
                                            userIdTxt.Focus();
                                            return;
                                        }
                                    }
                                    //error messaging for user password not on file
                                    else
                                    {
                                        MessageBox.Show("User Password entered not on file!");
                                        passwordTxt.Clear();
                                        passwordTxt.Focus();
                                    }
                                }
                                //error messaging for username not on file
                                else
                                {
                                    MessageBox.Show("Username entered not on file!");
                                    userNameTxt.Clear();
                                    userNameTxt.Focus();
                                }
                            }
                            //error messaging for user id not on file
                            else
                            {
                                MessageBox.Show("User ID entered not on file!");
                                userIdTxt.Clear();
                                userIdTxt.Focus();
                            }
                        }
                        //error messaging for non numeric User ID
                        else
                        {
                            MessageBox.Show("User ID must be of type numeric!");
                            userIdTxt.Clear();
                            userIdTxt.Focus();
                        }
                    }
                    //error messaging for blank text fields
                    else
                    {
                        MessageBox.Show("Please fill out all fields!");
                        userIdTxt.Clear();
                        userNameTxt.Clear();
                        passwordTxt.Clear();
                        userIdTxt.Focus();
                    }
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
    }
}
