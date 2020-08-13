namespace eKnjige.WinUI.Komentari
{
    partial class FormKomentari
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KomentarId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.komentar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumKomentara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izbrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btntrazi = new System.Windows.Forms.Button();
            this.txtTrazi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KomentarId,
            this.komentar,
            this.DatumKomentara,
            this.Izbrisi});
            this.dataGridView1.Location = new System.Drawing.Point(96, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(530, 260);
            this.dataGridView1.TabIndex = 0;
            // 
            // KomentarId
            // 
            this.KomentarId.DataPropertyName = "KomentarId";
            this.KomentarId.HeaderText = "KomentarId";
            this.KomentarId.Name = "KomentarId";
            this.KomentarId.Visible = false;
            // 
            // komentar
            // 
            this.komentar.DataPropertyName = "komentar";
            this.komentar.HeaderText = "komentar";
            this.komentar.Name = "komentar";
            // 
            // DatumKomentara
            // 
            this.DatumKomentara.DataPropertyName = "DatumKomentara";
            this.DatumKomentara.HeaderText = "DatumKomentara";
            this.DatumKomentara.Name = "DatumKomentara";
            // 
            // Izbrisi
            // 
            this.Izbrisi.HeaderText = "Izbrisi";
            this.Izbrisi.Name = "Izbrisi";
            // 
            // btntrazi
            // 
            this.btntrazi.BackColor = System.Drawing.SystemColors.Highlight;
            this.btntrazi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btntrazi.Location = new System.Drawing.Point(301, 38);
            this.btntrazi.Name = "btntrazi";
            this.btntrazi.Size = new System.Drawing.Size(75, 23);
            this.btntrazi.TabIndex = 1;
            this.btntrazi.Text = "Traži";
            this.btntrazi.UseVisualStyleBackColor = false;
            this.btntrazi.Click += new System.EventHandler(this.btntrazi_Click);
            // 
            // txtTrazi
            // 
            this.txtTrazi.Location = new System.Drawing.Point(96, 38);
            this.txtTrazi.Name = "txtTrazi";
            this.txtTrazi.Size = new System.Drawing.Size(149, 20);
            this.txtTrazi.TabIndex = 2;
            // 
            // FormKomentari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTrazi);
            this.Controls.Add(this.btntrazi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormKomentari";
            this.Text = "FormKomentari";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btntrazi;
        private System.Windows.Forms.TextBox txtTrazi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KomentarId;
        private System.Windows.Forms.DataGridViewTextBoxColumn komentar;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumKomentara;
        private System.Windows.Forms.DataGridViewButtonColumn Izbrisi;
    }
}