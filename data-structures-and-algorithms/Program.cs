using System;
using System.Collections.Generic;

namespace data_structures_and_algorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Graph<string> graph = new Graph<string>();

            Vertex<string> a = graph.AddVertex("New York");
            Vertex<string> b = graph.AddVertex("Los Angeles");
            Vertex<string> c = graph.AddVertex("Chicago");
            Vertex<string> d = graph.AddVertex("San Francisco");

            graph.AddEdge(a, b, 3000);
            graph.AddEdge(b, c, 2000);
            graph.AddEdge(c, d, 1800);
            graph.AddEdge(d, a, 2500);

            Console.WriteLine("Vertices in the graph:");
            foreach (var vertex in graph.GetVertices())
            {
                Console.WriteLine(vertex.Value);
            }

            Console.WriteLine("\nNeighbors of New York:");
            var newYorkNeighbors = graph.GetNeighbors(a);
            foreach (var edge in newYorkNeighbors)
            {
                Console.WriteLine($"{edge.Vertex.Value} (Weight: {edge.Weight})");
            }

            Console.WriteLine("\nSize of the graph: " + graph.Size());


            Console.WriteLine("Breadth-First Traversal:");
            var bfsOrder = graph.BreadthFirstTraversal(d);
            foreach (var vertex in bfsOrder)
            {
                Console.Write($"{vertex.Value} ");
            }
            Console.WriteLine();

        }


        public class Vertex<T>
        {
            public T Value { get; set; }

            public Vertex(T value)
            {
                Value = value;
            }
        }

        public class Edge<T>
        {
            public int Weight { get; set; }
            public Vertex<T> Vertex { get; set; }
        }

        public class Graph<T>
        {
            public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList { get; set; }
            public ICollection<Vertex<T>> BreadthFirstTraversal(Vertex<T> startVertex)
            {
                if (!AdjacencyList.ContainsKey(startVertex))
                    throw new InvalidOperationException("Start vertex is not in the graph.");

                List<Vertex<T>> visitedNodes = new List<Vertex<T>>();
                Queue<Vertex<T>> queue = new Queue<Vertex<T>>();
                HashSet<Vertex<T>> visited = new HashSet<Vertex<T>>();

                queue.Enqueue(startVertex);
                visited.Add(startVertex);

                while (queue.Count > 0)
                {
                    var currentVertex = queue.Dequeue();
                    visitedNodes.Add(currentVertex);

                    foreach (var edge in AdjacencyList[currentVertex])
                    {
                        if (!visited.Contains(edge.Vertex))
                        {
                            visited.Add(edge.Vertex);
                            queue.Enqueue(edge.Vertex);
                        }
                    }
                }

                return visitedNodes;
            }
            public Graph()
            {
                AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
            }

            public Vertex<T> AddVertex(T value)
            {
                Vertex<T> node = new Vertex<T>(value);

                AdjacencyList[node] = new List<Edge<T>>();
                return node;
            }

            public void AddEdge(Vertex<T> vertex1, Vertex<T> vertex2, int weight = 0)
            {
                if (!AdjacencyList.ContainsKey(vertex1) || !AdjacencyList.ContainsKey(vertex2))
                {
                    throw new ArgumentException("Both vertices should already be in the graph");
                }

                AdjacencyList[vertex1].Add(new Edge<T>
                {
                    Weight = weight,
                    Vertex = vertex2,
                });

                AdjacencyList[vertex2].Add(new Edge<T>
                {
                    Weight = weight,
                    Vertex = vertex1,
                });
            }

            public List<Vertex<T>> GetVertices()
            {
                return new List<Vertex<T>>(AdjacencyList.Keys);
            }

            public List<Edge<T>> GetNeighbors(Vertex<T> vertex)
            {
                if (AdjacencyList.ContainsKey(vertex))
                {
                    return AdjacencyList[vertex];
                }
                else
                {
                    return new List<Edge<T>>();
                }
            }

            public int Size()
            {
                return AdjacencyList.Count;
            }

            public void Print()
            {
                foreach (var item in AdjacencyList)
                {
                    Console.Write($"Vertex {item.Key.Value} =>");

                    foreach (var edge in item.Value)
                    {
                        Console.Write($"{edge.Vertex.Value} (Weight: {edge.Weight}) =>");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
