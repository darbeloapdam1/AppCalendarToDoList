using AppCalendarToDoList.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppCalendarToDoList.Data;
using System.IO;

namespace AppCalendarToDoList
{
    public partial class App : Application
    {
        static SQLiteHelper db;
        public App()
        {
            InitializeComponent();

            MainPage = new PaginaMenu();
        }
        public static SQLiteHelper SQLiteDB
        {
            get
            {
                if (db == null)
                {
                    db = new SQLiteHelper(Path.Combine
                        (Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                        "Eventos.db3"));
                }
                return db;
            }
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
