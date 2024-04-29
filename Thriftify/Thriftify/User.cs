using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thriftify
{
    public abstract class User
    {
        protected string Name;
        protected string Gender;
        protected string Email;
        protected string Address;
        protected string Contact;
        protected string Password;

        public User(string name, string gender, string email, string address, string contact, string password)
        {
            Name = name;
            Gender = gender;
            Email = email;
            Address = address;
            Contact = contact;
            Password = password;
        }

        public abstract bool Register();
    }
}
