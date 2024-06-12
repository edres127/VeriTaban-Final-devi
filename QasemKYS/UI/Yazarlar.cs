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
    public partial class Yazarlar : Form
    {
        public Yazarlar()
        {
            InitializeComponent();
        }

        private void btnYazarEkle_Click(object sender, EventArgs e)
        {
            YazarForm yazarForm = new YazarForm()
            {
                Text = "Yazar Ekle",
                Yazar = new Yazar() { ID = Guid.NewGuid() },
            };

            tekrar:
            var sonuc = yazarForm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.YazarEkle(yazarForm.Yazar);
                if (b)
                {
                    DataSet ds = BLogic.YazarGetir("");
                    if (ds != null)
                        dataGridViewYazarlar.DataSource = ds.Tables[0];
                }
                else
                    goto tekrar;
            }

        }

        private void btnYazarduzenlı_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewYazarlar.SelectedRows[0];

            YazarForm yazarForm = new YazarForm()
            {
                Text = "Yazar Güncelle",
                Güncelleme = true,
                Yazar = new Yazar()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    AD = row.Cells[1].Value.ToString(),
                    Soyad = row.Cells[2].Value.ToString(),
                },
            };

            var sonuc = yazarForm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.YazarGuncelle(yazarForm.Yazar);

                if (b)
                {
                    row.Cells[1].Value = yazarForm.Yazar.AD;
                    row.Cells[2].Value = yazarForm.Yazar.Soyad;
                }
            }
        }

        private void btnYazarsıl_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewYazarlar.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.YazarSil(ID);

                if (b)
                {
                    DataSet ds = BLogic.YazarGetir("");
                    if (ds != null)
                        dataGridViewYazarlar.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnYazarBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.YazarGetir(toolStripTextBox1.Text);

            if (ds != null)
                dataGridViewYazarlar.DataSource = ds.Tables[0];
        }

        private void Yazarlar_Load(object sender, EventArgs e)
        {
            DataSet ds = BLogic.YazarGetir("");
            if (ds != null)
                dataGridViewYazarlar.DataSource = ds.Tables[0];
        }
        public Yazar Yazar { get; set; }
        private void btnTamam_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewYazarlar.SelectedRows[0];


            Yazar = new Yazar()
            {
                ID = Guid.Parse(row.Cells[0].Value.ToString()),
                AD = row.Cells[1].Value.ToString(),
                Soyad = row.Cells[2].Value.ToString(),
            };
                DialogResult = DialogResult.OK;
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
