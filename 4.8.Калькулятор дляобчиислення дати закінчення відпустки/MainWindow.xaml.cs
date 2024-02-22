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

namespace _4._8.Калькулятор_дляобчиислення_дати_закінчення_відпустки
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dpStart.SelectedDate = DateTime.Now;
        }

        private void dpStart_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbDuration.SelectedItem == null)
            {
                defaultItem.IsSelected = true;
            }
            string item = ((ComboBoxItem)(cmbDuration.SelectedItem)).Content.ToString();
            dpFinish.SelectedDate = ((DateTime)(dpStart.SelectedDate)).AddDays(Convert.ToDouble(item));
        }



        private void cmbDuration_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            string item = ((ComboBoxItem)(cmbDuration.SelectedItem)).Content.ToString();
            dpFinish.SelectedDate = ((DateTime)(dpStart.SelectedDate)).AddDays(Convert.ToDouble(item));
        }
    }
}
