using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSwapMethod
{
    public class Box<T> : IComparable<Box<T>> where T : IComparable<T>
    {
        public T Value { get; set; }

        public Box(T value)
        {
            Value = value;
        }

      
        public int CompareTo(Box<T> other)
        {
          
            return this.Value.CompareTo(other.Value);
        }

        public override string ToString()
        {
            return $"{typeof(T)}: {Value}";
        }
    }

}

