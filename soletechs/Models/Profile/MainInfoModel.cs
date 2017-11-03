using System;
using System.Collections.Generic;
using System.Text;

namespace soletechs.Models.Profile
{
    public class MainInfoModel: BaseModel
    {
        private string personalNumber;

        public string PersonalNumber
        {
            get { return personalNumber; }
            set { personalNumber = value; }
        }

        private string oldNumber;

        public string OldNumber
        {
            get { return oldNumber; }
            set { oldNumber = value; }
        }

        private string birthDate;

        public string BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        private string gender;

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        private string  maritalStatus;

        public string  MaritalStatus
        {
            get { return maritalStatus; }
            set { maritalStatus = value; }
        }

        private string joinDate;

        public string JoinDate
        {
            get { return joinDate; }
            set { joinDate = value; }
        }

        private string endDate;

        public string EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        private List<Address> address;

        public List<Address> Addresses
        {
            get { return address; }
            set { address = value; }
        }

        private List<Contact> contacts;

        public List<Contact> Contacts
        {
            get { return contacts; }
            set { contacts = value; }
        }

    }

    public class Address
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string area;

        public string Area
        {
            get { return area; }
            set { area = value; }
        }

        private string country;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }
    }

    public class Contact
    {
        private ContactType type;

        public ContactType Type
        {
            get { return type; }
            set { type = value; }
        }

        private string detail;

        public string Detail
        {
            get { return detail; }
            set { detail = value; }
        }

    }

    public enum ContactType
    {
        Mobile,
        Landline,
        Email
    }
}
