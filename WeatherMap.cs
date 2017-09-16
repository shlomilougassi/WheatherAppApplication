using System;
using System.Linq;
using System.Net;
using System.Xml;
using System.Xml.Linq;

namespace WeatherApp
{

    public class WeatherMap : WeatherDataServiceFactory
    {
        const String URLStringXML = "http://api.openweathermap.org/data/2.5/weather?q=";
        const String RestOfURL = "&mode=xml&appid=bdda109516ac7460899029cc0dc03963";
        //SINGELTON
        private static WeatherMap weatherMap;
        private WeatherMap() { }

        public static WeatherMap Instance()
        {
            if (weatherMap == null) return new WeatherMap();
            return weatherMap;
        }
        ////////////////////
        public override WeatherDataServiceFactory getWeatherData(Location location)
        {
            this.Location = location;
            ParseXML(this);
            return (WeatherMap)this;
        }
        public void ParseXML(WeatherMap wd)
        {
            try
            {
                WebClient client = new WebClient();
                String xml = client.DownloadString(URLStringXML + wd.Location.City + RestOfURL);
                XDocument xmlDoc = XDocument.Parse(xml);
                //Console.WriteLine(xmlDoc);
                wd.Location.City = xmlDoc.Descendants("city").Attributes("name").First().Value;
                wd.Location.Wind = xmlDoc.Descendants("speed").Attributes("value").First().Value;
                wd.Location.Lastupdate = xmlDoc.Descendants("lastupdate").Attributes("value").First().Value;
                wd.Location.Temperature = xmlDoc.Descendants("temperature").Attributes("value").First().Value;
                wd.Location.Pressure = xmlDoc.Descendants("pressure").Attributes("value").First().Value;
                wd.Location.TemperatureMax = xmlDoc.Descendants("temperature").Attributes("max").First().Value;
                wd.Location.TemperatureMin = xmlDoc.Descendants("temperature").Attributes("min").First().Value;
                wd.Location.Country = xmlDoc.Descendants("country").First().Value;
                wd.Location.Sunrise = xmlDoc.Descendants("sun").Attributes("rise").First().Value;
                wd.Location.Sunset = xmlDoc.Descendants("sun").Attributes("set").First().Value;
                wd.Location.WindDir = xmlDoc.Descendants("direction").Attributes("value").First().Value;
                wd.Location.WindDesc = xmlDoc.Descendants("speed").Attributes("name").First().Value;
                wd.Location.WindDeg = xmlDoc.Descendants("direction").Attributes("name").First().Value;
                wd.Location.Visibility = xmlDoc.Descendants("visibility").Attributes("value").First().Value;
                wd.Location.Cloud = xmlDoc.Descendants("clouds").Attributes("name").First().Value;
                wd.Location.Humidity = xmlDoc.Descendants("humidity").Attributes("value").First().Value;
            }
            catch (XmlException e)
            {
                Console.WriteLine("Wrong XML read.problem reading the XML" + e.Source);
                Console.ReadKey();
                System.Environment.Exit(1);
            }
        }
    }
}