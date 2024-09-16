namespace Design_Patterns.Behavioral_Patterns.Mediator
{
    internal interface ICab
    {
        string Name { get; }
        int CurrentLocation { get; set; }
        bool IsAvailable { get; set; }

        void Assign(string name, string address);
    }
    internal class Cab : ICab
    {
        public Cab(string name, int currentLocation, bool isAvailable)
        {
            Name = name;
            CurrentLocation = currentLocation;
            IsAvailable = isAvailable;
        }

        public string Name { get; }
        public int CurrentLocation { get; set; }
        public bool IsAvailable { get; set; }

        public void Assign(string name, string address)
        {
            IsAvailable = false;

            Console.WriteLine($"Cab: {this.Name} is assigned to Passenger: {name} at Location: {address}\n");
        }
    }
}
