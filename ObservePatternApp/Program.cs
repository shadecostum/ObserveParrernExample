using ObservePatternApp.Models;

namespace ObservePatternApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           WeatherStation station=new WeatherStation();

            TemperaturteDisplay temperaturteDisplay = new TemperaturteDisplay();
            HumidityDisplay humidityDisplay = new HumidityDisplay();

            station.RegisterObserver(temperaturteDisplay);
            station.RegisterObserver(humidityDisplay);

           // station.RemoveRegisterd(humidityDisplay);

            station.UpdateWeather(32, 22);


        }
    }
}