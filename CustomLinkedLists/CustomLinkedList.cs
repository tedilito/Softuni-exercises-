using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedLists
{
    public class CustomLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Count { get; set; }


        public void AddFirst(int element)
        {
            Node node = new Node(element);
            if (Head == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Head.Previous = node;
                node.Next = Head;
                Head = node;
            }
            Count++;
        }

        public void AddLast(int element)
        {
            Node node = new Node(element);
            if (Head == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
                Tail = node;
            }
            Count++;
        }

        public int RemoveFirst()
        {
            if (Count == 0)
            {
                throw new Exception("No elements");
            }
            else
            {
                Node old = Head;

                if (this.Head.Next == null)
                {
                    this.Head = null;
                    this.Tail = null;
                    Count--;
                }
                else
                {

                    Head = Head.Next;
                    Head.Previous = null;
                    old.Next = null;
                }
                Count--;
                return old.Value;
            }


        }
        public int RemoveLast()
        {
            if (Count == 0)
            {
                throw new Exception("No elements");
            }
            else
            {
                Node old = Head;

                if (this.Tail.Previous == null)
                {
                    this.Tail = null;
                    this.Tail = null;
                    Count--;
                }
                else
                {

                    Tail = Tail.Previous;
                    Tail.Next = null;
                    old.Previous = null;
                }
                Count--;
                return old.Value;
            }
        }

        public void ForEach(Action<int> action)
        {
            Node node = this.Head;
            while (node != null)
            {
                action(node.Value);
                node = node.Next;
            }
        }

        public int[] ToArray()
        {
            int[] ints = new int[Count];
            int iterator = 0;
            ForEach(x => ints[iterator++] = x);
            return ints;

        }

    }
}
