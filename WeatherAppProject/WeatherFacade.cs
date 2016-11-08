using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using WeatherAppProject.Model;

namespace WeatherAppProject
{
    public class WeatherFacade
    {

        //public static async Task PopulateWeatherData(ObservableCollection<TxtForecast> weatherData)
        //{
        //    var getWheatherLatLon = await GetWeatherCity();

        //    var weatherLatLon = getWheatherLatLon.forecast.simpleforecast.forecastday;

        //    foreach (var weather in weatherLatLon)
        //    {
        //        weatherData.Add(weather);
        //    }
        //}

        public async static Task<OpenWeatherRootObject> GetWeatherLatlon(double lat, double lon)
        {
            var http = new HttpClient();
            var url = String.Format("http://api.openweathermap.org/data/2.5/weather?lat={0}&lon={1}&appid=cdfbbb0c252cbc6513da824fcdaedca1", lat, lon);
            var response = await http.GetAsync(url);
            var jsonMessage = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(OpenWeatherRootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

            var result = (OpenWeatherRootObject)serializer.ReadObject(ms);

            return result;

        }

        public async static Task<RootObject> GetWeatherCity()
        {
            var http = new HttpClient();
            var response = await http.GetAsync("http://api.wunderground.com/api/817ffb35035be408/conditions/q/IE/Galway.json");
            var jsonMessage = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

            var cityresult = (RootObject)serializer.ReadObject(ms);

            return cityresult;

        }

    }


}
