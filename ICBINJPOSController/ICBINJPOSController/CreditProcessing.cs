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
    public partial class CreditProcessing : Form
    {
        public CreditProcessing()
        {
            InitializeComponent();
        }

        bool cardNumSelected = false;
        bool cardExpSelected = false;
        string userInput = "";
        string cardExpInput = "";

        public void DirectInputToTextbox(string input)
        {
            userInput += input;

            if (cardNumSelected)
            {
                tbxEnterCardNum.Text = userInput;
            }
            else if (cardExpSelected)
            {
                tbxEnterExpiration.Text = userInput;
            }
            else
            {
                MessageBox.Show("Please select a textbox enter data.");
            }


           
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            DirectInputToTextbox("1");
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            DirectInputToTextbox("2");
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            DirectInputToTextbox("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            DirectInputToTextbox("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            DirectInputToTextbox("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            DirectInputToTextbox("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            DirectInputToTextbox("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            DirectInputToTextbox("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            DirectInputToTextbox("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            DirectInputToTextbox("0");
        }
        private void btnDecPt_Click(object sender, EventArgs e)
        {
            DirectInputToTextbox(".");
        }

        private void btnSlash_Click(object sender, EventArgs e)
        {
            DirectInputToTextbox("/");
        }

       


    }
}
