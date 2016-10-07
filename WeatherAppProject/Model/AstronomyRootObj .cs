using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAppProject.Model
{
    public class AstronomyFeatures
    {
        public int astronomy { get; set; }
    }

    public class AstronomyResponse
    {
        public string version { get; set; }
        public string termsofService { get; set; }
        public AstronomyFeatures features { get; set; }
    }

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

    public class AstronomyRootObject
    {
        public AstronomyResponse response { get; set; }
        public MoonPhase moon_phase { get; set; }
    }
}
