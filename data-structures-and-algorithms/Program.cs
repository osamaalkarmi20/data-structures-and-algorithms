using System;
using System.Collections.Generic;

namespace data_structures_and_algorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            int[] arr = { 8, 4, 23, 42, 16, 15 };
            int[] arrsorted = InsertionSort(arr);
            for (int i = 0; i < arrsorted.Length; i++) {
                Console.WriteLine(arrsorted[i]);
            
            }
        }

        static public int[] InsertionSort(int[] arr)
        {
            int key, j;
            int n = arr.Length;

            for (int i = 1; i < n; i++)
            {
                key = arr[i];
                j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = key;
            }

            return arr;
        }

    }
}