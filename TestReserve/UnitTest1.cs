using data_structures_and_algorithms;

namespace TestReserve
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] array = { 3,4,5,6 };
            int[] array2 = { 6, 5, 4, 3 };
            int[] result = Program.ReverseArray(array);
            Assert.Equal(result, array2);
        }
        [Fact]
        public void Test2()
        {
            int[] array = {};
            
            int[] result = Program.ReverseArray(array);
            Assert.Equal(result, null);
        }
    }
}