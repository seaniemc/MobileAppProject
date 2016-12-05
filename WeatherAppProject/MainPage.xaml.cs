﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using WeatherAppProject.ViewModel;
using WeatherAppProject.ViewFrames;
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
            ReadInFile = new CountryCodesVM("CountryCodes");

            this.InitializeComponent();
  
            MyFrame.Navigate(typeof(HomeFrame));
            TitleTextBlock.Text = "Current Weather";
            Home.IsSelected = true;
            
        }
         public CountryCodesVM ReadInFile { get; set; }


        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Home.IsSelected)
            {
                MyFrame.Navigate(typeof(HomeFrame));
                TitleTextBlock.Text = "Current Weather";
            }
            else if (Condition.IsSelected)
            {
                MyFrame.Navigate(typeof(Conditions));
                TitleTextBlock.Text = "Conditions";
            }
            else if (Forecast.IsSelected)
            {
                MyFrame.Navigate(typeof(ForecastFrame));
                TitleTextBlock.Text = "4 Day Forecast";
            }
            else if(TenForecast.IsSelected)
            {
                MyFrame.Navigate(typeof(WebcamFrame));
                TitleTextBlock.Text = "10 Day Forecast";
            }
            else if (ChancesOf.IsSelected)
            {
                MyFrame.Navigate(typeof(AstronomyFrame));
                TitleTextBlock.Text = "Chance's Of %";
            }
        }
    }

}

