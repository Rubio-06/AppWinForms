namespace WinFormsApp2
{
    partial class UpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnValidUpdate = new Button();
            btnCancelUpdate = new Button();
            tbNameUpdate = new TextBox();
            tbEmailUpdate = new TextBox();
            panel1 = new Panel();
            lblTitle = new Label();
            errorEmailUpdate = new Label();
            errorUpdateName = new Label();
            lblEmailUpdate = new Label();
            lblNameUpdate = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnValidUpdate
            // 
            btnValidUpdate.BackColor = Color.DarkSlateBlue;
            btnValidUpdate.Enabled = false;
            btnValidUpdate.ForeColor = Color.White;
            btnValidUpdate.Location = new Point(255, 351);
            btnValidUpdate.Name = "btnValidUpdate";
            btnValidUpdate.Size = new Size(135, 40);
            btnValidUpdate.TabIndex = 0;
            btnValidUpdate.Text = "Update";
            btnValidUpdate.UseVisualStyleBackColor = false;
            btnValidUpdate.Click += btnValidUpdate_Click;
            // 
            // btnCancelUpdate
            // 
            btnCancelUpdate.BackColor = SystemColors.ControlLight;
            btnCancelUpdate.Location = new Point(112, 351);
            btnCancelUpdate.Name = "btnCancelUpdate";
            btnCancelUpdate.Size = new Size(135, 40);
            btnCancelUpdate.TabIndex = 1;
            btnCancelUpdate.Text = "Cancel";
            btnCancelUpdate.UseVisualStyleBackColor = false;
            btnCancelUpdate.Click += btnCancelUpdate_Click_1;
            // 
            // tbNameUpdate
            // 
            tbNameUpdate.Location = new Point(46, 105);
            tbNameUpdate.Name = "tbNameUpdate";
            tbNameUpdate.Size = new Size(278, 27);
            tbNameUpdate.TabIndex = 2;
            tbNameUpdate.TextChanged += tbNameUpdate_TextChanged;
            // 
            // tbEmailUpdate
            // 
            tbEmailUpdate.Location = new Point(46, 217);
            tbEmailUpdate.Name = "tbEmailUpdate";
            tbEmailUpdate.Size = new Size(278, 27);
            tbEmailUpdate.TabIndex = 3;
            tbEmailUpdate.TextChanged += tbEmailUpdate_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(errorEmailUpdate);
            panel1.Controls.Add(errorUpdateName);
            panel1.Controls.Add(lblEmailUpdate);
            panel1.Controls.Add(lblNameUpdate);
            panel1.Controls.Add(tbNameUpdate);
            panel1.Controls.Add(tbEmailUpdate);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(378, 333);
            panel1.TabIndex = 4;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F);
            lblTitle.ForeColor = Color.DarkSlateBlue;
            lblTitle.Location = new Point(119, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(128, 28);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "Update Form";
            // 
            // errorEmailUpdate
            // 
            errorEmailUpdate.AutoSize = true;
            errorEmailUpdate.ForeColor = Color.Red;
            errorEmailUpdate.Location = new Point(101, 247);
            errorEmailUpdate.Name = "errorEmailUpdate";
            errorEmailUpdate.Size = new Size(158, 20);
            errorEmailUpdate.TabIndex = 7;
            errorEmailUpdate.Text = "Missing / Invalid Email";
            errorEmailUpdate.Visible = false;
            // 
            // errorUpdateName
            // 
            errorUpdateName.AutoSize = true;
            errorUpdateName.ForeColor = Color.Red;
            errorUpdateName.Location = new Point(128, 135);
            errorUpdateName.Name = "errorUpdateName";
            errorUpdateName.Size = new Size(103, 20);
            errorUpdateName.TabIndex = 6;
            errorUpdateName.Text = "Missing Name";
            errorUpdateName.Visible = false;
            // 
            // lblEmailUpdate
            // 
            lblEmailUpdate.AutoSize = true;
            lblEmailUpdate.Location = new Point(49, 194);
            lblEmailUpdate.Name = "lblEmailUpdate";
            lblEmailUpdate.Size = new Size(53, 20);
            lblEmailUpdate.TabIndex = 5;
            lblEmailUpdate.Text = "Email :";
            // 
            // lblNameUpdate
            // 
            lblNameUpdate.AutoSize = true;
            lblNameUpdate.Location = new Point(49, 82);
            lblNameUpdate.Name = "lblNameUpdate";
            lblNameUpdate.Size = new Size(56, 20);
            lblNameUpdate.TabIndex = 4;
            lblNameUpdate.Text = "Name :";
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 403);
            Controls.Add(panel1);
            Controls.Add(btnCancelUpdate);
            Controls.Add(btnValidUpdate);
            Name = "UpdateForm";
            Text = "Update";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnValidUpdate;
        private Button btnCancelUpdate;
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel1;
        private Label lblTitle;
        private Label errorEmailUpdate;
        private Label errorUpdateName;
        private Label lblEmailUpdate;
        private Label lblNameUpdate;
        private TextBox tbNameUpdate;
        private TextBox tbEmailUpdate;
    }
}