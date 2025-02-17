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

namespace PharmacyProject
{
    public partial class frm9 : Form
    {
        public frm9()
        {
            InitializeComponent();
        }

        private void frm9_Load(object sender, EventArgs e)
        {
            UrunListele();   
        }

        private string baglantiCumlesi = @"Data Source=DESKTOP-CEI400U\SQLEXPRESS;Initial Catalog=eczane;Integrated Security=True";
        public void UrunListele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Select * From URUN";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvUrunler.DataSource = dt;
            baglanti.Close();
        }
    }
}
