using System;
using System.Collections.Generic;
using System.Text;

namespace soletechs.Models.Profile
{
    public class JobInfoModel: BaseModel
    { 
        private string positionId;

        public string PositionID
        {
            get { return positionId; }
            set { positionId = value; }
        }

        private string positionDescription;

        public string PositionDescription
        {
            get { return positionDescription; }
            set { positionDescription = value; }
        }

        private string department;

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        private string jobType;

        public string JobType
        {
            get { return jobType; }
            set { jobType = value; }
        }

        private string compensationRegion;

        public string CompensationRegion
        {
            get { return compensationRegion; }
            set { compensationRegion = value; }
        }

        private string managerName;

        public string ManagerName
        {
            get { return managerName; }
            set { ManagerName = value; }
        }

        private string managerPosition;

        public string ManagerPosition
        {
            get { return managerPosition; }
            set { ManagerPosition = value; }
        }

        private string jobId;

        public string JobID
        {
            get { return jobId; }
            set { jobId = value; }
        }

        private string jobFunction;

        public string JobFunction
        {
            get { return jobFunction; }
            set { jobFunction = value; }
        }
    }
}
