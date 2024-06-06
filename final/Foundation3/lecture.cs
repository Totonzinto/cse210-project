using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    // Constructor to initialize the lecture with additional speaker and capacity
    public Lecture(string title, string description, DateTime date, DateTime time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    // Method to get full details of the lecture
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}