using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PansiyonOtomasyonKayit
{
    public partial class FrmMusteriler2 : Form
    {
        public FrmMusteriler2()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-KF6V5PA\\SQLEXPRESS01;Initial Catalog=\"Pansiyon Otomasyonu\";Integrated Security=True");
        //deneme
        private void verilerigoster()
        {


            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select * From Musteri_Ekle;", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            baglanti.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }
        int ide = 0;

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Musteri_Ekle where Musteriide='" + TxtAdi.Tag + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            comboBox1.Text = "";
            MskTxtTelefon.Clear();
            TxtMail.Text = "";
            TxtTCKimlikNo.Clear();
            TxtOdaNo.Clear();
            TxtUcret.Clear();
            DtpGirisTarihi.Text = "";
            DtpCikisTarihi.Text = "";
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Musteri_Ekle set Adi='" + TxtAdi.Text + "',Soyadi='" + TxtSoyadi.Text + "',Cinsiyet='" + comboBox1.Text + "',Telefon='" + MskTxtTelefon.Text + "',Mail='"+TxtMail.Text+"',TC='"+TxtTCKimlikNo.Text+"',Ucret='"+TxtUcret.Text+"',GirisTarihi='"+DtpGirisTarihi.Value.ToString("yyyy-MM-dd")+"',CikisTarihi='" + DtpCikisTarihi.Value.ToString("yyyy-MM-dd")+"' where Musteriide=" + ide + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();    
            SqlCommand cmd = new SqlCommand("Select * From Musteri_Ekle where Adi like '%"+textBox1.Text+"%';", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            TxtAdi.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            TxtAdi.Tag = dataGridView1.Rows[index].Cells[0].Value.ToString();
            TxtSoyadi.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            MskTxtTelefon.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            TxtMail.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
            TxtTCKimlikNo.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
            TxtOdaNo.Text = dataGridView1.Rows[index].Cells[7].Value.ToString();
            TxtUcret.Text = dataGridView1.Rows[index].Cells[8].Value.ToString();

            DtpGirisTarihi.Text = dataGridView1.Rows[index].Cells[9].Value.ToString();
            DtpCikisTarihi.Text = dataGridView1.Rows[index].Cells[10].Value.ToString();
        }
    }
}
//Data Source=DESKTOP-SJJ7N21\SQLEXPRESS;Initial Catalog="Pansiyon Otomasyonu";Integrated Security=True

