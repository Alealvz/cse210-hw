using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected static readonly Random random = new Random();
    protected bool isSpinnerRunning = true; // or initialize it to false if it should start as false


    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public abstract void Run();

    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"\n{_name} Activity");
        Console.WriteLine($"\n{_description}");
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine($"\nGood job! You have completed the {_name} Activity for {_duration} seconds.");
    }

    protected void ShowSpinner(int seconds)
    {
        string[] spins = { "|", "/", "-", "\\" };
        for (int i = 0; i < seconds * 10; i++)
        {
            if (!isSpinnerRunning)
                Console.Write("\b \b"); // Clear the previous character
            else
                Console.Write(spins[i % 4] + "\r");
            Thread.Sleep(100);
        }
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"Starting in: {i}\r");
            Thread.Sleep(1000);
        }
        ClearConsoleLine();
        Console.WriteLine("Go!");
    }

    protected void ClearConsoleLine()
    {
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, Console.CursorTop);
    }
}