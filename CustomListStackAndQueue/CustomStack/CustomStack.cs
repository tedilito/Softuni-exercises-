using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    public  class CustomStack<T> : IEnumerable<T>
    {
        private T[] buffer { get; set; }
        public int Count { get; set; }
        public CustomStack(int capacity)
        {
            this.buffer = new T[capacity];
        }
        public CustomStack()
        {
            this.buffer = new T[4];
        }
        public void Push(T element)
        {
            if (this.Count == this.buffer.Length)
            {
                this.Grow();
            }
            this.buffer[this.Count++] = element;
        }
        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            else
            {
                T removeElemt = this.buffer[this.Count - 1];
                this.buffer[this.Count - 1] = default;
                this.Count--;
                return removeElemt;
            }
        }
        public T Peek()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            else
            {
                return this.buffer[this.Count - 1]; 
            }
        }
        private void Grow()
        {
            T[] newBuffer = new T[this.buffer.Length * 2];
            Array.Copy(this.buffer, newBuffer, Count);
            this.buffer = newBuffer;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                yield return this.buffer[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return GetEnumerator();
        }
    }
}
