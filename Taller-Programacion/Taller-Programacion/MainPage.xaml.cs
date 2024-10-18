<<<<<<< HEAD
﻿namespace Taller_Programacion
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
=======
﻿using Microsoft.UI.Xaml.Controls;

namespace Taller_Programacion
{
    public partial class MainPage : FlyoutPage
    {
>>>>>>> 2d57958a9cee842defcf6a5622ff175fe734f9db

        public MainPage()
        {
            InitializeComponent();
<<<<<<< HEAD
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
=======


            Flyout = new Maestro();
            Detail = new NavigationPage(new Detalle());

            App.FlyoutPage = this;
>>>>>>> 2d57958a9cee842defcf6a5622ff175fe734f9db
        }
    }

}
