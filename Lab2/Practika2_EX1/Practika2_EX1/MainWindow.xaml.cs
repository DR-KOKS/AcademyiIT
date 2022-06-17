using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practika2_EX1
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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            //part 1
            double numdob;
            if(!double.TryParse(inputTextBox.Text, out numdob))
            {
                MessageBox.Show("Please enter a double");
                return;
            }

            if (numdob <= 0)
            {
                MessageBox.Show("Please enter a positive number");
                return;
            }

            double squareRoot = Math.Sqrt(numdob);

            frameworkLabel.Content = string.Format("{0} (Using the .NET Framework)", squareRoot);

            //part 2

            decimal nubdec;
            if(!decimal.TryParse(inputTextBox.Text, out nubdec))
            {
                MessageBox.Show("Please enter a decimal");
                return;
            }

            decimal del = Convert.ToDecimal(Math.Pow(10, -28));

            decimal gues = nubdec / 2;

            decimal res = (((nubdec/gues)+gues)/2);

            while (Math.Abs(res - gues) > del)
            {
                gues = res;
                res = (((nubdec / gues) + gues) / 2);

            }

            newtonLabel.Content = string.Format("{0} (Using Newton)", res);

        }
    }
}
