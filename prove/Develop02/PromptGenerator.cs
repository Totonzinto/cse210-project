

using System.Collections.Generic;
public class PromptGenerator

{
    private List<string> prompts = new List<string>()
    {
        
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "What am I grateful for today?",
        "What's something I'm looking forward to tomorrow?",
        "What's something I've been putting off that I need to do?",
        "What's something I'm proud of accomplishing recently?",
        "What's something I need to work on in my life?"
    };

    public string GetRandomPrompt()
    {
        var random = new Random();
        return prompts.ElementAt(random.Next(prompts.Count));
    }
}
