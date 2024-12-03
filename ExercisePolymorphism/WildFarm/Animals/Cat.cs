using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Animals
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }
        public override string ProduceSoung()
        {
            return "Meow";
        }

        public override void Eat(int quantity)
        {
            this.Weight += quantity * 0.30;
            this.FoodEaten += quantity;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}

