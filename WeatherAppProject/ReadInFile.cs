using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using WeatherAppProject.Model;
using Windows.Data.Json;

namespace WeatherAppProject
{
    class ReadInFile
    {
        public List<CountryCodes> Contrylist { get; set; }
        public static List<CountryCodes> gCountryList = new List<CountryCodes>();
        //public String BreedName { get; set; }

        public ReadInFile()
        {
            loadData();
            Contrylist = gCountryList;
        }

        public static async Task loadData()
        {
            await LoadLocalData();

        }

        public static async Task LoadLocalData()
        {
            var file = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync("Country-codes.txt");
            var result = await Windows.Storage.FileIO.ReadTextAsync(file);

            var jasonCountryList = JsonArray.Parse(result);
            CreateDogsList(jasonCountryList);
        }
        private static void CreateDogsList(JsonArray jasonCountryList)
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
                            code.code= value.GetString();
                            break;
                        case "name":
                            code.name = value.GetString();
                            break;
                    } // end switch
                } // end foreach(var key in oneDog.Keys )
                gCountryList.Add(code);
            } // end foreach (var item in jDogList)
        }

        //public async static  Task deserializeJsonAsync()
        //{
        //    string content = String.Empty;

        //    List<CountryCodes> myCodes;

        //    var jsonSerializer = new DataContractJsonSerializer(typeof(List<CountryCodes>));

        //    var myStream = await Windows.Storage.ApplicationData.Current.LocalFolder.OpenStreamForReadAsync("Country-codes.txt");


        //    myCodes = (List<CountryCodes>)jsonSerializer.ReadObject(myStream);

        //    foreach(var code in myCodes)
        //    {
        //        content += String.Format("Name: {0}, Code: {1}", code.name, code.code);
        //    }


        //}
    }
}
