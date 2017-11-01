using soletechs.CustomViews;
using soletechs.iOS;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Foundation;
using CoreGraphics;
using UIKit;
using System.Drawing;

[assembly: ExportRenderer(typeof(BoxFrame), typeof(BoxFrameRenderer))]
namespace soletechs.iOS
{
    public class BoxFrameRenderer: FrameRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Frame> e)
        {
            base.OnElementChanged(e);
            var elem = (BoxFrame)this.Element;
            if (elem != null)
            {

                // Border
                this.Layer.CornerRadius = (float)elem.CornerRadius;
                Layer.BorderColor = elem.BorderColor.ToCGColor();
                Layer.BorderWidth = (float)elem.BorderWidth;

                // Shadow
                this.Layer.ShadowColor = UIColor.DarkGray.CGColor;
                this.Layer.ShadowOpacity = 0.6f;
                this.Layer.ShadowRadius = 2.0f;
                this.Layer.ShadowOffset = new SizeF(0, 0);
            }
        }
    }
}
