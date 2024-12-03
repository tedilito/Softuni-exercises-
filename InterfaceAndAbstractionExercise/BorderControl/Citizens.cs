using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    public class Citizens : Individual, IBirthIndividual, IBuyer, INamerAndAger
    {
        public int Age { get;}

        public string birthdate { get;  }

        public int Food { get; private set;  }

        public Citizens(string nameOrModel,int age, string id, string birthdate) : base(nameOrModel, id)
        {
            this.Age = age;
            this.birthdate = birthdate;
        }

        public void BuyFood()
        {
            Food += 10; 
        }
    }
}
