

namespace Design_Patterns.Creational_Patterns.Prototype
{
    public class Program
    {
        public static void FillRegistry(Registry reg)
        {
            Car ferrari = new Car();
            ferrari.Name = "Roma";
            ferrari.Brand = "Ferrari";
            ferrari.FuelType = "Petrol";
            ferrari.NumberOfDoors = 4;
            reg.Register("Roma", ferrari);
            
            Bike honda = new Bike();
            honda.Name = "Activa";
            honda.Brand = "Honda";
            honda.FuelType = "Electric";
            honda.BikeType = "Scooter";
            reg.Register("Activa", honda);
        }
        public static void Main(string[] args)
        {
            Registry reg = new Registry();

            FillRegistry(reg);

            Vehicle car = reg.GetClone("Roma");
            car.FuelType = "Diesel";

            Vehicle bike = reg.GetClone("Activa");
            car.FuelType = "Petrol";

            car.Output();
            bike.Output();

        }
    }
}
