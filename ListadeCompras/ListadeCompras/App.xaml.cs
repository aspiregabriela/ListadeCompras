using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using ListadeCompras.Helper;
using System.IO;

namespace ListadeCompras
{
    public partial class App : Application
    {
        static SQLiteDatabaseHelper Database;
        
        public static SQLiteDatabaseHelper DatabaseHelper
        {
            get
            {
                if(Database == null)
                {
                    string path = Path.Combine(
                      Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                      "arquivo.db3"
                      );
                    Database = new SQLiteDatabaseHelper(path);

                }
                return Database;


            }


        }


        
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage();
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
