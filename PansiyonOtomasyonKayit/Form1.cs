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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-KF6V5PA\\SQLEXPRESS01;Initial Catalog=\"Pansiyon Otomasyonu\";Integrated Security=True");

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql="select * from Admin_Giris where"

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
