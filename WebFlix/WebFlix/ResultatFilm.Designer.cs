namespace WebFlix
{
    partial class ResultatFilm
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
            this.resultatListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // resultatListBox
            // 
            this.resultatListBox.FormattingEnabled = true;
            this.resultatListBox.Location = new System.Drawing.Point(12, 30);
            this.resultatListBox.Name = "resultatListBox";
            this.resultatListBox.Size = new System.Drawing.Size(248, 147);
            this.resultatListBox.TabIndex = 0;
            // 
            // ResultatFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.resultatListBox);
            this.Name = "ResultatFilm";
            this.Text = "ResultatFilm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox resultatListBox;
    }
}