using System;
using System.Collections.Generic;

namespace data_structures_and_algorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a new graph
            Graph<string> newGraph = new Graph<string>();

            Vertex<string> A = newGraph.AddVertex("A");
            Vertex<string> B = newGraph.AddVertex("B");
            Vertex<string> C = newGraph.AddVertex("C");
            Vertex<string> D = newGraph.AddVertex("D");
            Vertex<string> E = newGraph.AddVertex("E");
            Vertex<string> F = newGraph.AddVertex("F");
            Vertex<string> G = newGraph.AddVertex("G");
            Vertex<string> H = newGraph.AddVertex("H");

            newGraph.AddEdge(A, B);
            newGraph.AddEdge(A, D);
            newGraph.AddEdge(B, A);
            newGraph.AddEdge(B, D);
            newGraph.AddEdge(B, C);
            newGraph.AddEdge(C, B);
            newGraph.AddEdge(C, G);
            newGraph.AddEdge(D, B);
            newGraph.AddEdge(D, A);
            newGraph.AddEdge(D, F);
            newGraph.AddEdge(D, E);
            newGraph.AddEdge(D, H);
            newGraph.AddEdge(H, F);
            newGraph.AddEdge(H, D);

            // Perform depth-first traversal starting from A
            var depthFirstTraversal = newGraph.DepthFirstTraversal(A);

            Console.WriteLine("Depth-First Traversal from A:");
            foreach (var vertex in depthFirstTraversal)
            {
                Console.Write($"{vertex.Value} => ");
            }
        }

        public static int? BusinessTrip(Graph<string> graph, string[] cityNames)
        {
            if (cityNames.Length < 2)
            {
                return null; 
            }

            int totalCost = 0;

            for (int i = 0; i < cityNames.Length - 1; i++)
            {
                string fromCity = cityNames[i];
                string toCity = cityNames[i + 1];

                Vertex<string> fromVertex = null;
                Vertex<string> toVertex = null;

                
                foreach (var vertex in graph.GetVertices())
                {
                    if (vertex.Value == fromCity)
                    {
                        fromVertex = vertex;
                    }
                    if (vertex.Value == toCity)
                    {
                        toVertex = vertex;
                    }
                }

                if (fromVertex == null || toVertex == null)
                {
                    return null; 
                }

                Edge<string> edge = null;
                foreach (var neighborEdge in graph.GetNeighbors(fromVertex))
                {
                    if (neighborEdge.Vertex == toVertex)
                    {
                        edge = neighborEdge;
                    }
                }

                if (edge == null)
                {
                    return null;
                }

                totalCost += edge.Weight;
            }

            return totalCost;
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

            public ICollection<Vertex<T>> DepthFirstTraversal(Vertex<T> startVertex)
            {
                if (!AdjacencyList.ContainsKey(startVertex))
                    throw new InvalidOperationException("Start vertex is not in the graph.");

                List<Vertex<T>> visitedNodes = new List<Vertex<T>>();
                HashSet<Vertex<T>> visited = new HashSet<Vertex<T>>();

                DepthFirstTraversalRecursive(startVertex, visitedNodes, visited);

                return visitedNodes;
            }

            private void DepthFirstTraversalRecursive(Vertex<T> currentVertex, List<Vertex<T>> visitedNodes, HashSet<Vertex<T>> visited)
            {
                visitedNodes.Add(currentVertex);
                visited.Add(currentVertex);

                foreach (var edge in AdjacencyList[currentVertex])
                {
                    if (!visited.Contains(edge.Vertex))
                    {
                        DepthFirstTraversalRecursive(edge.Vertex, visitedNodes, visited);
                    }
                }
            }
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
