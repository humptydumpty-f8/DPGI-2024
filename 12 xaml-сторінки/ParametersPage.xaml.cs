﻿using System;
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

namespace _12_xaml_сторінки
{
    /// <summary>
    /// Логика взаимодействия для ParametersPage.xaml
    /// </summary>
    public partial class ParametersPage : Page
    {
        public TextBox txtBox=new HomePage().txtBox;
        public ParametersPage()
        {
            InitializeComponent();            
        }

        private void txtSize_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtBox.FontSize = double.Parse(txtSize.Text);
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content)
            {
                case "Italic":
                    txtBox.FontStyle = FontStyles.Italic;
                    break;
                case "Oblique":
                    txtBox.FontStyle = FontStyles.Oblique;
                    break;
                default:
                    txtBox.FontStyle = FontStyles.Normal;
                    break;
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            txtBox.AcceptsReturn = (bool)chkEnter.IsChecked;
            txtBox.AcceptsTab = (bool)chkTab.IsChecked;
        }
    }
}
