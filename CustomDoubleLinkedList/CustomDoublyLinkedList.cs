using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CustomDoublyLinkedList
{
    public class CustomDoublyLinkedList<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public int Count { get; set; }


        public void AddFirst(T element)
        {
            Node<T> node = new Node<T>(element);
            if (this.Head == null)
            {
                this.Head = node;
                this.Tail = node;
            }
            else
            {
                this.Head.PreviousNode = node;
                node.NextNode = Head;
                this.Head = node;
            }
            Count++;
        }

        public void AddLast(T element)
        {
            Node<T>  node = new Node<T>(element);
            if (this.Head == null)
            {
                this.Head = node;
                this.Tail = node;
            }
            else
            {
                node.PreviousNode = this.Tail;
                this.Tail.NextNode = node;
                this.Tail = node;
            }
            Count++;
        }

        public T RemoveFirst()
        {
            if (this.Head == null)
            {
                throw new Exception("Empty List");
            }

            Node<T> oldHead = this.Head;
            if (this.Head.NextNode == null) 
            {
                this.Head = null;
                this.Tail = null;
            }
            else
            {
                this.Head = this.Head.NextNode;
                this.Head.PreviousNode = null;
            }

            oldHead.NextNode = null; 
            Count--;
            return oldHead.Value;
        }
    
        public T RemoveLast()
        {
            if (this.Tail == null)
            {
                throw new Exception("Empty List");
            }

            Node<T> oldTail = this.Tail;
            if (this.Tail.PreviousNode == null)
            {
                this.Head = null;
                this.Tail = null;
            }
            else
            {
                this.Tail = this.Tail.PreviousNode;
                this.Tail.NextNode = null;
            }

            oldTail.PreviousNode = null; 
            Count--;
            return oldTail.Value;
        }


        public void ForEach(Action<T> action)
        {
            

            Node<T> node = this.Head;
            while (node != null)
            {
                action(node.Value);
                node = node.NextNode;
            }
        }
        public T[] ToArray()
        {
            if (this.Count == 0)
            {
                return new T[0]; 
            }

            T[] result = new T[Count];
            int i = 0;
            ForEach(x => result[i++] = x);
            return result;
        }
    }
}

