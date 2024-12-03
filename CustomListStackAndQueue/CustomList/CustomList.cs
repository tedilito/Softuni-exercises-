
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CustomList
{
    public class CustomList<T>
    {
        private T[] buffer;

        public CustomList()
        {
            this.buffer = new T[4];
        }
        public CustomList(int capacity)
        {
            this.buffer = new T[capacity];
        }

        public int Count { get; set; }
        public T this[int index]
        {

            get
            {
                this.IsValidIndex(index); return this.buffer[index];
            }
            set 
            {
                this.IsValidIndex(index); this.buffer[index] = value;
            
            }
        }



        public void Add(T element)
        {
            if (this.Count == this.buffer.Length)
            {
                this.Grow();
            }

            this.buffer[this.Count] = element;
            this.Count++;

        }

        private void Grow()
        {
            T[] newBuffer = new T[this.buffer.Length * 2];
            Array.Copy(this.buffer, newBuffer, this.Count);
            this.buffer = newBuffer;
        }

        public T RemoveAt(int index)
        {
            this.IsValidIndex(index);
            T removedElement = this.buffer[index];
           
            for (int i = index + 1; i < this.Count; i++)
            {
                this.buffer[i - 1] = this.buffer[i];
            }
            this.buffer[--this.Count] = default;
          
            return removedElement;
        }
        public bool Contains(T element) 
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (buffer[i].Equals(element))
                {
                    return true;
                }
            }
            
                
            
            return false;   
        }
        public void Swap(int firstIndex, int secondIndex)
        {
            this.IsValidIndex(firstIndex);
            this.IsValidIndex(secondIndex);
            if (firstIndex != secondIndex)
            {
                T tmp = this.buffer[firstIndex];
                this.buffer[firstIndex] = this.buffer[secondIndex];
                this.buffer[secondIndex] = tmp;
            }
            
        }

        void IsValidIndex(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException("Enter valid Index");
            }
        }

    }
}
