using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thriftify
{
    internal class Order
    {
        private int UserID;
        private int ProductID;
        private int Quantity;

        public Order(int userID, int productID, int quantity)
        {
            UserID = userID;
            ProductID = productID;
            Quantity = quantity;
        }

        public bool PlaceOrder()
        {
            // Implement placing order logic
            return true;
        }
    }
}
