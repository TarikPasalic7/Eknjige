namespace eKnjige.WinUI
{
    partial class FormIndex
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.klijentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviKlijentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.knjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipFajlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.komentariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prijedloziKnjigaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.klijentiToolStripMenuItem,
            this.knjigeToolStripMenuItem,
            this.kategorijeToolStripMenuItem,
            this.autoriToolStripMenuItem,
            this.tipFajlaToolStripMenuItem,
            this.komentariToolStripMenuItem,
            this.prijedloziKnjigaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // klijentiToolStripMenuItem
            // 
            this.klijentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem,
            this.noviKlijentToolStripMenuItem});
            this.klijentiToolStripMenuItem.Name = "klijentiToolStripMenuItem";
            this.klijentiToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.klijentiToolStripMenuItem.Text = "Klijenti";
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.pretragaToolStripMenuItem.Text = "Pretraga";
            this.pretragaToolStripMenuItem.Click += new System.EventHandler(this.pretragaToolStripMenuItem_Click);
            // 
            // noviKlijentToolStripMenuItem
            // 
            this.noviKlijentToolStripMenuItem.Name = "noviKlijentToolStripMenuItem";
            this.noviKlijentToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.noviKlijentToolStripMenuItem.Text = "Novi Klijent";
            this.noviKlijentToolStripMenuItem.Click += new System.EventHandler(this.noviKlijentToolStripMenuItem_Click_1);
            // 
            // knjigeToolStripMenuItem
            // 
            this.knjigeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem1});
            this.knjigeToolStripMenuItem.Name = "knjigeToolStripMenuItem";
            this.knjigeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.knjigeToolStripMenuItem.Text = "Knjige";
            // 
            // pretragaToolStripMenuItem1
            // 
            this.pretragaToolStripMenuItem1.Name = "pretragaToolStripMenuItem1";
            this.pretragaToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.pretragaToolStripMenuItem1.Text = "Pretraga";
            this.pretragaToolStripMenuItem1.Click += new System.EventHandler(this.pretragaToolStripMenuItem1_Click);
            // 
            // kategorijeToolStripMenuItem
            // 
            this.kategorijeToolStripMenuItem.Name = "kategorijeToolStripMenuItem";
            this.kategorijeToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.kategorijeToolStripMenuItem.Text = "Kategorije";
            this.kategorijeToolStripMenuItem.Click += new System.EventHandler(this.kategorijeToolStripMenuItem_Click);
            // 
            // autoriToolStripMenuItem
            // 
            this.autoriToolStripMenuItem.Name = "autoriToolStripMenuItem";
            this.autoriToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.autoriToolStripMenuItem.Text = "Autori";
            this.autoriToolStripMenuItem.Click += new System.EventHandler(this.autoriToolStripMenuItem_Click);
            // 
            // tipFajlaToolStripMenuItem
            // 
            this.tipFajlaToolStripMenuItem.Name = "tipFajlaToolStripMenuItem";
            this.tipFajlaToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.tipFajlaToolStripMenuItem.Text = "TipFajla";
            this.tipFajlaToolStripMenuItem.Click += new System.EventHandler(this.tipFajlaToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // komentariToolStripMenuItem
            // 
            this.komentariToolStripMenuItem.Name = "komentariToolStripMenuItem";
            this.komentariToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.komentariToolStripMenuItem.Text = "Komentari";
            this.komentariToolStripMenuItem.Click += new System.EventHandler(this.komentariToolStripMenuItem_Click);
            // 
            // prijedloziKnjigaToolStripMenuItem
            // 
            this.prijedloziKnjigaToolStripMenuItem.Name = "prijedloziKnjigaToolStripMenuItem";
            this.prijedloziKnjigaToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.prijedloziKnjigaToolStripMenuItem.Text = "Prijedlozi Knjiga";
            this.prijedloziKnjigaToolStripMenuItem.Click += new System.EventHandler(this.prijedloziKnjigaToolStripMenuItem_Click);
            // 
            // FormIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormIndex";
            this.Text = "FormIndex";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem klijentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviKlijentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem knjigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kategorijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipFajlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem komentariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prijedloziKnjigaToolStripMenuItem;
    }
}



