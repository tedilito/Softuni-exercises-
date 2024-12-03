using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }

        public Car(string model, Engine engine, string weight = "n/a", string color = "n/a")
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Model}:");
            sb.AppendLine(Engine.ToString());
            sb.AppendLine($"  Weight: {Weight}");
            sb.AppendLine($"  Color: {Color}");
            return sb.ToString().TrimEnd(); // Remove any trailing whitespace
        }
    }
}
