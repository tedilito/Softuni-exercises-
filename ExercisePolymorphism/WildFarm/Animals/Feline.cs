using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Animals
{
    public class Feline : Mammal
    {
        public Feline(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion)
        {
            this.Breed = breed;
        }
        public string Breed { get; set; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
