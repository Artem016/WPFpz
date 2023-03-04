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

namespace Wpfpz25
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double velue1, velue2;
        char action;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            wrot.Text = "котик";
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            wrot.Text += "7";
        }

        private void equel_Click(object sender, RoutedEventArgs e)
        {
            velue2 = double.Parse(wrot.Text);
            if(action == '+')
            {
                wrot.Text = Convert.ToString(velue1 + velue2);
            }
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            if(wrot.Text != null)
            {
                action = Convert.ToChar(plus.Content);
                velue1 = double.Parse(wrot.Text);
                wrot.Text = null;
            }
        }
    }
}
