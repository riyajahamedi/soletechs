using soletechs.ViewModels;
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
	public partial class Inquiries : ContentPage
	{
		public Inquiries ()
		{
			InitializeComponent ();
            BindingContext = new InquiriesViewModel();
		}
	}
}