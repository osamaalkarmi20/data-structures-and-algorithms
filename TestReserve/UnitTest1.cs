using data_structures_and_algorithms;
using static data_structures_and_algorithms.Program;

namespace TestReserve
{
    public class UnitTest1
    {

        [Fact]
        public void BusinessTrip_ShouldReturnCorrectCost_WhenValidInput()
        {
            Graph<string> graph = new Graph<string>();

            Vertex<string> pandora = graph.AddVertex("Pandora");
            Vertex<string> arendelle = graph.AddVertex("Arendelle");
            Vertex<string> metroville = graph.AddVertex("Metroville");
            Vertex<string> monstropolis = graph.AddVertex("New Monstropolis");
            Vertex<string> naboo = graph.AddVertex("Naboo");
            Vertex<string> narnia = graph.AddVertex("Narnia");

            graph.AddEdge(pandora, arendelle, 150);
            graph.AddEdge(pandora, metroville, 82);
            graph.AddEdge(arendelle, metroville, 99);
            graph.AddEdge(arendelle, monstropolis, 42);
            graph.AddEdge(monstropolis, metroville, 105);
            graph.AddEdge(monstropolis, naboo, 73);
            graph.AddEdge(metroville, naboo, 26);
            graph.AddEdge(naboo, narnia, 250);
            graph.AddEdge(narnia, metroville, 37);
      
            string[] input = { "Metroville", "Pandora" };
            int? cost = Program.BusinessTrip(graph, input);

            Assert.NotNull(cost);
            Assert.Equal(82, cost);
        }

        [Fact]
        public void BusinessTrip_ShouldReturnNull_WhenInvalidInput()
        {
            Graph<string> graph = new Graph<string>();

            Vertex<string> pandora = graph.AddVertex("Pandora");
            Vertex<string> arendelle = graph.AddVertex("Arendelle");
            Vertex<string> metroville = graph.AddVertex("Metroville");
            Vertex<string> monstropolis = graph.AddVertex("New Monstropolis");
            Vertex<string> naboo = graph.AddVertex("Naboo");
            Vertex<string> narnia = graph.AddVertex("Narnia");

            graph.AddEdge(pandora, arendelle, 150);
            graph.AddEdge(pandora, metroville, 82);
            graph.AddEdge(arendelle, metroville, 99);
            graph.AddEdge(arendelle, monstropolis, 42);
            graph.AddEdge(monstropolis, metroville, 105);
            graph.AddEdge(monstropolis, naboo, 73);
            graph.AddEdge(metroville, naboo, 26);
            graph.AddEdge(naboo, narnia, 250);
            graph.AddEdge(narnia, metroville, 37);
            
            string[] input = { "Naboo", "Pandora" };
            int? cost = Program.BusinessTrip(graph, input);

            Assert.Null(cost);
        }

        [Fact]
        public void BusinessTrip_ShouldReturnCorrectCost_WhenValidInput2()
        {
           
            Graph<string> graph = new Graph<string>();

            Vertex<string> pandora = graph.AddVertex("Pandora");
            Vertex<string> arendelle = graph.AddVertex("Arendelle");
            Vertex<string> metroville = graph.AddVertex("Metroville");
            Vertex<string> monstropolis = graph.AddVertex("New Monstropolis");
            Vertex<string> naboo = graph.AddVertex("Naboo");
            Vertex<string> narnia = graph.AddVertex("Narnia");

            graph.AddEdge(pandora, arendelle, 150);
            graph.AddEdge(pandora, metroville, 82);
            graph.AddEdge(arendelle, metroville, 99);
            graph.AddEdge(arendelle, monstropolis, 42);
            graph.AddEdge(monstropolis, metroville, 105);
            graph.AddEdge(monstropolis, naboo, 73);
            graph.AddEdge(metroville, naboo, 26);
            graph.AddEdge(naboo, narnia, 250);
            graph.AddEdge(narnia, metroville, 37);

          
            string[] input = { "Arendelle", "New Monstropolis", "Naboo" };
            int? cost = Program.BusinessTrip(graph, input);

            Assert.NotNull(cost);
            Assert.Equal(115, cost);
        }

        [Fact]
        public void BusinessTrip_ShouldReturnNull_WhenInvalidInput2()
        {
            

            Graph<string> graph = new Graph<string>();

            Vertex<string> pandora = graph.AddVertex("Pandora");
            Vertex<string> arendelle = graph.AddVertex("Arendelle");
            Vertex<string> metroville = graph.AddVertex("Metroville");
            Vertex<string> monstropolis = graph.AddVertex("New Monstropolis");
            Vertex<string> naboo = graph.AddVertex("Naboo");
            Vertex<string> narnia = graph.AddVertex("Narnia");

            graph.AddEdge(pandora, arendelle, 150);
            graph.AddEdge(pandora, metroville, 82);
            graph.AddEdge(arendelle, metroville, 99);
            graph.AddEdge(arendelle, monstropolis, 42);
            graph.AddEdge(monstropolis, metroville, 105);
            graph.AddEdge(monstropolis, naboo, 73);
            graph.AddEdge(metroville, naboo, 26);
            graph.AddEdge(naboo, narnia, 250);
            graph.AddEdge(narnia, metroville, 37);

         

            
            string[] input = { "Naboo", "Pandora" };
            int? cost = Program.BusinessTrip(graph, input);

           
            Assert.Null(cost);
        }

        [Fact]
        public void BusinessTrip_ShouldReturnNull_WhenOneCityNotFound()
        {
            

            Graph<string> graph = new Graph<string>();

            Vertex<string> pandora = graph.AddVertex("Pandora");
            Vertex<string> arendelle = graph.AddVertex("Arendelle");
            Vertex<string> metroville = graph.AddVertex("Metroville");
            Vertex<string> monstropolis = graph.AddVertex("New Monstropolis");
            Vertex<string> naboo = graph.AddVertex("Naboo");
            Vertex<string> narnia = graph.AddVertex("Narnia");

            graph.AddEdge(pandora, arendelle, 150);
            graph.AddEdge(pandora, metroville, 82);
            graph.AddEdge(arendelle, metroville, 99);
            graph.AddEdge(arendelle, monstropolis, 42);
            graph.AddEdge(monstropolis, metroville, 105);
            graph.AddEdge(monstropolis, naboo, 73);
            graph.AddEdge(metroville, naboo, 26);
            graph.AddEdge(naboo, narnia, 250);
            graph.AddEdge(narnia, metroville, 37);

           
            string[] input = { "Metroville", "Atlantis" };
            int? cost = Program.BusinessTrip(graph, input);

          
            Assert.Null(cost);
        }

        [Fact]
        public void BusinessTrip_ShouldReturnNull_WhenNoConnection()
        {

            Graph<string> graph = new Graph<string>();

            Vertex<string> pandora = graph.AddVertex("Pandora");
            Vertex<string> arendelle = graph.AddVertex("Arendelle");
            Vertex<string> metroville = graph.AddVertex("Metroville");
            Vertex<string> monstropolis = graph.AddVertex("New Monstropolis");
            Vertex<string> naboo = graph.AddVertex("Naboo");
            Vertex<string> narnia = graph.AddVertex("Narnia");

            graph.AddEdge(pandora, arendelle, 150);
            graph.AddEdge(pandora, metroville, 82);
            graph.AddEdge(arendelle, metroville, 99);
            graph.AddEdge(arendelle, monstropolis, 42);
            graph.AddEdge(monstropolis, metroville, 105);
            graph.AddEdge(monstropolis, naboo, 73);
            graph.AddEdge(metroville, naboo, 26);
            graph.AddEdge(naboo, narnia, 250);
            graph.AddEdge(narnia, metroville, 37);
            
            string[] input = { "Pandora", "Naboo" };
            int? cost = Program.BusinessTrip(graph, input);

            
            Assert.Null(cost);
        }
    }
}
