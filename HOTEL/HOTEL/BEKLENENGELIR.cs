﻿using System;
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
    public partial class BEKLENENGELIR : Form
    {
        public BEKLENENGELIR()
        {
            InitializeComponent();
        }
        Database db = new Database();
        private void BEKLENENGELIR_Load(object sender, EventArgs e)
        {
            db.baglanti.Open();
            string Query = "exec ODAGELIR";
            SqlDataAdapter sda = new SqlDataAdapter(Query, db.baglanti);
            SqlCommandBuilder buildeer = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            db.baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YoneticiAnaForm frm = new YoneticiAnaForm();
            frm.Show();
            this.Hide();
        }
    }
}
