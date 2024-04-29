using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thriftify
{
    internal class Seller:User
    {
        private string NIC;
        private string DocumentUpload;
        private string MobileNumber;
        private string BankInformation;

        public Seller(string name, string gender, string email, string address, string contact, string password, string nic, string documentUpload, string mobileNumber, string bankInformation)
            : base(name, gender, email, address, contact, password)
        {
            NIC = nic;
            DocumentUpload = documentUpload;
            MobileNumber = mobileNumber;
            BankInformation = bankInformation;
        }

        public override bool Register()
        {
            bool registrationSuccessful = SaveSellerToDatabase();

            if (registrationSuccessful)
            {
                Console.WriteLine("Seller registration successful!");
                return true;
            }
            else
            {
                Console.WriteLine("Error during registration. Please try again later.");
                return false;
            }
        }
    }
}
