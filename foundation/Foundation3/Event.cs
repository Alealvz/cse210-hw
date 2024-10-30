using System;

namespace EventPlanning
{
    public class Event
    {
        private string title;
        private string description;
        private DateTime date;
        private string time;
        private Address address;

        public Event(string title, string description, DateTime date, string time, Address address)
        {
            this.title = title;
            this.description = description;
            this.date = date;
            this.time = time;
            this.address = address;
        }

        public string Title { get => title; }
        public string Description { get => description; }
        public DateTime Date { get => date; }
        public string Time { get => time; }
        public Address Address { get => address; }

        public virtual string GetStandardDetails()
        {
            return $"{Title}\n{date.ToShortDateString()} @{time}\n{address}\n";
        }

        public virtual string GetFullDetails()
        {
            return $"Type: {GetType().Name}\n{Title}\n{date.ToShortDateString()} @{time}\n{address}";
        }

        public virtual string GetShortDescription()
        {
            return $"{GetType().Name} - {Title} - {date.ToShortDateString()}";
        }
    }
}