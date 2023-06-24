namespace data_structures_and_algorithms
{
    
        public class Program
        {
            static void Main(string[] args)
            {
                LinkedList linkedList = new LinkedList();
                linkedList.Insert(3);
                linkedList.Insert(2);

                bool exists = linkedList.Includes(2);
                Console.WriteLine($"Value 2 exists: {exists}");
                exists = linkedList.Includes(4);
                Console.WriteLine($"Value 4 exists: {exists}");
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

            public void Insert(int value)
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
