

namespace data_structures_and_algorithms
{


    public class Program
    {
        static void Main(string[] args)
        {
            {

                BinarySeartchTree<int> binarySeartchTree = new BinarySeartchTree<int>();

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
            }

        }

        public class Node<T>
        {
            public T Value { get; set; }

            public Node<T> Left { get; set; }

            public Node<T> Right { get; set; }

            public Node(T value)
            {
                Value = value;
                Left = null;
                Right = null;
            }
        }
        public class BinaryTree<T>
        {
            public Node<T> Root;

            public BinaryTree()
            {
                Root = null;
            }

            public List<T> PreOrderTravarsel()
            {
                List<T> result = new List<T>();
                PreOrderTravarsel(Root, result);

                return result;
            }

            public void PreOrderTravarsel(Node<T> node, List<T> result)
            {
                if (node != null)
                {
                    result.Add(node.Value);

                    PreOrderTravarsel(node.Left, result);

                    PreOrderTravarsel(node.Right, result);
                }

            }

            public List<T> InorderTraversal()
            {
                List<T> result = new List<T>();
                InorderTraversal(Root, result);
                return result;
            }

            private void InorderTraversal(Node<T> node, List<T> result)
            {
                if (node != null)
                {
                    InorderTraversal(node.Left, result);
                    result.Add(node.Value);
                    InorderTraversal(node.Right, result);
                }
            }

         
            public List<T> PostorderTraversal()
            {
                List<T> result = new List<T>();
                PostorderTraversal(Root, result);
                return result;
            }

            private void PostorderTraversal(Node<T> node, List<T> result)
            {
                if (node != null)
                {
                    PostorderTraversal(node.Left, result);
                    PostorderTraversal(node.Right, result);
                    result.Add(node.Value);
                }
            }

        }
        public class BinarySeartchTree<T> : BinaryTree<T> where T : IComparable
        {

            public void Add(T value)
            {
                Root = AddNode(Root, value);
            }
            private Node<T> AddNode(Node<T> node, T value)
            {
                if (node == null)
                    return new Node<T>(value);


                if (value.CompareTo(node.Value) < 0)
                    node.Left = AddNode(node.Left, value);

                else if (value.CompareTo(node.Value) > 0)
                    node.Right = AddNode(node.Right, value);

                return node;
            }
                public bool Contains(T value)
                {
                    return ContainsNode(Root, value);
                }

                private bool ContainsNode(Node<T> node, T value)
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


















