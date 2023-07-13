namespace PatitasSuaves
{
    partial class Donate
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
            dgvDonations = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txbEmail = new TextBox();
            txbUser = new TextBox();
            txbMessage = new TextBox();
            rbMp = new RadioButton();
            rbPayPal = new RadioButton();
            rbMastercard = new RadioButton();
            numAmount = new NumericUpDown();
            btnDonate = new Button();
            btnAutocomplete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDonations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PaleGoldenrod;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Chocolate;
            label1.Location = new Point(26, 31);
            label1.Name = "label1";
            label1.Size = new Size(385, 60);
            label1.TabIndex = 0;
            label1.Text = "¿Querés colaborar?\r\nCompleta este formulario y sé parte de Patitas Suaves,\r\n tu ayuda será registrada con la de los demás usuarios \r\n";
            // 
            // dgvDonations
            // 
            dgvDonations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonations.Location = new Point(498, 62);
            dgvDonations.Name = "dgvDonations";
            dgvDonations.RowTemplate.Height = 25;
            dgvDonations.Size = new Size(290, 338);
            dgvDonations.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(79, 122);
            label2.Name = "label2";
            label2.Size = new Size(40, 17);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(228, 130);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(70, 210);
            label4.Name = "label4";
            label4.Size = new Size(49, 17);
            label4.TabIndex = 4;
            label4.Text = "Monto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(19, 247);
            label5.Name = "label5";
            label5.Size = new Size(100, 17);
            label5.TabIndex = 5;
            label5.Text = "Medio de pago";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(47, 307);
            label6.Name = "label6";
            label6.Size = new Size(58, 17);
            label6.TabIndex = 6;
            label6.Text = "Mensaje";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(65, 166);
            label7.Name = "label7";
            label7.Size = new Size(54, 17);
            label7.TabIndex = 7;
            label7.Text = "Usuario";
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(136, 122);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(197, 23);
            txbEmail.TabIndex = 8;
            // 
            // txbUser
            // 
            txbUser.Location = new Point(136, 166);
            txbUser.Name = "txbUser";
            txbUser.Size = new Size(197, 23);
            txbUser.TabIndex = 9;
            // 
            // txbMessage
            // 
            txbMessage.Location = new Point(126, 309);
            txbMessage.Multiline = true;
            txbMessage.Name = "txbMessage";
            txbMessage.Size = new Size(193, 91);
            txbMessage.TabIndex = 10;
            txbMessage.Text = "\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // rbMp
            // 
            rbMp.AutoSize = true;
            rbMp.Location = new Point(136, 247);
            rbMp.Name = "rbMp";
            rbMp.Size = new Size(102, 19);
            rbMp.TabIndex = 11;
            rbMp.TabStop = true;
            rbMp.Text = "Mercado Pago";
            rbMp.UseVisualStyleBackColor = true;
            // 
            // rbPayPal
            // 
            rbPayPal.AutoSize = true;
            rbPayPal.Location = new Point(136, 272);
            rbPayPal.Name = "rbPayPal";
            rbPayPal.Size = new Size(60, 19);
            rbPayPal.TabIndex = 12;
            rbPayPal.TabStop = true;
            rbPayPal.Text = "PayPal";
            rbPayPal.UseVisualStyleBackColor = true;
            // 
            // rbMastercard
            // 
            rbMastercard.AutoSize = true;
            rbMastercard.Location = new Point(244, 247);
            rbMastercard.Name = "rbMastercard";
            rbMastercard.Size = new Size(86, 19);
            rbMastercard.TabIndex = 13;
            rbMastercard.TabStop = true;
            rbMastercard.Text = "MasterCard";
            rbMastercard.UseVisualStyleBackColor = true;
            // 
            // numAmount
            // 
            numAmount.Location = new Point(135, 210);
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(150, 23);
            numAmount.TabIndex = 14;
            // 
            // btnDonate
            // 
            btnDonate.BackColor = Color.Chocolate;
            btnDonate.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDonate.Location = new Point(352, 352);
            btnDonate.Name = "btnDonate";
            btnDonate.Size = new Size(124, 48);
            btnDonate.TabIndex = 15;
            btnDonate.Text = "Donar";
            btnDonate.UseVisualStyleBackColor = false;
            btnDonate.Click += btnDonate_Click;
            // 
            // btnAutocomplete
            // 
            btnAutocomplete.Location = new Point(352, 306);
            btnAutocomplete.Name = "btnAutocomplete";
            btnAutocomplete.Size = new Size(120, 27);
            btnAutocomplete.TabIndex = 49;
            btnAutocomplete.Text = "Autocompletar";
            btnAutocomplete.UseVisualStyleBackColor = true;
            btnAutocomplete.Click += btnAutocomplete_Click;
            // 
            // Donate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAutocomplete);
            Controls.Add(btnDonate);
            Controls.Add(numAmount);
            Controls.Add(rbMastercard);
            Controls.Add(rbPayPal);
            Controls.Add(rbMp);
            Controls.Add(txbMessage);
            Controls.Add(txbUser);
            Controls.Add(txbEmail);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvDonations);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Donate";
            Text = "Donate";
            Activated += Donate_Activated;
            Load += Donate_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDonations).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvDonations;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txbEmail;
        private TextBox txbUser;
        private TextBox txbMessage;
        private RadioButton rbMp;
        private RadioButton rbPayPal;
        private RadioButton rbMastercard;
        private NumericUpDown numAmount;
        private Button btnDonate;
        private Button btnAutocomplete;
    }
}