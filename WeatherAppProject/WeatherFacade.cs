using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WeatherAppProject.Model;

namespace WeatherAppProject
{
    public class WeatherFacade
    {
        

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

        public async static Task<RootObject> GetWeatherAstronomy(string countryCode, string city)
        {
            var http = new HttpClient();
            var url = String.Format("http://api.wunderground.com/api/817ffb35035be408/astronomy/q/{0}/{1}.json", countryCode, city);
            var response = await http.GetAsync(url);
            var jsonMessage = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

            var cityResult = (RootObject)serializer.ReadObject(ms);

            return cityResult;
        }

        public async static Task<RootObject> GetWeatherForecast(string countryCode, string city)
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

        public async static Task<RootObject> GetWeatherWebcams(string countryCode, string city)
        {
            var http = new HttpClient();
            var url = String.Format("http://api.wunderground.com/api/817ffb35035be408/webcams/q/{0}/{1}.json", countryCode, city);
            var response = await http.GetAsync(url);
            var jsonMessage = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

            var cityResult = (RootObject)serializer.ReadObject(ms);

            return cityResult;
        }

    }


}
