using System;
using Xamarin.Forms;

namespace soletechs.ViewModels
{
    public class ServiceConfigViewModel : BaseViewModel
    {
        public ServiceConfigViewModel()
        {
            Title = "Service Configuration";
            Image = UriImageSource.FromUri(new Uri("http://upload.wikimedia.org/wikipedia/commons/e/ed/Saguinus_tripartitus_-_Golden-mantled_Tamarin.jpg"));
        }

        string companyName = string.Empty;
        public string CompanyName
        {
            get { return companyName; }
            set { SetProperty(ref companyName, value); }
        }

        string companyPassword = string.Empty;
        public string CompanyPassword
        {
            get { return companyPassword; }
            set { SetProperty(ref companyPassword, value); }
        }

        private ImageSource image;

        public ImageSource Image
        {
            get { return image; }
            set { SetProperty(ref image, value); }
        }

    }
}
