using System;

namespace EventPlanning
{
    public class Outdoor : Event
    {
        private string weather;

        public Outdoor(string title, string description, DateTime date, string time, Address address, string weather)
            : base(title, description, date, time, address)
        {
            this.weather = weather;
        }

        public string Weather { get => weather; }

        public override string GetFullDetails()
        {
            return $"{base.GetFullDetails()}\nWeather Forecast: {weather}\n";
        }
    }
}