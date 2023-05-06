namespace PrimerParcial
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
            label1 = new Label();
            lbl_Rol = new Label();
            label3 = new Label();
            lbl_User = new Label();
            lbl_Email = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(394, 192);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "account";
            // 
            // lbl_Rol
            // 
            lbl_Rol.AutoSize = true;
            lbl_Rol.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Rol.Location = new Point(62, 68);
            lbl_Rol.Name = "lbl_Rol";
            lbl_Rol.Size = new Size(31, 20);
            lbl_Rol.TabIndex = 1;
            lbl_Rol.Text = "Rol";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(62, 108);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 2;
            label3.Text = "Nombre completo";
            // 
            // lbl_User
            // 
            lbl_User.AutoSize = true;
            lbl_User.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_User.Location = new Point(62, 88);
            lbl_User.Name = "lbl_User";
            lbl_User.Size = new Size(38, 20);
            lbl_User.TabIndex = 3;
            lbl_User.Text = "User";
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Email.Location = new Point(62, 128);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(46, 20);
            lbl_Email.TabIndex = 4;
            lbl_Email.Text = "Email";
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_Email);
            Controls.Add(lbl_User);
            Controls.Add(label3);
            Controls.Add(lbl_Rol);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Account";
            Text = "Account";
            Load += Account_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_Rol;
        private Label label3;
        private Label lbl_User;
        private Label lbl_Email;
    }
}