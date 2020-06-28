namespace eKnjige.WinUI.Knjige
{
    partial class FormKnjige
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
            this.buttonPrikazi = new System.Windows.Forms.Button();
            this.textPrikazi = new System.Windows.Forms.TextBox();
            this.dgveknjige = new System.Windows.Forms.DataGridView();
            this.EKnjigaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgveknjige)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPrikazi
            // 
            this.buttonPrikazi.Location = new System.Drawing.Point(40, 29);
            this.buttonPrikazi.Name = "buttonPrikazi";
            this.buttonPrikazi.Size = new System.Drawing.Size(75, 23);
            this.buttonPrikazi.TabIndex = 0;
            this.buttonPrikazi.Text = "Prikaži";
            this.buttonPrikazi.UseVisualStyleBackColor = true;
            this.buttonPrikazi.Click += new System.EventHandler(this.buttonPrikazi_Click);
            // 
            // textPrikazi
            // 
            this.textPrikazi.Location = new System.Drawing.Point(144, 31);
            this.textPrikazi.Name = "textPrikazi";
            this.textPrikazi.Size = new System.Drawing.Size(100, 20);
            this.textPrikazi.TabIndex = 1;
            // 
            // dgveknjige
            // 
            this.dgveknjige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgveknjige.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EKnjigaID,
            this.Naziv,
            this.Ocjena,
            this.Cijena});
            this.dgveknjige.Location = new System.Drawing.Point(40, 133);
            this.dgveknjige.Name = "dgveknjige";
            this.dgveknjige.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgveknjige.Size = new System.Drawing.Size(650, 221);
            this.dgveknjige.TabIndex = 2;
            this.dgveknjige.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgveknjige.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgveknjige_MouseDoubleClick);
            // 
            // EKnjigaID
            // 
            this.EKnjigaID.DataPropertyName = "EKnjigaID";
            this.EKnjigaID.HeaderText = "EKnjigeID";
            this.EKnjigaID.Name = "EKnjigaID";
            this.EKnjigaID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            // 
            // Ocjena
            // 
            this.Ocjena.DataPropertyName = "OcjenaKnjige";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.Name = "Ocjena";
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            // 
            // FormKnjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgveknjige);
            this.Controls.Add(this.textPrikazi);
            this.Controls.Add(this.buttonPrikazi);
            this.Name = "FormKnjige";
            this.Text = "FormKnjige";
            ((System.ComponentModel.ISupportInitialize)(this.dgveknjige)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrikazi;
        private System.Windows.Forms.TextBox textPrikazi;
        private System.Windows.Forms.DataGridView dgveknjige;
        private System.Windows.Forms.DataGridViewTextBoxColumn EKnjigaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
    }
}