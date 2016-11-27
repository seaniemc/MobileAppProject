using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using WeatherAppProject.Model;
using WeatherAppProject.ViewModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace WeatherAppProject.ViewFrames
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ForecastFrame : Page
    {
        //public List<TxtForecast> txtForecast { get; set; }
        public static List<TxtForecast> mainTxtForecast = new List<TxtForecast>();

        public ForecastFrame()
        {
            this.InitializeComponent();
            ReadInFile = new CountryCodesVM("CountryCodes");
            this.InitializeComponent();

        }
        public CountryCodesVM ReadInFile { get; set; }

        private async void ConditionsButton_Click(object sender, RoutedEventArgs e)
        {
            var city = CityTextBox.Text.ToString();
            var country = countryCombo.SelectedValue.ToString();

            MyProgressRing.IsActive = true;
            MyProgressRing.Visibility = Visibility.Visible;

            RootObject myCityWeather = await WeatherFacade.GetWeatherForecast(country, city);
            
            
            
        }
        //public static void CreateTxtForcast( forecastList)
        //{
        //    foreach (var item in forecastList)
        //    {

        //    }
        //}
    }

        
    
}
