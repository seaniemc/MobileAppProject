using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ObservableCollection<Results> CountryResults { get; set; }
        public MainPage()
        {
            this.InitializeComponent();
            CountryResults = new ObservableCollection<Results>();
        }
        //string country;
        private async void WeatherButton_Click(object sender, RoutedEventArgs e)
        {
            var position = await LocationManager.GetPosition();

            OpenWeatherRootObject myWeather = await WeatherFacade.GetWeatherLatlon(
                position.Coordinate.Latitude, position.Coordinate.Longitude);

            WeatherResultText.Text = myWeather.name.ToString() + " -- " + myWeather.weather[0].description;
                
        }

        private async void WeatherCityButton_Click(object sender, RoutedEventArgs e)
        {
            await ReadInFile.LoadLocalData();


            //CountryCodeRootObject myCountryCodes = await WeatherFacade.GetCountryCodes2();
            //var city = cityTextBox.Text.ToString();

            //RootObject myCityWeather = await WeatherFacade.GetWeatherCity(country, city);

           //WeatherCityResultText.Text = myCityWeather.current_observation.display_location.city + " _  " + myCityWeather.current_observation.temp_c.ToString() + "-" + myCityWeather.current_observation.wind_kph;
            
        }

        private void CountryCodeCombo_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //country = CountryCodeCombo.DataContext.ToString();
        }
    }
}
