class Order
{
    private Customer _customer;
    private Address _address;
    private List<Product> _products;

    public Order(Customer customer, Address address, List<Product> products)
    {
        _customer = customer;
        _address = address;
        _products = products;
    }

    public int TotalPriceCalculation()
    {
        int total = 0;

        foreach (Product p in _products)
        {
            total += p.TotalProductCost();
        }

        total += _address.UsaOrNot() ? 5 : 35;

        return total;
    }

    public void PackingLabel()
    {
        foreach (Product p in _products)
        {
            Console.WriteLine($"Product name: {p.GetName()}, Product ID: {p.GetProductID()}");
        }
    }

    public void ShippingLabel()
    {
        Console.WriteLine($"Customer Name: {_customer.GetName()}");
        Console.WriteLine($"Address:\n{_customer.GetAddress().GetAddress()}");
    }
}