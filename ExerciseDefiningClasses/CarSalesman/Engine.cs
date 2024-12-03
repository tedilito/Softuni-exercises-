using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    public class Engine
    {
        public string Model { get; set; }
        public int Power { get; set; }
        public string Displacement { get; set; }
        public string Efficiency { get; set; }

        public Engine(string model, int power, string displacement = "n/a", string efficiency = "n/a")
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"  {Model}:");
            sb.AppendLine($"    Power: {Power}");
            sb.AppendLine($"    Displacement: {Displacement}");
            sb.AppendLine($"    Efficiency: {Efficiency}");
            return sb.ToString().TrimEnd(); 
        }
    }

}

