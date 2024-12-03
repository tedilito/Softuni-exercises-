using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Animals
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }
        public override string ProduceSoung()
        {
            return "Squeak";
        }

        public override void Eat(int quantity)
        {
            this.Weight += quantity * 0.10;
            this.FoodEaten += quantity;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
