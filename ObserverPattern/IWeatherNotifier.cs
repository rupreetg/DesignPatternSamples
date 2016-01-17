using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface IWeatherNotifier
    {
        void Register(IWeatherClient client);

        void Remove(IWeatherClient client);

        void Notify();
    }
}
