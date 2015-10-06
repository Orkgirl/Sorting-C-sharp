using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSorting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Sorting sort = new Sorting();
            sort.printArray(sort.bubbleSort(sort.getActualArray()));
            sort.printArray(sort.gnomeSort(sort.getActualArray()));

            int[] array = { 1, 4, 8, 11, 15};
            Sorting sorting = new Sorting(array, array.Length);
            sorting.printArray(sorting.bubbleSort(sorting.getArray()));
            sorting.printArray(sorting.gnomeSort(sorting.getArray()));
            Console.Read();

        }
    }
}
