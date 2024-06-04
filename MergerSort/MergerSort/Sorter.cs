using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter
{
    class Sorter
    {


        public int[] BubbleSort(int[] array)
        {
            int[] sorted_array = array;

            for (int i = 0; i < sorted_array.Length - 1; i++)
            {

                bool swap = false;

                for (int j = 0; j < sorted_array.Length - 1; j++)
                {
                    if (sorted_array[j] > sorted_array[j + 1])
                    {
                        swap = true;
                        int temp = sorted_array[j];
                        sorted_array[j] = sorted_array[j + 1];
                        sorted_array[j + 1] = temp;
                    }
                }

                if (!swap)
                {
                    return sorted_array;
                }

            }


            return sorted_array;
        }

        public int[] MergeSort(int[] array)
        {
           
            //base case
            if (array.Length == 1)
            {
                return array;
            }

            // creating two deep copies of arg. array's halves
            int[] left_half_array = new int[array.Length / 2];
            Array.Copy(array, left_half_array, left_half_array.Length);

            int[] right_half_array = new int[array.Length - array.Length / 2];
            Array.Copy(array, left_half_array.Length, right_half_array, 0, right_half_array.Length);


            // checking whether further division is needed

            MergeSort(left_half_array);
            MergeSort(right_half_array);

            Merge(array, left_half_array,right_half_array);

            return array;
        }


        private int[] Merge(int[] dest_array, int[] left_array, int[] right_array)
        {

            int dest_index = 0;
            int left_index = 0;
            int right_index = 0;


            while (left_index < left_array.Length && right_index < right_array.Length)
            {
                if (left_array[left_index] < right_array[right_index])
                {
                    dest_array[dest_index++] = left_array[left_index++];
                }
                else
                {
                    dest_array[dest_index++] = right_array[right_index++];
                }

            }
            
            while(left_index < left_array.Length)
            {
                dest_array[dest_index++] = left_array[left_index++];

            }
            while(right_index < right_array.Length)
            {
                dest_array[dest_index++] = right_array[right_index++];
            }
                



                return dest_array;
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
