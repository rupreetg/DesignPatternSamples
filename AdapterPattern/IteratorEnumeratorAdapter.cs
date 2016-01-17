using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class IteratorEnumeratorAdapter<T> : ITestEnumerator<T>
    {
        ITestIterator<T> iterator;

        public IteratorEnumeratorAdapter(ITestIterator<T> _iterator)
        {
            iterator = _iterator;
        }

        public bool HasMoreItems()
        {
            Console.WriteLine("Has More Items called from IteratorEnumeratorAdapter");
            return iterator.HasNext();
        }

        public T Next()
        {
            Console.WriteLine("Next called from IteratorEnumeratorAdapter");
            return iterator.Next();
        }
    }
}
