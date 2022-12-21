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
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-KF6V5PA\\SQLEXPRESS01;Initial Catalog=\"Pansiyon Otomasyonu\";Integrated Security=True");

        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            
            SqlCommand komut1 = new SqlCommand("select * from Oda1 ", baglanti);
            baglanti.Open();
            SqlDataReader oku1 = komut1.ExecuteReader();



            while (oku1.Read());
            {
                BtnOda1.Text=oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda1.Text != "1")
            {
                BtnOda1.BackColor = Color.Red;
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
            }
        }
    }
} 