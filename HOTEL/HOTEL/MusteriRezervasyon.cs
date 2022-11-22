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
    public partial class MusteriRezervasyon : Form
    {
        public MusteriRezervasyon()
        {
            InitializeComponent();
        }

        private void MusteriRezervasyon_Load(object sender, EventArgs e)
        {
            paneleposta.Visible = false;
            panel.Visible = false;
        }

        private void cmbreztipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbreztipi.SelectedIndex==1)
            {
                paneleposta.Visible = true;
                panel.Visible = false;
            }
            else if (cmbreztipi.SelectedIndex==2)
            {
                panel.Visible = true;
                paneleposta.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalisanAnaForm frm = new CalisanAnaForm();
            frm.Show();
            this.Hide();
                 
        }
    }
}
