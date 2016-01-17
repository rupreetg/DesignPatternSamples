using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class TestEnumerator<T> : ITestEnumerator<T> where T : new()
    { 
        public bool HasMoreItems()
        {
            Console.WriteLine("Has More Items called from Test Enumerator instance");
            return true;
        }

        public T Next()
        {
            Console.WriteLine("Next called from TestEnumerator");
            return new T();      
        }
    }
}
