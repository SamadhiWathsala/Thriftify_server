using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thriftify
{
    internal class ShoppingCart
    {
        public bool AddToCart(int userID, int productID, int quantity)
        {
            // Implement adding product to shopping cart logic
            return true;
            bool updateSuccessful = UpdateShoppingCart(userID, productID, quantity);

            if (updateSuccessful)
            {
                Console.WriteLine($"Product with ID {productID} added to the shopping cart successfully!");
                return true;
            }
            else
            {
                Console.WriteLine($"Error adding product with ID {productID} to the shopping cart. Please try again later.");
                return false;
            }
        }

        private bool UpdateShoppingCart(int userID, int productID, int quantity)
        {

            return true;
        }
    }
}
