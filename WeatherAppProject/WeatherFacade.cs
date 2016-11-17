﻿using System;
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

        //public static async Task PopulateWeatherData(ObservableCollection<Results> countryCodes)
        //{
        //    var getCountryCodes = await GetCountryCodes();

        //    var codes = getCountryCodes.Results;

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

        public async static Task<CountryRootObject> GetCountryCodes()
        {
            var http = new HttpClient();
           // var url = String.Format("https://restcountries.eu/rest/v1/all");
            var response = await http.GetAsync("http://www.geognos.com/api/en/countries/info/all.json");
            var jsonMessage = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(CountryRootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

            var countryCodeResult = (CountryRootObject)serializer.ReadObject(ms);

            return countryCodeResult;

        }

        public async static Task<CountryCodeRootObject> GetCountryCodes2()
        {
            var http = new HttpClient();
            // var url = String.Format("https://restcountries.eu/rest/v1/all");
            var response = await http.GetAsync("https://restcountries.eu/rest/v1/capital/tallinn");
            var jsonMessage = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(CountryCodeRootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

            var countryCodeResult = (CountryCodeRootObject)serializer.ReadObject(ms);

            return countryCodeResult;

        }

    }


}
