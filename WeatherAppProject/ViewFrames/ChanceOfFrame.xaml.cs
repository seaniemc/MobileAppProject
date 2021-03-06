﻿using System;
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
            // Checks to see if the user has entered the correct details 
            //if both fields are empty or just one, it will request the user to
            //renter the values.
            if (CityTextBox.Text == "" && countryCombo.SelectedValue == null
                || CityTextBox.Text == "" || countryCombo.SelectedValue == null)
            {
                CityTextBox.PlaceholderText = "ENTER CITY NAME";
                countryCombo.PlaceholderText = "SELECT COUNTRY";
            }
            else
            {
                var country = countryCombo.SelectedValue.ToString();
                var city = CityTextBox.Text.ToString();

                city = city.Replace(" ", "_");
                var cityToUpper = Conditions.FirstCharToUpper(city);

           

                MyProgressRing.IsActive = true;
                MyProgressRing.Visibility = Visibility.Visible;

           
           
                RootObject myCityWeather = await WeatherFacade.GetWeatherChancesOf(country, city);

                if (myCityWeather.trip == null)
                {
                    CityTextBox.Text = "";
                    CityTextBox.PlaceholderText = "Re-enter City Name";

                    MyProgressRing.IsActive = false;
                    MyProgressRing.Visibility = Visibility.Collapsed;
                }
                else
                {
                    //Rain
                    RainDecText.Text = myCityWeather.trip.chance_of.chanceofprecip.percentage.ToString() + " %";

                    //Wind               
                    WindText.Text = myCityWeather.trip.chance_of.chanceofwindyday.percentage.ToString() + " %";

                    //Cloudy
                    MostlyCloudsDescText.Text = myCityWeather.trip.chance_of.chanceofcloudyday.percentage.ToString() + " %";

                    //Snow
                   
                    SnowDescText.Text = myCityWeather.trip.chance_of.chanceofsnowday.percentage.ToString() + " %";

                    //Fog
                    FogDescText.Text = myCityWeather.trip.chance_of.chanceoffogday.percentage.ToString() + " %";

                    //freezing
                    FreezingNameText.Text = myCityWeather.trip.chance_of.tempbelowfreezing.percentage.ToString() + " %";

                    HighTempDescText.Text = myCityWeather.trip.chance_of.tempoverninety.description.ToString();
                    HighTempNameText.Text = myCityWeather.trip.chance_of.tempoverninety.percentage.ToString() + " %";

                    MidTempText.Text = myCityWeather.trip.chance_of.tempoverfreezing.description.ToString();
                    MidTempDescText.Text = myCityWeather.trip.chance_of.tempoverfreezing.percentage.ToString() + " %";

                    WarmTempText.Text = myCityWeather.trip.chance_of.tempoversixty.description.ToString();
                    WarmTempDescText.Text = myCityWeather.trip.chance_of.tempoversixty.percentage.ToString() + " %";

                    MyProgressRing.IsActive = false;
                    MyProgressRing.Visibility = Visibility.Collapsed;

                    CityTextBox.PlaceholderText = "Enter City Name";
                }

            }

           

        }
    }
}
