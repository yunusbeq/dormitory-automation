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

namespace YurtOtomasyonu2
{
    public partial class FrmYoneticiDuzenle : Form
    {
        public FrmYoneticiDuzenle()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();  

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet4.Admin' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet4.Admin);

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Admin (YoneticiAd, YoneticiSifre) values (@p1, @p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKullanici.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yönetici Başarıyla Eklendi... ");
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet4.Admin);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string kadi, sifre, id;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            kadi = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtKullanici.Text = kadi;
            TxtSifre.Text = sifre;
            TxtYoneticid.Text = id;


        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("delete from Admin where Yoneticiid = @p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", TxtYoneticid.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yönetici Başarıyla Kaldırıldı...");
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet4.Admin);

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("update Admin set YoneticiAd = @p1, YoneticiSifre= @p2 where Yoneticiid = @p3", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", TxtKullanici.Text);
            komut3.Parameters.AddWithValue("@p2", TxtSifre.Text);
            komut3.Parameters.AddWithValue("@p3", TxtYoneticid.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yönetici Bilgileri Başarıyla Güncellendi...");
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet4.Admin);
        }
    }
}
