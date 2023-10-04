using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservePatternApp.Models
{
    internal class TemperaturteDisplay:IObserver
    {
        public void UpdateWeatherDetails(double temperature, double humidity)
        {
            Console.WriteLine("The Current Temperature is : " + temperature);
        }
    }
}
