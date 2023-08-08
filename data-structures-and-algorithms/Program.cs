﻿using System;
using System.Collections.Generic;

namespace data_structures_and_algorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Add("2");
            binaryTree.Add("7");
            binaryTree.Add("5");
            binaryTree.Add("2");
            binaryTree.Add("6");
            binaryTree.Add("9");
            binaryTree.Add("5");
            binaryTree.Add("15");
            binaryTree.Add("4");

            Console.WriteLine("Breadth-First Traversal: " + string.Join(" ", binaryTree.BFS(binaryTree.Root)));

            binaryTree.FizzBuzzTree();

            Console.WriteLine("FizzBuzz Tree Breadth-First Traversal: " + string.Join(" ", binaryTree.BFS(binaryTree.Root)));
        }

        public class Node
        {
            public string Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(string value)
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

            public static Node CheckForNode(Node node)
            {
                if (Convert.ToInt32(node.Value) % 15 == 0)
                {
                    Node n1 = new Node("FizzBuzz");
                    n1.Left = node.Left;
                    n1.Right = node.Right;
                    return n1;
                }
                else if (Convert.ToInt32(node.Value) % 5 == 0)
                {
                    Node n1 = new Node("Buzz");
                    n1.Left = node.Left;
                    n1.Right = node.Right;
                    return n1;
                }
                else if (Convert.ToInt32(node.Value) % 3 == 0)
                {
                    Node n1 = new Node("Fizz");
                    n1.Left = node.Left;
                    n1.Right = node.Right;
                    return n1;
                }

                return node;
            }

            public void FizzBuzzTree()
            {
                FizzBuzzTree(Root);
            }

            private void FizzBuzzTree(Node node)
            {
                if (node != null)
                {
                    FizzBuzzTree(node.Left);
                    node.Value = CheckForNode(node).Value;
                    FizzBuzzTree(node.Right);
                }
            }

            public List<string> InorderTraversal()
            {
                List<string> result = new List<string>();
                InorderTraversal(Root, result);
                return result;
            }

            private void InorderTraversal(Node node, List<string> result)
            {
                if (node != null)
                {
                    InorderTraversal(node.Left, result);
                    result.Add(node.Value);
                    InorderTraversal(node.Right, result);
                }
            }

            public List<string> BFS(Node root)
            {
                Queue<Node> queue = new Queue<Node>();
                List<string> results = new List<string>();
                if (root == null) return results;
                queue.Enqueue(root);
                while (queue.Count != 0)
                {
                    Node newNode = queue.Dequeue();
                    results.Add(newNode.Value);
                    if (newNode.Left != null)
                    {
                        queue.Enqueue(newNode.Left);
                    }
                    if (newNode.Right != null)
                    {
                        queue.Enqueue(newNode.Right);
                    }
                }
                return results;
            }

            public void Add(string value)
            {
                Root = AddRecursive(Root, value);
            }

            private Node AddRecursive(Node current, string value)
            {
                if (current == null)
                {
                    return new Node(value);
                }

                if (current.Left == null)
                {
                    current.Left = new Node(value);
                }
                else if (current.Right == null)
                {
                    current.Right = new Node(value);
                }
                else
                {
                    current.Left = AddRecursive(current.Left, value);
                }

                return current;
            }
        }
    }
}