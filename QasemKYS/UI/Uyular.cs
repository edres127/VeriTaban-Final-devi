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
    public partial class Uyular : Form
    {
        public Uyular()
        {
            InitializeComponent();
        }

        private void btnUyuEkle_Click(object sender, EventArgs e)
        {
            UyuForm uyuForm = new UyuForm()
            {
                Text = "Uyu Ekle",
                Uyu = new Uyu() { ID = Guid.NewGuid() },
            };
            var sonuc = uyuForm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.UyuEkle(uyuForm.Uyu);
                if (b)
                {
                    DataSet ds = BLogic.UyuGetir("");
                    if (ds != null)
                        dataGridViewUyular.DataSource = ds.Tables[0];
                }
            }

        }

        private void btnUyuduzenlı_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewUyular.SelectedRows[0];

            UyuForm uyuForm = new UyuForm()
            {
                Text = "Uyu Güncelle",
                Güncelleme = true,
                Uyu = new Uyu()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    AD = row.Cells[1].Value.ToString(),
                    Soyad = row.Cells[2].Value.ToString(),
                    Telefon = row.Cells[3].Value.ToString(),
                    Adres = row.Cells[4].Value.ToString(),
                },
            };

            var sonuc = uyuForm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.UyuGuncelle(uyuForm.Uyu);

                if (b)
                {
                    row.Cells[1].Value = uyuForm.Uyu.AD;
                    row.Cells[2].Value = uyuForm.Uyu.Soyad;
                    row.Cells[3].Value = uyuForm.Uyu.Telefon;
                    row.Cells[4].Value = uyuForm.Uyu.Adres;
                }
            }
        }

        private void btnUyusıl_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewUyular.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.UyuSil(ID);

                if (b)
                {
                    DataSet ds = BLogic.UyuGetir("");
                    if (ds != null)
                        dataGridViewUyular.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnUyuBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.UyuGetir(toolStripTextBox1.Text);

            if (ds != null)
                dataGridViewUyular.DataSource = ds.Tables[0];
        }

        private void Uyular_Load(object sender, EventArgs e)
        {
            DataSet ds = BLogic.UyuGetir("");
            if (ds != null)
                dataGridViewUyular.DataSource = ds.Tables[0];
        }
        public Uyu Uyu { get; set; }
        private void btnTamam_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewUyular.SelectedRows[0];


            Uyu = new Uyu()
            {
                ID = Guid.Parse(row.Cells[0].Value.ToString()),
                AD = row.Cells[1].Value.ToString(),
                Soyad = row.Cells[2].Value.ToString(),
                Telefon = row.Cells[3].Value.ToString(),
                Adres = row.Cells[4].Value.ToString(),
            };
            
            DialogResult = DialogResult.OK;
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
