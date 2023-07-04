using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROG6221_Part3_St10071737.Core;


namespace PROG6221_Part3_St10071737.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewComand { get; set; }


        public HomeViewModel HomeVm { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }


        public MainViewModel()
        {
            HomeVm = new HomeViewModel();
            CurrentView = HomeVm;

            HomeViewComand = new RelayCommand(o =>
            {
                CurrentView = HomeVm;
            });

        }
    }
}
