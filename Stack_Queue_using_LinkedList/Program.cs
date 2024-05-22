using System;

namespace Stack_Queue_using_LinkedList
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int data)
        {
            this.Data = data;
            this.Next = null;
        }
    }
    public class LinkedList
    {
        public Node head;
        public void Add(int data)
        {
            Node newnode = new Node(data);
            if (head == null)
            {
                head = newnode;
            }
            else
            {
                Node cuurent = head;
                while (cuurent.Next != null)
                {
                    cuurent = cuurent.Next;
                }
                cuurent.Next = newnode;
            }

        }
        public void Add_At(int index, int data)
        {
            Node newnode = new Node(data);
            if (index == 0)
            {
                newnode.Next = head;
                head = newnode;
                return;
            }

            Node cuurent = head;

            for (int i = 0; i < index - 1; ++i)
            {
                cuurent = cuurent.Next;
            }
            if (cuurent != null)
            {
                newnode.Next = cuurent.Next;
                cuurent.Next = newnode;
            }
        }
        public void Add_First(int data)
        {
            Node newnode = new Node(data);
            newnode.Next = head;
            head = newnode;
        }
        public void Remove(int data)
        {
            if (head == null) Console.WriteLine("No value to remove :)");
            Node cuurent = head;
            while (cuurent.Next != null && cuurent.Next.Data != data)
            {
                cuurent = cuurent.Next;
            }
            if (cuurent.Next != null)
            {
                cuurent.Next = cuurent.Next.Next;
            }
        }
        public void Remove_At(int index)
        {
            if (head == null) Console.WriteLine("No value to remove :)");
            if (index == 0)
            {
                head = head.Next;
                return;
            }
            Node current = head;
            for (int i = 0; i < index - 1; ++i)
            {
                current = current.Next;
            }
            if (current.Next != null)
            {
                current.Next = current.Next.Next;
            }
        }
        public void Clear()
        {
            head = null;
        }
        public void Print()
        {
            if (head == null)
            {
                Console.WriteLine("Empty linked list :)");
            }
            int i = 0;
            Node current = head;
            while (current != null)
            {
                Console.WriteLine($"The value for node [{i}] is: {current.Data}.");
                current = current.Next;
                ++i;
            }
        }
        public int count()
        {
            int i = 0;
            Node current = head;
            while (current != null)
            {
                ++i;
                current = current.Next;
            }
            return i;
        }
    }
    public class Stack
    {
        public LinkedList list;
        public Stack()
        {
            list = new LinkedList();
        }
        public void add(int data)
        {
            list.Add_First(data);
        }
        public void remove()
        {
            list.Remove_At(0);
        }
        public void print()
        {
            list.Print();
        }
    }
    public class Queue
    {
        public LinkedList list;
        public Queue()
        {
            list = new LinkedList();
        }
        public void add(int data)
        {
            list.Add_First(data);
        }
        public void remove()
        {
            list.Remove_At(list.count() - 1);
        }
        public void print()
        {
            list.Print();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue newqueue = new Queue();
            int[] values = { 5, 6, 8, 9, 12, 45, 47, 35 };
            for (int i = 0; i < values.Length; ++i)
            {
                newqueue.add(values[i]);
            }

            newqueue.print();
            Console.WriteLine("----------------------");

            newqueue.remove();
            newqueue.remove();
            newqueue.remove();

            newqueue.print();



            Console.ReadKey();
        }
    }
}
