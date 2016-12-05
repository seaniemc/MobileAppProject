using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Windows.UI.Xaml;
//https://channel9.msdn.com/Series/Windows-10-development-for-absolute-beginners/UWP-059-UWP-Weather-Accessing-the-GPS-Location
namespace WeatherAppProject
{
    class LocationManager
    {
        public async static Task<Geoposition>GetPosition()
        {
            var accessStatus = await Geolocator.RequestAccessAsync();

            if (accessStatus != GeolocationAccessStatus.Allowed) throw new Exception();

            var geolocator = new Geolocator { DesiredAccuracyInMeters = 0 };

            var position = await geolocator.GetGeopositionAsync();

            return position;
        }
    }
}
