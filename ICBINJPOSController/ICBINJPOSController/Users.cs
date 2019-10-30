using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ICBINJPOSController
{
    public class Users
    {
        //string to hold message box messages
        public string msgtxt;

        //to users names and passwords to hold textbox text
        public string EmployeeName;
        public string EmployeePass;
        public string ManagerName;
        public string ManagerPass;
        public string AdminName;
        public string AdminPass;

        //lists to hold ID, Usernames and Passwords
        List<string> empID = new List<string>();
        List<string> empUserName = new List<string>();
        List<string> empPassWord = new List<string>();
        List<string> mgtID = new List<string>();
        List<string> mgtUserName = new List<string>();
        List<string> mgtPassWord = new List<string>();
        List<string> adminID = new List<string>();
        List<string> adminUserName = new List<string>();
        List<string> adminPassWord = new List<string>();

        //Instance of new screens
        LoginScreen loginScreen = new LoginScreen();
        RegisterScreen registerScreen = new RegisterScreen();
        OptionsScreen optionsScreen = new OptionsScreen();
        ReportingScreen reportingScreen = new ReportingScreen();


        public void OpenEmpFile()
        {
            //instantiate stream reader file
            StreamReader streamEmployee = new StreamReader("employeeAuth.txt");
            string emp = "";

            //read line emp, split each whitespace separated entry to an array & add to list
            while ((emp = streamEmployee.ReadLine()) != null)
            {
                string[] entries = emp.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                empID.Add(entries[0]);
                empUserName.Add(entries[1]);
                empPassWord.Add(entries[2]);
            }
        }

        public void OpenMgtFile()
        {
            //instantiate stream reader file
            StreamReader streamManagement = new StreamReader("managementAuth.txt");
            string mgt = "";

            //read line mgt, split each whitespace separated entry to an array & add to list
            while ((mgt = streamManagement.ReadLine()) != null)
            {
                string[] entries = mgt.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                mgtID.Add(entries[0]);
                mgtUserName.Add(entries[1]);
                mgtPassWord.Add(entries[2]);
            }
        }

        public void OpenAdminFile()
        {
            //instantiate stream reader file
            StreamReader streamAdministrator = new StreamReader("administratorAuth.txt");
            string admin = "";

            //read line admin, split each whitespace separated entry to an array & add to list
            while ((admin = streamAdministrator.ReadLine()) != null)
            {
                string[] entries = admin.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                adminID.Add(entries[0]);
                adminUserName.Add(entries[1]);
                adminPassWord.Add(entries[2]);
            }
        }


        public void EmployeeLogin(string name, string password)
        {
            this.EmployeeName = name;
            this.EmployeePass = password;

            //if employee username and password correct
            if (empUserName.Contains(EmployeeName) && empPassWord.Contains(EmployeePass) && Array.IndexOf(empUserName.ToArray(), EmployeeName) == Array.IndexOf(empPassWord.ToArray(), EmployeePass))
            {
                //MessageBox.Show("Successful Login!");
                msgtxt = "Successful Login!";
                loginScreen.Hide();
                registerScreen.ShowDialog();


                //login login attempt to loginHist.txt file
                StreamWriter successHist = new StreamWriter("loginHist.txt", true);
                successHist.WriteLine("*" + EmployeeName + " ," + EmployeePass + " ," + msgtxt + " - " + DateTime.Now);
                successHist.Close();
            }

            //if employee username or password incorrect
            else if ((EmployeeName != "") || (EmployeePass != "") && Array.IndexOf(empUserName.ToArray(), EmployeeName) != Array.IndexOf(empPassWord.ToArray(), EmployeePass))
            {
                //MessageBox.Show("User Name and Password Incorrect!  Please Check and try again!");
                msgtxt = "User Name and Password Incorrect!  Please Check and try again!";

                //login login attempt to loginHist.txt file
                StreamWriter incorrectHist = new StreamWriter("loginHist.txt", true);
                incorrectHist.WriteLine("*" + EmployeeName + " ," + EmployeePass + " ," + msgtxt + " - " + DateTime.Now);
                incorrectHist.Close();
            }

            //if username or password left blank
            else if ((EmployeeName == "") || (EmployeePass == ""))
            {
                //MessageBox.Show("Please Fill out both Username and Password Fields!");
                msgtxt = "Please Fill out both Username and Password Fields!";

                //login login attempt to loginHist.txt file
                StreamWriter blankFormHist = new StreamWriter("loginHist.txt", true);
                blankFormHist.WriteLine("*" + EmployeeName + " ," + EmployeePass + " ," + msgtxt + " - " + DateTime.Now);
                blankFormHist.Close();
            }

        }

        public void ManagerLogin(string name, string password)
        {
            this.ManagerName = name;
            this.ManagerPass = password;

            //if manager username and password correct
            if (mgtUserName.Contains(ManagerName) && mgtPassWord.Contains(ManagerPass) && Array.IndexOf(mgtUserName.ToArray(), ManagerName) == Array.IndexOf(mgtPassWord.ToArray(), ManagerPass))
            {
                //MessageBox.Show("Successful Login!");
                msgtxt = "Successful Login!";
                loginScreen.Hide();
                reportingScreen.ShowDialog();


                //login login attempt to loginHist.txt file
                StreamWriter successHist = new StreamWriter("loginHist.txt", true);
                successHist.WriteLine("*" + ManagerName + " ," + ManagerPass + " ," + msgtxt + " - " + DateTime.Now);
                successHist.Close();
            }

            //if manager username or password incorrect
            else if ((ManagerName != "") || (ManagerPass != "") && Array.IndexOf(mgtUserName.ToArray(), ManagerName) != Array.IndexOf(mgtPassWord.ToArray(), ManagerPass))
            {
                //MessageBox.Show("User Name and Password Incorrect!  Please Check and try again!");
                msgtxt = "User Name and Password Incorrect!  Please Check and try again!";

                //login login attempt to loginHist.txt file
                StreamWriter incorrectHist = new StreamWriter("loginHist.txt", true);
                incorrectHist.WriteLine("*" + ManagerName + " ," + ManagerPass + " ," + msgtxt + " - " + DateTime.Now);
                incorrectHist.Close();
            }

            //if username or password left blank
            else if ((ManagerName == "") || (ManagerPass == ""))
            {
                //MessageBox.Show("Please Fill out both Username and Password Fields!");
                msgtxt = "Please Fill out both Username and Password Fields!";

                //login login attempt to loginHist.txt file
                StreamWriter blankFormHist = new StreamWriter("loginHist.txt", true);
                blankFormHist.WriteLine("*" + ManagerName + " ," + ManagerPass + " ," + msgtxt + " - " + DateTime.Now);
                blankFormHist.Close();
            }

        }

        public void AdminLogin(string name, string password)
        {
            this.AdminName = name;
            this.AdminPass = password;

            //if administrator username and password correct
            if (adminUserName.Contains(AdminName) && adminPassWord.Contains(AdminPass) && Array.IndexOf(adminUserName.ToArray(), AdminName) == Array.IndexOf(adminPassWord.ToArray(), AdminPass))
            {
                //MessageBox.Show("Successful Login!");
                msgtxt = "Successful Login!";
                loginScreen.Hide();
                optionsScreen.ShowDialog();


                //login login attempt to loginHist.txt file
                StreamWriter successHist = new StreamWriter("loginHist.txt", true);
                successHist.WriteLine("*" + AdminName + " ," + AdminPass + " ," + msgtxt + " - " + DateTime.Now);
                successHist.Close();
            }

            //if administrator username or password incorrect
            else if ((AdminName != "") || (AdminPass != "") && Array.IndexOf(adminUserName.ToArray(), AdminName) != Array.IndexOf(adminPassWord.ToArray(), AdminPass))
            {
                //MessageBox.Show("User Name and Password Incorrect!  Please Check and try again!");
                msgtxt = "User Name and Password Incorrect!  Please Check and try again!";

                //login login attempt to loginHist.txt file
                StreamWriter incorrectHist = new StreamWriter("loginHist.txt", true);
                incorrectHist.WriteLine("*" + AdminName + " ," + AdminPass + " ," + msgtxt + " - " + DateTime.Now);
                incorrectHist.Close();
            }

            //if username or password left blank
            else if ((AdminName == "") || (AdminPass == ""))
            {
                //MessageBox.Show("Please Fill out both Username and Password Fields!");
                msgtxt = "Please Fill out both Username and Password Fields!";

                //login login attempt to loginHist.txt file
                StreamWriter blankFormHist = new StreamWriter("loginHist.txt", true);
                blankFormHist.WriteLine("*" + AdminName + " ," + AdminPass + " ," + msgtxt + " - " + DateTime.Now);
                blankFormHist.Close();
            }
        }

       
    }
}
