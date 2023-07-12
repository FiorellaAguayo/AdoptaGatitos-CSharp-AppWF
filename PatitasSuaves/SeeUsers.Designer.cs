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
            txb = new TextBox();
            label3 = new Label();
            lblId = new Label();
            lblUser = new Label();
            txbPhone = new TextBox();
            txbDonation = new TextBox();
            txbPassword = new TextBox();
            btnDelete = new Button();
            btnModify = new Button();
            btnAdd = new Button();
            dgvPets = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPets).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(321, 382);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 35;
            label7.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(306, 342);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 34;
            label6.Text = "Donaciones";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(306, 311);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 33;
            label5.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 413);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 32;
            label4.Text = "Email";
            // 
            // txbId
            // 
            txbId.Location = new Point(113, 344);
            txbId.Name = "txbId";
            txbId.Size = new Size(167, 23);
            txbId.TabIndex = 31;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(113, 410);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(167, 23);
            txbEmail.TabIndex = 30;
            // 
            // txbRole
            // 
            txbRole.Location = new Point(113, 374);
            txbRole.Name = "txbRole";
            txbRole.Size = new Size(167, 23);
            txbRole.TabIndex = 29;
            // 
            // txb
            // 
            txb.Location = new Point(113, 308);
            txb.Name = "txb";
            txb.Size = new Size(167, 23);
            txb.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 382);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 27;
            label3.Text = "Rol";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(81, 344);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 26;
            lblId.Text = "Id";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(75, 311);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(30, 15);
            lblUser.TabIndex = 25;
            lblUser.Text = "User";
            // 
            // txbPhone
            // 
            txbPhone.Location = new Point(379, 374);
            txbPhone.Name = "txbPhone";
            txbPhone.Size = new Size(167, 23);
            txbPhone.TabIndex = 24;
            // 
            // txbDonation
            // 
            txbDonation.Location = new Point(381, 338);
            txbDonation.Name = "txbDonation";
            txbDonation.Size = new Size(167, 23);
            txbDonation.TabIndex = 23;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(381, 298);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(167, 23);
            txbPassword.TabIndex = 22;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(668, 382);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(133, 33);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnModify
            // 
            btnModify.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnModify.Location = new Point(668, 344);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(133, 32);
            btnModify.TabIndex = 20;
            btnModify.Text = "Modificar";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(668, 301);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(133, 33);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvPets
            // 
            dgvPets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPets.Location = new Point(57, 32);
            dgvPets.Name = "dgvPets";
            dgvPets.RowTemplate.Height = 25;
            dgvPets.Size = new Size(746, 244);
            dgvPets.TabIndex = 18;
            dgvPets.CellClick += dgvUsers_CellClick;
            dgvPets.SelectionChanged += dgvUsers_SelectionChanged;
            // 
            // SeeUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 476);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txbId);
            Controls.Add(txbEmail);
            Controls.Add(txbRole);
            Controls.Add(txb);
            Controls.Add(label3);
            Controls.Add(lblId);
            Controls.Add(lblUser);
            Controls.Add(txbPhone);
            Controls.Add(txbDonation);
            Controls.Add(txbPassword);
            Controls.Add(btnDelete);
            Controls.Add(btnModify);
            Controls.Add(btnAdd);
            Controls.Add(dgvPets);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SeeUsers";
            Text = "SeeUsers";
            Activated += SeeUsers_Activated;
            Load += SeeUsers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPets).EndInit();
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
        private TextBox txb;
        private Label label3;
        private Label lblId;
        private Label lblUser;
        private TextBox txbPhone;
        private TextBox txbDonation;
        private TextBox txbPassword;
        private Button btnDelete;
        private Button btnModify;
        private Button btnAdd;
        private DataGridView dgvPets;
    }
}