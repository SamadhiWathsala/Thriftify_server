using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thriftify
{
    internal class UserDatabase:Database
    {
        public bool AuthenticateUser(string username, string password)
        {


            var validUsers = new Dictionary<string, string>
        {
            { "alice", "password123" },
            { "bob", "securepass" },
            // Add more valid users here
        };

            if (validUsers.ContainsKey(username) && validUsers[username] == password)
            {
                Console.WriteLine($"User '{username}' authenticated successfully!");
                return true;
            }
            else
            {
                Console.WriteLine($"Authentication failed for user '{username}'. Invalid credentials.");
                return false;
            }
        }
    }
}
