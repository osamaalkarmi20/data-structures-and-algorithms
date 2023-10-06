using data_structures_and_algorithms;
using static data_structures_and_algorithms.Program;

namespace TestReserve
{
    public class UnitTest1
    {

        [Fact]
        public void DepthFirst_ReturnsCorrectTraversalOrder()
        {
            
            Graph<char> graph = new Graph<char>();
            var A = graph.AddVertex('A');
            var B = graph.AddVertex('B');
            var C = graph.AddVertex('C');
            var D = graph.AddVertex('D');
            var E = graph.AddVertex('E');
            var F = graph.AddVertex('F');
            var G = graph.AddVertex('G');
            var H = graph.AddVertex('H');

            graph.AddEdge(A, B);
            graph.AddEdge(B, C);
            graph.AddEdge(B, D);
            graph.AddEdge(C, G);
            graph.AddEdge(D, E);
            graph.AddEdge(D, H);
            graph.AddEdge(D, F);
            graph.AddEdge(E, H);


            var traversalOrder = graph.DepthFirst(A);


            char[] expectedOrder = { 'A', 'B', 'C', 'G', 'D', 'E', 'H', 'F' };
            Assert.Equal(expectedOrder, traversalOrder.Select(v => v.Value));
        }

        [Fact]
        public void DepthFirst_WithNullStartNode_ReturnsEmptyList()
        {
     
            Graph<char> graph = new Graph<char>();

            var traversalOrder = graph.DepthFirst(null);

            Assert.Empty(traversalOrder);
        }

        [Fact]
        public void DepthFirst_WithDisconnectedGraph_ReturnsCorrectOrder()
        {
      
            Graph<char> graph = new Graph<char>();
            var A = graph.AddVertex('A');
            var B = graph.AddVertex('B');
            var C = graph.AddVertex('C');


            var traversalOrder = graph.DepthFirst(A);

 
            char[] expectedOrder = { 'A' };
            Assert.Equal(expectedOrder, traversalOrder.Select(v => v.Value));
        }

    }
}
