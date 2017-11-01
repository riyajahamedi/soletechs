using System;
using System.Collections.Generic;
using System.Text;

namespace soletechs.ViewModels
{
    public class ApprovalViewModel : BaseViewModel
    {
        public ApprovalViewModel():base()
        {
            this.Title = "Approvals";
        }

        protected override string GetCurrentIcon()
        {
            return IsSelected ? "approval.png" : "approval_inactive.png";
        }
    }
}
