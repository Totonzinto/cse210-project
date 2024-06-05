using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    // Constructor to initialize the order with a customer
    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    // Method to add a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Method to calculate the total cost of the order, including a shipping cost
    public double CalculateTotalCost()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalCost();
        }
        // Add shipping cost: $5 if in USA, otherwise $35
        total += _customer.IsInUSA() ? 5 : 35;
        return total;
    }

    // Method to generate the packing label, listing the name and product ID of each product
    public string GetPackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder();
        foreach (var product in _products)
        {
            packingLabel.AppendLine($"Product: {product.GetName()}, ID: {product.GetProductID()}");
        }
        return packingLabel.ToString();
    }

    // Method to generate the shipping label, listing the customer's name and address
    public string GetShippingLabel()
    {
        return $"Customer: {_customer.GetName()}\nAddress:\n{_customer.GetAddress().GetFullAddress()}";
    }
}