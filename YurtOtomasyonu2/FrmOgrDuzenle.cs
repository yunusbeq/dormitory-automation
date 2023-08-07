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
    public partial class FrmOgrDuzenle : Form
    {
        public FrmOgrDuzenle()
        {
            InitializeComponent();
        }


        public string id, ad, soyad, tc, telefon, dogum, bolum;

        private void CmbBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void TxtOgrSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("delete From Ogrenci where Ogrid = @d1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@d1", TxtOgrId.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğrenci Kaydı Başarıyla Kaldırıldı...");


            // Oda Kontenjanı Artırma Komutları

            SqlCommand komut4 = new SqlCommand("update Odalar set OdaAktif = OdaAktif - 1 where OdaNo = @a1", bgl.baglanti());
            komut4.Parameters.AddWithValue("@a1", CmbOdaNo.Text);
            komut4.ExecuteNonQuery();
            bgl.baglanti().Close();

            // Borçlar Tablosundan Kayıt Sildirme Kodları

            SqlCommand komut5 = new SqlCommand("delete from Borclar where Ogrid = @sil", bgl.baglanti());
            komut5.Parameters.AddWithValue("@sil",TxtOgrId.Text );
            komut5.ExecuteNonQuery();
            bgl.baglanti().Close();


        }
      





        SqlBaglantim bgl = new SqlBaglantim();
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Ogrenci set OgrAd = @p2, OgrSoyad = @p3, OgrTC = @p4, OgrTelefon = @p5, OgrDogum = @p6, OgrBolum = @p7, OgrMail = @p8, OgrOdaNo = @p9, OgrVeliAdSoyad = @p10, OgrVeliTelefon = @p11, OgrVeliAdres = @p12 where Ogrid = @p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtOgrId.Text);
                komut.Parameters.AddWithValue("@p2", TxtOgrAd.Text);
                komut.Parameters.AddWithValue("@p3", TxtOgrSoyad.Text);
                komut.Parameters.AddWithValue("@p4", MskOgrTc.Text);
                komut.Parameters.AddWithValue("@p5", MskOgrTel.Text);
                komut.Parameters.AddWithValue("@p6", MskOgrDogum.Text);
                komut.Parameters.AddWithValue("@p7", CmbBolum.Text);
                komut.Parameters.AddWithValue("@p8", OgrMail.Text);
                komut.Parameters.AddWithValue("@p9", CmbOdaNo.Text);
                komut.Parameters.AddWithValue("@p10", TxtVeliAdSoyad.Text);
                komut.Parameters.AddWithValue("@p11", MskVeliTelNo.Text);
                komut.Parameters.AddWithValue("@p12", OgrAdres.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme Başarılı...");
                


            }
            catch (Exception)
            {

                MessageBox.Show("Güncelleme Başarısız. Tekrar Deneyiniz.....");
            }

        }

        public string mail, odano, veliadsoyad, velitel, adres;


        private void FrmOgrDuzenle_Load(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("Select BolumAd From Bolumler", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                CmbBolum.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();


            
            SqlCommand komut2 = new SqlCommand("Select OdaNo From Odalar where OdaKapasite != OdaAktif", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {

                CmbOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();


            TxtOgrId.Text = id;
            TxtOgrAd.Text = ad;
            TxtOgrSoyad.Text = soyad;
            MskOgrTc.Text = tc;
            MskOgrTel.Text = telefon;
            MskOgrDogum.Text = dogum;
            CmbBolum.Text = bolum;
            OgrMail.Text = mail;
            CmbOdaNo.Text = odano;
            TxtVeliAdSoyad.Text = veliadsoyad;
            MskVeliTelNo.Text = velitel;
            OgrAdres.Text = adres;


        }
    }
}
