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

        private void FrmYeniMusteri_Load(object sender , EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda1 ", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read()) ;
            {
                BtnOda1.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda1.Text != "1")
            {
                BtnOda1.BackColor = Color.Red;
                BtnOda1.Enabled = false;
            }

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Oda2 ", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read()) ;
            {
                BtnOda2.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda2.Text != "2")
            {
                BtnOda2.BackColor = Color.Red;
                BtnOda2.Enabled = false;
            }

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from Oda3 ", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read()) ;
            {
                BtnOda3.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda3.Text != "3")
            {
                BtnOda3.BackColor = Color.Red;
                BtnOda3.Enabled = false;
            }

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from Oda4 ", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read()) ;
            {
                BtnOda4.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda4.Text != "4")
            {
                BtnOda4.BackColor = Color.Red;
                BtnOda4.Enabled = false;
            }

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from Oda5 ", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read()) ;
            {
                BtnOda5.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda5.Text != "5")
            {
                BtnOda5.BackColor = Color.Red;
                BtnOda5.Enabled = false;
            }

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from Oda6 ", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read()) ;
            {
                BtnOda6.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda6.Text != "6")
            {
                BtnOda6.BackColor = Color.Red;
                BtnOda6.Enabled = false;
            }

            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from Oda7 ", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read()) ;
            {
                BtnOda7.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda7.Text != "7")
            {
                BtnOda7.BackColor = Color.Red;
                BtnOda7.Enabled = false;
            }

            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from Oda8 ", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read()) ;
            {
                BtnOda8.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda8.Text != "8")
            {
                BtnOda8.BackColor = Color.Red;
                BtnOda8.Enabled = false;
            }

            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from Oda9 ", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read()) ;
            {
                BtnOda9.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda9.Text != "9")
            {
                BtnOda9.BackColor = Color.Red;
                BtnOda9.Enabled = false;
            }
        }
    }
}

