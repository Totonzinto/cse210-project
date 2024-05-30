// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager(); // Initialize the GoalManager

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Eternal Quest Program");
            Console.WriteLine("1. Add Simple Goal");
            Console.WriteLine("2. Add Eternal Goal");
            Console.WriteLine("3. Add Checklist Goal");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Display Goals");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. Exit");
            Console.Write("Choose an option: ");
            
            if (!int.TryParse(Console.ReadLine(), out int choice)) // Validate input
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                Pause();
                continue;
            }

            switch (choice)
            {
                case 1:
                    AddSimpleGoal(goalManager); // Add a simple goal
                    break;
                case 2:
                    AddEternalGoal(goalManager); // Add an eternal goal
                    break;
                case 3:
                    AddChecklistGoal(goalManager); // Add a checklist goal
                    break;
                case 4:
                    RecordEvent(goalManager); // Record an event
                    break;
                case 5:
                    goalManager.DisplayGoals(); // Display all goals
                    Pause();
                    break;
                case 6:
                    SaveGoals(goalManager); // Save goals to a file
                    break;
                case 7:
                    LoadGoals(goalManager); // Load goals from a file
                    break;
                case 8:
                    return; // Exit the program
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    Pause();
                    break;
            }
        }
    }

    // Add a simple goal
    private static void AddSimpleGoal(GoalManager goalManager)
    {
        Console.Write("Enter the description of the simple goal: ");
        string description = Console.ReadLine();
        Console.Write("Enter the points for completing the goal: ");
        
        if (!int.TryParse(Console.ReadLine(), out int points)) // Validate points input
        {
            Console.WriteLine("Invalid input. Points should be a number.");
            Pause();
            return;
        }

        goalManager.AddGoal(new SimpleGoal(description, points)); // Add the simple goal to the manager
    }

    // Add an eternal goal
    private static void AddEternalGoal(GoalManager goalManager)
    {
        Console.Write("Enter the description of the eternal goal: ");
        string description = Console.ReadLine();
        Console.Write("Enter the points for each time the goal is recorded: ");
        
        if (!int.TryParse(Console.ReadLine(), out int points)) // Validate points input
        {
            Console.WriteLine("Invalid input. Points should be a number.");
            Pause();
            return;
        }

        goalManager.AddGoal(new EternalGoal(description, points)); // Add the eternal goal to the manager
    }

    // Add a checklist goal
    private static void AddChecklistGoal(GoalManager goalManager)
    {
        Console.Write("Enter the description of the checklist goal: ");
        string description = Console.ReadLine();
        Console.Write("Enter the points for each time the goal is recorded: ");
        
        if (!int.TryParse(Console.ReadLine(), out int points)) // Validate points input
        {
            Console.WriteLine("Invalid input. Points should be a number.");
            Pause();
            return;
        }

        Console.Write("Enter the target count to complete the goal: ");
        if (!int.TryParse(Console.ReadLine(), out int targetCount)) // Validate target count input
        {
            Console.WriteLine("Invalid input. Target count should be a number.");
            Pause();
            return;
        }

        Console.Write("Enter the bonus points for completing the goal: ");
        if (!int.TryParse(Console.ReadLine(), out int bonusPoints)) // Validate bonus points input
        {
            Console.WriteLine("Invalid input. Bonus points should be a number.");
            Pause();
            return;
        }

        goalManager.AddGoal(new ChecklistGoal(description, points, targetCount, bonusPoints)); // Add the checklist goal to the manager
    }

    // Record an event for a goal
    private static void RecordEvent(GoalManager goalManager)
    {
        Console.Write("Enter the description of the goal to record: ");
        string description = Console.ReadLine();
        goalManager.RecordEvent(description); // Record the event for the specified goal
    }

    // Save goals to a file
    private static void SaveGoals(GoalManager goalManager)
    {
        Console.Write("Enter the filename to save goals: ");
        string filename = Console.ReadLine();
        goalManager.SaveGoals(filename); // Save the goals to the specified file
    }

    // Load goals from a file
    private static void LoadGoals(GoalManager goalManager)
    {
        Console.Write("Enter the filename to load goals: ");
        string filename = Console.ReadLine();
        goalManager.LoadGoals(filename); // Load the goals from the specified file
    }

    // Pause the console to allow the user to read messages
    private static void Pause()
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}

public class ChecklistGoal(string description, int points, int targetCount, int bonusPoints) 
{
    private string description = description;
    private int points = points;
    private int targetCount = targetCount;
    private int bonusPoints = bonusPoints;
}

public class EternalGoal : SimpleGoal
{
    public EternalGoal(string description, int points) : base(description, points)
    {
    }
}

public class SimpleGoal
{
    private string description;
    private int points;

    public SimpleGoal(string description, int points)
    {
        this.description = description;
        this.points = points;
    }
}

public class GoalManager
{
    public void AddGoal(SimpleGoal simpleGoal)
    {
        //throw new NotImplementedException();
    }

    public void DisplayGoals()
    {
        throw new NotImplementedException();
    }

    public void LoadGoals(string filename)
    {
        //throw new NotImplementedException();
    }

    public void RecordEvent(string description)
    {
       // throw new NotImplementedException();
    }

    public void SaveGoals(string filename)
    {
        
        //throw new NotImplementedException();
    }

    public void AddGoal(ChecklistGoal checklistGoal)
    {
        //throw new NotImplementedException();
    }
}