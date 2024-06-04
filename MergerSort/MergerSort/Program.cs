
using System;
using System.Collections.Concurrent;

namespace Sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] unordered = { 5,7,4, 3, 2, 1, 9, 8,6,10};
            Random rand = new Random();
            int[] unorderedIntegers = new int[100];

            for (int i = 0; i < 100; i++)
            {
                unorderedIntegers[i] = rand.Next(1, 1000);
            }

            Sorter sorterino = new Sorter();
            sorterino.MergeSort(unorderedIntegers);
            PrintIntArray(unorderedIntegers);
           
        }

        static void PrintIntArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

    }
}