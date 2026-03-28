using System.Globalization;

public class Product
{
    private string _name;
    private string _productID;
    private double _pricePerUnit;
    private int _quantityOfProduct;

    public Product(string name, string id, double price)
    {
        _name = name;
        _productID = id;
        _pricePerUnit = price;
    }
    public void SetQuantity(int quantity)
    {
        _quantityOfProduct = quantity;
    }
    public string GetProduct()
    {
        // (The Order class will need these to build the Packing Label).
        return $"{_name}  ID: {_productID}";
    }

    public double TotalCost()
    {
        // this just calculates the cost
        return _pricePerUnit * _quantityOfProduct;
    }
}

