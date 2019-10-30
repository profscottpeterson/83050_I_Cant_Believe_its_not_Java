using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICBINJPOSController
{
    public class User
    {
        /// <summary>
        /// This field is a username
        /// </summary>
        private static string uName;

        /// <summary>
        /// Gets or sets username.
        /// </summary>
        public static string UName
        {
            get { return uName; }
            set { uName = value; }
        }

        private string password;

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        private string name;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        private int id;
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Login()
        {
            string loginMessage = "";
            // Send login message to file.

            return loginMessage;
        }

        public string Logout()
        {
            string logoutMessage = "";

            // Send logout message to file.
            return logoutMessage;
        }
    }
}
