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

        }

        private void OnGuestLoginClick(object sender, EventArgs e)
        {

        }
    }
}
