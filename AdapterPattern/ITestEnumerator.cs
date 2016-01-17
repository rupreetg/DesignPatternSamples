using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public interface ITestEnumerator<T>
    {
        bool HasMoreItems(); //does the enumerator has more items?

        T Next(); //get next item
    }
}
