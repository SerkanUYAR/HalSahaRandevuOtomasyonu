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

namespace HalıSahaOtomasyonu
{
    public partial class Frm_Giris : Form
    {
        public Frm_Giris()
        {
            InitializeComponent();
        }
        SqlBaglanti Bgl = new SqlBaglanti();

        void KullanıcıAd()
        {
            SqlCommand kullanıcıAd = new SqlCommand("select distinct pozisyon from tbl_personel ", Bgl.baglanti());
            SqlDataReader dataReader = kullanıcıAd.ExecuteReader();
            while (dataReader.Read())
            {
                CmbKullanıcıAd.Items.Add(dataReader[0].ToString());
            }
        }
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand Giris = new SqlCommand("select * from tbl_personel where pozisyon=@p1 and sifre=@p2 ", Bgl.baglanti());
            Giris.Parameters.AddWithValue("@p1",CmbKullanıcıAd.Text);
            Giris.Parameters.AddWithValue("@p2",MskSifre.Text);
            SqlDataReader dataReader1 = Giris.ExecuteReader();
            if (dataReader1.Read())
            {
                Frm_Randevu FrmRandevu = new Frm_Randevu();
                FrmRandevu.Kullanıcı = CmbKullanıcıAd.Text;
                FrmRandevu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya Şifre Hatalı...","HATA");
            }

        }

        private void Frm_Giris_Load(object sender, EventArgs e)
        {
            KullanıcıAd();
        }
    }
}
