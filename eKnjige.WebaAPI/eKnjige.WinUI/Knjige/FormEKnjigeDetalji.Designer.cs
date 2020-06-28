namespace eKnjige.WinUI.Knjige
{
    partial class FormEKnjigeDetalji
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
            this.buttonIzmijeni = new System.Windows.Forms.Button();
            this.buttonIzbriši = new System.Windows.Forms.Button();
            this.textNaziv = new System.Windows.Forms.TextBox();
            this.Naziv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textOcjena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textCijena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textOpis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonIzmijeni
            // 
            this.buttonIzmijeni.Location = new System.Drawing.Point(485, 371);
            this.buttonIzmijeni.Name = "buttonIzmijeni";
            this.buttonIzmijeni.Size = new System.Drawing.Size(75, 23);
            this.buttonIzmijeni.TabIndex = 0;
            this.buttonIzmijeni.Text = "Izmijeni";
            this.buttonIzmijeni.UseVisualStyleBackColor = true;
            // 
            // buttonIzbriši
            // 
            this.buttonIzbriši.Location = new System.Drawing.Point(613, 371);
            this.buttonIzbriši.Name = "buttonIzbriši";
            this.buttonIzbriši.Size = new System.Drawing.Size(75, 23);
            this.buttonIzbriši.TabIndex = 1;
            this.buttonIzbriši.Text = "Izbriši";
            this.buttonIzbriši.UseVisualStyleBackColor = true;
            // 
            // textNaziv
            // 
            this.textNaziv.Location = new System.Drawing.Point(28, 31);
            this.textNaziv.Name = "textNaziv";
            this.textNaziv.Size = new System.Drawing.Size(100, 20);
            this.textNaziv.TabIndex = 2;
            // 
            // Naziv
            // 
            this.Naziv.AutoSize = true;
            this.Naziv.Location = new System.Drawing.Point(163, 38);
            this.Naziv.Name = "Naziv";
            this.Naziv.Size = new System.Drawing.Size(34, 13);
            this.Naziv.TabIndex = 3;
            this.Naziv.Text = "Naziv";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ocjena";
            // 
            // textOcjena
            // 
            this.textOcjena.Location = new System.Drawing.Point(28, 89);
            this.textOcjena.Name = "textOcjena";
            this.textOcjena.Size = new System.Drawing.Size(100, 20);
            this.textOcjena.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cijena";
            // 
            // textCijena
            // 
            this.textCijena.Location = new System.Drawing.Point(28, 151);
            this.textCijena.Name = "textCijena";
            this.textCijena.Size = new System.Drawing.Size(100, 20);
            this.textCijena.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Opis";
            // 
            // textOpis
            // 
            this.textOpis.Location = new System.Drawing.Point(28, 317);
            this.textOpis.Name = "textOpis";
            this.textOpis.Size = new System.Drawing.Size(135, 20);
            this.textOpis.TabIndex = 8;
            // 
            // FormEKnjigeDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textOpis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCijena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textOcjena);
            this.Controls.Add(this.Naziv);
            this.Controls.Add(this.textNaziv);
            this.Controls.Add(this.buttonIzbriši);
            this.Controls.Add(this.buttonIzmijeni);
            this.Name = "FormEKnjigeDetalji";
            this.Text = "FormEKnjigeDetalji";
            this.Load += new System.EventHandler(this.FormEKnjigeDetalji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIzmijeni;
        private System.Windows.Forms.Button buttonIzbriši;
        private System.Windows.Forms.TextBox textNaziv;
        private System.Windows.Forms.Label Naziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textOcjena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCijena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textOpis;
    }
}