using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Animals
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }
        public override string ProduceSoung()
        {
            return "Cluck";
        }

        public override void Eat(int quantity)
        {
            this.Weight += quantity * 0.35;
            this.FoodEaten += quantity;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
