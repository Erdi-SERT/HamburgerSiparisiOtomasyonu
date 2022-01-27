using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburgerci
{
    public partial class MyMIDForm : Form
    {
        public MyMIDForm()
        {
            InitializeComponent();
        }
         

        void ChildForm(Form childForm)  // Form tipinde Tekrar Bak
        {
            
            this.Width = childForm.Width + 25;    
            this.Height = childForm.Height + 68;   

            bool durum = false; 

            foreach (Form form in this.MdiChildren)
            {
                if (form.Text == childForm.Text)
                {
                    durum = true;
                    form.Activate();
                }
                else
                {
                    form.Close();
                }

            }

            if (durum == false)
            {
                childForm.MdiParent = this;
                childForm.Show();
            }
        }

        private void btnSiparişOluştur_Click(object sender, EventArgs e)
        {
            ChildForm(new Form1());   // child forma yeni form1 gönderdik
        }

        private void btnSiparişBilgileri_Click(object sender, EventArgs e)
        {
            ChildForm(new Form4());

        }

        private void btnMenüEkle_Click(object sender, EventArgs e)
        {
            ChildForm(new Form2());
        }

        private void btnEkstraMalzemeEkle_Click(object sender, EventArgs e)
        {
            ChildForm(new Form3());
        }
    }
}
