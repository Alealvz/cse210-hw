using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {// For "exceeding requirements" I added specific colors to each activity that are matching with the menu
        // and work along the activities as well. Also, created animation with spinner while loading the menu at the end of every activity.
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" -------------------------");
            Console.WriteLine("|****Activities'  Menu****|");
            Console.WriteLine(" -------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("|  1. Breathing Activity  |");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("| 2. Reflecting Activity  |");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("|   3. Listing Activity   |");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|         4. Quit         |");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" -------------------------");
            Console.Write("\n    Enter your choice: ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            string choice = Console.ReadLine();
            Console.ResetColor();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    breathingActivity.Run();
                    break;
                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    reflectingActivity.Run();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    listingActivity.Run();
                    break;
                case "4":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Exiting program...");
                    Console.ResetColor();
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    break;
            }
        }
    }
}