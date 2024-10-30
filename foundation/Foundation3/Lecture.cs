using System;

namespace EventPlanning
{
    public class Lecture : Event
    {
        private string speaker;
        private int capacity;

        public Lecture(string title, string description, DateTime date, string time, Address address, string speaker, int capacity)
            : base(title, description, date, time, address)
        {
            this.speaker = speaker;
            this.capacity = capacity;
        }

        public string Speaker { get => speaker; }
        public int Capacity { get => capacity; }

        public override string GetFullDetails()
        {
            return $"{base.GetFullDetails()}\nSpeaker: {speaker}\nCapacity: {capacity}\n";
        }
    }
}