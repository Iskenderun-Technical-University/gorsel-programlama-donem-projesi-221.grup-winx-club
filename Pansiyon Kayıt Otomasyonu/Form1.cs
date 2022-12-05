namespace Pansiyon_Kayıt_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //yeni bir pencere açmak için kullanılır
            FrmYeniMusteri form = new FrmYeniMusteri();
            form.ShowDialog();
            //asfs
            //asasf
        }
    }
}