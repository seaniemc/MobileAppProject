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
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WeatherAppProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void WeatherButton_Click(object sender, RoutedEventArgs e)
        {
            GeolookupRootObject myWeather = await WeatherFacade.GetWeatherLatlon(66.6, 55.5);

            WeatherResultText.Text = myWeather.location.city + " -- " + myWeather.location.country_name;

        }

        private async void WeatherCityButton_Click(object sender, RoutedEventArgs e)
        {
            ConditionsRootObject myCityWeather = await WeatherFacade.GetWeatherCity("galway");

            WeatherCityResultText.Text = myCityWeather.current_observation.display_location.city + " _  " + myCityWeather.current_observation.temp_c.ToString()  + "-" + myCityWeather.current_observation.wind_kph;


        }
    }
}
