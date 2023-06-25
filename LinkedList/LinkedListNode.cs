using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedListNode<T> // T - generic type
    {
        public T Element { get; set; }
        public LinkedListNode<T> Pred { get; set; } // predecessor of element
        public LinkedListNode<T> Succ { get; set; } // successor of element


        public LinkedListNode(T elem, LinkedListNode<T> pred, LinkedListNode<T> succ)
        {
            Element = elem;
            Pred = pred;
            Succ = succ;
        }

    }

}
