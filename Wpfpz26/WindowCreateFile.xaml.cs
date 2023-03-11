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
using System.Windows.Shapes;
using System.IO;

namespace Wpfpz26
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public string mainTBString;

        public Window1()
        {
            InitializeComponent();
        }

        private void CreateFileOk_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists($"C:/Users/Артем/Desktop/{NameFile.Text}.txt"))
            {
                FileStream fileStream = new FileStream($"C:/Users/Артем/Desktop/{NameFile.Text}.txt", FileMode.Open, FileAccess.Read);
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    mainTBString = reader.ReadToEnd();
                }
                
            }
            else
                File.Create($"C:/Users/Артем/Desktop/{NameFile.Text}.txt");
            this.DialogResult = true;
        }
    }
}
