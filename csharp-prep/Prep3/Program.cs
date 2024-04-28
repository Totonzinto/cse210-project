using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenator = new Random();
        int magicNumber = randomGenator.Next(1, 101);
        int guess;

        while (true)
        {
            Console.WriteLine("what is the magic number? ");
            guess = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());


            if (guess < magicNumber)
            {
                Console.WriteLine("Guess higher!");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Guess lower!");
            }
            else
            {
                Console.WriteLine("You guessed it! The magic number was " + magicNumber);
            break;
            }
        }
    }
}

