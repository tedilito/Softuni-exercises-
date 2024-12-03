using System.Collections;
using System.Reflection;
using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main()
        {
            List<Tire[]> tiresCollection = new List<Tire[]>();
            string tireInput;
            while ((tireInput = Console.ReadLine()) != "No more tires")
            {
                var tireData = tireInput.Split().Select(double.Parse).ToArray();
                Tire[] tires = new Tire[tireData.Length / 2];
                for (int i = 0; i < tireData.Length; i += 2)
                {
                    int year = (int)tireData[i];
                    double pressure = tireData[i + 1];
                    tires[i / 2] = new Tire(year, pressure);
                }
                tiresCollection.Add(tires);
            }

         
            List<Engine> enginesCollection = new List<Engine>();
            string engineInput;
            while ((engineInput = Console.ReadLine()) != "Engines done")
            {
                var engineData = engineInput.Split().Select(double.Parse).ToArray();
                int horsePower = (int)engineData[0];
                double cubicCapacity = engineData[1];
                enginesCollection.Add(new Engine(horsePower, cubicCapacity));
            }

          
            List<Car> cars = new List<Car>();
            string carInput;
            while ((carInput = Console.ReadLine()) != "Show special")
            {
                var carData = carInput.Split();
                string make = carData[0];
                string model = carData[1];
                int year = int.Parse(carData[2]);
                double fuelQuantity = double.Parse(carData[3]);
                double fuelConsumption = double.Parse(carData[4]);
                int engineIndex = int.Parse(carData[5]);
                int tiresIndex = int.Parse(carData[6]);

                Engine engine = enginesCollection[engineIndex];
                Tire[] tires = tiresCollection[tiresIndex];

                cars.Add(new Car(make, model, year, fuelQuantity, fuelConsumption, engine, tires));
            }

            foreach (var car in cars.Where(c => c.Year > 2017 && c.Engine.HorsePower > 330 && c.Tires.Sum(t => t.Pressure) >= 9 && c.Tires.Sum(t => t.Pressure) <= 10))
            {
                
                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                double kmDriven = (car.FuelConsumption * 20) / 100;
                Console.WriteLine($"FuelQuantity: {(car.FuelQuantity - kmDriven):F1}");
            }


        }
    }
}