using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quicksort:");
        }

        static void QuickSort(int[] arr, int left, int right)
        {
            if(left < right)
            {  
                //Partition and get position of pivot
                int position = Partition(arr, left, right);
                //Sort of bottom half recursively
                QuickSort(arr, left, position - 1);
                //Sort the top half recursively
                QuickSort(arr, position + 1, right);
            }
        }


    }
}
