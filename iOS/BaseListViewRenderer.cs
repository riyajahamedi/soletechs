using UIKit;
using Xamarin.Forms.Platform.iOS;
using soletechs.CustomViews;
using soletechs.iOS;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(BaseListView), typeof(BaseListViewRenderer))]
namespace soletechs.iOS
{
    public class BaseListViewRenderer: ListViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<ListView> e)
        {
            base.OnElementChanged(e);

            if (this.Control == null) return;

            this.Control.TableFooterView = new UIView();
        }
    }
}