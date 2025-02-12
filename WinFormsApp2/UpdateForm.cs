using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace WinFormsApp2
{
    public partial class UpdateForm : Form
    {
        string nameUpdate = "";
        string emailUpdate = "";
        int idUpdate;

        bool nameUpdateIsValid = false;
        bool emailUpdateIsValid = false;

        // Connexion String
        string connexionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PC\\source\\repos\\WinFormsApp2\\WinFormsApp2\\Database1.mdf;Integrated Security=True";
        public UpdateForm(string name, string email, int id)
        {
            InitializeComponent();

            nameUpdate = name;
            emailUpdate = email;
            idUpdate = id;

            this.Text = $"Update {name} id: {id}";

            tbNameUpdate.Text = nameUpdate;
            tbEmailUpdate.Text = emailUpdate;
        }

        private void tbNameUpdate_TextChanged(object sender, EventArgs e)
        {
            nameUpdate = tbNameUpdate.Text;
            formIsValid();
        }

        private void tbEmailUpdate_TextChanged(object sender, EventArgs e)
        {
            emailUpdate = tbEmailUpdate.Text;
            formIsValid();
        }

        private void formIsValid()
        {
            // Verif Name
            if (nameUpdate == "")
            {
                errorUpdateName.Visible = true;
                nameUpdateIsValid = false;
            }
            else
            {
                errorUpdateName.Visible = false;
                nameUpdateIsValid = true;

            }

            // Verif Email
            if (!emailUpdate.Contains('@') || emailUpdate == "")
            {
                errorEmailUpdate.Visible = true;
                emailUpdateIsValid = false;
            }
            else
            {
                errorEmailUpdate.Visible = false;
                emailUpdateIsValid = true;
            }

            if(nameUpdateIsValid && emailUpdateIsValid)
            {
                btnValidUpdate.Enabled = true;
            } 
            else
            {
                btnValidUpdate.Enabled = false;
            }
        }

        private void btnValidUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connexionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE Contacts SET DGName = @Name, Email = @Email WHERE ID = @ID", conn);
                    cmd.Parameters.AddWithValue("@Name", nameUpdate);
                    cmd.Parameters.AddWithValue("@Email", emailUpdate);
                    cmd.Parameters.AddWithValue("@ID", idUpdate);

                    cmd.ExecuteNonQuery();
                }

                this.Close();
                MessageBox.Show("contact update succesfully");

            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());

                //MessageBox.Show("value : " + nameUpdate + " | " + emailUpdate + " | " + idUpdate);
                MessageBox.Show($"an error occured : {error.Message}, {error.StackTrace}");
            }
        }

        private void btnCancelUpdate_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
