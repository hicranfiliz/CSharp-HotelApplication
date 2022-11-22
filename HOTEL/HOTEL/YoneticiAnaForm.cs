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
    public partial class YoneticiAnaForm : Form
    {
        public int gecicifiyat2;
        public YoneticiAnaForm()
        {
            InitializeComponent();
        }

        private void btncalisanekle_Click(object sender, EventArgs e)
        {
            CalisanEkle ekle = new CalisanEkle();
            ekle.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
        Database db = new Database();
        private void button2_Click(object sender, EventArgs e)
        {
            
            db.baglanti.Open();
            SqlCommand guncelle = new SqlCommand("update tbloda set odafiyat=@fiyat", db.baglanti);
            guncelle.Parameters.AddWithValue("@fiyat", txtfiyat.Text);
            guncelle.ExecuteNonQuery();
            db.baglanti.Close();

        }

        private void YoneticiAnaForm_Load(object sender, EventArgs e)
        {
            
            Odeme od = new Odeme();
            txtfiyat.Text = gecicifiyat2.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BEKLENENGELIR glr = new BEKLENENGELIR();
            glr.Show();
            this.Hide();
        }
    }
}
