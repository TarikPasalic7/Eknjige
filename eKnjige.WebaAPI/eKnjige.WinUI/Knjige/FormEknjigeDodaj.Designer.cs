namespace eKnjige.WinUI.Knjige
{
    partial class FormEknjigeDodaj
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
            this.label3 = new System.Windows.Forms.Label();
            this.textOpis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textCijena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textOcjena = new System.Windows.Forms.TextBox();
            this.Naziv = new System.Windows.Forms.Label();
            this.textNaziv = new System.Windows.Forms.TextBox();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSlikaInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSlika = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Opis";
            // 
            // textOpis
            // 
            this.textOpis.Location = new System.Drawing.Point(23, 271);
            this.textOpis.Multiline = true;
            this.textOpis.Name = "textOpis";
            this.textOpis.Size = new System.Drawing.Size(359, 120);
            this.textOpis.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cijena";
            // 
            // textCijena
            // 
            this.textCijena.Location = new System.Drawing.Point(23, 143);
            this.textCijena.Name = "textCijena";
            this.textCijena.Size = new System.Drawing.Size(100, 20);
            this.textCijena.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ocjena";
            // 
            // textOcjena
            // 
            this.textOcjena.Location = new System.Drawing.Point(23, 81);
            this.textOcjena.Name = "textOcjena";
            this.textOcjena.Size = new System.Drawing.Size(100, 20);
            this.textOcjena.TabIndex = 12;
            // 
            // Naziv
            // 
            this.Naziv.AutoSize = true;
            this.Naziv.Location = new System.Drawing.Point(158, 30);
            this.Naziv.Name = "Naziv";
            this.Naziv.Size = new System.Drawing.Size(34, 13);
            this.Naziv.TabIndex = 11;
            this.Naziv.Text = "Naziv";
            // 
            // textNaziv
            // 
            this.textNaziv.Location = new System.Drawing.Point(23, 23);
            this.textNaziv.Name = "textNaziv";
            this.textNaziv.Size = new System.Drawing.Size(100, 20);
            this.textNaziv.TabIndex = 10;
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(621, 368);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(75, 23);
            this.btnSnimi.TabIndex = 18;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(566, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // txtSlikaInput
            // 
            this.txtSlikaInput.Location = new System.Drawing.Point(369, 30);
            this.txtSlikaInput.Name = "txtSlikaInput";
            this.txtSlikaInput.Size = new System.Drawing.Size(135, 20);
            this.txtSlikaInput.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Slika";
            // 
            // btnSlika
            // 
            this.btnSlika.Location = new System.Drawing.Point(429, 78);
            this.btnSlika.Name = "btnSlika";
            this.btnSlika.Size = new System.Drawing.Size(75, 23);
            this.btnSlika.TabIndex = 22;
            this.btnSlika.Text = "Dodaj";
            this.btnSlika.UseVisualStyleBackColor = true;
            this.btnSlika.Click += new System.EventHandler(this.btnSlika_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormEknjigeDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSlika);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSlikaInput);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textOpis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCijena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textOcjena);
            this.Controls.Add(this.Naziv);
            this.Controls.Add(this.textNaziv);
            this.Name = "FormEknjigeDodaj";
            this.Text = "FormEknjigeDodaj";
            this.Load += new System.EventHandler(this.FormEknjigeDodaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textOpis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCijena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textOcjena;
        private System.Windows.Forms.Label Naziv;
        private System.Windows.Forms.TextBox textNaziv;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSlikaInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSlika;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}