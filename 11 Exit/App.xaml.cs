using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace _11_Exit
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MessageBox.Show("Run the app?", "StartUp");            
        }

        private void Application_LoadCompleted(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            MessageBox.Show("The application has been successfully downloaded!", "LoadCompleted");
        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {
            MessageBox.Show("By-by!", "Exit");
        }

        private void Application_Activated(object sender, EventArgs e)
        {
            //MessageBox.Show("App is activated!", "Activated");
        }

        private void Application_Deactivated(object sender, EventArgs e)
        {
            MessageBox.Show("App is deactivated!", "Deactivated");
        }
    }
}
