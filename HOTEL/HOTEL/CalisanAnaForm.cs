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
    public partial class CalisanAnaForm : Form
    {
        public CalisanAnaForm()
        {
            InitializeComponent();
        }
        Database db = new Database();

        private void button1_Click(object sender, EventArgs e)
        {
            Kayitmusteri kyt = new Kayitmusteri();
            kyt.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            SqlCommand komut = new SqlCommand("select * from tbloda ", db.baglanti);
            komut.ExecuteNonQuery();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FaturaRAPOR rp = new FaturaRAPOR();
            rp.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            GUNLUKDOLULUK dl = new GUNLUKDOLULUK();
            dl.Show();
            this.Hide();
        }

        private void CalisanAnaForm_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Gunlukgelen gl = new Gunlukgelen();
            gl.Show();
            this.Hide();
        }
    }
}
