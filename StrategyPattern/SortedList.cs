using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class SortedList
    {
        private List<string> list = new List<string>();
        private SortBase sortStrategy;

        public void Add(string item)
        {
            list.Add(item);
        }

        public void SelectSortingAlgo(SortBase sortingAlgo)
        {
            sortStrategy = sortingAlgo;
        }

        public void Sort()
        {
            sortStrategy.Sort(list);
        }
    }
}
