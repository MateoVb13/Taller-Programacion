namespace Taller_Programación
{
    public partial class App : Application
    {
        public static FlyoutPage FlyoutPage { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
    }
}
