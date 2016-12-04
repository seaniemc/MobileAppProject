using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAppProject.Model
{
    public class Features
    {
        public int planner { get; set; }
        public int astronomy { get; set; }
        public int conditions { get; set; }
        public int forecast { get; set; }
        public int geolookup { get; set; }
        public int webcams { get; set; }
    }

    public class Response
    {
        public string version { get; set; }
        public string termsofService { get; set; }
        public Features features { get; set; }
    }

    //===============Astronomy======================
    public class CurrentTime
    {
        public string hour { get; set; }
        public string minute { get; set; }
    }

    public class Sunrise
    {
        public string hour { get; set; }
        public string minute { get; set; }
    }

    public class Sunset
    {
        public string hour { get; set; }
        public string minute { get; set; }
    }

    public class MoonPhase
    {
        public string percentIlluminated { get; set; }
        public string ageOfMoon { get; set; }
        public CurrentTime current_time { get; set; }
        public Sunrise sunrise { get; set; }
        public Sunset sunset { get; set; }
    }

    //===========Conditions=========================
    public class Image
    {
        public string url { get; set; }
        public string title { get; set; }
        public string link { get; set; }
    }

    public class DisplayLocation
    {
        public string full { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string state_name { get; set; }
        public string country { get; set; }
        public string country_iso3166 { get; set; }
        public string zip { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string elevation { get; set; }
    }

    public class ObservationLocation
    {
        public string full { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string country_iso3166 { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string elevation { get; set; }
    }

    public class Estimated
    {
    }

    public class CurrentObservation
    {
        public Image image { get; set; }
        public DisplayLocation display_location { get; set; }
        public ObservationLocation observation_location { get; set; }
        public Estimated estimated { get; set; }
        public string station_id { get; set; }
        public string observation_time { get; set; }
        public string observation_time_rfc822 { get; set; }
        public string observation_epoch { get; set; }
        public string local_time_rfc822 { get; set; }
        public string local_epoch { get; set; }
        public string local_tz_short { get; set; }
        public string local_tz_long { get; set; }
        public string local_tz_offset { get; set; }
        public string weather { get; set; }
        public string temperature_string { get; set; }
        public double temp_f { get; set; }
        public double temp_c { get; set; }
        public string relative_humidity { get; set; }
        public string wind_string { get; set; }
        public string wind_dir { get; set; }
        public int wind_degrees { get; set; }
        public double wind_mph { get; set; }
        public string wind_gust_mph { get; set; }
        public double wind_kph { get; set; }
        public string wind_gust_kph { get; set; }
        public string pressure_mb { get; set; }
        public string pressure_in { get; set; }
        public string pressure_trend { get; set; }
        public string dewpoint_string { get; set; }
        public int dewpoint_f { get; set; }
        public int dewpoint_c { get; set; }
        public string heat_index_string { get; set; }
        public string heat_index_f { get; set; }
        public string heat_index_c { get; set; }
        public string windchill_string { get; set; }
        public string windchill_f { get; set; }
        public string windchill_c { get; set; }
        public string feelslike_string { get; set; }
        public string feelslike_f { get; set; }
        public string feelslike_c { get; set; }
        public string visibility_mi { get; set; }
        public string visibility_km { get; set; }
        public string solarradiation { get; set; }
        public string UV { get; set; }
        public string precip_1hr_string { get; set; }
        public string precip_1hr_in { get; set; }
        public string precip_1hr_metric { get; set; }
        public string precip_today_string { get; set; }
        public string precip_today_in { get; set; }
        public string precip_today_metric { get; set; }
        public string icon { get; set; }
        public string icon_url { get; set; }
        public string forecast_url { get; set; }
        public string history_url { get; set; }
        public string ob_url { get; set; }
    }

    //================Forecast===========================

    public class Forecastday
    {
        public int period { get; set; }
        public string icon { get; set; }
        public string icon_url { get; set; }
        public string title { get; set; }
        public string fcttext { get; set; }
        public string fcttext_metric { get; set; }
        public string pop { get; set; }
    }

    public class TxtForecast
    {
        public string date { get; set; }
        public List<Forecastday> forecastday { get; set; }
    }

    public class Forecast
    {
        public TxtForecast txt_forecast { get; set; }

    }

    //========================Geolookup=====================
    public class Station
    {
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string icao { get; set; }
        public string lat { get; set; }
        public string lon { get; set; }
    }

    public class Airport
    {
        public List<Station> station { get; set; }
    }

    public class Station2
    {
        public string neighborhood { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string id { get; set; }
        public int distance_km { get; set; }
        public int distance_mi { get; set; }
    }

    public class Pws
    {
        public List<Station2> station { get; set; }
    }

    public class NearbyWeatherStations
    {
        public Airport airport { get; set; }
        public Pws pws { get; set; }
    }

    public class Location
    {
        public string type { get; set; }
        public string country { get; set; }
        public string country_iso3166 { get; set; }
        public string country_name { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public string tz_short { get; set; }
        public string tz_long { get; set; }
        public string lat { get; set; }
        public string lon { get; set; }
        public string zip { get; set; }
        public string magic { get; set; }
        public string wmo { get; set; }
        public string l { get; set; }
        public string requesturl { get; set; }
        public string wuiurl { get; set; }
        public NearbyWeatherStations nearby_weather_stations { get; set; }
    }
    //=================Webcam====================================

    //public class Webcam
    //{
    //    public string handle { get; set; }
    //    public string camid { get; set; }
    //    public string camindex { get; set; }
    //    public string assoc_station_id { get; set; }
    //    public string link { get; set; }
    //    public string linktext { get; set; }
    //    public string cameratype { get; set; }
    //    public string organization { get; set; }
    //    public string neighborhood { get; set; }
    //    public string zip { get; set; }
    //    public string city { get; set; }
    //    public string state { get; set; }
    //    public string country { get; set; }
    //    public string tzname { get; set; }
    //    public string lat { get; set; }
    //    public string lon { get; set; }
    //    public string updated { get; set; }
    //    public string downloaded { get; set; }
    //    public string isrecent { get; set; }
    //    public string CURRENTIMAGEURL { get; set; }
    //    public string WIDGETCURRENTIMAGEURL { get; set; }
    //    public string CAMURL { get; set; }
    //}
    //======================Planner =======================
    public class PlannerDate
    {
        public string epoch { get; set; }
        public string pretty { get; set; }
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        public int yday { get; set; }
        public int hour { get; set; }
        public string min { get; set; }
        public int sec { get; set; }
        public string isdst { get; set; }
        public string monthname { get; set; }
        public string weekday_short { get; set; }
        public string weekday { get; set; }
        public string ampm { get; set; }
        public string tz_short { get; set; }
        public string tz_long { get; set; }
    }

    //public class DateStart
    //{
    //    public Date date { get; set; }
    //}

    public class Date2
    {
        public string epoch { get; set; }
        public string pretty { get; set; }
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        public int yday { get; set; }
        public int hour { get; set; }
        public string min { get; set; }
        public int sec { get; set; }
        public string isdst { get; set; }
        public string monthname { get; set; }
        public string weekday_short { get; set; }
        public string weekday { get; set; }
        public string ampm { get; set; }
        public string tz_short { get; set; }
        public string tz_long { get; set; }
    }

    public class DateEnd
    {
        public Date2 date { get; set; }
    }

    public class PeriodOfRecord
    {
        //public DateStart date_start { get; set; }
        public DateEnd date_end { get; set; }
    }

    public class Min
    {
        public string F { get; set; }
        public string C { get; set; }
    }

    public class Avg
    {
        public string F { get; set; }
        public string C { get; set; }
    }

    public class Max
    {
        public string F { get; set; }
        public string C { get; set; }
    }

    public class TempHigh
    {
        public Min min { get; set; }
        public Avg avg { get; set; }
        public Max max { get; set; }
    }

    public class Min2
    {
        public string F { get; set; }
        public string C { get; set; }
    }

    public class Avg2
    {
        public string F { get; set; }
        public string C { get; set; }
    }

    public class Max2
    {
        public string F { get; set; }
        public string C { get; set; }
    }

    public class TempLow
    {
        public Min2 min { get; set; }
        public Avg2 avg { get; set; }
        public Max2 max { get; set; }
    }

    public class Min3
    {
        public string @in { get; set; }
        public string cm { get; set; }
    }

    public class Avg3
    {
        public string @in { get; set; }
        public string cm { get; set; }
    }

    public class Max3
    {
        public string @in { get; set; }
        public string cm { get; set; }
    }

    public class Precip
    {
        public Min3 min { get; set; }
        public Avg3 avg { get; set; }
        public Max3 max { get; set; }
    }

    public class Min4
    {
        public string F { get; set; }
        public string C { get; set; }
    }

    public class Avg4
    {
        public string F { get; set; }
        public string C { get; set; }
    }

    public class Max4
    {
        public string F { get; set; }
        public string C { get; set; }
    }

    public class DewpointHigh
    {
        public Min4 min { get; set; }
        public Avg4 avg { get; set; }
        public Max4 max { get; set; }
    }

    public class Min5
    {
        public string F { get; set; }
        public string C { get; set; }
    }

    public class Avg5
    {
        public string F { get; set; }
        public string C { get; set; }
    }

    public class Max5
    {
        public string F { get; set; }
        public string C { get; set; }
    }

    public class DewpointLow
    {
        public Min5 min { get; set; }
        public Avg5 avg { get; set; }
        public Max5 max { get; set; }
    }

    public class CloudCover
    {
        public string cond { get; set; }
    }

    public class Tempoversixty
    {
        public string name { get; set; }
        public string description { get; set; }
        public string percentage { get; set; }
    }

    public class Chanceofwindyday
    {
        public string name { get; set; }
        public string description { get; set; }
        public string percentage { get; set; }
    }

    public class Chanceofpartlycloudyday
    {
        public string name { get; set; }
        public string description { get; set; }
        public string percentage { get; set; }
    }

    public class Chanceofsunnycloudyday
    {
        public string name { get; set; }
        public string description { get; set; }
        public string percentage { get; set; }
    }

    public class Chanceofcloudyday
    {
        public string name { get; set; }
        public string description { get; set; }
        public string percentage { get; set; }
    }

    public class Chanceoffogday
    {
        public string name { get; set; }
        public string description { get; set; }
        public string percentage { get; set; }
    }

    public class Chanceofhumidday
    {
        public string name { get; set; }
        public string description { get; set; }
        public string percentage { get; set; }
    }

    public class Chanceofprecip
    {
        public string name { get; set; }
        public string description { get; set; }
        public string percentage { get; set; }
    }

    public class Chanceofrainday
    {
        public string name { get; set; }
        public string description { get; set; }
        public string percentage { get; set; }
    }

    public class Tempoverninety
    {
        public string name { get; set; }
        public string description { get; set; }
        public string percentage { get; set; }
    }

    public class Chanceofthunderday
    {
        public string name { get; set; }
        public string description { get; set; }
        public string percentage { get; set; }
    }

    public class Chanceofsnowonground
    {
        public string name { get; set; }
        public string description { get; set; }
        public string percentage { get; set; }
    }

    public class Chanceoftornadoday
    {
        public string name { get; set; }
        public string description { get; set; }
        public string percentage { get; set; }
    }

    public class Chanceofsultryday
    {
        public string name { get; set; }
        public string description { get; set; }
        public string percentage { get; set; }
    }

    public class Tempbelowfreezing
    {
        public string name { get; set; }
        public string description { get; set; }
        public string percentage { get; set; }
    }

    public class Tempoverfreezing
    {
        public string name { get; set; }
        public string description { get; set; }
        public string percentage { get; set; }
    }

    public class Chanceofhailday
    {
        public string name { get; set; }
        public string description { get; set; }
        public string percentage { get; set; }
    }

    public class Chanceofsnowday
    {
        public string name { get; set; }
        public string description { get; set; }
        public string percentage { get; set; }
    }

    public class ChanceOf
    {
        public Tempoversixty tempoversixty { get; set; }
        public Chanceofwindyday chanceofwindyday { get; set; }
        public Chanceofpartlycloudyday chanceofpartlycloudyday { get; set; }
        public Chanceofsunnycloudyday chanceofsunnycloudyday { get; set; }
        public Chanceofcloudyday chanceofcloudyday { get; set; }
        public Chanceoffogday chanceoffogday { get; set; }
        public Chanceofhumidday chanceofhumidday { get; set; }
        public Chanceofprecip chanceofprecip { get; set; }
        public Chanceofrainday chanceofrainday { get; set; }
        public Tempoverninety tempoverninety { get; set; }
        public Chanceofthunderday chanceofthunderday { get; set; }
        public Chanceofsnowonground chanceofsnowonground { get; set; }
        public Chanceoftornadoday chanceoftornadoday { get; set; }
        public Chanceofsultryday chanceofsultryday { get; set; }
        public Tempbelowfreezing tempbelowfreezing { get; set; }
        public Tempoverfreezing tempoverfreezing { get; set; }
        public Chanceofhailday chanceofhailday { get; set; }
        public Chanceofsnowday chanceofsnowday { get; set; }
    }

    public class Trip
    {
        public string title { get; set; }
        public string airport_code { get; set; }
        public string error { get; set; }
        public PeriodOfRecord period_of_record { get; set; }
        public TempHigh temp_high { get; set; }
        public TempLow temp_low { get; set; }
        public Precip precip { get; set; }
        public DewpointHigh dewpoint_high { get; set; }
        public DewpointLow dewpoint_low { get; set; }
        public CloudCover cloud_cover { get; set; }
        public ChanceOf chance_of { get; set; }
    }
    //============================RootObject=================
    public class RootObject
    {
        public Response response { get; set; }
        public MoonPhase moon_phase { get; set; }
        public Trip trip { get; set; }
        public CurrentObservation current_observation { get; set; }
        public Forecast forecast { get; set; }
        public Location location { get; set; }
        //public List<Webcam> webcams { get; set; }
    }
}
