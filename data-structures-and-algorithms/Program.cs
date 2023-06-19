namespace data_structures_and_algorithms
{
    public class Program
    {
        static void Main()
        {

            int[] array = { 1, 2, 3, 4, 5 };
            int key = 4;
            Console.WriteLine(BinarySearch(array, key));

        }


        public static int BinarySearch(int[] array, int key)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == key)
                    return mid + 1;

                if (array[mid] < key)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }




    }
}
