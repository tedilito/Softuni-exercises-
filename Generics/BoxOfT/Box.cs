using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class Box<T>
    {
        private Stack<T> stack;
        public int Count
        {
            get
            { return stack.Count; }
        }

        public Box()
        {
            stack = new Stack<T>();
          
           
        }


        public void Add(T element)
        {
            stack.Push(element);
                
        }

        public T Remove()
        {
            
            return stack.Pop();
          
        }

    }
}
