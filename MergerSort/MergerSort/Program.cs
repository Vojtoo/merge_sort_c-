
using System;
using System.Collections.Concurrent;

namespace Sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] unordered = { 5, 1, 3, 2, 7, 8, 6, 4 };

            
            Sorter sorterino = new Sorter();
            sorterino.BubbleSort(unordered);
            PrintIntArray(unordered);
           
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