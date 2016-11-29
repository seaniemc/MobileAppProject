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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace WeatherAppProject.ViewFrames
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    
    public sealed partial class ForecastFrame : Page
    {
        public List<string> txtForecastList = new List<string>();

        public ForecastFrame()
        {
            this.InitializeComponent();
            ReadInFile = new CountryCodesVM("CountryCodes");
            this.InitializeComponent();

        }
        public CountryCodesVM ReadInFile { get; set; }

        private async void ConditionsButton_Click(object sender, RoutedEventArgs e)
        {
            if (CityTextBox.Text == "" && countryCombo.SelectedValue == null)
            {
                CityTextBox.PlaceholderText = "ENTER CITY NAME";
                countryCombo.PlaceholderText = "SELECT COUNTRY";
            }
            else
            {
                var city = CityTextBox.Text.ToString();
                city = city.Replace(" ", "_");
                var cityToUpper = Conditions.FirstCharToUpper(city);
                var country = countryCombo.SelectedValue.ToString();

                MyProgressRing.IsActive = true;
                MyProgressRing.Visibility = Visibility.Visible;

                RootObject myCityWeather = await WeatherFacade.GetWeatherForecast(country, city);

                //  myCityWeather.forecast.txt_forecast.date.ToString();

                if (myCityWeather.forecast == null)
                {
                    CityTextBox.Text = "";
                    CityTextBox.PlaceholderText = "Re-enter City Name";

                    MyProgressRing.IsActive = false;
                    MyProgressRing.Visibility = Visibility.Collapsed;
                }
                else
                {
                    //Day1Text.Text = day.title.ToString();
                    foreach (var day in myCityWeather.forecast.txt_forecast.forecastday)
                    {

                        txtForecastList.Add(day.title.ToString());
                        txtForecastList.Add(day.fcttext_metric.ToString());
                        txtForecastList.Add(day.icon_url.ToString());

                    }
                    Day1Text.Text = txtForecastList[0].ToString();
                    Forecast1Text.Text = txtForecastList[1].ToString();
                    string icon = String.Format(txtForecastList[2].ToString());
                    Weather1Image.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));

                    Day2Text.Text = txtForecastList[3].ToString();
                    Forecast2Text.Text = txtForecastList[4].ToString();
                    icon = String.Format(txtForecastList[5].ToString());
                    Weather2Image.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));

                    Day3Text.Text = txtForecastList[6].ToString();
                    Forecast3Text.Text = txtForecastList[7].ToString();
                    icon = String.Format(txtForecastList[8].ToString());
                    Weather3Image.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));

                    Day4Text.Text = txtForecastList[9].ToString();
                    Forecast4Text.Text = txtForecastList[10].ToString();
                    icon = String.Format(txtForecastList[11].ToString());
                    Weather4Image.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));

                    Day5Text.Text = txtForecastList[12].ToString();
                    Forecast5Text.Text = txtForecastList[13].ToString();
                    icon = String.Format(txtForecastList[14].ToString());
                    Weather5Image.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));

                    Day6Text.Text = txtForecastList[15].ToString();
                    Forecast6Text.Text = txtForecastList[16].ToString();
                    icon = String.Format(txtForecastList[17].ToString());
                    Weather6Image.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));

                    Day7Text.Text = txtForecastList[18].ToString();
                    Forecast7Text.Text = txtForecastList[19].ToString();
                    icon = String.Format(txtForecastList[20].ToString());
                    Weather7Image.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));

                    MyProgressRing.IsActive = false;
                    MyProgressRing.Visibility = Visibility.Collapsed;

                    CityTextBox.PlaceholderText = "Enter City Name";
                    
                }

            }
            
        }
       
    }    
}
