using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Display01 display01 = new Display01();
            display01.Display();

            Display02 display02 = new Display02();
            display02.Display();

            Display03 display03 = new Display03();
            display03.Display();

            WeatherData weatherData = new WeatherData();
            weatherData.Register(display01);
            weatherData.Register(display02);
            weatherData.Register(display03);

            weatherData.measurementsChanged();
            //weatherData.Notify();

            display01.Display();
            display02.Display();
            display03.Display();

        }
    }
}
