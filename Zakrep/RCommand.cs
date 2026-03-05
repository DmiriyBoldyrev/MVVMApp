using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Zakrep
{
    public class RCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Func<object, bool> _CanExecute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _CanExecute = canExecute;
        }

        public void Execute(object parameter)
        {

            this._execute(parameter);
        }
        public bool CanExecute(object parameter)
        {

            return this._CanExecute == null || this._CanExecute(parameter);
        }
    }
}
