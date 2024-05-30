using System;
using System.Threading.Tasks;


//No member variable or method to track frquency
public abstract class Activity
{
    protected string name; // Name of the activity
    protected string description; // Description of the activity
    protected int duration; // Duration of the activity in seconds

    // Constructor to initialize name and description
    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    // Method to start the activity
    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Starting {name}");
        Console.WriteLine(description);
        Console.Write("Enter the duration of the activity in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(5); // Pause for 5 seconds before starting
        RunActivity();
        End();
    }

    // Abstract method to run the specific activity
    protected abstract void RunActivity();

    // Method to end the activity
    protected void End()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {name} for {duration} seconds.");
        ShowSpinner(3); // Pause for 3 seconds after ending
    }

    // Method to show a spinner animation
    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Task.Delay(1000).Wait();
        }
        Console.WriteLine();
    }
}