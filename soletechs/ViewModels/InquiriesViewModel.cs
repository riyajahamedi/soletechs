using System;
using System.Collections.Generic;
using System.Text;

namespace soletechs.ViewModels
{
    public class InquiriesViewModel:BaseViewModel
    {
        public InquiriesViewModel():base()
        {
            this.Title = "Inquiries";
        }

        protected override string GetCurrentIcon()
        {
            return IsSelected ? "inquiries.png" : "inquiries_inactive.png";
        }
    }
}
