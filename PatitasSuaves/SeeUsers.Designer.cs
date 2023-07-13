namespace PatitasSuaves
{
    partial class SeeUsers
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
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txbId = new TextBox();
            txbEmail = new TextBox();
            txbRole = new TextBox();
            txbUser = new TextBox();
            label3 = new Label();
            lblId = new Label();
            lblUser = new Label();
            txbPhone = new TextBox();
            txbDonation = new TextBox();
            txbPassword = new TextBox();
            btnDelete = new Button();
            btnModify = new Button();
            btnAdd = new Button();
            dgvUsers = new DataGridView();
            btnJSON = new Button();
            btnPDF = new Button();
            btnCSV = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(364, 385);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 35;
            label7.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(349, 345);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 34;
            label6.Text = "Donaciones";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(349, 314);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 33;
            label5.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(112, 416);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 32;
            label4.Text = "Email";
            // 
            // txbId
            // 
            txbId.Location = new Point(156, 347);
            txbId.Name = "txbId";
            txbId.Size = new Size(167, 23);
            txbId.TabIndex = 31;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(156, 413);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(167, 23);
            txbEmail.TabIndex = 30;
            // 
            // txbRole
            // 
            txbRole.Location = new Point(156, 377);
            txbRole.Name = "txbRole";
            txbRole.Size = new Size(167, 23);
            txbRole.TabIndex = 29;
            // 
            // txbUser
            // 
            txbUser.Location = new Point(156, 311);
            txbUser.Name = "txbUser";
            txbUser.Size = new Size(167, 23);
            txbUser.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 385);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 27;
            label3.Text = "Rol";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(124, 347);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 26;
            lblId.Text = "Id";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(118, 314);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(30, 15);
            lblUser.TabIndex = 25;
            lblUser.Text = "User";
            // 
            // txbPhone
            // 
            txbPhone.Location = new Point(422, 377);
            txbPhone.Name = "txbPhone";
            txbPhone.Size = new Size(167, 23);
            txbPhone.TabIndex = 24;
            // 
            // txbDonation
            // 
            txbDonation.Location = new Point(424, 341);
            txbDonation.Name = "txbDonation";
            txbDonation.Size = new Size(167, 23);
            txbDonation.TabIndex = 23;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(424, 301);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(167, 23);
            txbPassword.TabIndex = 22;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(702, 392);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(133, 28);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnModify
            // 
            btnModify.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnModify.Location = new Point(702, 354);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(133, 27);
            btnModify.TabIndex = 20;
            btnModify.Text = "Modificar";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(702, 311);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(133, 28);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(36, 32);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowTemplate.Height = 25;
            dgvUsers.Size = new Size(667, 244);
            dgvUsers.TabIndex = 18;
            dgvUsers.CellClick += dgvUsers_CellClick;
            dgvUsers.SelectionChanged += dgvUsers_SelectionChanged;
            // 
            // btnJSON
            // 
            btnJSON.Location = new Point(735, 52);
            btnJSON.Name = "btnJSON";
            btnJSON.Size = new Size(100, 34);
            btnJSON.TabIndex = 36;
            btnJSON.Text = "Exportar JSON";
            btnJSON.UseVisualStyleBackColor = true;
            btnJSON.Click += btnJSON_Click;
            // 
            // btnPDF
            // 
            btnPDF.Location = new Point(735, 158);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(100, 34);
            btnPDF.TabIndex = 37;
            btnPDF.Text = "Exportar PDF";
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += btnPDF_Click;
            // 
            // btnCSV
            // 
            btnCSV.Location = new Point(735, 105);
            btnCSV.Name = "btnCSV";
            btnCSV.Size = new Size(100, 34);
            btnCSV.TabIndex = 38;
            btnCSV.Text = "Exportar CSV";
            btnCSV.UseVisualStyleBackColor = true;
            btnCSV.Click += btnCSV_Click;
            // 
            // SeeUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 476);
            Controls.Add(btnCSV);
            Controls.Add(btnPDF);
            Controls.Add(btnJSON);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txbId);
            Controls.Add(txbEmail);
            Controls.Add(txbRole);
            Controls.Add(txbUser);
            Controls.Add(label3);
            Controls.Add(lblId);
            Controls.Add(lblUser);
            Controls.Add(txbPhone);
            Controls.Add(txbDonation);
            Controls.Add(txbPassword);
            Controls.Add(btnDelete);
            Controls.Add(btnModify);
            Controls.Add(btnAdd);
            Controls.Add(dgvUsers);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SeeUsers";
            Text = "SeeUsers";
            Activated += SeeUsers_Activated;
            Load += SeeUsers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txbId;
        private TextBox txbEmail;
        private TextBox txbRole;
        private TextBox txbUser;
        private Label label3;
        private Label lblId;
        private Label lblUser;
        private TextBox txbPhone;
        private TextBox txbDonation;
        private TextBox txbPassword;
        private Button btnDelete;
        private Button btnModify;
        private Button btnAdd;
        private DataGridView dgvUsers;
        private Button btnJSON;
        private Button btnPDF;
        private Button btnCSV;
    }
}