using Npgsql;
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
            //Check if the password and confirm password fields match
            if (!(PassTxt.Text == ConfirmPassTxt.Text))
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
                // Insert user data into the database
                string cs = "Host=localhost;Port=5432;Database=libraryManagement;Username=postgres;Password=harsha";
                using (NpgsqlConnection conn = new NpgsqlConnection(cs))
                {
                    conn.Open();
                    String query = "INSERT INTO Users (Username, FullName, PhoneNumber, Password) VALUES (@Username, @FullName, @PhoneNumber, @Password)";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", UsernameTxt.Text);
                        cmd.Parameters.AddWithValue("@FullName", FullNameTxt.Text);
                        cmd.Parameters.AddWithValue("@PhoneNumber", PhnNumberTxt.Text);
                        cmd.Parameters.AddWithValue("@Password", PassTxt.Text);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
                this.Hide();
                MessageBox.Show("Registration Successful!");
                LOGIN loginForm = new LOGIN();
                loginForm.ShowDialog();
                this.Close();

            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            //clear all the text fields
            UsernameTxt.Clear();
            FullNameTxt.Clear();
            PhnNumberTxt.Clear();
            PassTxt.Clear();
            ConfirmPassTxt.Clear();
        }
    }
}
