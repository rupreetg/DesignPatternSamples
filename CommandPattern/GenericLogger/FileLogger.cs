using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.GenericLogger
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("{0} executed -- {1}", nameof(FileLogger), message);
            //throw new NotImplementedException();
        }
    }
}
