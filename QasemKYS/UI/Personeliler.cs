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
    public partial class Personeliler : Form
    {
        public Personeliler()
        {
            InitializeComponent();
        }

        private void btnPersonelilerEkle_Click(object sender, EventArgs e)
        {
            PersoneliForm personeliForm = new PersoneliForm()
            {
                Text = "Personeli Ekle",
                Personeli = new Personeli() { ID = Guid.NewGuid() },
            };

        tekrar:
            var sonuc = personeliForm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.PersoneliEkle(personeliForm.Personeli);
                if (b)
                {
                    DataSet ds = BLogic.PersoneliGetir("");
                    if (ds != null)
                        dataGridViewPersoneliler.DataSource = ds.Tables[0];
                }
                else
                    goto tekrar;
            }
        }

        private void btnPersonelilerduzenlı_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewPersoneliler.SelectedRows[0];

            PersoneliForm personeliForm = new PersoneliForm()
            {
                Text = "Personeli Güncelle",
                Güncelleme = true,
                Personeli = new Personeli()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    AD            = row.Cells[1].Value.ToString(),
                    Soyad         = row.Cells[2].Value.ToString(),
                    Kullanici_adi = row.Cells[3].Value.ToString(),
                    Sifre         = row.Cells[4].Value.ToString(),
                },
            };

            var sonuc = personeliForm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.PersoneliGuncelle(personeliForm.Personeli);

                if (b)
                {
                    row.Cells[1].Value = personeliForm.Personeli.AD;
                    row.Cells[2].Value = personeliForm.Personeli.Soyad;
                    row.Cells[3].Value = personeliForm.Personeli.Kullanici_adi;
                    row.Cells[4].Value = personeliForm.Personeli.Sifre;
                }
            }
        }

        private void btnPersonelilersıl_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewPersoneliler.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.PersoneliSil(ID);

                if (b)
                {
                    DataSet ds = BLogic.PersoneliGetir("");
                    if (ds != null)
                        dataGridViewPersoneliler.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnPersonelilerBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.PersoneliGetir(toolStripTextBox1.Text);

            if (ds != null)
                dataGridViewPersoneliler.DataSource = ds.Tables[0];
        }

        private void Personeliler_Load(object sender, EventArgs e)
        {
            DataSet ds = BLogic.PersoneliGetir("");
            if (ds != null)
                dataGridViewPersoneliler.DataSource = ds.Tables[0];
        }

        public Personeli Personeli {  get; set; }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewPersoneliler.SelectedRows[0];

            Personeli = new Personeli()
            {
                ID = Guid.Parse(row.Cells[0].Value.ToString()),
                AD = row.Cells[1].Value.ToString(),
                Soyad = row.Cells[2].Value.ToString(),
                Kullanici_adi = row.Cells[3].Value.ToString(),
                Sifre = row.Cells[4].Value.ToString(),
            };

            DialogResult = DialogResult.OK;
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
