﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelKayit
{
    public partial class FormIstatistik : Form
    {
        public FormIstatistik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=Deniz;Initial Catalog=PersonelVeriTabani;Integrated Security=True;Encrypt=False");

        private void FormIstatistik_Load(object sender, EventArgs e)
        {
            // Toplam Personel Sayısı
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select count(*) From Tbl_Personel", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblToplamPersonel.Text = dr1[0].ToString();
            }
            baglanti.Close();

            // Evli Personel Sayısı
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select Count(*) From Tbl_Personel WHERE PerDurum =1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblEvliPersonel.Text = dr2[0].ToString();
            }
            baglanti.Close();

            // Bekar Personel Sayısı
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select Count(*) From Tbl_Personel WHERE PerDurum =0", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblBekarPersonel.Text = dr3[0].ToString();
            }
            baglanti.Close();

            // Şehir Sayısı

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("SELECT Count(distinct(PerSehir)) FROM Tbl_Personel", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();

            while (dr4.Read())
            {
                lblSehir.Text = dr4[0].ToString();

            }

            baglanti.Close();

            //Toplam Maaş

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("SELECT Sum(PerMaas) FROM Tbl_Personel", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();

            while (dr5.Read())
            {
                lblToplamMaas.Text = dr5[0].ToString();

            }

            baglanti.Close();

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("SELECT Avg(PerMaas) FROM Tbl_Personel", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();

            while (dr6.Read())
            {
                lblOrtalamaMaas.Text = dr6[0].ToString();

            }

            baglanti.Close();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
