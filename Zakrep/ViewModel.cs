using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;


namespace Zakrep
{
    public class ViewModel : Property
    {
        #region Счетчик
        private int _count;
        public int Count
        {
            get => _count;
            set {
                _count = value;
                OnPropertyChanged();
            }
        }

        public RCommand CountCommand { get; }
        public void countExecute(object parameter) { Count++; }
        public bool canCountExecute(object paranmeter) { if (Count >= 10) { return false; } else { return true; } }

        public RCommand CountCommandDikrement { get; }

        public void countExecuteDikrement(object p) { Count--; }
        public bool canCountExecuteDikrement(object p) { if (Count == 0) { return false; } else { return true; } }

        #endregion

        #region Состояние

        private bool _enable = true;
        public bool Enable
        {

            get => _enable;
            set
            {
                _enable = value;
                OnPropertyChanged();
            }
        }




        public RCommand EnableDisableCommand { get; }
        public void enableDisableExecute(object p) {


            Enable = !Enable;

        }
        public bool enableDisableCanExecute(object p) { return true; }
        #endregion

        #region сбросить


        public RCommand resetCommand { get; }

        public bool resetCommandCanExecute(object p) { if (Count != 0 && Text != null || Count != 0 || Text != null) { return true; } else { return false; } }
        public void resetCommandExecute(object p) { Count = 0; Text = null; }

        #endregion

        #region Валидация

        private string _text;
        public string Text {
            get => _text;
            set { if (_text != value) {
                    _text = value;
                    OnPropertyChanged();

                }
            }
        } 
        public RCommand validationCommand { get; }
        public bool validationCommandCanExecute(object p) { return Text != null && Text.Length > 2; }
        public void validationCommandExecute(object p) { MessageBox.Show("Hello"); }
        #endregion

        #region Калькулятор

        private int _firstNum;
        private int _secondNum;

        public int FirstNum { get => _firstNum;
            set { if (_firstNum != value)
                {
                    _firstNum = value; OnPropertyChanged();
                }
            }
        }

        public int SecondNum
        {
            get => _secondNum;
            set
            {
                if (_secondNum != value)
                {
                    _secondNum = value; OnPropertyChanged();
                }
            }
        }

        public RCommand plusCommand {  get; }
        public RCommand minusCommand { get; }
        public RCommand divideCommand {  get; }
        public RCommand multiplyCommand { get; }

        public bool plusCommandCanExecute(object p) { return true;  }
        public bool minusCommandCanExecute(object p) { return true;  }
        public bool divideCommandCanExecute(object p) { if (FirstNum == 0 && SecondNum == 0 || FirstNum == 0 || SecondNum == 0) { return false; } else { return true; }  }
        public bool multiplyCommandCanExecute(object p) { return true;  }

        public void plusCommandExecute(object p) { var sum = FirstNum + SecondNum; MessageBox.Show(sum.ToString());  }
        public void minusCommandExecute(object p) { var min = FirstNum - SecondNum; MessageBox.Show(min.ToString()); }
        public void divideCommandExecute(object p) { var div = FirstNum / SecondNum; MessageBox.Show(div.ToString()); }
        public void multiplyCommandExecute(object p) { var mul = FirstNum * SecondNum; MessageBox.Show(mul.ToString()); }
        #endregion

        #region Загрузка


        #endregion

        #region Спмсок

        private ObservableCollection<String> _list;
        private string _listText;
        public string ListText { get => _listText;
            set { if (_listText != value) {
                    _listText = value;
                }
            }
        }
        
        public ObservableCollection<String> List {
            get { return _list; }
            set {  _list = value;OnPropertyChanged(); }
        }
        

        public RCommand deleteCommand {  get; }
        public void deleteCommandExecute(object p) { List.Remove(ListText); }
        public bool deleteCommandCanExecute(object p) { if (_list == null) { return false; } else { return true; } }

        public RCommand addCommand { get; }
        public void addCommandExecute(object p) { List.Add(ListText); }
        public bool addCommandCanExecute(object p) { if (ListText == null) { return false; } else { return true; } }

        public RCommand clearCommand { get; }
        public void clearCommandExecute(object p) { List.Clear(); }
        public bool clearCommandCanExecute(object p) { if (_list == null) { return false; } else { return true; } }
        #endregion
        public ViewModel() {
        
            CountCommand = new RCommand(countExecute,canCountExecute);
            CountCommandDikrement = new RCommand(countExecuteDikrement,canCountExecuteDikrement);
            EnableDisableCommand = new RCommand(enableDisableExecute, enableDisableCanExecute);
            resetCommand = new RCommand(resetCommandExecute,resetCommandCanExecute);
            validationCommand = new RCommand(validationCommandExecute,validationCommandCanExecute);

            _list = new ObservableCollection<string>();
            deleteCommand = new RCommand(deleteCommandExecute,deleteCommandCanExecute);
            addCommand = new RCommand(addCommandExecute, addCommandCanExecute);
            clearCommand = new RCommand(clearCommandExecute, clearCommandCanExecute);


            plusCommand = new RCommand(plusCommandExecute, plusCommandCanExecute);
            minusCommand = new RCommand(minusCommandExecute, minusCommandCanExecute);
            divideCommand = new RCommand (divideCommandExecute, divideCommandCanExecute);
            multiplyCommand = new RCommand(multiplyCommandExecute, multiplyCommandCanExecute);
        }
    }
}
