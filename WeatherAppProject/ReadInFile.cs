using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using WeatherAppProject.Model;
using Windows.Data.Json;

namespace WeatherAppProject
{

    public class ReadInFile
    {
        // List of country codes
        public List<CountryCodes> Contrylist { get; set; }
        //public static List<CountryCodes> gCountryList = new List<CountryCodes>();
        public ObservableCollection<CountryCodes> gCountryList = new ObservableCollection<CountryCodes>();

        public string CountryName { get; set; }

        public ReadInFile()
        {
            loadData();
           // Contrylist = gCountryList;
        }

        public  async Task loadData()
        {
            await LoadLocalData();

        }

        public  async Task LoadLocalData()
        {
            var file = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync("Country-codes.txt");
            var result = await Windows.Storage.FileIO.ReadTextAsync(file);

            var jasonCountryList = JsonArray.Parse(result);
            CreateCountryList(jasonCountryList);
        }

        private  void CreateCountryList(JsonArray jasonCountryList)
        {
            foreach (var item in jasonCountryList)
            {
                var oneCountry = item.GetObject();
                CountryCodes code = new CountryCodes();

                foreach (var key in oneCountry.Keys)
                {
                    IJsonValue value;
                    if (!oneCountry.TryGetValue(key, out value))
                        continue;

                    switch (key)
                    {
                        case "code":
                            code.code = value.GetString();
                            break;
                        case "name":
                            code.name = value.GetString();
                            break;
                    } // end switch
                } // end foreach(var key in oneCountry.Keys )
                gCountryList.Add(code);
            } // end foreach (var item in jDogList)
        }
        //public static void PopulateWeatherData(ObservableCollection<ReadInFile> countryCodes)
        //{
        //    var getCountryCodes = loadData();

        //    var codes = getCountryCodes.;

        //    foreach (var code in codes)
        //    {
        //        countryCodes.Add(code);
        //    }

        //}
    }
}
