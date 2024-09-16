namespace Design_Patterns.Behavioral_Patterns.Mediator
{
    internal interface IPassenger
    {
        string Name { get; }
        string Address { get; }
        int Location { get; set; }

        void Acknowledge(string name);
    }
    internal class Passenger : IPassenger
    {
        public Passenger(string name, string address, int location)
        {
            Name = name;
            Address = address;
            Location = location;
        }

        public string Name { get; }
        public string Address { get; }
        public int Location { get; set; }

        public void Acknowledge(string name)
        {
            Console.WriteLine($"Passenger {this.Name} acknowledges Cab: {name}\n");
        }
    }
}
