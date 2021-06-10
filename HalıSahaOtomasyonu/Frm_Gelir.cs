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
    public partial class Frm_Gelir : Form
    {
        public Frm_Gelir()
        {
            InitializeComponent();
        }
        SqlBaglanti Bgl = new SqlBaglanti();
       
        void Temizle()
        {
            TxtTutar.Text = "00TL";
            TxtSu.Text = "0";
            Txtsat3.Text = "0";
            TxtSat2.Text = "0";
            Txtsat1.Text = "0";
            TxtKola.Text = "0";
            Txtkira3.Text = "0";
            Txtkira2.Text = "0";
            Txtkira1.Text = "0";
            Txtcikolata.Text = "0";
            TxtSaha.Text = "0";
        }

        void GelirListe()
        {
            SqlCommand Komut = new SqlCommand("select * from tbl_gelirler where Tarih='" + dateTimePicker1.Text + "'", Bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(Komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        void KayıtlıRandevuLİste()
        { 
            SqlCommand Komut = new SqlCommand("select ıd,RandevuTarıh,RandevuGun,UcretDurum,Ucret,RandevuGun from tbl_randevu_Kayıt where  RandevuTarıh='" + dateTimePicker1.Text+"'", Bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(Komut);
            DataTable tablo0 = new DataTable();
            da.Fill(tablo0);
            dataGridView2.DataSource = tablo0;
            randevuRenk();
        }

        void DurumGuncel()
        {
            if (UcretDurum=="False")
            {
                try
                {
                    SqlCommand DurumGuncel = new SqlCommand("update tbl_randevu_Kayıt set UcretDurum='" + "True" + "' where ıd='" + randevuId + "'", Bgl.baglanti());
                    DurumGuncel.ExecuteNonQuery();

                }
                catch (Exception HATA)
                {
                    MessageBox.Show(" " + "HATA" + HATA.Message + MessageBoxButtons.OK + MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Randevu ucreti daha önce alınmıştır.","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);  
            }
          
        }

        void randevuRenk()
        {
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)  
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle(); 
                if (Convert.ToBoolean(dataGridView2.Rows[i].Cells[3].Value) == false) 
                {
                    renk.BackColor = Color.Red;
                    renk.ForeColor = Color.WhiteSmoke;
                }
                else
                {
                    renk.BackColor = Color.Green;
                    renk.ForeColor = Color.Black;
                }
                dataGridView2.Rows[i].DefaultCellStyle = renk; 
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            double top = 0;
            int su = Convert.ToInt16(TxtSu.Text);
            int kola = Convert.ToInt16(TxtKola.Text);
            int cikolata = Convert.ToInt16(Txtcikolata.Text);
            int kıra1 = Convert.ToInt16(Txtkira1.Text);
            int kıra2 = Convert.ToInt16(Txtkira2.Text);
            int kıra3 = Convert.ToInt16(Txtkira3.Text);
            int sat1 = Convert.ToInt16(Txtsat1.Text);
            int sat2 = Convert.ToInt16(TxtSat2.Text);
            int sat3 = Convert.ToInt16(Txtsat3.Text);
            int saha = Convert.ToInt16(TxtSaha.Text);
            top = su * 2 + kola * 5 + cikolata * 5 + kıra1 * 20 + kıra2 * 20 + kıra3 * 20 + sat1 * 500 + sat2 * 900 + sat3 * 800 + saha * 1;
            TxtTutar.Text = top.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            if (TxtTutar.Text != "" && dateTimePicker1.Text != ""  || TxtSaha.Text!="0")
            {
                SqlCommand Gelir = new SqlCommand("insert into tbl_gelirler (Tarih,Su,Kola,Cikolata,Adidas_Kira,Puma_Kira,Nike_Kira,Adidas,Nike,Puma,SahaÜcreti,Tutar)values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)", Bgl.baglanti());
                Gelir.Parameters.AddWithValue("@p1", dateTimePicker1.Text);
                Gelir.Parameters.AddWithValue("@p2", TxtSu.Text);
                Gelir.Parameters.AddWithValue("@p3", TxtKola.Text);
                Gelir.Parameters.AddWithValue("@p4", Txtcikolata.Text);
                Gelir.Parameters.AddWithValue("@p5", Txtkira1.Text);
                Gelir.Parameters.AddWithValue("@p6", Txtkira2.Text);
                Gelir.Parameters.AddWithValue("@p7", Txtkira3.Text);
                Gelir.Parameters.AddWithValue("@p8", Txtsat1.Text);
                Gelir.Parameters.AddWithValue("@p9", TxtSat2.Text);
                Gelir.Parameters.AddWithValue("@p10", Txtsat3.Text);
                Gelir.Parameters.AddWithValue("@p11", TxtSaha.Text);
                Gelir.Parameters.AddWithValue("@p12", TxtTutar.Text);
                try
                {
                    Gelir.ExecuteNonQuery();
                    MessageBox.Show("Başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Temizle();
                    GelirListe();
                    KayıtlıRandevuLİste();
                    DurumGuncel();
                    randevuRenk();
                    KayıtlıRandevuLİste();
                }
                catch (Exception Hata)
                {

                    MessageBox.Show("Hata:" + "HATA" + Hata.Message + MessageBoxButtons.OK + MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tutar ve Tarih kısımları boş bırakılamaz");
            }
        }

        private void Frm_Gelirler_Load(object sender, EventArgs e)
        {
            GelirListe();
            KayıtlıRandevuLİste();
            randevuRenk();
        }
        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            GelirListe();
            KayıtlıRandevuLİste();
        }
        string randevuId;
        string UcretDurum;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int aktar = dataGridView2.SelectedCells[0].RowIndex;
            randevuId = dataGridView2.Rows[aktar].Cells[0].Value.ToString();
            TxtSaha.Text = dataGridView2.Rows[aktar].Cells[4].Value.ToString();
            UcretDurum = dataGridView2.Rows[aktar].Cells[3].Value.ToString();
        }

        private void CmbGun_SelectedIndexChanged(object sender, EventArgs e)
        {
            KayıtlıRandevuLİste();
        }
    }
}
