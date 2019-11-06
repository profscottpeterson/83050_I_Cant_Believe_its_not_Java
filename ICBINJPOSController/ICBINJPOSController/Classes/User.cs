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
        public bool employeeLoggedIn;
        public bool managerLoggedIn;
        public bool administratorLoggedIn;
        public bool loginIncorrect;
        public bool loginBlank;

        //to users names and passwords to hold textbox text
        public static string employeeName;
        public static string employeePass;
        public static string managerName;
        public static string managerPass;
        public static string adminName;
        public static string adminPass;

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
            employeeName = name;
            employeePass = password;

            //if employee username and password correct
            if (empUserName.Contains(employeeName) && empPassWord.Contains(employeePass) && Array.IndexOf(empUserName.ToArray(), employeeName) == Array.IndexOf(empPassWord.ToArray(), employeePass))
            {
                employeeLoggedIn = true;
                msgtxt = "Successful Login!";

                //login login attempt to loginHist.txt file
                StreamWriter successHist = new StreamWriter("loginHist.txt", true);
                successHist.WriteLine("*" + employeeName + " ," + employeePass + " ," + msgtxt + " - " + DateTime.Now);
                successHist.Close();
            }

            //if employee username or password incorrect
            else if ((employeeName != "") || (employeePass != "") && Array.IndexOf(empUserName.ToArray(), employeeName) != Array.IndexOf(empPassWord.ToArray(), employeePass))
            {
                loginIncorrect = true;
                msgtxt = "User Name and Password Incorrect!  Please Check and try again!";

                //login login attempt to loginHist.txt file
                StreamWriter incorrectHist = new StreamWriter("loginHist.txt", true);
                incorrectHist.WriteLine("*" + employeeName + " ," + employeePass + " ," + msgtxt + " - " + DateTime.Now);
                incorrectHist.Close();
            }

            //if username or password left blank
            else if ((employeeName == "") || (employeePass == ""))
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
            if (mgtUserName.Contains(managerName) && mgtPassWord.Contains(managerPass) && Array.IndexOf(mgtUserName.ToArray(), managerName) == Array.IndexOf(mgtPassWord.ToArray(), managerPass))
            {
                managerLoggedIn = true;
                msgtxt = "Successful Login!";
 
                //login login attempt to loginHist.txt file
                StreamWriter successHist = new StreamWriter("loginHist.txt", true);
                successHist.WriteLine("*" + managerName + " ," + managerPass + " ," + msgtxt + " - " + DateTime.Now);
                successHist.Close();
            }

            //if manager username or password incorrect
            else if ((managerName != "") || (managerPass != "") && Array.IndexOf(mgtUserName.ToArray(), managerName) != Array.IndexOf(mgtPassWord.ToArray(), managerPass))
            {
                loginIncorrect = true;
                msgtxt = "User Name and Password Incorrect!  Please Check and try again!";

                //login login attempt to loginHist.txt file
                StreamWriter incorrectHist = new StreamWriter("loginHist.txt", true);
                incorrectHist.WriteLine("*" + managerName + " ," + managerPass + " ," + msgtxt + " - " + DateTime.Now);
                incorrectHist.Close();
            }

            //if username or password left blank
            else if ((managerName == "") || (managerPass == ""))
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
            if (adminUserName.Contains(adminName) && adminPassWord.Contains(adminPass) && Array.IndexOf(adminUserName.ToArray(), adminName) == Array.IndexOf(adminPassWord.ToArray(), adminPass))
            {
                administratorLoggedIn = true;
                msgtxt = "Successful Login!";

                //login login attempt to loginHist.txt file
                StreamWriter successHist = new StreamWriter("loginHist.txt", true);
                successHist.WriteLine("*" + adminName + " ," + adminPass + " ," + msgtxt + " - " + DateTime.Now);
                successHist.Close();
            }

            //if administrator username or password incorrect
            else if ((adminName != "") || (adminPass != "") && Array.IndexOf(adminUserName.ToArray(), adminName) != Array.IndexOf(adminPassWord.ToArray(), adminPass))
            {
                loginIncorrect = true;
                msgtxt = "User Name and Password Incorrect!  Please Check and try again!";

                //login login attempt to loginHist.txt file
                StreamWriter incorrectHist = new StreamWriter("loginHist.txt", true);
                incorrectHist.WriteLine("*" + adminName + " ," + adminPass + " ," + msgtxt + " - " + DateTime.Now);
                incorrectHist.Close();
            }

            //if username or password left blank
            else if ((adminName == "") || (adminPass == ""))
            {
                loginBlank = true;
                msgtxt = "Please Fill out both Username and Password Fields!";

                //login login attempt to loginHist.txt file
                StreamWriter blankFormHist = new StreamWriter("loginHist.txt", true);
                blankFormHist.WriteLine("*" + adminName + " ," + adminPass + " ," + msgtxt + " - " + DateTime.Now);
                blankFormHist.Close();
            }
        }


    }
}
