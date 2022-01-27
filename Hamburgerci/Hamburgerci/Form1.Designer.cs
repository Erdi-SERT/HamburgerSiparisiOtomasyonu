
namespace Hamburgerci
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.cmbMenüler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBoyutlar = new System.Windows.Forms.GroupBox();
            this.rdoBüyük = new System.Windows.Forms.RadioButton();
            this.rdoOrta = new System.Windows.Forms.RadioButton();
            this.rdoKüçük = new System.Windows.Forms.RadioButton();
            this.flpEkstraMalzemeler = new System.Windows.Forms.FlowLayoutPanel();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbxSiparişler = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.grpBoyutlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(15, 12);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(207, 150);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // cmbMenüler
            // 
            this.cmbMenüler.FormattingEnabled = true;
            this.cmbMenüler.Location = new System.Drawing.Point(15, 181);
            this.cmbMenüler.Name = "cmbMenüler";
            this.cmbMenüler.Size = new System.Drawing.Size(201, 21);
            this.cmbMenüler.TabIndex = 1;
         
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menü Seçin";
            // 
            // grpBoyutlar
            // 
            this.grpBoyutlar.Controls.Add(this.rdoBüyük);
            this.grpBoyutlar.Controls.Add(this.rdoOrta);
            this.grpBoyutlar.Controls.Add(this.rdoKüçük);
            this.grpBoyutlar.Location = new System.Drawing.Point(15, 218);
            this.grpBoyutlar.Name = "grpBoyutlar";
            this.grpBoyutlar.Size = new System.Drawing.Size(206, 42);
            this.grpBoyutlar.TabIndex = 3;
            this.grpBoyutlar.TabStop = false;
            this.grpBoyutlar.Text = "Boyut Seçiniz";
            // 
            // rdoBüyük
            // 
            this.rdoBüyük.AutoSize = true;
            this.rdoBüyük.Location = new System.Drawing.Point(135, 19);
            this.rdoBüyük.Name = "rdoBüyük";
            this.rdoBüyük.Size = new System.Drawing.Size(55, 17);
            this.rdoBüyük.TabIndex = 2;
            this.rdoBüyük.TabStop = true;
            this.rdoBüyük.Text = "Büyük";
            this.rdoBüyük.UseVisualStyleBackColor = true;
            // 
            // rdoOrta
            // 
            this.rdoOrta.AutoSize = true;
            this.rdoOrta.Location = new System.Drawing.Point(68, 19);
            this.rdoOrta.Name = "rdoOrta";
            this.rdoOrta.Size = new System.Drawing.Size(45, 17);
            this.rdoOrta.TabIndex = 1;
            this.rdoOrta.TabStop = true;
            this.rdoOrta.Text = "Orta";
            this.rdoOrta.UseVisualStyleBackColor = true;
            // 
            // rdoKüçük
            // 
            this.rdoKüçük.AutoSize = true;
            this.rdoKüçük.Location = new System.Drawing.Point(6, 19);
            this.rdoKüçük.Name = "rdoKüçük";
            this.rdoKüçük.Size = new System.Drawing.Size(56, 17);
            this.rdoKüçük.TabIndex = 0;
            this.rdoKüçük.TabStop = true;
            this.rdoKüçük.Text = "Küçük";
            this.rdoKüçük.UseVisualStyleBackColor = true;
            // 
            // flpEkstraMalzemeler
            // 
            this.flpEkstraMalzemeler.Location = new System.Drawing.Point(18, 279);
            this.flpEkstraMalzemeler.Name = "flpEkstraMalzemeler";
            this.flpEkstraMalzemeler.Size = new System.Drawing.Size(248, 155);
            this.flpEkstraMalzemeler.TabIndex = 4;
            
            // 
            // nmrAdet
            // 
            this.nmrAdet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nmrAdet.Location = new System.Drawing.Point(102, 440);
            this.nmrAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(120, 20);
            this.nmrAdet.TabIndex = 5;
            this.nmrAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmrAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adet";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sipariş Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbxSiparişler
            // 
            this.lbxSiparişler.FormattingEnabled = true;
            this.lbxSiparişler.HorizontalScrollbar = true;
            this.lbxSiparişler.Location = new System.Drawing.Point(272, 17);
            this.lbxSiparişler.MultiColumn = true;
            this.lbxSiparişler.Name = "lbxSiparişler";
            this.lbxSiparişler.Size = new System.Drawing.Size(484, 355);
            this.lbxSiparişler.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Toplam Tutar";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.ForeColor = System.Drawing.Color.DarkRed;
            this.lblToplam.Location = new System.Drawing.Point(464, 447);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(34, 13);
            this.lblToplam.TabIndex = 10;
            this.lblToplam.Text = "₺0,00";
   
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(571, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 55);
            this.button2.TabIndex = 11;
            this.button2.Text = "Siparişi Tamamla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "MALZEME SEÇİNİZ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbxSiparişler);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmrAdet);
            this.Controls.Add(this.flpEkstraMalzemeler);
            this.Controls.Add(this.grpBoyutlar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMenüler);
            this.Controls.Add(this.pbxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.grpBoyutlar.ResumeLayout(false);
            this.grpBoyutlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.ComboBox cmbMenüler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBoyutlar;
        private System.Windows.Forms.RadioButton rdoBüyük;
        private System.Windows.Forms.RadioButton rdoOrta;
        private System.Windows.Forms.RadioButton rdoKüçük;
        private System.Windows.Forms.FlowLayoutPanel flpEkstraMalzemeler;
        private System.Windows.Forms.NumericUpDown nmrAdet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbxSiparişler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
    }
}

