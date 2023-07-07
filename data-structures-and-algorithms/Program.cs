using System.Collections.Generic;

namespace data_structures_and_algorithms
{


        public class Program
        {
            static void Main(string[] args)
            {
                LinkedList list1 = new LinkedList();
                list1.Append(1);
                list1.Append(3);
                list1.Append(5);
                LinkedList list2 = new LinkedList();
                list2.Append(0);
                list2.Append(0);
                list2.Append(0);

                LinkedList list3 = new LinkedList();
                list3 = LinkedList.zipList(list1, list2);

                // Traverse and print the zipped list
                Console.WriteLine(list3.ToString());
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

                public static LinkedList zipList(LinkedList list1, LinkedList list2)
                {
                    LinkedList list3 = new LinkedList();

                    Node pointer1 = list1.Head;
                    Node pointer2 = list2.Head;

                    while (pointer1 != null && pointer2 != null)
                    {
                        list3.Append(pointer1.Value);
                        list3.Append(pointer2.Value);

                        pointer1 = pointer1.Next;
                        pointer2 = pointer2.Next;
                    }

                    // Append any remaining nodes from list1
                    while (pointer1 != null)
                    {
                        list3.Append(pointer1.Value);
                        pointer1 = pointer1.Next;
                    }

                    // Append any remaining nodes from list2
                    while (pointer2 != null)
                    {
                        list3.Append(pointer2.Value);
                        pointer2 = pointer2.Next;
                    }

                    return list3;
                }
            }


        }
    }










