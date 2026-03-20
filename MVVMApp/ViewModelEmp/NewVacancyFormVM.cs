using MVVMApp.Other;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMApp.ViewModelEmp
{
    class NewVacancyFormVM : Property
    {
        private string _textBoxName;
        private string _textBoxExp;
        private string _comboBoxChangePay;
        private string _comboBoxChangeZanytost;
        private string _comboBoxChangeRegistration;
        private string _comboBoxChangeTimeWork;
        private string _textBoxAbout;

        public string TextBoxName {
            get => _textBoxName;
            set { if(_textBoxName != value)
                {
                _textBoxName = value; OnPropertyChanged();
                }
            }
        }

        public string TextBoxExp
        {
            get => _textBoxExp;
            set
            {
                if (_textBoxExp != value)
                { _textBoxExp = value; OnPropertyChanged(); }
            }
        }
        public string TextBoxAbout
        {
            get => _textBoxAbout;
            set
            {
                if (_textBoxAbout != value)
                {
                    _textBoxAbout = value; OnPropertyChanged();
                }
            }
        }
        public string ComboBoxChangePay { get => _comboBoxChangePay;
            set { if (_comboBoxChangePay != value)
                { _comboBoxChangePay = value; OnPropertyChanged(); }
            }
        }
        public string ComboBoxChangeZanytost
        {
            get => _comboBoxChangeZanytost;
            set
            {
                if (_comboBoxChangeZanytost != value)
                { _comboBoxChangeZanytost = value; OnPropertyChanged(); }
            }
        }
        public string ComboBoxChangeRegistration
        {
            get => _comboBoxChangeRegistration;
            set
            {
                if (_comboBoxChangeRegistration != value)
                { _comboBoxChangeRegistration = value; OnPropertyChanged(); }
            }
        }
        public string ComboBoxChangeTimeWork
        {
            get => _comboBoxChangeTimeWork;
            set
            {
                if (_comboBoxChangeTimeWork != value)
                { _comboBoxChangeTimeWork = value; OnPropertyChanged(); }
            }
        }

        public RelayCommand addVacancyInList { get; }
        public RelayCommand stopCreateVacancyCommand { get; }

        public void stopCreateVacancyCommandExecute(object p) {
            if (p is Window window)
            {
                window.Close();
            }
        }
        public bool stopCreateVacancyCanExecute(object p) { return true; }
        public void addVacancyExecute(object p) { MessageBox.Show("Вакансия создана"); }
        public bool addVacancyCanExecute(object p) {
            if (TextBoxName != null && TextBoxExp != null && ComboBoxChangePay != null
                && ComboBoxChangeZanytost != null && ComboBoxChangeRegistration != null
                && ComboBoxChangeTimeWork != null && TextBoxAbout != null) { return true; }
            else { return false; MessageBox.Show("Не все поля заполнены"); } }
        public NewVacancyFormVM()
        {

            addVacancyInList = new RelayCommand(addVacancyExecute,addVacancyCanExecute);
            stopCreateVacancyCommand = new RelayCommand(stopCreateVacancyCommandExecute, stopCreateVacancyCanExecute);
        }
    }
}
