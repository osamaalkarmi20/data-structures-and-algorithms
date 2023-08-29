using data_structures_and_algorithms;
using static data_structures_and_algorithms.Program;


namespace TestReserve
{

    public class UnitTest1
    {

        [Theory]
        [InlineData(new[] { 8, 4, 23, 42, 16, 15 }, new[] { 4, 8, 15, 16, 23, 42 })]
        [InlineData(new[] { 3, 1, 7, 2, 5 }, new[] { 1, 2, 3, 5, 7 })]
        [InlineData(new[] { 10, 9, 8, 7, 6, 5 }, new[] { 5, 6, 7, 8, 9, 10 })]
        
        public void InsertionSort(int[] arr, int[] expected)
        {
            int[] result = Program.InsertionSort(arr);
            Assert.Equal(expected, result);
        }
    }
}