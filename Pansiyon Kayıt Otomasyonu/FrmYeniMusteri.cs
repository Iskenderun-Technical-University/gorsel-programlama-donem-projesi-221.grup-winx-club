using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pansiyon_Kayıt_Otomasyonu
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }

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

        private void BtnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renkli butonlar dolu odaları gösterir");
        }

        private void BtnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renkli butonlar boş odaları gösterir");
        }
    }
}
