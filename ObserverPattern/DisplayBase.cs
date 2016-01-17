using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public abstract class DisplayBase
    {
        protected int Temperature { get; set; }

        protected int Humidity { get; set; }

        protected int Pressure { get; set; }

        public abstract void Display();
    }
}
