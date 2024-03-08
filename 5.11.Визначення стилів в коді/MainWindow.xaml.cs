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

namespace WpfApp8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Базовий стиль
            Style BigFontButtonStyle = new Style();
            BigFontButtonStyle.Setters.Add(new Setter { Property = Control.FontFamilyProperty, Value = new FontFamily("Times New Roman") });
            BigFontButtonStyle.Setters.Add(new Setter { Property = Control.FontSizeProperty, Value = 18.0 });
            BigFontButtonStyle.Setters.Add(new Setter { Property = Control.FontWeightProperty, Value = FontWeights.Bold });
            //Унаслідований стиль для TextBox
            Style TextBoxStyle = new Style(typeof(TextBox), BigFontButtonStyle);
            TextBoxStyle.Setters.Add(new Setter { Property = ForegroundProperty, Value = new SolidColorBrush(Colors.White) });
            TextBoxStyle.Setters.Add(new Setter { Property = BackgroundProperty, Value = new SolidColorBrush(Colors.DarkBlue) });
            TextBoxStyle.Setters.Add(new Setter { Property = BorderThicknessProperty, Value = new Thickness(2) });
            TextBoxStyle.Setters.Add(new Setter { Property = BorderBrushProperty, Value = new SolidColorBrush(Colors.Red) });

            txtName.Style = TextBoxStyle;
            txtSurname.Style = TextBoxStyle;

            btn.Style = BigFontButtonStyle;
        }
    }
}
