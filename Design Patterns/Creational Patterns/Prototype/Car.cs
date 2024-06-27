using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Design_Patterns.Creational_Patterns.Prototype
{
    public class Car : Vehicle,IPrototype<Car>
    {
        public int NumberOfDoors { get; set; }

        public Car(){ }
        public Car(Car c) : base(c)
        {
            this.NumberOfDoors = c.NumberOfDoors;
        }

        public override Car Clone()
        {
            return new Car(this);
        }

        public override void Output()
        {
            Console.WriteLine($"Car:\nName: {this.Name}\nBrand: {this.Brand}\nFuel Type: {this.FuelType}\nNumber Of Doors: {this.NumberOfDoors}\n");
        }
    }
}
