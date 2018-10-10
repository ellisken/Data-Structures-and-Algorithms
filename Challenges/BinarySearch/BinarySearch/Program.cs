using System;

namespace BinarySearch
{
    public class Program
    {
        static void Main()
        {
            int[] testArray = { 0, 5, 10, 23, 41 };
            Console.WriteLine("{0}", BinarySearch(testArray, 5));
        }

        /// <summary>
        /// Performs binary search of an array of ints
        /// </summary>
        /// <param name="array">Sorted array of ints (ascending)</param>
        /// <param name="target">Target int</param>
        /// <returns>The index of the target int (if found), else -1.</returns>
        public static int BinarySearch(int[] array, int target)
        {
            //Set start and end indices
            int start = 0;
            int end = array.Length - 1;

            while(start <= end)
            {
                //Set middle index
                int middle = (start + end) / 2;
                //If target found, return index
                if (array[middle] == target) return middle;
                //If target < middle value, search lower half of array
                else if (target < array[middle]) end = middle - 1;
                //Else, search upper half
                else start = middle + 1;
            }
            //Default return -1 (i.e., target value not found)
            return -1;
        }
    }
}
