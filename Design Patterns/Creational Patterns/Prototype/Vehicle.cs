using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational_Patterns.Prototype
{
    public class Vehicle : IPrototype<Vehicle>
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public string FuelType { get; set; }
        public Vehicle() { }
        public Vehicle(Vehicle v)
        {
            this.Name = v.Name;
            this.Brand = v.Brand;
            this.FuelType = v.FuelType;
        }
        public virtual Vehicle Clone()
        {
            return new Vehicle(this);
        }

        public virtual void Output()
        {
            Console.WriteLine($"Vehicle:\nName: {this.Name}\nBrand: {this.Brand}\nFuel Type: {this.FuelType} ");
        }
    }
}
