using AppCalendarToDoList.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCalendarToDoList
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PaginaMenu();
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
