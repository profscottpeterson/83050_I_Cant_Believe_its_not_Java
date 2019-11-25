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
            //instantiate stream reader file
            using(StreamReader streamEmployee = new StreamReader("employeeAuth.txt"))
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

                //write private list to a static list
                empID = EmpID;
                empUserName = EmpUserName;
                empPassWord = EmpPassWord;
            }        
        }

        public void OpenMgtFile()
        {
            //instantiate stream reader file
            using (StreamReader streamManagement = new StreamReader("managementAuth.txt"))
            {
                //variable to hold line
                string mgt = "";

                //read line mgt, split each whitespace separated entry to an array & add to list
                while ((mgt = streamManagement.ReadLine()) != null && !streamManagement.EndOfStream)
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
            //instantiate stream reader file
            using (StreamReader streamAdministrator = new StreamReader("administratorAuth.txt"))
            {
                //variable to hold line
                string admin = "";

                //read line admin, split each whitespace separated entry to an array & add to list
                while ((admin = streamAdministrator.ReadLine()) != null && !streamAdministrator.EndOfStream)
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
