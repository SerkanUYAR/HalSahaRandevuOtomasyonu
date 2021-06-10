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
    public partial class Frm_Admin : Form
    {
        public Frm_Admin()
        {
            InitializeComponent();
        }

        SqlBaglanti Bgl = new SqlBaglanti();

        void PozisyonListesi()
        {
            SqlCommand Liste = new SqlCommand("select distinct(pozisyon) from tbl_personel", Bgl.baglanti());
            SqlDataReader  dr = Liste.ExecuteReader();
            while (dr.Read())
            {
                CmbPozisyon.Items.Add(dr[0].ToString());
            }
        }

        void PersoneListesi()
        {
            SqlCommand komut = new SqlCommand("select * from tbl_personel", Bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

       
        private void Frm_Admin_Load(object sender, EventArgs e)
        {
            PersoneListesi();
            PozisyonListesi();
        }
        
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (TxtAdı.Text !="" && TxtSoyad.Text != "" && MskTel.Text != "" && CmbPozisyon.Text != "" && DtpTarih.Text != "" && MskMaas.Text != "" && MskSifre.Text != "" )
            {
                SqlCommand Kaydet = new SqlCommand(" insert into tbl_personel (Adı,Soyad,pozisyon,sifre,Baslangıc,Maaş,Telefon) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", Bgl.baglanti());
                Kaydet.Parameters.AddWithValue("@p1", TxtAdı.Text);
                Kaydet.Parameters.AddWithValue("@p2", TxtSoyad.Text);
                Kaydet.Parameters.AddWithValue("@p3", CmbPozisyon.Text);
                Kaydet.Parameters.AddWithValue("@p4", MskSifre.Text);
                Kaydet.Parameters.AddWithValue("@p5", DtpTarih.Text);
                Kaydet.Parameters.AddWithValue("@p6", MskMaas.Text);
                Kaydet.Parameters.AddWithValue("@p7", MskTel.Text);
                try
                {
                    Kaydet.ExecuteNonQuery();
                    MessageBox.Show("Personel kayıd başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    PersoneListesi();
                    PozisyonListesi();

                }
                catch (Exception HATA)
                {
                    MessageBox.Show("Personel kaydı başarısız Hata:", HATA.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Boş alan bırakmayınız!!!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            if (TxtAdı.Text != "" && TxtSoyad.Text != "" && MskTel.Text != "" && CmbPozisyon.Text != "" && DtpTarih.Text != "" && MskMaas.Text != "" && MskSifre.Text != "" &&  MskTel.Text !="")
            {
                SqlCommand Güncelle = new SqlCommand("update tbl_personel set Adı='"+TxtAdı.Text+"',Soyad='"+TxtSoyad.Text+ "',pozisyon='"+CmbPozisyon.Text+"',sifre='"+MskSifre.Text+"',Baslangıc='"+DtpTarih.Text+"',Maaş='"+MskMaas.Text + "' Telefon='" + MskTel.Text+"'", Bgl.baglanti());
                try
                {
                    Güncelle.ExecuteNonQuery();
                    MessageBox.Show("Personel bilgisi güncellendi","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    PersoneListesi();

                }
                catch (Exception HATA)
                {

                    MessageBox.Show("Personel bilgisi güncellenemedi"+"HATA"+HATA.Message+MessageBoxButtons.OK+MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Boş alan bırakmayınız!!!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dıalogSıl = new DialogResult();
            dıalogSıl = MessageBox.Show(TxtAdı.Text + " " + TxtSoyad.Text + " Personel Kaydı silinecek eminmisiniz?","UYARI",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
            if (dıalogSıl == DialogResult.OK)
            {
                try
                {
                    SqlCommand Sıl = new SqlCommand("delete from tbl_personel where ID='" + P_ıd + "'", Bgl.baglanti());
                    Sıl.ExecuteNonQuery();
                    MessageBox.Show(TxtAdı.Text + " " + TxtSoyad.Text + " Adlı personel kaydı silindi", "DURUM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    PersoneListesi();
                }
                catch (Exception HATA)
                {
                    MessageBox.Show("Personel kaydı silinemedi" + HATA.Message + MessageBoxButtons.OK + MessageBoxIcon.Error);
                }
            }
        }

        string P_ıd;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int tası = dataGridView1.SelectedCells[0].RowIndex;
            P_ıd = dataGridView1.Rows[tası].Cells[0].Value.ToString();
            TxtAdı.Text = dataGridView1.Rows[tası].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[tası].Cells[2].Value.ToString();
            CmbPozisyon.Text = dataGridView1.Rows[tası].Cells[3].Value.ToString();
            MskSifre.Text = dataGridView1.Rows[tası].Cells[4].Value.ToString();
            DtpTarih.Text = dataGridView1.Rows[tası].Cells[5].Value.ToString();
            MskMaas.Text = dataGridView1.Rows[tası].Cells[6].Value.ToString();
            MskTel.Text = dataGridView1.Rows[tası].Cells[7].Value.ToString();
        }

        private void rANDEUİŞLEMLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Randevu_Islemleri frm = new Frm_Randevu_Islemleri();
            frm.Show();
        }

        private void iToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Ist frm = new Frm_Ist();
            frm.Show();
        }

        
    }
}
