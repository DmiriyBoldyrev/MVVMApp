using System;
using System.Threading.Tasks;
using System.Windows.Input;

public class AsyncRCommand<T> : ICommand
{
    private readonly Func<T, Task> _execute;
    private readonly Predicate<T> _canExecute;
    private bool _isExecuting;

    public AsyncRCommand(Func<T, Task> execute, Predicate<T> canExecute = null)
    {
        _execute = execute ?? throw new ArgumentNullException(nameof(execute));
        _canExecute = canExecute;
    }

    public bool CanExecute(object parameter)
    {
        if (_isExecuting) return false;
        if (_canExecute == null) return true;

        // Пытаемся привести параметр к типу T
        if (parameter is T typedParameter)
            return _canExecute(typedParameter);

        // Если параметр null и T - ссылочный тип
        if (parameter == null && !typeof(T).IsValueType)
            return _canExecute(default(T));

        return false;
    }

    public async void Execute(object parameter)
    {
        if (!CanExecute(parameter))
            return;

        try
        {
            _isExecuting = true;
            RaiseCanExecuteChanged();

            T typedParameter = default(T);
            if (parameter is T tp)
                typedParameter = tp;
            // Если параметр null и T - ссылочный тип
            else if (parameter == null && !typeof(T).IsValueType)
                typedParameter = default(T);
            else
                return; // Не можем привести параметр

            await _execute(typedParameter);
        }
        finally
        {
            _isExecuting = false;
            RaiseCanExecuteChanged();
        }
    }

    public event EventHandler CanExecuteChanged;
    public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
}