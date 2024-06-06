using System;

public class OutdoorGathering : Event
{
    private string _weatherForecast;

    // Constructor to initialize the outdoor gathering with additional weather forecast
    public OutdoorGathering(string title, string description, DateTime date, DateTime time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    // Method to get full details of the outdoor gathering
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Outdoor Gathering\nWeather Forecast: {_weatherForecast}";
    }
}