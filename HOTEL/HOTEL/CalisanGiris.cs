using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HOTEL
{

    public class CalisanGiris
    {
        Database db = new Database();
        public void OgrGirisYap(string KullaniciAdi, string KullaniciSifre)
        {

            if (db.baglanti.State == System.Data.ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand login = new SqlCommand("select CTC,CSifre from Calisan where CTC=@p1 and CSifre=@p2", db.baglanti);
                login.Parameters.AddWithValue("@p1", KullaniciAdi);
                login.Parameters.AddWithValue("@p2", KullaniciSifre);
                SqlDataReader read = login.ExecuteReader();
                if (read.Read())
                {
                    CalisanAnaForm rez = new CalisanAnaForm();
                    rez.Show();
                }
                else
                {
                    MessageBox.Show("Kullanici adi veya şifre yanlış!");
                }


            }
            catch { }
            finally
            {
                db.baglanti.Close();
            }
        }
    }
}
