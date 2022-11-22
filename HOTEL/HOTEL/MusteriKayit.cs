using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HOTEL
{
    public class MusteriKayit
    { 
        public void MusteriKayitAl(string Adi, string tc, string telefonNo, string adres,DateTime GirisTarihi,DateTime CikisTarihi,int Gun,string RezTipi,int Oda)
        {
            Database db = new Database();
           
                db.baglanti.Open();
                //verileri database e insert etmek için:
                SqlCommand kayitAl = new SqlCommand("insert into Tblmusteri  values(@p1,@p2,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", db.baglanti);
                kayitAl.Parameters.AddWithValue("@p1", Adi);
                kayitAl.Parameters.AddWithValue("@p2", tc);
                kayitAl.Parameters.AddWithValue("@p4", telefonNo);
                kayitAl.Parameters.AddWithValue("@p5", adres);
                kayitAl.Parameters.AddWithValue("@p6", GirisTarihi);
                kayitAl.Parameters.AddWithValue("@p7", CikisTarihi);
                kayitAl.Parameters.AddWithValue("@p8", Gun);
                kayitAl.Parameters.AddWithValue("@p9", RezTipi);
                kayitAl.Parameters.AddWithValue("@p10", Oda);
                kayitAl.ExecuteNonQuery();
                MessageBox.Show("Müşteri kaydınız başarıyla yapılmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                
        }
    }
}
