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
    public partial class Frm_Randevu : Form
    {
        public Frm_Randevu()
        {
            InitializeComponent();
        }

        SqlBaglanti Bgl = new SqlBaglanti();
        public  string Kullanıcı;
        string randevuId;
        string Randevudurum;
        bool durum;
        string RandevuSaat;
        bool Ucretdurum;

        void Temizle()
        {
            CmbTakımAdı1.Items.Clear();
            CmbTakımAdı1.Text = "";
            CmbTakımAdı2.Items.Clear();
            CmbTakımAdı2.Text = "";
            MskTel.Clear();
            TxtMail.Clear();
            CmbGun.Text = "";
            TxtSaat.Clear();
            CmbUcretDurum.Text = "";
        }

        void Takımad()
        {
            SqlCommand Takımad = new SqlCommand("select distinct takımad1 from tbl_randevu_Kayıt", Bgl.baglanti());
            SqlDataReader dr = Takımad.ExecuteReader();
            while (dr.Read())
            {
                CmbTakımAdı1.Items.Add(dr[0].ToString());
                CmbTakımAdı2.Items.Add(dr[0].ToString());
            }
        }

        void randevular()
        {
            SqlCommand randevu = new SqlCommand("select * from tbl_randevu ",Bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(randevu);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
        
        void randevuDurum()
        {
            SqlCommand güncelle = new SqlCommand(" update tbl_randevu set RandevuDurum='"+ "1"+ "' where Id='" + randevuId + "' ", Bgl.baglanti());
            try
            {
                güncelle.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata",hata.Message);
            }
        }

        void randevuRenk()
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle(); 
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[3].Value) == true) 
                { 
                    renk.BackColor = Color.Red;
                    renk.ForeColor = Color.WhiteSmoke;
                }
                else
                {
                    renk.BackColor = Color.Green;
                    renk.ForeColor = Color.Black;
                }
                dataGridView1.Rows[i].DefaultCellStyle = renk; 
            }
        }
        
        void Tekrarengelle()
        {
            SqlCommand tekrarengel = new SqlCommand("select * from tbl_randevu where  gunler='"+ CmbGun.Text+"'And Saatler='"+ RandevuSaat +"' And RandevuDurum='"+"True" +"'" ,Bgl.baglanti());
            try
            {
                SqlDataReader dr = tekrarengel.ExecuteReader();
                if (dr.Read())
                {
                    durum = false;
                }
                else
                {
                    durum = true;
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show("HATA","HATA"+hata.Message+MessageBoxButtons.OK+MessageBoxIcon.Error);
            }
        }

        void GünlereLilstele()
        {  
            SqlCommand komutAra = new SqlCommand(" select * from tbl_randevu where Gunler='" + CmbGun.Text + "'", Bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komutAra);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            randevuRenk();
        }
        
        private void CmbGun_SelectedIndexChanged(object sender, EventArgs e)
        {
            GünlereLilstele();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            DialogResult dialog = new DialogResult(); 
            dialog=MessageBox.Show("Haftalık kayıtlar silinecek eminmisiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Information); 
            if (dialog==DialogResult.Yes)
            {
                SqlCommand haftaBitir = new SqlCommand("update tbl_randevu set RandevuDurum='" + "0" + "' ", Bgl.baglanti());
                SqlDataAdapter da = new SqlDataAdapter(haftaBitir);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                try
                {
                    dataGridView1.DataSource = tablo;
                    MessageBox.Show("Haftalık Kayıt listesi Güncellenmiştir.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    randevular();
                    randevuDurum();
                    randevuRenk();
                }
                catch (Exception HATA)
                {
                    MessageBox.Show("Hafta Bitirme işlemi yapılamadı: " + HATA.Message + "HATA" + MessageBoxButtons.OK + MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Haftalık kayıtlar silinmedi.","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
       
        private void btnekle_Click_1(object sender, EventArgs e)
        {
            Tekrarengelle();
            if (durum==true)
            {
                if (CmbTakımAdı1.Text != "" && CmbTakımAdı2.Text != "" && MskTel.Text != "" && TxtMail.Text != "" && Tarih.Text != "" && CmbGun.Text != "" && TxtSaat.Text != "" && MskUcret.Text != "" && CmbUcretDurum.Text!="") 
                {
                    SqlCommand Kayıt = new SqlCommand("insert into tbl_randevu_Kayıt(randevuıd,takımad1,takımad2,telno,mail,tarih,Ucret,UcretDurum,RandevuGun,RandevuTarıh) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", Bgl.baglanti());
                    Kayıt.Parameters.AddWithValue("@p1", TxtSaat.Text);
                    Kayıt.Parameters.AddWithValue("@p2", CmbTakımAdı1.Text);
                    Kayıt.Parameters.AddWithValue("@p3", CmbTakımAdı2.Text);
                    Kayıt.Parameters.AddWithValue("@p4", MskTel.Text);
                    Kayıt.Parameters.AddWithValue("@p5", TxtMail.Text);
                    Kayıt.Parameters.AddWithValue("@p6", Tarih.Text);
                    Kayıt.Parameters.AddWithValue("@p7", MskUcret.Text);
                    Kayıt.Parameters.AddWithValue("@p8", Ucretdurum);
                    Kayıt.Parameters.AddWithValue("@p9", CmbGun.Text);
                    Kayıt.Parameters.AddWithValue("@p10", dateTimePicker1.Text);
                    try
                    {
                        Kayıt.ExecuteNonQuery();
                        randevuDurum();
                        MessageBox.Show("Randevu Alındı","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        Temizle();
                        Takımad();
                        randevular();
                        randevuRenk();
                    }
                    catch (Exception HATA)
                    {

                        MessageBox.Show("Randevu Alınamadı :"+"HATA"+HATA.Message+MessageBoxButtons.OK+MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Boş alan bırakmayınız", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Randevu daha önce alımmıştır.","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog2 = new DialogResult();
            dialog2 = MessageBox.Show(TxtSaat.Text+" "+"Randevuyu iptal edilecek!","UYARI",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
            if (dialog2==DialogResult.OK)
            {
                if (TxtSaat.Text != "" && CmbGun.Text != "")
                {
                    SqlCommand randevuIptal = new SqlCommand("update tbl_randevu set RandevuDurum='" + "False" + "' where Gunler='" + CmbGun.Text + "' And Saatler='" + RandevuSaat + "'", Bgl.baglanti());
                    try
                    {
                        randevuIptal.ExecuteNonQuery();
                        MessageBox.Show("Randevu iptali başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        randevular();
                        randevuRenk();
                    }
                    catch (Exception Hata)
                    {

                        MessageBox.Show("Randevu iptali yapılamadı Hata:" + Hata.Message + MessageBoxButtons.OK + MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(" İptal edilmek istenen Randevu günü veya saati belirlenmemiştir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            int aktar = dataGridView1.SelectedCells[0].RowIndex;
            randevuId = dataGridView1.Rows[aktar].Cells[0].Value.ToString();
            TxtSaat.Text = dataGridView1.Rows[aktar].Cells[2].Value.ToString();
            CmbGun.Text  = dataGridView1.Rows[aktar].Cells[1].Value.ToString();
            RandevuSaat = dataGridView1.Rows[aktar].Cells[2].Value.ToString();
            Randevudurum = dataGridView1.Rows[aktar].Cells[3].Value.ToString();
           
            if (Randevudurum== "True")
            {
                BtnRandevuIptal.Visible = true;
            }
            else
            {
                BtnRandevuIptal.Visible = false; 
            } 
        }

        private void CmbUcretDurum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbUcretDurum.Text == "Alınmadı")
            {
                Ucretdurum = Convert.ToBoolean("false");
            }
            if (CmbUcretDurum.Text == "Alındı")
            {
                Ucretdurum = Convert.ToBoolean("true");
            }
        }

        private void Frm_Randevu_Load(object sender, EventArgs e)
        {
            Takımad();
            randevular();
            if (Kullanıcı == "MÜDÜR")
            {
                aDMİNToolStripMenuItem.Visible = true;
                gİDERLERToolStripMenuItem.Visible = true;
            }
            else
            {
                aDMİNToolStripMenuItem.Visible = false;
                gİDERLERToolStripMenuItem.Visible = false;
            }
            randevuRenk();
        }

        private void gELİRLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Gelir frm = new Frm_Gelir();
            frm.Show();
        }

        private void gİDERLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Giderler frm = new Frm_Giderler();
            frm.Show();
        }

        private void mAİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mail frm = new Frm_Mail();
            frm.Show();
        }

        private void aDMİNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Admin frm = new Frm_Admin();
            frm.Show();
        }

        private void aRŞİVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Arsiv frm = new Frm_Arsiv();
            frm.Show();
        }

       
    }
}
