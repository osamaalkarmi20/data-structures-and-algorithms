using static data_structures_and_algorithms.Program;


namespace TestReserve
{

    public class UnitTest1
    {

        public class BinarySearchTreeTests
        {

            [Fact]
            public void FizzBuzzTreetest()
            {


                BinaryTree binaryTree = new BinaryTree();
                binaryTree.Add("2");
                binaryTree.Add("30");
                binaryTree.Add("5");
                binaryTree.Add("2");
                binaryTree.Add("6");
                binaryTree.Add("45");
                binaryTree.Add("5");
                binaryTree.Add("15");
                binaryTree.Add("1");


                binaryTree.FizzBuzzTree();
                List<string> result = binaryTree.BFS(binaryTree.Root);

                List<string> expected = new List<string>
                { "2", "FizzBuzz", "Buzz", "2" ,"Fizz" , "FizzBuzz", "Buzz", "FizzBuzz", "1"};
                Assert.Equal(expected, result);
            }
        }
    }
}