using System;

class Program
{
    static void Main(string[] args)
    {
        
        // Create a list to hold different activities
        List<Activity> activities = new List<Activity>();

        // Add a Running activity to the list
        activities.Add(new Running(new DateTime(2024, 5, 1), 30, 3.0));

        // Add a Cycling activity to the list
        activities.Add(new Cycling(new DateTime(2024, 5, 2), 45, 15.0));

        // Add a Swimming activity to the list
        activities.Add(new Swimming(new DateTime(2024, 5, 3), 60, 40));

        // Iterate through the list and display the summary of each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}