using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservePatternApp.Models
{
    internal class HumidityDisplay : IObserver
    {
        public void UpdateWeatherDetails(double temperature, double humidity)
        {
            Console.WriteLine("The Current Humidity is : " + humidity);
        }
    }
}
