using Thriftify;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Buyer buyer = new Buyer("John", "Male", "john@example.com", "123 Street", "1234567890", "password");
        bool buyerRegistered = buyer.Register();

        Seller seller = new Seller("Jane", "Female", "jane@example.com", "456 Street", "9876543210", "password", "1234567890", "document_upload_path", "987654321", "bank_info");
        bool sellerRegistered = seller.Register();

        Product product = new Product("Product 1", 10.99, "Description", "Category", 100);
        bool addedToInventory = product.AddToInventory();

        Order order = new Order(1, 1, 2);
        bool orderPlaced = order.PlaceOrder();

        ShoppingCart cart = new ShoppingCart();
        bool addedToCart = cart.AddToCart(1, 1, 1);

        UserDatabase userDB = new UserDatabase();
        bool authenticated = userDB.AuthenticateUser("username", "password");

        ProductDatabase productDB = new ProductDatabase();
        bool productsSearched = productDB.SearchProducts("keyword");
    }
}