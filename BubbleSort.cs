using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class BubbleSort
    {
        //Bubble Sort is the simplest sorting algorithm that works by repeatedly swapping the adjacent elements if they are in wrong order.
        public void SortData(int [] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                for (int j = 1; j < arr.Length; j++)
                    if (arr[j] < arr[j - 1])
                        Swap(arr, j, j - 1);

        }

        private void Swap(int[] arr , int index1, int index2)
        {
            var temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;

        }

    }
}
