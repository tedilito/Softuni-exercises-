using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Person
    {

        private string name;
        private int age;
        private List<Person> persons = new List<Person>();

        public List<Person> Persons
        {
            get { return  persons = new List<Person>(); }
            set {  persons =  value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }

        public Person(int age) : this()
        {
            this.Age = age;
        }
        public Person(string name, int age) : this(age)
        {
            this.Name = name;


        }

    }
}
