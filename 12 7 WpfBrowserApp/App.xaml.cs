using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace _12_7_WpfBrowserApp
{ 
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_NavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            if (e.Exception is System.Net.WebException)
            {
                MessageBox.Show("Website " + e.Uri.ToString() + " cannot be reached.", "NavigationFailed");
                
                e.Handled = true;
            }
        }
    }
}
