using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _11_Startup
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SoundPlayer player = new SoundPlayer(@"Sound\muzyika-vezeniya.wav");
        public MainWindow()
        {
            InitializeComponent();
            player.LoadAsync();
        }

        private void btnPlaer_Click(object sender, RoutedEventArgs e)
        {
            player.Play();
        }
    }
}
