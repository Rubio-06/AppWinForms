using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SqlClient;
using System.Data;

namespace WinFormsApp2
{
    public partial class ContactForm : Form
    {
        // Init Fields
        string name = "";
        string email = "";

        // Valid Fields
        bool emailIsValid = false;
        bool nameIsValid = false;

        // Connexion String
        string connexionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PC\\source\\repos\\WinFormsApp2\\WinFormsApp2\\Database1.mdf;Integrated Security=True";

        public ContactForm()
        {
            InitializeComponent();

            // Connect DataBase
            gridViewUpdate();

            // Update Button
            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();

            btnUpdate.HeaderText = "Update";
            btnUpdate.Text = "Update";
            btnUpdate.Name = "btnUpdate";
            btnUpdate.UseColumnTextForButtonValue = true;

            // Remove Button
            DataGridViewButtonColumn btnRemove = new DataGridViewButtonColumn();

            btnRemove.HeaderText = "Remove";
            btnRemove.Text = "Remove";
            btnRemove.Name = "btnRemove";
            btnRemove.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(btnUpdate);
            dataGridView1.Columns.Add(btnRemove);
        }

        // Update Name 
        private void tbName_TextChanged(object sender, EventArgs e)
        {
            name = tbName.Text;
            formIsValid();
        }

        // Update Email
        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            email = tbEmail.Text;
            formIsValid();
        }

        // Verif Form
        void formIsValid()
        {
            // Verif Name
            if (name == "")
            {
                nameError.Visible = true;
                nameIsValid = false;
            }
            else
            {
                nameError.Visible = false;
                nameIsValid = true;

            }

            // Verif Email
            if (!email.Contains('@') || email == "")
            {
                emailError.Visible = true;
                emailIsValid = false;
            }
            else
            {
                emailError.Visible = false;
                emailIsValid = true;
            }

            // Active Button
            if (nameIsValid && emailIsValid)
            {
                btnAddContact.Enabled = true;
            }
            else
            {
                btnAddContact.Enabled = false;
            }
        }

        // Add Button
        private void btnAddContact_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact added succesfully");

            using (SqlConnection conn  = new SqlConnection(connexionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Contacts VALUES (@Name, @Email)", conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Email", email);

                cmd.ExecuteNonQuery();
            }
        }

        // Cell Event
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Remove User 
            if (e.ColumnIndex == dataGridView1.Columns["btnRemove"].Index && e.RowIndex >= 0)
            {
                using (SqlConnection conn = new SqlConnection(connexionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM Contacts WHERE ID = @ID", conn);
                    cmd.Parameters.AddWithValue("@ID", idToDelete);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Delete succesfully");
            }
        }

        // GridView Update 
        private void gridViewUpdate()
        {
            using (SqlConnection conn = new SqlConnection(connexionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Contacts", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }
    }
}
