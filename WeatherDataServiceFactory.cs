using System;

namespace WeatherApp{
   public abstract class WeatherDataServiceFactory: WeatherData, IWeatherDataService
    {
        public const String OPEN_WEATHER_MAP = "OPEN_WEATHER_MAP";
        //public const String OTHER_WEATHER_SOURCE = "OTHER_WEATHER_SOURCE";

        public static WeatherDataServiceFactory getWeatherDataService(String Source){
            try
            {
                if (Source.Equals(OPEN_WEATHER_MAP)) return WeatherMap.Instance();
                else throw new WeatherDataException("input is wrong!");
            }
            finally { }       
        }
        virtual public WeatherDataServiceFactory getWeatherData(Location location) { return null; }
    }
}