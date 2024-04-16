using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace _11_ComLine_to_Win
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        MainWindow wnd;
        private void Application_Startup(object sender, StartupEventArgs e)
        {            
            wnd = new MainWindow();

            switch (e.Args[0])
            {
                case "WindowState=Normal":
                    wnd.WindowState = WindowState.Normal;
                    break;
                case "WindowState=Minimized":
                    wnd.WindowState = WindowState.Minimized;
                    break;
                case "WindowState=Maximized":
                    wnd.WindowState = WindowState.Maximized;
                    break;
                default:
                    MessageBox.Show("Invalid key of WindowState!");
                    break;
            }

            wnd.txtBlock.Text = wnd.WindowState.ToString();
            wnd.Show();
        }
    }
}
