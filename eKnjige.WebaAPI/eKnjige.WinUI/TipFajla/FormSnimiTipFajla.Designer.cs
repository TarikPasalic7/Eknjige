namespace eKnjige.WinUI.TipFajla
{
    partial class FormSnimiTipFajla
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
            this.btnSnimi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipFajlaNaziv = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSnimi
            // 
            this.btnSnimi.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSnimi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSnimi.Location = new System.Drawing.Point(338, 181);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(75, 23);
            this.btnSnimi.TabIndex = 0;
            this.btnSnimi.Text = "Dodaj";
            this.btnSnimi.UseVisualStyleBackColor = false;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv";
            // 
            // txtTipFajlaNaziv
            // 
            this.txtTipFajlaNaziv.Location = new System.Drawing.Point(43, 83);
            this.txtTipFajlaNaziv.Name = "txtTipFajlaNaziv";
            this.txtTipFajlaNaziv.Size = new System.Drawing.Size(112, 20);
            this.txtTipFajlaNaziv.TabIndex = 2;
            // 
            // FormSnimiTipFajla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(498, 244);
            this.Controls.Add(this.txtTipFajlaNaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSnimi);
            this.Name = "FormSnimiTipFajla";
            this.Text = "FormSnimiTipFajla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTipFajlaNaziv;
    }
}