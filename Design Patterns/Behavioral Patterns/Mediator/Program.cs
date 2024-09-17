namespace Design_Patterns.Behavioral_Patterns.Mediator;

internal class Program
{
    public static void Main(string[] args)
    {
        var mediator = new Mediator();

        var cab1 = new Cab("Cab1", 5, true);
        var cab2 = new Cab("Cab2", 10, true);
        var cab3 = new Cab("Cab3", 2, false);

        mediator.Register(cab3);
        mediator.Register(cab1);
        mediator.Register(cab2);

        var ps1 = new Passenger("Bruce Wayne", "Gotham", 4);
        var ps2 = new Passenger("Peter Parker", "New York", 5);
        var ps3 = new Passenger("Harry Potter", "Hogwarts", 10);

        mediator.BookCab(ps1);
        mediator.BookCab(ps2);
        mediator.BookCab(ps3);

    }
}
