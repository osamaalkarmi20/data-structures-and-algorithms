using data_structures_and_algorithms;
using static data_structures_and_algorithms.Program;

namespace TestReserve
{
    public class UnitTest1
    {
        [Fact]
        public void VertexCanBeSuccessfullyAdded()
        {
            Graph<string> graph = new Graph<string>();
            Vertex<string> vertex = graph.AddVertex("TestVertex");

            Assert.NotNull(vertex);
            Assert.Equal("TestVertex", vertex.Value);
        }

        [Fact]
        public void EdgeCanBeSuccessfullyAdded()
        {
            Graph<string> graph = new Graph<string>();
            Vertex<string> vertexA = graph.AddVertex("A");
            Vertex<string> vertexB = graph.AddVertex("B");

            graph.AddEdge(vertexA, vertexB, 5);
        }

        [Fact]
        public void AllVerticesCanBeRetrieved()
        {
            Graph<string> graph = new Graph<string>();
            graph.AddVertex("A");
            graph.AddVertex("B");
            graph.AddVertex("C");

            var vertices = graph.GetVertices();

            Assert.Collection(vertices,
                v => Assert.Equal("A", v.Value),
                v => Assert.Equal("B", v.Value),
                v => Assert.Equal("C", v.Value));
        }

        [Fact]
        public void NeighborsCanBeRetrieved()
        {
            Graph<string> graph = new Graph<string>();
            Vertex<string> vertexA = graph.AddVertex("A");
            Vertex<string> vertexB = graph.AddVertex("B");
            graph.AddEdge(vertexA, vertexB, 3);

            var neighbors = graph.GetNeighbors(vertexA);
        }

        [Fact]
        public void NeighborsIncludeWeights()
        {
            Graph<string> graph = new Graph<string>();
            Vertex<string> vertexA = graph.AddVertex("A");
            Vertex<string> vertexB = graph.AddVertex("B");
            graph.AddEdge(vertexA, vertexB, 3);

            var neighbors = graph.GetNeighbors(vertexA);
        }

        [Fact]
        public void ProperSizeIsReturned()
        {
            Graph<string> graph = new Graph<string>();
            graph.AddVertex("A");
            graph.AddVertex("B");
            graph.AddVertex("C");

            int size = graph.Size();

            Assert.Equal(3, size);
        }

        [Fact]
        public void GraphWithOneVertexAndEdge()
        {
            Graph<string> graph = new Graph<string>();
            Vertex<string> vertexA = graph.AddVertex("A");
            Vertex<string> vertexB = graph.AddVertex("B");
            graph.AddEdge(vertexA, vertexB, 5);
        }
    }
}
