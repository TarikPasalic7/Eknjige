namespace eKnjige.WinUI.Knjige
{
    partial class FormKategorijeKnjige
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
            this.listBoxKategorijeKnjige = new System.Windows.Forms.ListBox();
            this.buttonDodajKK = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // listBoxKategorijeKnjige
            // 
            this.listBoxKategorijeKnjige.FormattingEnabled = true;
            this.listBoxKategorijeKnjige.Location = new System.Drawing.Point(168, 54);
            this.listBoxKategorijeKnjige.Name = "listBoxKategorijeKnjige";
            this.listBoxKategorijeKnjige.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxKategorijeKnjige.Size = new System.Drawing.Size(251, 199);
            this.listBoxKategorijeKnjige.TabIndex = 0;
            // 
            // buttonDodajKK
            // 
            this.buttonDodajKK.Location = new System.Drawing.Point(516, 266);
            this.buttonDodajKK.Name = "buttonDodajKK";
            this.buttonDodajKK.Size = new System.Drawing.Size(75, 23);
            this.buttonDodajKK.TabIndex = 1;
            this.buttonDodajKK.Text = "Dodaj";
            this.buttonDodajKK.UseVisualStyleBackColor = true;
            this.buttonDodajKK.Click += new System.EventHandler(this.buttonDodajKK_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(31, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(31, 218);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 3;
            // 
            // FormKategorijeKnjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 388);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonDodajKK);
            this.Controls.Add(this.listBoxKategorijeKnjige);
            this.Name = "FormKategorijeKnjige";
            this.Text = "FormKategorijeKnjige";
            this.Load += new System.EventHandler(this.FormKategorijeKnjige_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxKategorijeKnjige;
        private System.Windows.Forms.Button buttonDodajKK;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}