using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class VolumeControl
    {
        public void IncreaseVolume()
        {
            Console.WriteLine("Volume Increasing...");
        }

        public void DecreaseVolume()
        {
            Console.WriteLine("Volume Decreasng...");
        }
    }
}
