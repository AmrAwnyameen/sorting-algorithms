﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class BubbleSort
    {
        //Bubble Sort is the simplest sorting algorithm that works by repeatedly swapping the adjacent elements if they are in wrong order.
        //Example:
        //First Pass:
        //( 5 1 4 2 8 ) –> ( 1 5 4 2 8 ), Here, algorithm compares the first two elements, and swaps since 5 > 1.
        //( 1 5 4 2 8 ) –>  ( 1 4 5 2 8 ), Swap since 5 > 4
        //( 1 4 5 2 8 ) –>  ( 1 4 2 5 8 ), Swap since 5 > 2
        //( 1 4 2 5 8 ) –> ( 1 4 2 5 8 ), Now, since these elements are already in order(8 > 5), algorithm does not swap them.

        //Second Pass:
        //( 1 4 2 5 8 ) –> ( 1 4 2 5 8 )
        //( 1 4 2 5 8 ) –> ( 1 2 4 5 8 ), Swap since 4 > 2
        //( 1 2 4 5 8 ) –> ( 1 2 4 5 8 )
        //( 1 2 4 5 8 ) –>  ( 1 2 4 5 8 )
        //Now, the array is already sorted, but our algorithm does not know if it is completed.The algorithm needs one whole pass without any swap to know it is sorted.

        //Third Pass:
        //( 1 2 4 5 8 ) –> ( 1 2 4 5 8 )
        //( 1 2 4 5 8 ) –> ( 1 2 4 5 8 )
        //( 1 2 4 5 8 ) –> ( 1 2 4 5 8 )
        //( 1 2 4 5 8 ) –> ( 1 2 4 5 8 )
        
        public void SortData(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                for (int j = 1; j < arr.Length; j++)
                    if (arr[j] < arr[j - 1])
                        Swap(arr, j, j - 1);
        }

        public void OptomizeSortData(int[] arr)
        {
            bool swapped;
            for (int i = 0; i < arr.Length; i++)
            {
                swapped = false;
                for (int j = 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        Swap(arr, j, j - 1);
                        swapped = true;
                    }
                }
                if (swapped == false)
                    break;
            }


        }

        private void Swap(int[] arr, int j, int j2)
        {
            var temp = arr[j];
            arr[j] = arr[j2];
            arr[j2] = temp;

        }

    }
}
