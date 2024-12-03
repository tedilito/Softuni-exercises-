using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Animals
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override string ProduceSoung()
        {
            return "Woof!";
        }

        public override void Eat(int quantity)

        {
            this.FoodEaten += quantity;
            this.Weight += quantity * 0.40;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
