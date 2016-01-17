using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class ChannelControl
    {
        public void IncreaseChannel()
        {
            Console.WriteLine("Channel Increase by 1");
        }

        public void DecreaseChannel()
        {
            Console.WriteLine("Channel Decrease by 1");
        }
    }
}
