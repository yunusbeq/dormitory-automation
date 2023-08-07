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
using System.Xml.Linq;

namespace YurtOtomasyonu2
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from admin where yoneticiad = @p1 and yoneticisifre = @p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                FrmAnaForm fr = new FrmAnaForm();
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış. Lütfen Tekrar Deneyiniz...");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();


            }
            bgl.baglanti().Close();

        }

        private void TxtCikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmAdminGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
