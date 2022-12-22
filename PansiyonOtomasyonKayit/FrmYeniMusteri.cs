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
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-KF6V5PA\\SQLEXPRESS01;Initial Catalog=\"Pansiyon Otomasyonu\";Integrated Security=True");

        private void BtnOda1_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "1";
        }

        private void BtnOda2_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "2";
        }

        private void BtnOda3_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "3";
        }

        private void BtnOda4_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "4";
        }

        private void BtnOda5_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "5";
        }

        private void BtnOda6_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "6";
        }

        private void BtnOda7_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "7";
        }

        private void BtnOda8_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "8";
        }

        private void BtnOda9_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "9";
        }

        private void BtnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renkli butonlar boş odaları gösterir");
        }

        private void BtnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renkli butonlar dolu odaları gösterir");
        }

        private void DtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(DtpGirisTarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DtpCikisTarihi.Text);

            TimeSpan Sonuc;
            Sonuc = BuyukTarih - KucukTarih;

            label10.Text = Sonuc.TotalDays.ToString();

            Ucret = Convert.ToInt32(label10.Text) * 50;
            TxtUcret.Text = Ucret.ToString();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Musteri_Ekle (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi) values('" + TxtAdi.Text + "' , '" + TxtSoyadi.Text + "' , '" + comboBox1.Text +"','"+ MskTxtTelefon.Text+"','"+TxtMail.Text+ "','" + TxtTCKimlikNo.Text+"','"+TxtOdaNo.Text+"' , '"+ TxtUcret.Text+"' , '" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd")+"' , '" + DtpCikisTarihi.Value.ToString("yyyy-MM-dd")+"')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt hatasız yapılmıştır");

        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select * From Musteri_Ekle where CikisTarihi > '" + DateTime.Now.ToString("yyyy-MM-dd") + "'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][7].ToString() == "1")
                {
                    BtnOda1.BackColor = Color.Red;
                }
                if (dt.Rows[i][7].ToString() == "2")
                {
                    BtnOda2.BackColor = Color.Red;
                }
                if (dt.Rows[i][7].ToString() == "3")
                {
                    BtnOda3.BackColor = Color.Red;
                }
                if (dt.Rows[i][7].ToString() == "4")
                {
                    BtnOda4.BackColor = Color.Red;
                }
                if (dt.Rows[i][7].ToString() == "5")
                {
                    BtnOda5.BackColor = Color.Red;
                }
                if (dt.Rows[i][7].ToString() == "6")
                {
                    BtnOda6.BackColor = Color.Red;
                }
                if (dt.Rows[i][7].ToString() == "7")
                {
                    BtnOda7.BackColor = Color.Red;
                }
                if (dt.Rows[i][7].ToString() == "8")
                {
                    BtnOda8.BackColor = Color.Red;
                }
                if (dt.Rows[i][7].ToString() == "9")
                {
                    BtnOda9.BackColor = Color.Red;
                }
            }

            baglanti.Close();
        }
    }
}

