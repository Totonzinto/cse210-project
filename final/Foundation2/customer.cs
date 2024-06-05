public class Customer
{
    private string _name;
    private Address _address;

    // Constructor to initialize the customer with a name and address
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Method to check if the customer lives in the USA
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    // Method to get the customer's address
    public Address GetAddress()
    {
        return _address;
    }

    // Method to get the customer's name
    public string GetName()
    {
        return _name;
    }
}