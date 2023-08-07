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
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet.Bolumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);

        }

        private void PcrBolumEkle_Click(object sender, EventArgs e)
        {
            try
            {
               
                SqlCommand komut1 = new SqlCommand("insert into Bolumler (BolumAd) values (@p1)", bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1", TxtBolumAd.Text);
                komut1.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Bölüm Başarıyla Eklendi.");
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);
            }
            catch (Exception)
            {

                MessageBox.Show("Bölüm Eklenirken Hata Oluştu. Lütfen Tekrar Deneyiniz...");
            }
            

        }

        private void PcrBolumSil_Click(object sender, EventArgs e)
        {
            try
            {
              
                SqlCommand komut2 = new SqlCommand("delete from Bolumler where Bolumid=@p1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", TxtBolumId.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Bölüm Başarıyla Kaldırıldı.");
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);
            }
            catch (Exception)
            {

                MessageBox.Show("Bölüm Kaldırılırken Hata Oluştu. Lütfen Tekrar Deneyiniz...");
            }

        }

        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, bolumad;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bolumad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            TxtBolumId.Text = id;
            TxtBolumAd.Text = bolumad;
            


        }

        private void PcrBolumDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komut3 = new SqlCommand("update Bolumler Set Bolumad= @p1 where Bolumid=@p2", bgl.baglanti());
                komut3.Parameters.AddWithValue("@p2", TxtBolumId.Text);
                komut3.Parameters.AddWithValue("@p1", TxtBolumAd.Text);
                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Bölüm İsmi Başarıyla Güncellendi...");
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);
            }
            catch (Exception)
            {

                MessageBox.Show("Bölüm İsmi Güncellenirken Hata Oluştu");
            }


        }
    }
}
