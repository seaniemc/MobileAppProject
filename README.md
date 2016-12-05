# The Wheater App

The Wheater App, is an app developed for the Universial Windows Platform. The app was a project assigned, as part of the Mobile Application's 3 module, in 4th year Software Development at GMIT.  The Application consumes 2 API's to get the wheater conditions. The first API is the [OpenWheaterMap](http://openweathermap.org/), this returns current conditions based on the Geo location of the device. The second is the [Wunderground](https://www.wunderground.com/), which returns wheater conditons based on the country selected and city entered by the user. 

##Project Structure and Architecture 
The project structure is broken into diferent parts and sections,with each section seperated into folders. 

###Data
The data returned from the the API is stored in the Data folder, the returned json is deserialized and stored in the c# classes ForecastRootObj.cs, OpenWeatherRootObj.cs and RootObj.cs. The data folder also holds the text file Country-codes.txt and the c# class CountryCodes.cs. The text file, contains a list of country codes and names, which is then used in a list to give the user the option, to select multiple different countries. 

###Modell
The modell folder holds the classes which construct the model of the data produced. In the folder we have the WeatherFacade.cs class, which is populated with methods which make the calls to the API's. The folder also holds the ReadinFile.cs class which is used to read the Country-codes.txt file in to the program. 

###ViewModel
Although the application does not adhere to the MVVM architecture design pattern. The feature which allows users to select countries, was done using the MVVM patern. The ViewModel folder holds the classes 

