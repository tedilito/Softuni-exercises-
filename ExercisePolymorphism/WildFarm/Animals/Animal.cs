using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Animals
{
    public abstract class Animal
    {
        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
            FoodEaten = 0;
        }

        public string Name { get; }
        public double Weight { get; protected set; }
        public int FoodEaten { get; set; }

        public virtual string ProduceSoung()
        {
            return " ";
        }

        public virtual void Eat(int quantity)
        {
            this.FoodEaten += quantity;
        }

        
    }
}
