using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using soletechs.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace soletechs.Views.Profile
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainInfo : ContentPage
	{
		public MainInfo ()
		{
			InitializeComponent ();
            BindingContext = new MainInfoViewModel();
		}
	}
}