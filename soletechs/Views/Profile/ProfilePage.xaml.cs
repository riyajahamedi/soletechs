using soletechs.ViewModels;
using soletechs.Views.Profile;
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
	public partial class ProfilePage : ContentPage
	{
        public ProfilePage ()
		{
			InitializeComponent ();
            BindingContext = new ProfileViewModel();
        }

        private async void OnMainInfoTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainInfo());           
        }

        private async void OnJobInfoTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new JobInfo());
        }

        private async void OnBenifitTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Benifits());
        }

        private async void OnBankInfoTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BankInfo());
        }

        private async void OnIdentificationTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Identification());
        }

        private async void OnDependentTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Dependent());
        }
    }
}