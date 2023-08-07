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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-7QPASKI;Initial Catalog=YurtOtomasyonu;Integrated Security=True");
         



        private void Form1_Load(object sender, EventArgs e)
        {
            // Bölümleri Listeleme Kodları
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select BolumAd From Bolumler", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                CmbBolum.Items.Add(oku[0].ToString());
            }
            baglanti.Close();

            // Boş Odaları Listeleme Kodları

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select OdaNo From Odalar where OdaKapasite != OdaAktif", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {

                CmbOdaNo.Items.Add(oku2[0].ToString());
            }
            baglanti.Close();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                //Öğrenci Kaydı Yapma Kodları
                baglanti.Open();
                SqlCommand komutkaydet = new SqlCommand("insert into Ogrenci (OgrAd, OgrSoyad, OgrTC, OgrTelefon, OgrDogum, OgrBolum, OgrMail, OgrOdaNo, OgrVeliAdSoyad, OgrVeliTelefon, OgrVeliAdres) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11)", baglanti);
                komutkaydet.Parameters.AddWithValue("@p1", TxtOgrAd.Text);
                komutkaydet.Parameters.AddWithValue("@p2", TxtOgrSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p3", MskOgrTc.Text);
                komutkaydet.Parameters.AddWithValue("@p4", MskOgrTel.Text);
                komutkaydet.Parameters.AddWithValue("@p5", MskOgrDogum.Text);
                komutkaydet.Parameters.AddWithValue("@p6", CmbBolum.Text);
                komutkaydet.Parameters.AddWithValue("@p7", OgrMail.Text);
                komutkaydet.Parameters.AddWithValue("@p8", CmbOdaNo.Text);
                komutkaydet.Parameters.AddWithValue("@p9", TxtVeliAdSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p10", MskVeliTelNo.Text);
                komutkaydet.Parameters.AddWithValue("@p11", OgrAdres.Text);
                komutkaydet.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Öğrenci Başarıyla Kaydedildi!");


                //Öğrenci Id'yi Labele Çekme Kodları
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select Ogrid from Ogrenci", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {

                    label12.Text= oku[0].ToString();    
                }
                baglanti.Close();







                // Öğrenci Borç Alanı Oluşturma Kodları
                baglanti.Open();
                SqlCommand komutkaydet2 = new SqlCommand("insert into Borclar(Ogrid, OgrAd, OgrSoyad) values(@b1, @b2, @b3)",baglanti);
                komutkaydet2.Parameters.AddWithValue("@b1", label12.Text);
                komutkaydet2.Parameters.AddWithValue("@b2",TxtOgrAd.Text );
                komutkaydet2.Parameters.AddWithValue("@b3",TxtOgrSoyad.Text );
                komutkaydet2.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata! Lütfen Yeniden Deneyiniz.");
                throw;
            }


           

            




        }

        private void CmbBolum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
