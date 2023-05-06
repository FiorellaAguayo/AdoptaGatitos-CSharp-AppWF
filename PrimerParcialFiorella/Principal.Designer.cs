namespace PrimerParcial
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
            pan_Buttons = new Panel();
            btn_Account = new Button();
            btn_Contact = new Button();
            btn_BePart = new Button();
            btn_Donate = new Button();
            btn_Profiles = new Button();
            btn_Adopt = new Button();
            pan_Logo = new Panel();
            lbl_Logo = new Label();
            pan_ButtonSelected = new Panel();
            lbl_Title = new Label();
            pan_Buttons.SuspendLayout();
            pan_Logo.SuspendLayout();
            pan_ButtonSelected.SuspendLayout();
            SuspendLayout();
            // 
            // pan_Buttons
            // 
            pan_Buttons.BackColor = Color.IndianRed;
            pan_Buttons.Controls.Add(btn_Account);
            pan_Buttons.Controls.Add(btn_Contact);
            pan_Buttons.Controls.Add(btn_BePart);
            pan_Buttons.Controls.Add(btn_Donate);
            pan_Buttons.Controls.Add(btn_Profiles);
            pan_Buttons.Controls.Add(btn_Adopt);
            pan_Buttons.Controls.Add(pan_Logo);
            pan_Buttons.Dock = DockStyle.Left;
            pan_Buttons.Location = new Point(0, 0);
            pan_Buttons.Name = "pan_Buttons";
            pan_Buttons.Size = new Size(193, 523);
            pan_Buttons.TabIndex = 14;
            // 
            // btn_Account
            // 
            btn_Account.Dock = DockStyle.Top;
            btn_Account.FlatAppearance.BorderSize = 0;
            btn_Account.FlatStyle = FlatStyle.Flat;
            btn_Account.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Account.ForeColor = Color.White;
            btn_Account.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Account.Location = new Point(0, 450);
            btn_Account.Name = "btn_Account";
            btn_Account.Padding = new Padding(12, 0, 0, 0);
            btn_Account.Size = new Size(193, 70);
            btn_Account.TabIndex = 21;
            btn_Account.Text = "  Tu cuenta";
            btn_Account.TextAlign = ContentAlignment.MiddleLeft;
            btn_Account.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Account.UseVisualStyleBackColor = true;
            btn_Account.Click += btn_Account_Click;
            // 
            // btn_Contact
            // 
            btn_Contact.Dock = DockStyle.Top;
            btn_Contact.FlatAppearance.BorderSize = 0;
            btn_Contact.FlatStyle = FlatStyle.Flat;
            btn_Contact.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Contact.ForeColor = Color.White;
            btn_Contact.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Contact.Location = new Point(0, 380);
            btn_Contact.Name = "btn_Contact";
            btn_Contact.Padding = new Padding(12, 0, 0, 0);
            btn_Contact.Size = new Size(193, 70);
            btn_Contact.TabIndex = 20;
            btn_Contact.Text = "  Contacto";
            btn_Contact.TextAlign = ContentAlignment.MiddleLeft;
            btn_Contact.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Contact.UseVisualStyleBackColor = true;
            btn_Contact.Click += btn_Contact_Click;
            // 
            // btn_BePart
            // 
            btn_BePart.Dock = DockStyle.Top;
            btn_BePart.FlatAppearance.BorderSize = 0;
            btn_BePart.FlatStyle = FlatStyle.Flat;
            btn_BePart.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_BePart.ForeColor = Color.White;
            btn_BePart.ImageAlign = ContentAlignment.MiddleLeft;
            btn_BePart.Location = new Point(0, 310);
            btn_BePart.Name = "btn_BePart";
            btn_BePart.Padding = new Padding(12, 0, 0, 0);
            btn_BePart.Size = new Size(193, 70);
            btn_BePart.TabIndex = 19;
            btn_BePart.Text = "  ¿Querés ser parte?";
            btn_BePart.TextAlign = ContentAlignment.MiddleLeft;
            btn_BePart.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_BePart.UseVisualStyleBackColor = true;
            btn_BePart.Click += btn_BePart_Click;
            // 
            // btn_Donate
            // 
            btn_Donate.Dock = DockStyle.Top;
            btn_Donate.FlatAppearance.BorderSize = 0;
            btn_Donate.FlatStyle = FlatStyle.Flat;
            btn_Donate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Donate.ForeColor = Color.White;
            btn_Donate.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Donate.Location = new Point(0, 240);
            btn_Donate.Name = "btn_Donate";
            btn_Donate.Padding = new Padding(12, 0, 0, 0);
            btn_Donate.Size = new Size(193, 70);
            btn_Donate.TabIndex = 18;
            btn_Donate.Text = "  Donar";
            btn_Donate.TextAlign = ContentAlignment.MiddleLeft;
            btn_Donate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Donate.UseVisualStyleBackColor = true;
            btn_Donate.Click += btn_Donate_Click;
            // 
            // btn_Profiles
            // 
            btn_Profiles.Dock = DockStyle.Top;
            btn_Profiles.FlatAppearance.BorderSize = 0;
            btn_Profiles.FlatStyle = FlatStyle.Flat;
            btn_Profiles.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Profiles.ForeColor = Color.White;
            btn_Profiles.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Profiles.Location = new Point(0, 170);
            btn_Profiles.Name = "btn_Profiles";
            btn_Profiles.Padding = new Padding(12, 0, 0, 0);
            btn_Profiles.Size = new Size(193, 70);
            btn_Profiles.TabIndex = 17;
            btn_Profiles.Text = "  Perfiles";
            btn_Profiles.TextAlign = ContentAlignment.MiddleLeft;
            btn_Profiles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Profiles.UseVisualStyleBackColor = true;
            btn_Profiles.Click += btn_Profiles_Click;
            // 
            // btn_Adopt
            // 
            btn_Adopt.Dock = DockStyle.Top;
            btn_Adopt.FlatAppearance.BorderSize = 0;
            btn_Adopt.FlatStyle = FlatStyle.Flat;
            btn_Adopt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Adopt.ForeColor = Color.White;
            btn_Adopt.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Adopt.Location = new Point(0, 100);
            btn_Adopt.Name = "btn_Adopt";
            btn_Adopt.Padding = new Padding(12, 0, 0, 0);
            btn_Adopt.Size = new Size(193, 70);
            btn_Adopt.TabIndex = 16;
            btn_Adopt.Text = "  Adoptar";
            btn_Adopt.TextAlign = ContentAlignment.MiddleLeft;
            btn_Adopt.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Adopt.UseVisualStyleBackColor = true;
            btn_Adopt.Click += btn_Adopt_Click;
            // 
            // pan_Logo
            // 
            pan_Logo.BackColor = Color.Salmon;
            pan_Logo.Controls.Add(lbl_Logo);
            pan_Logo.Dock = DockStyle.Top;
            pan_Logo.Location = new Point(0, 0);
            pan_Logo.Name = "pan_Logo";
            pan_Logo.Size = new Size(193, 100);
            pan_Logo.TabIndex = 15;
            // 
            // lbl_Logo
            // 
            lbl_Logo.AutoSize = true;
            lbl_Logo.Location = new Point(51, 50);
            lbl_Logo.Name = "lbl_Logo";
            lbl_Logo.Size = new Size(76, 15);
            lbl_Logo.TabIndex = 0;
            lbl_Logo.Text = "logoEmpresa";
            // 
            // pan_ButtonSelected
            // 
            pan_ButtonSelected.BackColor = Color.DarkGray;
            pan_ButtonSelected.Controls.Add(lbl_Title);
            pan_ButtonSelected.Dock = DockStyle.Top;
            pan_ButtonSelected.Location = new Point(193, 0);
            pan_ButtonSelected.Name = "pan_ButtonSelected";
            pan_ButtonSelected.Size = new Size(607, 100);
            pan_ButtonSelected.TabIndex = 15;
            // 
            // lbl_Title
            // 
            lbl_Title.Anchor = AnchorStyles.None;
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Title.ForeColor = SystemColors.ButtonFace;
            lbl_Title.Location = new Point(261, 39);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(84, 28);
            lbl_Title.TabIndex = 0;
            lbl_Title.Text = "INICIO";
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(800, 523);
            Controls.Add(pan_ButtonSelected);
            Controls.Add(pan_Buttons);
            IsMdiContainer = true;
            Name = "Principal";
            Text = "Principal";
            Load += Principal_Load;
            pan_Buttons.ResumeLayout(false);
            pan_Logo.ResumeLayout(false);
            pan_Logo.PerformLayout();
            pan_ButtonSelected.ResumeLayout(false);
            pan_ButtonSelected.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pan_Buttons;
        private Panel pan_ButtonSelected;
        private Button btn_Adopt;
        private Panel pan_Logo;
        private Button btn_Contact;
        private Button btn_BePart;
        private Button btn_Donate;
        private Button btn_Profiles;
        private Button btn_Account;
        private Label lbl_Title;
        private Label lbl_Logo;
    }
}