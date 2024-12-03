using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    public class Product
    {
        private string name;
        private int cost;

        public Product(string name, int cost)
        {
            if (cost < 0)
                throw new ArgumentException("Money cannot be negative");
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Name cannot be empty");

            this.name = name;
            this.cost = cost;
        }

        public string Name
        {
            get { return name; }
        }

        public int Cost
        {
            get { return cost; }
        }


    }
}
