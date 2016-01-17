using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class TestIterator<T> : ITestIterator<T> where T : new()
    {
        public bool HasNext()
        {
            Console.WriteLine("Has Next Iterator called from Test Iterator");
            return true;
        }

        public T Next()
        {
            Console.WriteLine("Next called from TestIterator");
            return new T();
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }
    }
}
