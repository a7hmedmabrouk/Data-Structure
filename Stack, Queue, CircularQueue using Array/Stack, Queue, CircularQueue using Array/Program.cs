using System;

namespace ConsoleApp7
{
    public class Stack
    {
        static int Max;
        int[] stackarray;
        int top;

        public Stack()
        {
            top = -1;
            Console.Write("Enter the size of the stack array: ");
            Max = int.Parse(Console.ReadLine());
            stackarray = new int[Max];
        }

        bool IsEmpaty() => top < 0;
        bool IsFull() => top == stackarray.Length - 1;

        public void push(int value)
        {
            if(IsFull())
            {
                Console.WriteLine("You can not push data the stack is overflow :)");
            }
            else
            {
                ++top;
                stackarray[top] = value;
            }
        }
        public void pop()
        {
            if (IsEmpaty())
            {
                Console.WriteLine("There is no data to pop :)");
            }
            else
            {
                int value = stackarray[top--];
                Console.WriteLine($"the value being poped is: {value}");
            }
        }
        public void Peek()
        {
            if(IsEmpaty()) Console.WriteLine("there is no top :)");
            
            else Console.WriteLine($"the top is {stackarray[top]}");
        }
        public void Print()
        {
            if (IsEmpaty()) Console.WriteLine("there is no data :)");
            else
            {
                Console.WriteLine("the items is the stack is: ");
                for(int i = top; i >= 0; i--)
                {
                    Console.WriteLine($"the values [{stackarray[i]}]");
                }
            }
        }
    }
    public class Queue
    {
        int Max;
        int[] queueArray;
        int front, back;

        public Queue()
        {
            front = -1;
            back = -1;
            Console.Write("Enter the size of the queue: ");
            Max = int.Parse(Console.ReadLine());
            queueArray = new int[Max];
        }

        bool IsEmpty() => front == -1 || front > back;
        bool IsFull() => back == Max - 1;

        public void Push(int value)
        {
            if (IsFull())
            {
                Console.WriteLine("You cannot add more values :)");
                return;
            }
            if (IsEmpty())
            {
                front = 0;
            }
            back++;
            queueArray[back] = value;
        }

        public void Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("There is no data to pop :)");
            }
            else
            {
                int value = queueArray[front];
                Console.WriteLine($"The value that has been popped is {value}");
                front++;
                if (front > back) front = back = -1;
            }
        }

        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("There is no data to print :)");
            }
            else
            {
                for (int i = front; i <= back; i++)
                {
                    Console.WriteLine($"The value in the queue is [{queueArray[i]}]");
                }
            }
        }
    }
    public class CircularQueue
    {
        private int Max;
        private int[] Queue;
        private int front, rear, count;

        public CircularQueue()
        {
            Console.Write("Please enter size of queue: ");
            Max = int.Parse(Console.ReadLine());
            Queue = new int[Max];
            front = rear = count = 0;
        }

        private bool IsEmpty() => count == 0;
        private bool IsFull() => count == Max;

        public void Enqueue()
        {
            if (IsFull())
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            Console.Write("Enter the Pushed item: ");
            int value = int.Parse(Console.ReadLine());
            Queue[rear] = value;
            rear = (rear + 1) % Max;
            count++;
        }

        public void Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue Underflow");
                return;
            }
            int value = Queue[front];
            front = (front + 1) % Max;
            count--;
            Console.WriteLine($"The removed item is {value}");
        }

        public void Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue Underflow");
                return;
            }
            Console.WriteLine($"The topmost element of queue is: {Queue[front]}");
        }

        public void PrintQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue Underflow");
                return;
            }
            Console.WriteLine("Items in the Queue are:");
            for (int i = 0; i < count; i++)
            {
                int index = (front + i) % Max;
                Console.WriteLine(Queue[index]);
            }
        }
    }


        internal class Program
    {
        static void Main(string[] args)
        {

            //Stack stack = new Stack();

            //stack.push(5);
            //stack.push(4);
            //stack.push(8);
            //stack.push(2);
            //stack.push(3);

            //stack.Print();

            //stack.pop();
            //stack.pop();
            //stack.pop();

            //stack.Peek();

            //Queue queue = new Queue();
            //queue.Push(1);
            //queue.Push(2);
            //queue.Push(3);
            //queue.Print();
            //queue.Pop();
            //queue.Pop();
            //queue.Print();

            CircularQueue myQueue = new CircularQueue();
            char choice;
            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Enqueue");
                Console.WriteLine("2. Dequeue");
                Console.WriteLine("3. Peek");
                Console.WriteLine("4. Print Queue");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (choice)
                {
                    case '1':
                        myQueue.Enqueue();
                        break;
                    case '2':
                        myQueue.Dequeue();
                        break;
                    case '3':
                        myQueue.Peek();
                        break;
                    case '4':
                        myQueue.PrintQueue();
                        break;
                    case '5':
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please enter a valid option.");
                        break;
                }
            } 
            while (choice != '5');



            Console.ReadKey();

        }
    }
}
