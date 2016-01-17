using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class ChannelChangeCommand : ICommand
    {
        ChannelControl channelControl; 

        public ChannelChangeCommand(ChannelControl _channelControl)
        {
            channelControl = _channelControl;
        }
        
        public void Execute()
        {
            Console.WriteLine("Channel Command Executed");
            channelControl.IncreaseChannel();
        }

        public void Undo()
        {
            Console.WriteLine("Channel Command Undo");
            channelControl.DecreaseChannel();
        }
    }
}
