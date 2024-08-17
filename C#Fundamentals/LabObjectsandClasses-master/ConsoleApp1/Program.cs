using System;
using System.Collections.Generic;
using System.Linq;

class Truck
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Weight { get; set; }
}

class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int HorsePower { get; set; }
}

class Catalog
{
    public List<Truck> Trucks { get; set; }
    public List<Car> Cars { get; set; }

    public Catalog()
    {
        Trucks = new List<Truck>();
        Cars = new List<Car>();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Catalog catalog = new Catalog();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "end")
                break;

            string[] data = input.Split('/');
            string type = data[0];
            string brand = data[1];
            string model = data[2];

            if (type == "Car")
            {
                int horsePower = int.Parse(data[3]);
                catalog.Cars.Add(new Car { Brand = brand, Model = model, HorsePower = horsePower });
            }
            else if (type == "Truck")
            {
                int weight = int.Parse(data[3]);
                catalog.Trucks.Add(new Truck { Brand = brand, Model = model, Weight = weight });
            }
        }

        PrintCatalog(catalog);
    }

    static void PrintCatalog(Catalog catalog)
    {
        Console.WriteLine("Cars:");
        foreach (var car in catalog.Cars.OrderBy(c => c.Brand))
        {
            Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
        }

        Console.WriteLine("Trucks:");
        foreach (var truck in catalog.Trucks.OrderBy(t => t.Brand))
        {
            Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
        }
    }
}
