using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QasemKYS.BL;

namespace QasemKYS.UI
{
    public partial class Kitaplar : Form
    {
        public Kitaplar()
        {
            InitializeComponent();
        }

        private void btnKitaplarEkle_Click(object sender, EventArgs e)
        {
            KitapForm kitapForm = new KitapForm()
            {
                Text = "Kitap Ekle",
                Kitap = new Kitap() { ID = Guid.NewGuid() },
            };

        tekrar:
            var sonuc = kitapForm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.KitapEkle(kitapForm.Kitap);
                if (b)
                {
                    DataSet ds = BLogic.KitapGetir("");
                    if (ds != null)
                        dataGridViewKitaplar.DataSource = ds.Tables[0];
                }
                else
                    goto tekrar;
            }
        }

        private void btnKitaplarduzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewKitaplar.SelectedRows[0];

            KitapForm kitapForm = new KitapForm()
            {
                Text = "Kitap Güncelle",
                Güncelleme = true,
                Kitap = new Kitap()
                {
                    ID          = Guid.Parse(row.Cells[0].Value.ToString()),
                    AD          = row.Cells[1].Value.ToString(),
                    yazarID     = Guid.Parse(row.Cells[2].Value.ToString()),
                    kategoriID  = Guid.Parse(row.Cells[3].Value.ToString()),
                    YayinYili   = DateTime.Parse(row.Cells[4].Value.ToString()),
                    Adet        = int.Parse(row.Cells[5].Value.ToString()),
                },
            };

            var sonuc = kitapForm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.KitapGuncelle(kitapForm.Kitap);

                if (b)
                {
                    row.Cells[1].Value = kitapForm.Kitap.AD;
                    row.Cells[4].Value = kitapForm.Kitap.YayinYili;
                    row.Cells[5].Value = kitapForm.Kitap.Adet;
                }
            }
        }

        private void btnKitaplarsil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewKitaplar.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.KitapSil(ID);

                if (b)
                {
                    DataSet ds = BLogic.KitapGetir("");
                    if (ds != null)
                        dataGridViewKitaplar.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnKitaplarBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.KitapGetir(toolStripTextBox2.Text);

            if (ds != null)
                dataGridViewKitaplar.DataSource = ds.Tables[0];
        }

        private void Kitaplar_Load(object sender, EventArgs e)
        {
            DataSet ds = BLogic.KitapGetir("");
            if (ds != null)
                dataGridViewKitaplar.DataSource = ds.Tables[0];
        }

        public Kitap Kitap = new Kitap();

        private void btnTamam_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewKitaplar.SelectedRows[0];
            Kitap = new Kitap()
            {
                ID = Guid.Parse(row.Cells[0].Value.ToString()),
                AD = row.Cells[1].Value.ToString(),
                yazarID = Guid.Parse(row.Cells[2].Value.ToString()),
                kategoriID = Guid.Parse(row.Cells[3].Value.ToString()),
                YayinYili = DateTime.Parse(row.Cells[4].Value.ToString()),
                Adet = int.Parse(row.Cells[5].Value.ToString()),
            };
            DialogResult = DialogResult.OK;
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
