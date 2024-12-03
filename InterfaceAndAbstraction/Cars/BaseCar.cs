using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public abstract class BaseCar : ICar
    {
        protected BaseCar(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public string Model { get; }

        public string Color {  get; }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Color} {this.GetType().Name} {this.Model}");
            sb.AppendLine(this.Start());
            sb.Append(this.Stop());
            return sb.ToString().TrimEnd();
        }
    }
}
