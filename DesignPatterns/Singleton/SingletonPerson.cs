using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SingletonPerson
    {
        private static  SingletonPerson instance = new SingletonPerson();
        public string Name { get; set; }
        private  SingletonPerson()
        {
            
           
        }


        public static SingletonPerson CreatePerson(string name)
        {
            instance.Name = name;
            return SingletonPerson.instance;
        }
    }
}
