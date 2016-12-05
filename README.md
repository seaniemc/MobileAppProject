# The Wheater App

The Wheater App, is an app developed for the Universial Windows Platform. The app was a project assigned, as part of the Mobile Applications module, in 4th year Software Development at GMIT.  The Application consumes 2 API's to get the wheater conditions. The first API is the [OpenWheaterMap](http://openweathermap.org/), this returns current conditions based on the Geo location of the device. The second is the [Wunderground](https://www.wunderground.com/), which returns wheater conditons based on the country selected and city entered by the user.  
When the app starts up, users are given the codnditions based on the their current location. The Application offers users the ability to retrieve data based on the Conditions, 4 Day Forecast, 10 Day Forecast And Chances's Of for any country on the list. 

##Project Structure and Architecture 
The project structure is broken into diferent parts and sections,with each section seperated into folders. 

###Data
The data returned from the  API is stored in the Data folder, the returned json is deserialized and stored in the c# classes ForecastRootObj.cs, OpenWeatherRootObj.cs and RootObj.cs. The data folder also holds the text file Country-codes.txt and the c# class CountryCodes.cs. The text file, contains a list of country codes and names, which is then used in a list to give the user the option, to select multiple different countries. 

###Modell
The Modell folder holds the classes which construct the model of the data produced. In the folder, we have the WeatherFacade.cs class, which is populated with methods that make the calls to the API's. The folder also holds the ReadinFile.cs class, which is used to read the Country-codes.txt file in to the program. 

###ViewModel
Although the application does not adhere to the MVVM architecture design pattern. The feature, which allows users to select countries, was programed using the MVVM pattern. The ViewModel folder holds the classes CodesViewModel.cs, CountryCodesVM.cs, ViewModelHelper.cs all of these classes are used to create the View Model and Observable Collection which holds the list of the country codes and names. 

###ViewFrames
The ViewFrame folder, holds the different views HomeFrame, ConditionsFrame, ForecastFrame, TenForecastFrame and ChsanceOfFrame. Inside the MainPage.xmal we use a frame tag which when different buttons are selected, injects the different views into the place. 

###LocationManger
The LocationManger.cs class, is responisible for generating the GPS coordinates for the device. These coordinates are used to return the weather for the location. 

###MainPage
Holds the UI structure which is present throughout the project. The app uses the Hamburger Navigation model.

##API Calls
In the Applcation we use 2 different API's to collect data for the app.  

###[OpenWheaterMap](http://openweathermap.org/)
The [OpenWheaterMap](http://openweathermap.org/) API is used to generate weather conditions based on the GPS oordinates of the device. 
```json
URL used to make the call 

http://api.openweathermap.org/data/2.5/weather?lat={0}&lon={1}&units=metric&appid=xxxxxxxxxxxxxxxxx", lat, lon

Returned Json

{"coord":{"lon":-9.05,"lat":53.27},"weather":[{"id":701,"main":"Mist","description":"mist","icon":"50n"}],"base":"stations","main":{"temp":8,"pressure":1019,"humidity":93,"temp_min":8,"temp_max":8},"visibility":2400,"wind":{"speed":4.6,"deg":100},"clouds":{"all":75},"dt":1480966200,"sys":{"type":1,"id":5240,"message":0.4568,"country":"IE","sunrise":1480926913,"sunset":1480954753},"id":2964180,"name":"Gaillimh","cod":200}

```

###[Wunderground](https://www.wunderground.com/)
The [Wunderground](https://www.wunderground.com/) API is used to generate data based on country code and city name. 

```json
Sample URL used 
("http://api.wunderground.com/api/xxxxxxxxxxxxxxx/forecast/q/{0}/{1}.json", countryCode, city);

Returned Json

{
  "response": {
  "version": "0.1",
  "termsofService": "http://www.wunderground.com/weather/api/d/terms.html", 
  "features": {
  "forecast": 1
  }
  },
  "forecast": {
  "txt_forecast": {
  "date": "2:00 PM PDT",
  "forecastday": [{
  "period": 0,
  "icon": "partlycloudy",
  "icon_url": "http://icons-ak.wxug.com/i/c/k/partlycloudy.gif",
  "title": "Tuesday",
  "fcttext": "Partly cloudy in the morning, then clear. High of 68F. Breezy. Winds from the West at 10 to 25 mph.",
  "fcttext_metric": "Partly cloudy in the morning, then clear. High of 20C. Windy. Winds from the West at 20 to 35 km/h.",
  "pop": "0"
  }, {
  "period": 1,
  "icon": "partlycloudy",
  "icon_url": "http://icons-ak.wxug.com/i/c/k/partlycloudy.gif",
  "title": "Tuesday Night",
  "fcttext": "Mostly cloudy. Fog overnight. Low of 50F. Winds from the WSW at 5 to 15 mph.",
  "fcttext_metric": "Mostly cloudy. Fog overnight. Low of 10C. Breezy. Winds from the WSW at 10 to 20 km/h.",
  "pop": "0"
  }, {
  "period": 2,
  "icon": "partlycloudy",
  "icon_url": "http://icons-ak.wxug.com/i/c/k/partlycloudy.gif",
  "title": "Wednesday",
  "fcttext": "Mostly cloudy. Fog early. High of 72F. Winds from the WSW at 10 to 15 mph.",
  "fcttext_metric": "Mostly cloudy. Fog early. High of 22C. Breezy. Winds from the WSW at 15 to 20 km/h.",
  "pop": "0"
  }, {
  "period": 3,
  "icon": "mostlycloudy",
  "icon_url": "http://icons-ak.wxug.com/i/c/k/mostlycloudy.gif",
  "title": "Wednesday Night",
  "fcttext": "Overcast. Fog overnight. Low of 54F. Winds from the WSW at 5 to 15 mph.",
  "fcttext_metric": "Overcast. Fog overnight. Low of 12C. Breezy. Winds from the WSW at 10 to 20 km/h.",
  "pop": "0"
  }, {
  "period": 4,
  "icon": "partlycloudy",
  "icon_url": "http://icons-ak.wxug.com/i/c/k/partlycloudy.gif",
  "title": "Thursday",
  "fcttext": "Overcast in the morning, then partly cloudy. Fog early. High of 72F. Winds from the WSW at 10 to 15 mph.",
  "fcttext_metric": "Overcast in the morning, then partly cloudy. Fog early. High of 22C. Breezy. Winds from the WSW at 15 to 25 km/h.",
  "pop": "0"
  }, {
  "period": 5,
  "icon": "partlycloudy",
  "icon_url": "http://icons-ak.wxug.com/i/c/k/partlycloudy.gif",
  "title": "Thursday Night",
  "fcttext": "Partly cloudy in the evening, then overcast. Fog overnight. Low of 54F. Winds from the WNW at 5 to 15 mph.",
  "fcttext_metric": "Partly cloudy in the evening, then overcast. Fog overnight. Low of 12C. Breezy. Winds from the WNW at 10 to 20 km/h.",
  "pop": "0"
  }, {
  "period": 6,
  "icon": "partlycloudy",
  "icon_url": "http://icons-ak.wxug.com/i/c/k/partlycloudy.gif",
  "title": "Friday",
  "fcttext": "Overcast in the morning, then partly cloudy. Fog early. High of 68F. Winds from the West at 5 to 15 mph.",
  "fcttext_metric": "Overcast in the morning, then partly cloudy. Fog early. High of 20C. Breezy. Winds from the West at 10 to 20 km/h.",
  "pop": "0"
  }, {
  "period": 7,
  "icon": "partlycloudy",
  "icon_url": "http://icons-ak.wxug.com/i/c/k/partlycloudy.gif",
  "title": "Friday Night",
  "fcttext": "Mostly cloudy. Fog overnight. Low of 52F. Winds from the West at 5 to 10 mph.",
  "fcttext_metric": "Mostly cloudy. Fog overnight. Low of 11C. Winds from the West at 10 to 15 km/h.",
  "pop": "0"
  }]
  },
  
}
```




