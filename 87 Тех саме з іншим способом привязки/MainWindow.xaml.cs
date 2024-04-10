using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WpfApp35
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PersonModel Том;
        public MainWindow()
        {
            InitializeComponent();

            Том = new PersonModel();
            this.DataContext = Том;
        }
    }

    public class PersonModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
    }
}
