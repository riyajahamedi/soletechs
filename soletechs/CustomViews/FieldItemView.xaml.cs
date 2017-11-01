using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace soletechs.CustomViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FieldItemView : ContentView
	{
		public FieldItemView ()
		{
			InitializeComponent ();
		}

        public static BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(float), typeof(FieldItemView), string.Empty);

        public string Title
        {
            get
            {
                return (string)GetValue(TitleProperty);
            }
            set
            {
                SetValue(TitleProperty, value);
            }
        }

        public static BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(float), typeof(FieldItemView), string.Empty);

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
    }
}