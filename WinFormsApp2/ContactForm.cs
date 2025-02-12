using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;

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

            // Insert Buttons In Columns
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
        private void formIsValid()
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

        // Add Contact Button
        private void btnAddContact_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connexionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Contacts VALUES (@Name, @Email);", conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Email", email);

                cmd.ExecuteNonQuery();
            }

            gridViewUpdate();

            MessageBox.Show("Contact added succesfully");
        }

        // Disconnect Button
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Hide();
        }

        // Cell Event
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Remove User 
            if (e.ColumnIndex == dataGridView1.Columns["btnRemove"].Index && e.RowIndex >= 0)
            {
                using (SqlConnection conn = new SqlConnection(connexionString))
                {
                    int IDCol = dataGridView1.Columns["ID"].Index;
                    int ID = (int)dataGridView1.Rows[e.RowIndex].Cells[IDCol].Value;

                    conn.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM Contacts WHERE ID = @ID;", conn);
                    cmd.Parameters.AddWithValue("@ID", ID);

                    cmd.ExecuteNonQuery();
                }

                gridViewUpdate();

                MessageBox.Show("Delete succesfully");
            }

            // Update User 
            if (e.ColumnIndex == dataGridView1.Columns["btnUpdate"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                string name = (string)row.Cells["DGName"].Value;
                string email = (string)row.Cells["Email"].Value;
                int id = (int)row.Cells["ID"].Value;

                UpdateForm formUpdate = new UpdateForm(name, email, id);
                formUpdate.ShowDialog();

                gridViewUpdate();
            }
        }

        // Double Click DataGrid
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            string name = (string)row.Cells["DGName"].Value;
            string email = (string)row.Cells["Email"].Value;
            int id = (int)row.Cells["ID"].Value;

            UpdateForm updateForm = new UpdateForm(name, email, id);
            updateForm.ShowDialog();
        }

        // GridView Update 
        private void gridViewUpdate()
        {
            using (SqlConnection conn = new SqlConnection(connexionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Contacts;", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }

            if (dataGridView1.RowCount > 0)
            {
                btnExportPDF.Enabled = true;
            }
            else
            {
                btnExportPDF.Enabled = false;
            }


        }
        private void ContactForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {

        }

        
    }
}
