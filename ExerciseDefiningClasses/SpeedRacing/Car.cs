using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    public class Car
    {
		private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelleddistance;

        public Car(string model, double fuleAmount, double fuelConsump)
        {
            this.model = model;
            this.fuelAmount = fuleAmount;
            this.Travelleddistance = 0;
            this.FuelConsumptionPerKilometer = fuelConsump;
        }

        public string  Model
		{
			get { return model; }
			set { model = value; }
		}

        public double FuelAmount
        {
            get { return fuelAmount; }
            set { fuelAmount = value; }
        }

        public double FuelConsumptionPerKilometer
        {
            get { return fuelConsumptionPerKilometer; }
            set { fuelConsumptionPerKilometer = value; }
        }

        public double Travelleddistance
        {
            get { return travelleddistance; }
            set { travelleddistance = value; }
        }

       public bool canTravel( string model, double amountOfKm)
        {
            double totalFuelConsumption = this.fuelConsumptionPerKilometer * amountOfKm;
            if (totalFuelConsumption <= this.fuelAmount)
            {
                this.fuelAmount -= totalFuelConsumption;
                this.travelleddistance += amountOfKm;
                return true;    
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
                return false;
            }

        }

    }
}
