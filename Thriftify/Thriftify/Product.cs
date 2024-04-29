using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thriftify
{
    internal class Product
    {
        private string Name;
        private double Price;
        private string Description;
        private string Category;
        private int Inventory;

        public Product(string name, double price, string description, string category, int inventory)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
            Inventory = inventory;
        }

        public bool AddToInventory()
        {
            bool updateSuccessful = UpdateInventoryInDatabase();

            if (updateSuccessful)
            {
                Console.WriteLine($"Product '{Name}' added to inventory successfully!");
                return true;
            }
            else
            {
                Console.WriteLine($"Error adding product '{Name}' to inventory. Please try again later.");
                return false;
            }
            return true;
        }

        public bool Update()
        {
            // Implement product update logic
            return true;
        }

        public bool Delete()
        {
            // Implement product deletion logic
            return true;
        }
    }
}
