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
    public partial class Frm_Ist : Form
    {
        public Frm_Ist()
        {
            InitializeComponent();
        }
        SqlBaglanti Bgl = new SqlBaglanti();

        private void Frm_Istat_Load(object sender, EventArgs e)
        {
            // Toplam kasa : ++
            SqlCommand Komut1 = new SqlCommand("Select sum(Tutar) from tbl_gelirler ", Bgl.baglanti());
            SqlDataReader dr = Komut1.ExecuteReader();
            while (dr.Read())
            {
               LblTopKasa.Text = dr[0].ToString();
            }

            // Günlük kasa:   ++
            SqlCommand Komut2 = new SqlCommand("select sum(Tutar)from tbl_gelirler  where Tarih='" + dateTimePicker1.Text+"' ", Bgl.baglanti());
            SqlDataReader dr2 = Komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblGunKasa.Text = dr2[0].ToString();
            }
            
            // Personel ortalama Toplam Maaş
            SqlCommand Komut5 = new SqlCommand("select AVG(Maaş) From tbl_personel ", Bgl.baglanti());
            SqlDataReader dr5 = Komut5.ExecuteReader();
            while (dr5.Read())
            {
                LnlOrtalamaMaas.Text = dr5[0].ToString();
            }

            // toplam per sayısı
            SqlCommand Komut6 = new SqlCommand("Select count(*) from tbl_personel", Bgl.baglanti());
            SqlDataReader dr6 = Komut6.ExecuteReader();
            while (dr6.Read())
            {
                LblPerSay.Text = dr6[0].ToString();
            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SqlCommand Komut2 = new SqlCommand("select sum(Tutar)from tbl_gelirler  where Tarih='" + dateTimePicker1.Text + "' ", Bgl.baglanti());
            SqlDataReader dr2 = Komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblGunKasa.Text = dr2[0].ToString();
            }
        }
    }
}
