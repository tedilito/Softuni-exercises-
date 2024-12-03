using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Animals
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override string ProduceSoung()
        {
            return "Hoot Hoot";
        }

        public override void Eat(int quantity)
        {
            this.Weight += quantity * 0.25;
            this.FoodEaten += quantity;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
