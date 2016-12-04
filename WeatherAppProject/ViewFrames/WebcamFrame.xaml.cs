using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using WeatherAppProject.Data;
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
    public sealed partial class WebcamFrame : Page
    {
        public WebcamFrame()
        {
            this.InitializeComponent();
            ReadInFile = new CountryCodesVM("CountryCodes");
            this.InitializeComponent();

        }
        public CountryCodesVM ReadInFile { get; set; }

        private async void ConditionsButton_Click(object sender, RoutedEventArgs e)
        {
            ForeCastRootObject wheaterData = await WeatherFacade.GetWeather10DayForecast("IE", "Galway");
        }
    }
}
