using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxOfString
{
    public class Box<T>
    {
        public Box(T value)
        {
            Value = value;
            myList = new List<T>();
        }

        public List<T>  myList{ get; set; }
        public T Value  { get; set; }

        public void Add()
        {
            myList.Add(Value);
        }
        public override string ToString()
        {
            for (int i = 0; i < myList.Count; i++)
            {
                T value = myList[i];
                return $"{typeof(T)}: {value}";
            }
            return " ";
        }
    }
}
