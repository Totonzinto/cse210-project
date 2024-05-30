using System;
using System.Threading.Tasks;

public class ListingActivity : Activity
{
    private string[] prompts = new string[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    // Override method to run the listing activity
    protected override void RunActivity()
    {
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine(prompt);
        ShowSpinner(5); // Pause for 5 seconds to think about the prompt

        Console.WriteLine("Start listing items:");
        int itemCount = 0;
        int elapsed = 0;
        while (elapsed < duration)
        {
            Console.Write("Item: ");
            Console.ReadLine(); // User enters an item
            itemCount++;
            elapsed += 5;
        }

        Console.WriteLine($"You listed {itemCount} items.");
    }
}