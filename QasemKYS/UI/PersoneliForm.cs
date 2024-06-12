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
    public partial class PersoneliForm : Form
    {
        public PersoneliForm()
        {
            InitializeComponent();
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public Personeli Personeli { get; set; }

        public bool Güncelleme { get; set; } = false;
        private void btnTamam_Click(object sender, EventArgs e)
        {

            if (!ErrorControl(textAd)) return;
            if (!ErrorControl(textSoyad)) return;
            if (!ErrorControl(textKullanici_adi)) return;
            if (!ErrorControl(textSifre)) return;


            Personeli.AD = textAd.Text;
            Personeli.Soyad = textSoyad.Text;
            Personeli.Kullanici_adi = textKullanici_adi.Text;
            Personeli.Sifre = textSifre.Text;

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

        private void PersoneliForm_Load(object sender, EventArgs e)
        {
            textID.Text = Personeli.ID.ToString();
            if (Güncelleme)
            {
                textAd.Text = Personeli.AD;
                textSoyad.Text = Personeli.Soyad;
                textKullanici_adi.Text = Personeli.Kullanici_adi;
                textSifre.Text = Personeli.Sifre;


            }
        }
    }
}
