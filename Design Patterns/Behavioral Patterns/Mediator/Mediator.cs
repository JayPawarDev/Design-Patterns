namespace Design_Patterns.Behavioral_Patterns.Mediator
{
    internal interface IMediator
    {
        void Register(ICab cab);
        void BookCab(IPassenger passenger);
    }
    internal class Mediator : IMediator
    {
        private readonly Dictionary<string, ICab> _cabs = new Dictionary<string, ICab>();
        public void BookCab(IPassenger passenger)
        {
            foreach(var cab in _cabs.Values.Where(c => c.IsAvailable))
            {
                if(IsWithin5Km(cab.CurrentLocation, passenger.Location))
                {
                    cab.Assign(passenger.Name, passenger.Address);
                    passenger.Acknowledge(cab.Name);
                    return;
                }
            }
            Console.WriteLine($"No free Cab available currently for {passenger.Name}\n");

        }

        public void Register(ICab cab)
        {
            if (!_cabs.ContainsValue(cab))
            {
                _cabs.Add(cab.Name, cab);
            }
        }

        private bool IsWithin5Km(int cabLocation, int passengerLocation)
            => Math.Abs(cabLocation - passengerLocation) < 5;
    }
}
