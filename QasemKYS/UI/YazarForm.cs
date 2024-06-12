using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QasemKYS.UI
{
    public partial class YazarForm : Form
    {
        public YazarForm()
        {
            InitializeComponent();
        }
        public Yazar Yazar { get; set; }

        public bool Güncelleme { get; set; } = false;

        private void btniptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        
        private void btnTamam_Click(object sender, EventArgs e)
        {
          
            if (!ErrorControl(textAd)) return;
            if (!ErrorControl(textSoyad)) return;
        
          
            Yazar.AD = textAd.Text;
            Yazar.Soyad = textSoyad.Text;

            DialogResult = DialogResult.OK;
        }
        private bool ErrorControl(Control c)
        {
            if (c.Text == "")
            {
                errorProvider1.SetError(c, "Eksik veya hatalı bilgi");
                c.Focus();
                return false;
            }
            errorProvider1.SetError(c, "");
            return true;

        }

        private void YazarForm_Load(object sender, EventArgs e)
        {
            textID.Text = Yazar.ID.ToString();
            if (Güncelleme)
            {
                textAd.Text = Yazar.AD;
                textSoyad.Text = Yazar.Soyad;
             

            }
        }
    }
}
