using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QasemKYS;

namespace QasemKYS.UI
{
    public partial class KitapForm : Form
    {
        public KitapForm()
        {
            InitializeComponent();
        }
         private void btniptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public Kitap Kitap { get; set; }
        public bool Güncelleme { get; set; } = false;

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(textAd)) return;
            if (!ErrorControl(textKategoriID)) return;
            if (!ErrorControl(textYazarID)) return;
            if (!ErrorControl(numAdet)) return;


            Kitap.AD = textAd.Text ;
            Kitap.yazarID = Guid.Parse(textYazarID.Text);
            Kitap.kategoriID = Guid.Parse(textKategoriID.Text);
            Kitap.YayinYili = dateTimePicker1.Value;
            Kitap.Adet = (int)numAdet.Value;
          

            DialogResult = DialogResult.OK;
        }

        private bool ErrorControl(Control c)
        {
            if (c is TextBox)
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

            if (c is NumericUpDown)
            {
                if (((NumericUpDown)c).Value == 0)
                {
                    errorProvider1.SetError(c, "Lütfen fiyat giriniz!");
                    c.Focus();
                    return false;
                }
                errorProvider1.SetError(c, "");
            }
            return true;
        }

       

   

        private void btnYazarSeç_Click(object sender, EventArgs e)
        {
            Yazarlar yazarlar = new Yazarlar();
            if (yazarlar.ShowDialog() == DialogResult.OK)
            {
                textYazarID.Text = yazarlar.Yazar.ID.ToString();
            }
        }

        private void btnKategoriSeç_Click(object sender, EventArgs e)
        {
            Kategoriler kategoriler = new Kategoriler();
            if (kategoriler.ShowDialog() == DialogResult.OK)
            {
                textKategoriID.Text = kategoriler.Kategori.ID.ToString();
            }
        }

        private void KitapForm_Load(object sender, EventArgs e)
        {
            textID.Text = Kitap.ID.ToString();
            if (Güncelleme)
            {
                textAd.Text = Kitap.AD;
                textYazarID.Text = Kitap.yazarID.ToString();
                textKategoriID.Text = Kitap.kategoriID.ToString();
                dateTimePicker1.Value = Kitap.YayinYili;
                numAdet.Value = (decimal)Kitap.Adet;
            }
        }
    }
}