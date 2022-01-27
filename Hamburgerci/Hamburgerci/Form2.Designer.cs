
namespace Hamburgerci
{
    partial class Form2
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
            this.txtMenüAdı = new System.Windows.Forms.TextBox();
            this.nmrMenüFiyatı = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenüEkle = new System.Windows.Forms.Button();
            this.grpMenüEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMenüFiyatı)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMenüEkle
            // 
            this.grpMenüEkle.AutoSize = true;
            this.grpMenüEkle.Controls.Add(this.txtMenüAdı);
            this.grpMenüEkle.Controls.Add(this.nmrMenüFiyatı);
            this.grpMenüEkle.Controls.Add(this.label2);
            this.grpMenüEkle.Controls.Add(this.label1);
            this.grpMenüEkle.Controls.Add(this.btnMenüEkle);
            this.grpMenüEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpMenüEkle.Location = new System.Drawing.Point(35, 19);
            this.grpMenüEkle.Name = "grpMenüEkle";
            this.grpMenüEkle.Size = new System.Drawing.Size(348, 249);
            this.grpMenüEkle.TabIndex = 0;
            this.grpMenüEkle.TabStop = false;
            this.grpMenüEkle.Text = "Menü Bilgileri";
            // 
            // txtMenüAdı
            // 
            this.txtMenüAdı.Location = new System.Drawing.Point(169, 78);
            this.txtMenüAdı.Name = "txtMenüAdı";
            this.txtMenüAdı.Size = new System.Drawing.Size(144, 20);
            this.txtMenüAdı.TabIndex = 4;
            // 
            // nmrMenüFiyatı
            // 
            this.nmrMenüFiyatı.DecimalPlaces = 2;
            this.nmrMenüFiyatı.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nmrMenüFiyatı.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.nmrMenüFiyatı.Location = new System.Drawing.Point(169, 112);
            this.nmrMenüFiyatı.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrMenüFiyatı.Name = "nmrMenüFiyatı";
            this.nmrMenüFiyatı.Size = new System.Drawing.Size(144, 20);
            this.nmrMenüFiyatı.TabIndex = 3;
            this.nmrMenüFiyatı.Value = new decimal(new int[] {
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menü Adı";
            // 
            // btnMenüEkle
            // 
            this.btnMenüEkle.Location = new System.Drawing.Point(169, 168);
            this.btnMenüEkle.Name = "btnMenüEkle";
            this.btnMenüEkle.Size = new System.Drawing.Size(132, 28);
            this.btnMenüEkle.TabIndex = 0;
            this.btnMenüEkle.Text = "Menüyü Kaydet";
            this.btnMenüEkle.UseVisualStyleBackColor = true;
            this.btnMenüEkle.Click += new System.EventHandler(this.btnMenüEkle_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 284);
            this.Controls.Add(this.grpMenüEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form3";
            this.grpMenüEkle.ResumeLayout(false);
            this.grpMenüEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMenüFiyatı)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMenüAdı;
        private System.Windows.Forms.NumericUpDown nmrMenüFiyatı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenüEkle;
        private System.Windows.Forms.GroupBox grpMenüEkle;
    }
}