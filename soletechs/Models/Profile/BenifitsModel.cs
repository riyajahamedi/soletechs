using System;
using System.Collections.Generic;
using System.Text;

namespace soletechs.Models.Profile
{
    public class BenifitsModel: BaseModel
    {
        private string contractStartDate;

        public string ContractStartDate
        {
            get { return contractStartDate; }
            set { contractStartDate = value; }
        }

        private string contractEndDate;

        public string ContractEndDate
        {
            get { return contractEndDate; }
            set { contractEndDate = value; }
        }

        private string grade;

        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        private string salaryScale;

        public string SalaryScale
        {
            get { return salaryScale; }
            set { salaryScale = value; }
        }

        private string payGroup;

        public string PayGroup
        {
            get { return payGroup; }
            set { payGroup = value; }
        }

        private int basicSalary;

        public int BasicSalary
        {
            get { return basicSalary; }
            set { basicSalary = value; }
        }

        private int annualLeave;

        public int AnnualLeave
        {
            get { return annualLeave; }
            set { annualLeave = value; }
        }

        private int ticketNumber;

        public int TicketNumber
        {
            get { return ticketNumber; }
            set { ticketNumber = value; }
        }

        private int ticketRate;

        public int TicketRate
        {
            get { return ticketRate; }
            set { ticketRate = value; }
        }

        private string fromAirport;

        public string FromAirport
        {
            get { return fromAirport; }
            set { fromAirport = value; }
        }

        private string toAirport;

        public string ToAirport
        {
            get { return toAirport; }
            set { toAirport = value; }
        }

        private string ticketClass;

        public string TicketClass
        {
            get { return ticketClass; }
            set { ticketClass = value; }
        }

        private List<Allowences> allowances;

        public List<Allowences> Allowences
        {
            get { return allowances; }
            set { allowances = value; }
        }

    }

    public class Allowences
    {
        private string allowance;

        public string Allowance
        {
            get { return allowance; }
            set { allowance = value; }
        }

        private int percent;

        public int Percent
        {
            get { return percent; }
            set { percent = value; }
        }

        private int amount;

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
    }
}
