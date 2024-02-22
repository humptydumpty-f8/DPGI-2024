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

namespace _3._15.Програмне_керування_DocPanel
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DockPanel dockPanel;
        Label lbl;
        TextBox txt;
        Button btn;

        public MainWindow()
        {
            InitializeComponent();
            
            dockPanel = new DockPanel();            

            Border border = new Border()
            {
                BorderThickness = new Thickness(5),
                BorderBrush = Brushes.Red,
                CornerRadius = new CornerRadius(10)
            };

            lbl = new Label()
            {
                Content = "Login:",
                FontWeight = FontWeights.Bold
            };

            txt = new TextBox()
            {
                FontStyle = FontStyles.Italic,
                Foreground = Brushes.Brown                               
            };

            btn = new Button()
            {
                Content = "Ok!"                
            };

            dockPanel.Children.Add(lbl);
            dockPanel.LastChildFill = false;

            DockPanel.SetDock(lbl, Dock.Top);

            dockPanel.Children.Add(txt);
            DockPanel.SetDock(txt, Dock.Top);

            dockPanel.Children.Add(btn);
            DockPanel.SetDock(btn, Dock.Bottom);

            border.Child = dockPanel;

            grid.Children.Add(border);

            btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            dockPanel.Children.Remove(lbl);
            dockPanel.Children.Remove(txt);
            dockPanel.Children.Remove(btn);

            TextBlock tbl = new TextBlock()
            {
                Text = "Login entry blocked!",
                FontSize = 18,
                FontWeight=FontWeights.ExtraBold,
                //VerticalAlignment = VerticalAlignment.Center,
                Background=Brushes.Red,
                Foreground=Brushes.White
            };
            
            dockPanel.Children.Add(tbl);
        }
    }
}
