using soletechs.Models;
using soletechs.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace soletechs.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : TabbedPage
    {
        private Page currentPage;
        public HomePage()
        {
            InitializeComponent();
            ToolbarItems.Add(new ToolbarItem("signout", "signout.png", () =>
            {
                SignOut();
            }, ToolbarItemOrder.Primary));
        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            if (currentPage != null)
                (currentPage.BindingContext as ITabIcon).IsSelected = false;
            if (this.CurrentPage != null)
            {
                this.Title = CurrentPage.Title;
                currentPage = CurrentPage;
                (currentPage.BindingContext as ITabIcon).IsSelected = true;
            }
        }

        private void SignOut()
        {
            var loginPage = new LoginPage();
            loginPage.BindingContext = new LoginViewModel("Test");
            Navigation.InsertPageBefore(loginPage, this);
            Navigation.PopAsync();
        }
    }
}