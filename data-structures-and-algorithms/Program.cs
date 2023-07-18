
using System.Collections.Generic;

namespace data_structures_and_algorithms
{


    public class Program
    {
        static void Main(string[] args)
        {

            //query:
            Console.WriteLine("???????????????????????????????????????");
            Queue queue = new Queue();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

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

            public Node Peek()
            {
                if (IsEmpty())
                    throw new InvalidOperationException("Stack is empty");

                return top;
            }

            public bool IsEmpty()
            {
                return top == null;
            }



        }

       public class Queue
        {
            private Stack stack1;
            private Stack stack2;

            public Queue()
            {
                stack1 = new Stack();
                stack2 = new Stack();
            }

            public void Enqueue(int value)
            {

                while (!stack2.IsEmpty())
                {
                    stack1.Push(stack2.Pop());
                }

                stack1.Push(value);
            }

            public int Dequeue()
            {

                while (!stack1.IsEmpty())
                {
                    stack2.Push(stack1.Pop());
                }

                return stack2.Pop();
            }
        }




    }
}







