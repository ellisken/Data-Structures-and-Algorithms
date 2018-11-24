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


    }
}
