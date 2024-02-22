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

namespace _3._14.Програмне_керування_WrapPanel
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TextBox txt;
        public MainWindow()
        {
            InitializeComponent();
            

            WrapPanel wrapPanel = new WrapPanel();

            Label lbl = new Label()
            {
                Content = "Login:",
                FontWeight = FontWeights.Bold
            };

            txt = new TextBox()
            {
                FontStyle = FontStyles.Italic,
                Foreground = Brushes.Brown,
                MinWidth = 50,
                Margin = new Thickness(15, 0, 15, 0)
            };

            Button btn = new Button()
            {
                Content = "Ok!",
                MinWidth = 50
            };

            wrapPanel.Children.Add(lbl);
            wrapPanel.Children.Add(txt);
            wrapPanel.Children.Add(btn);

            grid.Children.Add(wrapPanel);

            btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(string.Format("Login: {0}", txt.Text));
        }
    }
}
