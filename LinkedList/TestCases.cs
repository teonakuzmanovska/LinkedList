using System;

namespace LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a new instance of LinkedList<int>
            LinkedList<int> linkedList = new LinkedList<int>();

            // Add elements to the linked list
            linkedList.AddFirst(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);

            // Print the initial list
            Console.WriteLine("Initial List:");
            linkedList.Print();

            // Test CopyTo method
            int[] array = new int[linkedList.Count+2];
            array[0] = 1;
            array[1] = 2;
            linkedList.CopyTo(array, 2);
            Console.WriteLine("Copied to array:");
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");

            // Test Find method
            LinkedListNode<int> node = linkedList.Find(3);
            Console.WriteLine("Find '3' result: " + (node.Element.ToString()));
            Console.WriteLine("Count: " + linkedList.Count);

            // Test Contains method
            bool contains = linkedList.Contains(2);
            Console.WriteLine("Contains '2' result: " + contains);

            // Test AddFirst method
            LinkedListNode<int> newFirstNode = linkedList.AddFirst(0);
            Console.WriteLine("Add " + newFirstNode.Element.ToString() + " as first result: ");
            linkedList.Print();
            Console.WriteLine("Count: " + linkedList.Count);

            // Test AddLast method
            LinkedListNode<int> newLastNode = linkedList.AddLast(5);
            Console.WriteLine("Add " + newLastNode.Element.ToString() + " as last result: ");
            linkedList.Print();
            Console.WriteLine("Count: " + linkedList.Count);

            // Test AddBefore method
            LinkedListNode<int> newNode = linkedList.AddBefore(node, 5);
            Console.WriteLine("Add " + newNode.Element.ToString() + " before 3 result: ");
            linkedList.Print();
            Console.WriteLine("Count: " + linkedList.Count);

            // Test AddAfter method
            newNode = linkedList.AddAfter(node, 6);
            Console.WriteLine("Add " + newNode.Element.ToString() + " after 3 result: ");
            linkedList.Print();
            Console.WriteLine("Count: " + linkedList.Count);

            // Test RemoveFirst method
            linkedList.RemoveFirst();
            Console.WriteLine("List after RemoveFirst:");
            linkedList.Print();
            Console.WriteLine("Count: " + linkedList.Count);

            // Test RemoveLast method
            linkedList.RemoveLast();
            Console.WriteLine("List after RemoveLast:");
            linkedList.Print();
            Console.WriteLine("Count: " + linkedList.Count);

            // Test Remove method
            linkedList.Remove(node);
            Console.WriteLine("List after Remove '3':");
            linkedList.Print();
            Console.WriteLine("Count: " + linkedList.Count);

            // Clear the list
            linkedList.Clear();
            Console.WriteLine("List after Clear:");
            linkedList.Print();
            Console.WriteLine("Count: " + linkedList.Count);

            Console.ReadLine();
        }
    }
}
