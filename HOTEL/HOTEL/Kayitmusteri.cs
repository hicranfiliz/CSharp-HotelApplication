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
    public partial class Kayitmusteri : Form
    {
        public Kayitmusteri()
        {
            InitializeComponent();
        }

        public static string KullaniciAd = "";

        private void btnmusterikayit_Click(object sender, EventArgs e)
        {
            //MusteriKayit kyt = new MusteriKayit();
            //kyt.MusteriKayitAl(txtadı.Text, txtkullaniciadi.Text, txtsifre.Text, txttelefon.Text, txtadres.Text);
            //KullaniciAd = txtkullaniciadi.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbreztipi.SelectedIndex==1)
            //{
            //    paneleposta.Visible = true;
            //    panel1.Visible = false;
            //}
            //else if (cmbreztipi.SelectedIndex==2)
            //{
            //    panel1.Visible = true;
            //    paneleposta.Visible = false;
            //}
        }

        private void Kayitmusteri_Load(object sender, EventArgs e)
        {
            //paneleposta.Visible = false;
            //panel1.Visible = false;
        }

        private void btnrezervasyonyap_Click(object sender, EventArgs e)
        {
            Odeme od = new Odeme();
            int yil = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
            int gun = Convert.ToInt32(DateTime.Now.ToString("dd"));
            int ay = Convert.ToInt32(DateTime.Now.ToString("MM"));

            int yilsec = Convert.ToInt32(pickergiris.Value.ToString("yyy"));
            int gunsec = Convert.ToInt32(pickergiris.Value.ToString("dd"));
            int aysec = Convert.ToInt32(pickergiris.Value.ToString("MM"));

            int yilcikis = Convert.ToInt32(pickercikis.Value.ToString("yyy"));
            int guncikis = Convert.ToInt32(pickercikis.Value.ToString("dd"));
            int aycikis = Convert.ToInt32(pickercikis.Value.ToString("MM"));

            int degisken1 = (yil - 1) * 365 + (ay - 1) * 30 + gun; 

            int degisken2 = (yilsec - 1) * 365 + (aysec - 1) * 30 + gunsec;
            
            int degisken3 = (yilcikis - 1) * 365 + (aycikis - 1) * 30 + guncikis;

            int yilfarki = degisken2 - degisken1;

            if (yilfarki >= 365)
            {
                MessageBox.Show("Lütfen maksimum 90 gün sonrasını seçiniz.");
            }
            else
            {
                if (yilfarki >= 90)
                {
                    od.yazi = "Ön ödemeli rezervaszon";
                    
                }
                else if (yilfarki >= 60)
                {
                    od.yazi = "60 gün önceden rezervasyon";
                    
                }
                else
                {
                    od.yazi = "Standart rezervasyon";
                    
                }
                od.mtc = od.tc = txttc.Text;
                od.adi = txtadı.Text;
                od.telefonno = txttelefon.Text;
                od.adres = txtadres.Text;
                od.giristarihi = pickergiris.Value;
                od.cikistarihi = pickercikis.Value;
                od.gun = Convert.ToInt32(txtgunsayisi.Text);
                od.reztipi = od.yazi;
                od.Show();

            }
            
        }

        private void pickercikis_ChangeUICues(object sender, UICuesEventArgs e)
        {
            
        }

        private void pickercikis_EnabledChanged(object sender, EventArgs e)
        {
            
        }

        private void pickercikis_ValueChanged(object sender, EventArgs e)
        {
            int yilsec = Convert.ToInt32(pickergiris.Value.ToString("yyy"));
            int gunsec = Convert.ToInt32(pickergiris.Value.ToString("dd"));
            int aysec = Convert.ToInt32(pickergiris.Value.ToString("MM"));

            int yilcikis = Convert.ToInt32(pickercikis.Value.ToString("yyy"));
            int guncikis = Convert.ToInt32(pickercikis.Value.ToString("dd"));
            int aycikis = Convert.ToInt32(pickercikis.Value.ToString("MM"));

            int degisken2 = (yilsec - 1) * 365 + (aysec - 1) * 30 + gunsec;

            int degisken3 = (yilcikis - 1) * 365 + (aycikis - 1) * 30 + guncikis;

            txtgunsayisi.Text = (degisken3 - degisken2).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalisanAnaForm frm = new CalisanAnaForm();
            frm.Show();
            this.Hide();
        }
    }
}
