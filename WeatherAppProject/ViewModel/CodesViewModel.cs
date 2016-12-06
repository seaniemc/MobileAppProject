using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAppProject.Model;

namespace WeatherAppProject.ViewModel
{
    //Creates the properties for the observable collection
    
    public class CodesViewModel : NotificationBase<CountryCodes>
    {
        public CodesViewModel(CountryCodes codes = null) : base(codes) { }

        public String Name
        {
            get { return This.name; }
            set { SetProperty(This.name, value, () => This.name = value); }
        }
        public String Code
        {
            get { return This.code; }
            set { SetProperty(This.code, value, () => This.code = value); }
        }

        public static explicit operator CodesViewModel(int v)
        {
            throw new NotImplementedException();
        }
    }
}
