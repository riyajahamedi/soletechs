using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using soletechs.CustomViews;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using System.ComponentModel;
using soletechs.iOS;


[assembly: ExportRenderer(typeof(BorderlessEntry), typeof(BorderlessEntryRenderer))]
namespace soletechs.iOS
{
    public class BorderlessEntryRenderer : EntryRenderer
    {
        public static void Init() { }
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            Control.Layer.BorderWidth = 0;
            Control.BorderStyle = UITextBorderStyle.None;
        }
    }
}
