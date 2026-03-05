using MVVMApp.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMApp.ViewModelWorker
{
    internal class NavigationVMWorker : Property
    {
        private object _currentView;
        public object CurrentView { get { return _currentView; }
            set { _currentView = value;OnPropertyChanged(); } }

        public RelayCommand HomeCommandWorker {  get; set; }
        public RelayCommand AboutWorkerCommand {  get; set; }
        public RelayCommand ResumeWorkerCommand {  get; set; }
        public RelayCommand SearchVacancyWorkerCommand {  get; set; }
        public RelayCommand SettingsWorkerCommand {  get; set; }


        private void HomeCommandWorkerExecute(object p) { CurrentView = new HomeVMWorker(); }
        private void AboutWorkerCommandExecute(object p) { CurrentView = new AboutWorkerVM(); }
        private void ResumeWorkerCommandExecute(object p) { CurrentView = new ResumeVMWorker(); }
        private void SearchVacancyWorkerCommandExecute(object p) { CurrentView = new SearchVacancyVMWorker(); }
        private void SettingsWorkerCommandExecute(object p) { CurrentView = new SettingsVMWorker(); }
    }
}
