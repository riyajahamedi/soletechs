using System;
using System.Collections.Generic;
using System.Text;

namespace soletechs.Models.Profile
{
    public class BankInfoModel: BaseModel
    {
        private string bankName;

        public string BankName
        {
            get { return bankName; }
            set { bankName = value; }
        }

        private string accountNumber;

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        private string code;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        private string iban;

        public string Iban
        {
            get { return iban; }
            set { iban = value; }
        }

        private string swiftCode;

        public string SwiftCode
        {
            get { return swiftCode; }
            set { swiftCode = value; }
        }
    }
}
