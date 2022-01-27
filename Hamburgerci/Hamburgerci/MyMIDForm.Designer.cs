
namespace Hamburgerci
{
    partial class MyMIDForm
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
            this.btnSiparişYönetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSiparişOluştur = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSiparişBilgileri = new System.Windows.Forms.ToolStripMenuItem();
            this.btnÜrünYönetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenüEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEkstraMalzemeEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSiparişYönetimi,
            this.btnÜrünYönetimi});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnSiparişYönetimi
            // 
            this.btnSiparişYönetimi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSiparişOluştur,
            this.btnSiparişBilgileri});
            this.btnSiparişYönetimi.Name = "btnSiparişYönetimi";
            this.btnSiparişYönetimi.Size = new System.Drawing.Size(103, 20);
            this.btnSiparişYönetimi.Text = "Sipariş Yönetimi";
            // 
            // btnSiparişOluştur
            // 
            this.btnSiparişOluştur.Name = "btnSiparişOluştur";
            this.btnSiparişOluştur.Size = new System.Drawing.Size(180, 22);
            this.btnSiparişOluştur.Text = "Sipariş Oluştur";
            this.btnSiparişOluştur.Click += new System.EventHandler(this.btnSiparişOluştur_Click);
            // 
            // btnSiparişBilgileri
            // 
            this.btnSiparişBilgileri.Name = "btnSiparişBilgileri";
            this.btnSiparişBilgileri.Size = new System.Drawing.Size(180, 22);
            this.btnSiparişBilgileri.Text = "Sipariş Bilgileri";
            this.btnSiparişBilgileri.Click += new System.EventHandler(this.btnSiparişBilgileri_Click);
            // 
            // btnÜrünYönetimi
            // 
            this.btnÜrünYönetimi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenüEkle,
            this.btnEkstraMalzemeEkle});
            this.btnÜrünYönetimi.Name = "btnÜrünYönetimi";
            this.btnÜrünYönetimi.Size = new System.Drawing.Size(95, 20);
            this.btnÜrünYönetimi.Text = "Ürün Yönetimi";
            // 
            // btnMenüEkle
            // 
            this.btnMenüEkle.Name = "btnMenüEkle";
            this.btnMenüEkle.Size = new System.Drawing.Size(180, 22);
            this.btnMenüEkle.Text = "Menü Ekle";
            this.btnMenüEkle.Click += new System.EventHandler(this.btnMenüEkle_Click);
            // 
            // btnEkstraMalzemeEkle
            // 
            this.btnEkstraMalzemeEkle.Name = "btnEkstraMalzemeEkle";
            this.btnEkstraMalzemeEkle.Size = new System.Drawing.Size(180, 22);
            this.btnEkstraMalzemeEkle.Text = "Ekstra Malzeme Ekle";
            this.btnEkstraMalzemeEkle.Click += new System.EventHandler(this.btnEkstraMalzemeEkle_Click);
            // 
            // MyMIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MyMIDForm";
            this.Text = "MyMIDForm";
          
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnSiparişYönetimi;
        private System.Windows.Forms.ToolStripMenuItem btnSiparişOluştur;
        private System.Windows.Forms.ToolStripMenuItem btnSiparişBilgileri;
        private System.Windows.Forms.ToolStripMenuItem btnÜrünYönetimi;
        private System.Windows.Forms.ToolStripMenuItem btnMenüEkle;
        private System.Windows.Forms.ToolStripMenuItem btnEkstraMalzemeEkle;
    }
}