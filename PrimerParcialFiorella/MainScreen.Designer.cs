namespace PrimerParcial
{
    partial class MainScreen
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
            lbl_MainScreen = new Label();
            SuspendLayout();
            // 
            // lbl_MainScreen
            // 
            lbl_MainScreen.AutoSize = true;
            lbl_MainScreen.Location = new Point(368, 198);
            lbl_MainScreen.Name = "lbl_MainScreen";
            lbl_MainScreen.Size = new Size(74, 15);
            lbl_MainScreen.TabIndex = 0;
            lbl_MainScreen.Text = "BIENVENIDO";
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_MainScreen);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainScreen";
            Text = "MainScreen";
            Load += MainScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_MainScreen;
    }
}