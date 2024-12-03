using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    public class Person
    {

        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < 650)
                {
                    throw new ArgumentException("Salary cannot be less than 650 leva!");
                }
                salary = value;
            }
        }

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            Age = age;
            LastName = lastName;
            FirstName = firstName;
            Salary = salary;
        }

        public int Age
        {
            get { return age; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
                age = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }
                lastName = value;
            }
        }

        public string FirstName
        {
            get { return firstName; }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
                firstName = value;
            }
        }

        public void IncreaseSalary(decimal percentage)
        {
            decimal increasedSalary = this.Salary * percentage / 100;
            if (this.Age < 30)
            {
                increasedSalary /= 2;
            }
            this.Salary += increasedSalary;
        }


        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.Salary:f2} leva.";
        }

    }
}
