using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ICBINJPOSController
{
    public class Files
    {
        //lists to hold ID, Usernames and Passwords
        public static List<string> empID = new List<string>();
        public static List<string> empUserName = new List<string>();
        public static List<string> empPassWord = new List<string>();
        public static List<string> mgtID = new List<string>();
        public static List<string> mgtUserName = new List<string>();
        public static List<string> mgtPassWord = new List<string>();
        public static List<string> adminID = new List<string>();
        public static List<string> adminUserName = new List<string>();
        public static List<string> adminPassWord = new List<string>();


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


        public void OpenEmpFile()
        {
            //clear all list contents upon opening new file
            EmpID.Clear();
            empID.Clear();
            EmpUserName.Clear();
            empUserName.Clear();
            EmpPassWord.Clear();
            empPassWord.Clear();

            //instantiate stream reader file
            using (StreamReader streamEmployee = new StreamReader("employeeAuth.txt"))
            {
                //variable to hold line
                string emp = "";

                //read line emp, split each whitespace separated entry to an array & add to list
                while ((emp = streamEmployee.ReadLine()) != null)
                {
                    string[] entries = emp.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    EmpID.Add(entries[0]);
                    EmpUserName.Add(entries[1]);
                    EmpPassWord.Add(entries[2]);
                }

                //write private list to a static list
                empID = EmpID;
                empUserName = EmpUserName;
                empPassWord = EmpPassWord;

            }
        }

        public void OpenMgtFile()
        {
            //clear all list contents upon opening new file
            MgtID.Clear();
            mgtID.Clear();
            MgtUserName.Clear();
            mgtUserName.Clear();
            MgtPassWord.Clear();
            mgtPassWord.Clear();

            //instantiate stream reader file
            using (StreamReader streamManagement = new StreamReader("managementAuth.txt"))
            {
                //variable to hold line
                string mgt = "";

                //read line mgt, split each whitespace separated entry to an array & add to list
                while ((mgt = streamManagement.ReadLine()) != null)
                {
                    string[] entries = mgt.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    MgtID.Add(entries[0]);
                    MgtUserName.Add(entries[1]);
                    MgtPassWord.Add(entries[2]);
                }

                //write private list to a static list
                mgtID = MgtID;
                mgtUserName = MgtUserName;
                mgtPassWord = MgtPassWord;
            }
        }

        public void OpenAdminFile()
        {
            //clear all list contents upon opening new file
            AdminID.Clear();
            adminID.Clear();
            AdminUserName.Clear();
            adminUserName.Clear();
            AdminPassWord.Clear();
            adminPassWord.Clear();

            //instantiate stream reader file
            using (StreamReader streamAdministrator = new StreamReader("administratorAuth.txt"))
            {
                //variable to hold line
                string admin = "";

                //read line admin, split each whitespace separated entry to an array & add to list
                while ((admin = streamAdministrator.ReadLine()) != null)
                {
                    string[] entries = admin.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    AdminID.Add(entries[0]);
                    AdminUserName.Add(entries[1]);
                    AdminPassWord.Add(entries[2]);
                }

                //write private list to a static list
                adminID = AdminID;
                adminUserName = AdminUserName;
                adminPassWord = AdminPassWord;
            }
        }
    }
}