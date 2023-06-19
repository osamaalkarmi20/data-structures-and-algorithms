using data_structures_and_algorithms;

namespace TestReserve
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            int[] array = { 1, 2, 3, 4, 5 };
            int key = 4;
            int result = Program.BinarySearch(array, key);
            Assert.Equal(4, result);

        }

        [Fact]
        public void Test2()
        {

            int[] array = { 1, 2, 3, 4, 5 };
            int key = 10;
            int result = Program.BinarySearch(array, key);
            Assert.Equal(-1, result);

        }

    }
}