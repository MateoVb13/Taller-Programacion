using Microsoft.UI.Xaml.Controls;

namespace Taller_Programacion
{
    public partial class MainPage : FlyoutPage
    {

        public MainPage()
        {
            InitializeComponent();


            Flyout = new Maestro();
            Detail = new NavigationPage(new Detalle());

            App.FlyoutPage = this;
        }
    }

}
