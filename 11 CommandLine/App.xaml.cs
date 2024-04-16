using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace _11_CommandLine
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {        
        private void Application_Startup(object sender, StartupEventArgs e)
        {            
            MainWindow wnd = new MainWindow();
            if (e.Args.Length>0)
            {
                wnd.lstParameters.ItemsSource = e.Args;
            }
            
            wnd.Show();
        }
    }
}
