using System;
using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description) { }

    public override void Run()
    {
        DisplayStartingMessage();

        Console.Write("\nEnter duration in seconds: ");
        if (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
            return;
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nStarting {_name} Activity");
        ShowCountDown(5);

        Console.WriteLine("......................");

        int totalTime = 0;
        while (totalTime < _duration)
        {
            Console.Write("Breathe in... ");
            Countdown(5);
            totalTime += 5;

            if (totalTime >= _duration) break;

            Console.Write("Breathe out... ");
            Countdown(5);
            totalTime += 5;
        }

        Console.WriteLine("......................");

        DisplayEndingMessage();
        
        // Show spinner for 5 seconds after ending message
        Console.WriteLine("Loading main menu...");
        ShowSpinner(5);
        Console.ResetColor();
    }

    private void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
            Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
        }
        ClearConsoleLine();
    }
}