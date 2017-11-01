using System;
using Xamarin.Forms;

namespace soletechs.ViewModels
{
    public class ProfileViewModel: BaseViewModel
    {
        public ProfileViewModel() : base()
        {
            this.Title = "Profile";
            Image = UriImageSource.FromUri(new Uri("http://upload.wikimedia.org/wikipedia/commons/e/ed/Saguinus_tripartitus_-_Golden-mantled_Tamarin.jpg"));
        }

        private ImageSource image;

        public ImageSource Image
        {
            get { return image; }
            set { SetProperty(ref image, value); }
        }

        protected override string GetCurrentIcon()
        {
            return IsSelected ? "profile.png" : "profile_inactive.png";
        }
    }
}
