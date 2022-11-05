using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 6, 2, 4, 3 };

            Console.WriteLine("BubbleSort");
            BubbleSort sort = new BubbleSort();
            sort.SortData(arr);
            arr.ToList().ForEach(s => Console.WriteLine(s.ToString()));

           // Console.WriteLine("SelectionSort ");
           // SelectionSort selectionSort = new SelectionSort();
           // selectionSort.SortData();
           // selectionSort.arr2.ToList().ForEach(s => Console.WriteLine(s.ToString()));



           // Console.WriteLine("Insertion Sort");
           // InsertionSort InsertionSort = new InsertionSort();
           // InsertionSort.sort(arr);
           //arr.ToList().ForEach(s => Console.WriteLine(s.ToString()));


            Console.ReadLine();

        }
    }
}
