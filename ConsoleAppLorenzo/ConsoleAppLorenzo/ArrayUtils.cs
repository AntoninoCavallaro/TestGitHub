using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLorenzo
{
    internal static class ArrayUtils
    {
        public static int FindIndexOfMin(int[] array, int from, int to)
        {
            int minIndex = from;
            for (int i = from; i <= to; i++)
            {
                if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }
            }
            return minIndex;
        }

        public static int FindIndexOfMin(int[] array)
        {
            int valueMin = array[0];
            int indexMin = 0;
            int size = array.Length;

            for (int i = 0; i < size; i++)
            {
                if (array[i] < valueMin)
                {
                    valueMin = array[i];
                    indexMin = i;
                }
            }
            return indexMin;
        }


    }
}
