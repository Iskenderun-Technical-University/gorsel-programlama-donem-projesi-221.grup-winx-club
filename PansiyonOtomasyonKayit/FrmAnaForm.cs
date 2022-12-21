using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PansiyonOtomasyonKayit
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminGiris fr = new FrmAdminGiris();
            fr.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri fr = new FrmYeniMusteri();
            fr.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMusteriler2 fr = new FrmMusteriler2();
            fr.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Paradise Pansiyon Kayıt Uygulaması");
        }

        private void button3_Clik(object sender, EventArgs e)
        {
            FrmOdalar fr = new FrmOdalar();
            fr.Show();
        }


        private void FrmAnaForm_Load(object sender, EventArgs e)
        {

        }


        private void button5_Click(object sender, EventArgs e)
        {
            FrmPersonelMaas fr = new FrmPersonelMaas();
            fr.Show();
        }
    }
}

