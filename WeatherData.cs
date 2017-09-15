using System;

namespace WeatherApp
{
    public abstract class WeatherData
    {
        const double Kalvin = 273.15;
        private Location location;
        public Location Location
        {
            get { return location; }
            set { location = value; }
        }

        public WeatherData() { this.location = new Location(null); }


        public void PrintData()
        {
            double TemperatureCelsius = Convert.ToDouble(location.Temperature) - Kalvin;
            double TemperatureCelsiusMax = Convert.ToDouble(location.TemperatureMax) - Kalvin;
            double TemperatureCelsiusMin = Convert.ToDouble(location.TemperatureMin) - Kalvin;
            for (int i = 0; i < 20; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine(
               "\nThe Weather of " + Location.Country +", "+ location.City + " is:\n" +
               "Tempature is  : " + Location.Temperature + " Kalvin\n" +
               "Tempature is  : " + TemperatureCelsius + " Celsius\n" +
               "Max Tempature is  : " + TemperatureCelsiusMax + " Celsius\n" +
               "Min Tempature is  : " + TemperatureCelsiusMin + " Celsius\n" +
               "Sunrise is : " + Location.Sunrise + "\n" +
               "Sunset is : " + Location.Sunset + "\n" +
               "Clouds status is : " + Location.Cloud + "\n" +
               "Wind Speed is : " + Location.Wind + ", wind's speed is:"+ Location.WindDir+ ", and the wind's deg. is :"+ Location.WindDeg+ "\n" +
               "Humidity is : " + Location.Humidity + "%\n" +
               "Pressure is : " + Location.Pressure + "%\n" +
               "Visibility  status : " + Location.Visibility + "%\n" +
               "Last Update : " + Location.Lastupdate + "\n"
               );
        }
    }
}