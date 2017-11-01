using System;
using System.Collections.Generic;
using System.Text;

namespace soletechs.ViewModels
{
    public class NotificationViewModel : BaseViewModel
    {
        public NotificationViewModel() : base()
        {
            this.Title = "Notifications";
            this.Notifications = new string[] { "Test", "Test" };
        }

        protected override string GetCurrentIcon()
        {
            return IsSelected? "notification.png": "notification_inactive.png";
        }

        private string[] notification;

        public string[] Notifications
        {
            get { return notification; }
            set { SetProperty(ref notification, value); }
        }
    }
}
