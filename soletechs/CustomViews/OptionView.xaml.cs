using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.Mime.MediaTypeNames;

namespace soletechs.CustomViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OptionView : ContentView
	{
		public OptionView ()
		{
			InitializeComponent ();
		}

        public static BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(OptionView), defaultBindingMode: BindingMode.TwoWay);
        public string Text
        {
            get
            {
                return (string)GetValue(TextProperty);
            }
            set
            {
                SetValue(TextProperty, value);
            }
        }

        public static BindableProperty ImageProperty = BindableProperty.Create(nameof(Image), typeof(string), typeof(OptionView), defaultBindingMode: BindingMode.TwoWay);
        public string Image
        {
            get
            {
                return (string)GetValue(ImageProperty);
            }
            set
            {
                SetValue(ImageProperty, value);
            }
        }
    }
}