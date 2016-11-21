using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using WeatherAppProject.Model;

namespace WeatherAppProject
{
    public class WeatherFacade
    {

        //public static void PopulateWeatherData(ObservableCollection<ReadInFile> countryCodes)
        //{
        //    var getCountryCodes = ReadInFile.loadData();

        //    var codes = getCountryCodes;

        //    foreach (var code in codes)
        //    {
        //        countryCodes.Add(code);
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

        public async static Task<RootObject> GetWeatherCity(string countryCode, string city)
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

    }


}
