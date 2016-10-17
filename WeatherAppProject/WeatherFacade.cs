using System;
using System.Collections.Generic;
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
        public async static Task<GeolookupRootObject> GetWeatherLatlon(double lat, double lon)
        {
            var http = new HttpClient();
            var response = await http.GetAsync("http://api.wunderground.com/api/817ffb35035be408/geolookup/q/53.28653757012604,-9.041748044375026.json");
            var jsonMessage = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(GeolookupRootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

            var result = (GeolookupRootObject)serializer.ReadObject(ms);

            return result;

        }

        public async static Task<ConditionsRootObject> GetWeatherCity(string city)
        {
            var http = new HttpClient();
            var response = await http.GetAsync("http://api.wunderground.com/api/817ffb35035be408/conditions/q/CA/San_Francisco.json");
            var jsonMessage = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(ConditionsRootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

            var cityresult = (ConditionsRootObject)serializer.ReadObject(ms);

            return cityresult;

        }

    }

    
}
