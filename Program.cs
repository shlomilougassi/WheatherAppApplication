using System;

namespace WeatherApp
{
    class Program
    {
        public delegate void AnonymousPrint(ref IWeatherDataService service1);//ananymous method
        public static void Main(string[] args)
        {
            try
            {
                IWeatherDataService service = WeatherDataServiceFactory.getWeatherDataService(WeatherDataServiceFactory.OPEN_WEATHER_MAP);
                WeatherData weatherData = service.getWeatherData(new Location("London"));
                AnonymousPrint HowAmI = delegate (ref IWeatherDataService service1)
                {
                    Console.WriteLine("base object type of - " + service1.ToString());

                };
                weatherData.PrintData();
                HowAmI(ref service);
            }
            catch (WeatherDataException w)
            {
                Console.WriteLine(w.ToString());
            }
            finally
            {
                Console.ReadKey();
            }

        }
    }
}