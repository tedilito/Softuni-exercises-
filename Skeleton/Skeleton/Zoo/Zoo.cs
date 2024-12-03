using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Zoo
{
    public class Zoo
    {
        public Zoo(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Animals = new List<Animal>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Animal> Animals { get; set; }


        public string AddAnimal(Animal animal)
        {
            if (string.IsNullOrWhiteSpace(animal.Species))
            {
                return "Invalid animal species.";
            }
            else if (animal.Diet != "herbivore" && animal.Diet != "carnivore")
            {
                return "Invalid animal diet.";
            }
            else if (Animals.Count >= Capacity)
            {
                return "The zoo is full.";
            }
            else
            {
                Animals.Add(animal);
                return $"Successfully added {animal.Species} to the zoo.";
            }
        }
        public int RemoveAnimals(string species)
        {
            return Animals.RemoveAll(a => a.Species == species);
        }
        public List<Animal> GetAnimalsByDiet(string diet)
        {
            return Animals.FindAll(x => x.Diet == diet);
        }
        public Animal GetAnimalByWeight(double weight)
        {
            return Animals.Where( a => a.Weight == weight).FirstOrDefault(); 
        }
        public string GetAnimalCountByLength(double minimumLength, double maximumLength)
        {
           int num = Animals.Where(x => x.Length >= minimumLength && x.Length <= maximumLength).Count();
            return $"There are {num} animals with a length between {minimumLength} and {maximumLength} meters.";
        }

    }
}
