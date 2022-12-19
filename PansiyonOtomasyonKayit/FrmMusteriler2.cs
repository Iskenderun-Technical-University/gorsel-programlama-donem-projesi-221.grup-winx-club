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

        SqlConnection baglanti = new SqlConnection (@"Data Source=DESKTOP-KF6V5PA\SQLEXPRESS01;Initial Catalog=""Pansiyon Otomasyonu"";Integrated Security=True");
        //deneme
         private void verilerigoster()
        {
            listView1.Items.Clear();
            
            SqlCommand komut = new SqlCommand("select * from Musteri_Ekle", baglanti);
            baglanti.Open();
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriide"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString()); 
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }
        int ide = 0;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ide = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;//adını yazdırmak için
            TxtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MskTxtTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtTCKimlikNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            DtpCikisTarihi.Text = listView1.SelectedItems[0].SubItems[10].Text; 

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (TxtOdaNo.Text == "1")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete fron Oda1", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();

            }
            if (TxtOdaNo.Text == "2")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete fron Oda2", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();

            }
            if (TxtOdaNo.Text == "2")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete fron Oda2", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();

            }
            if (TxtOdaNo.Text == "3")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete fron Oda3", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();

            }
            if (TxtOdaNo.Text == "4")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete fron Oda4", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();

            }
            if (TxtOdaNo.Text == "5")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete fron Oda5", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();

            }
            if (TxtOdaNo.Text == "6")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete fron Oda6", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();

            }
            if (TxtOdaNo.Text == "7")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete fron Oda7", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();

            }
            if (TxtOdaNo.Text == "8")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete fron Oda8", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();

            }
            if (TxtOdaNo.Text == "9")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete fron Oda9", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();

            }
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
            listView1.Items.Clear();

            SqlCommand komut = new SqlCommand("select * from Musteri_Ekle where Adi like '%" +textBox1.Text+"½'", baglanti);
            baglanti.Open();
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriide"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
    }
}
//Data Source=DESKTOP-SJJ7N21\SQLEXPRESS;Initial Catalog="Pansiyon Otomasyonu";Integrated Security=True

