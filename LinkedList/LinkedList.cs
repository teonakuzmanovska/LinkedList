using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList<T>
    {
        private LinkedListNode<T> First { get; set; }
        private LinkedListNode<T> Last { get; set; }
        public int Count { get; set; }

        public void Clear()
        {
            First = null;
            Last = null;
            Count = 0;
        }

        //returns last node which contains the value
        public LinkedListNode<T> FindLast(T value)
        {
            // the list is not empty
            if (First != null)
            {
                LinkedListNode<T> tmp = Last;
                while(tmp != null)
                {
                    if (tmp.Element.Equals(value))
                    {
                        return tmp;
                    }
                    tmp = tmp.Pred;
                }
                Console.WriteLine("Element " + value + " is not in list");
            }
            // the list is empty
            else
            {
                Console.WriteLine("List is empty.");
            }
            return null;
        }

        public LinkedListNode<T> Find(T value)
        {
            LinkedListNode<T> tmp = First;
            // the list is not empty
            if(First != null)
            {
                while(tmp.Succ != null)
                {
                    if(tmp.Element.Equals(value))
                    {
                        return tmp; // returns index of element
                    }
                    tmp = tmp.Succ;
                }
                Console.WriteLine("Element is not in list");
            }
            // the list is empty
            else
            {
                Console.WriteLine("List is empty.");
            }
            return null;
        }

        public bool Contains(T value)
        {
            if (Find(value) != null)
                return true;
            else
                return false;
        }

        public LinkedListNode<T> AddFirst(T value)
        {
            // set predecessor of newly inserted node to null, successor to First
            LinkedListNode<T> newNode = new LinkedListNode<T>(value, null, First); 

            // the list is empty
            if(First == null)
            {
                Last = newNode; // set newly inserted element as Last
            }

            // the list is not empty
            else
            {
                First.Pred = newNode; // set predecessor of First element to newly inserted
            }
            First = newNode; // set newly inserted node as First

            Count++;

            return newNode;

        }

        public LinkedListNode<T> AddLast(T value)
        {
            // the list is empty
            if(First == null)
            {
                return AddFirst(value); // call AddFirst method
            }

            // the list is not empty
            else
            {
                // set predecessor of newly inserted element to Last, successor to null 
                LinkedListNode<T> newNode = new LinkedListNode<T>(value, Last, null);
                Last.Succ = newNode; // set successor of Last to newly inserted node
                Last = newNode; // set newly inserted node as Last

                Count++;

                return newNode;
            }

        }

        public LinkedListNode<T> AddBefore(LinkedListNode<T> before, T value)
        {
            if(before == First) // checks if before node is the First element
            {
                AddFirst(value); // call add First method
            }

            // set predecessor of newly inserted item to before node's predecessor, set predecessor to before node
            LinkedListNode<T> newNode = new LinkedListNode<T>(value, before.Pred, before);
            before.Pred.Succ = newNode; // set successor of predecessor of before node to newly inserted node
            before.Pred = newNode; // set predecessor of before node to newly inserted node
           
            Count++;

            return newNode;
        }

        public LinkedListNode<T> AddAfter(LinkedListNode<T> after, T value)
        {
            if (after == Last) // checks if after node is the Last element
            {
                AddLast(value); // call add Last method
            }

            // set predecessor of newly inserted item to after node, successor to the successor of the after node
            LinkedListNode<T> newNode = new LinkedListNode<T>(value, after, after.Succ);
            after.Succ.Pred = newNode; // set predecessor of successor of after node to newly inserted node
            after.Succ = newNode; // set successor of after node to newly inserted node
            Count++;

            return newNode;
        }

        public void RemoveFirst()
        {
            // the list is not empty
            if (First != null)
            {
                First = First.Succ; // set First to successor of First
                if (First != null)
                {
                    First.Pred = null; // set the predecessor of the new First to null
                }
                if (First == null) // if the new First is null (the list had 1 element)
                {
                    Last = null; // set the Last to null
                }
                Count--;
            }
            // the list is empty
            else
                Console.WriteLine("The list is empty.");
        }

        public void RemoveLast()
        {
            // the list is not empty
            if (First != null)
            {
                // the First has only one element
                if (First.Succ == null)
                {
                    RemoveFirst();
                }
                else
                {
                    Last = Last.Pred; // set Last to predecessor of Last
                    Last.Succ = null; // set successor of new Last to null
                    Count--;
                }
            }
            // the list is empty
            else
                Console.WriteLine("The list is empty.");
        }

        public void Remove(LinkedListNode<T> node)
        {
            if (node == First)
            {
                RemoveFirst();
            }
            else if(node == Last)
            {
                RemoveLast();
            }
            else
            {
                node.Pred.Succ = node.Succ; // set successor of node's predecessor to node's successor
                node.Succ.Pred = node.Pred; // set predecessor of node successot to node's predecessor
                Count--;
            }
        }

        // method for copying list to an array
        public void CopyTo(T[] array, int index)
        {
            if(array.Length <= index || index < 0 )
            {
                Console.WriteLine("Invalid index");
            }
            else if (Count > array.Length - index )
            {
                Console.WriteLine("There is no space for all of the elements");
            }
            else
            {
                LinkedListNode<T> currentNode = First;
                while(currentNode != null)
                {
                    array[index] = currentNode.Element;
                    currentNode = currentNode.Succ;
                    index++;
                }
            }
            
        }

        // method for printing the results in console
        public void Print()
        {
            LinkedListNode<T> currentNode = First;
            while (currentNode != null)
            {
                Console.Write(currentNode.Element + " ");
                currentNode = currentNode.Succ;
            }
            Console.WriteLine();
        }

    }
}
