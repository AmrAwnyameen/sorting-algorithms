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
            BubbleSort sort = new BubbleSort();
            var arr = new int[] { 6, 2, 3, 0, 8, 4, 9, 1 };
            sort.SortData(arr);
            arr.ToList().ForEach(s => Console.WriteLine(s.ToString()));
            Console.ReadLine();

        }
    }
}
