using System;
using System.Collections.Generic;

namespace data_structures_and_algorithms
{
    public class Program
    {
        static void Main(string[] args)
        {

            {
                int[] arr = { 8,4,23,42,16,15};
                Console.WriteLine("Original array:");
                PrintArray(arr);

                MergeSort(arr);

                Console.WriteLine("\nSorted array:");
                PrintArray(arr);
            }

        }
        public static void MergeSort(int[] arr)
        {
            int n = arr.Length;
            if (n > 1)
            {
                int mid = n / 2;
                int[] left = new int[mid];
                int[] right = new int[n - mid];

                for (int i = 0; i < mid; i++)
                {
                    left[i] = arr[i];
                }

                for (int i = mid; i < n; i++)
                {
                    right[i - mid] = arr[i];
                }

                MergeSort(left);
                MergeSort(right);

                Merge(left, right, arr);

            }
        }

        public static void Merge(int[] left, int[] right, int[] arr)
        {
            int i = 0, j = 0, k = 0;
            int leftLength = left.Length;
            int rightLength = right.Length;

            while (i < leftLength && j < rightLength)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }

            while (i < leftLength)
            {
                arr[k] = left[i];
                i++;
                k++;
            }

            while (j < rightLength)
            {
                arr[k] = right[j];
                j++;
                k++;
            }
        }

        public static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            return arr;

        }

    }
}