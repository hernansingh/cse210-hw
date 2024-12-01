class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Laptop", 1, 1000, 1);  // 1 unidad a $1000
        Product product2 = new Product("Smartphone", 2, 500, 2);  // 2 unidades a $500 cada una
        Product product3 = new Product("Headphones", 3, 150, 3);  // 3 unidades a $150 cada una

        Address address = new Address("123 Main St", "Los Angeles", "CA", "USA");

        Customer customer = new Customer("John Doe", address);

        List<Product> products = new List<Product> { product1, product2, product3 };

        Order order = new Order(customer, address, products);

        int totalPrice = order.TotalPriceCalculation();
        Console.WriteLine($"Total Price: ${totalPrice}");

        Console.WriteLine("\nPacking Label:");
        order.PackingLabel();

        Console.WriteLine("\nShipping Label:");
        order.ShippingLabel();
    }
}