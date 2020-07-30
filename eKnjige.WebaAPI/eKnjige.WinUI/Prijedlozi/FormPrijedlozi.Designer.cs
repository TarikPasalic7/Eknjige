namespace eKnjige.WinUI.Prijedlozi
{
    partial class FormPrijedlozi
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
            this.dataGridViewPrijedlog = new System.Windows.Forms.DataGridView();
            this.buttonTrazi = new System.Windows.Forms.Button();
            this.textBoxTrazi = new System.Windows.Forms.TextBox();
            this.PrijedlogKnjigeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odgovoren = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrijedlog)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPrijedlog
            // 
            this.dataGridViewPrijedlog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrijedlog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrijedlogKnjigeID,
            this.Naziv,
            this.Datum,
            this.Odgovoren});
            this.dataGridViewPrijedlog.Location = new System.Drawing.Point(70, 111);
            this.dataGridViewPrijedlog.Name = "dataGridViewPrijedlog";
            this.dataGridViewPrijedlog.Size = new System.Drawing.Size(496, 241);
            this.dataGridViewPrijedlog.TabIndex = 0;
            // 
            // buttonTrazi
            // 
            this.buttonTrazi.Location = new System.Drawing.Point(297, 34);
            this.buttonTrazi.Name = "buttonTrazi";
            this.buttonTrazi.Size = new System.Drawing.Size(75, 23);
            this.buttonTrazi.TabIndex = 1;
            this.buttonTrazi.Text = "Trazi";
            this.buttonTrazi.UseVisualStyleBackColor = true;
            this.buttonTrazi.Click += new System.EventHandler(this.buttonTrazi_Click);
            // 
            // textBoxTrazi
            // 
            this.textBoxTrazi.Location = new System.Drawing.Point(84, 36);
            this.textBoxTrazi.Name = "textBoxTrazi";
            this.textBoxTrazi.Size = new System.Drawing.Size(146, 20);
            this.textBoxTrazi.TabIndex = 2;
            // 
            // PrijedlogKnjigeID
            // 
            this.PrijedlogKnjigeID.DataPropertyName = "PrijedlogKnjigeID";
            this.PrijedlogKnjigeID.HeaderText = "PrijedlogKnjigeID";
            this.PrijedlogKnjigeID.Name = "PrijedlogKnjigeID";
            this.PrijedlogKnjigeID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            // 
            // Odgovoren
            // 
            this.Odgovoren.DataPropertyName = "Odgovoren";
            this.Odgovoren.HeaderText = "Odgovoren";
            this.Odgovoren.Name = "Odgovoren";
            // 
            // FormPrijedlozi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxTrazi);
            this.Controls.Add(this.buttonTrazi);
            this.Controls.Add(this.dataGridViewPrijedlog);
            this.Name = "FormPrijedlozi";
            this.Text = "FormPrijedlozi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrijedlog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPrijedlog;
        private System.Windows.Forms.Button buttonTrazi;
        private System.Windows.Forms.TextBox textBoxTrazi;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrijedlogKnjigeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Odgovoren;
    }
}