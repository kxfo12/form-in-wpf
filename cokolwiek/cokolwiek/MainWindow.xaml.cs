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

namespace cokolwiek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Powitanie { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Powitanie = "Hi";
            DataContext = this;
        }

        private void Change_Text_Button(object sender, RoutedEventArgs e)
        {
            powitanie.Content = "The text has been changed!";
            MessageBox.Show("Do you like the change?", "Very not important question", MessageBoxButton.YesNo, MessageBoxImage.Question);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int number1 = 0, number2 = 0;
            if(int.TryParse(firstNumber.Text, out number1) && int.TryParse(secondNumber.Text, out number2))
            {
                int sum = number1 + number2;
                MessageBox.Show("Suma: " + sum);
            }
        }
    }
}
