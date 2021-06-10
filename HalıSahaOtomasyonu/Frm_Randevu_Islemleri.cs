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
    public partial class Frm_Randevu_Islemleri : Form
    {
        public Frm_Randevu_Islemleri()
        {
            InitializeComponent();
        }

        SqlBaglanti Bgl = new SqlBaglanti();
        string randevuID = "0";

        private void Frm_Randevu_Islemleri_Load(object sender, EventArgs e)
        {
            RandevuLİstesi();
        }

        private void CmbGun_SelectedIndexChanged(object sender, EventArgs e)
        {
            GünlereLilstele();
        }

        private void CmbGun2_SelectedIndexChanged(object sender, EventArgs e)
        {
            GünlereLilstele();
        }

        void RandevuLİstesi()
        {
            // randevuları listeledik.
            SqlCommand randevu = new SqlCommand("select * from tbl_randevu ", Bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(randevu);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            LblRabdevuId.DataSource = tablo;
        }
        void GünlereLilstele()
        {
            // günler combobox dan secilen günü ayit randevuları data gridde listelettik.  
            SqlCommand komutAra = new SqlCommand(" select * from tbl_randevu where Gunler='" + CmbGun.Text + "'", Bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komutAra);
            DataTable dt = new DataTable();
            da.Fill(dt);
            LblRabdevuId.DataSource = dt;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand Ekle = new SqlCommand("insert into tbl_randevu (Gunler,Saatler,RandevuDurum) values (@p1,@p2,@p3)",Bgl.baglanti());
            Ekle.Parameters.AddWithValue("@p1",CmbGun.Text);
            Ekle.Parameters.AddWithValue("@p2",TxtSaat1.Text+" - "+ TxtSaat2.Text);
            Ekle.Parameters.AddWithValue("@p3", "False");
            try
            {
                Ekle.ExecuteNonQuery();
                MessageBox.Show(CmbGun.Text +" gününe "+" "+TxtSaat1.Text+"-"+TxtSaat2.Text+" saatli randevu eklenmiştir","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                CmbGun.Text = "";
                RandevuLİstesi();
            }
            catch (Exception HATA)
            {

                MessageBox.Show("Kayıt eklenemedi"+HATA.Message+"HATA"+MessageBoxIcon.Error+MessageBoxButtons.OK);
            }
        }

        string RandevuSaat;
        string RandevuGun;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int aktar = LblRabdevuId.SelectedCells[0].RowIndex;
            randevuID= LblRabdevuId.Rows[aktar].Cells[0].Value.ToString();
            RandevuSaat= LblRabdevuId.Rows[aktar].Cells[2].Value.ToString();
            RandevuGun= LblRabdevuId.Rows[aktar].Cells[1].Value.ToString();
            LblRandevuId.Text = randevuID;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult a =  new DialogResult();
            a = MessageBox.Show( RandevuGun+" "+ RandevuSaat+" randevu silinsinmi?  ","UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (a==DialogResult.Yes)
            {
                SqlCommand Sıl = new SqlCommand("delete from tbl_randevu where Id='" + randevuID + "'", Bgl.baglanti());
                try
                {
                    Sıl.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Silindi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    CmbGun.Text = "";
                    RandevuLİstesi();
                }
                catch (Exception HATA)
                {

                    MessageBox.Show("Kayıt Silinemedi!" + HATA.Message + "BİLGİ" + MessageBoxButtons.OK + MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kayıt Silinmedi.","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
           
        }
    }
}
