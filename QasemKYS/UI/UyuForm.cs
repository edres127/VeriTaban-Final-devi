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
    public partial class UyuForm : Form
    {
        public UyuForm()
        {
            InitializeComponent();
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public Uyu Uyu { get; set; }
        public bool Güncelleme { get; set; } = false;

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (textAd.Text == "")
            {
                errorProvider1.SetError(textAd, "lutfun yaz");
                textAd.Focus();
                return;

            }

            else
            {
                errorProvider1.SetError(textAd, "");

            }


            if (!ErrorControl(textAd)) return;
            if (!ErrorControl(textSoyad)) return;
            if (!ErrorControl(textTelefon)) return;
            if (!ErrorControl(textAdres)) return;

            Uyu.AD = textAd.Text;
            Uyu.Soyad = textSoyad.Text;
            Uyu.Telefon = textTelefon.Text;
            Uyu.Adres = textAdres.Text;

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
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;

                }
            }

            if (c is MaskedTextBox)
            {
                if (!((MaskedTextBox)c).MaskFull)
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;

                }
            }

            return true;

        }

        private void UyuForm_Load(object sender, EventArgs e)
        {
            textID.Text = Uyu.ID.ToString();
            if (Güncelleme)
            {
                textAd.Text = Uyu.AD;
                textSoyad.Text = Uyu.Soyad;
                textTelefon.Text = Uyu.Telefon;
                textAdres.Text = Uyu.Adres;

            }

        }

        private void btniptal_Click_1(object sender, EventArgs e)
        {

        }
    }
}