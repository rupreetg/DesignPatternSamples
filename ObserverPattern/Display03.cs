﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Display03 : DisplayBase, IWeatherClient
    {
        public override void Display()
        {
            Console.WriteLine("Display03::: Temperature: {0}, Humitidy: {1}, Pressure: {2}", Temperature, Humidity, Pressure);
        }

        public void Update(int temperature, int humidity, int pressure)
        {
            //Console.WriteLine("Temperature: {0}, Humitidy: {1}, Pressure: {2}", temperature, humidity, pressure);
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
        }
    }
}
