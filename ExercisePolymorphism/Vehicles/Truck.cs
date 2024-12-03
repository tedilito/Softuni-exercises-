using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuel, double fuelConsumption, double tankCapacity) : base(fuel, fuelConsumption, tankCapacity)
        {
        }

        
        public override double FuelConsumption => base.FuelConsumption + 1.6;

        public override void Refuel(double liters)
        {
            base.Refuel(liters * 0.95);
        }
    }
}
