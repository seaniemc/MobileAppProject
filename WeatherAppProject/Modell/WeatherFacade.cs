using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WeatherAppProject.Data;
using WeatherAppProject.Model;

namespace WeatherAppProject
{
    //This class keeps all the methods which are used to call the API's
    //All of the methods in this class use the async and await keywords.
    public class WeatherFacade
    {
       // https://channel9.msdn.com/Series/Windows-10-development-for-absolute-beginners/UWP-058-UWP-Weather-Setup-and-Working-with-the-Weather-API 

        
       // This method retrieves current weather data from the OpenWeatherMap API based on the device location.
        public async static Task<OpenWeatherRootObject> GetWeatherLatlon(double lat, double lon)
        {
           
                var http = new HttpClient();
                var url = String.Format("http://api.openweathermap.org/data/2.5/weather?lat={0}&lon={1}&units=metric&appid=cdfbbb0c252cbc6513da824fcdaedca1", lat, lon);
                var response = await http.GetAsync(url);
                var jsonMessage = await response.Content.ReadAsStringAsync();
                var serializer = new DataContractJsonSerializer(typeof(OpenWeatherRootObject));

                var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

                var result = (OpenWeatherRootObject)serializer.ReadObject(ms);

                return result;
               
        }

        // This method retrieves data from the 
        public async static Task<RootObject> GetWeatherConditions(string countryCode, string city)
        {
            
                var http = new HttpClient();
                var url = String.Format("http://api.wunderground.com/api/817ffb35035be408/conditions/q/{0}/{1}.json", countryCode, city);
                var response = await http.GetAsync(url);
                var jsonMessage = await response.Content.ReadAsStringAsync();
                var serializer = new DataContractJsonSerializer(typeof(RootObject));

                var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

                var cityResult = (RootObject)serializer.ReadObject(ms);

                return cityResult;
       
            
        }

        //Users can get Chances of from any city on the Country list. 
        //The method takes countrycode and city name as paramatuers
        public async static Task<RootObject> GetWeatherChancesOf(string countryCode, string city)
        {
            var http = new HttpClient();
            var url = String.Format("http://api.wunderground.com/api/817ffb35035be408/planner_07010731/q/{0}/{1}.json", countryCode, city);
            var response = await http.GetAsync(url);
            var jsonMessage = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

            var cityResult = (RootObject)serializer.ReadObject(ms);

            return cityResult;
        }

        //Users can get forecast from any city on the Country list. 
        //The method takes countrycode and city name as paramatuers
        public async static Task<RootObject> GetWeatherForecastData(string countryCode, string city)
        {
            var http = new HttpClient();
            var url = String.Format("http://api.wunderground.com/api/817ffb35035be408/forecast/q/{0}/{1}.json", countryCode, city);
            var response = await http.GetAsync(url);
            var jsonMessage = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

            var cityResult = (RootObject)serializer.ReadObject(ms);

            return cityResult;
        }

        //Users can get 10 day forecast from any city on the Country list. 
        //The method takes countrycode and city name as paramatuers
        public async static Task<RootObject> GetWeather10DayForecast(string countryCode, string city)
        {
            var http = new HttpClient();
            var url = String.Format("http://api.wunderground.com/api/817ffb35035be408/forecast10day/q/{0}/{1}.json", countryCode, city);
            var response = await http.GetAsync(url);
            var jsonMessage = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

            var cityResult = (RootObject)serializer.ReadObject(ms);

            return cityResult;
        }

    }


}
