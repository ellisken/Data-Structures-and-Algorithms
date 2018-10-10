using System;

namespace arrayShift
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare some test arrays
            int[][] testArrays =
            {
                new int[] { 3, 1, -2, 94 }, //even number of elements
                new int[] { 4, 5, 6 }, //odd number of elements
                new int[] { 1 }, //one element
                new int[] { } //empty array
            };

            //Show initial arrays
            Console.WriteLine("This program tests insertion into the following arrays:");
            foreach (int[] array in testArrays)
            {
                Console.WriteLine($"[{string.Join(",", array)}]");
            }

            Console.WriteLine();

            //Test insertion of the number 99 into each arr
            //and print the resulting arrays to the console
            Console.WriteLine("After inserting 99 into each array:");
            foreach (int[] array in testArrays)
            {
                Console.WriteLine($"[{string.Join(",", ArrayShift(array, 99))}]");
            }
        }


        static int[] ArrayShift(int[] arr, int num)
        {
            //Create new array
            int[] newArr = new int[arr.Length + 1];

            //Find middle index
            int middleIndex = arr.Length / 2;
            if (arr.Length % 2 != 0) middleIndex += 1;

            //Fill new array
            for (int i = 0; i < newArr.Length; i++)
            {
                if (i < middleIndex) newArr[i] = arr[i];
                else if (i == middleIndex) newArr[i] = num;
                else newArr[i] = arr[i - 1];
            }

            return newArr;
        }
    }
}
