using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    public abstract class Individual : IIndividals
    {
        protected Individual(string name, string id)
        {
            Name = name;
            Id = id;
         
        }

        public string Name { get; }

        public string Id { get; }



        public int Age { get; }
    }
}
