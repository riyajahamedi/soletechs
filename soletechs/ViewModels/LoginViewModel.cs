namespace soletechs.ViewModels
{
    public class LoginViewModel: BaseViewModel
    {
        public LoginViewModel():base()
        {
            this.Title = "Login";
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
    }
}
