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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string cs = "Host=localhost;Port=5432;Database=libraryManagement;Username=postgres;Password=harsha";
            using(NpgsqlConnection conn = new NpgsqlConnection(cs))
            {
                conn.Open();
                string que = @"
                    SELECT EXISTS (
                        SELECT 1 FROM public.users
                        WHERE username = @username
                        AND password = @password
                    )";
                using (NpgsqlCommand cmd = new NpgsqlCommand(que, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    bool isValid = (bool)cmd.ExecuteScalar();

                    if (isValid)
                    {
                        MessageBox.Show("Login successful!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                        this.Hide();
                        LOGIN loginform = new LOGIN();
                        loginform.ShowDialog();
                        this.Close(); return;
                    }
                }
            }
        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
