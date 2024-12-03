using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomQueue
{


    public class CustomQueue<T> 
    {
        private T[] items;
        private int front;
        private int rear;
        private int count;
        private const int InitialCapacity = 4;

        public CustomQueue()
        {
            items = new T[InitialCapacity];
            front = 0;
            rear = 0;
            count = 0;
        }


        public int Count => count;


        public bool IsEmpty()
        {
            return count == 0;
        }


        public void Enqueue(T item)
        {
            if (count == items.Length)
            {
                Resize();
            }

            items[rear] = item;
            rear = (rear + 1) % items.Length;
            count++;
        }


        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            T item = items[front];
            items[front] = default(T);
            front = (front + 1) % items.Length;
            count--;
            return item;
        }

        
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }
            return items[front];
        }


        private void Resize()
        {
            T[] newArray = new T[items.Length * 2];
            for (int i = 0; i < count; i++)
            {
                newArray[i] = items[(front + i) % items.Length];
            }
            items = newArray;
            front = 0;
            rear = count;
        }
    }



}

