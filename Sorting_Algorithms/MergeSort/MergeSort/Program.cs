using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merge sort:");
        }

        /// <summary>
        /// Merges two smaller arrays into a larger array in sorted order
        /// </summary>
        /// <param name="left">Left subarray</param>
        /// <param name="right">Right subarray</param>
        /// <param name="array">Sorted, merged array</param>
        /// <returns></returns>
        static int[] Merge(int[] left, int[] right, int[] array)
        {
            //Declare pointers for left, right, and resulting array
            int i = 0, j = 0, k = 0;

            //While the left and right arrays have values
            while(i < left.Length && j < right.Length)
            {
                //Put the values from the left and right arrays into the resulting array
                if(left[i] <= right[j])
                {
                    array[k] = left[i];
                    i++;
                }
                else
                {
                    array[k] = right[j];
                    j++;
                }
                k++;
            }

            //Fill the resulting array with the remainder from left or right
            if(i == left.Length)
            {
                Array.Copy(right, j, array, k, right.Length - j);
            }
            else
            {
                Array.Copy(left, i, array, k, left.Length - i);
            }
            return array;
        }

        static void MergeSort(int[] array)
        {
            //array.Length == 1 is the base case
            if (array.Length > 1)
            {
                //Establish subarray sizes
                int leftLength = array.Length / 2;
                int rightLength = array.Length - leftLength;

                //Copy first half of original array into left
                int[] left = new int[leftLength];
                Array.Copy(array, 0, left, 0, leftLength);

                //Do the same with the right
                int[] right = new int[rightLength];
                Array.Copy(array, array.Length / 2, right, 0, rightLength);

                //Sort left, then right, then merge
                MergeSort(left);
                MergeSort(right);
                Merge(left, right, array);
            }

        }
    }
}
