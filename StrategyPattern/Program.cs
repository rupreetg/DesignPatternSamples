using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList students = new SortedList();
            students.Add("Rose");
            students.Add("Lily");
            students.Add("sunflower");

            students.SelectSortingAlgo(new MergeSort());
            students.Sort();

            students.SelectSortingAlgo(new BubbleSort());
            students.Sort();
        }
    }
}
