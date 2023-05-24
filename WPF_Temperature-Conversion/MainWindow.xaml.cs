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

namespace WPF_Temperature_Conversion
{
    public partial class MainWindow : Window
    {
        // Variables for calculation
        private double userNumber = 0;
        private double fValue = 0;
        private double cValue = 0;
        private double kValue = 0;

        // Error Messages

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateResults_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(txtbox_userInput.Text, out userNumber))
            {
                MessageBox.Show("Please enter a valid number!");
            }
            else
            {
                Fahrenheit(userNumber);
                Celsius(userNumber);
                Kelvin(userNumber);
            }
        }

        private void Fahrenheit(double input )
        {
            fValue = input;
            cValue = (input - 32) / 1.8;
            kValue = (((input - 32) * 5) / 9) + 273.15;

            txtblk_userInputFahrenheit.Text = fValue.ToString("N2") + "F";
            txtblk_resultFtoC.Text= cValue.ToString("N2") + "C";
            txtblk_resultFtoK.Text= kValue.ToString("N2") + "K";
        }

        private void Celsius(double input)
        {
            cValue = input;
            fValue = (input * 1.8) + 32;
            kValue = input + 273.15;

            txtblk_userInputCelsius.Text = cValue.ToString("N2") + "C";
            txtblk_resultCtoF.Text = fValue.ToString("N2") + "F";
            txtblk_resultCtoK.Text = kValue.ToString("N2") + "K";
        }

        private void Kelvin(double input)
        {
            kValue = input;
            cValue = input - 273.15; ;
            fValue = ((input - 273.15) * 1.8) + 32;

            txtblk_userInputKelvin.Text = kValue.ToString("N2") + "K";
            txtblk_resultKtoF.Text = fValue.ToString("N2") + "F";
            txtblk_resultKtoC.Text = cValue.ToString("N2") + "C";
        }
    }
}
