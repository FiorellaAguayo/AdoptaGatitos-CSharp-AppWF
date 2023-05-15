namespace PrimerParcial
{
    partial class Login
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
            btn_Login = new Button();
            label1 = new Label();
            txb_Usser = new TextBox();
            txb_Password = new TextBox();
            ll_SignUp = new LinkLabel();
            label2 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.White;
            btn_Login.FlatAppearance.BorderSize = 0;
            btn_Login.FlatAppearance.MouseDownBackColor = Color.LightSlateGray;
            btn_Login.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.ForeColor = SystemColors.WindowFrame;
            btn_Login.Location = new Point(254, 190);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(315, 32);
            btn_Login.TabIndex = 3;
            btn_Login.Text = "ACCEDER";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(362, 27);
            label1.Name = "label1";
            label1.Size = new Size(100, 33);
            label1.TabIndex = 2;
            label1.Text = "LOGIN";
            // 
            // txb_Usser
            // 
            txb_Usser.BorderStyle = BorderStyle.None;
            txb_Usser.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_Usser.ForeColor = SystemColors.WindowFrame;
            txb_Usser.Location = new Point(254, 103);
            txb_Usser.Name = "txb_Usser";
            txb_Usser.Size = new Size(315, 20);
            txb_Usser.TabIndex = 1;
            txb_Usser.Text = "USUARIO";
            txb_Usser.Enter += txb_Usser_Enter;
            txb_Usser.Leave += txb_Usser_Leave;
            // 
            // txb_Password
            // 
            txb_Password.BorderStyle = BorderStyle.None;
            txb_Password.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_Password.ForeColor = SystemColors.WindowFrame;
            txb_Password.Location = new Point(254, 138);
            txb_Password.Name = "txb_Password";
            txb_Password.Size = new Size(315, 20);
            txb_Password.TabIndex = 2;
            txb_Password.Text = "CONTRASEÑA";
            txb_Password.Enter += txb_Password_Enter;
            txb_Password.Leave += txb_Password_Leave;
            // 
            // ll_SignUp
            // 
            ll_SignUp.ActiveLinkColor = SystemColors.Highlight;
            ll_SignUp.AutoSize = true;
            ll_SignUp.Location = new Point(435, 249);
            ll_SignUp.Name = "ll_SignUp";
            ll_SignUp.Size = new Size(59, 15);
            ll_SignUp.TabIndex = 0;
            ll_SignUp.TabStop = true;
            ll_SignUp.Text = "Regístrate";
            ll_SignUp.LinkClicked += ll_SignUp_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.WindowFrame;
            label2.Location = new Point(309, 249);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 7;
            label2.Text = "¿No tienes una cuenta?";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(161, 273);
            panel1.TabIndex = 8;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(649, 273);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(ll_SignUp);
            Controls.Add(txb_Password);
            Controls.Add(txb_Usser);
            Controls.Add(btn_Login);
            Controls.Add(label1);
            ForeColor = SystemColors.Highlight;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Login";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Login;
        private Label label1;
        private TextBox txb_Password;
        private LinkLabel ll_SignUp;
        private Label label2;
        public TextBox txb_Usser;
        private Panel panel1;
    }
}