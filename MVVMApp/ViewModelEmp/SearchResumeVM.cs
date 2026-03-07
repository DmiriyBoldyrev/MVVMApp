using MVVMApp.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMApp.ViewModelEmp
{
    class SearchResumeVM : Property
    {
        #region Поисковая строка

        private string _row;
        public string Row { get => _row;
            set { if (_row != value)
                { _row = value; OnPropertyChanged(); }
            }
        }
        #endregion
        #region Кнопка стереть
        public RelayCommand clearCommand { get; set; }
        public void clearCommandExecute(object p) { Row = null; }
        public bool clearCommandCanExecute(object p) { return true; }
        #endregion
        #region Кнопка найти

        #endregion
        public SearchResumeVM()
        {
            clearCommand = new RelayCommand(clearCommandExecute, clearCommandCanExecute);
        }

    }
}
