using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservePatternApp.Models
{
    public class WeatherStation
    {
        public double Humidity;
        public double Temperature;

       
         private List<IObserver> observables = new List<IObserver>();



        internal void RegisterObserver(IObserver observ)
        {
            observables.Add(observ);
        }

        internal void RemoveRegisterd(IObserver observer) 
        {
           observables.Remove(observer);
        }


        public void UpdateWeather(double temperature,double humidity)
        {
            Temperature = temperature;
            Humidity = humidity;
            NotifyObserver();
        }

        private void NotifyObserver()
        {
            foreach (IObserver observerr in observables) 
            {
                observerr.UpdateWeatherDetails(Temperature, Humidity);
            }
           
        }
    }
}
