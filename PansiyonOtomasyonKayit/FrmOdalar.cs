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
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select * From Musteri_Ekle where CikisTarihi > '"+DateTime.Now.ToString("yyyy-MM-dd")+"'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for(int i=0; i<dt.Rows.Count; i++) 
            {
                if (dt.Rows[i][7].ToString() == "1")
                {
                    BtnOda1.Text = dt.Rows[i][1].ToString() + " " + dt.Rows[i][2].ToString();
                    BtnOda1.BackColor = Color.Red;
                }
                if (dt.Rows[i][7].ToString() == "2")
                {
                    BtnOda2.Text = dt.Rows[i][1].ToString() + " " + dt.Rows[i][2].ToString();
                    BtnOda2.BackColor = Color.Red;
                }
                if (dt.Rows[i][7].ToString() == "3")
                {
                    BtnOda3.Text = dt.Rows[i][1].ToString() + " " + dt.Rows[i][2].ToString();
                    BtnOda3.BackColor = Color.Red;
                }
                if (dt.Rows[i][7].ToString() == "4")
                {
                    BtnOda4.Text = dt.Rows[i][1].ToString() + " " + dt.Rows[i][2].ToString();
                    BtnOda4.BackColor = Color.Red;
                }
                if (dt.Rows[i][7].ToString() == "5")
                {
                    BtnOda5.Text = dt.Rows[i][1].ToString() + " " + dt.Rows[i][2].ToString();
                    BtnOda5.BackColor = Color.Red;
                }
                if (dt.Rows[i][7].ToString() == "6")
                {
                    BtnOda6.Text = dt.Rows[i][1].ToString() + " " + dt.Rows[i][2].ToString();
                    BtnOda6.BackColor = Color.Red;
                }
                if (dt.Rows[i][7].ToString() == "7")
                {
                    BtnOda7.Text = dt.Rows[i][1].ToString() + " " + dt.Rows[i][2].ToString();
                    BtnOda7.BackColor = Color.Red;
                }
                if (dt.Rows[i][7].ToString() == "8")
                {
                    BtnOda8.Text = dt.Rows[i][1].ToString() + " " + dt.Rows[i][2].ToString();
                    BtnOda8.BackColor = Color.Red;
                }
                if (dt.Rows[i][7].ToString() == "9")
                {
                    BtnOda9.Text = dt.Rows[i][1].ToString() + " " + dt.Rows[i][2].ToString();
                    BtnOda9.BackColor = Color.Red;
                }
            }

            baglanti.Close();
        }
    }
} 