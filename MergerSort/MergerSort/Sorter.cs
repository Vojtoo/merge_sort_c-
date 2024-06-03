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

            for (int i = 0; i < sorted_array.Length-1; i++)
            {
                for (int j = i; j < sorted_array.Length-1; j++)
                {
                    if (sorted_array[j] > sorted_array[j+1])
                    {
                        int temp = sorted_array[j];
                        sorted_array[j] = sorted_array[j+1];
                        sorted_array[j+1] = temp;
                    }
                }

            }


            return sorted_array;
        }

    }
}
