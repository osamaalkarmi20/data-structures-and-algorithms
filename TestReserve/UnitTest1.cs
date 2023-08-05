using static data_structures_and_algorithms.Program;


namespace TestReserve
{

    public class UnitTest1
    {

        public class BinarySearchTreeTests
        {

            [Fact]
            public void BFStest()
            {


                BinaryTree binaryTree = new BinaryTree();
                binaryTree.Add(2);
                binaryTree.Add(7);
                binaryTree.Add(5);
                binaryTree.Add(2);
                binaryTree.Add(6);
                binaryTree.Add(9);
                binaryTree.Add(5);
                binaryTree.Add(11);
                binaryTree.Add(4);

                List<int> result = binaryTree.BFS(binaryTree.Root);


                List<int> expected = new List<int> { 2, 7, 5, 2, 6, 9, 5, 11, 4 };
                Assert.Equal(expected, result);
            }
        }
    }
}