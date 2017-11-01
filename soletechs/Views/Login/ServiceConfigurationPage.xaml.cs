using System;
using System.Collections.Generic;
using soletechs.ViewModels;
using Xamarin.Forms;

namespace soletechs.Views
{
    public partial class ServiceConfigurationPage : ContentPage
    {
        public ServiceConfigurationPage()
        {
            InitializeComponent();

            BindingContext = new ServiceConfigViewModel();
        }

        private void OnSaveButtonClick(object sender, EventArgs e)
        {
            var loginPage = new LoginPage();
            loginPage.BindingContext = new LoginViewModel((this.BindingContext as ServiceConfigViewModel).CompanyName);
            Navigation.InsertPageBefore(loginPage, this);
            Navigation.PopAsync();
        }

        private void OnGuestLoginClick(object sender, EventArgs e)
        {
            
        }
    }
}
