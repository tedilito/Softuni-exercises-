using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    public class Pet : IBirthIndividual
    {
        public Pet(string name, string birthdate)
        {
            Name = name;
            this.birthdate = birthdate;
        }

        public string Name { get; }
        public string birthdate { get;  }

       
    }
}
