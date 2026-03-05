using System;
using System.ComponentModel;
using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace TestApp
{
    public class TestViewModel : Property
    {
        private int _count;
        public int Count
        {
            get => _count;
            set
            {
                _count = value;
                OnPropertyChanged();

            }
        }

        public RCommand CountCommand { get; }
        public void countExecute(object parameter) { Count++; System.Diagnostics.Debug.WriteLine($"Count изменен: {Count}"); }
        public bool canCountExecute(object paranmeter) { return true; }

        public ViewModel()
        {

            CountCommand = new RCommand(countExecute, canCountExecute);

        }
    }