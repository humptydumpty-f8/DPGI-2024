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

namespace WpfApp10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Binding binding = new Binding();
            binding.ElementName = "textBox"; // елемент-джерело
            binding.Path = new PropertyPath("Text"); // властивість елемента-джерела
            textBlock.SetBinding(TextBlock.TextProperty, binding); // установка прив'язки для елемента-приймача
        }
    }
}
