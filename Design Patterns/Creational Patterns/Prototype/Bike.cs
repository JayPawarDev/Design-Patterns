using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational_Patterns.Prototype
{
    public class Bike: Vehicle, IPrototype<Bike>
    {
        public string BikeType { get; set; }

        public Bike() { }
        public Bike(Bike b) : base(b)
        {
            this.BikeType = b.BikeType;
        }

        public override Bike Clone()
        {
            return new Bike(this);
        }

        public override void Output()
        {
            Console.WriteLine($"Bike: \nName: {this.Name}\nBrand: {this.Brand}\nFuel Type: {this.FuelType}\nBike Type: {this.BikeType}\n");
        }
    }
}
