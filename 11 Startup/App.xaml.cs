using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Media;
using System.Threading.Tasks;
using System.Windows;

namespace _11_Startup
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //SoundPlayer відтворює тільки файли *.wav!
            //Ці файли додаються в проект і для властивості Копіювати в вихідний каталог вибирається Завжди копіювати
            SoundPlayer player = new SoundPlayer(@"Sound\ny0nqq.wav"); 
            player.Play();
        }
    }
}
