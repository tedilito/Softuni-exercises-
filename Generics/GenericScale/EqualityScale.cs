using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GenericScale
{
    public class EqualityScale<T>
    {

        public T leftElement { get; set; }
        public T rightElement { get; set; }

        public EqualityScale(T leftElement, T rightElement)
        {
            this.leftElement = leftElement;
            this.rightElement = rightElement;
        }

       public bool AreEqual()
        {
            return leftElement.Equals(rightElement);



        }

    }
}
