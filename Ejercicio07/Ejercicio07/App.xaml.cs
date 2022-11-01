using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio07
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new PickerDemo();
            //MainPage = new ListViewDemo();
            //MainPage = new BindingModeDemo();
            MainPage = new ViewToViewDemo();
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
