using data_structures_and_algorithms;

namespace TestReserve
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int value = 10;
            int[] array = { 3,4,5,6 };
            int[] shifted = { 3, 4, 10, 5, 6 };
           
            int[] result = Program.InsertShiftArray(array ,value);
            Assert.Equal(result, shifted);
        }

        [Fact]
        public void Test2()
        {
            int value = 10;
            int[] array = { };
            int[] shifted = null;

            int[] result = Program.InsertShiftArray(array, value);
            Assert.Equal(result, shifted);
        }

    }
}