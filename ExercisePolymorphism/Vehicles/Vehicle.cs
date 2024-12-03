using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        protected Vehicle(double fuel, double fuelConsumption, double tankCapacity)
        {
            Fuel = fuel;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
            if (Fuel > TankCapacity)
            {
                Fuel = 0;
            }
        }

        public double Fuel { get; protected set; }

        public virtual double FuelConsumption { get; protected set; }

        public double TankCapacity { get; protected set; }

        public bool Drive(double kmToDrive)
        {
            if (kmToDrive * FuelConsumption <= Fuel)
            {
                Console.WriteLine($"{this.GetType().Name} travelled {kmToDrive} km");
                Fuel -= kmToDrive * FuelConsumption;
                return true;
            }
            Console.WriteLine($"{this.GetType().Name} needs refueling");
            return false;
        }

        public virtual void Refuel(double liters)
        {

            if (this.Fuel + liters > TankCapacity)
            {
                if (this.GetType().Name == "Truck")
                {
                    liters /= 0.95;
                }
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
                return;
            }
             if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return;
            }
            this.Fuel += liters;
        }
    }
}
