using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using WeatherAppProject.Model;

namespace WeatherAppProject
{
    class ReadInFile
    {
        public async static  Task deserializeJsonAsync()
        {
            string content = String.Empty;

            List<CountryCodes> myCodes;

            var jsonSerializer = new DataContractJsonSerializer(typeof(List<CountryCodes>));

            var myStream = await Windows.Storage.ApplicationData.Current.LocalFolder.OpenStreamForReadAsync("Country-codes.txt");

            myCodes = (List<CountryCodes>)jsonSerializer.ReadObject(myStream);

            foreach(var code in myCodes)
            {
                content += String.Format("Name: {0}, Code: {1}", code.name, code.code);
            }

            
        }
    }
}
