using System;

public abstract class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private DateTime _time;
    private Address _address;

    // Constructor to initialize the event with title, description, date, time, and address
    public Event(string title, string description, DateTime date, DateTime time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    // Method to get standard details of the event
    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time.ToShortTimeString()}\nAddress:\n{_address.GetFullAddress()}";
    }

    // Abstract method to get full details of the event, to be implemented by derived classes
    public abstract string GetFullDetails();

    // Method to get short description of the event
    public string GetShortDescription()
    {
        return $"Type: {this.GetType().Name}\nTitle: {_title}\nDate: {_date.ToShortDateString()}";
    }
}