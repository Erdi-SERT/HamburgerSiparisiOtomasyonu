
namespace Hamburgerci
{
    partial class Form3
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
            this.grpMenüEkle = new System.Windows.Forms.GroupBox();
            this.txtEkstraMalzemeAdı = new System.Windows.Forms.TextBox();
            this.nmrEkstraMalzemeFiyatı = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEkstraMalzemeEKle = new System.Windows.Forms.Button();
            this.grpMenüEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEkstraMalzemeFiyatı)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMenüEkle
            // 
            this.grpMenüEkle.Controls.Add(this.txtEkstraMalzemeAdı);
            this.grpMenüEkle.Controls.Add(this.nmrEkstraMalzemeFiyatı);
            this.grpMenüEkle.Controls.Add(this.label2);
            this.grpMenüEkle.Controls.Add(this.label3);
            this.grpMenüEkle.Controls.Add(this.btnEkstraMalzemeEKle);
            this.grpMenüEkle.Location = new System.Drawing.Point(2, 12);
            this.grpMenüEkle.Name = "grpMenüEkle";
            this.grpMenüEkle.Size = new System.Drawing.Size(348, 249);
            this.grpMenüEkle.TabIndex = 3;
            this.grpMenüEkle.TabStop = false;
            this.grpMenüEkle.Text = "Ekstra Malzeme Bilgileri";
            
            // 
            // txtEkstraMalzemeAdı
            // 
            this.txtEkstraMalzemeAdı.Location = new System.Drawing.Point(169, 78);
            this.txtEkstraMalzemeAdı.Name = "txtEkstraMalzemeAdı";
            this.txtEkstraMalzemeAdı.Size = new System.Drawing.Size(144, 20);
            this.txtEkstraMalzemeAdı.TabIndex = 4;
            // 
            // nmrEkstraMalzemeFiyatı
            // 
            this.nmrEkstraMalzemeFiyatı.DecimalPlaces = 2;
            this.nmrEkstraMalzemeFiyatı.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nmrEkstraMalzemeFiyatı.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.nmrEkstraMalzemeFiyatı.Location = new System.Drawing.Point(169, 112);
            this.nmrEkstraMalzemeFiyatı.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrEkstraMalzemeFiyatı.Name = "nmrEkstraMalzemeFiyatı";
            this.nmrEkstraMalzemeFiyatı.Size = new System.Drawing.Size(144, 20);
            this.nmrEkstraMalzemeFiyatı.TabIndex = 3;
            this.nmrEkstraMalzemeFiyatı.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Menü Adı";
            // 
            // btnEkstraMalzemeEKle
            // 
            this.btnEkstraMalzemeEKle.Location = new System.Drawing.Point(169, 168);
            this.btnEkstraMalzemeEKle.Name = "btnEkstraMalzemeEKle";
            this.btnEkstraMalzemeEKle.Size = new System.Drawing.Size(132, 28);
            this.btnEkstraMalzemeEKle.TabIndex = 0;
            this.btnEkstraMalzemeEKle.Text = "Ekstra Malzeme Kaydet";
            this.btnEkstraMalzemeEKle.UseVisualStyleBackColor = true;
            this.btnEkstraMalzemeEKle.Click += new System.EventHandler(this.btnEkstraMalzemeEKle_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 272);
            this.Controls.Add(this.grpMenüEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form4";
            this.grpMenüEkle.ResumeLayout(false);
            this.grpMenüEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEkstraMalzemeFiyatı)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMenüEkle;
        private System.Windows.Forms.TextBox txtEkstraMalzemeAdı;
        private System.Windows.Forms.NumericUpDown nmrEkstraMalzemeFiyatı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEkstraMalzemeEKle;
    }
}