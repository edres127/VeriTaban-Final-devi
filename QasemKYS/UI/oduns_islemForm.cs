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
    public partial class oduns_islemForm : Form
    {
        public oduns_islemForm()
        {
            InitializeComponent();
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public Oduns_islem oduns_Islem { get; set; }
        public bool Güncelleme { get; set; } = false;

        private void btnTamam_Click(object sender, EventArgs e)
        {
            oduns_Islem.kitapID = Guid.Parse(textKitapID.Text);
            oduns_Islem.uyuID = Guid.Parse(textUyuID.Text);
            oduns_Islem.personeliID = Guid.Parse(textPersoneliID.Text);
            oduns_Islem.Virilis_tarihi = dateTimeIade_tarihi.Value;
            oduns_Islem.Son_tarihi = dateTimeSon_tarihi.Value;
            oduns_Islem.Iade_tarihi = dateTimeIade_tarihi.Value;


            DialogResult = DialogResult.OK;
        }


        private void oduns_islemForm_Load(object sender, EventArgs e)
        {
            textID.Text = oduns_Islem.ID.ToString();
            if (Güncelleme)
            {
                textKitapID.Text = oduns_Islem.kitapID.ToString();
                textUyuID.Text = oduns_Islem.uyuID.ToString();
                textPersoneliID.Text = oduns_Islem.personeliID.ToString();
                dateTimeIade_tarihi.Value = oduns_Islem.Virilis_tarihi;
                oduns_Islem.Son_tarihi = dateTimeSon_tarihi.Value;
                oduns_Islem.Iade_tarihi = dateTimeIade_tarihi.Value;
            }
        }

        private void btnKitapSec_Click(object sender, EventArgs e)
        {
            Kitaplar kitaplar = new Kitaplar();
            if (kitaplar.ShowDialog() == DialogResult.OK)
            {
                textKitapID.Text = kitaplar.Kitap.ID.ToString();
            }
                
        }

        private void btnPersoneliSec_Click(object sender, EventArgs e)
        {
            Personeliler personeliler = new Personeliler();
            if (personeliler.ShowDialog() == DialogResult.OK)
            {
                textPersoneliID.Text = personeliler.Personeli.ID.ToString();

            }
        }

        private void btnUyuSec_Click(object sender, EventArgs e)
        {
            Uyular uyular = new Uyular();
            if (uyular.ShowDialog() == DialogResult.OK)
            {
                textUyuID.Text = uyular.Uyu.ID.ToString();
            } 
        }
    }
}
