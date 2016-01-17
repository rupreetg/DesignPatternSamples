using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class VolumeChangeCommand : ICommand
    {
        VolumeControl volumeControl;

        public VolumeChangeCommand(VolumeControl _volumeControl)
        {
            volumeControl = _volumeControl;
        }

        public void Execute()
        {
            Console.WriteLine("Volume Command Executed");
            volumeControl.IncreaseVolume();
        }

        public void Undo()
        {
            Console.WriteLine("Volume Command Undo");
            volumeControl.DecreaseVolume();
        }
    }
}
