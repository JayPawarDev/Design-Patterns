
namespace Design_Patterns.Creational_Patterns.Builder
{
    class Program
    {
        public static void Main(string[] args)
        {
            Car car1 = Car.GetCarBuilder()
                        .setName("Model X")
                        .setBrand("Tesla")
                        .setType("Sedan")
                        .setColor("Red")
                        .setNumberOfSeats(4)
                        .setHeight(5.81f)
                        .setWeight(150.45f)
                        .Build();


            Console.WriteLine($"Name: {car1.Name}\nBrand: {car1.Brand}\nSeats: {car1.NumberOfSeats}");
        }
    }
}
