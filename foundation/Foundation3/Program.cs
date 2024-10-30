using System;
using EventPlanning;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York City", "NY", "USA");
        Address address2 = new Address("456 Elm St", "Los Angeles", "CA", "USA");
        Address address3 = new Address("789 Oak St", "London", "England", "UK");

        Lecture lecture = new Lecture("Introduction to AI", "Learn about artificial intelligence", new DateTime(2024, 6, 1), "10:00 AM", address1, "John Doe", 50);
        Reception reception = new Reception("Networking Mixer", "Meet and greet with professionals", new DateTime(2024, 6, 2), "7:00 PM", address2, "rsvp@example.com");
        Outdoor gathering = new Outdoor("Summer Picnic", "Enjoy food and games outdoors", new DateTime(2024, 6, 3), "12:00 PM", address3, "Sunny with a high of 75°F");

        // Display Lecture details
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine("===================================");

        // Display Reception details
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine("===================================");

        // Display Outdoor Gathering details
        Console.WriteLine(gathering.GetStandardDetails());
        Console.WriteLine(gathering.GetFullDetails());
        Console.WriteLine(gathering.GetShortDescription());
        Console.WriteLine("===================================");
    }
}