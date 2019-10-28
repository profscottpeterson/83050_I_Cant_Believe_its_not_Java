using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICBINJPOSController
{
    public partial class RegisterScreen : Form
    {
        // Fields go here
        string currentDate = DateTime.Now.ToShortDateString();

        public RegisterScreen()
        {
            InitializeComponent();
           
            // Show current date.
            lblTodaysDate.Text = currentDate;
        }

        private void coffeeButton_Click(object sender, EventArgs e)
        {

        }

        
    }
}
