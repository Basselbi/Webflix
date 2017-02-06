namespace WebFlix
{
    partial class FormBrowse
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
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonRent = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.buttonMyRentals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(625, 258);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(150, 34);
            this.buttonLogout.TabIndex = 0;
            this.buttonLogout.Text = "QUITTER";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonRent
            // 
            this.buttonRent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(35)))), ((int)(((byte)(58)))));
            this.buttonRent.FlatAppearance.BorderSize = 0;
            this.buttonRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRent.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRent.ForeColor = System.Drawing.Color.White;
            this.buttonRent.Location = new System.Drawing.Point(625, 12);
            this.buttonRent.Name = "buttonRent";
            this.buttonRent.Size = new System.Drawing.Size(150, 33);
            this.buttonRent.TabIndex = 1;
            this.buttonRent.Text = "EMPRUNTER";
            this.buttonRent.UseVisualStyleBackColor = false;
            this.buttonRent.Click += new System.EventHandler(this.buttonRent_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(607, 277);
            this.listBox.TabIndex = 3;
            // 
            // buttonMyRentals
            // 
            this.buttonMyRentals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(35)))), ((int)(((byte)(58)))));
            this.buttonMyRentals.FlatAppearance.BorderSize = 0;
            this.buttonMyRentals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMyRentals.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMyRentals.ForeColor = System.Drawing.Color.White;
            this.buttonMyRentals.Location = new System.Drawing.Point(625, 219);
            this.buttonMyRentals.Name = "buttonMyRentals";
            this.buttonMyRentals.Size = new System.Drawing.Size(150, 33);
            this.buttonMyRentals.TabIndex = 4;
            this.buttonMyRentals.Text = "MES LOCATIONS";
            this.buttonMyRentals.UseVisualStyleBackColor = false;
            this.buttonMyRentals.Click += new System.EventHandler(this.buttonMyRentals_Click);
            // 
            // FormBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(790, 304);
            this.Controls.Add(this.buttonMyRentals);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.buttonRent);
            this.Controls.Add(this.buttonLogout);
            this.Name = "FormBrowse";
            this.Text = "WEBFLIX";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonRent;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button buttonMyRentals;
    }
}