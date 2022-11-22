using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTEL
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelcalisan.Visible = false;
            //panelmusteri.Visible = false;
            panelyonetici.Visible = false;
        }

        private void cmbkullanicitur_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("fghj");
            //if (cmbkullanicitur.SelectedIndex == 0)
            //{
            //    panelyonetici.Visible = true;
            //    //panelmusteri.Visible = false;
            //    panelcalisan.Visible = false;
            //}
            //else if (cmbkullanicitur.SelectedIndex == 1)
            //{
            //    panelcalisan.Visible = true;
            //    //panelmusteri.Visible = false;
            //    panelyonetici.Visible = false;
            //}
            
        }

        private void panelyonetici_Paint(object sender, PaintEventArgs e)
        {

        }

       

       

        private void btncalisangiris_Click(object sender, EventArgs e)
        {
            CalisanGiris grs = new CalisanGiris();
            grs.OgrGirisYap(TXTTC.Text,txtcalisansifre.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtyoneticisifre.Text == "123")
            {
                YoneticiAnaForm ana = new YoneticiAnaForm();
                ana.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Şifreniz yanlış!");
        }

        private void cmbtur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbtur.SelectedIndex == 0)
            {
                panelyonetici.Visible = true;
                //panelmusteri.Visible = false;
                panelcalisan.Visible = false;
            }
            else if (cmbtur.SelectedIndex == 1)
            {
                panelcalisan.Visible = true;
                //panelmusteri.Visible = false;
                panelyonetici.Visible = false;
            }
        }
    }
}
