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
            this.checkBoxMP3 = new System.Windows.Forms.CheckBox();
            this.checkBoxPdf = new System.Windows.Forms.CheckBox();
            this.buttonKategorijeKnjige = new System.Windows.Forms.Button();
            this.comboBoxKategorije = new System.Windows.Forms.ComboBox();
            this.comboBoxAutori = new System.Windows.Forms.ComboBox();
            this.buttonEknnjigeAutori = new System.Windows.Forms.Button();
            this.buttonmp3file = new System.Windows.Forms.Button();
            this.buttonpdffile = new System.Windows.Forms.Button();
            this.openFileDialogmp3 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogpdf = new System.Windows.Forms.OpenFileDialog();
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
            this.btnSnimi.Location = new System.Drawing.Point(949, 500);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(155, 56);
            this.btnSnimi.TabIndex = 18;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(900, 12);
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
            // checkBoxMP3
            // 
            this.checkBoxMP3.AutoSize = true;
            this.checkBoxMP3.Location = new System.Drawing.Point(336, 130);
            this.checkBoxMP3.Name = "checkBoxMP3";
            this.checkBoxMP3.Size = new System.Drawing.Size(48, 17);
            this.checkBoxMP3.TabIndex = 23;
            this.checkBoxMP3.Text = "MP3";
            this.checkBoxMP3.UseVisualStyleBackColor = true;
            // 
            // checkBoxPdf
            // 
            this.checkBoxPdf.AutoSize = true;
            this.checkBoxPdf.Location = new System.Drawing.Point(442, 130);
            this.checkBoxPdf.Name = "checkBoxPdf";
            this.checkBoxPdf.Size = new System.Drawing.Size(47, 17);
            this.checkBoxPdf.TabIndex = 24;
            this.checkBoxPdf.Text = "PDF";
            this.checkBoxPdf.UseVisualStyleBackColor = true;
            // 
            // buttonKategorijeKnjige
            // 
            this.buttonKategorijeKnjige.Location = new System.Drawing.Point(702, 269);
            this.buttonKategorijeKnjige.Name = "buttonKategorijeKnjige";
            this.buttonKategorijeKnjige.Size = new System.Drawing.Size(75, 23);
            this.buttonKategorijeKnjige.TabIndex = 25;
            this.buttonKategorijeKnjige.Text = "Kategorije";
            this.buttonKategorijeKnjige.UseVisualStyleBackColor = true;
            this.buttonKategorijeKnjige.Click += new System.EventHandler(this.buttonKategorijeKnjige_Click);
            // 
            // comboBoxKategorije
            // 
            this.comboBoxKategorije.FormattingEnabled = true;
            this.comboBoxKategorije.Location = new System.Drawing.Point(496, 271);
            this.comboBoxKategorije.Name = "comboBoxKategorije";
            this.comboBoxKategorije.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKategorije.TabIndex = 26;
            // 
            // comboBoxAutori
            // 
            this.comboBoxAutori.FormattingEnabled = true;
            this.comboBoxAutori.Location = new System.Drawing.Point(496, 344);
            this.comboBoxAutori.Name = "comboBoxAutori";
            this.comboBoxAutori.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAutori.TabIndex = 28;
            // 
            // buttonEknnjigeAutori
            // 
            this.buttonEknnjigeAutori.Location = new System.Drawing.Point(702, 342);
            this.buttonEknnjigeAutori.Name = "buttonEknnjigeAutori";
            this.buttonEknnjigeAutori.Size = new System.Drawing.Size(75, 23);
            this.buttonEknnjigeAutori.TabIndex = 27;
            this.buttonEknnjigeAutori.Text = "Autori";
            this.buttonEknnjigeAutori.UseVisualStyleBackColor = true;
            this.buttonEknnjigeAutori.Click += new System.EventHandler(this.buttonEknnjigeAutori_Click);
            // 
            // buttonmp3file
            // 
            this.buttonmp3file.Location = new System.Drawing.Point(312, 170);
            this.buttonmp3file.Name = "buttonmp3file";
            this.buttonmp3file.Size = new System.Drawing.Size(75, 23);
            this.buttonmp3file.TabIndex = 29;
            this.buttonmp3file.Text = "MP3 file";
            this.buttonmp3file.UseVisualStyleBackColor = true;
            this.buttonmp3file.Click += new System.EventHandler(this.buttonmp3file_Click);
            // 
            // buttonpdffile
            // 
            this.buttonpdffile.Location = new System.Drawing.Point(442, 169);
            this.buttonpdffile.Name = "buttonpdffile";
            this.buttonpdffile.Size = new System.Drawing.Size(75, 23);
            this.buttonpdffile.TabIndex = 30;
            this.buttonpdffile.Text = "PDF file";
            this.buttonpdffile.UseVisualStyleBackColor = true;
            this.buttonpdffile.Click += new System.EventHandler(this.buttonpdffile_Click);
            // 
            // openFileDialogmp3
            // 
            this.openFileDialogmp3.FileName = "openFileDialogmp3";
            // 
            // openFileDialogpdf
            // 
            this.openFileDialogpdf.FileName = "openFileDialogpdf";
            // 
            // FormEknjigeDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 638);
            this.Controls.Add(this.buttonpdffile);
            this.Controls.Add(this.buttonmp3file);
            this.Controls.Add(this.comboBoxAutori);
            this.Controls.Add(this.buttonEknnjigeAutori);
            this.Controls.Add(this.comboBoxKategorije);
            this.Controls.Add(this.buttonKategorijeKnjige);
            this.Controls.Add(this.checkBoxPdf);
            this.Controls.Add(this.checkBoxMP3);
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
        private System.Windows.Forms.CheckBox checkBoxMP3;
        private System.Windows.Forms.CheckBox checkBoxPdf;
        private System.Windows.Forms.Button buttonKategorijeKnjige;
        private System.Windows.Forms.ComboBox comboBoxKategorije;
        private System.Windows.Forms.ComboBox comboBoxAutori;
        private System.Windows.Forms.Button buttonEknnjigeAutori;
        private System.Windows.Forms.Button buttonmp3file;
        private System.Windows.Forms.Button buttonpdffile;
        private System.Windows.Forms.OpenFileDialog openFileDialogmp3;
        private System.Windows.Forms.OpenFileDialog openFileDialogpdf;
    }
}