
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Tires
    {
		private int age;
        private double pressure;

        public int Age
		{
			get { return age; }
			set { age = value; }
		}

		public double Pressure
		{
			get { return pressure; }
			set { pressure = value; }
		}

        public Tires(double pressure, int age)
        {
            this.Pressure = pressure;
			this.Age = age;
        }

    }
}
