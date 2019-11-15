using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ICBINJPOSController
{
    public class User
    {
        //string to hold message box messages
        public string msgtxt;

        //flag to show message box messages
        static public bool employeeLoggedIn;
        static public bool managerLoggedIn;
        static public bool administratorLoggedIn;
        static public bool loginIncorrect;
        static public bool loginBlank;

        //to users names and passwords to hold textbox text
        public static string employeeName;
        public static string employeePass;
        public static string managerName;
        public static string managerPass;
        public static string adminName;
        public static string adminPass;


        public void EmployeeLogin(string name, string password)
        {
            employeeName = name;
            employeePass = password;

            //if employee username and password correct
            if (File.empUserName.Contains(employeeName) && File.empPassWord.Contains(employeePass) && Array.IndexOf(File.empUserName.ToArray(), employeeName) == Array.IndexOf(File.empPassWord.ToArray(), employeePass))
            {
                employeeLoggedIn = true;
                msgtxt = "Successful Login!";

                //login login attempt to loginHist.txt file
                StreamWriter successHist = new StreamWriter("loginHist.txt", true);
                successHist.WriteLine("*" + employeeName + " ," + employeePass + " ," + msgtxt + " - " + DateTime.Now);
                successHist.Close();
            }

            //if employee username or password incorrect
            else if ((employeeName != "") || (employeePass != "") && Array.IndexOf(File.empUserName.ToArray(), employeeName) != Array.IndexOf(File.empPassWord.ToArray(), employeePass))
            {
                loginIncorrect = true;
                msgtxt = "User Name and Password Incorrect!  Please Check and try again!";

                //login login attempt to loginHist.txt file
                StreamWriter incorrectHist = new StreamWriter("loginHist.txt", true);
                incorrectHist.WriteLine("*" + employeeName + " ," + employeePass + " ," + msgtxt + " - " + DateTime.Now);
                incorrectHist.Close();
            }

            //if username or password left blank
            else if ((employeeName == "") || (employeePass == "" || employeeName != "" && employeePass == "" || employeeName == "" && employeePass != ""))
            {
                loginBlank = true;
                msgtxt = "Please Fill out both Username and Password Fields!";

                //login login attempt to loginHist.txt file
                StreamWriter blankFormHist = new StreamWriter("loginHist.txt", true);
                blankFormHist.WriteLine("*" + employeeName + " ," + employeePass + " ," + msgtxt + " - " + DateTime.Now);
                blankFormHist.Close();
            }
            
        }

        public void ManagerLogin(string name, string password)
        {
            managerName = name;
            managerPass = password;

            //if manager username and password correct
            if (File.mgtUserName.Contains(managerName) && File.mgtPassWord.Contains(managerPass) && Array.IndexOf(File.mgtUserName.ToArray(), managerName) == Array.IndexOf(File.mgtPassWord.ToArray(), managerPass))
            {
                managerLoggedIn = true;
                msgtxt = "Successful Login!";
 
                //login login attempt to loginHist.txt file
                StreamWriter successHist = new StreamWriter("loginHist.txt", true);
                successHist.WriteLine("*" + managerName + " ," + managerPass + " ," + msgtxt + " - " + DateTime.Now);
                successHist.Close();
            }

            //if manager username or password incorrect
            else if ((managerName != "") || (managerPass != "") && Array.IndexOf(File.mgtUserName.ToArray(), managerName) != Array.IndexOf(File.mgtPassWord.ToArray(), managerPass))
            {
                loginIncorrect = true;
                msgtxt = "User Name and Password Incorrect!  Please Check and try again!";

                //login login attempt to loginHist.txt file
                StreamWriter incorrectHist = new StreamWriter("loginHist.txt", true);
                incorrectHist.WriteLine("*" + managerName + " ," + managerPass + " ," + msgtxt + " - " + DateTime.Now);
                incorrectHist.Close();
            }

            //if username or password left blank
            else if ((employeeName == "") || (employeePass == "" || employeeName != "" && employeePass == "" || employeeName == "" && employeePass != ""))
            {
                loginBlank = true;
                msgtxt = "Please Fill out both Username and Password Fields!";

                //login login attempt to loginHist.txt file
                StreamWriter blankFormHist = new StreamWriter("loginHist.txt", true);
                blankFormHist.WriteLine("*" + managerName + " ," + managerPass + " ," + msgtxt + " - " + DateTime.Now);
                blankFormHist.Close();
            }

        }

        public void AdminLogin(string name, string password)
        {
            adminName = name;
            adminPass = password;

            //if administrator username and password correct
            if (File.adminUserName.Contains(adminName) && File.adminPassWord.Contains(adminPass) && Array.IndexOf(File.adminUserName.ToArray(), adminName) == Array.IndexOf(File.adminPassWord.ToArray(), adminPass))
            {
                administratorLoggedIn = true;
                msgtxt = "Successful Login!";

                //login login attempt to loginHist.txt file
                StreamWriter successHist = new StreamWriter("loginHist.txt", true);
                successHist.WriteLine("*" + adminName + " ," + adminPass + " ," + msgtxt + " - " + DateTime.Now);
                successHist.Close();
            }

            //if administrator username or password incorrect
            else if ((adminName != "") || (adminPass != "") && Array.IndexOf(File.adminUserName.ToArray(), adminName) != Array.IndexOf(File.adminPassWord.ToArray(), adminPass))
            {
                loginIncorrect = true;
                msgtxt = "User Name and Password Incorrect!  Please Check and try again!";

                //login login attempt to loginHist.txt file
                StreamWriter incorrectHist = new StreamWriter("loginHist.txt", true);
                incorrectHist.WriteLine("*" + adminName + " ," + adminPass + " ," + msgtxt + " - " + DateTime.Now);
                incorrectHist.Close();
            }

            //if username or password left blank
            else if ((employeeName == "") || (employeePass == "" || employeeName != "" && employeePass == "" || employeeName == "" && employeePass != ""))
            {
                loginBlank = true;
                msgtxt = "Please Fill out both Username and Password Fields!";

                //login login attempt to loginHist.txt file
                StreamWriter blankFormHist = new StreamWriter("loginHist.txt", true);
                blankFormHist.WriteLine("*" + adminName + " ," + adminPass + " ," + msgtxt + " - " + DateTime.Now);
                blankFormHist.Close();
            }
        }

        //sign out button functions
        public void SignOut()
        {
            AdminScreen adminScreen = new AdminScreen();
            LoginScreen loginScreen = new LoginScreen();
            OptionsScreen optionScreen = new OptionsScreen();
            RegisterScreen registerScreen = new RegisterScreen();
            ReportingScreen reportingScreen = new ReportingScreen();

            //set all login bool to false
            User.employeeLoggedIn = false;
            User.managerLoggedIn = false;
            User.administratorLoggedIn = false;

            //hide all open screens and open login screen
            adminScreen.Hide();
            optionScreen.Hide();
            registerScreen.Hide();
            reportingScreen.Hide();
            loginScreen.ShowDialog();

            
        }
    }
}
