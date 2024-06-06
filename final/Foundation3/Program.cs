using System;

class Program
{
    static void Main(string[] args)
    {
       // Create an Address
        Address address = new Address("123 Main St", "Anytown", "CA", "USA");

        // Create a Lecture event
        Lecture lecture = new Lecture("communication", "The importance of effective communication.", new DateTime(2024, 7, 10), new DateTime(2024, 7, 10, 18, 0, 0), address, "Dr. John Smith", 100);

        // Create a Reception event
        Reception reception = new Reception("Annual Gala", "A night to remember.", new DateTime(2024, 12, 31), new DateTime(2024, 12, 31, 20, 0, 0), address, "rsvp@company.com");

        // Create an Outdoor Gathering event
        OutdoorGathering outdoor = new OutdoorGathering("Summer BBQ", "Enjoy the summer with a BBQ.", new DateTime(2024, 8, 15), new DateTime(2024, 8, 15, 12, 0, 0), address, "Sunny and warm");

        // Print the details for each event
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor.GetShortDescription());
        Console.WriteLine();
    }
}