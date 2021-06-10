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
    public partial class Frm_Arsiv : Form
    {
        public Frm_Arsiv()
        {
            InitializeComponent();
        }
        SqlBaglanti Bgl = new SqlBaglanti();

        void KayıtLİste()
        {
            SqlCommand kayıtlar = new SqlCommand("select * from tbl_randevu_Kayıt", Bgl.baglanti());
            SqlDataAdapter dataAdapter = new SqlDataAdapter(kayıtlar);
            DataTable Tablo = new DataTable();
            dataAdapter.Fill(Tablo);
            dataGridView1.DataSource = Tablo;
        }

        private void Frm_Arsiv_Load(object sender, EventArgs e)
        {
            KayıtLİste();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KayıtLİste();
            button1.Visible = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SqlCommand kayıtlar = new SqlCommand("select * from tbl_randevu_Kayıt where tarih='"+ dateTimePicker1.Text + "'", Bgl.baglanti());
            SqlDataAdapter dataAdapter = new SqlDataAdapter(kayıtlar);
            DataTable Tablo = new DataTable();
            dataAdapter.Fill(Tablo);
            dataGridView1.DataSource = Tablo;
            button1.Visible = true;
        }
    }
}
