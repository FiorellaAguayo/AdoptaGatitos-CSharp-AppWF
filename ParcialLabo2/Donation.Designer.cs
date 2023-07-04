namespace ParcialLabo2
{
    partial class Donation
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
            btnDonate = new Button();
            groupBox2 = new GroupBox();
            txbCardNumber = new TextBox();
            label8 = new Label();
            label5 = new Label();
            chkBancoPatagonia = new CheckBox();
            chkMercadoPago = new CheckBox();
            numAmount = new NumericUpDown();
            label4 = new Label();
            txbMessage = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            txbPhone = new TextBox();
            label7 = new Label();
            txbEmail = new TextBox();
            txbDirection = new TextBox();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            txbFullName = new TextBox();
            btn_Autocomplete = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnDonate
            // 
            btnDonate.Location = new Point(462, 346);
            btnDonate.Name = "btnDonate";
            btnDonate.Size = new Size(289, 32);
            btnDonate.TabIndex = 28;
            btnDonate.Text = "Donar";
            btnDonate.UseVisualStyleBackColor = true;
            btnDonate.Click += btnDonate_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txbCardNumber);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(chkBancoPatagonia);
            groupBox2.Controls.Add(chkMercadoPago);
            groupBox2.Controls.Add(numAmount);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(462, 56);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(289, 186);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Medio de pago";
            // 
            // txbCardNumber
            // 
            txbCardNumber.Location = new Point(131, 94);
            txbCardNumber.Multiline = true;
            txbCardNumber.Name = "txbCardNumber";
            txbCardNumber.Size = new Size(139, 23);
            txbCardNumber.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(15, 94);
            label8.Name = "label8";
            label8.Size = new Size(116, 17);
            label8.TabIndex = 22;
            label8.Text = "Numero de tarjeta";
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
            // chkBancoPatagonia
            // 
            chkBancoPatagonia.AutoSize = true;
            chkBancoPatagonia.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            chkBancoPatagonia.Location = new Point(131, 59);
            chkBancoPatagonia.Name = "chkBancoPatagonia";
            chkBancoPatagonia.Size = new Size(124, 21);
            chkBancoPatagonia.TabIndex = 20;
            chkBancoPatagonia.Text = "Banco Patagonia";
            chkBancoPatagonia.UseVisualStyleBackColor = true;
            // 
            // chkMercadoPago
            // 
            chkMercadoPago.AutoSize = true;
            chkMercadoPago.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            chkMercadoPago.Location = new Point(131, 32);
            chkMercadoPago.Name = "chkMercadoPago";
            chkMercadoPago.Size = new Size(114, 21);
            chkMercadoPago.TabIndex = 19;
            chkMercadoPago.Text = "Mercado Pago";
            chkMercadoPago.UseVisualStyleBackColor = true;
            // 
            // numAmount
            // 
            numAmount.Location = new Point(131, 135);
            numAmount.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(139, 27);
            numAmount.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(78, 139);
            label4.Name = "label4";
            label4.Size = new Size(47, 17);
            label4.TabIndex = 11;
            label4.Text = "Monto";
            // 
            // txbMessage
            // 
            txbMessage.Location = new Point(113, 277);
            txbMessage.Multiline = true;
            txbMessage.Name = "txbMessage";
            txbMessage.Size = new Size(284, 101);
            txbMessage.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(50, 277);
            label3.Name = "label3";
            label3.Size = new Size(57, 17);
            label3.TabIndex = 25;
            label3.Text = "Mensaje";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbPhone);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txbEmail);
            groupBox1.Controls.Add(txbDirection);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txbFullName);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(50, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(374, 202);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles del usuario";
            // 
            // txbPhone
            // 
            txbPhone.Location = new Point(128, 148);
            txbPhone.Multiline = true;
            txbPhone.Name = "txbPhone";
            txbPhone.Size = new Size(219, 29);
            txbPhone.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(64, 154);
            label7.Name = "label7";
            label7.Size = new Size(58, 17);
            label7.TabIndex = 18;
            label7.Text = "Teléfono";
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(128, 108);
            txbEmail.Multiline = true;
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(219, 29);
            txbEmail.TabIndex = 17;
            // 
            // txbDirection
            // 
            txbDirection.Location = new Point(128, 73);
            txbDirection.Multiline = true;
            txbDirection.Name = "txbDirection";
            txbDirection.Size = new Size(219, 29);
            txbDirection.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(60, 77);
            label6.Name = "label6";
            label6.Size = new Size(62, 17);
            label6.TabIndex = 13;
            label6.Text = "Direccion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(83, 114);
            label2.Name = "label2";
            label2.Size = new Size(39, 17);
            label2.TabIndex = 9;
            label2.Text = "Email";
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
            // txbFullName
            // 
            txbFullName.Location = new Point(128, 36);
            txbFullName.Multiline = true;
            txbFullName.Name = "txbFullName";
            txbFullName.Size = new Size(219, 29);
            txbFullName.TabIndex = 1;
            // 
            // btn_Autocomplete
            // 
            btn_Autocomplete.Location = new Point(50, 27);
            btn_Autocomplete.Name = "btn_Autocomplete";
            btn_Autocomplete.Size = new Size(98, 23);
            btn_Autocomplete.TabIndex = 29;
            btn_Autocomplete.Text = "autocompletar";
            btn_Autocomplete.UseVisualStyleBackColor = true;
            btn_Autocomplete.Click += btn_Autocomplete_Click;
            // 
            // Donation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Autocomplete);
            Controls.Add(btnDonate);
            Controls.Add(groupBox2);
            Controls.Add(txbMessage);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Donation";
            Text = "Donation";
            Load += Donation_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDonate;
        private GroupBox groupBox2;
        private Label label5;
        private CheckBox chkBancoPatagonia;
        private CheckBox chkMercadoPago;
        private NumericUpDown numAmount;
        private Label label4;
        private TextBox txbMessage;
        private Label label3;
        private GroupBox groupBox1;
        private TextBox txbPhone;
        private Label label7;
        private TextBox txbEmail;
        private TextBox txbDirection;
        private Label label6;
        private Label label2;
        private Label label1;
        private TextBox txbFullName;
        private TextBox txbCardNumber;
        private Label label8;
        private Button btn_Autocomplete;
    }
}