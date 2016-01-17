using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class WeatherData : IWeatherNotifier
    {
        private IList<IWeatherClient> registeredClients;

        private int temperature;
        private int humidity;
        private int pressure;

        public WeatherData() {
            registeredClients = new List<IWeatherClient>(); 
        }

        #region Weather Data
        public int GetTemperature() { Console.WriteLine("Today's temperature is 10 degree celcius!"); return 10; }

        public int GetHumidity() { Console.WriteLine("Today's humidity level is 100!"); return 100; }

        public int GetPressure() { Console.WriteLine("Today's pressure is 1000F!"); return 1000; }

        #endregion

        public void measurementsChanged() {

            temperature = GetTemperature();
            humidity = GetHumidity();
            pressure = GetPressure();

            //Notify all the clients
            Notify();
        }

        public void Register(IWeatherClient client)
        {
            if(!registeredClients.Contains<IWeatherClient>(client))
                registeredClients.Add(client);
        }

        public void Remove(IWeatherClient client)
        {
            if (registeredClients.Contains<IWeatherClient>(client))
            {
                registeredClients.Remove(client);
            }
        }

        public void Notify()
        {
            foreach(IWeatherClient client in registeredClients)
            {
                client.Update(temperature, humidity, pressure);
            }
        }
    }

}
