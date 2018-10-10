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

        public static int BinarySearch(int[] array, int target)
        {
            //Set start and end indices
            int start = 0;
            int end = array.Length - 1;

            while(start <= end)
            {
                //Set middle index
                int middle = Convert.ToInt32(Math.Floor((start + end) / 2.0));
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
