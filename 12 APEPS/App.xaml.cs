using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace _12_APEPS
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_NavigationFailed(object sender, System.Windows.Navigation.NavigationFailedEventArgs e)
        {
            if (e.Exception is System.Net.WebException)
            {
                MessageBox.Show("Website " + e.Uri.ToString() + " cannot be reached.", "NavigationFailed");

                // Нейтралізувати помилку, щоб додаток продовжив свою роботу,
                e.Handled = true;
            }
        }

        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
                // Запобігання обробці необроблених виключень за умовчанням
                e.Handled = true;
            
        }
    }
}
