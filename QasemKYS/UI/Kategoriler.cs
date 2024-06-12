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
    public partial class Kategoriler : Form
    {
        public Kategoriler()
        {
            InitializeComponent();
        }

        private void btnKategorilerEkle_Click(object sender, EventArgs e)
        {
            KategoriForm KategoriForm = new KategoriForm()
            {
                Text = "kategori Ekle",
                Kategori = new Kategori() { ID = Guid.NewGuid() },
            };
            var sonuc = KategoriForm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.KategorilerEkle(KategoriForm.Kategori);
                if (b)
                {
                    DataSet ds = BLogic.KategoriGetir("");
                    if (ds != null)
                        dataGridViewKategoriler.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnKategorilerduzenlı_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewKategoriler.SelectedRows[0];

            KategoriForm KategoriForm = new KategoriForm()
            {
                Text = "Kategori Güncelle",
                Güncelleme = true,
                Kategori = new Kategori()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    AD = row.Cells[1].Value.ToString(),

                },
            };

            var sonuc = KategoriForm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.KategoriGuncelle(KategoriForm.Kategori);

                if (b)
                {
                    row.Cells[1].Value = KategoriForm.Kategori.AD;

                }
            }
        }

        private void btnKategorilersıl_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewKategoriler.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.KategoriSil(ID);

                if (b)
                {
                    DataSet ds = BLogic.KategoriGetir("");
                    if (ds != null)
                        dataGridViewKategoriler.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnKategorilerBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.KategoriGetir(toolStripTextBox1.Text);

            if (ds != null)
                dataGridViewKategoriler.DataSource = ds.Tables[0];
        }

        private void Kategoriler_Load(object sender, EventArgs e)
        {
            DataSet ds = BLogic.KategoriGetir("");
            if (ds != null)
                dataGridViewKategoriler.DataSource = ds.Tables[0];
        }
        public Kategori Kategori { get; set; }
        private void btnTamam_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewKategoriler.SelectedRows[0];


            Kategori = new Kategori()
            {
                ID = Guid.Parse(row.Cells[0].Value.ToString()),
                AD = row.Cells[1].Value.ToString(),
   
            };

            DialogResult = DialogResult.OK;
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
