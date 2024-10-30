using System;

namespace EventPlanning
{
    public class Reception : Event
    {
        private string email;

        public Reception(string title, string description, DateTime date, string time, Address address, string email)
            : base(title, description, date, time, address)
        {
            this.email = email;
        }

        public string Email { get => email; }

        public override string GetFullDetails()
        {
            return $"{base.GetFullDetails()}\nRSVP Email: {email}\n";
        }
    }
}