using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Animals
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override string ProduceSoung()
        {
            return "ROAR!!!";
        }
        public override void Eat(int quantity)
        {
            this.FoodEaten += quantity;
            this.Weight += quantity *  1.00;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
