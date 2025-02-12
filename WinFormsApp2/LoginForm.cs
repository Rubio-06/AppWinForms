using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Policy;

namespace WinFormsApp2
{
    public partial class LoginForm : Form
    {
        string login = "";
        string password = "";

        // Connexion String
        string connexionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PC\\source\\repos\\WinFormsApp2\\WinFormsApp2\\Database1.mdf;Integrated Security=True";

        List<string[]> user = new List<string[]>();

        public LoginForm()
        {
            InitializeComponent();
        }

        // Verif Login Form
        private void formIsValid()
        {
            if (password == "" || login == "")
            {
                btnLogin.Enabled = false;
                errorLogin.Visible = true;
            }
            else
            {
                btnLogin.Enabled = true;
                errorLogin.Visible = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connexionString))
                {
                    user = new List<string[]>();
                    // SQL REQUEST
                    string querySring = "SELECT * FROM users";

                    // CONNEXION
                    SqlCommand command = new SqlCommand(querySring, conn); 
                    conn.Open();                    

                    // SCAN DATA
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            user.Add([(string)reader[1], (string)reader[2]]);
                        }
                    }
                }

                if (user.Count > 0)
                {
                    foreach (string[] data in user)
                    {
                        string hashedPassword = generateHashPassword(password);

                        if (data[0] == login && data[1] == hashedPassword)
                        {
                            ContactForm form = new ContactForm();
                            form.Show();
                            this.Hide();
                        } 
                        else
                        {
                            MessageBox.Show("Login invalid");
                        }
                    }
                } 
                else
                {
                    MessageBox.Show("error");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {
            login = tbLogin.Text;
            formIsValid();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            password = tbPassword.Text;
            formIsValid();
        }

        private string generateHashPassword(string password)
        {
            byte[] salt = BitConverter.GetBytes(06122006);

            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password!,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));

            return hashed;
        }
    }
}
