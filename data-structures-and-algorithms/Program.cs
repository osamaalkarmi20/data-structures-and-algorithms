namespace data_structures_and_algorithms
{
   public class Program
    {
        static void Main()
        {
            int[] array = { 4,3,5,6 };
            int midNum = 12;
            int[] InsertArray = InsertShiftArray(array , midNum);
            for (int i = 0; i < InsertArray.Length; i++)
            {
                Console.WriteLine(InsertArray[i]);

            }
        }
        public static int[] InsertShiftArray(int[] array, int midNum)
        {if (array.Length <= 0)
            {
                return null;
            }
else
            {

                int[] newArray = new int[array.Length + 1];
                int midIndex = array.Length / 2;

                for (int i = 0, j = 0; i <= array.Length; i++, j++)
                {
                    if (i == midIndex)
                    {
                        newArray[i] = midNum;
                        j--;
                    }
                    else
                    {
                        newArray[i] = array[j];
                    }
                }

                return newArray;
            }
        
        }


    }
}