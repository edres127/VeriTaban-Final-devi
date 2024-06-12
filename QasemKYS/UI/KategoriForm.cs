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
    public partial class KategoriForm : Form
    {
        public KategoriForm()
        {
            InitializeComponent();
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public Kategori Kategori { get; set; }

        public bool Güncelleme { get; set; } = false;
        private void btnTamam_Click(object sender, EventArgs e)
        {

            if (!ErrorControl(textAd)) return;
           


            Kategori.AD = textAd.Text;
           

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

        

        private void KategoriForm_Load(object sender, EventArgs e)
        {
            textID.Text = Kategori.ID.ToString();
            if (Güncelleme)
            {
                textAd.Text = Kategori.AD;



            }
        }
    }
}
