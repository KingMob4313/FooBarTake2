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

namespace FooBarTake2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            for (int y = 1; y < 100; y++)
            {
                string outputString = string.Empty;
                int fooDivisor = 0;
                int.TryParse(FooTextBox.Text, out fooDivisor);
                int barDivisor = 0;
                int.TryParse(BarTextBox.Text, out barDivisor);
                if (y % fooDivisor == 0)
                {
                    outputString += "foo";
                }
                if (y % barDivisor == 0)
                {
                    outputString += "bar";
                }
                if ((y % fooDivisor > 0) && (y % barDivisor > 0))
                {
                    outputString = y.ToString();
                }
                OutputBox.Text += outputString + " \r\n";
            }
        }

        private void FooTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            FooTextBox.Clear();
        }

        private void BarTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            BarTextBox.Clear();
        }
    }
}