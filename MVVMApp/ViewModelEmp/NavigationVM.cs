using MVVMApp.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMApp.ViewModelEmp
{
    internal class NavigationVM : Property
    {
        private object currentView;
        public object CurrentView {
            get { return currentView; }
            set { currentView = value; OnPropertyChanged(); }
        }

        public RelayCommand HomeCommand { get; set;  }
        public RelayCommand AboutEmpCommand { get; set;  }
        public RelayCommand SettingsEmpCommand { get; set;  }
        public RelayCommand VacancyEmpCommand { get; set;  }
        public RelayCommand SearchResumeCommand { get; set;  }

        private void HomeCommandExecute(object p) { CurrentView = new HomeEmpVM(); }
        private void AboutEmpCommandExecute(object p) { CurrentView = new AboutEmpVM(); }
        private void SettingsEmpCommandExecute(object p) { CurrentView = new SettingsEmpVM(); }
        private void VacancyEmpCommandExecute(object p) { CurrentView = new VacancyEmpVM(); }
        private void SearchResumeCommandExecute(object p) { CurrentView = new SearchResumeVM(); }
        
        public NavigationVM() {
        
            HomeCommand = new RelayCommand(HomeCommandExecute);
            AboutEmpCommand = new RelayCommand(AboutEmpCommandExecute);
            SettingsEmpCommand = new RelayCommand(SettingsEmpCommandExecute);
            VacancyEmpCommand = new RelayCommand(VacancyEmpCommandExecute);
            SearchResumeCommand = new RelayCommand(SearchResumeCommandExecute);

            CurrentView = new HomeEmpVM();

        }


    }
}
