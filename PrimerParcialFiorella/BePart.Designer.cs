namespace PrimerParcial
{
    partial class BePart
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
            btn_BePart = new Button();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            txb_Password = new TextBox();
            label8 = new Label();
            txb_Phone = new TextBox();
            label7 = new Label();
            txb_Email = new TextBox();
            txb_Direction = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            txb_FullName = new TextBox();
            label5 = new Label();
            txb_Reason = new TextBox();
            rb_FaceToFace = new RadioButton();
            rb_Virtual = new RadioButton();
            label9 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_BePart
            // 
            btn_BePart.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_BePart.Location = new Point(48, 406);
            btn_BePart.Name = "btn_BePart";
            btn_BePart.Size = new Size(891, 45);
            btn_BePart.TabIndex = 0;
            btn_BePart.Text = "Ingresar";
            btn_BePart.UseVisualStyleBackColor = true;
            btn_BePart.Click += btn_BePart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(786, 94);
            label1.Name = "label1";
            label1.Size = new Size(231, 17);
            label1.TabIndex = 2;
            label1.Text = "Muestro lista personas que colaboran";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(48, 42);
            label2.Name = "label2";
            label2.Size = new Size(423, 21);
            label2.TabIndex = 3;
            label2.Text = "Si queres pertenecer a la organizacion completa estos datos";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txb_Password);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txb_Phone);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txb_Email);
            groupBox1.Controls.Add(txb_Direction);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txb_FullName);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(56, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(374, 267);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles del usuario";
            // 
            // txb_Password
            // 
            txb_Password.Location = new Point(86, 185);
            txb_Password.Multiline = true;
            txb_Password.Name = "txb_Password";
            txb_Password.Size = new Size(219, 29);
            txb_Password.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(6, 197);
            label8.Name = "label8";
            label8.Size = new Size(74, 17);
            label8.TabIndex = 20;
            label8.Text = "Contraseña";
            // 
            // txb_Phone
            // 
            txb_Phone.Location = new Point(70, 142);
            txb_Phone.Multiline = true;
            txb_Phone.Name = "txb_Phone";
            txb_Phone.Size = new Size(219, 29);
            txb_Phone.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(6, 154);
            label7.Name = "label7";
            label7.Size = new Size(58, 17);
            label7.TabIndex = 18;
            label7.Text = "Teléfono";
            // 
            // txb_Email
            // 
            txb_Email.Location = new Point(51, 102);
            txb_Email.Multiline = true;
            txb_Email.Name = "txb_Email";
            txb_Email.Size = new Size(219, 29);
            txb_Email.TabIndex = 17;
            txb_Email.TextChanged += txb_Email_TextChanged;
            // 
            // txb_Direction
            // 
            txb_Direction.Location = new Point(74, 65);
            txb_Direction.Multiline = true;
            txb_Direction.Name = "txb_Direction";
            txb_Direction.Size = new Size(219, 29);
            txb_Direction.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(6, 77);
            label6.Name = "label6";
            label6.Size = new Size(62, 17);
            label6.TabIndex = 13;
            label6.Text = "Direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 114);
            label3.Name = "label3";
            label3.Size = new Size(39, 17);
            label3.TabIndex = 9;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 39);
            label4.Name = "label4";
            label4.Size = new Size(116, 17);
            label4.TabIndex = 0;
            label4.Text = "Nombre completo";
            // 
            // txb_FullName
            // 
            txb_FullName.Location = new Point(128, 30);
            txb_FullName.Multiline = true;
            txb_FullName.Name = "txb_FullName";
            txb_FullName.Size = new Size(219, 29);
            txb_FullName.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(485, 166);
            label5.Name = "label5";
            label5.Size = new Size(49, 17);
            label5.TabIndex = 11;
            label5.Text = "Motivo";
            // 
            // txb_Reason
            // 
            txb_Reason.Location = new Point(540, 165);
            txb_Reason.Multiline = true;
            txb_Reason.Name = "txb_Reason";
            txb_Reason.Size = new Size(204, 189);
            txb_Reason.TabIndex = 18;
            // 
            // rb_FaceToFace
            // 
            rb_FaceToFace.AutoSize = true;
            rb_FaceToFace.Location = new Point(635, 96);
            rb_FaceToFace.Name = "rb_FaceToFace";
            rb_FaceToFace.Size = new Size(78, 19);
            rb_FaceToFace.TabIndex = 19;
            rb_FaceToFace.TabStop = true;
            rb_FaceToFace.Text = "Presencial";
            rb_FaceToFace.UseVisualStyleBackColor = true;
            // 
            // rb_Virtual
            // 
            rb_Virtual.AutoSize = true;
            rb_Virtual.Location = new Point(635, 123);
            rb_Virtual.Name = "rb_Virtual";
            rb_Virtual.Size = new Size(59, 19);
            rb_Virtual.TabIndex = 20;
            rb_Virtual.TabStop = true;
            rb_Virtual.Text = "Virtual";
            rb_Virtual.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(476, 94);
            label9.Name = "label9";
            label9.Size = new Size(153, 20);
            label9.TabIndex = 21;
            label9.Text = "Cómo queres ayudar?";
            // 
            // BePart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 479);
            Controls.Add(label9);
            Controls.Add(rb_Virtual);
            Controls.Add(rb_FaceToFace);
            Controls.Add(txb_Reason);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_BePart);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BePart";
            Text = "BePart";
            Load += BePart_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_BePart;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label4;
        private TextBox txb_FullName;
        private Label label5;
        private TextBox txb_Reason;
        private Label label8;
        private RadioButton rb_FaceToFace;
        private RadioButton rb_Virtual;
        private Label label9;
        private TextBox txb_Password;
        private TextBox txb_Phone;
        private TextBox txb_Email;
        private TextBox txb_Direction;
    }
}