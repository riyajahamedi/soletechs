namespace soletechs.ViewModels
{
    public class LoginViewModel: BaseViewModel
    {
        public LoginViewModel(string companyName):base()
        {
            Title = "Login";
            CompanyName = companyName;
        }

        string userID = string.Empty;
        public string UserID
        {
            get { return userID; }
            set { SetProperty(ref userID, value); }
        }

        string password = string.Empty;
        public string PassWord
        {
            get { return password; }
            set { SetProperty(ref password, value); }
        }

        string companyName = string.Empty;
        public string CompanyName
        {
            get { return companyName; }
            set { SetProperty(ref companyName, value); }
        }
    }
}
