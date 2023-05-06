namespace PrimerParcial
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
            label1 = new Label();
            btn_SignUp = new Button();
            txb_Email = new TextBox();
            txb_Usser = new TextBox();
            txb_Password = new TextBox();
            btn_Back = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 255);
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(199, 23);
            label1.Name = "label1";
            label1.Size = new Size(118, 33);
            label1.TabIndex = 3;
            label1.Text = "SIGN UP";
            // 
            // btn_SignUp
            // 
            btn_SignUp.BackColor = Color.FromArgb(224, 224, 224);
            btn_SignUp.FlatAppearance.BorderSize = 0;
            btn_SignUp.FlatAppearance.MouseDownBackColor = Color.LightSlateGray;
            btn_SignUp.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btn_SignUp.FlatStyle = FlatStyle.Flat;
            btn_SignUp.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_SignUp.ForeColor = SystemColors.WindowFrame;
            btn_SignUp.Location = new Point(114, 208);
            btn_SignUp.Name = "btn_SignUp";
            btn_SignUp.Size = new Size(315, 32);
            btn_SignUp.TabIndex = 18;
            btn_SignUp.Text = "REGÍSTRAME";
            btn_SignUp.UseVisualStyleBackColor = false;
            btn_SignUp.Click += btn_SignUp_Click;
            // 
            // txb_Email
            // 
            txb_Email.BorderStyle = BorderStyle.None;
            txb_Email.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_Email.ForeColor = SystemColors.WindowFrame;
            txb_Email.Location = new Point(114, 75);
            txb_Email.Name = "txb_Email";
            txb_Email.Size = new Size(315, 20);
            txb_Email.TabIndex = 22;
            txb_Email.Text = "EMAIL";
            txb_Email.Enter += txb_Email_Enter;
            txb_Email.Leave += txb_Email_Leave;
            // 
            // txb_Usser
            // 
            txb_Usser.BorderStyle = BorderStyle.None;
            txb_Usser.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_Usser.ForeColor = SystemColors.WindowFrame;
            txb_Usser.Location = new Point(114, 112);
            txb_Usser.Name = "txb_Usser";
            txb_Usser.Size = new Size(315, 20);
            txb_Usser.TabIndex = 23;
            txb_Usser.Text = "USUARIO";
            txb_Usser.Enter += txb_Usser_Enter;
            txb_Usser.Leave += txb_Usser_Leave;
            // 
            // txb_Password
            // 
            txb_Password.BorderStyle = BorderStyle.None;
            txb_Password.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_Password.ForeColor = SystemColors.WindowFrame;
            txb_Password.Location = new Point(114, 152);
            txb_Password.Name = "txb_Password";
            txb_Password.Size = new Size(315, 20);
            txb_Password.TabIndex = 24;
            txb_Password.Text = "CONTRASEÑA";
            txb_Password.Enter += txb_Password_Enter;
            txb_Password.Leave += txb_Password_Leave;
            // 
            // btn_Back
            // 
            btn_Back.Location = new Point(12, 12);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(75, 23);
            btn_Back.TabIndex = 25;
            btn_Back.Text = "Login";
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += btn_Back_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(509, 273);
            Controls.Add(btn_Back);
            Controls.Add(txb_Password);
            Controls.Add(txb_Usser);
            Controls.Add(txb_Email);
            Controls.Add(btn_SignUp);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUp";
            Text = "SignUp";
            Load += SignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_SignUp;
        private TextBox txb_Email;
        private TextBox txb_Usser;
        private TextBox txb_Password;
        private Button btn_Back;
    }
}