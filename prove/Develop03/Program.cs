using System;

class Program
{
    static void Main(string[] args)
    {
        var scripture = new Scripture(
            new ScriptureReference("John", 3, 16),
            "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."
        );

        while (true)
        {
            scripture.Display();
            Console.Write("Press enter or type 'quit': ");
            var input = Console.ReadLine();
            if (input.ToLower() == "quit") break;
            scripture.HideRandomWords();
        }
    }
}
