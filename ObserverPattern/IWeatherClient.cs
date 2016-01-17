using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface IWeatherClient
    {
        void Update(int temperature, int humidity, int pressure);
    }
}
