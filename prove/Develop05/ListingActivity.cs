using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description) : base(name, description)
    {
        _count = 0;
        _prompts = new List<string>
        {
            "Who are people that you appreciate?", "What are personal strengths of yours?",
            "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public override void Run()
    {
        DisplayStartingMessage();

        // Display "Enter duration in seconds" without the spinner
        Console.Write("\nEnter duration in seconds: ");
        if (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
            return;
        }

        Console.ForegroundColor = ConsoleColor.Blue; //Display text in Blue
        Console.WriteLine($"\nStarting {_name} Activity");
        ShowCountDown(5);

        Console.WriteLine("......................");

        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.ResetColor();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
                _count++; // Increment count for each item listed
        }

        Console.ForegroundColor = ConsoleColor.Blue; //Display text in Blue
        Console.WriteLine("......................");
        Console.WriteLine($"Number of items listed: {_count}");
        DisplayEndingMessage();

        // Show spinner for 5 seconds after ending message
        Console.WriteLine("Loading main menu...");
        ShowSpinner(5);
        Console.ResetColor();
    }

    private string GetRandomPrompt()
    {
        return _prompts[random.Next(_prompts.Count)];
    }
}