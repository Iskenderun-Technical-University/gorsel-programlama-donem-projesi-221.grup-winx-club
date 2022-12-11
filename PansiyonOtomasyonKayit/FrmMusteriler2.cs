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
        SqlConnection baglanti = new SqlConnection (@"Data Source=DESKTOP-SJJ7N21\\SQLEXPRESS;Initial Catalog=PansiyonOtomasyonu;Integrated Security=True");
         private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Musteri_Ekle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
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
    }
}
//Data Source=DESKTOP-SJJ7N21\SQLEXPRESS;Initial Catalog="Pansiyon Otomasyonu";Integrated Security=True
