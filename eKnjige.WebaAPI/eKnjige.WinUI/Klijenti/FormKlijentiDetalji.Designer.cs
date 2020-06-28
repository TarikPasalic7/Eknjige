namespace eKnjige.WinUI.Klijenti
{
    partial class FormKlijentiDetalji
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
            this.textIme = new System.Windows.Forms.TextBox();
            this.labelIme = new System.Windows.Forms.Label();
            this.labelDatumRodjenja = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textJmbg = new System.Windows.Forms.TextBox();
            this.labelKorisnickoIme = new System.Windows.Forms.Label();
            this.textKorisnickoIme = new System.Windows.Forms.TextBox();
            this.labelPrezime = new System.Windows.Forms.Label();
            this.textPrezime = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.labelPasswordPotvrda = new System.Windows.Forms.Label();
            this.textPasswordPotvrda = new System.Windows.Forms.TextBox();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbSpol = new System.Windows.Forms.ComboBox();
            this.labelSpol = new System.Windows.Forms.Label();
            this.labelGrad = new System.Windows.Forms.Label();
            this.cmbGradovi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.buttonGrad = new System.Windows.Forms.Button();
            this.dateDatum = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // textIme
            // 
            this.textIme.Location = new System.Drawing.Point(12, 44);
            this.textIme.Name = "textIme";
            this.textIme.Size = new System.Drawing.Size(159, 20);
            this.textIme.TabIndex = 0;
            this.textIme.Validating += new System.ComponentModel.CancelEventHandler(this.textIme_Validating);
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Location = new System.Drawing.Point(12, 28);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(24, 13);
            this.labelIme.TabIndex = 1;
            this.labelIme.Text = "Ime";
            // 
            // labelDatumRodjenja
            // 
            this.labelDatumRodjenja.AutoSize = true;
            this.labelDatumRodjenja.Location = new System.Drawing.Point(9, 276);
            this.labelDatumRodjenja.Name = "labelDatumRodjenja";
            this.labelDatumRodjenja.Size = new System.Drawing.Size(82, 13);
            this.labelDatumRodjenja.TabIndex = 3;
            this.labelDatumRodjenja.Text = "Datum Rođenja";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(12, 219);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(36, 13);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "JMBG";
            // 
            // textJmbg
            // 
            this.textJmbg.Location = new System.Drawing.Point(12, 244);
            this.textJmbg.Name = "textJmbg";
            this.textJmbg.Size = new System.Drawing.Size(159, 20);
            this.textJmbg.TabIndex = 4;
            this.textJmbg.Validating += new System.ComponentModel.CancelEventHandler(this.textEmail_Validating);
            // 
            // labelKorisnickoIme
            // 
            this.labelKorisnickoIme.AutoSize = true;
            this.labelKorisnickoIme.Location = new System.Drawing.Point(12, 154);
            this.labelKorisnickoIme.Name = "labelKorisnickoIme";
            this.labelKorisnickoIme.Size = new System.Drawing.Size(73, 13);
            this.labelKorisnickoIme.TabIndex = 7;
            this.labelKorisnickoIme.Text = "KorisnickoIme";
            // 
            // textKorisnickoIme
            // 
            this.textKorisnickoIme.Location = new System.Drawing.Point(15, 170);
            this.textKorisnickoIme.Name = "textKorisnickoIme";
            this.textKorisnickoIme.Size = new System.Drawing.Size(159, 20);
            this.textKorisnickoIme.TabIndex = 6;
            this.textKorisnickoIme.Validating += new System.ComponentModel.CancelEventHandler(this.textKorisnickoIme_Validating);
            // 
            // labelPrezime
            // 
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.Location = new System.Drawing.Point(12, 83);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(44, 13);
            this.labelPrezime.TabIndex = 9;
            this.labelPrezime.Text = "Prezime";
            this.labelPrezime.UseMnemonic = false;
            // 
            // textPrezime
            // 
            this.textPrezime.Location = new System.Drawing.Point(12, 99);
            this.textPrezime.Name = "textPrezime";
            this.textPrezime.Size = new System.Drawing.Size(159, 20);
            this.textPrezime.TabIndex = 8;
            this.textPrezime.TextChanged += new System.EventHandler(this.textPrezime_TextChanged);
            this.textPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.textPrezime_Validating);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(9, 343);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 11;
            this.labelPassword.Text = "Password";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(12, 370);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(159, 20);
            this.textPassword.TabIndex = 10;
            // 
            // labelPasswordPotvrda
            // 
            this.labelPasswordPotvrda.AutoSize = true;
            this.labelPasswordPotvrda.Location = new System.Drawing.Point(221, 343);
            this.labelPasswordPotvrda.Name = "labelPasswordPotvrda";
            this.labelPasswordPotvrda.Size = new System.Drawing.Size(93, 13);
            this.labelPasswordPotvrda.TabIndex = 13;
            this.labelPasswordPotvrda.Text = "Password Potvrda";
            // 
            // textPasswordPotvrda
            // 
            this.textPasswordPotvrda.Location = new System.Drawing.Point(224, 370);
            this.textPasswordPotvrda.Name = "textPasswordPotvrda";
            this.textPasswordPotvrda.PasswordChar = '*';
            this.textPasswordPotvrda.Size = new System.Drawing.Size(159, 20);
            this.textPasswordPotvrda.TabIndex = 12;
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(510, 401);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(130, 38);
            this.btnSnimi.TabIndex = 14;
            this.btnSnimi.Text = "Sačuvaj";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cmbSpol
            // 
            this.cmbSpol.FormattingEnabled = true;
            this.cmbSpol.Location = new System.Drawing.Point(224, 99);
            this.cmbSpol.Name = "cmbSpol";
            this.cmbSpol.Size = new System.Drawing.Size(121, 21);
            this.cmbSpol.TabIndex = 15;
            // 
            // labelSpol
            // 
            this.labelSpol.AutoSize = true;
            this.labelSpol.Location = new System.Drawing.Point(221, 83);
            this.labelSpol.Name = "labelSpol";
            this.labelSpol.Size = new System.Drawing.Size(28, 13);
            this.labelSpol.TabIndex = 16;
            this.labelSpol.Text = "Spol";
            // 
            // labelGrad
            // 
            this.labelGrad.AutoSize = true;
            this.labelGrad.Location = new System.Drawing.Point(221, 28);
            this.labelGrad.Name = "labelGrad";
            this.labelGrad.Size = new System.Drawing.Size(30, 13);
            this.labelGrad.TabIndex = 18;
            this.labelGrad.Text = "Grad";
            // 
            // cmbGradovi
            // 
            this.cmbGradovi.FormattingEnabled = true;
            this.cmbGradovi.Location = new System.Drawing.Point(224, 44);
            this.cmbGradovi.Name = "cmbGradovi";
            this.cmbGradovi.Size = new System.Drawing.Size(121, 21);
            this.cmbGradovi.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Email";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(12, 425);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(159, 20);
            this.textEmail.TabIndex = 19;
            // 
            // buttonGrad
            // 
            this.buttonGrad.Location = new System.Drawing.Point(395, 44);
            this.buttonGrad.Name = "buttonGrad";
            this.buttonGrad.Size = new System.Drawing.Size(75, 23);
            this.buttonGrad.TabIndex = 21;
            this.buttonGrad.Text = "Dodaj Grad";
            this.buttonGrad.UseVisualStyleBackColor = true;
            this.buttonGrad.Click += new System.EventHandler(this.buttonGrad_Click);
            // 
            // dateDatum
            // 
            this.dateDatum.Location = new System.Drawing.Point(12, 301);
            this.dateDatum.Name = "dateDatum";
            this.dateDatum.Size = new System.Drawing.Size(200, 20);
            this.dateDatum.TabIndex = 22;
            // 
            // FormKlijentiDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 492);
            this.Controls.Add(this.dateDatum);
            this.Controls.Add(this.buttonGrad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.labelGrad);
            this.Controls.Add(this.cmbGradovi);
            this.Controls.Add(this.labelSpol);
            this.Controls.Add(this.cmbSpol);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.labelPasswordPotvrda);
            this.Controls.Add(this.textPasswordPotvrda);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.labelPrezime);
            this.Controls.Add(this.textPrezime);
            this.Controls.Add(this.labelKorisnickoIme);
            this.Controls.Add(this.textKorisnickoIme);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textJmbg);
            this.Controls.Add(this.labelDatumRodjenja);
            this.Controls.Add(this.labelIme);
            this.Controls.Add(this.textIme);
            this.Name = "FormKlijentiDetalji";
            this.Text = "FormKlijentiDetalji";
            this.Load += new System.EventHandler(this.FormKlijentiDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textIme;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label labelDatumRodjenja;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textJmbg;
        private System.Windows.Forms.Label labelKorisnickoIme;
        private System.Windows.Forms.TextBox textKorisnickoIme;
        private System.Windows.Forms.Label labelPrezime;
        private System.Windows.Forms.TextBox textPrezime;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label labelPasswordPotvrda;
        private System.Windows.Forms.TextBox textPasswordPotvrda;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label labelGrad;
        private System.Windows.Forms.ComboBox cmbGradovi;
        private System.Windows.Forms.Label labelSpol;
        private System.Windows.Forms.ComboBox cmbSpol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Button buttonGrad;
        private System.Windows.Forms.DateTimePicker dateDatum;
    }
}