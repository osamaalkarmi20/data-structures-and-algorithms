using System.Collections.Generic;

namespace data_structures_and_algorithms
{


    public class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            Console.WriteLine(stack.IsEmpty());  

            stack.Push(10);
            stack.Push(20);
            int peekValue = stack.Peek();
            Console.WriteLine(peekValue); 

            int popValue = stack.Pop();
            Console.WriteLine(popValue);  
            //query:
            Console.WriteLine("???????????????????????????????????????");  
            Queue queue = new Queue();
            Console.WriteLine(queue.IsEmpty()); 

            queue.Enqueue(10);
            queue.Enqueue(20);
            int peekValueQueue = queue.Peek();
            Console.WriteLine(peekValueQueue); 

            int dequeueValue = queue.Dequeue();
            Console.WriteLine(dequeueValue);  
        }
        public class Node
        {
            public int Value { get; set; }
            public Node Next { get; set; }

            public Node(int value)
            {
                Value = value;
                Next = null;
            }
        }
        public class Stack
        {
            private Node top;

            public Stack()
            {
                top = null;
            }



            public void Push(int value)
            {
                Node newNode = new Node(value);
                newNode.Next = top;
                top = newNode;
            }

            public int Pop()
            {
                if (IsEmpty())
                    throw new InvalidOperationException("Stack is empty");

                int value = top.Value;
                top = top.Next;
                return value;
            }

            public int Peek()
            {
                if (IsEmpty())
                    throw new InvalidOperationException("Stack is empty");

                return top.Value;
            }

            public bool IsEmpty()
            {
                return top == null;
            }



        }


        public class Queue
        {
            private Node front;
            private Node rear;

            public Queue()
            {
                front = null;
                rear = null;
            }

            public void Enqueue(int value)
            {
                Node newNode = new Node(value);

                if (IsEmpty())
                {
                    front = newNode;
                    rear = newNode;
                }
                else
                {
                    rear.Next = newNode;
                    rear = newNode;
                }
            }

            public int Dequeue()
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException("Queue is empty");
                }

                int value = front.Value;
                front = front.Next;

                if (front == null)
                    rear = null;

                return value;
            }

            public int Peek()
            {
                if (IsEmpty())
                    throw new InvalidOperationException("Queue is empty");

                return front.Value;
            }

            public bool IsEmpty()
            {
                return front == null;
            }
        }



    }
}










