# LinkedList

This is a C# implementation of a doubly linked list data structure from scratch. It provides methods for adding, removing, and searching for elements in the list.

## Prerequisites

- .NET Framework 7.4.2 or later

## LinkedListNode.cs

The LinkedListNode is a generic class which represents a node in the linked list. It contains the following properties:

- `Element`: The value of the node.
- `Pred`: The predecessor (previous) node in the list.
- `Succ`: The successor (next) node in the list.

## LinkedList.cs

The LinkedList<T> class represents the linked list itself. It has the following properties:

- `First`: The first node in the list.
- `Last`: The last node in the list.
- `Count`: The number of elements in the list.

The class provides the following methods:

- `Clear()`: Removes all elements from the list.
- `FindLast()`: Finds and returns the last occurence of node in the list.
- `Find(T value)`: Searches for a node with the specified value and returns it.
- `Contains(T value)`: Checks if the list contains a node with the specified value.
- `AddFirst(T value)`: Inserts a new node with the specified value at the beginning of the list.
- `AddLast(T value)`: Inserts a new node with the specified value at the end of the list.
- `AddBefore(LinkedListNode<T> before, T value)`: Inserts a new node with the specified value before the specified node.
- `AddAfter(LinkedListNode<T> after, T value)`: Inserts a new node with the specified value after the specified node.
- `RemoveFirst()`: Removes the first node from the list.
- `RemoveLast()`: Removes the last node from the list.
- `Remove(LinkedListNode<T> node)`: Removes the specified node from the list.
- `CopyTo(T[] array, int index)`: Copies the elements of the list to an array, starting at the specified index.
- `Print()`: Prints the elements of the list to the console.

## TestCases.cs

This is a file containing example usage of the mentioned methods

## Getting Started

1. Clone the repository:

   ```shell
   git clone https://github.com/your-username/DapperORMConsoleApp.git

2. Open the solution in Visual Studio.
3. Run the application

## Usage

For the sake of convenience the methods are automatically called. Feel free to change the list's elements in the `TestCases.cs` file.
