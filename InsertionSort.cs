using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    /// <summary>
    //Insertion sort is a simple sorting algorithm that works the way we sort playing cards in our hands.
    /// </summary>                        
    public class InsertionSort
    {
        //var arr = new int[] { 6, 2, 3, 4, };
        public void sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                var current = arr[i];
                var previous = arr[i - 1];
                var previousIndex = i - 1;
                while(previousIndex >= 0 && arr[previousIndex] > current)
                {
                    arr[previousIndex + 1] = arr[previousIndex];
                    previousIndex = previousIndex - 1;
                
                }
                arr[previousIndex + 1] = current;

            }
        }
    }
}
