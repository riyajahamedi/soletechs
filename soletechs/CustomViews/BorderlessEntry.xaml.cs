using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace soletechs.CustomViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BorderlessEntry : Entry
    {
        public BorderlessEntry()
        {
            InitializeComponent();
        }
    }
}
