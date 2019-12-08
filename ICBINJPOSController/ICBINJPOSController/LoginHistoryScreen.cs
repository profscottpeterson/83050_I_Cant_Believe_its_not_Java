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
    public partial class LoginHistoryScreen : Form
    {
        public LoginHistoryScreen()
        {
            InitializeComponent();
        }

        //load screen
        private void LoginHistoryScreen_Load(object sender, EventArgs e)
        {
            //open file and write to list box
            using (StreamReader histStream = new StreamReader("loginHist.txt"))
            {
                string hist;

                while ((hist = histStream.ReadLine()) != null)
                {
                    loginHistLbx.Items.Add(hist);
                }
            }
        }

        //go back to admin screen
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            loginHistLbx.Items.Clear();
        }
    }
}
