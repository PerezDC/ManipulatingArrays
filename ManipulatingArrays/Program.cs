using Microsoft.VisualBasic.CompilerServices;
using System;

namespace ManipulatingArrays
{
    class Program
    {
        static void countArray(int[] myarray)
        {
            string eles = sizeof(myarray)/1;
            Console.WriteLine($"There are {sizeof(myarray)} elements in the array.");
        }

        static void Main(string[] args)
        {
            //Array A: 0, 2, 4, 6, 8, 10
            //Array B: 1, 3, 5, 7, 9
            //Array C: 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9

            int[] arrayA = { 0, 2, 4, 6, 8, 10 };
            int[] arrayB = new int[5] { 1, 3, 5, 7, 9 };
            int[] arrayC = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            countArray(arrayB);
        }
    }
}
