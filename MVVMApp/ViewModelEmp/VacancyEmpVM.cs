using MVVMApp.Other;
using MVVMApp.View.EmployerUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMApp.ViewModelEmp
{
    class VacancyEmpVM : Property
    {
        #region Поисковая строка

        private string _row;
        public string Row
        {
            get => _row;
            set
            {
                if (_row != value)
                { _row = value; OnPropertyChanged(); }
            }
        }
        #endregion
        #region Кнопка стереть
        public RelayCommand clearCommand { get; set; }
        public void clearCommandExecute(object p) { Row = null; }
        public bool clearCommandCanExecute(object p) { return true; }
        #endregion
        #region Кнопка добавить

        public RelayCommand addVacancyCommand { get; set; }
        public void addVacancyCommandExecute(object p) {
            NewVacancyForm nvc = new NewVacancyForm();
            nvc.ShowDialog(); }
        public bool addVacancyCommandCanExecute(object p) { return true; }
        #endregion
        public VacancyEmpVM()
        {

            clearCommand = new RelayCommand(clearCommandExecute, clearCommandCanExecute);
            addVacancyCommand = new RelayCommand(addVacancyCommandExecute, addVacancyCommandCanExecute);
        }

        private ObservableCollection<string> _vacancyList;
        private string _vacancy;

        public string VacancyList
        {
            get => _vacancy;
            set
            {
                if (_vacancy != value)
                {
                    _vacancy = value;
                }
            }
        }
        public ObservableCollection<string> ListVacancy
        {
            get { return _vacancyList; }
            set { _vacancyList = value; OnPropertyChanged(); }
        }

        
    
    } 
}
