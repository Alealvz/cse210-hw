using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description) : base(name, description)
    {
        _prompts = new List<string>
        {
            "--Think of a time when you stood up for someone else.--",
            "--Think of a time when you did something really difficult.--",
            "--Think of a time when you helped someone in need.--",
            "--Think of a time when you did something truly selfless.--"
        };

        _questions = new List<string>
        {
            "--Why was this experience meaningful to you?--",
            "--Have you ever done anything like this before?--",
            "--How did you get started?--",
            "--How did you feel when it was complete?--",
            "--What made this time different than other times when you were not as successful?--",
            "--What is your favorite thing about this experience?--",
            "--What could you learn from this experience that applies to other situations?--",
            "--What did you learn about yourself through this experience?--",
            "--How can you keep this experience in mind in the future?--"
        };
    }

    public override void Run()
    {
        DisplayStartingMessage(); // Display the starting message
        Console.Write("\nEnter duration in seconds: ");
        if (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
            return;
        }

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\nStarting {_name} Activity");
        ShowCountDown(5);

        Console.WriteLine("......................");
        Console.ResetColor();
        DisplayPrompt();

        // Add spinner after the prompt
        Task.Run(() =>
        {
            while (true)
            {
                ShowSpinner(1);
                Thread.Sleep(100); // Adjust the spinner speed if needed
                Console.Write('\b'); // Clear the previous character
                Console.Write('\b'); // Move the cursor back again
                if (Console.KeyAvailable && Console.ReadKey().Key == ConsoleKey.Enter)
                    break;
            }
        });

        // Wait for user to press Enter
        Console.ReadLine();

        Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("\nNow ponder on each of the following questions as they are related to this experience:");

        DateTime startTime = DateTime.Now;
        foreach (var question in _questions)
        {
            if ((DateTime.Now - startTime).TotalSeconds > _duration)
                break;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(question);
            Console.ResetColor();
            Console.ReadLine();
        }

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("......................");

        DisplayEndingMessage();
        
        // Show spinner for 5 seconds after ending message
        Console.WriteLine("Loading main menu...");
        ShowSpinner(5);
        Console.ResetColor();
    }

    private void DisplayPrompt()
    {
        Console.Write("Consider the following prompt: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);
        Console.ResetColor();
    }

    private void DisplayQuestions()
    {
        foreach (var question in _questions)
        {
            Console.WriteLine(question);
            Console.ReadLine();
        }
    }
}