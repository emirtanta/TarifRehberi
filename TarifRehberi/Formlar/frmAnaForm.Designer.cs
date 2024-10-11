namespace TarifRehberi.Formlar
{
    partial class frmAnaForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tariflerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarifEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarifListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarifÖnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.malzemelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.malzemeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.malzemeListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tariflerToolStripMenuItem,
            this.malzemelerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(845, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tariflerToolStripMenuItem
            // 
            this.tariflerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tarifEkleToolStripMenuItem,
            this.tarifListesiToolStripMenuItem,
            this.tarifÖnerToolStripMenuItem});
            this.tariflerToolStripMenuItem.Name = "tariflerToolStripMenuItem";
            this.tariflerToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.tariflerToolStripMenuItem.Text = "Tarifler";
            // 
            // tarifEkleToolStripMenuItem
            // 
            this.tarifEkleToolStripMenuItem.Name = "tarifEkleToolStripMenuItem";
            this.tarifEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tarifEkleToolStripMenuItem.Text = "Tarif Ekle";
            this.tarifEkleToolStripMenuItem.Click += new System.EventHandler(this.tarifEkleToolStripMenuItem_Click);
            // 
            // tarifListesiToolStripMenuItem
            // 
            this.tarifListesiToolStripMenuItem.Name = "tarifListesiToolStripMenuItem";
            this.tarifListesiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tarifListesiToolStripMenuItem.Text = "Tarif Listesi";
            this.tarifListesiToolStripMenuItem.Click += new System.EventHandler(this.tarifListesiToolStripMenuItem_Click);
            // 
            // tarifÖnerToolStripMenuItem
            // 
            this.tarifÖnerToolStripMenuItem.Name = "tarifÖnerToolStripMenuItem";
            this.tarifÖnerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tarifÖnerToolStripMenuItem.Text = "Tarif Öner";
            // 
            // malzemelerToolStripMenuItem
            // 
            this.malzemelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.malzemeEkleToolStripMenuItem,
            this.malzemeListesiToolStripMenuItem});
            this.malzemelerToolStripMenuItem.Name = "malzemelerToolStripMenuItem";
            this.malzemelerToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.malzemelerToolStripMenuItem.Text = "Malzemeler";
            // 
            // malzemeEkleToolStripMenuItem
            // 
            this.malzemeEkleToolStripMenuItem.Name = "malzemeEkleToolStripMenuItem";
            this.malzemeEkleToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.malzemeEkleToolStripMenuItem.Text = "Malzeme Ekle";
            // 
            // malzemeListesiToolStripMenuItem
            // 
            this.malzemeListesiToolStripMenuItem.Name = "malzemeListesiToolStripMenuItem";
            this.malzemeListesiToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.malzemeListesiToolStripMenuItem.Text = "Malzeme Listesi";
            // 
            // frmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 611);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAnaForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tariflerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem malzemelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarifEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarifListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarifÖnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem malzemeEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem malzemeListesiToolStripMenuItem;
    }
}