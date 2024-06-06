using System;

public class Reception : Event
{
    private string _rsvpEmail;

    // Constructor to initialize the reception with additional RSVP email
    public Reception(string title, string description, DateTime date, DateTime time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    // Method to get full details of the reception
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Reception\nRSVP Email: {_rsvpEmail}";
    }
}