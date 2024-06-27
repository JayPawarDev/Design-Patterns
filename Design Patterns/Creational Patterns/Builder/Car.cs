using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational_Patterns.Builder
{
    public class Car
    {
        public string Name { get; private set; }
        public string Brand { get; private set; }
        public string Color { get; private set; }
        public string Type { get; private set; }
        public float Weight { get; private set; }
        public float Height { get; private set; }
        public int NumberOfSeats { get; private set; }

        private Car() { }
        private Car(CarBuilder builder)
        {
            //Validations
            if (String.IsNullOrEmpty(builder.Name)) { throw new ArgumentNullException("Name is required"); }
            if (builder.NumberOfSeats > 8 || builder.NumberOfSeats < 1) { throw new InvalidDataException("Invalid number of seats"); }


            this.Name = builder.Name;
            this.Brand = builder.Brand;
            this.Color = builder.Color;
            this.Type = builder.Type;
            this.Weight = builder.Weight;
            this.Height = builder.Height;
            this.NumberOfSeats = builder.NumberOfSeats;
        }
        public static CarBuilder GetCarBuilder()
        {
            return new CarBuilder();
        }
        public class CarBuilder
        {
            public string Name { get; private set; }
            public string Brand { get; private set; }
            public string Color { get; private set; }
            public string Type { get; private set; }
            public float Weight { get; private set; }
            public float Height { get; private set; }
            public int NumberOfSeats { get; private set; }

            public CarBuilder setName(string name)
            {
                this.Name = name;
                return this;
            }
            public CarBuilder setBrand(string brand)
            {
                this.Brand = brand;
                return this;
            }
            public CarBuilder setColor(string color)
            {
                this.Color = color;
                return this;
            }
            public CarBuilder setType(string type)
            {
                this.Type = type;
                return this;
            }
            public CarBuilder setWeight(float weight)
            {
                this.Weight = weight;
                return this;
            }
            public CarBuilder setHeight(float height)
            {
                this.Height = height;
                return this;
            }
            public CarBuilder setNumberOfSeats(int numberOfSeats)
            {
                this.NumberOfSeats = numberOfSeats;
                return this;
            }
            public Car Build()
            {
                return new Car(this);
            }
        }
    }
}
