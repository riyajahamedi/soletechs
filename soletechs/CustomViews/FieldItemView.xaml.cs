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
            BindingContext = this;
		}

        public static BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(FieldItemView), string.Empty);

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

        public static BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(FieldItemView), string.Empty);

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

        public static BindableProperty TitleColorProperty = BindableProperty.Create(nameof(TitleColor), typeof(Color), typeof(FieldItemView), Color.Accent);

        public Color TitleColor
        {
            get
            {
                return (Color)GetValue(TitleColorProperty);
            }
            set
            {
                SetValue(TitleColorProperty, value);
            }
        }

        public static BindableProperty TextColorProperty = BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(FieldItemView), Color.Accent);

        public Color TextColor
        {
            get
            {
                return (Color)GetValue(TextColorProperty);
            }
            set
            {
                SetValue(TextColorProperty, value);
            }
        }
    }
}