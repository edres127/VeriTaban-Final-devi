using QasemKYS.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QasemKYS.BL
{
    public static class BLogic
    {
        public static bool UyuEkle(Uyu u)
        {
            try
            {
                int res = DataLayer.UyuEkle(u);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oldu: " + ex.Message);
                return false;
            }
        }

        internal static DataSet UyuGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.UyuGetir(filtre);

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return null;
            }
            
        }

        internal static bool UyuGuncelle(Uyu u)
        {
            try
            {
                int res = DataLayer.UyuGuncelle(u);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }

        internal static bool UyuSil(string iD)
        {
            try
            {
                int res = DataLayer.UyuSil(iD);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }



        public static bool YazarEkle(Yazar y)
        {
            try
            {
                int res = DataLayer.YazarEkle(y);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }

        internal static DataSet YazarGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.YazarGetir(filtre);

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return null;
            }

        }

        internal static bool YazarGuncelle(Yazar y)
        {
            try
            {
                int res = DataLayer.YazarGuncelle(y);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }

        internal static bool YazarSil(string iD)
        {
            try
            {
                int res = DataLayer.YazarSil(iD);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }



        internal static bool KategoriGuncelle(Kategori kategori)
        {
            try
            {
                int res = DataLayer.KategoriGuncelle(kategori);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }

        internal static bool KategoriSil(string iD)
        {
            try
            {
                int res = DataLayer.KategoriSil(iD);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }

        internal static DataSet KategoriGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.KategoriGetir(filtre);

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return null;
            }
        }

        internal static bool KategorilerEkle(Kategori kategori)
        {
            try
            {
                int res = DataLayer.KategoriEkle(kategori);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }



        internal static bool KitapEkle(Kitap kitap)
        {
            try
            {
                int res = DataLayer.KitapEkle(kitap);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }

        internal static bool KitapGuncelle(Kitap ki)
        {
            try
            {
                int res = DataLayer.KitapGuncelle(ki);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }

        internal static bool KitapSil(string iD)
        {
            try
            {
                int res = DataLayer.KitapSil(iD);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }

        internal static DataSet KitapGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.KitapGetir(filtre);

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return null;
            }
        }



        internal static bool PersoneliEkle(Personeli p)
        {
            try
            {
                int res = DataLayer.PersoneliEkle(p);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oldu: " + ex.Message);
                return false;
            }
        }

        internal static DataSet PersoneliGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.PersoneliGetir(filtre);

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return null;
            }
        }

        internal static bool PersoneliGuncelle(Personeli p)
        {
            try
            {
                int res = DataLayer.PersoneliGuncelle(p);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }

        internal static bool PersoneliSil(string id)
        {
            try
            {
                int res = DataLayer.PersoneliSil(id);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }

        internal static bool Oduns_islemEkle(Oduns_islem o)
        {
            try
            {
                int res = DataLayer.Oduns_islemEkle(o);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }

        internal static bool Oduns_islemGuncelle(Oduns_islem o)
        {
            try
            {
                int res = DataLayer.Oduns_islemGuncelle(o);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }

        internal static DataSet Oduns_islemGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.Oduns_islemGetir(filtre);

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return null;
            }
        }

        internal static bool Oduns_islemSil(string iD)
        {
            try
            {

                int res = DataLayer.Oduns_islemSil(iD);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }

        internal static DataSet Oduns_islemDetay()
        {
            try
            {
                DataSet ds = DataLayer.Oduns_islemDetay();

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return null;
            }
        }
    }
}
