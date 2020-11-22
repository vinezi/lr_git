using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClassLibrary2;

namespace p1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Net(object sender, RoutedEventArgs e)
        {
            helper Net = new helper(Tb1.Text, Tb2.Text);
            if (!Net.IsEmpty())
            {
                answ.Content = Net.GetLog();
            }
        } 

        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            Tb1.Clear();
            Tb2.Clear();
            helper Clear = new helper(Tb1.Text, Tb2.Text);
            answ.Content = Clear.GetClear();
        }

        private void Tb1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Regex.IsMatch(Tb1.Text, "[^0-9-,]"))
            {
                Tb1.Text = Tb1.Text.Remove(Tb1.Text.Length - 1);
                Tb1.SelectionStart = Tb1.Text.Length;
            }
        }

        private void Tb2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Regex.IsMatch(Tb2.Text, "[^0-9-,]"))
            {
                Tb2.Text = Tb2.Text.Remove(Tb2.Text.Length - 1);
                Tb2.SelectionStart = Tb2.Text.Length;
            }
        }

        private void Button_Click_Change(object sender, RoutedEventArgs e)
        {
            string temp = Tb1.Text;
            Tb1.Text = Tb2.Text;
            Tb2.Text = temp;
        }
    }
}
