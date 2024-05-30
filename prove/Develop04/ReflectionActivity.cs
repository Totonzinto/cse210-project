using System;
using System.Threading.Tasks;

public class ReflectionActivity : Activity
{
    private string[] prompts = new string[]
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = new string[]
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") { }

    // Override method to run the reflection activity
    protected override void RunActivity()
    {
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine(prompt);
        ShowSpinner(5); // Pause for 5 seconds to think about the prompt

        int elapsed = 0;
        while (elapsed < duration)
        {
            string question = questions[rand.Next(questions.Length)];
            Console.WriteLine(question);
            ShowSpinner(5); // Pause for 5 seconds to reflect on the question
            elapsed += 5;
        }
    }
}