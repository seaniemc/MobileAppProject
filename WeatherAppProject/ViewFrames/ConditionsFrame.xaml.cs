using System;
using System.Collections.Generic;
using System.Globalization;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace WeatherAppProject.ViewFrames
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Conditions : Page
    {
        public Conditions()
        {
            this.InitializeComponent();
            ReadInFile = new CountryCodesVM("CountryCodes");
            this.InitializeComponent();

        }
        public CountryCodesVM ReadInFile { get; set; }

        private async void ConditionsButton_Click(object sender, RoutedEventArgs e)
        {
            var city = CityTextBox.Text.ToString();
            city = city.Replace(" ", "_");
            var cityToUpper = FirstCharToUpper(city);
            var country = countryCombo.SelectedValue.ToString();

            MyProgressRing.IsActive = true;
            MyProgressRing.Visibility = Visibility.Visible;

            RootObject myCityWeather = await WeatherFacade.GetWeatherConditions(country, cityToUpper);
            //Grid.Row 1
            //LocationResultText.Text = myCityWeather.current_observation.display_location.full.ToString();
            if (myCityWeather.current_observation == null)
            {
                ErrorText.Text = "Please Check Spelling";
            }
            else
            {
                CurrentTimeText.Text = myCityWeather.current_observation.local_time_rfc822.ToString();

                MinTempText.Text = myCityWeather.current_observation.temperature_string.ToString();

                string icon = String.Format(myCityWeather.current_observation.icon_url);
                PressureImage.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));

                //Grid.Row 2
                WindSpeedext.Text = myCityWeather.current_observation.wind_string.ToString();
                PrecipText.Text = myCityWeather.current_observation.precip_today_string.ToString();
                WindImage.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));

                MyProgressRing.IsActive = false;
                MyProgressRing.Visibility = Visibility.Collapsed;
            }    
              


        }
        //http://stackoverflow.com/questions/4135317/make-first-letter-of-a-string-upper-case-for-maximum-performance
        public static string FirstCharToUpper(string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentException("ARGH!");
            return input.First().ToString().ToUpper() + input.Substring(1);
        }

    }
}
