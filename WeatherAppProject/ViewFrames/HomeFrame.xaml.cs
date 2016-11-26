using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using WeatherAppProject.Model;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace WeatherAppProject.ViewFrames
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomeFrame : Page
    {
        public HomeFrame()
        {
            this.InitializeComponent();
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            MyProgressRing.IsActive = true;
            MyProgressRing.Visibility = Visibility.Visible;

            //Makes call to a call to the location manger class to get geolocation
            var position = await LocationManager.GetPosition();

            //Calls the WeaterFacade and passes the current geo location
            OpenWeatherRootObject myWeather = await WeatherFacade.GetWeatherLatlon(
                position.Coordinate.Latitude, position.Coordinate.Longitude);

            //Is used to populate the xmal in Grid.Row 0
            WeatherResultText.Text = myWeather.sys.country.ToString() + "   " +  myWeather.name.ToString();
            string icon = String.Format("http://openweathermap.org/img/w/{0}.png",myWeather.weather[0].icon);
            TodaysImage.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));
            TempText.Text = ((int)myWeather.main.temp).ToString() +" C";
            DescripitionText.Text = myWeather.weather[0].description.ToString();

            //Is used to populate the xmal in Grid.Row 1
            PressureResultText.Text = myWeather.main.pressure.ToString() +" hPa";
            MaxTempText.Text = ((int)myWeather.main.temp_max).ToString() +" C";
            MinTempText.Text = ((int)myWeather.main.temp_min).ToString() +" C";
            PressureImage.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));

            //Used to populate the xmal in Grid.Row 1

            WindressureResultText.Text = myWeather.wind.speed.ToString() + " kph";
            
            double degrees = myWeather.wind.deg;
            var stringDegree = DegreesToCardinalDetailed(degrees);
            WindDirectionResultText.Text = stringDegree.ToString();

            //http://stackoverflow.com/questions/4505825/convert-utc-time-in-unix-time-format-to-a-readable-datetime-format
            //reformates the rturned date and time from unix timestamp to Date time format
            double timeStamp = myWeather.sys.sunrise;
            DateTime dateTime = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            dateTime = dateTime.AddSeconds(timeStamp);
            SunUpText.Text = dateTime.ToString() + " a.m";

            //reformates the rturned date and time from unix timestamp to Date time format
            timeStamp = myWeather.sys.sunset;
            dateTime = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            dateTime = dateTime.AddSeconds(timeStamp);
            SunDownText.Text = dateTime.ToString() + " p.m";
            WindImage.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));

            MyProgressRing.IsActive = false;
            MyProgressRing.Visibility = Visibility.Collapsed;
        }

        //this method was used from the below link, converts the degrees returned from the api to a string
        //http://www.themethodology.net/2013/12/how-to-convert-degrees-to-cardinal.html
        public static string DegreesToCardinalDetailed(double degrees)
        {
            degrees *= 10;

            string[] caridnals = { "N", "NNE", "NE", "ENE", "E", "ESE", "SE", "SSE", "S", "SSW", "SW", "WSW", "W", "WNW", "NW", "NNW", "N" };
            return caridnals[(int)Math.Round(((double)degrees % 3600) / 225)];
        }
    }
}
