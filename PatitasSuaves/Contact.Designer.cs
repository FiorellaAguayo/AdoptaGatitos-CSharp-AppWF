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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(43, 32);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
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
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(43, 89);
            label2.Name = "label2";
            label2.Size = new Size(146, 140);
            label2.TabIndex = 5;
            label2.Text = "Nuestra direccion es:\r\ndireccion:\r\ntelefono:\r\n\r\nRedes sociales\r\nFacebook\r\nInstagram\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(380, 61);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(380, 127);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(380, 195);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 8;
            label5.Text = "Mensaje";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 323);
            label6.Name = "label6";
            label6.Size = new Size(286, 30);
            label6.TabIndex = 9;
            label6.Text = "¿Querés ser parte? \r\nHaz click aquí y le llegará la petición al administrador";
            // 
            // button1
            // 
            button1.Location = new Point(46, 386);
            button1.Name = "button1";
            button1.Size = new Size(115, 30);
            button1.TabIndex = 10;
            button1.Text = "Ser Parte";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(167, 386);
            button2.Name = "button2";
            button2.Size = new Size(115, 30);
            button2.TabIndex = 11;
            button2.Text = "Cancelar petición";
            button2.UseVisualStyleBackColor = true;
            // 
            // Contact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
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
            Load += Contact_Load;
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
        private Button button1;
        private Button button2;
    }
}