using System.Numerics;

namespace Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVehicle car = null;
            Bus bus = null;
            IVehicle truck = null;
            for (int i = 0; i < 3; i++)
            {
                string[] vehicleInfo = Console.ReadLine().Split();
                double fuelQuantity = double.Parse(vehicleInfo[1]);
                double litersPerKm = double.Parse(vehicleInfo[2]);
                double tankCapacity = double.Parse(vehicleInfo[3]);

                switch (vehicleInfo[0])
                {

                    case "Car":
                        car = new Car(fuelQuantity, litersPerKm, tankCapacity);
                        break;

                    case "Bus":
                        bus = new Bus(fuelQuantity, litersPerKm, tankCapacity);
                        break;

                    case "Truck":
                        truck = new Truck(fuelQuantity, litersPerKm, tankCapacity);
                        break;
                }
            }


            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                switch (commands[0])
                {
                    case "Drive":
                        double distance = double.Parse(commands[2]);
                        if (commands[1] == "Car")
                        {
                            car.Drive(distance);

                        }
                        else if (commands[1] == "Truck")
                        {
                            truck.Drive(distance);
                        }
                        else
                        {
                            bus.IsEmpty(true, distance);
                            

                        }

                        break;

                    case "DriveEmpty":
                        double distance1 = double.Parse(commands[2]);
                        bus.Drive(distance1);

                        break;

                    case "Refuel":
                        double fuelToRefill = double.Parse(commands[2]);
                       
                        if (commands[1] == "Car")
                        {
                            car.Refuel(fuelToRefill);

                        }
                        else if (commands[1] == "Truck")
                        {
                            truck.Refuel(fuelToRefill);
                        }
                        else
                        {
                            bus.Refuel(fuelToRefill);
                        }
                        break;

                }
            }

            Console.WriteLine($"Car: {car.Fuel:F2}");
            Console.WriteLine($"Truck: {truck.Fuel:F2}");
            Console.WriteLine($"Bus: {bus.Fuel:F2}");
        }
    }
}
