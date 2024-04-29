using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thriftify
{
    internal class Buyer:User
    {
        public Buyer(string name, string gender, string email, string address, string contact, string password)
        : base(name, gender, email, address, contact, password)
        {
        }

        public override bool Register()
        {     

            // Example: Save buyer details to a database
            bool registrationSuccessful = SaveBuyerToDatabase();

            if (registrationSuccessful)
            {
                Console.WriteLine("Buyer registration successful!");
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
