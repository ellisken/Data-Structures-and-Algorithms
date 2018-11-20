using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void InsertionSort(int[] input)
        {
            //Starting from the second element in the array
            for(int i=1; i < input.Length; i++)
            {
                //Set temp variable equal to that element
                int temp = input[i];
                //Create another index that is the previous element
                int j = i - 1;
                //While the second index is larger than zero and the temporary
                //value is less than that second input
                while (j >= 0 && temp < input[j])
                {
                    //Move the second index's value one to the right
                    input[j + 1] = input[j];
                    j--;
                }
                //Put the current element in it's sorted place
                input[j + 1] = temp;
            }
        }
    }
}
