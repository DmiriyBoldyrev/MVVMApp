using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMApp.Other
{
    class RelayCommand : ICommand
    {
        private readonly Action<object> exacute;
        private readonly Func<object,bool> canExacute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; } 
            remove {CommandManager.RequerySuggested -= value;  } 
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            exacute = execute;
            canExacute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return this.canExacute == null || this.canExacute(parameter); 
        }

        public void Execute(object parameter) {
        
            this.exacute(parameter);
        }

    }
}
