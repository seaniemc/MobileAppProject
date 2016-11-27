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
    public sealed partial class AstronomyFrame : Page
    {
        public AstronomyFrame()
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

            RootObject myCityWeather = await WeatherFacade.GetWeatherAstronomy(country, city);
            //Rain
            RainText.Text = myCityWeather.trip.chance_of.chanceofprecip.name.ToString();
            RainDecText.Text = myCityWeather.trip.chance_of.chanceofprecip.percentage.ToString() + " %";

            //Wind
            WindText.Text = myCityWeather.trip.chance_of.chanceofwindyday.name.ToString();
            WindNameText.Text = myCityWeather.trip.chance_of.chanceofwindyday.percentage.ToString() + " %";

            //Clouds
            CloudTempText.Text = myCityWeather.trip.chance_of.chanceofcloudyday.name.ToString();
            MostlyCloudsDescText.Text  = myCityWeather.trip.chance_of.chanceofcloudyday.description.ToString();
            MostlyCloudsText.Text = myCityWeather.trip.chance_of.chanceofcloudyday.percentage.ToString() + " %";

            //Snow
            SnowText.Text = myCityWeather.trip.chance_of.chanceofsnowday.name.ToString();
            SnowDescText.Text = myCityWeather.trip.chance_of.chanceofsnowday.description.ToString();
            SnowNameText.Text = myCityWeather.trip.chance_of.chanceofsnowday.percentage.ToString() + " %";


        }
    }
}
