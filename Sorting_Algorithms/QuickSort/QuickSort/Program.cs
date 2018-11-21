using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quicksort:");
            int[] arr = { 15, 6, 3, 90, 21, 500, -1};
            Console.WriteLine("Initial array:");
            Console.WriteLine(string.Join(",", arr));
            Console.WriteLine("\n");
            Console.WriteLine("Calling QuickSort...");
            Console.WriteLine("\n");
            QuickSort(arr, 0, arr.Length - 1);
            Console.WriteLine("Resulting array:");
            Console.WriteLine(string.Join(",", arr));
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

        static int Partition(int[] arr, int left, int right)
        {
            //Set pivot to right-most element
            int pivot = arr[right];
            //Set low to one index below the left-most value
            int low = left - 1;

            //While i (which starts at left) is less than right
            for(int i=left; i < right; i++)
            {
                //If the element at the left is <= to the pivot value,
                //move it into the "lower than pivot" subarray
                if(arr[i] <= pivot)
                {
                    low++;
                    Swap(arr, low, i);
                }
            }
            //Put pivot element into its rightful place
            Swap(arr, low + 1, right);
            //Return its position
            return low + 1;
        }

        static void Swap(int[] arr, int low, int i)
        {
            int temp;
            temp = arr[low];
            arr[low] = arr[i];
            arr[i] = temp;
        }

    }
}
