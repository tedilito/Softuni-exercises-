using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityLogic
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

       
        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }

            Person other = (Person)obj;
            return this.Name == other.Name && this.Age == other.Age;
        }

        
        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Age);
        }

        public int CompareTo(Person other)
        {
            int result = this.Name.CompareTo(other.Name);
            if (result == 0)
            {
                result = this.Age.CompareTo(other.Age);
            }
            return result;
        }

       
        public override string ToString()
        {
            return $"{Name} {Age}";
        }
    }
}
