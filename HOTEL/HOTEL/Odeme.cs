using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HOTEL
{
    public partial class Odeme : Form
    {
        public string yazi;
        public int fiyat;
        public string mtc;
        public string adi;
        public string tc;
        public string telefonno;
        public string adres;
        public DateTime giristarihi;
        public DateTime cikistarihi;
        public int gun;
        public string reztipi;
        public int oda;
        public int gecicifiyat;

        public Odeme()
        {
            InitializeComponent();
        }

        private void btnrezervasyonyap_Click(object sender, EventArgs e)
        {
            int sifir = 0;
            Database db = new Database();
            db.baglanti.Open();
            SqlCommand ciguli = new SqlCommand("update tbloda set MTC=@tc,bosmu=@s where odaid=@odano", db.baglanti);
            ciguli.Parameters.AddWithValue("@tc",mtc);
            ciguli.Parameters.AddWithValue("@s", sifir);
            ciguli.Parameters.AddWithValue("@odano", oda);
            MusteriKayit kyt = new MusteriKayit();
            kyt.MusteriKayitAl(adi, mtc, telefonno, adres, giristarihi, cikistarihi, gun, reztipi, oda);
            ciguli.ExecuteNonQuery();
            db.baglanti.Close();

            CalisanAnaForm rez = new CalisanAnaForm();
            rez.Show();
            this.Close();


        }

        private void Odeme_Load(object sender, EventArgs e)
        {
            labelrzv.Text = yazi;
            MessageBox.Show(yazi);
            Database db = new Database();
            db.baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from tbloda where bosmu='1'", db.baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int odano = Convert.ToInt32(dt.Compute("min([odaid])",String.Empty));
            lblodano.Text = odano.ToString();
            oda = odano;
            cmd.ExecuteNonQuery();
            db.baglanti.Close();
        }

        private void labelrzv_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalisanAnaForm frm = new CalisanAnaForm();
            frm.Show();
            this.Hide();
        }
    }
}
