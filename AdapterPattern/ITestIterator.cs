using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public interface ITestIterator<T>
    {
        bool HasNext();

        T Next();

        void Remove();
    }
}
