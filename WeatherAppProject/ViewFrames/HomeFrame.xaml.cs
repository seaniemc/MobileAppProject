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
            //MyProgressRing.IsActive = true;
            //MyProgressRing.Visibility = Visibility.Visible;

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

            double timestamp = myWeather.sys.sunrise;
            DateTime dateTime = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            dateTime = dateTime.AddSeconds(timestamp);
            SunUpText.Text = dateTime.ToString();
            //MyProgressRing.IsActive = false;
            //MyProgressRing.Visibility = Visibility.Collapsed;
        }
    }
}
