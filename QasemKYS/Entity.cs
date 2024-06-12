using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QasemKYS
{
    public class Yazar
    {
        public Guid ID { get; set; }
        public string AD { get; set; }
        public string Soyad { get; set; }

        public override string ToString()
        {
            return $"{AD} {Soyad}";
        }
    }

    public class Kategori
    {
        public Guid ID { get; set; }
        public string AD { get; set; }

        public override string ToString()
        {
            return $"{AD} ";
        }

    }
    public class Kitap
    {
        public Guid ID { get; set; }
        public string AD { get; set; }
        public Guid yazarID { get; set;}
        public Guid kategoriID { get; set; }
        public DateTime YayinYili { get; set; }
        public int Adet { get; set; }


    }
    public class Uyu
    {
        public Guid ID { get; set; }
        public string AD { get; set; }
        public string Soyad { get; set; }
        public string Adres  { get; set; }
        public string Telefon  { get; set; }


    }
    public class Personeli
    {
        public Guid ID { get; set; }
        public string AD { get; set; }
        public string Soyad { get; set; }
        public string Kullanici_adi { get; set; }
        public string Sifre { get; set; }

        internal DialogResult ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
    public class Oduns_islem
    {
        public Guid ID { get; set; }
        public Guid kitapID { get; set; }
        public Guid uyuID { get; set; }
        public Guid personeliID { get; set; }
        public DateTime  Virilis_tarihi { get; set; }
        public DateTime Son_tarihi { get; set; }
        public DateTime Iade_tarihi { get; set; }
    }
}
