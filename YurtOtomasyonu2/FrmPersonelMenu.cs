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
    public partial class FrmPersonelMenu : Form
    {
        public FrmPersonelMenu()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmPersonelMenu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet5.Personeller' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personellerTableAdapter.Fill(this.yurtOtomasyonuDataSet5.Personeller);

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Personeller(PersonelAdSoyad, PersonelDepartman) values (@p1, @p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtPersonelAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtPersonelGorev.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Başarıyla Kaydedildi...");
            this.personellerTableAdapter.Fill(this.yurtOtomasyonuDataSet5.Personeller);

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("delete from Personeller where Personelid = @p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", TxtPersonelId.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Başarıyla Kaldırıldı... ");
            this.personellerTableAdapter.Fill(this.yurtOtomasyonuDataSet5.Personeller);
        }

        int secilen;
        string id, ad, gorev;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            gorev = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            TxtPersonelAd.Text = ad;
            TxtPersonelId.Text = id;
            TxtPersonelGorev.Text = gorev;

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("update Personeller set PersonelAdSoyad = @p1, PersonelDepartman = @p2 where Personelid = @p3", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", TxtPersonelAd.Text);
            komut3.Parameters.AddWithValue("@p2", TxtPersonelGorev.Text);
            komut3.Parameters.AddWithValue("@p3", TxtPersonelId.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Bilgisi Başarıyla Güncellendi... ");
            this.personellerTableAdapter.Fill(this.yurtOtomasyonuDataSet5.Personeller);

        }
    }
}
