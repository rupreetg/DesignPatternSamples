using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ITestEnumerator<TestClass> enumerator = new TestEnumerator<TestClass>();
            enumerator.HasMoreItems();
            enumerator.Next();

            Console.WriteLine("-----------------------------------");

            ITestIterator<TestClass> iterator = new TestIterator<TestClass>();
            iterator.HasNext();
            iterator.Next();

            Console.WriteLine("-----------------------------------");

            ITestEnumerator<TestClass> adapter = new IteratorEnumeratorAdapter<TestClass>(iterator);
            adapter.HasMoreItems();
            adapter.Next();

        }
    }
}
