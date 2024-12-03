using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> persons = new List<Person>();
        public List<Person> Persons
        {
            get { return persons; }
            set { persons = value; }
        }
     


        public  void AddMember(Person member)
        {
            Persons.Add(member);
        }
        public Person GetOldestMember()
        {
           return this.Persons.MaxBy(p => p.Age);

        }



    }
}
