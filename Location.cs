using System;

namespace WeatherApp{

    public class Location{
        private String city;
        private String country;
        private String sunrise;
        private String sunset;
        private String cloud;
        private String humidity;
        private String lastupdate;
        private String wind;
        private String temperature;
        private String temperatureMin;
        private String temperatureMax;
        private String pressure;
        private String windDeg;
        private String windDir;
        private String visibility;

        public Location(String location){
            city = location;
        }

        public String City{
            get { return city; }
            set { city = value; }
        }
        public String Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }
        public String Visibility
        {
            get { return visibility; }
            set { visibility = value; }
        }
        public String WindDeg
        {
            get { return windDeg; }
            set { windDeg = value; }
        }
        public String WindDir
        {
            get { return windDir; }
            set { windDir = value; }
        }
        public String Country
        {
            get { return country; }
            set { country = value; }
        }
        public String TemperatureMin
        {
            get { return temperatureMin; }
            set { temperatureMin = value; }
        }
        public String TemperatureMax
        {
            get { return temperatureMax; }
            set { temperatureMax = value; }
        }
        public String Sunrise{
            get { return sunrise; }
            set { sunrise = value; }
        }
        
        public String Sunset{
            get { return sunset; }
            set { sunset = value; }
        }
      
        public String Cloud{
            get { return cloud; }
            set { cloud = value; }
        }
    
        public String Wind{
            get { return wind; }
            set { wind = value; }
        }
        
        public String Temperature{
            get { return temperature; }
            set { temperature = value; }
        }

        public String Humidity{
            get { return humidity; }
            set { humidity = value; }
        }
        
        public String Lastupdate{
            get { return lastupdate; }
            set { lastupdate = value; }
        }
    }
}