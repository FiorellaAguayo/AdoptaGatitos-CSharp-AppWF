namespace PrimerParcialFiorella
{
    partial class DonationCompleteData
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
            txb_NameComplete = new TextBox();
            groupBox1 = new GroupBox();
            txb_Email = new TextBox();
            txb_Direction = new TextBox();
            label6 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txb_Message = new TextBox();
            num_Amount = new NumericUpDown();
            chk_MercadoPago = new CheckBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            chk_Card = new CheckBox();
            btn_Register = new Button();
            btn_Cancel = new Button();
            label7 = new Label();
            txb_Phone = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_Amount).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 39);
            label1.Name = "label1";
            label1.Size = new Size(116, 17);
            label1.TabIndex = 0;
            label1.Text = "Nombre completo";
            // 
            // txb_NameComplete
            // 
            txb_NameComplete.Location = new Point(128, 36);
            txb_NameComplete.Multiline = true;
            txb_NameComplete.Name = "txb_NameComplete";
            txb_NameComplete.Size = new Size(219, 23);
            txb_NameComplete.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txb_Phone);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txb_Email);
            groupBox1.Controls.Add(txb_Direction);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txb_NameComplete);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(63, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(374, 186);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles del usuario";
            // 
            // txb_Email
            // 
            txb_Email.Location = new Point(51, 108);
            txb_Email.Multiline = true;
            txb_Email.Name = "txb_Email";
            txb_Email.Size = new Size(219, 23);
            txb_Email.TabIndex = 17;
            // 
            // txb_Direction
            // 
            txb_Direction.Location = new Point(74, 71);
            txb_Direction.Multiline = true;
            txb_Direction.Name = "txb_Direction";
            txb_Direction.Size = new Size(219, 23);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 114);
            label2.Name = "label2";
            label2.Size = new Size(39, 17);
            label2.TabIndex = 9;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(63, 263);
            label3.Name = "label3";
            label3.Size = new Size(57, 17);
            label3.TabIndex = 10;
            label3.Text = "Mensaje";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(78, 113);
            label4.Name = "label4";
            label4.Size = new Size(47, 17);
            label4.TabIndex = 11;
            label4.Text = "Monto";
            // 
            // txb_Message
            // 
            txb_Message.Location = new Point(126, 263);
            txb_Message.Multiline = true;
            txb_Message.Name = "txb_Message";
            txb_Message.Size = new Size(284, 101);
            txb_Message.TabIndex = 17;
            // 
            // num_Amount
            // 
            num_Amount.Location = new Point(131, 113);
            num_Amount.Name = "num_Amount";
            num_Amount.Size = new Size(120, 27);
            num_Amount.TabIndex = 18;
            // 
            // chk_MercadoPago
            // 
            chk_MercadoPago.AutoSize = true;
            chk_MercadoPago.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            chk_MercadoPago.Location = new Point(131, 32);
            chk_MercadoPago.Name = "chk_MercadoPago";
            chk_MercadoPago.Size = new Size(114, 21);
            chk_MercadoPago.TabIndex = 19;
            chk_MercadoPago.Text = "Mercado Pago";
            chk_MercadoPago.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(chk_Card);
            groupBox2.Controls.Add(chk_MercadoPago);
            groupBox2.Controls.Add(num_Amount);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(475, 55);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(289, 161);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Medio de pago";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(15, 32);
            label5.Name = "label5";
            label5.Size = new Size(110, 17);
            label5.TabIndex = 21;
            label5.Text = "Transferencia por";
            // 
            // chk_Card
            // 
            chk_Card.AutoSize = true;
            chk_Card.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            chk_Card.Location = new Point(131, 59);
            chk_Card.Name = "chk_Card";
            chk_Card.Size = new Size(66, 21);
            chk_Card.TabIndex = 20;
            chk_Card.Text = "Tarjeta";
            chk_Card.UseVisualStyleBackColor = true;
            // 
            // btn_Register
            // 
            btn_Register.Location = new Point(475, 332);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(136, 32);
            btn_Register.TabIndex = 22;
            btn_Register.Text = "Inscribirse";
            btn_Register.UseVisualStyleBackColor = true;
            btn_Register.Click += btn_Register_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(628, 332);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(136, 32);
            btn_Cancel.TabIndex = 23;
            btn_Cancel.Text = "Cancelar";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
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
            // txb_Phone
            // 
            txb_Phone.Location = new Point(70, 148);
            txb_Phone.Multiline = true;
            txb_Phone.Name = "txb_Phone";
            txb_Phone.Size = new Size(219, 23);
            txb_Phone.TabIndex = 19;
            // 
            // DonationCompleteData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 399);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Register);
            Controls.Add(groupBox2);
            Controls.Add(txb_Message);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DonationCompleteData";
            Text = "DonationCompleteData";
            Load += DonationCompleteData_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_Amount).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txb_NameComplete;
        private GroupBox groupBox1;
        private Label label6;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txb_Message;
        private NumericUpDown num_Amount;
        private TextBox txb_Email;
        private TextBox txb_Direction;
        private CheckBox chk_MercadoPago;
        private GroupBox groupBox2;
        private Label label5;
        private CheckBox chk_Card;
        private Button btn_Register;
        private Button btn_Cancel;
        private TextBox txb_Phone;
        private Label label7;
    }
}