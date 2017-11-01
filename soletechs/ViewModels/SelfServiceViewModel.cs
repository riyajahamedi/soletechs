using System;
using System.Collections.Generic;
using System.Text;

namespace soletechs.ViewModels
{
    public class SelfServiceViewModel: BaseViewModel
    {
        public SelfServiceViewModel(): base()
        {
            this.Title = "Self Services";
        }

        protected override string GetCurrentIcon()
        {
            return IsSelected ? "service.png" : "service_inactive.png";
        }
    }
}
