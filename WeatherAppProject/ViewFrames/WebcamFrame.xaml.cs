using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using WeatherAppProject.Data;
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
    public sealed partial class WebcamFrame : Page
    {
        public List<string> txtForecastList = new List<string>();
        public WebcamFrame()
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

                RootObject wheaterData = await WeatherFacade.GetWeather10DayForecast(country, city);

                if (wheaterData.forecast == null)
                {
                    CityTextBox.Text = "";
                    CityTextBox.PlaceholderText = "Re-enter City Name";

                    //MyProgressRing.IsActive = false;
                    //MyProgressRing.Visibility = Visibility.Collapsed;
                }
                else
                {
                    //int i = 0;
                    //string icon;
                    //Day1Text.Text = day.title.ToString();
                    foreach (var day in wheaterData.forecast.txt_forecast.forecastday)
                    {

                        txtForecastList.Add(day.title.ToString());
                        txtForecastList.Add(day.fcttext_metric.ToString());
                        txtForecastList.Add(day.icon_url.ToString());

                        //Day1Text.Text = txtForecastList[0].ToString();
                        //Forecast1Text.Text = txtForecastList[1].ToString();
                        //icon = String.Format(txtForecastList[2].ToString());
                        //Weather1Image.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));

                    }
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

                Day8Text.Text = txtForecastList[21].ToString();
                Forecast8Text.Text = txtForecastList[22].ToString();
                icon = String.Format(txtForecastList[23].ToString());
                Weather8Image.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));

                Day9Text.Text = txtForecastList[24].ToString();
                Forecast9Text.Text = txtForecastList[25].ToString();
                icon = String.Format(txtForecastList[26].ToString());
                Weather9Image.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));

                Day10Text.Text = txtForecastList[27].ToString();
                Forecast10Text.Text = txtForecastList[28].ToString();
                icon = String.Format(txtForecastList[29].ToString());
                Weather10Image.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));

                Day11Text.Text = txtForecastList[30].ToString();
                Forecast11Text.Text = txtForecastList[31].ToString();
                icon = String.Format(txtForecastList[32].ToString());
                Weather11Image.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));

                Day12Text.Text = txtForecastList[33].ToString();
                Forecast12Text.Text = txtForecastList[34].ToString();
                icon = String.Format(txtForecastList[35].ToString());
                Weather12Image.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));

                Day13Text.Text = txtForecastList[36].ToString();
                Forecast13Text.Text = txtForecastList[37].ToString();
                icon = String.Format(txtForecastList[38].ToString());
                Weather13Image.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));

                Day14Text.Text = txtForecastList[39].ToString();
                Forecast14Text.Text = txtForecastList[40].ToString();
                icon = String.Format(txtForecastList[41].ToString());
                Weather14Image.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));

                Day15Text.Text = txtForecastList[42].ToString();
                Forecast15Text.Text = txtForecastList[43].ToString();
                icon = String.Format(txtForecastList[44].ToString());
                Weather15Image.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));

                Day16Text.Text = txtForecastList[45].ToString();
                Forecast16Text.Text = txtForecastList[46].ToString();
                icon = String.Format(txtForecastList[47].ToString());
                Weather16Image.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));

                Day17Text.Text = txtForecastList[48].ToString();
                Forecast17Text.Text = txtForecastList[49].ToString();
                icon = String.Format(txtForecastList[50].ToString());
                Weather17Image.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));

                Day18Text.Text = txtForecastList[51].ToString();
                Forecast18Text.Text = txtForecastList[52].ToString();
                icon = String.Format(txtForecastList[53].ToString());
                Weather18Image.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));

                Day19Text.Text = txtForecastList[54].ToString();
                Forecast19Text.Text = txtForecastList[55].ToString();
                icon = String.Format(txtForecastList[56].ToString());
                Weather19Image.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));

                Day20Text.Text = txtForecastList[57].ToString();
                Forecast20Text.Text = txtForecastList[58].ToString();
                icon = String.Format(txtForecastList[59].ToString());
                Weather20Image.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));

                //MyProgressRing.IsActive = false;
                //MyProgressRing.Visibility = Visibility.Collapsed;
            }
        }
    }
}
