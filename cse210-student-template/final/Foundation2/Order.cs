public class Order
{
    List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        // This makes sure that every order is attached to its person
        _customer = customer;
    }

    public void AddProduct(Product product, int quantity)
    {
        product.SetQuantity(quantity);
        _products.Add(product);
    }
    public double ShippingCost()
    {
        // if(IsUsa() == True or False) {the shipping cost varies then we add that to our total cost}
        double shipping = 0;

        if (_customer.IsInUSA() == true)
        {
           shipping += 5; 
        }
        else
        {
            shipping += 35; 
        }
        
        return shipping;
    
    }
    public double Total()
    {
        double total = 0;

        foreach (Product p in _products)
        {
            total += p.TotalCost();
        }
        total += ShippingCost();

        return Math.Round(total,2);
    }
    public string PackingLabel()
    {
        // this is where you return the name of the product and it's productID
        string label = "Packing Label\n\n";

        foreach(Product p in _products)
        {
            label += " - " + p.GetProduct() + "\n";
        }
        return label;
    }
    public string ShippingLabel()
    {
        // this is where you return the name of the customer and their address
        return _customer.GetAddress();
    }
    public string GetName()
    {
        return _customer.GetName();
    }

}
