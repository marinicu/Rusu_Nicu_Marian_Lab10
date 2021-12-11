using System;
using Rusu_Nicu_Marian_Lab10.Data;
using System.IO;

namespace Rusu_Nicu_Marian_Lab10
{
    public partial class App : Application
    {
        static ShoppingListDatabase database;
        public static ShoppingListDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new
                   ShoppingListDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                   LocalApplicationData), "ShoppingList.db3"));
                }
                return database;
            }
        }
    }
    public App()
    {
        InitializeComponent();
        MainPage = new NavigationPage(new ListEntryPage());
    }
}