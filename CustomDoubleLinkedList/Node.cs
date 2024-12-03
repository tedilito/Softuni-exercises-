using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDoublyLinkedList
{
    public class Node<T>
    {
        public Node(T value)
        {
            Value = value;
        }

        public T Value { get; set; }
        public Node<T> NextNode { get; set; }
        public Node<T> PreviousNode { get; set; }

    }
}
