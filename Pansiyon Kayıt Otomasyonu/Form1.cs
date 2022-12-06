namespace Pansiyon_Kayıt_Otomasyonu
{
    public partial class FrmAdminGiriş : Form
    {
        public FrmAdminGiriş()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //yeni bir pencere açmak için kullanılır
            FrmYeniMusteri form = new FrmYeniMusteri();
            form.ShowDialog();
        }
    }
}