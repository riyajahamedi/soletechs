using Xamarin.Forms;

namespace soletechs.CustomViews
{
    public class MaterialButton:Button
    {
        public static BindableProperty ElevationProperty = BindableProperty.Create(nameof(Elevation), typeof(float), typeof(MaterialButton), 4.0f);

        public float Elevation
        {
            get
            {
                return (float)GetValue(ElevationProperty);
            }
            set
            {
                SetValue(ElevationProperty, value);
            }
        }
    }
}
