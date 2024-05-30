using System;

class Program

{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an activity: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Start();
                    break;
                case "2":
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.Start();
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Start();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
                    // No logic for tracking activity frequency
            }
        }
    }
}