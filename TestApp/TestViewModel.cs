using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace TestApp
{
    public class TestViewModel : INotifyPropertyChanged
    {
        private int _counter;
        public int Counter
        {
            get => _counter;
            set
            {
                _counter = value;
                OnPropertyChanged();
                System.Diagnostics.Debug.WriteLine($"Counter = {_counter}");
            }
        }

        public ICommand ClickCommand { get; }

        public TestViewModel()
        {
            ClickCommand = new RelayCommand((p) => Counter++);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }

    public class RelayCommand : ICommand
    {
        private readonly Action<object> _execute;
        public RelayCommand(Action<object> execute) => _execute = execute;
        public bool CanExecute(object p) => true;
        public void Execute(object p) => _execute(p);
        public event EventHandler CanExecuteChanged;
    }
}