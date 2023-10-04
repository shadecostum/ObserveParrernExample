using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservePatternApp.Models
{
    internal interface IObserver
    {
        void UpdateWeatherDetails(double temperature, double humidity);

    }
}
