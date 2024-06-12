using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QasemKYS.UI;
using QasemKYS.BL;
using QasemKYS.DL;

namespace QasemKYS
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        Uyular UYULAR = new Uyular();
        Yazarlar YAZARLAR = new Yazarlar();
        Kategoriler KATEGORILER = new Kategoriler();
        Kitaplar KITAPLAR = new Kitaplar();
        Personeliler PERSONELILER = new Personeliler();
        Oduns_islemler ODUNS_ISLEMLER = new Oduns_islemler();
      

        private void btnYazarlar_Click(object sender, EventArgs e)
        {
             YAZARLAR.ShowDialog();
        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
             KATEGORILER.ShowDialog();
        }

        private void btnKitaplar_Click(object sender, EventArgs e)
        {
             KITAPLAR.ShowDialog();
        }
        private void btnPersoneliler_Click(object sender, EventArgs e)
        {
             PERSONELILER.ShowDialog();
        }
        private void btnoduns_islemler_Click(object sender, EventArgs e)
        {
            oduns_islemForm oduns_IslemForm = new oduns_islemForm()
            {
                Text = "oduns_islem Yap",
                oduns_Islem = new Oduns_islem()
                {
                    ID = Guid.NewGuid()
                }
            };
        tekrar:
            var sonuc = oduns_IslemForm.ShowDialog();
            if (sonuc == DialogResult.OK )
            {
                bool b = BLogic.Oduns_islemEkle(oduns_IslemForm.oduns_Islem);
                if (b)
                {
                    DataSet ds = BLogic.Oduns_islemDetay();
                    if (ds != null)
                        dataGridViewOduns.DataSource = ds.Tables[0];
                }
                else
                    goto tekrar;
            }
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            DataSet ds = BLogic.Oduns_islemDetay();
            if (ds != null)
                dataGridViewOduns.DataSource = ds.Tables[0];
        }

        private void btnUyular_Click(object sender, EventArgs e)
        {
            UYULAR.ShowDialog();

        }

        private void btnOdunsDuzenlı_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewOduns.SelectedRows[0];

            oduns_islemForm Oduns_islemForm = new oduns_islemForm()
            {
                Text = "Oduns_islem Güncelle",
                Güncelleme = true,
                oduns_Islem = new Oduns_islem()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    kitapID = Guid.Parse(row.Cells[1].Value.ToString()),
                    uyuID = Guid.Parse(row.Cells[2].Value.ToString()),
                    personeliID= Guid.Parse(row.Cells[3].Value.ToString()),
                    Virilis_tarihi =DateTime.Parse(row.Cells[8].Value.ToString()),
                    Son_tarihi = DateTime.Parse(row.Cells[9].Value.ToString()),
                    Iade_tarihi = DateTime.Parse(row.Cells[10].Value.ToString()),

                },
            };

            var sonuc = Oduns_islemForm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.Oduns_islemGuncelle(Oduns_islemForm.oduns_Islem);

                if (b)
                {
                    row.Cells[1].Value = Oduns_islemForm.oduns_Islem.kitapID;
                    row.Cells[2].Value = Oduns_islemForm.oduns_Islem.uyuID;
                    row.Cells[3].Value = Oduns_islemForm.oduns_Islem.personeliID;
                    row.Cells[8].Value = Oduns_islemForm.oduns_Islem.Virilis_tarihi;
                    row.Cells[9].Value = Oduns_islemForm.oduns_Islem.Son_tarihi;
                    row.Cells[10].Value = Oduns_islemForm.oduns_Islem.Iade_tarihi;
                }
            }
        }

        private void btnOdunsSıl_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewOduns.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.Oduns_islemSil(ID);

                if (b)
                {
                    DataSet ds = BLogic.Oduns_islemDetay();
                    if (ds != null)
                        dataGridViewOduns.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnOdunsBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.Oduns_islemGetir(toolStripTextBox1.Text);

            if (ds != null)
                dataGridViewOduns.DataSource = ds.Tables[0];
        }
    }
}
