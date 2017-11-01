using System;

using Xamarin.Forms;
using soletechs.Views;

namespace soletechs
{
    public partial class App : Application
    {
        public static bool UseMockDataStore = true;
        public static string BackendUrl = "https://localhost:5000";

        public App()
        {
            InitializeComponent();

            if (UseMockDataStore)
                DependencyService.Register<MockDataStore>();
            else
                DependencyService.Register<CloudDataStore>();

            MainPage = new NavigationPage(new ServiceConfigurationPage());
        }
    }
}
