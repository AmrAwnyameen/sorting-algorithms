using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    public static class CountSort
    {
        //[]
       //big o spance = o(n)
        public static void CountSortArray(int[] array)
        {
            var counts = new int[GetMaxArraValue(array) + 1];
            foreach (var item in array)
                counts[item]++;

            var k = 0;
            for (int i = 0; i < counts.Length; i++)
            {
                for (int j = 0; j < counts[i]; j++)
                {
                    array[k++] = i;
                }
            }
        }

        public static void CountSortArrayWhile(int[] array)
        {
            var counts = new int[GetMaxArraValue(array) + 1];
            foreach (var item in array)
                counts[item]++;

            var k = 0;
            for (int i = 0; i < counts.Length; i++)
            {
                while(counts[i]  > 0)
                {
                    array[k++] = i;
                    counts[i]--;
                }
            }
        }

        public static int GetMaxArraValue(int[] arr)
        {
            //{ 5, 2, 4, 6 }
            var min = arr[0];
            var max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];

                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }
    }
}
