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
            label1 = new Label();
            emailError = new Label();
            nameError = new Label();
            btnDisconnect = new Button();
            btnAddContact = new Button();
            lblEmail = new Label();
            lblName = new Label();
            tbEmail = new TextBox();
            tbName = new TextBox();
            contactPanel = new Panel();
            dataGridView1 = new DataGridView();
            btnExportPDF = new Button();
            formPanel.SuspendLayout();
            contactPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // formPanel
            // 
            formPanel.Controls.Add(label1);
            formPanel.Controls.Add(emailError);
            formPanel.Controls.Add(nameError);
            formPanel.Controls.Add(btnDisconnect);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.DarkSlateBlue;
            label1.Location = new Point(90, 29);
            label1.Name = "label1";
            label1.Size = new Size(122, 28);
            label1.TabIndex = 5;
            label1.Text = "Add Contact";
            // 
            // emailError
            // 
            emailError.AutoSize = true;
            emailError.ForeColor = Color.Red;
            emailError.Location = new Point(72, 243);
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
            nameError.Location = new Point(100, 151);
            nameError.Name = "nameError";
            nameError.Size = new Size(103, 20);
            nameError.TabIndex = 4;
            nameError.Text = "Missing Name";
            nameError.Visible = false;
            // 
            // btnDisconnect
            // 
            btnDisconnect.BackColor = SystemColors.ControlLight;
            btnDisconnect.ForeColor = Color.Black;
            btnDisconnect.Location = new Point(36, 354);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(225, 50);
            btnDisconnect.TabIndex = 3;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = false;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // btnAddContact
            // 
            btnAddContact.BackColor = Color.DarkSlateBlue;
            btnAddContact.Enabled = false;
            btnAddContact.ForeColor = Color.White;
            btnAddContact.Location = new Point(36, 298);
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
            lblEmail.Location = new Point(36, 190);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 20);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email :";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(36, 98);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name :";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(36, 213);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(225, 27);
            tbEmail.TabIndex = 2;
            tbEmail.TextChanged += tbEmail_TextChanged;
            // 
            // tbName
            // 
            tbName.Location = new Point(36, 121);
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
            contactPanel.Size = new Size(702, 429);
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
            dataGridView1.Size = new Size(696, 423);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // btnExportPDF
            // 
            btnExportPDF.BackColor = Color.DarkSlateBlue;
            btnExportPDF.Enabled = false;
            btnExportPDF.ForeColor = Color.White;
            btnExportPDF.Location = new Point(870, 451);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new Size(150, 40);
            btnExportPDF.TabIndex = 2;
            btnExportPDF.Text = "Export PDF";
            btnExportPDF.UseVisualStyleBackColor = false;
            btnExportPDF.Click += btnExportPDF_Click;
            // 
            // ContactForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 503);
            Controls.Add(btnExportPDF);
            Controls.Add(contactPanel);
            Controls.Add(formPanel);
            ForeColor = Color.Black;
            Name = "ContactForm";
            Text = "Contact";
            FormClosed += ContactForm_FormClosed;
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
        private Label label1;
        private Button btnDisconnect;
        private Button btnExportPDF;
    }
}
