namespace PatitasSuaves
{
    partial class Contact
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
            txbName = new TextBox();
            txbEmail = new TextBox();
            txbMessage = new TextBox();
            btnSend = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnBePart = new Button();
            btnCancelBePart = new Button();
            pictureBox1 = new PictureBox();
            btnAutocomplete = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumVioletRed;
            label1.Location = new Point(73, 32);
            label1.Name = "label1";
            label1.Size = new Size(134, 30);
            label1.TabIndex = 0;
            label1.Text = "Contáctenos";
            // 
            // txbName
            // 
            txbName.Location = new Point(462, 58);
            txbName.Name = "txbName";
            txbName.Size = new Size(285, 23);
            txbName.TabIndex = 1;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(462, 124);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(285, 23);
            txbEmail.TabIndex = 2;
            // 
            // txbMessage
            // 
            txbMessage.Location = new Point(462, 195);
            txbMessage.Multiline = true;
            txbMessage.Name = "txbMessage";
            txbMessage.Size = new Size(285, 69);
            txbMessage.TabIndex = 3;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(529, 291);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(187, 46);
            btnSend.TabIndex = 4;
            btnSend.Text = "ENVIAR";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(43, 89);
            label2.Name = "label2";
            label2.Size = new Size(275, 189);
            label2.TabIndex = 5;
            label2.Text = "Puede visitarnos en:\r\nCalle 123, Ciudad Gatuna\r\n\r\ntelefono: 1123303770\r\n\r\nRedes sociales\r\nFacebook: Patitas Suaves Adopcion \r\nInstagram: @patitas_suaves_adopcion\r\n\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(378, 61);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 6;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(393, 127);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Firebrick;
            label5.Location = new Point(378, 195);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 8;
            label5.Text = "Mensaje";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkSlateBlue;
            label6.Location = new Point(31, 319);
            label6.Name = "label6";
            label6.Size = new Size(413, 48);
            label6.TabIndex = 9;
            label6.Text = "¿Querés ser parte? \r\n\r\nHaz click  en \"Ser Parte\" y le llegará la petición al administrador";
            // 
            // btnBePart
            // 
            btnBePart.BackColor = Color.SlateBlue;
            btnBePart.Location = new Point(31, 383);
            btnBePart.Name = "btnBePart";
            btnBePart.Size = new Size(151, 46);
            btnBePart.TabIndex = 10;
            btnBePart.Text = "Ser Parte";
            btnBePart.UseVisualStyleBackColor = false;
            btnBePart.Click += btnBePart_Click;
            // 
            // btnCancelBePart
            // 
            btnCancelBePart.BackColor = Color.SlateBlue;
            btnCancelBePart.Location = new Point(188, 383);
            btnCancelBePart.Name = "btnCancelBePart";
            btnCancelBePart.Size = new Size(151, 46);
            btnCancelBePart.TabIndex = 11;
            btnCancelBePart.Text = "Cancelar petición";
            btnCancelBePart.UseVisualStyleBackColor = false;
            btnCancelBePart.Click += btnCancelBePart_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.happy__1_;
            pictureBox1.Location = new Point(46, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 26);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // btnAutocomplete
            // 
            btnAutocomplete.Location = new Point(462, 12);
            btnAutocomplete.Name = "btnAutocomplete";
            btnAutocomplete.Size = new Size(120, 27);
            btnAutocomplete.TabIndex = 50;
            btnAutocomplete.Text = "Autocompletar";
            btnAutocomplete.UseVisualStyleBackColor = true;
            btnAutocomplete.Click += btnAutocomplete_Click;
            // 
            // Contact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAutocomplete);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancelBePart);
            Controls.Add(btnBePart);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSend);
            Controls.Add(txbMessage);
            Controls.Add(txbEmail);
            Controls.Add(txbName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Contact";
            Text = "Contact";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbName;
        private TextBox txbEmail;
        private TextBox txbMessage;
        private Button btnSend;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnBePart;
        private Button btnCancelBePart;
        private PictureBox pictureBox1;
        private Button btnAutocomplete;
    }
}