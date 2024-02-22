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

namespace _4._5.Визначник_кодів_операторів_звязку___ListBox
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<MobOperator> listOperators = new List<MobOperator>();
        public struct MobOperator
        {
            public string name;
            public string codes;

            public override string ToString() { return name; }
        }
        public MainWindow()
        {
            InitializeComponent();

            MobOperator kyivstar = new MobOperator() { name = "Київстар", codes = "039, 067, 068, 096, 097, 098" };
            MobOperator vodaphone = new MobOperator() { name = "Водафон", codes = "050, 066, 095, 099" };
            MobOperator lifecell = new MobOperator() { name = "Lifecell", codes = "063, 073, 093" };
            MobOperator utel = new MobOperator() { name = "Utel", codes = "091" };
            MobOperator pEOPLEnet = new MobOperator() { name = "PEOPLEnet", codes = "092" };
            MobOperator intertelecom = new MobOperator() { name = "Iнтертелеком", codes = "089, 094" };

            listOperators.Add(kyivstar);
            listOperators.Add(vodaphone);
            listOperators.Add(lifecell);
            listOperators.Add(utel);
            listOperators.Add(pEOPLEnet);
            listOperators.Add(intertelecom);

            lbxOperators.ItemsSource = listOperators;
        }

        private void lbxOperators_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txbCodes.Text = String.Empty;
            foreach (var item in lbxOperators.SelectedItems)
            {
                txbCodes.Text += ((MobOperator)item).codes + ", ";
            }
        }
    }
}
