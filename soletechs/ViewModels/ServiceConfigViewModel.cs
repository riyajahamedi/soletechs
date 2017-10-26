using System;
namespace soletechs.ViewModels
{
    public class ServiceConfigViewModel:BaseViewModel
    {
        public ServiceConfigViewModel()
        {
            Title= "Service Configuration";
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
    }
}
