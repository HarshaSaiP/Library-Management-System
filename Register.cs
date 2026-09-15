using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if(!(PassTxt.Text == ConfirmPassTxt.Text))
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }
            else if(String.IsNullOrEmpty(PassTxt.Text) || String.IsNullOrEmpty(ConfirmPassTxt.Text) || String.IsNullOrEmpty(UsernameTxt.Text)|| String.IsNullOrEmpty(FullNameTxt.Text)|| String.IsNullOrEmpty(PhnNumberTxt.Text))
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }
            else
            {
                MessageBox.Show("Registration Successful!");
            }
        }
    }
}
