public class Product
{
    private string _name;
    private string _productID;
    private double _price;
    private int _quantity;

    // Constructor to initialize the product with a name, product ID, price, and quantity
    public Product(string name, string productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    // Method to calculate the total cost of the product (price per unit * quantity)
    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    // Method to get the product's name
    public string GetName()
    {
        return _name;
    }

    // Method to get the product's ID
    public string GetProductID()
    {
        return _productID;
    }
}