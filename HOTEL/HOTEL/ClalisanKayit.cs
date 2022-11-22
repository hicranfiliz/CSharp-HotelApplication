using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTEL
{
    public class ClalisanKayit
    {
        public void CalisanKayitAl(string TC, string Sifre, string ADsoyad)
        {
            Database db = new Database();

            db.baglanti.Open();
            //verileri database e insert etmek için:
            SqlCommand kayitAl = new SqlCommand("insert into Calisan (CTC,CSifre,CAd) values(@p1,@p2,@p3)", db.baglanti);
            kayitAl.Parameters.AddWithValue("@p1", TC);
            kayitAl.Parameters.AddWithValue("@p2", Sifre);
            kayitAl.Parameters.AddWithValue("@p3", ADsoyad);
            kayitAl.ExecuteNonQuery();
            MessageBox.Show("Müşteri kaydınız başarıyla yapılmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
