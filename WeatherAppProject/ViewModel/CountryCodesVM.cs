using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAppProject.Model;
using WeatherAppProject.ViewModel;

namespace WeatherAppProject.ViewModel
{
    public class CountryCodesVM : NotificationBase
    {
        ReadInFile readFile;

        public CountryCodesVM(String CountryCode)
        {
            readFile = new ReadInFile();
            _SelectedIndex = -1;
          
            foreach (var codes in readFile.Contrylist)
            {
                var np = new CodesViewModel(codes);
               
                _CountryCodes.Add(np);
            }
        }

        private CountryCodes codes;

        public CountryCodesVM(CountryCodes codes)
        {
            this.codes = codes;
        }

        ObservableCollection<CodesViewModel> _CountryCodes
          = new ObservableCollection<CodesViewModel>();
        

        public ObservableCollection<CodesViewModel> CountryCodes
        {
            get { return _CountryCodes; }
            set { SetProperty(ref _CountryCodes, value); }
        }

        int _SelectedIndex;
      

        public int SelectedIndex
        {
            get { return _SelectedIndex; }
            set
            {
                if (SetProperty(ref _SelectedIndex, value))
                {
                    RaisePropertyChanged(nameof(SelectedCode));
                }
            }
        }

        public CodesViewModel SelectedCode
        {
            get { return (_SelectedIndex >= 0) ? _CountryCodes[_SelectedIndex] : null; }
        }

    }
}
