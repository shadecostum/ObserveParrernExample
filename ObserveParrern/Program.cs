using ObserveParrern.Models;

namespace ObserveParrern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherDetailsProvider weatherDetails = new WeatherDetailsProvider();

            NewAgencys agencysKerala = new NewAgencys("Kerala");

            weatherDetails.Register(agencysKerala);

            NewAgencys agencysMumbai = new NewAgencys("Mumbai");

            weatherDetails.Register(agencysMumbai);

            weatherDetails.UpdateTemperature(32f);
            weatherDetails.UpdateTemperature(30f);
            weatherDetails.UpdateTemperature(34f);
            weatherDetails.UpdateTemperature(22f);

        }
    }
}