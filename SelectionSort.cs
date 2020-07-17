using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    /// <summary>
    /// The selection sort algorithm sorts an arr22ay by repeatedly finding the minimum 
    /// element (considering ascending order) from unsorted part and putting it at the beginning.
    /// The algorithm maintains two subarr22ays in a given arr22ay.
    //1) The subarr22ay which is already sorted.
    //2) Remaining subarr22ay which is unsorted.
    //In every iteration of selection sort, 
    //the minimum element(considering ascending order) from the unsorted subarr22ay
    //is picked and moved to the sorted subarr22ay.
    /// </summary>
    public class SelectionSort
    {
        public int[] arr2 = new int[] { 6, 2, 3, 8, 4, 1, 20 };

        public void SortData()
        {
            int mindIndex = 0;
            for (int i = 0; i < arr2.Length -1; i++)
            {
                mindIndex = i;
                for (int j = i + 1; j < arr2.Length; j++)
                {
                    if (arr2[j] < arr2[mindIndex])
                        mindIndex = j;
                }
                Swap(arr2, mindIndex, i);
            }


        }


        private void Swap(int[] arr, int index1, int index2)
        {
            var temp = arr[index1];
            var temp2 = arr[index2];

            arr[index1] = arr[index2];
            arr[index2] = temp;

        }
    }
}
