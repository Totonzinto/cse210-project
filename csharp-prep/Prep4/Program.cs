using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Initialize an empty list
        List<int> numbers = new List<int>();

        // Ask the user for a series of numbers
        while (true)
        {
            Console.Write("Enter a number (0 to stop): ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 0)
            {
                break;
            }
            numbers.Add(num);
        }

        // Compute the sum, average, and max of the numbers in the list
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        double average = (double)total / numbers.Count;
        int maxNum = numbers.Max();
        // Print the results
        Console.WriteLine("Sum: " + total);
        Console.WriteLine("Average: " + average);
        Console.WriteLine("Max: " + maxNum);
    }
}



