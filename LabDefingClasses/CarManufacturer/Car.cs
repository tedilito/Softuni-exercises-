using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;



        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;

        }

        public Car(string make, string model, int years) : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = years;


        }

        public Car(string make, string model, int years, double fuelQuant, double fuelCons) : this(make, model, years)
        {
            this.FuelQuantity = fuelQuant;
            this.FuelConsumption = fuelCons;
        }
        public Car(string make, string model, int years, double fuelQuant, double fuelCons, Engine engine, Tire[] tires) : this(make, model, years, fuelQuant, fuelCons)
        {
            
            this.Engine = engine;
            this.Tires = tires;
        }

        public void Drive(double distance)
        {
            double result = FuelQuantity - distance * FuelConsumption;
            if (result <= 0) { Console.WriteLine("Not enough fuel to perform this trip!"); }
        }


        public string WhoAmI()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Make: {this.Make}");
            stringBuilder.AppendLine($" Model: {this.Model}");
            stringBuilder.AppendLine($"Year: {this.Year}");
            stringBuilder.AppendLine($"Fuel: {this.FuelQuantity:F2}");
            return stringBuilder.ToString();
        }

        public string Make
        {
            get { return make; }
            set { make = value; }
        }


        public string Model
        {
            get { return model; }
            set { model = value; }
        }



        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
          
        }

        public Tire[] Tires
        {
            get { return tires; }
            set { tires = value; }
        }


    }
}
