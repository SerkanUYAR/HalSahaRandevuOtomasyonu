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
    public partial class Frm_Giderler : Form
    {
        public Frm_Giderler()
        {
            InitializeComponent();
        }
        SqlBaglanti Bgl = new SqlBaglanti();

        void GiderListesi()
        {
            SqlCommand GiderListe = new SqlCommand("select * from tbl_giderler", Bgl.baglanti());
            SqlDataAdapter dataAdapter = new SqlDataAdapter(GiderListe);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
        void Temzile()
        {
            TxtCim.Clear();
            TxtDolgaz.Clear();
            TxtElekyitik.Clear();
            TxtForma.Clear();
            TxtKira.Clear();
            TxtSu.Clear();
            TxtTop.Clear();
            CmbAy.Text = "";
            TxtMaas.Clear();
        }
        private void Frm_Giderler_Load(object sender, EventArgs e)
        {
            GiderListesi();
           
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand Kayıt = new SqlCommand("insert into tbl_giderler (Elektrik,Su,Dogalgaz,Cim,FutbolTop,Forma,Kira,Yıl,Ay,P_Maas) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10) ", Bgl.baglanti());
            Kayıt.Parameters.AddWithValue("@p1",TxtElekyitik.Text);
            Kayıt.Parameters.AddWithValue("@p2",TxtSu.Text);
            Kayıt.Parameters.AddWithValue("@p3",TxtDolgaz.Text);
            Kayıt.Parameters.AddWithValue("@p4",TxtCim.Text);
            Kayıt.Parameters.AddWithValue("@p5", TxtTop.Text);
            Kayıt.Parameters.AddWithValue("@p6", TxtForma.Text);
            Kayıt.Parameters.AddWithValue("@p7", TxtKira.Text);
            Kayıt.Parameters.AddWithValue("@p8",dateTimePicker1.Text);
            Kayıt.Parameters.AddWithValue("@p9",CmbAy.Text);
            Kayıt.Parameters.AddWithValue("@p10",TxtMaas.Text);
            try
            {
                Kayıt.ExecuteNonQuery();
                
                MessageBox.Show("Kayıt Başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Temzile();
                GiderListesi();
            }
            catch (Exception)
            {

                MessageBox.Show("Kayıt yapılamadı","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
        
        private void btngüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand guncel = new SqlCommand("update tbl_giderler set Elektrik=@p1,Su=@p2,Dogalgaz=@p3,Cim=@p4,FutbolTop=@p5,Forma=@p6,Kira=@p7,P_Maas=@p8,Yıl=@p9,Ay=@P10 where ıd=@p11 ", Bgl.baglanti());
                guncel.Parameters.AddWithValue("@p1",Convert.ToDecimal(TxtElekyitik.Text));
                guncel.Parameters.AddWithValue("@p2", Convert.ToDecimal(TxtSu.Text));
                guncel.Parameters.AddWithValue("@p3", Convert.ToDecimal(TxtDolgaz.Text));
                guncel.Parameters.AddWithValue("@p4", Convert.ToDecimal(TxtCim.Text));
                guncel.Parameters.AddWithValue("@p5", Convert.ToDecimal(TxtTop.Text));
                guncel.Parameters.AddWithValue("@p6",Convert.ToDecimal( TxtForma.Text));
                guncel.Parameters.AddWithValue("@p7",Convert.ToDecimal( TxtKira.Text));
                guncel.Parameters.AddWithValue("@p8",Convert.ToDecimal( TxtMaas.Text));
                guncel.Parameters.AddWithValue("@p9", dateTimePicker1.Text);
                guncel.Parameters.AddWithValue("@p10",CmbAy.Text);
                guncel.Parameters.AddWithValue("@p11",label9.Text);
                guncel.ExecuteNonQuery();
                MessageBox.Show("Kayıt Güncellendi.","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                GiderListesi();
                Temzile();

            }
            catch (Exception HATA)
            {
                MessageBox.Show("Güncellem işlemi yercekleştirilemedi. Hata:" + HATA.Message + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int tası = dataGridView1.SelectedCells[0].RowIndex;
            TxtElekyitik.Text = dataGridView1.Rows[tası].Cells[0].Value.ToString();
            TxtSu.Text = dataGridView1.Rows[tası].Cells[1].Value.ToString();
            TxtDolgaz.Text = dataGridView1.Rows[tası].Cells[2].Value.ToString();
            TxtCim.Text = dataGridView1.Rows[tası].Cells[3].Value.ToString();
            TxtTop.Text = dataGridView1.Rows[tası].Cells[4].Value.ToString();
            TxtForma.Text = dataGridView1.Rows[tası].Cells[5].Value.ToString();
            TxtKira.Text = dataGridView1.Rows[tası].Cells[6].Value.ToString();
            TxtMaas.Text = dataGridView1.Rows[tası].Cells[7].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[tası].Cells[8].Value.ToString();
            CmbAy.Text = dataGridView1.Rows[tası].Cells[9].Value.ToString();
            label9.Text= dataGridView1.Rows[tası].Cells[10].Value.ToString();
            
        }
    }
}
