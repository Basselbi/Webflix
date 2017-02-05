namespace WebFlix
{
    partial class InscriptionForm
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
            this.components = new System.ComponentModel.Container();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.ccvBox = new System.Windows.Forms.TextBox();
            this.prenomBox = new System.Windows.Forms.TextBox();
            this.rueBox = new System.Windows.Forms.TextBox();
            this.nomBox = new System.Windows.Forms.TextBox();
            this.numeroCiviqueBox = new System.Windows.Forms.TextBox();
            this.numeroCarteBox = new System.Windows.Forms.TextBox();
            this.codePostalBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dateNaissanceBox = new System.Windows.Forms.DateTimePicker();
            this.villeComboBox = new System.Windows.Forms.ComboBox();
            this.cONNEXIONCLIENTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.equipe15datasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipe15_dataset = new WebFlix.Equipe15_dataset();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provinceComboBox = new System.Windows.Forms.ComboBox();
            this.creditCardBox = new System.Windows.Forms.ComboBox();
            this.dateExpirationBox = new System.Windows.Forms.DateTimePicker();
            this.cONNEXIONCLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cONNEXIONCLIENTTableAdapter = new WebFlix.Equipe15_datasetTableAdapters.CONNEXIONCLIENTTableAdapter();
            this.inscriptionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cONNEXIONCLIENTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipe15datasetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipe15_dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONNEXIONCLIENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(157, 122);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(100, 20);
            this.emailBox.TabIndex = 0;
            // 
            // ccvBox
            // 
            this.ccvBox.Location = new System.Drawing.Point(157, 457);
            this.ccvBox.Name = "ccvBox";
            this.ccvBox.Size = new System.Drawing.Size(42, 20);
            this.ccvBox.TabIndex = 1;
            // 
            // prenomBox
            // 
            this.prenomBox.Location = new System.Drawing.Point(157, 96);
            this.prenomBox.Name = "prenomBox";
            this.prenomBox.Size = new System.Drawing.Size(100, 20);
            this.prenomBox.TabIndex = 2;
            // 
            // rueBox
            // 
            this.rueBox.Location = new System.Drawing.Point(157, 192);
            this.rueBox.Name = "rueBox";
            this.rueBox.Size = new System.Drawing.Size(100, 20);
            this.rueBox.TabIndex = 3;
            // 
            // nomBox
            // 
            this.nomBox.Location = new System.Drawing.Point(157, 58);
            this.nomBox.Name = "nomBox";
            this.nomBox.Size = new System.Drawing.Size(100, 20);
            this.nomBox.TabIndex = 4;
            // 
            // numeroCiviqueBox
            // 
            this.numeroCiviqueBox.Location = new System.Drawing.Point(157, 157);
            this.numeroCiviqueBox.Name = "numeroCiviqueBox";
            this.numeroCiviqueBox.Size = new System.Drawing.Size(100, 20);
            this.numeroCiviqueBox.TabIndex = 5;
            // 
            // numeroCarteBox
            // 
            this.numeroCarteBox.Location = new System.Drawing.Point(157, 398);
            this.numeroCarteBox.Name = "numeroCarteBox";
            this.numeroCarteBox.Size = new System.Drawing.Size(100, 20);
            this.numeroCarteBox.TabIndex = 6;
            // 
            // codePostalBox
            // 
            this.codePostalBox.Location = new System.Drawing.Point(157, 312);
            this.codePostalBox.Name = "codePostalBox";
            this.codePostalBox.Size = new System.Drawing.Size(100, 20);
            this.codePostalBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Numero Civique";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Rue ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ville";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Province";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Code Postal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Carte Credit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 398);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Numero Carte";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 434);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Date Expiration";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 464);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "CCV";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 492);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Date Naissance";
            // 
            // dateNaissanceBox
            // 
            this.dateNaissanceBox.Location = new System.Drawing.Point(157, 485);
            this.dateNaissanceBox.Name = "dateNaissanceBox";
            this.dateNaissanceBox.Size = new System.Drawing.Size(200, 20);
            this.dateNaissanceBox.TabIndex = 21;
            // 
            // villeComboBox
            // 
            this.villeComboBox.DataSource = this.cONNEXIONCLIENTBindingSource1;
            this.villeComboBox.FormattingEnabled = true;
            this.villeComboBox.Location = new System.Drawing.Point(157, 228);
            this.villeComboBox.Name = "villeComboBox";
            this.villeComboBox.Size = new System.Drawing.Size(121, 21);
            this.villeComboBox.TabIndex = 22;
            // 
            // cONNEXIONCLIENTBindingSource1
            // 
            this.cONNEXIONCLIENTBindingSource1.DataMember = "CONNEXIONCLIENT";
            this.cONNEXIONCLIENTBindingSource1.DataSource = this.equipe15datasetBindingSource;
            // 
            // equipe15datasetBindingSource
            // 
            this.equipe15datasetBindingSource.DataSource = this.equipe15_dataset;
            this.equipe15datasetBindingSource.Position = 0;
            // 
            // equipe15_dataset
            // 
            this.equipe15_dataset.DataSetName = "Equipe15_dataset";
            this.equipe15_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.equipe15datasetBindingSource;
            // 
            // provinceComboBox
            // 
            this.provinceComboBox.FormattingEnabled = true;
            this.provinceComboBox.Location = new System.Drawing.Point(157, 276);
            this.provinceComboBox.Name = "provinceComboBox";
            this.provinceComboBox.Size = new System.Drawing.Size(121, 21);
            this.provinceComboBox.TabIndex = 23;
            // 
            // creditCardBox
            // 
            this.creditCardBox.FormattingEnabled = true;
            this.creditCardBox.Location = new System.Drawing.Point(157, 360);
            this.creditCardBox.Name = "creditCardBox";
            this.creditCardBox.Size = new System.Drawing.Size(121, 21);
            this.creditCardBox.TabIndex = 24;
            this.creditCardBox.Text = "Master Card";
            // 
            // dateExpirationBox
            // 
            this.dateExpirationBox.Location = new System.Drawing.Point(157, 434);
            this.dateExpirationBox.Name = "dateExpirationBox";
            this.dateExpirationBox.Size = new System.Drawing.Size(69, 20);
            this.dateExpirationBox.TabIndex = 25;
            this.dateExpirationBox.ValueChanged += new System.EventHandler(this.dateExpirationBox_ValueChanged);
            // 
            // cONNEXIONCLIENTBindingSource
            // 
            this.cONNEXIONCLIENTBindingSource.DataMember = "CONNEXIONCLIENT";
            this.cONNEXIONCLIENTBindingSource.DataSource = this.equipe15datasetBindingSource;
            // 
            // cONNEXIONCLIENTTableAdapter
            // 
            this.cONNEXIONCLIENTTableAdapter.ClearBeforeFill = true;
            // 
            // inscriptionButton
            // 
            this.inscriptionButton.Location = new System.Drawing.Point(135, 561);
            this.inscriptionButton.Name = "inscriptionButton";
            this.inscriptionButton.Size = new System.Drawing.Size(75, 23);
            this.inscriptionButton.TabIndex = 26;
            this.inscriptionButton.Text = "Ok";
            this.inscriptionButton.UseVisualStyleBackColor = true;
            // 
            // InscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 606);
            this.Controls.Add(this.inscriptionButton);
            this.Controls.Add(this.dateExpirationBox);
            this.Controls.Add(this.creditCardBox);
            this.Controls.Add(this.provinceComboBox);
            this.Controls.Add(this.villeComboBox);
            this.Controls.Add(this.dateNaissanceBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codePostalBox);
            this.Controls.Add(this.numeroCarteBox);
            this.Controls.Add(this.numeroCiviqueBox);
            this.Controls.Add(this.nomBox);
            this.Controls.Add(this.rueBox);
            this.Controls.Add(this.prenomBox);
            this.Controls.Add(this.ccvBox);
            this.Controls.Add(this.emailBox);
            this.Name = "InscriptionForm";
            this.Text = "InscriptionForm";
            this.Load += new System.EventHandler(this.InscriptionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cONNEXIONCLIENTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipe15datasetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipe15_dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONNEXIONCLIENTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox ccvBox;
        private System.Windows.Forms.TextBox prenomBox;
        private System.Windows.Forms.TextBox rueBox;
        private System.Windows.Forms.TextBox nomBox;
        private System.Windows.Forms.TextBox numeroCiviqueBox;
        private System.Windows.Forms.TextBox numeroCarteBox;
        private System.Windows.Forms.TextBox codePostalBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateNaissanceBox;
        private System.Windows.Forms.ComboBox villeComboBox;
        private System.Windows.Forms.ComboBox provinceComboBox;
        private System.Windows.Forms.ComboBox creditCardBox;
        private System.Windows.Forms.DateTimePicker dateExpirationBox;
        private System.Windows.Forms.BindingSource equipe15datasetBindingSource;
        private Equipe15_dataset equipe15_dataset;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private System.Windows.Forms.BindingSource cONNEXIONCLIENTBindingSource1;
        private System.Windows.Forms.BindingSource cONNEXIONCLIENTBindingSource;
        private Equipe15_datasetTableAdapters.CONNEXIONCLIENTTableAdapter cONNEXIONCLIENTTableAdapter;
        private System.Windows.Forms.Button inscriptionButton;
    }
}