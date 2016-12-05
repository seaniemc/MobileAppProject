using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using WeatherAppProject.Model;
using Windows.Data.Json;

namespace WeatherAppProject
{
    //https://learnonline.gmit.ie/pluginfile.php/153102/mod_resource/content/0/LAB2-Problems.pdf

    //This Class is used to read the list of country codes from the Country-codes.txt into the program. 
    
    public class ReadInFile
    {
        // List of country codes
        public List<CountryCodes> Contrylist { get; set; }
        public static List<CountryCodes> gCountryList = new List<CountryCodes>();
        public string CountryName { get; set; }

        //Constructor
        public ReadInFile()
        {
            loadData();
            Contrylist = gCountryList;
        }

        public static async Task loadData()
        {
            await LoadLocalData();

        }

        //Loads the text file and parses it into jason
        public static async Task LoadLocalData()
        {
            //Gets the file
            var file = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync("Data\\Country-codes.txt");
            //Reads the file
            var result = await Windows.Storage.FileIO.ReadTextAsync(file);

            //Parses the file
            var jasonCountryList = JsonArray.Parse(result);
            CreateCountryList(jasonCountryList);
        }

        //Method is passed the JsonArray jasonCountryList, which it loops through and adds the data to the
        //gCountryList based on the switch statement
        private static void CreateCountryList(JsonArray jasonCountryList)
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

    }
}
