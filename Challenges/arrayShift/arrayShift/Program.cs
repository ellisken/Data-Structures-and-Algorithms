using System;

namespace arrayShift
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare some test arrays
            int[] arr1 = { 3, 1, -2, 94 }, arr2 = { 4, 5, 6 }, arr3 = { 1 }, arr4 = { };
     
            
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
