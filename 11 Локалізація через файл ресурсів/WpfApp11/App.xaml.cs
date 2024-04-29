using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Globalization;
using System.Windows;

namespace WpfApp11
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");
        }

        //App()
        //{
        //    Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");
        //}
    }
}
