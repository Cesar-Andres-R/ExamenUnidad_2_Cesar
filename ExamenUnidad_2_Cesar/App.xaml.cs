using ExamenUnidad_2_Cesar.Vista;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenUnidad_2_Cesar
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CalcularPeso();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
