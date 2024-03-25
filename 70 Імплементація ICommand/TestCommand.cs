using System;
using System.Windows;
using System.Windows.Input;

namespace _70_Імплементація_ICommand
{
    public class TestCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MessageBox.Show("Custom Command Executed!!!");
        }
    }
}
