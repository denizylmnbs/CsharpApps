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

namespace PersonelKayit
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=Deniz;Initial Catalog=PersonelVeriTabani;Integrated Security=True;Encrypt=False");

        FormIstatistik frmIstatistik = new FormIstatistik();

        FrmGrafikler frmGrafikler = new FrmGrafikler();

        void temizle()
        {
            txtId.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            cmbSehir.Text = "";
            mskMaas.Text = "";
            txtMeslek.Text = "";
            rdoBekar.Checked = false;
            rdoEvli.Checked = false;
            txtAd.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (PerAd, PerSoyad, PerSehir, PerMaas, PerMeslek, PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbSehir.Text);
            komut.Parameters.AddWithValue("@p4", mskMaas.Text);
            komut.Parameters.AddWithValue("@p5", txtMeslek.Text);
            komut.Parameters.AddWithValue("@p6", lblEvliBekar.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Eklendi");
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);

        }

        private void rdoEvli_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoEvli.Checked == true)
            {
                lblEvliBekar.Text = "True";
            }
        }

        private void rdoBekar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBekar.Checked == true)
            {
                lblEvliBekar.Text = "False";
            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            lblEvliBekar.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();


        }

        private void lblEvliBekar_TextChanged(object sender, EventArgs e)
        {
            if (lblEvliBekar.Text == "True")
            {
                rdoEvli.Checked = true;
            }
            else if (lblEvliBekar.Text == "False")
            {
                rdoBekar.Checked = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Personel where Perid=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", txtId.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi");
            baglanti.Close();
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutGuncelle = new SqlCommand("Update Tbl_Personel set PerAd=@a1, PerSoyad=@a2, PerSehir=@a3, PerMaas=@a4, PerMeslek=@a5, PerDurum=@a6 WHERE Perid=@a7", baglanti);
            komutGuncelle.Parameters.AddWithValue("@a1", txtAd.Text);
            komutGuncelle.Parameters.AddWithValue("@a2", txtSoyad.Text);
            komutGuncelle.Parameters.AddWithValue("@a3", cmbSehir.Text);
            komutGuncelle.Parameters.AddWithValue("@a4", mskMaas.Text);
            komutGuncelle.Parameters.AddWithValue("@a5", txtMeslek.Text);
            komutGuncelle.Parameters.AddWithValue("@a6", lblEvliBekar.Text);
            komutGuncelle.Parameters.AddWithValue("@a7", txtId.Text);
            komutGuncelle.ExecuteNonQuery();
            MessageBox.Show("Personel Bilgileri Güncellendi");
            baglanti.Close();
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);

        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            frmIstatistik.Show();
        }

        private void btnGrafikler_Click(object sender, EventArgs e)
        {
            frmGrafikler.Show();
        }
    }
}
