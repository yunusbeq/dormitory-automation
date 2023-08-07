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
    public partial class FrmOdemeler : Form
    {
        public FrmOdemeler()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet1.Borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borclarTableAdapter.Fill(this.yurtOtomasyonuDataSet1.Borclar);

        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, soyad, kalan;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            TxtOgrAd.Text = ad;
            TxtOgrSoyad.Text = soyad;
            TxtOgrId.Text = id;
            TxtBorc.Text = kalan;



        }

        private void BtnOdemeAl_Click(object sender, EventArgs e)
        {
            // Ödenen Tutarı Kalan Tutardan Düşme Kodları
            int odenen, kalan, yeniborc;
            odenen = Convert.ToInt16(TxtOdenen.Text);
            kalan = Convert.ToInt16(TxtBorc.Text);
            yeniborc = kalan - odenen;
            TxtBorc.Text = yeniborc.ToString();

            // Yeni Tutarı Veritabanına Kaydetme Kodları
            SqlCommand komut = new SqlCommand("update Borclar set ogrkalanborc = @p1 where Ogrid = @p2 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", TxtOgrId.Text);
            komut.Parameters.AddWithValue("@p1", TxtBorc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Aidat başarıyla tahsil edildi.");
            this.borclarTableAdapter.Fill(this.yurtOtomasyonuDataSet1.Borclar);

            // Kasa Tablosuna Ekleme Yapma Kodları
            SqlCommand komut3 = new SqlCommand("insert into Kasa(OdemeAy, OdemeMiktar) values (@k1, @k2)", bgl.baglanti());
            komut3.Parameters.AddWithValue("@k1", TxtOdenenAy.Text);
            komut3.Parameters.AddWithValue("@k2", TxtOdenen.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();





        }

        private void label8_Click(object sender, EventArgs e)
        {
            SqlCommand komut4 = new SqlCommand("Select Sum(OgrKalanBorc) from Borclar", bgl.baglanti());
            SqlDataReader oku = komut4.ExecuteReader();
            while (oku.Read())
            {

                label8.Text = oku[0].ToString() + "  ₺";
            }

            bgl.baglanti().Close();

        }
    }
}
