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

namespace ISRPO_Palashicheva_PR11
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            listbox1.Items.Add(textbox1.Text);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            listbox1.Items.Remove(listbox1.SelectedItem);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            listbox1.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("Content", System.ComponentModel.ListSortDirection.Ascending));
        }

        private void Zd2_Click(object sender, RoutedEventArgs e)
        {
            Window a = new Window1();
            a.Show();
        }


        private void Prakt_Click(object sender, RoutedEventArgs e)
        {
            Window a = new Window2();
            a.Show();
        }

        private void Praktika_Click(object sender, RoutedEventArgs e)
        {
            Window a = new Window3();
            a.Show();
        }

        private void Individ_Click(object sender, RoutedEventArgs e)
        {
            Window a = new Window4();
            a.Show();
        }
    }
}
