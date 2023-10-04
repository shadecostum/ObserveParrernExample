using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserveParrern.Models
{
    internal class WeatherDetailsProvider : Isubject
    {
        private List<IAgencys> Agencys;

        public float Temperature;

      

        public WeatherDetailsProvider()
        {
           Agencys = new List<IAgencys>();
        }
        
       

        public void Register(IAgencys agency)
        {
            Agencys.Add(agency);
        }

       

        public void UpdateTemperature(float temperature) 
        {
            Temperature = temperature;
            Notify();
        }
        public void Notify()
        {
            foreach (var agency in Agencys)
            {
                agency.UpdateTEmperature(Temperature);
            }
        }
    }
}
