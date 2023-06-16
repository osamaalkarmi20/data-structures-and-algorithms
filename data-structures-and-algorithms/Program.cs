namespace data_structures_and_algorithms
{
   public class Program
    {
        static void Main()
        {
            int[] array = { 4,3,5,6 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");

            }
            Console.Write(" ");
            int[] reversedArray = ReverseArray(array);
            for (int i = 0; i < reversedArray.Length; i++)
            {
                Console.WriteLine(reversedArray[i]);

            }
        }
        public static int[] ReverseArray(int[] oldArray)
        {
            if (oldArray.Length <= 0)
            { return null; 
            }
            else
            {
                int[] newArray = new int[oldArray.Length];
                int newArrayIndex = 0;
                for (int i = oldArray.Length-1; i >= 0; i--)
                {
                    newArray[newArrayIndex] = oldArray[i];
                    newArrayIndex++;
                }
                return newArray;

            }
        }

    }
}