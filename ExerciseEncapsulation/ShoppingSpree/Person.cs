using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private int money;

        public Person(string name, int money)
        {
            if (money < 0)
                throw new ArgumentException("Money cannot be negative");
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Name cannot be empty");
            this.Money = money;
            this.Name = name;
        }

        public int Money
        {
            get { return money; }
            set { money = value; }
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
    }
}

