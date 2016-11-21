using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAppProject.Model;
using WeatherAppProject.ViewModel;

namespace WeatherAppProject.CountryCodesViewModel
{
    public class CountryCodesVM : NotificationBase
    {
        ReadInFile readFile;

        public CountryCodesVM(String CountryCode)
        {
            readFile = new ReadInFile();
            _SelectedIndex = -1;
            // Load the database
            foreach (var codes in readFile.Contrylist)
            {
                var np = new CountryCodesVM(codes);
                //np.PropertyChanged += Dogs_OnNotifyPropertyChanged;
                _CountryCodes.Add(np);
            }
        }

        private CountryCodes codes;

        public CountryCodesVM(CountryCodes codes)
        {
            this.codes = codes;
        }

        ObservableCollection<CountryCodesVM> _CountryCodes
          = new ObservableCollection<CountryCodesVM>();
        

        public ObservableCollection<CountryCodesVM> CountryCodes
        {
            get { return _CountryCodes; }
            set { SetProperty(ref _CountryCodes, value); }
        }

        int _SelectedIndex;
        //private PropertyChangedEventHandler //Dogs_OnNotifyPropertyChanged;

        //public int SelectedIndex
        //{
        //    get { return _SelectedIndex; }
        //    set
        //    {
        //        if (SetProperty(ref _SelectedIndex, value))
        //        {
        //            RaisePropertyChanged(nameof(SelectedCode));
        //        }
        //    }
        //}

        //public CodesViewModel SelectedCode
        //{
        //    get { return (_SelectedIndex >= 0) ? _CountryCodes[_SelectedIndex] : null; }
        //}

    }
}
