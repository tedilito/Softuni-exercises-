using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {

        private List<T> list;
        private int index = 0;
        public ListyIterator(List<T> list)
        {
            this.list = list;
        }

        public void Create(params T[] values)
        {
            list = new List<T>(values.ToList());
        }

        public bool Move()
        {
            if (index + 1 < list.Count)
            {
                index++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasNext()
        {
            if (index + 1 < list.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Print()
        {
            if (index >= list.Count)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(list[index]);
            }


        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in list)
            {
                yield return item;
            }
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
