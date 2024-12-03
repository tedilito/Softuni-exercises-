using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    public class Car
    {
		private string make;
		private string model;
		private int horsePower;
		private string registrationNumber;

		public string RegistrationNumber
		{
			get { return registrationNumber; }
			set { registrationNumber = value; }
		}

		public int HorsePower
		{
			get { return horsePower; }
			set { horsePower = value; }
		}

		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		public string Make
		{
			get { return make; }
			set { make = value; }
		}
        public Car(string make, string model, int hp, string regstrationNum)
        {
            this.Make = make;
			this.Model = model;
			this.HorsePower = hp;
			this.RegistrationNumber = regstrationNum;
        }
		public override string ToString()
		{
			StringBuilder	sb = new StringBuilder();
			sb.AppendLine($"Make: {this.Make}");
			sb.AppendLine($"Model: {this.Model}");
			sb.AppendLine($"HorsePower: {this.HorsePower}");
			sb.AppendLine($"RegistrationNumber: {this.RegistrationNumber}");
			return sb.ToString().Trim();
		}
    }
}
