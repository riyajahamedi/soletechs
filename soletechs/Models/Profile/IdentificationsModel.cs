using System;
using System.Collections.Generic;
using System.Text;

namespace soletechs.Models.Profile
{
    public class IdentificationsModel:BaseModel
    {
        private string number;

        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private string issueDate;

        public string IssueDate
        {
            get { return issueDate; }
            set { issueDate = value; }
        }

        private string endDate;

        public string EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        private int focous;

        public int Facous
        {
            get { return focous; }
            set { focous = value; }
        }

        private string agency;

        public string Agency
        {
            get { return agency; }
            set { agency = value; }
        }
    }
}
