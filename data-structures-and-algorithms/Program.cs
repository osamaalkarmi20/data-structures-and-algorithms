﻿

using static data_structures_and_algorithms.Program.BinaryTree;

namespace data_structures_and_algorithms
{


    public class Program
    {
        static void Main(string[] args)
        {
            {

                BinarySearchTree binarySeartchTree = new BinarySearchTree();

                binarySeartchTree.Add(50);
                binarySeartchTree.Add(30);
                binarySeartchTree.Add(70);
                binarySeartchTree.Add(20);
                binarySeartchTree.Add(40);
                binarySeartchTree.Add(60);
                binarySeartchTree.Add(80);


                Console.WriteLine("Pre-Order Traversal");

                string resultString = string.Join(",", binarySeartchTree.PreOrderTravarsel());
                Console.WriteLine(resultString);
                

                Console.WriteLine("In-order Traversal");
                Console.WriteLine(string.Join(", ", binarySeartchTree.InorderTraversal()));

                Console.WriteLine("Post-order Traversal");
                Console.WriteLine(string.Join(", ", binarySeartchTree.PostorderTraversal()));
                Console.WriteLine(binarySeartchTree.Max_tree());
            }

        }

        public class Node
        {
            public int Value { get; set; }

            public Node Left { get; set; }

            public Node Right { get; set; }

            public Node(int value)
            {
                Value = value;
                Left = null;
                Right = null;
            }
        }
        public class BinaryTree
        {
            public Node Root;

            public BinaryTree()
            {
                Root = null;
            }

            public List<int> PreOrderTravarsel()
            {
                List<int> result = new List<int>();
                PreOrderTravarsel(Root, result);

                return result;
            }

            public void PreOrderTravarsel(Node node, List<int> result)
            {
                if (node != null)
                {
                    result.Add(node.Value);

                    PreOrderTravarsel(node.Left, result);

                    PreOrderTravarsel(node.Right, result);
                }

            }

            public List<int> InorderTraversal()
            {
                List<int> result = new List<int>();
                InorderTraversal(Root, result);
                return result;
            }

            private void InorderTraversal(Node node, List<int> result)
            {
                if (node != null)
                {
                    InorderTraversal(node.Left, result);
                    result.Add(node.Value);
                    InorderTraversal(node.Right, result);
                }
            }


            public List<int> PostorderTraversal()
            {
                List<int> result = new List<int>();
                PostorderTraversal(Root, result);
                return result;
            }

            private void PostorderTraversal(Node node, List<int> result)
            {
                if (node != null)
                {
                    PostorderTraversal(node.Left, result);
                    PostorderTraversal(node.Right, result);
                    result.Add(node.Value);
                }
            }
            public int Max_tree()
            {
                return Max_tree(Root);
            }
            private int Max_tree(Node Root)
            {
                if (Root == null)
                {
                    return 0;
                }
                else
                {
                    int max = Root.Value;
                    int lMax = Max_tree(Root.Left);
                    int rMax = Max_tree(Root.Right);
                    if (max < lMax)
                    {
                        max = lMax;
                    }
                    if (max < rMax)
                    {
                        max = rMax;

                    }
                    return max;

                }

            }
            public class BinarySearchTree : BinaryTree
            {

                public void Add(int value)
                {
                    Root = AddNode(Root, value);
                }
                private Node AddNode(Node node, int value)
                {
                    if (node == null)
                        return new Node(value);


                    if (value.CompareTo(node.Value) < 0)
                        node.Left = AddNode(node.Left, value);

                    else if (value.CompareTo(node.Value) > 0)
                        node.Right = AddNode(node.Right, value);

                    return node;
                }
                public bool Contains(int value)
                {
                    return ContainsNode(Root, value);
                }

                private bool ContainsNode(Node node, int value)
                {
                    if (node == null)
                        return false;

                    int comparisonResult = value.CompareTo(node.Value);
                    if (comparisonResult == 0)
                        return true;
                    else if (comparisonResult < 0)
                        return ContainsNode(node.Left, value);
                    else
                        return ContainsNode(node.Right, value);

                }
            }
        }
    }
    }
























