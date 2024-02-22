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

namespace _3._7.Теж_що_в_попередньому_зддаванням_сплітера_і_обрамлення
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String titleBuff;
        double widthBuff;
        double heigtBuff;

        public MainWindow()
        {
            InitializeComponent();

            titleBuff = this.Title;
            widthBuff = this.Width;
            heigtBuff = this.Height;
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            this.Title = txtTitle.Text;
            this.Width = Convert.ToDouble(txtWidth.Text);
            this.Height = Convert.ToDouble(txtHeigt.Text);
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Title = titleBuff;
            this.Width = widthBuff;
            this.Height = heigtBuff;
        }
    }
}
