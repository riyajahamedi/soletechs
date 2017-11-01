using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace soletechs.CustomViews
{
    public class BoxFrame: Frame
    {
        public static BindableProperty BorderWidthProperty = BindableProperty.Create(nameof(BorderWidth), typeof(float), typeof(BoxFrame), 0.5f);

        public float BorderWidth
        {
            get
            {
                return (float)GetValue(BorderWidthProperty);
            }
            set
            {
                SetValue(BorderWidthProperty, value);
            }
        }

        public static BindableProperty BorderColorProperty = BindableProperty.Create(nameof(BorderColor), typeof(Color), typeof(BoxFrame), Color.Accent);

        public Color BorderColor
        {
            get
            {
                return (Color)GetValue(BorderColorProperty);
            }
            set
            {
                SetValue(BorderColorProperty, value);
            }
        }
    }
}
