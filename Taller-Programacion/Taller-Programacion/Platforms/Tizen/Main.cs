<<<<<<< HEAD
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using System;
=======
using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
>>>>>>> 2d57958a9cee842defcf6a5622ff175fe734f9db

namespace Taller_Programacion
{
    internal class Program : MauiApplication
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}
