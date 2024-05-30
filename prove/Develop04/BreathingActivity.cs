using System;
using System.Threading.Tasks;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    // Override method to run the breathing activity
    protected override void RunActivity()
    {
        int elapsed = 0;
        while (elapsed < duration)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(3); // Pause for 3 seconds
            elapsed += 3;

            if (elapsed >= duration) break;

            Console.WriteLine("Breathe out...");
            ShowSpinner(3); // Pause for 3 seconds
            elapsed += 3;
        }
    }
}