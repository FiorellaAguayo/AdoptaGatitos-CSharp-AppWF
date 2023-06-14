namespace ParcialLabo2
{
    partial class Account
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
            btnDelete = new Button();
            btnLogout = new Button();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblId = new Label();
            lblUserName = new Label();
            lblPassword = new Label();
            lblEmail = new Label();
            lblRole = new Label();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(451, 362);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(231, 38);
            btnDelete.TabIndex = 27;
            btnDelete.Text = "Eliminar cuenta";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.Location = new Point(121, 362);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(231, 38);
            btnLogout.TabIndex = 26;
            btnLogout.Text = "Cerrar sesión";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(42, 168);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 25;
            label6.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(42, 139);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 23;
            label4.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(42, 110);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 22;
            label3.Text = "Rol:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(42, 81);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 21;
            label2.Text = "User: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(42, 51);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 20;
            label1.Text = "ID:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblId.Location = new Point(134, 51);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 19;
            lblId.Text = "ID";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserName.Location = new Point(134, 81);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(38, 20);
            lblUserName.TabIndex = 18;
            lblUserName.Text = "User";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(134, 139);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(83, 20);
            lblPassword.TabIndex = 16;
            lblPassword.Text = "Contraseña";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(134, 168);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 15;
            lblEmail.Text = "Email";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblRole.Location = new Point(134, 110);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(31, 20);
            lblRole.TabIndex = 14;
            lblRole.Text = "Rol";
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnLogout);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblId);
            Controls.Add(lblUserName);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblRole);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Account";
            Text = "Account";
            Load += Account_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnLogout;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblId;
        private Label lblUserName;
        private Label lblPassword;
        private Label lblEmail;
        private Label lblRole;
    }
}