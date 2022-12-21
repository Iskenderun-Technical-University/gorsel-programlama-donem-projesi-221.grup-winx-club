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
    public partial class FrmPersonelMaas : Form
    {
        public FrmPersonelMaas()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-KF6V5PA\\SQLEXPRESS01;Initial Catalog=\"Pansiyon Otomasyonu\";Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select sum(Ucret) as toplam from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                LblKasaToplam.Text = oku["toplam"].ToString();

            }
            baglanti.Close();

            int personel;
            personel = Convert.ToInt16(textBox1.Text);
            LblPersonelMaas.Text = (personel * 1500).ToString();
        }
    }
}
