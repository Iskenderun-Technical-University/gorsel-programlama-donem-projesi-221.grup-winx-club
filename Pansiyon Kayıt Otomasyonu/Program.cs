namespace Pansiyon_Kayıt_Otomasyonu
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Program hangi formdan başlayacaksa buraya yazılır.
            //örn: new Form1()
            Application.Run(new FrmOdalar());
        }
    }
}