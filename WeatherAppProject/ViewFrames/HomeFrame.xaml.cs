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

            var position = await LocationManager.GetPosition();

                OpenWeatherRootObject myWeather = await WeatherFacade.GetWeatherLatlon(
                    position.Coordinate.Latitude, position.Coordinate.Longitude);

            WeatherResultText.Text = myWeather.sys.country.ToString() + "   " +  myWeather.name.ToString();
            string icon = String.Format("http://openweathermap.org/img/w/{0}.png",myWeather.weather[0].icon);
            TodaysImage.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));

            TempText.Text = ((int)myWeather.main.temp).ToString() +" C";
            DescripitionText.Text = myWeather.weather[0].description.ToString();

            PressureResultText.Text = myWeather.main.pressure.ToString() +" hPa" ;
            ((int)myWeather.main.temp_max).ToString();
            ((int)myWeather.main.temp_min).ToString();

            PressureImage.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));
            //myWeather.weather[1].icon

            //MyProgressRing.IsActive = false;
            //MyProgressRing.Visibility = Visibility.Collapsed;
        }
    }
}
