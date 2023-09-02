using static data_structures_and_algorithms.Program;


namespace TestReserve
{

    public class UnitTest1
    {

        public class Sort
        {

            [Fact]
        public void TestMergeSort()
            {
                // Arrange
                int[] arr = { 12, 11, 13, 5, 6, 7 };
                int[] expectedSortedArr = { 5, 6, 7, 11, 12, 13 };

                // Act
                MergeSort(arr);

                // Assert
                Assert.Equal(expectedSortedArr, arr);
            }

            [Fact]
            public void TestMerge()
            {
                int[] left = { 5, 11, 13 };
                int[] right = { 6, 7, 12 };
                int[] expectedMergedArr = { 5, 6, 7, 11, 12, 13 };
                int[] mergedArr = new int[left.Length + right.Length];

                // Act
           Merge(left, right, mergedArr);

                // Assert
                Assert.Equal(expectedMergedArr, mergedArr);
            }
        }
    }
}