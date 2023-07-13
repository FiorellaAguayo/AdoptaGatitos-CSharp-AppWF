namespace PatitasSuaves
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            panButtonSelected = new Panel();
            lblTitle = new Label();
            panButtons = new Panel();
            btnSeePets = new Button();
            btnSeeUsers = new Button();
            btnAccount = new Button();
            btnContact = new Button();
            btnDonate = new Button();
            btnProfiles = new Button();
            panLogo = new Panel();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            panButtonSelected.SuspendLayout();
            panButtons.SuspendLayout();
            panLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panButtonSelected
            // 
            panButtonSelected.BackColor = Color.DarkGray;
            panButtonSelected.Controls.Add(lblTitle);
            panButtonSelected.Dock = DockStyle.Top;
            panButtonSelected.Location = new Point(193, 0);
            panButtonSelected.Name = "panButtonSelected";
            panButtonSelected.Size = new Size(822, 94);
            panButtonSelected.TabIndex = 19;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.ButtonFace;
            lblTitle.Location = new Point(371, 37);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(84, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "INICIO";
            // 
            // panButtons
            // 
            panButtons.BackColor = Color.IndianRed;
            panButtons.Controls.Add(btnSeePets);
            panButtons.Controls.Add(btnSeeUsers);
            panButtons.Controls.Add(btnAccount);
            panButtons.Controls.Add(btnContact);
            panButtons.Controls.Add(btnDonate);
            panButtons.Controls.Add(btnProfiles);
            panButtons.Controls.Add(panLogo);
            panButtons.Dock = DockStyle.Left;
            panButtons.Location = new Point(0, 0);
            panButtons.Name = "panButtons";
            panButtons.Size = new Size(193, 552);
            panButtons.TabIndex = 18;
            // 
            // btnSeePets
            // 
            btnSeePets.Dock = DockStyle.Top;
            btnSeePets.FlatAppearance.BorderSize = 0;
            btnSeePets.FlatStyle = FlatStyle.Flat;
            btnSeePets.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSeePets.ForeColor = Color.White;
            btnSeePets.ImageAlign = ContentAlignment.MiddleLeft;
            btnSeePets.Location = new Point(0, 391);
            btnSeePets.Name = "btnSeePets";
            btnSeePets.Padding = new Padding(12, 0, 0, 0);
            btnSeePets.Size = new Size(193, 60);
            btnSeePets.TabIndex = 22;
            btnSeePets.Text = "  Ver mascotas";
            btnSeePets.TextAlign = ContentAlignment.MiddleLeft;
            btnSeePets.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSeePets.UseVisualStyleBackColor = true;
            btnSeePets.Visible = false;
            btnSeePets.Click += btnSeePets_Click;
            // 
            // btnSeeUsers
            // 
            btnSeeUsers.Dock = DockStyle.Top;
            btnSeeUsers.FlatAppearance.BorderSize = 0;
            btnSeeUsers.FlatStyle = FlatStyle.Flat;
            btnSeeUsers.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSeeUsers.ForeColor = Color.White;
            btnSeeUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnSeeUsers.Location = new Point(0, 331);
            btnSeeUsers.Name = "btnSeeUsers";
            btnSeeUsers.Padding = new Padding(12, 0, 0, 0);
            btnSeeUsers.Size = new Size(193, 60);
            btnSeeUsers.TabIndex = 23;
            btnSeeUsers.Text = "  Ver usuarios";
            btnSeeUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnSeeUsers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSeeUsers.UseVisualStyleBackColor = true;
            btnSeeUsers.Visible = false;
            btnSeeUsers.Click += btnSeeUsers_Click;
            // 
            // btnAccount
            // 
            btnAccount.Dock = DockStyle.Top;
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatStyle = FlatStyle.Flat;
            btnAccount.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAccount.ForeColor = Color.White;
            btnAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnAccount.Location = new Point(0, 274);
            btnAccount.Name = "btnAccount";
            btnAccount.Padding = new Padding(12, 0, 0, 0);
            btnAccount.Size = new Size(193, 57);
            btnAccount.TabIndex = 21;
            btnAccount.Text = "  Tu cuenta";
            btnAccount.TextAlign = ContentAlignment.MiddleLeft;
            btnAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAccount.UseVisualStyleBackColor = true;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnContact
            // 
            btnContact.Dock = DockStyle.Top;
            btnContact.FlatAppearance.BorderSize = 0;
            btnContact.FlatStyle = FlatStyle.Flat;
            btnContact.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnContact.ForeColor = Color.White;
            btnContact.ImageAlign = ContentAlignment.MiddleLeft;
            btnContact.Location = new Point(0, 214);
            btnContact.Name = "btnContact";
            btnContact.Padding = new Padding(12, 0, 0, 0);
            btnContact.Size = new Size(193, 60);
            btnContact.TabIndex = 20;
            btnContact.Text = "  Contacto";
            btnContact.TextAlign = ContentAlignment.MiddleLeft;
            btnContact.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnContact.UseVisualStyleBackColor = true;
            btnContact.Click += btnContact_Click;
            // 
            // btnDonate
            // 
            btnDonate.Dock = DockStyle.Top;
            btnDonate.FlatAppearance.BorderSize = 0;
            btnDonate.FlatStyle = FlatStyle.Flat;
            btnDonate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDonate.ForeColor = Color.White;
            btnDonate.ImageAlign = ContentAlignment.MiddleLeft;
            btnDonate.Location = new Point(0, 154);
            btnDonate.Name = "btnDonate";
            btnDonate.Padding = new Padding(12, 0, 0, 0);
            btnDonate.Size = new Size(193, 60);
            btnDonate.TabIndex = 18;
            btnDonate.Text = "  Donar";
            btnDonate.TextAlign = ContentAlignment.MiddleLeft;
            btnDonate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDonate.UseVisualStyleBackColor = true;
            btnDonate.Click += btnDonate_Click;
            // 
            // btnProfiles
            // 
            btnProfiles.Dock = DockStyle.Top;
            btnProfiles.FlatAppearance.BorderSize = 0;
            btnProfiles.FlatStyle = FlatStyle.Flat;
            btnProfiles.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnProfiles.ForeColor = Color.White;
            btnProfiles.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfiles.Location = new Point(0, 94);
            btnProfiles.Name = "btnProfiles";
            btnProfiles.Padding = new Padding(12, 0, 0, 0);
            btnProfiles.Size = new Size(193, 60);
            btnProfiles.TabIndex = 17;
            btnProfiles.Text = "  Perfiles";
            btnProfiles.TextAlign = ContentAlignment.MiddleLeft;
            btnProfiles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProfiles.UseVisualStyleBackColor = true;
            btnProfiles.Click += btnProfiles_Click;
            // 
            // panLogo
            // 
            panLogo.BackColor = Color.Salmon;
            panLogo.Controls.Add(label3);
            panLogo.Controls.Add(pictureBox3);
            panLogo.Dock = DockStyle.Top;
            panLogo.Location = new Point(0, 0);
            panLogo.Name = "panLogo";
            panLogo.Size = new Size(193, 94);
            panLogo.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Script", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(37, 71);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 40;
            label3.Text = "Patitas Suaves";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(37, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(105, 85);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 39;
            pictureBox3.TabStop = false;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 552);
            Controls.Add(panButtonSelected);
            Controls.Add(panButtons);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            Load += Principal_Load;
            Resize += Principal_Resize;
            StyleChanged += Principal_StyleChanged;
            panButtonSelected.ResumeLayout(false);
            panButtonSelected.PerformLayout();
            panButtons.ResumeLayout(false);
            panLogo.ResumeLayout(false);
            panLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panButtonSelected;
        private Label lblTitle;
        private Panel panButtons;
        private Button btnSeePets;
        private Button btnSeeUsers;
        private Button btnAccount;
        private Button btnContact;
        private Button btnDonate;
        private Button btnProfiles;
        private Panel panLogo;
        private Label label3;
        private PictureBox pictureBox3;
    }
}