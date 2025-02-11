using System.Xml.Linq;

namespace WinFormsApp2
{
    partial class ContactForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            formPanel = new Panel();
            emailError = new Label();
            nameError = new Label();
            btnAddContact = new Button();
            lblEmail = new Label();
            lblName = new Label();
            tbEmail = new TextBox();
            tbName = new TextBox();
            contactPanel = new Panel();
            dataGridView1 = new DataGridView();
            formPanel.SuspendLayout();
            contactPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // formPanel
            // 
            formPanel.Controls.Add(emailError);
            formPanel.Controls.Add(nameError);
            formPanel.Controls.Add(btnAddContact);
            formPanel.Controls.Add(lblEmail);
            formPanel.Controls.Add(lblName);
            formPanel.Controls.Add(tbEmail);
            formPanel.Controls.Add(tbName);
            formPanel.Location = new Point(12, 12);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(300, 429);
            formPanel.TabIndex = 0;
            // 
            // emailError
            // 
            emailError.AutoSize = true;
            emailError.ForeColor = Color.Red;
            emailError.Location = new Point(75, 180);
            emailError.Name = "emailError";
            emailError.Size = new Size(158, 20);
            emailError.TabIndex = 4;
            emailError.Text = "Missing Email / Invalid";
            emailError.Visible = false;
            // 
            // nameError
            // 
            nameError.AutoSize = true;
            nameError.ForeColor = Color.Red;
            nameError.Location = new Point(103, 88);
            nameError.Name = "nameError";
            nameError.Size = new Size(103, 20);
            nameError.TabIndex = 4;
            nameError.Text = "Missing Name";
            nameError.Visible = false;
            // 
            // btnAddContact
            // 
            btnAddContact.BackColor = Color.DarkSlateBlue;
            btnAddContact.Enabled = false;
            btnAddContact.ForeColor = Color.White;
            btnAddContact.Location = new Point(39, 235);
            btnAddContact.Name = "btnAddContact";
            btnAddContact.Size = new Size(225, 50);
            btnAddContact.TabIndex = 3;
            btnAddContact.Text = "Add Contact";
            btnAddContact.UseVisualStyleBackColor = false;
            btnAddContact.Click += btnAddContact_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(39, 127);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 20);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email :";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(39, 35);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name :";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(39, 150);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(225, 27);
            tbEmail.TabIndex = 2;
            tbEmail.TextChanged += tbEmail_TextChanged;
            // 
            // tbName
            // 
            tbName.Location = new Point(39, 58);
            tbName.Name = "tbName";
            tbName.Size = new Size(225, 27);
            tbName.TabIndex = 2;
            tbName.TextChanged += tbName_TextChanged;
            // 
            // contactPanel
            // 
            contactPanel.Controls.Add(dataGridView1);
            contactPanel.Location = new Point(318, 12);
            contactPanel.Name = "contactPanel";
            contactPanel.Size = new Size(674, 429);
            contactPanel.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Gray;
            dataGridView1.Location = new Point(3, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(668, 423);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ContactForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 453);
            Controls.Add(contactPanel);
            Controls.Add(formPanel);
            ForeColor = Color.Black;
            Name = "ContactForm";
            Text = "Contact";
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            contactPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel formPanel;
        private Panel contactPanel;
        private Label label3;
        private Label lblEmail;
        private Label lblName;
        private TextBox tbEmail;
        private TextBox tbName;
        private Label emailError;
        private Label nameError;
        private Button btnAddContact;
        private DataGridView dataGridView1;
    }
}
