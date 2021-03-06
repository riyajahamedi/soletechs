﻿using soletechs.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace soletechs.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
        }

        private void OnLoginButtonClicked(object sender, EventArgs e)
        {
            var homePage = new HomePage();
            Navigation.InsertPageBefore(homePage, this);
            Navigation.PopAsync();
        }

        private void OnCompanyNameClick(object sender, EventArgs e)
        {
            var configPage = new ServiceConfigurationPage();
            Navigation.InsertPageBefore(configPage, this);
            Navigation.PopAsync();
        }
    }
}