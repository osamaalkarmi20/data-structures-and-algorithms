namespace data_structures_and_algorithms
{
    
        public class Program
        {
            static void Main(string[] args)
            {
            LinkedList linkedList = new LinkedList();
            linkedList.Append(1);
            linkedList.Append(3);
            linkedList.Append(4);

            bool exists = linkedList.Includes(3);
            Console.WriteLine($"Value 3 exists: {exists}");
            exists = linkedList.Includes(2);
            Console.WriteLine($"Value 2 exists: {exists}");

            linkedList.InsertBefore(3, 2);
            linkedList.InsertAfter(4, 5);

            Console.WriteLine(linkedList.ToString());
        }
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

        public class LinkedList
        {
            public Node Head { get; set; }
            public Node Tail { get; set; }

            public LinkedList()
            {
                Head = null;
                Tail = null;
            }

            public void Append(int value)
            {
                Node newNode = new Node(value);
                if (Head == null)
                {
                    Head = newNode;
                    Tail = newNode;
                }
                else
                {
                    Tail.Next = newNode;
                    Tail = newNode;
                }
            }

            public bool Includes(int value)
            {
                Node position = Head;
                while (position != null)
                {
                    if (position.Value == value)
                    {
                        return true;
                    }
                    position = position.Next;
                }
                return false;
            }

        public void InsertBefore(int value, int newValue)
        {
            if (Head == null)
                return;

            if (Head.Value == value)
            {
                Node newNode = new Node(newValue);
                newNode.Next = Head;
                Head = newNode;
                return;
            }

            Node current = Head;
            while (current.Next != null)
            {
                if (current.Next.Value == value)
                {
                    Node newNode = new Node(newValue);
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }
        }
        public void InsertAfter(int value, int newValue)
        {
            Node current = Head;
            while (current != null)
            {
                if (current.Value == value)
                {
                    Node newNode = new Node(newValue);
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    if (current == Tail)
                        Tail = newNode;
                    return;
                }
                current = current.Next;
            }
        }
        public string ToString()
            {
                Node current = Head;
                string result = "";
                while (current != null)
                {
                    result += $"{{ {current.Value} }} -> ";
                    current = current.Next;
                }
                result += "NULL";
                return result;
            }
        }
    }
