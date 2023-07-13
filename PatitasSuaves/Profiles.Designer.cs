namespace PatitasSuaves
{
    partial class Profiles
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
            flpCats = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flpCats
            // 
            flpCats.Location = new Point(0, 4);
            flpCats.Name = "flpCats";
            flpCats.Size = new Size(801, 454);
            flpCats.TabIndex = 0;
            // 
            // Profiles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 460);
            Controls.Add(flpCats);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Profiles";
            Text = "Profiles";
            Load += Profiles_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpCats;
    }
}