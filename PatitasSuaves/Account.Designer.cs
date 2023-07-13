namespace PatitasSuaves
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
            lblTotalDonations = new Label();
            lblUser = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            lblRole = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblData = new Label();
            btnDeleteAccount = new Button();
            btnLogOut = new Button();
            SuspendLayout();
            // 
            // lblTotalDonations
            // 
            lblTotalDonations.AutoSize = true;
            lblTotalDonations.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalDonations.Location = new Point(225, 247);
            lblTotalDonations.Name = "lblTotalDonations";
            lblTotalDonations.Size = new Size(75, 20);
            lblTotalDonations.TabIndex = 25;
            lblTotalDonations.Text = "donations";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUser.Location = new Point(224, 96);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(36, 20);
            lblUser.TabIndex = 24;
            lblUser.Text = "user";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(224, 131);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 23;
            lblEmail.Text = "email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(222, 161);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(72, 20);
            lblPassword.TabIndex = 22;
            lblPassword.Text = "password";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblRole.Location = new Point(225, 203);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(35, 20);
            lblRole.TabIndex = 21;
            lblRole.Text = "role";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(74, 203);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 20;
            label5.Text = "Tu rol es:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(74, 131);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 19;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(74, 161);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 18;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(74, 247);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 17;
            label2.Text = "Total de donaciones:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(74, 96);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 16;
            label1.Text = "Nombre de usuario:";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblData.Location = new Point(55, 38);
            lblData.Name = "lblData";
            lblData.Size = new Size(151, 21);
            lblData.TabIndex = 15;
            lblData.Text = "Tus datos están aquí";
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Location = new Point(421, 366);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(147, 38);
            btnDeleteAccount.TabIndex = 14;
            btnDeleteAccount.Text = "Eliminar cuenta";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(224, 366);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(138, 38);
            btnLogOut.TabIndex = 13;
            btnLogOut.Text = "Cerrar sesión";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotalDonations);
            Controls.Add(lblUser);
            Controls.Add(lblEmail);
            Controls.Add(lblPassword);
            Controls.Add(lblRole);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblData);
            Controls.Add(btnDeleteAccount);
            Controls.Add(btnLogOut);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Account";
            Text = "Account";
            Load += Account_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotalDonations;
        private Label lblUser;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblRole;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblData;
        private Button btnDeleteAccount;
        private Button btnLogOut;
    }
}