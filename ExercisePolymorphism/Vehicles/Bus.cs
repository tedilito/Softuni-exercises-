using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(double fuel, double fuelConsumption, double tankCapacity) : base(fuel, fuelConsumption, tankCapacity)
        {
        }

       
        public void IsEmpty(bool empty, double distance)
        {
            if (empty)
            {
                this.FuelConsumption += 1.4; 
            }
            this.Drive(distance);
            this.FuelConsumption -= 1.4;

        }

    }
}
