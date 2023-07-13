﻿namespace PatitasSuaves
{
    partial class SeePets
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
            lblIsEsterilized = new Label();
            lblWeight = new Label();
            lblCoatColor = new Label();
            txbName = new TextBox();
            lblRace = new Label();
            lblAge = new Label();
            lblName = new Label();
            btnDelete = new Button();
            btnModify = new Button();
            btnAdd = new Button();
            dgvCats = new DataGridView();
            lbxRace = new ListBox();
            lbxFurColor = new ListBox();
            txbURLImage = new TextBox();
            lblURLImagen = new Label();
            txbAge = new TextBox();
            txbWeight = new TextBox();
            lbxIsSterelized = new ListBox();
            btnCSV = new Button();
            btnPDF = new Button();
            btnJSON = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCats).BeginInit();
            SuspendLayout();
            // 
            // lblIsEsterilized
            // 
            lblIsEsterilized.AutoSize = true;
            lblIsEsterilized.Location = new Point(482, 396);
            lblIsEsterilized.Name = "lblIsEsterilized";
            lblIsEsterilized.Size = new Size(100, 15);
            lblIsEsterilized.TabIndex = 52;
            lblIsEsterilized.Text = "¿Está esterilizado?";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(78, 382);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(32, 15);
            lblWeight.TabIndex = 51;
            lblWeight.Text = "Peso";
            // 
            // lblCoatColor
            // 
            lblCoatColor.AutoSize = true;
            lblCoatColor.Location = new Point(296, 296);
            lblCoatColor.Name = "lblCoatColor";
            lblCoatColor.Size = new Size(70, 15);
            lblCoatColor.TabIndex = 50;
            lblCoatColor.Text = "Color pelaje";
            // 
            // txbName
            // 
            txbName.Location = new Point(117, 298);
            txbName.Name = "txbName";
            txbName.Size = new Size(120, 23);
            txbName.TabIndex = 46;
            // 
            // lblRace
            // 
            lblRace.AutoSize = true;
            lblRace.Location = new Point(476, 296);
            lblRace.Name = "lblRace";
            lblRace.Size = new Size(31, 15);
            lblRace.TabIndex = 45;
            lblRace.Text = "Raza";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(78, 342);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(33, 15);
            lblAge.TabIndex = 44;
            lblAge.Text = "Edad";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(60, 301);
            lblName.Name = "lblName";
            lblName.Size = new Size(51, 15);
            lblName.TabIndex = 43;
            lblName.Text = "Nombre";
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(694, 405);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(133, 33);
            btnDelete.TabIndex = 39;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnModify
            // 
            btnModify.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnModify.Location = new Point(694, 367);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(133, 32);
            btnModify.TabIndex = 38;
            btnModify.Text = "Modificar";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(694, 324);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(133, 33);
            btnAdd.TabIndex = 37;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvCats
            // 
            dgvCats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCats.Location = new Point(44, 32);
            dgvCats.Name = "dgvCats";
            dgvCats.RowTemplate.Height = 25;
            dgvCats.Size = new Size(666, 244);
            dgvCats.TabIndex = 36;
            dgvCats.CellClick += dgvCats_CellClick;
            dgvCats.SelectionChanged += dgvCats_SelectionChanged;
            // 
            // lbxRace
            // 
            lbxRace.FormattingEnabled = true;
            lbxRace.ItemHeight = 15;
            lbxRace.Location = new Point(476, 314);
            lbxRace.Name = "lbxRace";
            lbxRace.Size = new Size(130, 64);
            lbxRace.TabIndex = 54;
            // 
            // lbxFurColor
            // 
            lbxFurColor.FormattingEnabled = true;
            lbxFurColor.ItemHeight = 15;
            lbxFurColor.Location = new Point(296, 314);
            lbxFurColor.Name = "lbxFurColor";
            lbxFurColor.Size = new Size(130, 64);
            lbxFurColor.TabIndex = 58;
            // 
            // txbURLImage
            // 
            txbURLImage.Location = new Point(155, 421);
            txbURLImage.Name = "txbURLImage";
            txbURLImage.Size = new Size(252, 23);
            txbURLImage.TabIndex = 59;
            // 
            // lblURLImagen
            // 
            lblURLImagen.AutoSize = true;
            lblURLImagen.Location = new Point(78, 424);
            lblURLImagen.Name = "lblURLImagen";
            lblURLImagen.Size = new Size(71, 15);
            lblURLImagen.TabIndex = 60;
            lblURLImagen.Text = "URL imagen";
            // 
            // txbAge
            // 
            txbAge.Location = new Point(117, 339);
            txbAge.Name = "txbAge";
            txbAge.Size = new Size(120, 23);
            txbAge.TabIndex = 61;
            // 
            // txbWeight
            // 
            txbWeight.Location = new Point(117, 379);
            txbWeight.Name = "txbWeight";
            txbWeight.Size = new Size(120, 23);
            txbWeight.TabIndex = 62;
            // 
            // lbxIsSterelized
            // 
            lbxIsSterelized.FormattingEnabled = true;
            lbxIsSterelized.ItemHeight = 15;
            lbxIsSterelized.Location = new Point(482, 421);
            lbxIsSterelized.Name = "lbxIsSterelized";
            lbxIsSterelized.Size = new Size(124, 34);
            lbxIsSterelized.TabIndex = 63;
            // 
            // btnCSV
            // 
            btnCSV.Location = new Point(727, 116);
            btnCSV.Name = "btnCSV";
            btnCSV.Size = new Size(100, 34);
            btnCSV.TabIndex = 66;
            btnCSV.Text = "Exportar CSV";
            btnCSV.UseVisualStyleBackColor = true;
            btnCSV.Click += btnCSV_Click;
            // 
            // btnPDF
            // 
            btnPDF.Location = new Point(727, 169);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(100, 34);
            btnPDF.TabIndex = 65;
            btnPDF.Text = "Exportar PDF";
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += btnPDF_Click;
            // 
            // btnJSON
            // 
            btnJSON.Location = new Point(727, 63);
            btnJSON.Name = "btnJSON";
            btnJSON.Size = new Size(100, 34);
            btnJSON.TabIndex = 64;
            btnJSON.Text = "Exportar JSON";
            btnJSON.UseVisualStyleBackColor = true;
            btnJSON.Click += btnJSON_Click;
            // 
            // SeePets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 488);
            Controls.Add(btnCSV);
            Controls.Add(btnPDF);
            Controls.Add(btnJSON);
            Controls.Add(lbxIsSterelized);
            Controls.Add(txbWeight);
            Controls.Add(txbAge);
            Controls.Add(lblURLImagen);
            Controls.Add(txbURLImage);
            Controls.Add(lbxFurColor);
            Controls.Add(lbxRace);
            Controls.Add(lblIsEsterilized);
            Controls.Add(lblWeight);
            Controls.Add(lblCoatColor);
            Controls.Add(txbName);
            Controls.Add(lblRace);
            Controls.Add(lblAge);
            Controls.Add(lblName);
            Controls.Add(btnDelete);
            Controls.Add(btnModify);
            Controls.Add(btnAdd);
            Controls.Add(dgvCats);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SeePets";
            Text = "SeePets";
            Activated += SeePets_Activated;
            Load += SeePets_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCats).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label lblIsEsterilized;
        private Label lblWeight;
        private Label lblCoatColor;
        private TextBox txbName;
        private Label lblRace;
        private Label lblAge;
        private Label lblName;
        private TextBox txbPhone;
        private Button btnDelete;
        private Button btnModify;
        private Button btnAdd;
        private DataGridView dgvCats;
        private ListBox lbxRace;
        private ListBox lbxFurColor;
        private TextBox txbURLImage;
        private Label lblURLImagen;
        private TextBox txbAge;
        private TextBox txbWeight;
        private ListBox lbxIsSterelized;
        private Button btnCSV;
        private Button btnPDF;
        private Button btnJSON;
    }
}