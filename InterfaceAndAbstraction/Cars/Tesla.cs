using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Tesla : BaseCar, ICar, IElectricCar
    {
        public Tesla(string model, string color, int battery) : base(model, color)
        {
            this.Battery = battery;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Color} {this.GetType().Name} {this.Model} with {this.Battery} Batteries");
            sb.AppendLine(this.Start());
            sb.Append(this.Stop());
            return sb.ToString().TrimEnd();
        }

        public int Battery { get; }
    }
}
