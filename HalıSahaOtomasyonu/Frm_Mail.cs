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
using System.Net.Mail;
using System.Net;

namespace HalıSahaOtomasyonu
{
    public partial class Frm_Mail : Form
    {
        public Frm_Mail()
        {
            InitializeComponent();
        }

        SqlBaglanti Bgl = new SqlBaglanti();

        private void BtnGönder_Click(object sender, EventArgs e)
        {
            SmtpClient sk = new SmtpClient();
            sk.Port = 587;  //PORT ADRESİ
            sk.Host = "smtp.gmail.com"; //GMAİL, OUTLOOK, HOTMAİL, HANGİSİNDEN GÖNDERİLECEĞİ
            sk.EnableSsl = true; //GÜVENLİK KATMANI
            sk.Credentials = new NetworkCredential("Meil Adresi", "ŞİFRE"); //GÖNDERİCİNİN MAİLİ VE ŞİFRESİ
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(TxtKimden.Text.ToString()); //GÖNDEREN KISMI
            mail.To.Add(TxtKime.Text.ToString()); //ALICI KISMI
            mail.Subject = TxtKonu.Text.ToString(); //KONU KISMI
            mail.IsBodyHtml = true;  //POSTA GÖNDERİSİNİN HTML BİÇİMDE OLDUĞUNU DOĞRULATMA
            mail.Body = richTextBox1.Text.ToString(); // BODY KISMININ NEREYE YAZILACAĞI (MESAJ)
            sk.Send(mail); //TÜR 
            MessageBox.Show("Mail Gönderildi");
        }
        void listele()
        {
            SqlCommand müsteri = new SqlCommand("select * from tbl_randevu_Kayıt", Bgl.baglanti());
            SqlDataAdapter dataadapter0 = new SqlDataAdapter(müsteri);
            DataTable Tablo0 = new DataTable();
            dataadapter0.Fill(Tablo0);
            try
            {
                dataGridView1.DataSource = Tablo0; //HATA YOK İSE DATAGRİDDE GÖSTER

            }
            catch (Exception hata0)
            {

                MessageBox.Show("Hasta Mail'leri getirilemedi", hata0.Message + "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error); //HATALI İSE MESAJ VER
            }
        }

        private void Frm_Mail_Load(object sender, EventArgs e)
        {
            TxtKimden.Text = "Meil adresi girilecek."; // göndern mail a
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtKime.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString(); //KİME VERİLERİNİ TEXTDE GÖSTERİR
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SqlCommand müsteri = new SqlCommand("select * from tbl_randevu_Kayıt where tarih='"+ dateTimePicker1.Text+"'", Bgl.baglanti());
            SqlDataAdapter dataadapter0 = new SqlDataAdapter(müsteri);
            DataTable Tablo0 = new DataTable();
            dataadapter0.Fill(Tablo0);
            try
            {
                dataGridView1.DataSource = Tablo0; //HATA YOK İSE DATAGRİDDE GÖSTER
                button1.Visible = true;

            }
            catch (Exception hata0)
            {

                MessageBox.Show("Hasta Mail'leri getirilemedi", hata0.Message + "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error); //HATALI İSE MESAJ VER
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listele();
            button1.Visible = false;
        }
    }
}
