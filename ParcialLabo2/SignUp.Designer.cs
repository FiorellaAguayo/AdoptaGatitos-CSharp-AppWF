namespace ParcialLabo2
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            btnBack = new Button();
            txbPassword = new TextBox();
            txbUser = new TextBox();
            txbEmail = new TextBox();
            btnSignUp = new Button();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            SeePassword = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SeePassword).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(177, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 31;
            btnBack.Text = "Login";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txbPassword
            // 
            txbPassword.BorderStyle = BorderStyle.None;
            txbPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbPassword.ForeColor = SystemColors.WindowFrame;
            txbPassword.Location = new Point(240, 155);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(315, 20);
            txbPassword.TabIndex = 30;
            txbPassword.Text = "CONTRASEÑA";
            txbPassword.Enter += txbPassword_Enter;
            txbPassword.Leave += txbPassword_Leave;
            // 
            // txbUser
            // 
            txbUser.BorderStyle = BorderStyle.None;
            txbUser.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbUser.ForeColor = SystemColors.WindowFrame;
            txbUser.Location = new Point(240, 120);
            txbUser.Name = "txbUser";
            txbUser.Size = new Size(315, 20);
            txbUser.TabIndex = 29;
            txbUser.Text = "USUARIO";
            txbUser.Enter += txbUser_Enter;
            txbUser.Leave += txbUser_Leave;
            // 
            // txbEmail
            // 
            txbEmail.BorderStyle = BorderStyle.None;
            txbEmail.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbEmail.ForeColor = SystemColors.WindowFrame;
            txbEmail.Location = new Point(240, 85);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(315, 20);
            txbEmail.TabIndex = 28;
            txbEmail.Text = "EMAIL";
            txbEmail.Enter += txbEmail_Enter;
            txbEmail.Leave += txbEmail_Leave;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.FromArgb(224, 224, 224);
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.FlatAppearance.MouseDownBackColor = Color.LightSlateGray;
            btnSignUp.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSignUp.ForeColor = SystemColors.WindowFrame;
            btnSignUp.Location = new Point(240, 218);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(315, 32);
            btnSignUp.TabIndex = 27;
            btnSignUp.Text = "REGÍSTRAME";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 255);
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(337, 28);
            label1.Name = "label1";
            label1.Size = new Size(118, 33);
            label1.TabIndex = 26;
            label1.Text = "SIGN UP";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Violet;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(161, 273);
            panel1.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(26, 151);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 40;
            label3.Text = "Patitas Suaves";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(26, 66);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(111, 95);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 39;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.userSignUp;
            pictureBox1.Location = new Point(207, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(207, 78);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(207, 148);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 35;
            pictureBox3.TabStop = false;
            // 
            // SeePassword
            // 
            SeePassword.Image = Properties.Resources.hide;
            SeePassword.Location = new Point(240, 181);
            SeePassword.Name = "SeePassword";
            SeePassword.Size = new Size(27, 26);
            SeePassword.TabIndex = 36;
            SeePassword.TabStop = false;
            SeePassword.Click += SeePassword_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(620, 273);
            Controls.Add(SeePassword);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(btnBack);
            Controls.Add(txbPassword);
            Controls.Add(txbUser);
            Controls.Add(txbEmail);
            Controls.Add(btnSignUp);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SignUp";
            Opacity = 0.9D;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            Load += SignUp_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)SeePassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private TextBox txbPassword;
        private TextBox txbUser;
        private TextBox txbEmail;
        private Button btnSignUp;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label3;
        private PictureBox pictureBox4;
        private PictureBox SeePassword;
    }
}